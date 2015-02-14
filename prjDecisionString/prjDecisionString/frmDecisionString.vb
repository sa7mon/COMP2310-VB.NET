Public Class frmDecisionString
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Project Name: prjDecisionString
    ' Created By:   Dan Salmon (https://danthesalmon.com/)
    ' Created On:   2/9/15
    ' Updated On:   2/12/15
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' PROJECT CODE REQUIREMENTS
    '
    ' Using a set of if then elseif statements, calculate the total amount using the chart above. 
    ' If the user checks the non-profit checkbox, subtract 20% off the total cost.
    ' Display the original total as well as the discounted amount. Make certain everything is clearly labeled for the user.
    ' Use the iif( ) to determine what title should be displayed "Monthly Charge" or "Discounted Monthly Charge".
    ' All rates, limits, and discount values must be declared as symbolic constants using the proper keyword and 
    ' capitalization that you learned in the Learning Activities. Include these near the top of your code so they can be easily modified.
    ' Validate the user input. There cannot be more than 744 hours used per month. The value must be numeric.
    '
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Package Name	  Price	                         Additional Hours
    '   Fast	    10 hrs/month at $9.95/month	          $2.00
    ' Faster	    20 hrs/month at $14.95/month	      $1.00
    'Fastest	    Unlimited Access at $19.95/month	  no extra charge
    'Non-Profit Discount	20% off any package	20% off
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Dim MAX_HOURS As Integer = 744
    Dim FAST_HOURS As Integer = 10
    Dim FAST_MONTHLY As Decimal = 9.95
    Dim FAST_HOURS_CHARGE As Integer = 2.0
    Dim FASTER_HOURS As Integer = 20
    Dim FASTER_HOURS_CHARGE As Integer = 1
    Dim FASTER_MONTHLY As Decimal = 14.95
    Dim FASTEST_MONTHLY As Decimal = 19.95
    Dim NONPROF_DISCOUNT As Decimal = 0.2

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'total = ((base monthly price) + (hours over * overage charge)) - non-profit discount
        Dim totalPrice As Decimal = 0
        Dim baseMonthlyPrice As Decimal = 0
        Dim hoursOver As Integer = 0
        Dim overageCharge As Decimal = 0
        Dim discount As Decimal = 0
        Dim package As String = ""
        Dim total As Decimal = 0

        '' Start by validating all the information

        '' Check if hours entered is greater than 744. If it is, don't even continue. 
        If (CInt(numHours.Value) > MAX_HOURS) Then
            'Give an error and exit out of this subroutine
            MsgBox("Error: Hours used cannot be more than 744. Please re-check used hours.")
            'TODO Set maximum value of numHours to 744
            Return
        End If

        ' Validation is done, proceed with the calculation
        ' Figure out which package was selected
        If radioFast.Checked = True Then
            package = "Fast"
            baseMonthlyPrice = FAST_MONTHLY
            'Calculate how many hours over the limit the customer went.
            'hoursOver = numHours.Value - FAST_HOURS
            overageCharge = FAST_HOURS_CHARGE
        ElseIf radioFaster.Checked = True Then
            package = "Faster"
            baseMonthlyPrice = FASTER_MONTHLY
            'hoursOver = numHours.Value - FASTER_HOURS
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
            ' Discount = (base monthly price + overage charges)*discount
            discount = (baseMonthlyPrice + (hoursOver * overageCharge)) * NONPROF_DISCOUNT
        End If

        totalPrice = ((baseMonthlyPrice) + (hoursOver * overageCharge)) - discount

        frmResult.Show()
        'total = ((base monthly price) + (hours over * overage charge)) - non-profit discount

    End Sub
End Class
