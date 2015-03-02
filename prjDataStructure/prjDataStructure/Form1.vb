Public Class frmMain
    Public Structure vinyl
        Public album As String
        Public artist As String
        Public year As Integer

        Public ReadOnly Property yearString() As String
            Get
                Return year.ToString()
            End Get
        End Property

    End Structure

    Dim vinylList As New ArrayList

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        ' Create new object from vinyl structure.
        Dim newVinyl As vinyl
        newVinyl.album = txtAlbum.Text
        newVinyl.artist = txtArtist.Text
        newVinyl.year = CInt(txtYear.Text)
        'Add the object to the arraylist
        vinylList.Add(newVinyl)

    End Sub
End Class
