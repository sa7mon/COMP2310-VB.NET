' Project: VB Application [GitHub link here]
' Created by: Dan Salmon [https://danthesalmon.com]
' Created on: 1/25/15
' Updated on: 1/28/15

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' On form load: Select a drop-down item
        '               Populate the HTML web browser control

        'Select a drop-down item
        cmbPartNo.SelectedIndex = 0

        'Populate the HTML web browser control

    End Sub

    Private Sub picboxParts_Click(sender As Object, e As EventArgs) Handles picboxParts.Click
        'Toggle information when the user clicks on a picture box

    End Sub

    Private Sub cmbPartNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPartNo.SelectedIndexChanged
        'Populate labels when the selection in the combo box changes

    End Sub
End Class