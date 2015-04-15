
Partial Class index
    Inherits System.Web.UI.Page

    Protected Sub btnChoice_Click(sender As Object, e As EventArgs) Handles btnChoice.Click
        lblChoice.Text = "You like: " & lstFlavor.SelectedItem.Text
    End Sub

    Protected Sub btnChoice2_Click(sender As Object, e As EventArgs) Handles btnChoice2.Click
        If radGoldNugget.Checked Then
            lblChoice2.Text = "You like Gold Nugget"
        ElseIf radSassaphrass.Checked Then
            lblChoice2.Text = "You like Sassaphrass"
        ElseIf radMooseDroppings.Checked Then
            lblChoice2.Text = "You like moose droppings."
        End If
    End Sub
End Class
