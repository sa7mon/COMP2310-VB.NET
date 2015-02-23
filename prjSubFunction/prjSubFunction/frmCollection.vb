'    Project: subFunction (https://github.com/sa7mon/COMP2310-VB.NET)
' Created By: Dan Salmon (https://danthesalmon.com)
' Created On: 2/18/15
' Updated On: 2/22/15
Public Class frmCollection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Call function from modFunctions
        readXML("..\..\myCollection.xml", dsRecords, gridRecords, "record")

    End Sub
End Class
