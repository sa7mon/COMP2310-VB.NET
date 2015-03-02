Public Class Form1
    ' Structure similar to box. You don't get any benefits of OOPS
    Private Structure Customer
        'Public variables

        Public firstName As String
        Public lastName As String
        Public email As String

    End Structure

    Private objCustomer As Customer

    Private Sub btnListCustomers_Click(sender As Object, e As EventArgs) Handles btnListCustomers.Click

        objCustomer.firstName = "Jim"
        objCustomer.lastName = "Halpbert"
        objCustomer.email = "jim.halpbert@dundermiflin.com"
        displayCustomer(objCustomer)
    End Sub

    Private Sub displayCustomer(ByVal cust As Customer)
        txtFirstName.Text = cust.firstName
        txtLastName.Text = cust.lastName
        txtEmail.Text = cust.email
        txtName.Text = cust.firstName + " " + cust.lastName
    End Sub

End Class
