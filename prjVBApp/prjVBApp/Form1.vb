' Project: VB Application [GitHub link here]
' Created by: Dan Salmon [https://danthesalmon.com]
' Created on: 1/25/15
' Updated on: 1/28/15


'Part 1: http://offset.gobizkorea.com/att/cat/akbgks/tp_html/img/akbgks_cat_755148_small_img_2.gif

''Rich Text file resides 2 levels up from the debug directory.
'   rtbInput.LoadFile(GetFullPath("..\..\rtfExample.rtf"))
'Navigate the Web Browser to a local .html file.
'   webInput.Navigate(GetFullPath("..\..\htmlExample.html"))
Imports System.IO.Path
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

        'Show the "Picture Viewer" window
        frmPictureLarge.Show()
    End Sub

    Private Sub cmbPartNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPartNo.SelectedIndexChanged
        'Populate labels when the selection in the combo box changes
        If cmbPartNo.SelectedItem.ToString = "Pick a Part No." Then
            lblPartName.Text = ""
            WebBrowser1.Navigate(GetFullPath("..\..\pageSelectPart.html"))
        End If
        If cmbPartNo.SelectedItem.ToString = "12345" Then
            'Change label text to name of part.
            lblPartName.Text = "Bearing Assembly #1"

            'Change image of picturebox in this form
            picboxParts.Image = Image.FromFile("..\..\part_12345.png")

            'Change image of picturebox in "Picture Viewer" form
            frmPictureLarge.picboxViewer.Image = Image.FromFile("..\..\part_12345.png")
        End If
        If cmbPartNo.SelectedItem.ToString = "23456" Then
            lblPartName.Text = "Part #2"
        End If
        If cmbPartNo.SelectedItem.ToString = "34567" Then
            lblPartName.Text = "Part #3"
        End If
    End Sub
End Class