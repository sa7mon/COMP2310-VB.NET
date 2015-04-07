Imports System
Imports System.Data.SqlClient
Public Class frmAzureDBFDemo
    Const DBF_NAME As String = "userDatabase"
    Const TABLE_NAME As String = "userTable"
    ' TABLE SCHEMA: userTable
    ' 0 id int,
    ' 1 userID varchar(30),
    ' 2 userName varchar(25),
    ' 3 password varchar(25),
    ' 4 email varchar(30),
    ' 5 phone varchar(10)
    Const USERTABLE_ID = 0
    Const USERTABLE_USERID = 1
    Const USERTABLE_USERNAME = 2
    Const USERTABLE_PASSWORD = 3
    Const USERTABLE_EMAIL = 4
    Const USERTABLE_PHONE = 5
    Dim ds As New DataSet


    Private Sub frmAzureDBFDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateGrid(DBF_NAME, TABLE_NAME, "SELECT * FROM [" & TABLE_NAME & "]")
    End Sub

    Private Sub populateGrid(ByVal dbfName As String, ByVal tableName As String, ByVal strSQL As String)
        'Dim con As New SqlConnection = 
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

    Private Sub dg_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellEnter
        '=========================
        ' CELL ENTER EVENT
        '=========================
        ' Print out current cell data in console
        Dim currentCol As Integer = e.ColumnIndex
        Dim currentRow As Integer = e.RowIndex
        Console.WriteLine("Value: " &
        dg.Rows(currentRow).Cells(currentCol).Value)
        Console.WriteLine("Row: " & currentRow)
        Console.WriteLine("Col: " & currentCol)
        ' Update the text boxes, checking for empty rows
        ' Cell is the column index based on the table Schema
        If (currentRow < dg.RowCount - 1) Then
            lblUserID.Text =
            dg.Rows(currentRow).Cells(USERTABLE_USERID).Value
            lblPassword.Text =
            dg.Rows(currentRow).Cells(USERTABLE_PASSWORD).Value
            lblEmail.Text =
            dg.Rows(currentRow).Cells(USERTABLE_EMAIL).Value
        Else
            lblUserID.Text = ""
            lblPassword.Text = ""
            lblEmail.Text = ""
        End If
    End Sub
End Class
