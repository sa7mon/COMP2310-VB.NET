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
    Dim MAX_HOURS As Integer = 744

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        '' Start by validating all the information

        '' Check if hours entered is greater than 744. If it is, don't even continue. 
        If CInt(numHours.Value) > MAX_HOURS Then
            MsgBox("Error: Hours used cannot be more than 744. Please re-check used hours.")
            Return
        Else
            '' Not greater than MAX_HOURS

        End If
        '' Validation is done, proceed with the calculation
        MsgBox("Don't let it get here.")

    End Sub

End Class
