<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnCancel = New Button()
        btnConfirm = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtpass2 = New TextBox()
        txtpass = New TextBox()
        txtuser = New TextBox()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(174, 159)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Location = New Point(89, 159)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(75, 23)
        btnConfirm.TabIndex = 14
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 13
        Label3.Text = "Confirm Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 12
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 11
        Label1.Text = "User ID:"
        ' 
        ' txtpass2
        ' 
        txtpass2.Location = New Point(133, 111)
        txtpass2.Name = "txtpass2"
        txtpass2.PasswordChar = "*"c
        txtpass2.Size = New Size(192, 23)
        txtpass2.TabIndex = 10
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(133, 66)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(192, 23)
        txtpass.TabIndex = 9
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(133, 24)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(192, 23)
        txtuser.TabIndex = 8
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 213)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtpass2)
        Controls.Add(txtpass)
        Controls.Add(txtuser)
        Name = "register"
        Text = "register"
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
End Class
