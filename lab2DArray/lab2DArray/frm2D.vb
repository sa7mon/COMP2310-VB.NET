Public Class frm2D

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        

        Dim myRow, myCol As Integer
        Dim prices(,) = {{450D, 440D},
                        {425D, 415D},
                        {400D, 410D}}
        Try
            myRow = CInt(cmbRow.SelectedIndex)
            myCol = CInt(cmbColumn.SelectedIndex)

            lblPrice.Text = prices(myRow, myCol).ToString("c")
        Catch ex As Exception
            MsgBox("Row and column must be integers.")
        End Try


    End Sub

    Private Sub frm2D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbColumn.SelectedIndex = 0
        cmbRow.SelectedIndex = 0
    End Sub
End Class