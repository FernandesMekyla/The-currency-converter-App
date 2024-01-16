Public Class frmchkChoose1
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Text = "Choose your Currency"
        ComboBox1.Items.Add("USA Dollars")
        ComboBox1.Items.Add("Euros")
        ComboBox1.Items.Add("Canadian Dollar")
        ComboBox1.Items.Add("Rupees")
        ComboBox1.Items.Add("Swiss Franc")
        ComboBox1.Items.Add("Won")
        ComboBox1.Items.Add("Yen")
    End Sub

    Private Sub btnConverttoAnyCurrency_Click(sender As Object, e As EventArgs) Handles btnConverttoAnyCurrency.Click
        Dim Us_Dollars As Double = 1.2
        Dim 
    End Sub

    Private Sub btnConvertToGBPCurrency_Click(sender As Object, e As EventArgs) Handles btnConvertToGBPCurrency.Click

    End Sub
End Class