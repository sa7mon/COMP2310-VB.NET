Imports Microsoft.VisualBasic

Public Class globals
    Public Shared ReadOnly Property AzureConnection() As String
        Get
            Return "Server=tcp:mydatabasehere.database.windows.net,1433;Database=bookCollection;User ID=deletemedbadmin@mydatabasehere;Password=pASSWORD;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;"
        End Get
    End Property
End Class
