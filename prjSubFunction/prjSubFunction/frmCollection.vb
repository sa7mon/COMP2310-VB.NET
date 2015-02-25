'    Project: subFunction (https://github.com/sa7mon/COMP2310-VB.NET)
' Created By: Dan Salmon (https://danthesalmon.com)
' Created On: 2/18/15
' Updated On: 2/22/15
Public Class frmCollection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xml As XDocument = XDocument.Load("myCollection.xml")
        Dim artist = ""
        Dim releaseName = ""
        Dim year = ""

        For Each node As XElement In xml.Descendants("records")
            ' For every element under records, do the following.
            ' We need to loop through the elements under <record> because the first loop grab all child elements.
            For Each recordNode As XElement In xml.Descendants("record")
                ' For every child element of <record> do the following.

                artist = recordNode.Element("artist").Value
                releaseName = recordNode.Element("releaseName").Value
                year = recordNode.Element("year").Value
                'Now that we've gotten all the values, call the dashConcat function
                txtXML.Text &= dashConcat(artist, releaseName, year) & vbCrLf
            Next
        Next

    End Sub
End Class
