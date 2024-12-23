<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnClose = New Button()
        txtUserName = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnRegister = New Button()
        Label1 = New Label()
        Label2 = New Label()
        lblCurrentUser = New Label()
        lblUser = New Label()
        Label3 = New Label()
        btnlogout = New Button()
        btnSettings = New Button()
        NotifyIcon1 = New NotifyIcon(components)
        ToolTip1 = New ToolTip(components)
        progress = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.HotPink
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(246, 8)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(32, 34)
        btnClose.TabIndex = 0
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' txtUserName
        ' 
        txtUserName.BackColor = SystemColors.Info
        txtUserName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtUserName.Location = New Point(75, 161)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(181, 25)
        txtUserName.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.Info
        txtPassword.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.Location = New Point(75, 192)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(181, 25)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.DeepPink
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = SystemColors.ControlLightLight
        btnLogin.Location = New Point(85, 232)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(123, 47)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.DeepPink
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.ForeColor = Color.WhiteSmoke
        btnRegister.Location = New Point(66, 285)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(156, 30)
        btnRegister.TabIndex = 4
        btnRegister.Text = "Create a new account"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 17)
        Label1.TabIndex = 5
        Label1.Text = "UserName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(4, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 17)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' lblCurrentUser
        ' 
        lblCurrentUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblCurrentUser.BackColor = Color.Transparent
        lblCurrentUser.Font = New Font("VALORANT", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblCurrentUser.ForeColor = Color.Plum
        lblCurrentUser.Location = New Point(12, 92)
        lblCurrentUser.Name = "lblCurrentUser"
        lblCurrentUser.Size = New Size(263, 47)
        lblCurrentUser.TabIndex = 7
        lblCurrentUser.Text = "Label3"
        lblCurrentUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUser
        ' 
        lblUser.BackColor = Color.Transparent
        lblUser.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUser.ForeColor = Color.WhiteSmoke
        lblUser.Location = New Point(85, 125)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(113, 14)
        lblUser.TabIndex = 8
        lblUser.Text = "CURRENT USER"
        lblUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("VALORANT", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Fuchsia
        Label3.Location = New Point(18, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(257, 28)
        Label3.TabIndex = 9
        Label3.Text = "SAVE MY GAME" & vbCrLf
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = Color.DeepPink
        btnlogout.FlatAppearance.BorderSize = 0
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Segoe UI Black", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnlogout.ForeColor = Color.White
        btnlogout.Location = New Point(92, 321)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(100, 28)
        btnlogout.TabIndex = 10
        btnlogout.Text = "LOG OUT"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.DeepPink
        btnSettings.BackgroundImage = My.Resources.Resources.SETTINGS
        btnSettings.BackgroundImageLayout = ImageLayout.Stretch
        btnSettings.CausesValidation = False
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = Color.Transparent
        btnSettings.Location = New Point(9, 12)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(30, 30)
        btnSettings.TabIndex = 13
        ToolTip1.SetToolTip(btnSettings, "This is an admin-only access.")
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "Auto Save N Load"
        NotifyIcon1.Visible = True
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Admin Settings"
        ' 
        ' progress
        ' 
        progress.AutoSize = True
        progress.BackColor = Color.Transparent
        progress.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        progress.ForeColor = Color.White
        progress.Location = New Point(5, 157)
        progress.Name = "progress"
        progress.Size = New Size(279, 150)
        progress.TabIndex = 14
        progress.Text = resources.GetString("progress.Text")
        progress.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.eyepink
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(261, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(23, 25)
        Button1.TabIndex = 17
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.back
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(287, 391)
        Controls.Add(Button1)
        Controls.Add(btnSettings)
        Controls.Add(btnlogout)
        Controls.Add(Label3)
        Controls.Add(lblUser)
        Controls.Add(lblCurrentUser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnRegister)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUserName)
        Controls.Add(btnClose)
        Controls.Add(progress)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCurrentUser As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    ' This is the event handler for the KeyDown event
    Private Sub btnLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyDown, txtPassword.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Trigger the Login button click
            btnLogin.PerformClick()
        End If
    End Sub

    Friend WithEvents progress As Label
    Friend WithEvents Button1 As Button
End Class
