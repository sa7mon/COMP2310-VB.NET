Imports System.IO

Public Class Form1

    Private myWriter As New StreamWriter("myFile.txt")
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        myWriter.WriteLine(txtWrite.Text)
        myWriter.Close()
    End Sub

End Class
