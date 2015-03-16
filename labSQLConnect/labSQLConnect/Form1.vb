Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class frmMain



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=userDatabase.mdb")
        Dim strSQL As String = "SELECT * FROM userList"
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet()
        Try
            con.Open()
            da = New OleDbDataAdapter(strSQL, con)
            da.TableMappings.Add("Table", "UserList")
            da.Fill(ds)
            con.Close()
            dgResult.DataSource = ds
            dgResult.DataMember = "UserList"
        Catch ex As Exception

        End Try

    End Sub
End Class
