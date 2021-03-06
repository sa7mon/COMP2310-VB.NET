﻿Imports System
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

    Private Sub dg_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dg.CellValidating
        '=========================
        ' VALIDATE USER INPUT
        '=========================
        'Any user input that is fixed is reset by CellEndEdit( )
        ' === userID Field ===
        If e.ColumnIndex = 1 Then
            If IsNumeric(e.FormattedValue) Then
                dg.Rows(e.RowIndex).ErrorText = "The User ID must be contain text."
                e.Cancel = True
            Else ' error was fixed by user, so reset
                dg.Rows(e.RowIndex).ErrorText = ""
            End If
        End If
    End Sub

    Private Sub dg_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellEndEdit
        '=========================
        ' CLEAR ERROR MESSAGES
        ' that may have been set by CellEnter( )
        '=========================
        dg.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '=========================
        ' UPDATE ROW in TABLE
        '=========================
        'IMPORTANT NOTE: This SQL only updates the UserNamefield. You will have to
        ' add fields to the SQL statement in order to update allof the columns.
        ' This sub only updates the current row for efficiency.
        '
        ' Do not update the key field (in this example: id).
        ' The user could change that to a number that is already in use by the table
        '
        'TIP: When writing SQL UPDATE statements add only one field in an UPDATE statement at a time.
        ' Watch out for the missing ' ' around each string field and spaces around keywords.
        ' Extract the new information from the datagrid
        ' The cell is the column index base on the table schema
        Dim currentRow As Integer = dg.CurrentRow.Index
        Dim thisID As Integer = dg.Rows(currentRow).Cells(USERTABLE_ID).Value
        Dim thisUserID As String = dg.Rows(currentRow).Cells(USERTABLE_USERID).Value
        Dim thisPassword As String = dg.Rows(currentRow).Cells(USERTABLE_PASSWORD).Value
        Dim thisEmail As String = dg.Rows(currentRow).Cells(USERTABLE_EMAIL).Value
        ' Write the SQL statement. Don't forget to put single quotes around each VARCHAR field Tutorial: VB.NET SQL Using Azure / 14
        ' BE SMART! Hard-code in the values first before adding the variables
        ' "UPDATE userTable SET userID = 'ginny99' WHERE id = 3"
        '***********************************************************************
        '**** EDIT THE SQL TO UPDATE all of the fields for the selected row ****
        '***********************************************************************
        Dim strSQL As String = "UPDATE [" & TABLE_NAME & "] SET userID = '" & thisUserID & "',email = '" & thisEmail & "' WHERE id = " & thisID
        sendQuery(strSQL)
    End Sub

    Private Sub sendQuery(strSQL As String)
        '=========================
        ' RUN SQL STATEMENT - REFRESH GRID
        '=========================
        con.Open()
        ' Create the command with the SQL, connection, and transaction objects
        Dim cmd As New SqlCommand(strSQL, con)
        ' Execute the query getting the number of records affected (should be 1)
        Dim recordCount As Integer = cmd.ExecuteNonQuery()
        If recordCount = 1 Then
            Console.WriteLine("Update was successful.")
        Else
            Console.WriteLine("Update was NOT successful.")
        End If
        con.Close()
        'Redisplay the grid to show updated records
        Dim newSQLString As String = "SELECT * FROM [" &
        TABLE_NAME & "]"
        populateGrid(DBF_NAME, TABLE_NAME, newSQLString)
    End Sub
End Class
