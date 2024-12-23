<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register
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
        btnCancel = New Button()
        btnConfirm = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtpass2 = New TextBox()
        txtpass = New TextBox()
        txtuser = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.DeepPink
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Location = New Point(188, 159)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(74, 33)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.DeepPink
        btnConfirm.FlatStyle = FlatStyle.Popup
        btnConfirm.Location = New Point(93, 159)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(79, 33)
        btnConfirm.TabIndex = 14
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 17)
        Label3.TabIndex = 13
        Label3.Text = "Confirm Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 17)
        Label2.TabIndex = 12
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 17)
        Label1.TabIndex = 11
        Label1.Text = "User ID:"
        ' 
        ' txtpass2
        ' 
        txtpass2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtpass2.Location = New Point(142, 116)
        txtpass2.Name = "txtpass2"
        txtpass2.Size = New Size(176, 25)
        txtpass2.TabIndex = 10
        ' 
        ' txtpass
        ' 
        txtpass.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtpass.Location = New Point(142, 69)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(176, 25)
        txtpass.TabIndex = 9
        ' 
        ' txtuser
        ' 
        txtuser.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtuser.Location = New Point(142, 27)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(176, 25)
        txtuser.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.eyepink
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(324, 69)
        Button1.Name = "Button1"
        Button1.Size = New Size(23, 25)
        Button1.TabIndex = 16
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.eyepink
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(324, 116)
        Button2.Name = "Button2"
        Button2.Size = New Size(23, 25)
        Button2.TabIndex = 17
        Button2.UseVisualStyleBackColor = False
        ' 
        ' register
        ' 
        AcceptButton = btnConfirm
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.back
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(359, 213)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtpass2)
        Controls.Add(txtpass)
        Controls.Add(txtuser)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpass2 As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
