Public Class frmMain

    Private Sub btnXMLFunction_Click(sender As Object, e As EventArgs) Handles btnXMLFunction.Click
        frmCollection.Show()
    End Sub

    Private Sub btnByvalByref_Click(sender As Object, e As EventArgs) Handles btnByvalByref.Click
        frmByrefByval.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmModule.Show()
    End Sub
End Class