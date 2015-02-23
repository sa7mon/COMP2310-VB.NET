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
    End Sub
End Class