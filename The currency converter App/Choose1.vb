Public Class FrmchkChoose1
    Dim Any As Decimal
    Dim GBP As Decimal
    Dim USD As Decimal
    Dim Euro As Decimal
    Dim CAD As Decimal
    Dim Rupees As Decimal
    Dim CHF As Decimal
    Dim Won As Decimal
    Dim Yen As Decimal
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.Items.Add("USD")
        ComboBox2.Items.Add("Euro")
        ComboBox2.Items.Add("CAD")
        ComboBox2.Items.Add("Rupees")
        ComboBox2.Items.Add("CHF")
        ComboBox2.Items.Add("Won")
        ComboBox2.Items.Add("Yen")
    End Sub

    Private Sub BtnConverttoAnyCurrency_Click(sender As Object, e As EventArgs) Handles btnConverttoAnyCurrency.Click

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "US Dollars" Then
            USD = GBP * 1.206
            txtAny.Text = txtGBP.Text * 1.206
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Euro" Then
            Euro = GBP * 1.17
            txtAny.Text = txtGBP.Text * 1.17
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Canadian Dollar" Then
            CAD = GBP * 1.71
            txtAny.Text = txtGBP.Text * 1.71
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Rupees" Then
            Rupees = GBP * 105.4
            txtAny.Text = txtGBP.Text * 105.4
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Swiss Franc" Then
            CHF = GBP * 1.1
            txtAny.Text = txtGBP.Text * 1.1
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Won" Then
            Won = GBP * 1705.2
            txtAny.Text = txtGBP.Text * 1705.2
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Yen" Then
            Yen = GBP * 187.2
            txtAny.Text = txtGBP.Text * 187.29
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        txtGBP.ResetText()
        txtAny.ResetText()
    End Sub
End Class