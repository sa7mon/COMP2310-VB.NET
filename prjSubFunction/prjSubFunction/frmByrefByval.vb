Public Class frmByrefByval

    Private strFirst As String = "Red"
    Private strSecond As String = "Blue"

    Private Sub btnRunSub_Click(sender As Object, e As EventArgs) Handles btnRunSub.Click
        demoByRef(strFirst, strSecond)
    End Sub

    Public Sub demoByRef(ByVal argStrFirst As String, ByRef argStrSecond As String)
        txtLog.Text = "demoByRef() Executing..." + Environment.NewLine
        txtLog.Text += "strFirst = " + strFirst + Environment.NewLine
        txtLog.Text += "strSecond = " + strSecond + Environment.NewLine
        txtLog.Text += "Changing values..." + Environment.NewLine

        'Change values
        strFirst = "Orange"
        strSecond = "Violet"

        txtLog.Text += "strFirst = " + strFirst + Environment.NewLine
        txtLog.Text += "strSecond = " + strSecond + Environment.NewLine
        txtPara.Text = "The variable that was passed ByVal is only changed in the sub. To the program outside of the function, the variable is unchanged."
        txtPara.Text &= "The ByRef variable, on the other hand, is changed inside and ouside of the sub from the sub." + vbCrLf
        txtPara.Text &= "If the two variables were global, they could be changed by anything and the changes would be reflected in anything referencing them."
    End Sub
End Class