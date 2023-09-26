Public Class Form1
    Private Sub But_Click(sender As Object, e As EventArgs) Handles But.Click
        Dim totalCost As Decimal
        totalCost = 0

        If CB1.Checked Then
            totalCost += 2 * numCoke.Value
            IstOrders.Items.Add("Coca Cola " & numCoke.Value)
        End If

        If CB2.Checked Then
            totalCost += 2.5 * Num2.Value
            IstOrders.Items.Add("Prime" & Num2.Value)
        End If

        If CB3.Checked Then
            totalCost += 2.5 * Num3.Value
            IstOrders.Items.Add("Sprite" & Num3.Value)
        End If

        If CB4.Checked Then
            totalCost += 1 * Num4.Value
            IstOrders.Items.Add("Water" & Num4.Value)
        End If

        If CB5.Checked Then
            totalCost += 2.5 * Num5.Value
            IstOrders.Items.Add("Tango" & Num5.Value)
        End If

        If CB6.Checked Then
            totalCost += 2.5 * Num6.Value
            IstOrders.Items.Add("Fanta" & Num6.Value)
        End If

        If CB7.Checked Then
            totalCost += 2.5 * Num7.Value
            IstOrders.Items.Add("Apple Juise" & Num7.Value)
        End If

        If CB8.Checked Then
            totalCost += 2.5 * Num8.Value
            IstOrders.Items.Add("Limonade" & Num8.Value)
        End If


        If totalCost < 3 Then
            lbl.Text = "Minimum order is £3 - buy more"
        Else
            lbl.Text = totalCost
        End If
    End Sub
End Class
