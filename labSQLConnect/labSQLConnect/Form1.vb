Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class frmMain


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=userDatabase.mdb")
        Dim strSQL As String = txtQuery.Text
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet()

        ' Populate the combobox with the users

        Try
            con.Open()
            da = New OleDbDataAdapter(strSQL, con)
            da.TableMappings.Add("Table", "UserList")
            da.Fill(ds)
            Dim myDataTable As DataTable = ds.Tables(0)

            Dim tempRow As DataRow
            For Each tempRow In myDataTable.Rows
                lstUser.Items.Add((tempRow("userid")))
            Next
            ' set the first item as the default selection
            lstUser.SelectedIndex = 0
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
