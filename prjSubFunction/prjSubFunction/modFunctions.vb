Module modFunctions
    Public Function dashConcat(ByRef one As String, ByRef two As String, ByRef three As String) As String
        'Concatenate the 3 strings
        Dim strResult = one + " - " + two + " - " + three

        'Return the result
        Return strResult
    End Function
End Module
