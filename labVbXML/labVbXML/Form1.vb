Imports System.Xml
Imports System.Xml.XPath
Imports System.Data

Public Class frmMain

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim docXML As XDocument = XDocument.Load("myXML.xml")
        For Each node As XElement In docXML.Descendants("story")
            txtParagraph.Text &= node.Element("paragraph").Value & vbCrLf
        Next

        txtParagraph.Text &= vbCrLf & "=============================" & vbCrLf

        For Each node As XElement In docXML.Descendants("story")
            Dim paragraphs As IEnumerable(Of XElement) = node.Descendants("paragraph")
            For Each thisPara In paragraphs
                txtParagraph.Text &= "Paragraph: " & thisPara.Value & vbCrLf
            Next
        Next

        For Each node As XElement In docXML.Descendants("story")
            Dim actors As IEnumerable(Of XElement) = node.Descendants("actor")
            For Each thisActor In actors
                txtParagraph.Text &= "Actor: " & thisActor.Value & vbCrLf
            Next
        Next
    End Sub
End Class
