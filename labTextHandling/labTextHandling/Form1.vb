Public Class frm1


    Private Sub cmbxListItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxListItems.SelectedIndexChanged
        lblSelection.Text = "The item that was selected was: " & cmbxListItems.SelectedItem
    End Sub
End Class
