Public Class frmCallStackDemo
    'Created By: Dan Salmon
    'Lab: appCallStackDemo
    'Written: 1/26/15

    'frmCallStackDemo - Demonstrate the use of Debug.WriteLine() and Debug.Assert()
    ' Also show how to display information in a multi-line textbox 

    'Test with this flag later
    Dim flagTest As Integer = 10

    Private Sub subroutineOne()
        txtMsg.Text = "In subroutineOne()" & vbCrLf
        subroutineTwo()
    End Sub
    Private Sub subroutineTwo()
        txtMsg.Text &= "In subroutineTwo()" & vbCrLf
        subroutineThree()
    End Sub
    Private Sub subroutineThree()
        txtMsg.Text &= "In subroutineThree()" & vbCrLf
    End Sub

    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDo.Click
        ' Call the first subroutine
        subroutineOne()
    End Sub
End Class
