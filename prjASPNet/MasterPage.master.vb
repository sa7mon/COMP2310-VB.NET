''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' MasterPage.master.vb - Contains the VB.NET code that drives the master page.
' Name: Dan Salmon (https://danthesalmon.com)
' Date Created: 4/27/15
'
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Data.SqlClient

Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Protected Sub onMasterPageLoad(sender As Object, e As EventArgs) Handles Me.Load
        'Runs whenever a child of this master page is loaded.
        lblGreeting.Text = "Hello, Guest"

        If Not Session("userID") Is Nothing Then
            ' Query the DB for the username if the user has logged in successfully. 

            Dim con As New SqlConnection
            Dim reader As SqlDataReader
            Try
                con.ConnectionString = globals.AzureConnection
                Dim cmd As New SqlCommand("SELECT userName FROM tbl_users WHERE userID =" & Session("userID"), con)
                con.Open()
                ' Execute Query    '
                reader = cmd.ExecuteReader()

                While reader.Read()
                    lblGreeting.Text = "Hello, " & reader("userName")
                End While

                con.Close()

            Catch ex As Exception
                MsgBox("Error while connecting to SQL Server." & ex.Message)
                con.Close()
            End Try
        End If

    End Sub
End Class

