Public Class frmLabDebug
    'labDebug.vb - demonstrate converting data types and breakpoints
    'Peter K. Johnson - peterk@WebExplorations.com
    'Written:     01-25-15
    'Revised:     01-25-15

    ' Use debugging tools, watches, and the conversion functions to get this
    ' calculator up and running.

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) _
                Handles btnCalc.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intResult As Integer
        intNum1 = CInt(txtNum1.Text)
        intNum2 = CInt(txtNum2.Text)
        intResult = intNum1 + intNum2
        lblResult.Text = intResult
    End Sub
End Class
