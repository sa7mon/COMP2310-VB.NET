Imports System
Imports System.Data.SqlClient
Public Class frmAzureDBFDemo
    Const DBF_NAME As String = "userDatabase"
    Const TABLE_NAME As String = "userTable"
    Dim ds As New DataSet


    Private Sub frmAzureDBFDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateGrid(DBF_NAME, TABLE_NAME, "SELECT * FROM [" & TABLE_NAME & "]")
    End Sub

    Private Sub populateGrid(ByVal dbfName As String, ByVal tableName As String, ByVal strSQL As String)
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        'Clear out old data
        ds.Clear()
        ' Create the Connection
        ' Paste in Connection string from Azure
        ' Don't forget to add in your password.

        'con is stored in sql.vb but isn't in the repo so that we don't expose our Azure db password to public GitHub.

        Try
            con.Open()
            da.SelectCommand = New SqlCommand(strSQL, con)
            da.Fill(ds, TABLE_NAME)
            con.Close()
            'Fill the form objects with data
            dg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
