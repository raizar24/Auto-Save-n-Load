Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Xml

Module mods
    Sub CopyFile(ByVal sourcePath As String, ByVal destinationPath As String)
        If File.Exists(sourcePath) Then
            File.Copy(sourcePath, destinationPath, True)
        Else
            Throw New FileNotFoundException("Source file does not exist: " + sourcePath)
        End If
    End Sub
    Function loadList(ByVal xmlName As String, ByVal Descendant As String, ByVal element As String) As List(Of String)
        Dim doc As XDocument = XDocument.Load(xmlName)
        Dim listNames As List(Of String) = doc.Descendants(Descendant).Select(Function(game) game.Element(element).Value).ToList()

        Return listNames
    End Function

    Sub CreateSymbolicLinks(ByVal xmlFile As String, ByVal destinationFolder As String)
        Dim logFile As String = "symbolic_links_log.txt"
        Dim logBuilder As New StringBuilder()
        Try
            logBuilder.AppendLine($"{DateTime.Now}: Starting the process for XML file '{xmlFile}' and destination folder '{destinationFolder}'")
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(xmlFile)

            Dim gameNodes As XmlNodeList = xmlDoc.SelectNodes("//game")
            Parallel.ForEach(
            gameNodes.Cast(Of XmlNode),
            Sub(gameNode)
                Dim nameNode As String = CleanStringForPath(gameNode.SelectSingleNode("name").InnerText)
                Dim pathNode As String = EnsureTrailingSlash(ContainsSpecialCommand(gameNode.SelectSingleNode("path").InnerText))
                Dim folderName As String = IO.Path.GetFileName(IO.Path.GetDirectoryName(pathNode))
                Dim targetPath As String = EnsureTrailingSlash(IO.Path.Combine(destinationFolder, nameNode, folderName))
                Dim sourceParentDirectory As String = IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(pathNode))
                Directory.CreateDirectory(targetPath)
                Directory.CreateDirectory(sourceParentDirectory)
                doSymbolicLink(pathNode, targetPath, logBuilder)
            End Sub)
            logBuilder.AppendLine($"{DateTime.Now}: Successfully completed creating symbolic links for all games.")
        Catch ex As Exception
            logBuilder.AppendLine($"{DateTime.Now}: Error occurred: {ex.Message}")
        Finally
            File.AppendAllText(logFile, logBuilder.ToString())
        End Try
    End Sub

    Private Sub doSymbolicLink(ByVal sourcePath As String, ByVal targetPath As String, ByRef logBuilder As StringBuilder)
        Dim command As String = $"/C mklink /D ""{sourcePath}"" ""{targetPath}"""
        Try
            logBuilder.AppendLine($"{DateTime.Now}: Creating symbolic link from {sourcePath} to {targetPath}")
            Using process As New Process()
                With process.StartInfo
                    .FileName = "cmd.exe"
                    .Arguments = command
                    .WindowStyle = ProcessWindowStyle.Hidden
                    .CreateNoWindow = True
                    .RedirectStandardOutput = True
                    .RedirectStandardError = True
                    .UseShellExecute = False
                End With
                process.Start()
                process.WaitForExit()
                Dim errorOutput As String = process.StandardError.ReadToEnd()
                If process.ExitCode = 0 Then
                    logBuilder.AppendLine($"{DateTime.Now}: Symbolic link created successfully.")
                Else
                    logBuilder.AppendLine($"{DateTime.Now}: Failed to create symbolic link. Source: {sourcePath} to {targetPath}. Exit code: {process.ExitCode}. Error: {errorOutput}")
                End If
            End Using
        Catch ex As Exception
            logBuilder.AppendLine($"{DateTime.Now}: Error creating symbolic link: {ex.Message}")
        End Try
    End Sub

    Sub RemoveSymbolicLinks(ByVal xmlFile As String)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(xmlFile)
        Dim pathNodes As XmlNodeList = xmlDoc.SelectNodes("//path")

        Parallel.ForEach(
            pathNodes.Cast(Of XmlNode),
            Sub(pathNode)
                Dim sourcePath As String = ContainsSpecialCommand(pathNode.InnerText)
                sourcePath = EnsureTrailingSlash(sourcePath)
                If Directory.Exists(sourcePath) Then
                    Directory.Delete(sourcePath, True)
                End If
            End Sub)
    End Sub
    Function loadXML(ByVal value As String)
        Dim xDoc As XDocument = XDocument.Load("settings.xml")
        Dim xreturn As String = xDoc.Descendants(value).FirstOrDefault().Value
        Return xreturn
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
        Dim replacements As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
        {"%appdata%", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)},
        {"%userprofile%", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)},
        {"%localappdata%", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)},
        {"%programdata%", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}
    }

        For Each key As String In replacements.Keys
            input = Regex.Replace(input, key, replacements(key), RegexOptions.IgnoreCase)
        Next

        Return input
    End Function

    Function CleanStringForPath(ByVal input As String) As String
        Dim invalidChars As Char() = IO.Path.GetInvalidFileNameChars()
        For Each ch As Char In invalidChars
            input = input.Replace(ch, "")
        Next
        Return input
    End Function
    Function EnsureTrailingSlash(directory As String) As String
        If Not String.IsNullOrEmpty(directory) Then
            Dim separator As Char = If(directory.Contains("/"), "/"c, "\"c)
            If Not directory.EndsWith(separator) Then
                directory &= separator
            End If
        End If
        Return directory
    End Function
End Module
