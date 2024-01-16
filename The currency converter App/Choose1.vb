Public Class FrmchkChoose1
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.Text = "Choose your Currency"
        ComboBox2.Items.Add("USA Dollars")
        ComboBox2.Items.Add("Euros")
        ComboBox2.Items.Add("Canadian Dollar")
        ComboBox2.Items.Add("Rupees")
        ComboBox2.Items.Add("Swiss Franc")
        ComboBox2.Items.Add("Won")
        ComboBox2.Items.Add("Yen")
    End Sub

    Private Sub BtnConverttoAnyCurrency_Click(sender As Object, e As EventArgs) Handles btnConverttoAnyCurrency.Click
        Dim Us_Dollars As Double = 1.206 * 1.2
    End Sub

    Private Sub BtnConvertToGBPCurrency_Click(sender As Object, e As EventArgs) Handles btnConvertToGBPCurrency.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Text = "Choose your Currency"
        ComboBox2.Items.Add("GBP")
    End Sub
End Class