Public Class frmDecisionString
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Project Name: prjDecisionString (https://github.com/sa7mon/COMP2310-VB.NET/tree/master/prjDecisionString)
    ' Created By:   Dan Salmon (https://danthesalmon.com/)
    ' Created On:   2/9/15
    ' Updated On:   2/14/15
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim MAX_HOURS As Integer = 744
    Dim FAST_HOURS As Integer = 10
    Dim FAST_MONTHLY As Decimal = 9.95
    Dim FAST_HOURS_CHARGE As Integer = 2.0
    Dim FASTER_HOURS As Integer = 20
    Dim FASTER_HOURS_CHARGE As Integer = 1
    Dim FASTER_MONTHLY As Decimal = 14.95
    Dim FASTEST_MONTHLY As Decimal = 19.95
    Dim NONPROF_DISCOUNT As Decimal = 0.2
    Public Function cleanInput(input)
        Dim cleanedPhone As String = ""

        For Each c As Char In input
            ' Loop through each characted in the input string
            ' Check for any character that's not a number and ignore it
            If (Char.IsNumber(c)) Then
                'It's a number alright. Add it to the string we're going to return
                cleanedPhone += c
            End If
        Next

        Return cleanedPhone
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'total = ((base monthly price) + (hours over * overage charge)) - non-profit discount
        Dim totalPrice As Decimal = 0
        Dim baseMonthlyPrice As Decimal = 0
        Dim hoursOver As Integer = 0
        Dim overageCharge As Decimal = 0
        Dim discount As Decimal = 0
        Dim package As String = ""
        Dim total As Decimal = 0
        Dim accNumber As String = ""

        '' Start by validating all the information

        '' Check if hours entered is greater than 744. If it is, don't even continue. 
        If (CInt(numHours.Value) > MAX_HOURS) Then
            'Give an error and exit out of this subroutine
            MsgBox("Error: Hours used cannot be more than 744. Please re-check used hours.")
            Return
        End If

        ' Validation is done, proceed with the calculation
        ' Figure out which package was selected
        If radioFast.Checked = True Then
            package = "Fast"
            baseMonthlyPrice = FAST_MONTHLY
            'Calculate how many hours over the limit the customer went.
            overageCharge = FAST_HOURS_CHARGE
        ElseIf radioFaster.Checked = True Then
            package = "Faster"
            baseMonthlyPrice = FASTER_MONTHLY
            overageCharge = FASTER_HOURS_CHARGE
        ElseIf radioFastest.Checked = True Then
            package = "Fastest"
            baseMonthlyPrice = FASTEST_MONTHLY
            'Fastest has no max hours or overage charge
            hoursOver = 0
            overageCharge = 0
        End If

        'Calculate our overage hours
        If package = "Fast" Then
            'Check for overage hours
            If numHours.Value > FAST_HOURS Then
                'We've gone over our limit.
                hoursOver = numHours.Value - FAST_HOURS
            Else
                hoursOver = 0
            End If
        ElseIf package = "Faster" Then
            'Check for overage hours
            If numHours.Value > FASTER_HOURS Then
                hoursOver = numHours.Value - FASTER_HOURS
            Else
                hoursOver = 0
            End If
        End If

        'Check if non-profit organizaion. If true, find total discount
        If cbNonProfit.Checked = True Then
            'User has selected Non-Profit Organization
            discount = (baseMonthlyPrice + (hoursOver * overageCharge)) * NONPROF_DISCOUNT
        End If

        'Calculate total price
        totalPrice = ((baseMonthlyPrice) + (hoursOver * overageCharge)) - discount

        'Create our account number with a one-liner
        accNumber = txtFirstName.Text.Substring(0, 3).ToLower + "-" + cleanInput(txtPhone.Text).substring(6, 4) + "-" _
                    + txtLastName.Text.Substring(txtLastName.Text.Length - 3, 3).ToLower

        'Change all the labels on the result form to show our results
        frmResult.lblTotalData.Text = FormatCurrency(totalPrice, 2)
        frmResult.lblSubTotalData.Text = FormatCurrency(totalPrice + discount, 2)
        frmResult.lblDiscountData.Text = FormatCurrency(discount, 2)
        frmResult.lblAccNumData.Text = accNumber

        frmResult.Show()

    End Sub
End Class
