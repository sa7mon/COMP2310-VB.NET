Public Class frmTextHandling


    Private Sub cmbxListItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxListItems.SelectedIndexChanged
        lblSelection.Text = "The item that was selected was: " & cmbxListItems.SelectedItem
    End Sub

    Private Sub frmTextHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbxListItems.SelectedIndex = 0
    End Sub
End Class
