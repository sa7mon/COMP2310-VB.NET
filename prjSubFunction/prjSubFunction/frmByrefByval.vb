Public Class frmByrefByval

    Private strFirst As String = "Red"
    Private strSecond As String = "Blue"

    Private Sub btnRunSub_Click(sender As Object, e As EventArgs) Handles btnRunSub.Click
        demoByRef(strFirst, strSecond)
    End Sub

    Public Sub demoByRef(ByVal argStrFirst As String, ByRef argStrSecond As String)
        txtLog.Text = "demoByRef() Executing..." + Environment.NewLine
        txtLog.Text += "New line"
    End Sub
End Class