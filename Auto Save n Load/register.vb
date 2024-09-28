Imports System.Xml

Public Class register
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtuser.Text = "" Or txtpass.Text = "" Or txtpass2.Text = "" Then
            MessageBox.Show("All fields are required", "System Information")
            Exit Sub
        End If

        If 6 > txtpass.Text.Length Then
            MessageBox.Show("Password length must be greater than 6 characters", "System Information")
            Exit Sub
        End If

        If txtpass.Text <> txtpass2.Text Then
            MessageBox.Show("Password did not match", "System Information")
            Exit Sub
        End If

        AddUserData(txtuser.Text.Trim(), txtpass.Text.Trim())
    End Sub

    Sub AddUserData(ByVal username As String, ByVal password As String)

        Dim doc As XmlDocument = New XmlDocument()
        doc.Load(Form1.userXML)

        Dim existingUser As XmlElement = doc.SelectSingleNode("//users/user/username[text() = '" & username & "']")
        If existingUser IsNot Nothing Then
            MessageBox.Show("User '" & username & "' already exists.", "System Information")
            Exit Sub
        End If

        password = Encrypt(password)

        Dim newUserElement As XmlElement = doc.CreateElement("user")

        Dim usernameElement As XmlElement = doc.CreateElement("username")
        usernameElement.InnerText = username
        Dim passwordElement As XmlElement = doc.CreateElement("passwordHash")
        passwordElement.InnerText = password

        newUserElement.AppendChild(usernameElement)
        newUserElement.AppendChild(passwordElement)

        doc.DocumentElement.AppendChild(newUserElement)

        doc.Save(Form1.userXML)
        MessageBox.Show("User added successfully!", "System Information")
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class