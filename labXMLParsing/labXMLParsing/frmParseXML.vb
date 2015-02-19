Public Class frmParseXML

    Private Sub btnReadXML_Click(sender As Object, e As EventArgs) Handles btnReadXML.Click
        Dim xmlPath As String = "..\..\authors.xml"

        ' Read the XML file into the invisible dataset
        datasetAuthors.ReadXml(xmlPath)

        gridData.DataSource = datasetAuthors
        gridData.DataMember = "authors"
    End Sub

    Private Sub btnShowSchema_Click(sender As Object, e As EventArgs) Handles btnShowSchema.Click
        Dim swXML As New System.IO.StringWriter()
        datasetAuthors.WriteXmlSchema(swXML)
        txtSchema.Text = datasetAuthors.ToString
    End Sub
End Class
