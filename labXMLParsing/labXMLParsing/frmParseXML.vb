Public Class frmParseXML

    Private Sub btnReadXML_Click(sender As Object, e As EventArgs) Handles btnReadXML.Click
        Dim xmlPath As String = "..\..\authors.xml"

        ' Read the XML file into the invisible dataset
        datasetAuthors.ReadXml(xmlPath)

        gridData.DataSource = datasetAuthors
        gridData.DataMember = "authors"
    End Sub
End Class
