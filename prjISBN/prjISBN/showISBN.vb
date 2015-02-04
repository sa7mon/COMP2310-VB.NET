''File: showISBN.vb (https://github.com/sa7mon/COMP2310-VB.NET)
''Created By: Dan Salmon (https://danthesalmon.com)
''Created On: 2/4/15
''Last Updated: 2/4/15

Public Class frmShowISBN

    Public Function cleanISBN(input)
        Dim cleanedISBN As String = ""

        For Each c As Char In input
            ' Loop through each characted in the input string
            ' Check for any character that's not a number and ignore it
            If (Char.IsNumber(c)) Then
                'Yep, it's a number alright. Add it to the string we're going to return
                cleanedISBN += c
            End If
        Next

        Return cleanedISBN
    End Function

    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged
        lblValid.Text = IIf(txtISBN.Text.Length > 12, cleanISBN(txtISBN.Text), "Not an ISBN")
    End Sub
End Class
