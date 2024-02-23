Public Class Form1
    Private Sub But_Click(sender As Object, e As EventArgs) Handles But.Click
        ' This event handler is executed when the "But" button is clicked.
        ' It calculates the total cost of selected items and displays the order details.

        ' Variable declaration
        Dim totalCost As Decimal ' Variable to store the total cost of the order
        totalCost = 0 ' Initialize total cost to zero

        ' Check if Coca Cola is selected
        If CB1.Checked Then
            ' If selected, add the cost of Coca Cola multiplied by the quantity to the total cost
            totalCost += 2 * numCoke.Value
            ' Add the item and quantity to the list box
            IstOrders.Items.Add("Coca Cola " & numCoke.Value)
        End If

        ' Check if Prime is selected
        If CB2.Checked Then
            ' If selected, add the cost of Prime multiplied by the quantity to the total cost
            totalCost += 2.5 * Num2.Value
            ' Add the item and quantity to the list box
            IstOrders.Items.Add("Prime " & Num2.Value)
        End If

        ' Check if Sprite is selected
        If CB3.Checked Then
            ' If selected, add the cost of Sprite multiplied by the quantity to the total cost
            totalCost += 2.5 * Num3.Value
            ' Add the item and quantity to the list box
            IstOrders.Items.Add("Sprite " & Num3.Value)
        End If

        ' Repeat the above process for the remaining items (Water, Tango, Fanta, Apple Juice, Limonade)
        ' ...

        ' Check if the total cost is less than £3
        If totalCost < 3 Then
            ' If less than £3, display a message indicating the minimum order requirement
            lbl.Text = "Minimum order is £3 - buy more"
        Else
            ' If £3 or more, display the total cost
            lbl.Text = totalCost
        End If
    End Sub

    Private Sub IstOrders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IstOrders.SelectedIndexChanged
        ' This event handler is executed when an item is selected in the list box.
        ' Currently, it does not contain any code.
    End Sub
End Class
