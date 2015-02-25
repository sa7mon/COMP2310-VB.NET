Public Class frmModule
    Public highScore = 500
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Display current high score
        lblHIghScoreData.Text = highScore
        'Generate a random number
        Dim numRnd = CInt(Rnd() * 1000)
        'Display the random number
        lblRandData.Text = Str(numRnd)
        'Compare the random number to the current high score using a function
        If (isHighScore(numRnd)) Then
            lblIsHigher.ForeColor = Color.Green
            lblIsHigher.Text = "New high score!"
        Else
            lblIsHigher.ForeColor = Color.Red
            lblIsHigher.Text = "Not new high score."
        End If
    End Sub
End Class