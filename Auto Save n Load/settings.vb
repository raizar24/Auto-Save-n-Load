Imports System.Net.Http
Imports System.Xml

Public Class settings
    Dim SaveMode As String
    Dim SaveMode2 As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        open()
        SaveMode = "add"
        txtgame.Enabled = True
        txtSavepath.Enabled = True
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox2.Items.AddRange(loadList(Form1.userXML, "user", "username").ToArray())
        ListBox1.Items.AddRange(loadList(Form1.gamesXML, "game", "name").ToArray())
    End Sub

    Sub reset()
        txtgame.Enabled = False
        txtSavepath.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        ListBox1.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        SaveMode = ""
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(loadList(Form1.gamesXML, "game", "name").ToArray())
    End Sub

    Sub reset2()
        txtUser.Enabled = False
        txtPass.Enabled = False
        btnadd2.Enabled = True
        btnedit2.Enabled = True
        btndelete2.Enabled = True
        ListBox2.Enabled = True
        btnsave2.Enabled = False
        btncancel2.Enabled = False
        SaveMode2 = ""
        ListBox2.Items.Clear()
        ListBox2.Items.AddRange(loadList(Form1.userXML, "user", "username").ToArray())
    End Sub

    Sub open()
        txtgame.Text = ""
        txtSavepath.Text = ""
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        ListBox1.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Sub open2()
        txtUser.Text = ""
        txtPass.Text = ""
        btnadd2.Enabled = False
        btnedit2.Enabled = False
        btndelete2.Enabled = False
        ListBox2.Enabled = False
        btnsave2.Enabled = True
        btncancel2.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        open()
        ListBox1.Enabled = True
        txtgame.Enabled = False
        txtSavepath.Enabled = True
        SaveMode = "edit"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        open()
        ListBox1.Enabled = True
        txtgame.Enabled = False
        txtSavepath.Enabled = False
        SaveMode = "delete"
    End Sub

    Function add(name As String, path As String, xml As String, parent As String, child As String, child2 As String, encryption As Boolean) As Boolean
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load(xml)
        Dim existing As XmlElement
        If name.Contains("'") Then
            MessageBox.Show("Game Name must not contain single quotation mark", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        existing = doc.SelectSingleNode("//" & parent & "/" & child & "[text() = '" & name & "']")
        If existing IsNot Nothing Then
            MessageBox.Show("Item '" & name & "' already exists.", "System Information")
            Return False
        End If

        Dim newElement As XmlElement = doc.CreateElement(parent)

        Dim Element As XmlElement = doc.CreateElement(child)
        Element.InnerText = name
        Dim Element2nd As XmlElement = doc.CreateElement(child2)
        If encryption Then
            path = Encrypt(path)
        End If
        Element2nd.InnerText = path

        newElement.AppendChild(Element)
        newElement.AppendChild(Element2nd)

        doc.DocumentElement.AppendChild(newElement)
        doc.Save(xml)
        Return True
    End Function

    Sub delete(gameName As String, newPath As String, filePath As String, parent As String, child As String)

        Dim doc As XDocument = XDocument.Load(filePath)
        Dim gameNode = doc.Descendants(parent).Where(Function(g) g.Element(child).Value = gameName).FirstOrDefault()

        gameNode.Remove()

        doc.Save(filePath)

    End Sub

    Sub edit(gameName As String, newPath As String, filePath As String, parent As String, child As String, child2 As String, encryption As Boolean)
        Dim doc As XDocument = XDocument.Load(filePath)

        Dim gameNode = doc.Descendants(parent).Where(Function(g) g.Element(child).Value = gameName).FirstOrDefault()
        If encryption Then
            newPath = Encrypt(newPath)
        End If
        gameNode.Element(child2).Value = newPath

        doc.Save(filePath)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As DialogResult
        Dim name = txtgame.Text.Trim
        Dim path = txtSavepath.Text.Trim

        If SaveMode = "add" Then
            If name = "" Or path = "" Then
                MessageBox.Show("All fields are required", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        If SaveMode = "edit" Or SaveMode = "delete" Then
            If name = "" Then
                MessageBox.Show("Please select a game to " & SaveMode, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        result = MessageBox.Show("Do you want to " & txtgame.Text.Trim & " to be " & SaveMode & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If SaveMode = "add" Then
            If result = DialogResult.Yes Then
                Dim success As Boolean = add(name, path, Form1.gamesXML, "game", "name", "path", False)
                If Not success Then
                    Exit Sub
                End If
                MessageBox.Show("Save Complete", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save Cancelled", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        If SaveMode = "edit" Then
            If result = DialogResult.Yes Then
                edit(name, path, Form1.gamesXML, "game", "name", "path", False)
                MessageBox.Show("Save Complete", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save Cancelled", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        If SaveMode = "delete" Then
            If result = DialogResult.Yes Then
                delete(name, path, Form1.gamesXML, "game", "name")
                MessageBox.Show("Deletion Complete", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Deltion Cancelled", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        reset()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        reset()
    End Sub

    Private Sub btnadd2_Click(sender As Object, e As EventArgs) Handles btnadd2.Click
        open2()
        SaveMode2 = "add"
        txtUser.Enabled = True
        txtPass.Enabled = True
    End Sub

    Private Sub btnedit2_Click(sender As Object, e As EventArgs) Handles btnedit2.Click
        open2()
        ListBox2.Enabled = True
        txtUser.Enabled = False
        txtPass.Enabled = True
        SaveMode2 = "edit"
    End Sub

    Private Sub btndelete2_Click(sender As Object, e As EventArgs) Handles btndelete2.Click
        open2()
        ListBox2.Enabled = True
        txtUser.Enabled = False
        txtPass.Enabled = False
        SaveMode2 = "delete"
    End Sub

    Private Sub btnsave2_Click(sender As Object, e As EventArgs) Handles btnsave2.Click
        Dim result As DialogResult
        Dim name = txtUser.Text.Trim
        Dim path = txtPass.Text.Trim

        If SaveMode2 = "add" Then
            If name = "" Or path = "" Then
                MessageBox.Show("All fields are required", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        If SaveMode2 = "edit" Or SaveMode2 = "delete" Then
            If name = "" Then
                MessageBox.Show("Please select a game to " & SaveMode2, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        result = MessageBox.Show("Do you want to " & name & " to be " & SaveMode2 & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If SaveMode2 = "add" Then
            If result = DialogResult.Yes Then
                Dim success As Boolean = add(name, path, Form1.userXML, "user", "username", "passwordHash", True)
                If Not success Then
                    Exit Sub
                End If
                MessageBox.Show("Save Complete", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save Cancelled", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        If SaveMode2 = "edit" Then
            If result = DialogResult.Yes Then
                edit(name, path, Form1.userXML, "user", "username", "passwordHash", True)
                MessageBox.Show("Save Complete", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save Cancelled", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        If SaveMode2 = "delete" Then
            If result = DialogResult.Yes Then
                delete(name, path, Form1.userXML, "user", "username")
                MessageBox.Show("Deletion Complete", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Deltion Cancelled", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        reset2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doc As XDocument = XDocument.Load(Form1.adminXML)
        Dim password = Encrypt(NewAdminPassword.Text.Trim())
        doc.<passwordHash>.Value = password
        doc.Save(Form1.adminXML)
        MessageBox.Show("Admin Password Change Successful", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        NewAdminPassword.Clear()
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim selectedItem As String = ListBox1.SelectedItem
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load(Form1.gamesXML)
        selectedItem = selectedItem
        Dim xpathExpression = $"/games/game[name='{selectedItem}']/path"

        If xpathExpression.Equals(String.Empty) Then
            Exit Sub
        End If
        Dim pathNode As XmlNode = doc.SelectSingleNode(xpathExpression)

        txtgame.Text = ListBox1.SelectedItem
        If Not pathNode Is Nothing Then
            txtSavepath.Text = pathNode.InnerText
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim selectedItem As String = ListBox2.SelectedItem
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load(Form1.userXML)
        selectedItem = CleanStringForPath(selectedItem)
        Dim xpathExpression = $"/users/user[username='{selectedItem}']/passwordHash"
        Dim pathNode As XmlNode = doc.SelectSingleNode(xpathExpression)
        txtUser.Text = ListBox2.SelectedItem
        If Not pathNode Is Nothing Then
            Dim node = Decrypt(pathNode.InnerText)
            txtPass.Text = node
        End If
    End Sub


    Sub updateXML()
        Dim localFilePath As String = Form1.gamesXML
        Dim githubRawUrl As String = "https://raw.githubusercontent.com/raizar24/Auto-Save-n-Load/refs/heads/master/Auto%20Save%20n%20Load/games.xml"
        Dim rawXml As String = DownloadRawXml(githubRawUrl)
        Dim localXml As XDocument = XDocument.Load(localFilePath)
        Dim githubXml As XDocument = XDocument.Parse(rawXml)

        UpdateLocalXml(localXml, githubXml)
        localXml.Save(localFilePath)
    End Sub

    Function DownloadRawXml(url As String) As String
        Using client As New HttpClient()
            Return client.GetStringAsync(url).Result
        End Using
    End Function

    Sub UpdateLocalXml(localXml As XDocument, githubXml As XDocument)
        Dim localRoot As XElement = localXml.Root
        Dim githubRoot As XElement = githubXml.Root

        For Each githubGame As XElement In githubRoot.Elements("game")
            Dim localGame As XElement = localRoot.Elements("game").FirstOrDefault(Function(e) e.Element("name")?.Value = githubGame.Element("name")?.Value)

            If localGame IsNot Nothing Then
                localGame.Element("path")?.SetValue(githubGame.Element("path")?.Value)
            Else
                localRoot.Add(githubGame)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result = MessageBox.Show("Do you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            updateXML()
            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(loadList(Form1.gamesXML, "game", "name").ToArray())
            MessageBox.Show("Game List updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class