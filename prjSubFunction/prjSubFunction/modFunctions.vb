Module modFunctions
    Public Sub readXML(xmlPath As String, xmlDataSet As DataSet, grid As DataGridView, member As String)
        ' Read the XML file into the invisible dataset
        xmlDataSet.ReadXml(xmlPath)

        'Change the source of data on the grid to the invisible dataset
        grid.DataSource = xmlDataSet

        'Tell the grid which element to not list
        grid.DataMember = member
    End Sub

    Public Function dashConCat(one As String, two As String, three As String) As String
        'Concatenate the 3 strings
        Dim strResult = one + " - " + two + " - " + three

        'Return the result
        Return strResult
    End Function
End Module
