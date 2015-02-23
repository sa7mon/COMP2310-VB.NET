Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'Limit the array length
        Const MAX_SUBSCRIPT As Integer = 4
        Dim numberArray(MAX_SUBSCRIPT) As Integer

        'Make counter
        Dim count As Integer

        'Create new random object
        Dim myRandom As New Random

        'Fill the array
        'Each number will be in range of 0-99
        For count = 0 To MAX_SUBSCRIPT
            numberArray(count) = myRandom.Next(100)
        Next

        lblFirst.Text = numberArray(0).ToString
        lblSecond.Text = numberArray(1).ToString
        lblThird.Text = numberArray(2).ToString
        lblFourth.Text = numberArray(3).ToString
        lblFifth.Text = numberArray(4).ToString

    End Sub
End Class
