Public Class Form1
    ' Structure similar to box. You don't get any benefits of OOPS
    Private Structure Customer
        'Public variables

        Public firstName As String
        Public lastName As String
        Public email As String

        Public ReadOnly Property Name() As String
            Get
                Return firstName & " " & lastName
            End Get
        End Property

    End Structure

    Private objCustomer As Customer
    Private objNewCustomer As Customer

    Private Sub btnListCustomers_Click(sender As Object, e As EventArgs) Handles btnListCustomers.Click
        objCustomer.firstName = "Jim"
        objCustomer.lastName = "Halpbert"
        objCustomer.email = "jim.halpbert@dundermiflin.com"

        objNewCustomer.firstName = "Dan"
        objNewCustomer.lastName = "Awesome"
        objNewCustomer.email = "dan.awesome@email.com"
        displayCustomer(objNewCustomer)
    End Sub

    Private Sub displayCustomer(ByVal cust As Customer)
        txtName.Text = cust.Name
        txtFirstName.Text = cust.firstName
        txtLastName.Text = cust.lastName
        txtEmail.Text = cust.email
    End Sub

End Class
