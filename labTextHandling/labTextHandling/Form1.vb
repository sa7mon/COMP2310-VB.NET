Public Class frmTextHandling


    Private Sub cmbxListItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxListItems.SelectedIndexChanged
        lblSelection.Text = "The item that was selected was: " & cmbxListItems.SelectedItem
    End Sub

    Private Sub frmTextHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the first item as the default selected item.
        cmbxListItems.SelectedIndex = 0
        'Rich Text file resides 2 levels up from the debug directory.
        rtbInput.LoadFile(System.IO.Path.GetFullPath("..\..\rtfExample.rtf"))
    End Sub
End Class
