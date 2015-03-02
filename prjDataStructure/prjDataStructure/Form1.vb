Imports System.IO

Public Class frmMain
    Public Structure vinyl
        Public album As String
        Public artist As String
        Public year As Integer
        Public ReadOnly Property yearString() As String
            ' Returns the year variable as a String
            Get
                Return year.ToString()
            End Get
        End Property

    End Structure

    Dim vinylList As New ArrayList
    Private fileWriter As New StreamWriter("myCollection.txt")

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        ' Create new object from vinyl structure.
        Dim newVinyl As vinyl

        ' Assign values to object variables.
        newVinyl.album = txtAlbum.Text
        newVinyl.artist = txtArtist.Text
        newVinyl.year = CInt(txtYear.Text)

        'Add the object to the arraylist
        vinylList.Add(newVinyl)

        ' Clear textbox
        txtCollection.Clear()

        ' For each vinyl in collection, do the following
        For Each collectionItem As vinyl In vinylList
            ' Add a line in the text box in this format: Artist - Album (Year) and add a new line character
            txtCollection.Text &= collectionItem.artist _
                                  + " - " + collectionItem.album + " (" + collectionItem.yearString + ")" + vbCrLf
        Next

        'Clear the textboxes to prepare for a new item being entered
        txtAlbum.Clear()
        txtArtist.Clear()
        txtYear.Clear()
    End Sub

    Private Sub msItemSave_Click(sender As Object, e As EventArgs) Handles msItemSave.Click
        sdSaveCollection.ShowDialog()
        'fileWriter.WriteLine(txtCollection.Text)
        'fileWriter.Close()
        'MsgBox("Collection saved to file successfully!")
    End Sub
End Class
