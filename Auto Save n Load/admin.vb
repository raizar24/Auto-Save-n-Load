Imports Microsoft.SqlServer
Imports System.Runtime

Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password = Encrypt(TextBox2.Text.Trim())
        Dim doc = XDocument.Load(Form1.serverLocation & "admin.xml")
        Dim storedPasswordHash = doc.<passwordHash>.Value
        If storedPasswordHash.Equals(password) Then
            Dim settings As New settings
            Me.Hide()
            settings.ShowDialog()
            settings.BringToFront()


        Else
            MessageBox.Show("Passwords do not match", "System Information")
            Exit Sub
        End If
    End Sub


    ' This is the event handler for the KeyDown event
    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Trigger the Login button click
            Button1.PerformClick()
        End If
    End Sub
End Class