Imports System.IO
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
                    Dim pathNode As String = ContainsSpecialCommand(gameNode.SelectSingleNode("path").InnerText)
                    pathNode = EnsureTrailingSlash(pathNode)
                    Dim folderName As String = IO.Path.GetFileName(IO.Path.GetDirectoryName(pathNode))
                    Dim targetPath As String = IO.Path.Combine(destinationFolder, nameNode, folderName)

                    logBuilder.AppendLine($"{DateTime.Now}: Processing game '{nameNode}' with source path '{pathNode}'")

                    If Not Directory.Exists(targetPath) Then
                        Directory.CreateDirectory(targetPath)
                        logBuilder.AppendLine($"{DateTime.Now}: Created directory '{targetPath}'")
                    End If

                    Dim sourceParentDirectory As String = IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(pathNode))

                    If Not Directory.Exists(sourceParentDirectory) Then
                        Directory.CreateDirectory(sourceParentDirectory)
                        logBuilder.AppendLine($"{DateTime.Now}: Created directory '{sourceParentDirectory}'")
                    End If
                    doSymbolicLink(pathNode, targetPath)
                End Sub)

            logBuilder.AppendLine($"{DateTime.Now}: Successfully completed creating symbolic links for all games.")
        Catch ex As Exception
            logBuilder.AppendLine($"{DateTime.Now}: Error occurred: {ex.Message}")
        Finally
            File.AppendAllText(logFile, logBuilder.ToString())
        End Try
    End Sub

    Private Sub doSymbolicLink(ByVal sourcePath As String, ByVal targetPath As String)
        Dim logFile As String = "logfile.txt"
        Dim logBuilder As New StringBuilder()
        Dim command As String = "/C mklink /D """ & sourcePath & """ """ & targetPath & """"
        Try
            logBuilder.AppendLine($"{DateTime.Now}: Creating symbolic link from {sourcePath} to {targetPath}")

            Dim process As New Process()
            With process.StartInfo
                .FileName = "cmd.exe"
                .Arguments = command
                .WindowStyle = ProcessWindowStyle.Hidden
                .CreateNoWindow = True
            End With

            process.Start()
            process.WaitForExit()

            If process.ExitCode = 0 Then
                logBuilder.AppendLine($"{DateTime.Now}: Symbolic link created successfully.")
            Else
                logBuilder.AppendLine($"{DateTime.Now}: Failed to create symbolic link. Exit code: {process.ExitCode}")
            End If

        Catch ex As Exception
            logBuilder.AppendLine($"{DateTime.Now}: Error creating symbolic link: {ex.Message}")
        Finally
            File.AppendAllText(logFile, logBuilder.ToString())
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

    Function CleanStringForPath(ByVal input As String) As String
        Dim invalidChars As Char() = IO.Path.GetInvalidFileNameChars()
        For Each ch As Char In invalidChars
            input = input.Replace(ch, "")
        Next
        Return input
    End Function

    Function GetFolderDepthFromString(folderPath As String) As Integer
        Try
            Dim pathParts As String() = folderPath.Split(New Char() {"\"c, "/"c}, StringSplitOptions.RemoveEmptyEntries)

            Return pathParts.Length

        Catch ex As Exception
            Return 0
        End Try
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
