'    Project: subFunction (https://github.com/sa7mon/COMP2310-VB.NET)
' Created By: Dan Salmon (https://danthesalmon.com)
' Created On: 2/18/15
' Updated On: 2/18/15
Public Class frmCollection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'readXML("..\..\myCollection.xml", dsRecords, gridRecords, "record")
        Dim xmlPath As String = "..\..\authors.xml"

        ' Read the XML file into the invisible dataset
        dsRecords.ReadXml(xmlPath)

        gridRecords.DataSource = dsRecords
        gridRecords.DataMember = "authors"
    End Sub
End Class
