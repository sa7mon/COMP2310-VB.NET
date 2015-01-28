' Project: VB Application [https://github.com/sa7mon/COMP2310-VB.NET/tree/master/prjVBApp]
' Created by: Dan Salmon [https://danthesalmon.com]
' Created on: 1/25/15
' Updated on: 1/28/15

' Image Credits
'Part 12345: http://offset.gobizkorea.com/att/cat/akbgks/tp_html/img/akbgks_cat_755148_small_img_2.gif
'Part 23456: http://www.globalspec.com/ImageRepository/LearnMore/20121/spur-gears9c6eaaa7c5d640c6b2bf74c77c566edf.png
'Part 34567: http://horstengineering.com/wp-content/uploads/2010/08/2010_Parts_Aerospace_Bolt_01.jpg

Imports System.IO.Path
Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Select a drop-down item and launch everything.
        cmbPartNo.SelectedIndex = 0
    End Sub
    Private Sub picboxParts_Click(sender As Object, e As EventArgs) Handles picboxParts.Click
        'Toggle information when the user clicks on a picture box

        'Change the picture on the form we can't see yet
        Dim comboBoxText As String = cmbPartNo.SelectedItem.ToString
        Select Case comboBoxText
            Case "12345"
                frmPictureLarge.picboxViewer.Image = Image.FromFile("..\..\imgPart_12345.png")
            Case "23456"
                frmPictureLarge.picboxViewer.Image = Image.FromFile("..\..\imgPart_23456.png")
            Case "34567"
                frmPictureLarge.picboxViewer.Image = Image.FromFile("..\..\imgPart_34567.png")
            Case Else
                frmPictureLarge.picboxViewer.Image = Nothing
        End Select
        'Show the "Picture Viewer" window
        frmPictureLarge.Show()
    End Sub
    Private Sub cmbPartNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPartNo.SelectedIndexChanged
        Dim comboBoxChangedText As String = cmbPartNo.SelectedItem.ToString
        'Populate labels when the selection in the combo box changes
        Select comboBoxChangedText
            Case "Pick a Part No."
                lblPartName.Text = ""
                lblPartPicture.Text = "Part Picture"
                lblPartDesc.Text = "Part Description"
                picboxParts.Image = Nothing
                wbInst.Navigate(GetFullPath("..\..\pageSelectPart.html"))
                rtbDesc.LoadFile(GetFullPath("..\..\rtfSelectPart.rtf"))

            Case "12345"
                'Change labels
                lblPartName.Text = "Part 12345: Bearing Assembly #1"
                lblPartDesc.Text = "Part 12345 Description"
                lblPartPicture.Text = "Part 12345 Picture"
                'Change image of picturebox in this form
                picboxParts.Image = Image.FromFile("..\..\imgPart_12345.png")
                'Navigate WebBrowser
                wbInst.Navigate(GetFullPath("..\..\pagePart12345.html"))
                'Load Rich Text File
                rtbDesc.LoadFile(GetFullPath("..\..\rtfPart12345.rtf"))

            Case "23456"
                'Change labels
                lblPartName.Text = "Part 23456: Left Assembly Gear"
                lblPartDesc.Text = "Part 23456 Description"
                lblPartPicture.Text = "Part 23456 Picture"
                'Change image of picturebox in this form
                picboxParts.Image = Image.FromFile("..\..\imgPart_23456.png")
                'Change image of picturebox in "Picture Viewer" form
                'Navigate WebBrowser
                wbInst.Navigate(GetFullPath("..\..\pagePart23456.html"))
                'Load Rich Text File
                rtbDesc.LoadFile(GetFullPath("..\..\rtfPart23456.rtf"))

            Case "34567"
                'Change labels
                lblPartName.Text = "Part 34567: Center-threaded hollow bolt"
                lblPartDesc.Text = "Part 34567 Description"
                lblPartPicture.Text = "Part 34567 Picture"
                'Change image of picturebox in this form
                picboxParts.Image = Image.FromFile("..\..\imgPart_34567.png")
                'Navigate WebBrowser
                wbInst.Navigate(GetFullPath("..\..\pagePart34567.html"))
                'Load Rich Text File
                rtbDesc.LoadFile(GetFullPath("..\..\rtfPart34567.rtf"))
            Case Else
                MsgBox("Error: Invalid part number", MsgBoxStyle.Critical)
        End Select
    End Sub

    Private Sub btnSubmitComment_Click(sender As Object, e As EventArgs) Handles btnSubmitComment.Click
        textComment.Text = ""
        MsgBox("Comment submitted. Thank you!", MsgBoxStyle.OkOnly, "Sent Comment")
    End Sub
End Class