Imports System.Data.SqlClient
Imports System.Data

Partial Class index
    Inherits System.Web.UI.Page
    Const DBF_NAME As String = "userDatabase"
    Const TABLE_NAME As String = "userTable"
    Dim da As New SqlDataAdapter()
    Dim cmd As New SqlCommand()
    Dim ds As New DataSet()



    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            refreshGrid()
            populatePhoneList("SELECT DISTINCT [phone] FROM [" & TABLE_NAME & "]")
        End If
    End Sub
    Private Sub populatePhoneList(ByVal strSQL As String)
        Dim dsList As New DataSet

        Try
            con.open()
            da.SelectCommand = New SqlCommand(strSQL, con)
            da.Fill(dsList, "userTable")
            con.close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        lstPhone.DataSource = dsList
        lstPhone.DataValueField = "phone"
        lstPhone.DataTextField = "phone"
        lstPhone.DataBind()
    End Sub
    Private Sub refreshGrid()
        Dim strSQL As String = "SELECT * FROM [" & TABLE_NAME & "]"
        Try
            con.Open()
            da.SelectCommand = New SqlCommand(strSQL, con)
            da.Fill(ds, "userTable")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ' Get the dataview from the table
        ' alternative to: ds.Tables(0)
        ' A dataview allows sorting
        Dim dv As DataView = ds.Tables(TABLE_NAME).DefaultView

        'Fill the form objects with data
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

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newUserID As String = txtUserID.Text
        Dim newUserName As String = txtUserName.Text
        Dim newEmail As String = txtEmail.Text
        Dim newPassword As String = txtPassword.Text
        Dim newPhone As String = txtPhone.Text


        Dim strSQL As String = "INSERT INTO [" & TABLE_NAME & "] (userID, userName, password, email, phone) VALUES ('" & newUserID & "', '" & newUserName & "', '" & newPassword & "', '" & newEmail & "', '" & newPhone & "')"
        'MsgBox(strSQL)
        runNonSelect(strSQL)
        refreshGrid()
    End Sub

    Protected Sub gv_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles gv.RowCancelingEdit
        ' Reset back to an unknown index position
        gv.EditIndex = -1
        ' bind the datagrid
        refreshGrid()
    End Sub


    Protected Sub gv_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles gv.RowDeleting
        Dim thisID As String
        Dim strSQL As String

        ' Get the id - Cell(0) is the first column in the grid
        ' If you have the delete or edit links on the left this column will change!
        thisID = gv.Rows(e.RowIndex).Cells(0).Text

        ' Delete the specific record
        ' Use hard-coded values first to check your work
        ' strSQL = "DELETE FROM userTable WHERE id = 25"
        strSQL = "DELETE FROM " & TABLE_NAME & " WHERE id = " & thisID
        runNonSelect(strSQL)
        refreshGrid()
    End Sub

    Protected Sub gv_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles gv.RowEditing
        ' set the grid to the selected row
        gv.EditIndex = e.NewEditIndex
        refreshGrid()
    End Sub

    Protected Sub gv_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles gv.RowUpdating
        ' Use type hyperlink if you are embedding a hyperlink in the column
        ' instead of a textbox
        'Dim name as Hyperlink

        Dim thisID As String
        Dim thisUserID As TextBox
        Dim thisUserName As TextBox
        Dim thisPassword As TextBox
        Dim thisEmail As TextBox
        Dim thisPhone As TextBox

        Dim strSQL As String

        ' Col 0 is id field
        thisID = gv.Rows(e.RowIndex).Cells(0).Text

        ' When handling a read/write column, treat as a text box
        thisUserID = CType(gv.Rows(e.RowIndex).Cells(1).Controls(0), TextBox)
        thisUserName = CType(gv.Rows(e.RowIndex).Cells(2).Controls(0), TextBox)
        thisEmail = CType(gv.Rows(e.RowIndex).Cells(3).Controls(0), TextBox)
        thisPassword = CType(gv.Rows(e.RowIndex).Cells(4).Controls(0), TextBox)
        thisPhone = CType(gv.Rows(e.RowIndex).Cells(5).Controls(0), TextBox)

        strSQL = "UPDATE userTable SET userID = '" & thisUserID.Text & "',userName = '" & thisUserName.Text & "',password = '" & thisPassword.Text & "',email = '" & thisEmail.Text & "', phone = '" & thisPhone.Text & "' WHERE id='" & thisID & "'"
        runNonSelect(strSQL)
        gv.EditIndex = -1
        refreshGrid()
    End Sub
End Class
