Imports Microsoft.SqlServer
Imports System.Runtime

Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password = Encrypt(TextBox2.Text.Trim())
        Dim doc = XDocument.Load(Form1.serverLocation & "admin.xml")
        Dim storedPasswordHash = doc.<passwordHash>.Value
        If storedPasswordHash.Equals(password) Then
            Dim settings As New Settings
            Me.Close()
            settings.ShowDialog()
            settings.BringToFront()
        End If
    End Sub
End Class