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
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
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
        txtUserName.Location = New Point(91, 179)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(181, 23)
        txtUserName.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.Info
        txtPassword.Location = New Point(91, 209)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(181, 23)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.HotTrack
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = SystemColors.ControlLightLight
        btnLogin.Location = New Point(12, 243)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(266, 47)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.DarkGreen
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.ForeColor = Color.WhiteSmoke
        btnRegister.Location = New Point(65, 296)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(156, 30)
        btnRegister.TabIndex = 4
        btnRegister.Text = "Create a new account"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 5
        Label1.Text = "User Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' lblCurrentUser
        ' 
        lblCurrentUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblCurrentUser.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblCurrentUser.Location = New Point(9, 96)
        lblCurrentUser.Name = "lblCurrentUser"
        lblCurrentUser.Size = New Size(263, 47)
        lblCurrentUser.TabIndex = 7
        lblCurrentUser.Text = "Label3"
        lblCurrentUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblUser.Location = New Point(81, 143)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(113, 14)
        lblUser.TabIndex = 8
        lblUser.Text = "CURRENT USER"
        lblUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(23, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(249, 28)
        Label3.TabIndex = 9
        Label3.Text = "OFFLINE SAVE GAME TOOL"
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = SystemColors.HotTrack
        btnlogout.FlatAppearance.BorderSize = 0
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnlogout.ForeColor = SystemColors.ControlLightLight
        btnlogout.Location = New Point(99, 332)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(83, 39)
        btnlogout.TabIndex = 10
        btnlogout.Text = "LOG OUT"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' btnSettings
        ' 
        btnSettings.Location = New Point(9, 12)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(75, 23)
        btnSettings.TabIndex = 13
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(287, 391)
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
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.Manual
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

End Class
