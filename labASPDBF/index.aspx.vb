Imports System.Data.SqlClient
Imports System.Data

Partial Class index
    Inherits System.Web.UI.Page
    Const DBF_NAME As String = "userDatabase"
    Const TABLE_NAME As String = "userTable"


    Dim da As New SqlDataAdapter()
    Dim cmd As New SqlCommand()
    Dim ds As New DataSet()

End Class
