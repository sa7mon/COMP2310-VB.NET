﻿Module modFunctions
    Public Function dashConcat(ByRef one As String, ByRef two As String, ByRef three As String) As String
        'Concatenate the 3 strings
        Dim strResult = one + " - " + two + " - " + three

        'Return the result
        Return strResult
    End Function


    Public Function isHighScore(num As Integer)
        Dim isHigher As Boolean = False
        'Compare parameter to current highscore
        If (num > frmModule.highScore) Then
            'User has beaten high score.
            ' Set high score to new value
            frmModule.highScore = num
            Return True
        Else
            Return False
        End If
    End Function
End Module
