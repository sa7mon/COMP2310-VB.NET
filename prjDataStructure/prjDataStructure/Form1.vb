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
        ' Show the Save File Dialog
        sdSaveCollection.ShowDialog()
    End Sub

    Private Sub saveListToFile() Handles sdSaveCollection.FileOk
        'Instantiate a new StreamWriter because the path can't be changed once it's created.
        Dim fileWriter As New StreamWriter(sdSaveCollection.FileName)

        Try
            ' Write the contents of the textbox to the file
            fileWriter.WriteLine(txtCollection.Text)
            ' Give success message to user
            MsgBox("Collection saved to file successfully!")
        Catch ex As IOException
            ' Catch IO error and report to the user
            MsgBox("IO Error Occured: " + ex.ToString)
        Catch generalEx As Exception
            ' Catch general error and report to the user
            MsgBox("Unknown Error Occured: " + generalEx.ToString)
        Finally
            ' Close the streamWriter to save on resources regardless of if there was an error
            fileWriter.Close()
        End Try
        
    End Sub

    Private Sub msItemOpen_Click() Handles msItemOpen.Click
        ' Show open file dialog
        odOpenCollection.ShowDialog()
    End Sub

    Private Sub readListFromFile() Handles odOpenCollection.FileOk
        ' Sub launched when "Ok" clicked in Open File Dialog


    End Sub
End Class
