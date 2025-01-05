Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Form1
    Dim username As String = Environment.MachineName.ToUpper
    Public serverLocation As String = EnsureTrailingSlash(loadXML("sharedFolder"))
    Public userXML As String = Path.Combine(serverLocation, "users.xml")
    Public gamesXML As String = Path.Combine(serverLocation, "games.xml")
    Public adminXML As String = Path.Combine(serverLocation, "admin.xml")
    Dim currentUser As String = Path.Combine(serverLocation, username)
    Dim userSession As String = Path.Combine(Path.GetTempPath(), "session.txt")

    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(hWnd As IntPtr) As Boolean
    End Function

    Private Const SW_SHOW As Integer = 5
    Private Const SW_RESTORE As Integer = 9
    Private Const SW_NORMAL As Integer = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentProcess As Process = Process.GetCurrentProcess()
        Dim runningProcesses As Process() = Process.GetProcessesByName(currentProcess.ProcessName)
        For Each process As Process In runningProcesses
            If process.Id <> currentProcess.Id Then
                If process.MainWindowHandle <> IntPtr.Zero Then
                    Show()
                    SetForegroundWindow(process.MainWindowHandle)
                End If
                MessageBox.Show("Program already running.", "System Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
                Return
            End If
        Next
        StartPosition = FormStartPosition.Manual
        Dim xValue = Screen.PrimaryScreen.Bounds.Width - 300
        Dim yValue = Screen.PrimaryScreen.Bounds.Height - 450
        Location = New Point(xValue, yValue)
        Try
            If Not CheckServerAvailability() Then Exit Sub
            If Not File.Exists(userXML) Then
                CopyFile("users.xml", userXML)
            End If
            If Not File.Exists(gamesXML) Then
                CopyFile("games.xml", gamesXML)
            End If
            lblCurrentUser.Text = username
            Directory.CreateDirectory(currentUser)
            UpdateSymbolicLinks()
            CheckCurrentUser()
        Catch ex As Exception
            MessageBox.Show($"Please run this program as administrator: {ex.Message}",
                                "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not CheckServerAvailability() Then Exit Sub

        Dim myUserName As String = txtUserName.Text.Trim()
        Dim passwordHash As String = Encrypt(txtPassword.Text)

        Dim doc = XDocument.Load(userXML)
        Dim isValidUser = (From user In doc.Descendants("user")
                           Where user.Element("username").Value.Equals(myUserName, StringComparison.OrdinalIgnoreCase) AndAlso
                               user.Element("passwordHash").Value.Equals(passwordHash)
                           Select user).Any()

        If isValidUser Then
            username = myUserName.ToUpper
            lblCurrentUser.Text = username
            Directory.CreateDirectory(currentUser)
            UpdateSymbolicLinks()

            If File.Exists(userSession) Then File.Delete(userSession)
            File.WriteAllText(userSession, username)

            checkCurrentUser()
            Panel1.Visible = True
            Panel1.Location = New Point(8, 147)
            MessageBox.Show("Login Successful", "System Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Text = String.Empty
            txtUserName.Text = String.Empty
        Else
            MessageBox.Show("Username or Password is incorrect", "System Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result = MessageBox.Show("Do you want to logout?", "Confirmation",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            lblCurrentUser.Text = Environment.MachineName
            username = Environment.MachineName
            currentUser = Path.Combine(serverLocation, username)
            UpdateSymbolicLinks()

            If File.Exists(userSession) Then File.Delete(userSession)
            checkCurrentUser()
            Panel1.Visible = False
        End If
    End Sub
    Private Sub UpdateSymbolicLinks()
        If Not IsServerEnvironment(serverLocation) Then
            currentUser = Path.Combine(serverLocation, username)
            RemoveSymbolicLinks(gamesXML)
            CreateSymbolicLinks(gamesXML, currentUser)
        Else
            Dim settings As New Settings
            settings.ShowDialog()
            Close()
        End If
    End Sub
    Private Sub CheckCurrentUser()
        If username.Equals(Environment.MachineName) Then
            lblUser.Text = "PUBLIC SAVE"
        Else
            lblUser.Text = "CURRENT USER"
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Hide()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not CheckServerAvailability() Then Exit Sub
        Dim register As New register()
        register.ShowDialog()
    End Sub
    Private Function CheckServerAvailability() As Boolean
        If Not Directory.Exists(serverLocation) Then
            MessageBox.Show("Shared folder cannot be accessed. Folder access denied: " & serverLocation,
                            "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Show()
        WindowState = FormWindowState.Normal
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Show()
        WindowState = FormWindowState.Normal
    End Sub
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Application.Exit()
    End Sub
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Function IsServerEnvironment(ByVal serverLoc As String) As Boolean

        Dim isDeveloperMode As Boolean = Environment.GetEnvironmentVariable("DEVELOPER_MODE") = "true"
        If isDeveloperMode Then
            Button1.Visible = True
            Return False
        End If

        Try
            Dim regex As New Regex("\\\\(?<name>[^\\]+)\\")
            Dim match As Match = regex.Match(serverLoc)
            Dim server As String = match.Groups("name").Value

            Dim localIPs As List(Of String) = GetLocalIPAddresses()

            Dim computerName As String = Environment.MachineName
            If localIPs.Contains(server, StringComparer.OrdinalIgnoreCase) Then
                Return True
            ElseIf server.Equals(computerName, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If

            Return False
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GetLocalIPAddresses() As List(Of String)
        Dim ipAddresses As New List(Of String)()
        Dim host As String = Dns.GetHostName()
        Dim addresses As IPAddress() = Dns.GetHostAddresses(host)

        For Each ip As IPAddress In addresses
            If ip.AddressFamily = AddressFamily.InterNetwork Then
                ipAddresses.Add(ip.ToString())
            End If
        Next

        If ipAddresses.Count = 0 Then
            Throw New Exception("No network adapters with an IPv4 address in the system")
        End If

        Return ipAddresses
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim settings As New Settings
        settings.ShowDialog()
    End Sub
End Class
