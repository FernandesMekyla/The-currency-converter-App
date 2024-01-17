Public Class FrmchkChoose1
    Dim x As Decimal
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.Items.Add("USA Dollars")
        ComboBox2.Items.Add("Euros")
        ComboBox2.Items.Add("Canadian Dollar")
        ComboBox2.Items.Add("Rupees")
        ComboBox2.Items.Add("Swiss Franc")
        ComboBox2.Items.Add("Won")
        ComboBox2.Items.Add("Yen")
    End Sub

    Private Sub BtnConverttoAnyCurrency_Click(sender As Object, e As EventArgs) Handles btnConverttoAnyCurrency.Click

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "USD" Then
            x = 1.206
            lblResult.Text = Textbox1.Text * x
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Euro" Then
            x = 1.17
            lblResult.Text = Textbox1.Text * x
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Canadian Dollar" Then
            x = 1.71
            lblResult.Text = Textbox1.Text * x
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Rupees" Then
            x = 105.4
            lblResult.Text = Textbox1.Text * x
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Swiss Franc" Then
            x = 1.1
            lblResult.Text = Textbox1.Text * x
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Won" Then
            x = 1705.2
            lblResult.Text = Textbox1.Text * x
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Yen" Then
            x = 187.29
            lblResult.Text = Textbox1.Text * x
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()

    End Sub
End Class