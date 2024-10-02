Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.SqlServer

Public Class Form1
    Dim username As String = Environment.MachineName.ToUpper
    Public serverLocation As String = checkBackSlash(loadXML("sharedFolder"))
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim currentProcess As Process = Process.GetCurrentProcess()
        Dim runningProcess As Process() = Process.GetProcessesByName(currentProcess.ProcessName)

        For Each process As Process In runningProcess
            If process.Id <> currentProcess.Id Then
                ShowWindow(process.MainWindowHandle, SW_RESTORE)
                SetForegroundWindow(process.MainWindowHandle)
                MessageBox.Show("Program already running.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
        Next

        Me.StartPosition = FormStartPosition.Manual
        Dim xValue = Screen.PrimaryScreen.Bounds.Width - 300
        Dim yValue = Screen.PrimaryScreen.Bounds.Height - 500
        Me.Location = New Point(xValue, yValue)

        Try
            If Not CheckServerAvailability() Then
                Exit Sub
            End If
            If Not File.Exists(userXML) Then
                CopyFile("users.xml", userXML)
            End If

            If Not File.Exists(gamesXML) Then
                CopyFile("games.xml", gamesXML)
            End If
            If Not File.Exists(adminXML) Then
                CopyFile("admin.xml", adminXML)
            End If
            If Not checkSession() Then
                lblCurrentUser.Text = username
                If Not Directory.Exists(currentUser) Then
                    Directory.CreateDirectory(currentUser)
                End If
                UpdateSymbolicLinks()
            End If
            checkCurrentUser()
        Catch ex As Exception
            ShowError("Please run this program as administrator", ex)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not CheckServerAvailability() Then
            Exit Sub
        End If

        Dim myUserName As String = txtUserName.Text.Trim()
        Dim passwordHash As String = Encrypt(txtPassword.Text)

        If ValidateUser(myUserName, passwordHash) Then
            username = myUserName.ToUpper
            lblCurrentUser.Text = username

            If Not Directory.Exists(currentUser) Then
                Directory.CreateDirectory(currentUser)
            End If
            UpdateSymbolicLinks()
            CreateSession()
            checkCurrentUser()
            MessageBox.Show("Login Successful", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Text = String.Empty
            txtUserName.Text = String.Empty
        Else
            MessageBox.Show("Username or Password is incorrect", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            ResetToDefaultUser()
            DeleteSession()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not CheckServerAvailability() Then
            Exit Sub
        End If
        Dim register As New register()
        register.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If Not CheckServerAvailability() Then
            Exit Sub
        End If
        Dim admin As New admin()
        admin.ShowDialog()
    End Sub

    Private Function CheckServerAvailability() As Boolean
        If Not Directory.Exists(serverLocation) Then
            MessageBox.Show("Shared folder cannot be accessed. Folder access denied: " & serverLocation, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function ValidateUser(userName As String, passwordHash As String) As Boolean
        Dim doc = XDocument.Load(userXML)
        Return (From user In doc.Descendants("user")
                Where user.Element("username").Value.Equals(userName, StringComparison.OrdinalIgnoreCase) AndAlso
                      user.Element("passwordHash").Value.Equals(passwordHash)
                Select user).Any()
    End Function

    Private Sub UpdateSymbolicLinks()
        currentUser = Path.Combine(serverLocation, username)
        RemoveSymbolicLinks(gamesXML)
        CreateSymbolicLinks(gamesXML, currentUser)
    End Sub

    Private Sub ResetToDefaultUser()
        lblCurrentUser.Text = Environment.MachineName
        username = Environment.MachineName
        currentUser = Path.Combine(serverLocation, username)
        UpdateSymbolicLinks()
    End Sub

    Private Function checkSession() As Boolean
        If File.Exists(userSession) Then
            username = File.ReadAllText(userSession).Trim()
            currentUser = Path.Combine(serverLocation, username)
            lblCurrentUser.Text = username
            Return True
        End If
        Return False
    End Function

    Private Sub CreateSession()
        If File.Exists(userSession) Then
            File.Delete(userSession)
        End If
        File.WriteAllText(userSession, username)
    End Sub

    Private Sub DeleteSession()
        If File.Exists(userSession) Then
            File.Delete(userSession)
        End If
    End Sub

    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub checkCurrentUser()
        If username.Equals(Environment.MachineName) Then
            lblUser.Text = "PUBLIC SAVE"
        Else
            lblUser.Text = "CURRENT USER"
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Application.Exit()
    End Sub
End Class