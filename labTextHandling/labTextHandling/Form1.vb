Imports System.IO.Path
Public Class frmTextHandling
    Private Sub cmbxListItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxListItems.SelectedIndexChanged
        lblSelection.Text = "The item that was selected was: " & cmbxListItems.SelectedItem
    End Sub
    Private Sub frmTextHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the first item as the default selected item.
        cmbxListItems.SelectedIndex = 0
        'Rich Text file resides 2 levels up from the debug directory.
        rtbInput.LoadFile(GetFullPath("..\..\rtfExample.rtf"))
        'Navigate the Web Browser to a local .html file.
        webInput.Navigate(GetFullPath("..\..\htmlExample.html"))
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        webInput.DocumentText = txtWebEdit.Text
    End Sub
End Class
