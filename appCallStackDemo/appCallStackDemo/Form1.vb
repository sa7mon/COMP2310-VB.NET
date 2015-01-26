Public Class frmCallStackDemo
    'Created By: Dan Salmon
    'Lab: appCallStackDemo
    'Written: 1/26/15

    'frmCallStackDemo - Demonstrate the use of Debug.WriteLine() and Debug.Assert()
    ' Also show how to display information in a multi-line textbox 

    'Test with this flag later
    Dim flagTest As Integer = 10

    Private Sub subroutineOne()
        Debug.WriteLine("In subroutineOne()")
        txtMsg.Text = "In subroutineOne()" & vbCrLf
        subroutineTwo()
    End Sub
    Private Sub subroutineTwo()
        Debug.WriteLine("In subroutineTwo()")
        txtMsg.Text &= "In subroutineTwo()" & vbCrLf
        subroutineThree()
    End Sub
    Private Sub subroutineThree()
        Debug.WriteLine("In subroutineThree()")
        txtMsg.Text &= "In subroutineThree()" & vbCrLf
        flagTest = -1
        Debug.Assert(flagTest >= 0, "flagTest is less than zero! This is from the Debug.Assert message in subroutineThree()")
    End Sub

    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDo.Click
        ' Call the first subroutine
        subroutineOne()
    End Sub
End Class
