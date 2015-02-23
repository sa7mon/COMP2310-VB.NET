Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim values(,) As String = New String(,) {{"ant", "aunt"},
                         {"Sam", "Samantha"},
                         {"clozapine", "quetiapine"},
                         {"flomax", "volmax"},
                         {"toradol", "tramadol"}}

        ' Get bounds of the array.
        Dim bound0 As Integer = values.GetUpperBound(0)
        Dim bound1 As Integer = values.GetUpperBound(1)

        ' Loop over all elements.
        For i As Integer = 0 To bound0
            For x As Integer = 0 To bound1
                ' Get element.
                Dim s1 As String = values(i, x)
                Console.Write(s1)
                Console.Write(" "c)
            Next
            Console.WriteLine()
        Next
    End Sub
End Class
