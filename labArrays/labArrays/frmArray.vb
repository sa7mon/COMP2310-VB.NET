Public Class frmArray
    Const MAX_INDEX As Integer = 5
    Const MAX_ROW As Integer = 3
    Const MAX_COL As Integer = 5

    'Declare singl-dimension array
    Dim priceArray(MAX_INDEX) As Double
    Dim tempArray(MAX_INDEX) As Double
    Dim mileageGrid(3, MAX_INDEX) As Integer
    Private Sub frmArray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        priceArray(0) = 0.99
        priceArray(1) = 5.99
        priceArray(2) = 2.99
        priceArray(3) = 3.99
        priceArray(4) = 4.99
        priceArray(5) = 1.99

        mileageGrid(0, 0) = 15
        mileageGrid(0, 1) = 35
        mileageGrid(0, 2) = 46
        mileageGrid(0, 3) = 5
        mileageGrid(0, 4) = 20
        mileageGrid(0, 5) = 22

        mileageGrid(1, 0) = 15
        mileageGrid(1, 1) = 35
        mileageGrid(1, 2) = 46
        mileageGrid(1, 3) = 5
        mileageGrid(1, 4) = 20
        mileageGrid(1, 5) = 22

        mileageGrid(2, 0) = 15
        mileageGrid(2, 1) = 22
        mileageGrid(2, 2) = 42
        mileageGrid(2, 3) = 2
        mileageGrid(2, 4) = 0
        mileageGrid(2, 5) = 13

        mileageGrid(3, 0) = 5
        mileageGrid(3, 1) = 65
        mileageGrid(3, 2) = 36
        mileageGrid(3, 3) = 53
        mileageGrid(3, 4) = 4
        mileageGrid(3, 5) = 2

    End Sub

    Sub showArray(ByRef thisArray() As Double)
        txtResult.Clear()
        For Each item In thisArray
            txtResult.Text &= item & vbCrLf
        Next
    End Sub
End Class
