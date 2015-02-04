''File: showISBN.vb (https://github.com/sa7mon/COMP2310-VB.NET)
''Created By: Dan Salmon (https://danthesalmon.com)
''Created On: 2/4/15
''Last Updated: 2/4/15

Public Class frmShowISBN

    Public Function cleanInput(input)
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
        Dim cleanedInput As String = ""
        Dim validISBN As String = ""

        If (txtISBN.Text.Length > 12) Then
            'Enough characters to be valid

            'First, clean the input
            cleanedInput = cleanInput(txtISBN.Text)

            If (cleanedInput.Length = 13) Then
                'This is the right number of digits.
                'Time to add dashes
                validISBN = cleanedInput
                validISBN = validISBN.Insert(3, "-")
                validISBN = validISBN.Insert(6, "-")
                validISBN = validISBN.Insert(11, "-")
                validISBN = validISBN.Insert(15, "-")

                lblValid.Text = "Yes, " & validISBN
                lblIndustry.Text = validISBN.Substring(0, 3)
                lblGroupLanguage.Text = validISBN.Substring(4, 2)
                lblPublisher.Text = validISBN.Substring(7, 4)
                lblTitle.Text = validISBN.Substring(12, 3)
            Else
                lblValid.Text = "No"
                lblIndustry.Text = ""
                lblGroupLanguage.Text = ""
                lblPublisher.Text = ""
                lblTitle.Text = ""

            End If
        Else
            'Not enough characters to be valid
            lblValid.Text = "No"
            lblValid.Text = "No"
            lblIndustry.Text = ""
            lblGroupLanguage.Text = ""
            lblPublisher.Text = ""
            lblTitle.Text = ""
        End If
    End Sub
End Class
