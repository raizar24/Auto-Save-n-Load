Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Xml

Module mods
    Function loadList(ByVal xmlName As String, ByVal Descendant As String, ByVal element As String) As List(Of String)
        Dim doc As XDocument = XDocument.Load(xmlName)
        Dim listNames As List(Of String) = doc.Descendants(Descendant).Select(Function(game) game.Element(element).Value).ToList()

        Return listNames
    End Function

    Sub CreateSymbolicLinks(ByVal xmlFile As String, ByVal destinationFolder As String)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(xmlFile)

        Dim gameNodes As XmlNodeList = xmlDoc.SelectNodes("//game")

        For Each gameNode As XmlNode In gameNodes
            Dim nameNode As XmlNode = gameNode.SelectSingleNode("name")
            Dim pathNode As XmlNode = gameNode.SelectSingleNode("path")
            Dim gameName As String = CleanStringForPath(nameNode.InnerText)
            Dim sourcePath As String = ContainsSpecialCommand(pathNode.InnerText)
            Dim folderName As String = IO.Path.GetFileName(IO.Path.GetDirectoryName(sourcePath))
            Dim targetPath As String = IO.Path.Combine(destinationFolder, gameName, folderName)

            If Not Directory.Exists(targetPath) Then
                Directory.CreateDirectory(targetPath)
            End If
            Dim sourceParentDirectory As String = IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(sourcePath))

            If Directory.Exists(sourceParentDirectory) Then
                Directory.CreateDirectory(sourceParentDirectory)
            End If

            doSymbolicLink(sourcePath, targetPath)
        Next
    End Sub

    Private Sub doSymbolicLink(ByVal sourcePath As String, ByVal targetPath As String)
        Dim command As String = "/C mklink /D """ & sourcePath & """ """ & targetPath & """"

        Dim process As New Process()
        With process.StartInfo
            .FileName = "cmd.exe"
            .Arguments = command
            .WindowStyle = ProcessWindowStyle.Hidden
            .CreateNoWindow = True
        End With

        process.Start()
        process.WaitForExit()
    End Sub

    Sub RemoveSymbolicLinks(ByVal xmlFile As String)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(xmlFile)

        Dim pathNodes As XmlNodeList = xmlDoc.SelectNodes("//path")

        For Each pathNode As XmlNode In pathNodes
            Dim sourcePath As String = ContainsSpecialCommand(pathNode.InnerText)
            If Directory.Exists(sourcePath) Then
                Directory.Delete(sourcePath, True)
            End If
        Next
    End Sub

    Function loadXML(ByVal value As String)
        Dim xDoc As XDocument = XDocument.Load("settings.xml")
        Dim xreturn As String = xDoc.Descendants(value).FirstOrDefault().Value
        Return xreturn
    End Function

    Sub saveXML(ByVal newVal As String, ByVal varLoc As String)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load("settings.xml")
        Dim node As XmlNode = xmlDoc.SelectSingleNode("/Variable/" & varLoc)
        node.InnerText = newVal
        xmlDoc.Save("settings.xml")
    End Sub

    Function checkBackSlash(ByVal path As String) As String
        If Not path.EndsWith("\") Then
            path &= "\"
        End If
        Return path
    End Function

    Function Encrypt(plainText As String) As String
        Dim reversedText As String = StrReverse(plainText)

        Dim encryptedText As String = ""
        For Each c As Char In reversedText
            encryptedText &= ChrW(AscW(c) + 4)
        Next

        Return encryptedText
    End Function

    Function Decrypt(encryptedText As String) As String
        Dim decryptedText As String = ""
        For Each c As Char In encryptedText
            decryptedText &= ChrW(AscW(c) - 4)
        Next

        decryptedText = StrReverse(decryptedText)

        Return decryptedText
    End Function

    Function ContainsSpecialCommand(input As String) As String
        Dim userProfile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim localAppData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim programData As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)

        Dim appdataRegex As New Regex("%appdata%", RegexOptions.IgnoreCase)
        Dim userProfileRegex As New Regex("%userprofile%", RegexOptions.IgnoreCase)
        Dim localAppDataRegex As New Regex("%localappdata%", RegexOptions.IgnoreCase)
        Dim programDataRegex As New Regex("%programdata%", RegexOptions.IgnoreCase)

        Dim result As String = input

        If appdataRegex.IsMatch(input) Then
            result = appdataRegex.Replace(input, appData)
        End If

        If userProfileRegex.IsMatch(input) Then
            result = userProfileRegex.Replace(result, userProfile)
        End If

        If localAppDataRegex.IsMatch(input) Then
            result = localAppDataRegex.Replace(result, localAppData)
        End If

        If programDataRegex.IsMatch(input) Then
            result = programDataRegex.Replace(result, programData)
        End If

        Return result
    End Function

    Sub CopyDirectory(ByVal sourcePath As String, ByVal destinationPath As String)
        If Directory.Exists(sourcePath) Then
            My.Computer.FileSystem.CopyDirectory(sourcePath, destinationPath, True)
        Else
            Throw New DirectoryNotFoundException("Source directory does not exist: " + sourcePath)
        End If
    End Sub

    Sub CopyFile(ByVal sourcePath As String, ByVal destinationPath As String)
        If File.Exists(sourcePath) Then
            File.Copy(sourcePath, destinationPath, True)
        Else
            Throw New FileNotFoundException("Source file does not exist: " + sourcePath)
        End If
    End Sub

    Function CleanStringForPath(ByVal input As String) As String
        Dim invalidChars As Char() = IO.Path.GetInvalidFileNameChars()
        For Each ch As Char In invalidChars
            input = input.Replace(ch, "")
        Next
        Return input
    End Function

End Module
