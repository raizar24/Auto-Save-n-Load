<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button3 = New Button()
        Button2 = New Button()
        btnCancel = New Button()
        btnSave = New Button()
        ListBox1 = New ListBox()
        Label2 = New Label()
        Label1 = New Label()
        txtSavepath = New TextBox()
        btnDelete = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        txtgame = New TextBox()
        TabPage2 = New TabPage()
        btncancel2 = New Button()
        btnsave2 = New Button()
        ListBox2 = New ListBox()
        Label3 = New Label()
        Label4 = New Label()
        txtPass = New TextBox()
        btndelete2 = New Button()
        btnedit2 = New Button()
        btnadd2 = New Button()
        txtUser = New TextBox()
        TabPage3 = New TabPage()
        CheckBox1 = New CheckBox()
        Label7 = New Label()
        Label6 = New Label()
        txtCnewpass = New TextBox()
        txtOldPass = New TextBox()
        Button1 = New Button()
        Label5 = New Label()
        txtNewpass = New TextBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(653, 421)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.back
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(Button3)
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(btnCancel)
        TabPage1.Controls.Add(btnSave)
        TabPage1.Controls.Add(ListBox1)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(txtSavepath)
        TabPage1.Controls.Add(btnDelete)
        TabPage1.Controls.Add(btnEdit)
        TabPage1.Controls.Add(btnAdd)
        TabPage1.Controls.Add(txtgame)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(645, 393)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Game management"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(395, 346)
        Button3.Name = "Button3"
        Button3.Size = New Size(119, 41)
        Button3.TabIndex = 30
        Button3.Text = "Create game path Back-up"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(520, 346)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 41)
        Button2.TabIndex = 29
        Button2.Text = "Update Game List from Github"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.DeepPink
        btnCancel.Enabled = False
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.White
        btnCancel.Image = My.Resources.Resources.cancel
        btnCancel.Location = New Point(438, 230)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(114, 79)
        btnCancel.TabIndex = 28
        btnCancel.Text = "Cancel"
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DeepPink
        btnSave.Enabled = False
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Image = My.Resources.Resources.floppy_disc
        btnSave.Location = New Point(318, 230)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(114, 79)
        btnSave.TabIndex = 27
        btnSave.Text = "Save"
        btnSave.TextImageRelation = TextImageRelation.ImageAboveText
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.AllowDrop = True
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(15, 14)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(211, 364)
        ListBox1.Sorted = True
        ListBox1.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(230, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 17)
        Label2.TabIndex = 25
        Label2.Text = "Save Path:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(230, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 17)
        Label1.TabIndex = 24
        Label1.Text = "Game:"
        ' 
        ' txtSavepath
        ' 
        txtSavepath.Enabled = False
        txtSavepath.Location = New Point(309, 71)
        txtSavepath.Multiline = True
        txtSavepath.Name = "txtSavepath"
        txtSavepath.Size = New Size(270, 73)
        txtSavepath.TabIndex = 23
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.DeepPink
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.Location = New Point(496, 150)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(114, 74)
        btnDelete.TabIndex = 22
        btnDelete.Text = "Delete"
        btnDelete.TextImageRelation = TextImageRelation.ImageAboveText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.DeepPink
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.White
        btnEdit.Image = My.Resources.Resources.edit
        btnEdit.Location = New Point(376, 150)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(114, 74)
        btnEdit.TabIndex = 21
        btnEdit.Text = "Edit"
        btnEdit.TextImageRelation = TextImageRelation.ImageAboveText
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.DeepPink
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.White
        btnAdd.Image = My.Resources.Resources.add4
        btnAdd.Location = New Point(256, 150)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(114, 74)
        btnAdd.TabIndex = 20
        btnAdd.Text = "Add"
        btnAdd.TextImageRelation = TextImageRelation.ImageAboveText
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtgame
        ' 
        txtgame.Enabled = False
        txtgame.Location = New Point(309, 42)
        txtgame.Name = "txtgame"
        txtgame.Size = New Size(270, 23)
        txtgame.TabIndex = 19
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.back
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(btncancel2)
        TabPage2.Controls.Add(btnsave2)
        TabPage2.Controls.Add(ListBox2)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(txtPass)
        TabPage2.Controls.Add(btndelete2)
        TabPage2.Controls.Add(btnedit2)
        TabPage2.Controls.Add(btnadd2)
        TabPage2.Controls.Add(txtUser)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(645, 393)
        TabPage2.TabIndex = 1
        TabPage2.Text = "User Management"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btncancel2
        ' 
        btncancel2.BackColor = Color.DeepPink
        btncancel2.Enabled = False
        btncancel2.FlatStyle = FlatStyle.Popup
        btncancel2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btncancel2.ForeColor = Color.Transparent
        btncancel2.Image = My.Resources.Resources.cancel
        btncancel2.Location = New Point(433, 229)
        btncancel2.Name = "btncancel2"
        btncancel2.Size = New Size(114, 76)
        btncancel2.TabIndex = 36
        btncancel2.Text = "Cancel"
        btncancel2.TextImageRelation = TextImageRelation.ImageAboveText
        btncancel2.UseVisualStyleBackColor = False
        ' 
        ' btnsave2
        ' 
        btnsave2.BackColor = Color.DeepPink
        btnsave2.Enabled = False
        btnsave2.FlatStyle = FlatStyle.Popup
        btnsave2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave2.ForeColor = Color.Transparent
        btnsave2.Image = My.Resources.Resources.floppy_disc
        btnsave2.Location = New Point(313, 229)
        btnsave2.Name = "btnsave2"
        btnsave2.Size = New Size(114, 76)
        btnsave2.TabIndex = 35
        btnsave2.Text = "Save"
        btnsave2.TextImageRelation = TextImageRelation.ImageAboveText
        btnsave2.UseVisualStyleBackColor = False
        ' 
        ' ListBox2
        ' 
        ListBox2.AllowDrop = True
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(22, 11)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(211, 379)
        ListBox2.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(252, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 33
        Label3.Text = "Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(252, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 32
        Label4.Text = "UserName:"
        ' 
        ' txtPass
        ' 
        txtPass.Enabled = False
        txtPass.Location = New Point(323, 83)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(270, 23)
        txtPass.TabIndex = 31
        ' 
        ' btndelete2
        ' 
        btndelete2.BackColor = Color.DeepPink
        btndelete2.FlatStyle = FlatStyle.Popup
        btndelete2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete2.ForeColor = Color.Transparent
        btndelete2.Image = My.Resources.Resources.delete
        btndelete2.Location = New Point(508, 143)
        btndelete2.Name = "btndelete2"
        btndelete2.Size = New Size(114, 80)
        btndelete2.TabIndex = 30
        btndelete2.Text = "Delete"
        btndelete2.TextImageRelation = TextImageRelation.ImageAboveText
        btndelete2.UseVisualStyleBackColor = False
        ' 
        ' btnedit2
        ' 
        btnedit2.BackColor = Color.DeepPink
        btnedit2.FlatStyle = FlatStyle.Popup
        btnedit2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit2.ForeColor = Color.Transparent
        btnedit2.Image = My.Resources.Resources.edit
        btnedit2.Location = New Point(382, 143)
        btnedit2.Name = "btnedit2"
        btnedit2.Size = New Size(114, 80)
        btnedit2.TabIndex = 29
        btnedit2.Text = "Edit"
        btnedit2.TextImageRelation = TextImageRelation.ImageAboveText
        btnedit2.UseVisualStyleBackColor = False
        ' 
        ' btnadd2
        ' 
        btnadd2.BackColor = Color.DeepPink
        btnadd2.FlatStyle = FlatStyle.Popup
        btnadd2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnadd2.ForeColor = Color.Transparent
        btnadd2.Image = My.Resources.Resources.add4
        btnadd2.Location = New Point(258, 143)
        btnadd2.Name = "btnadd2"
        btnadd2.Size = New Size(114, 80)
        btnadd2.TabIndex = 28
        btnadd2.Text = "Add"
        btnadd2.TextImageRelation = TextImageRelation.ImageAboveText
        btnadd2.UseVisualStyleBackColor = False
        ' 
        ' txtUser
        ' 
        txtUser.Enabled = False
        txtUser.Location = New Point(323, 42)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(270, 23)
        txtUser.TabIndex = 27
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = My.Resources.Resources.back
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(CheckBox1)
        TabPage3.Controls.Add(Label7)
        TabPage3.Controls.Add(Label6)
        TabPage3.Controls.Add(txtCnewpass)
        TabPage3.Controls.Add(txtOldPass)
        TabPage3.Controls.Add(Button1)
        TabPage3.Controls.Add(Label5)
        TabPage3.Controls.Add(txtNewpass)
        TabPage3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage3.ForeColor = Color.White
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(645, 393)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Admin management"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(269, 204)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(122, 21)
        CheckBox1.TabIndex = 34
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(111, 94)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 17)
        Label7.TabIndex = 33
        Label7.Text = "Old Password:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(59, 161)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 17)
        Label6.TabIndex = 32
        Label6.Text = "Confirm New Password:"
        ' 
        ' txtCnewpass
        ' 
        txtCnewpass.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtCnewpass.Location = New Point(220, 161)
        txtCnewpass.Name = "txtCnewpass"
        txtCnewpass.Size = New Size(270, 25)
        txtCnewpass.TabIndex = 32
        ' 
        ' txtOldPass
        ' 
        txtOldPass.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtOldPass.Location = New Point(220, 94)
        txtOldPass.Name = "txtOldPass"
        txtOldPass.Size = New Size(270, 25)
        txtOldPass.TabIndex = 30
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DeepPink
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.White
        Button1.Location = New Point(297, 231)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 31)
        Button1.TabIndex = 28
        Button1.Text = "Save"
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(106, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 17)
        Label5.TabIndex = 27
        Label5.Text = "New Password:"
        ' 
        ' txtNewpass
        ' 
        txtNewpass.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtNewpass.Location = New Point(220, 125)
        txtNewpass.Name = "txtNewpass"
        txtNewpass.Size = New Size(270, 25)
        txtNewpass.TabIndex = 31
        ' 
        ' settings
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 445)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSavepath As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtgame As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btncancel2 As Button
    Friend WithEvents btnsave2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btndelete2 As Button
    Friend WithEvents btnedit2 As Button
    Friend WithEvents btnadd2 As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNewpass As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCnewpass As TextBox
    Friend WithEvents txtOldPass As TextBox
End Class
