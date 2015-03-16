Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class frmMain


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=userDatabase.mdb")
    End Sub
End Class
