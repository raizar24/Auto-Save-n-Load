<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Button1 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DeepPink
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.White
        Button1.Location = New Point(56, 70)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 27)
        Button1.TabIndex = 15
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(12, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 17)
        Label2.TabIndex = 18
        Label2.Text = "Enter Your Password:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(12, 39)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(204, 25)
        TextBox2.TabIndex = 17
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.back
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(228, 107)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMIN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
