Public Class frmDecisionString
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Project Name: prjDecisionString
    ' Created By:   Dan Salmon (https://danthesalmon.com/)
    ' Created On:   2/9/15
    ' Updated On:   2/9/15
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
    Dim FAST_MONTHLY As Integer = 9.95
    Dim FAST_HOURS_CHARGE As Integer = 2.0
    Dim FASTER_HOURS As Integer = 20
    Dim FASTER_HOURS_CHARGE As Integer = 1
    Dim FASTER_MONTHLY As Integer = 14.95
    Dim FASTEST_MONTHLY As Integer = 19.95
    Dim NONPROF_DISCOUNT As Decimal = 0.2

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'total = ((base monthly price) + (hours over * overage charge)) - non-profit discount
        Dim totalPrice As Integer = 0
        Dim baseMonthlyPrice As Integer = 0
        Dim hoursOver As Integer = 0
        Dim overageCharge As Integer = 0
        Dim discount As Integer = 0

        Dim package As String = ""

        '' Start by validating all the information

        '' Check if hours entered is greater than 744. If it is, don't even continue. 
        If (CInt(numHours.Value) > MAX_HOURS) Then
            MsgBox("Error: Hours used cannot be more than 744. Please re-check used hours.")
            'TODO Set maximum value of numHours to 744

            ''Give an error and exit out of this subroutine
            Return
        End If

        '' Validation is done, proceed with the calculation
        '' Figure out which package was selected
        If radioFast.Checked = True Then
            package = "Fast"
        ElseIf radioFaster.Checked = True Then
            package = "Faster"
        ElseIf radioFastest.Checked = True Then
            package = "Fastest"
        End If

        Select Case package
            Case "Fast"
                ''First, see if we've exceeded our hour limit
                If numHours.Value > FAST_HOURS Then
                    '' We've exceeded our hour limit.

                End If
            Case "Faster"
            Case "Fastest"
            Case Else
                MsgBox("Error: Couldn't determine package.")
        End Select


    End Sub
End Class
