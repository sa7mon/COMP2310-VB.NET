''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' index.aspx.vb - Contains the VB.NET code that drives the login page
' Name: Dan Salmon (https://danthesalmon.com)
' Date Created: 4/27/15
'
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient
Imports System.Data

Partial Class index
    Inherits System.Web.UI.Page
    Const DBF_NAME As String = "bookCollection"
    Const TABLE_NAME As String = "tbl_book"
    Dim da As New SqlDataAdapter()
    'Dim cmd As New SqlCommand()

    Protected Sub testLogin_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim con As New SqlConnection
        Dim reader As SqlDataReader
        Dim success As Boolean
        Dim userID As String = ""
        Try
            con.ConnectionString = globals.AzureConnection
            Dim cmd As New SqlCommand("SELECT COUNT(*) AS count, userID FROM tbl_users WHERE userName = '" & txtUserName.Text.Trim().ToString() & "' AND password='" & txtPwd.Text.Trim().ToString() & "' GROUP BY userID;", con)
            con.Open()
            ' Execute Query
            reader = cmd.ExecuteReader()

            While reader.Read()
                If (reader("count") = 1) Then
                    ' It was a successful login. Only one row was returned from the query.
                    success = True
                    userID = reader("userID")
                Else
                    success = False
                End If
            End While

            'Close the connection
            con.Close()

            ' We do the handling outside of the reader so we can close the connection faster
            If (success) Then
                redirect(userID)
            Else
                lblMsg.Text = "Error: Incorrect username or password. Please try again."
            End If

        Catch ex As Exception
            MsgBox("Error while connecting to SQL Server." & ex.Message)
            con.Close()
        End Try
    End Sub

    Public Sub redirect(user As Integer)
        ' Set the session variable so we can look the user's name up on the collection page.
        Session("userID") = user

        ' Redirect to the collection page
        Response.Redirect("myDataView.aspx", False) 'http://stackoverflow.com/a/4874947
    End Sub
End Class
