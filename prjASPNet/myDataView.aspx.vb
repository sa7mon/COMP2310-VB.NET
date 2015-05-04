''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' myDataView.aspx.vb - Contains the VB.NET code that drives the book collection page.
' Name: Dan Salmon (https://danthesalmon.com)
' Date Created: 4/27/15
'
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports System.Data.SqlClient
Imports System.Data

Partial Class collection
    Inherits System.Web.UI.Page
    Const DBF_NAME As String = "bookCollection"
    Const TABLE_NAME As String = "tbl_book"
    Dim da As New SqlDataAdapter()
    Dim cmd As New SqlCommand()
    Dim ds As New DataSet()
    Dim con = New SqlConnection(globals.AzureConnection)

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            refreshGrid()
        End If
    End Sub

    Private Sub refreshGrid()
        Dim strSQL As String = "SELECT book.ISBN, book.bookName, book.author, book.cover, booktype.typeDesc FROM tbl_book as book INNER JOIN tbl_book_type as booktype ON book.type = booktype.id"
        Try
            con.Open()
            da.SelectCommand = New SqlCommand(strSQL, con)
            da.Fill(ds, TABLE_NAME)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        ' Connect gridview to dataAdapter
        Dim dv As DataView = ds.Tables(TABLE_NAME).DefaultView

        ' Populate gridview
        gv.DataSource = dv
        gv.DataBind()

    End Sub

    Sub runNonSelect(ByVal strSQL As String)
        Try
            cmd.Connection = con
            cmd.CommandText = strSQL
            con.open()
            cmd.ExecuteNonQuery()
            con.close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub gv_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles gv.RowEditing
        ' set the grid to the selected row
        gv.EditIndex = e.NewEditIndex
        refreshGrid()
    End Sub
    Protected Sub gv_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles gv.RowCancelingEdit
        ' Reset back to an unknown index position
        gv.EditIndex = -1
        ' bind the datagrid
        refreshGrid()
    End Sub
    Protected Sub gv_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles gv.RowUpdating
        Dim thisISBN As String
        Dim thisTitle As TextBox
        Dim thisAuthor As TextBox
        Dim thisCover As TextBox
        Dim strSQL As String

        ' Col 0 is id field
        thisISBN = gv.Rows(e.RowIndex).Cells(0).Text

        ' When handling a read/write column, treat as a text box
        thisTitle = CType(gv.Rows(e.RowIndex).Cells(1).Controls(0), TextBox)
        thisAuthor = CType(gv.Rows(e.RowIndex).Cells(2).Controls(0), TextBox)
        thisCover = CType(gv.Rows(e.RowIndex).Cells(3).Controls(0), TextBox)

        strSQL = "UPDATE tbl_book SET bookName='" & thisTitle.Text & "', author='" & thisAuthor.Text & "', cover='" & thisCover.Text & "' WHERE isbn = '" & thisISBN & "'"
        'MsgBox(strSQL)
        runNonSelect(strSQL)
        gv.EditIndex = -1
        refreshGrid()
    End Sub

    Protected Sub gv_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles gv.RowDeleting
        Dim thisISBN As String
        Dim strSQL As String

        ' Get the id - Cell(0) is the first column in the grid
        thisISBN = gv.Rows(e.RowIndex).Cells(0).Text

        ' Delete the specific record
        strSQL = "DELETE FROM " & TABLE_NAME & " WHERE ISBN = '" & thisISBN & "'"
        runNonSelect(strSQL)
        refreshGrid()
    End Sub

    Protected Sub addBook(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' First, we need to get all the data to build our SQL statement.
        ' We'll just assume that everything has been filled in this time.
        Dim qryAddBook As String = "INSERT INTO tbl_book VALUES ('"

        qryAddBook &= txtISBN.Text.Trim().ToString() & "', '" & txtTitle.Text.Trim().ToString() & "'"
        qryAddBook &= ", '" & txtAuthor.Text.Trim().ToString() & "', '" & rblistCover.SelectedValue.ToString()
        qryAddBook &= "', " & ddType.SelectedValue.ToString & ");"

        'MsgBox(qryAddBook)
        runNonSelect(qryAddBook)
        refreshGrid()
    End Sub

End Class
