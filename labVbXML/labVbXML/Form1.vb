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

    Private Sub btnXPath_Click(sender As Object, e As EventArgs) Handles btnXPath.Click
        txtParagraph.Text = ""

        Dim filePath As String = "myXML.xml"
        Dim xpathDoc As XPathDocument
        Dim xmlNav As XPath.XPathNavigator
        Dim xmlData As XPathNodeIterator

        Try
            xpathDoc = New XPathDocument(filePath)
            xmlNav = xpathDoc.CreateNavigator()
            xmlData = xmlNav.Select("/story/paragraph")

            While (xmlData.MoveNext())
                txtParagraph.Text &= vbCrLf & xmlData.Current.Name & ":" & xmlData.Current.Value
            End While
        Catch ex As XPathException
            System.Console.WriteLine("XMLException: " + ex.Message)
        Catch ex As Exception
            System.Console.WriteLine("Exception: " + ex.Message)
        End Try
    End Sub
End Class
