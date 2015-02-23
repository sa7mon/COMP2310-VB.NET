Public Class frmByrefByval

    Private strFirst As String
    Private strSecond As String

    Private Sub btnRunSub_Click(sender As Object, e As EventArgs) Handles btnRunSub.Click
        demoByRef(strFirst, strSecond)
    End Sub

    Public Sub demoByRef(ByVal argStrFirst As String, ByRef argStrSecond As String)


    End Sub
End Class