Public Class frmModule

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Generate a random number
        Dim numRnd = CInt(Rnd() * 1000)
        'Display the random number
        lblRandData.Text = Str(numRnd)
        'Compare the random number to the current high score using a function

    End Sub
End Class