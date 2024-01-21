Public Class FrmchkChoose1
    Dim Any As Decimal
    Dim GBP As Decimal
    Dim USD As Decimal
    Dim Euros As Decimal
    Dim CAD As Decimal
    Dim Rupees As Decimal
    Dim CHF As Decimal
    Dim Won As Decimal
    Dim Yen As Decimal
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.Items.Add("US Dollars")
        ComboBox2.Items.Add("Euros")
        ComboBox2.Items.Add("CAD")
        ComboBox2.Items.Add("Rupees")
        ComboBox2.Items.Add("CHF")
        ComboBox2.Items.Add("Won")
        ComboBox2.Items.Add("Yen")
    End Sub

    Private Sub BtnConverttoAnyCurrency_Click(sender As Object, e As EventArgs) Handles btnConverttoAnyCurrency.Click

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "US Dollars" Then
            USD = 1.0 * 1.27
            txtAny.Text = txtGBP.Text * 1.27
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Euros" Then
            Euros = 1.0 * 1.17
            txtAny.Text = txtGBP.Text * 1.17
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Canadian Dollar" Then
            CAD = 1.0 * 1.71
            txtAny.Text = txtGBP.Text * 1.71
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Rupees" Then
            Rupees = 1.0 * 105.52
            txtAny.Text = txtGBP.Text * 105.52
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Swiss Franc" Then
            CHF = 1.0 * 1.1
            txtAny.Text = txtGBP.Text * 1.1
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Won" Then
            Won = 1.0 * 1693.75
            txtAny.Text = txtGBP.Text * 1693.75
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Yen" Then
            Yen = 1.0 * 188.14
            txtAny.Text = txtGBP.Text * 188.14
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        txtGBP.ResetText()
        txtAny.ResetText()
    End Sub

    Private Sub btnConvertToGBPCurrency_Click(sender As Object, e As EventArgs) Handles btnConvertToGBPCurrency.Click
        If ComboBox2.Text = "USD" And ComboBox1.Text = "GBP" Then
            USD = 1.0 * 1.27
            txtAny.Text = txtGBP.Text * 1.27
        End If

        If ComboBox2.Text = "Euros" And ComboBox1.Text = "GBP" Then
            Euros = 1.0 * 1.17
            txtAny.Text = txtGBP.Text * 1.17
        End If

        If ComboBox2.Text = "CAD" And ComboBox1.Text = "GBP" Then
            CAD = 1.0 * 1.71
            txtAny.Text = txtGBP.Text * 1.71
        End If

        If ComboBox2.Text = "Rupees" And ComboBox1.Text = "GBP" Then
            Rupees = 1.0 * 105.52
            txtAny.Text = txtGBP.Text * 105.52
        End If

        If ComboBox2.Text = "CHF" And ComboBox1.Text = "GBP" Then
            CHF = 1.0 * 1.1
            txtAny.Text = txtGBP.Text * 1.1
        End If

        If ComboBox2.Text = "Won" And ComboBox1.Text = "GBP" Then
            Won = 1.0 * 1693.75
            txtAny.Text = txtGBP.Text * 1693.75
        End If

        If ComboBox2.Text = "Yen" And ComboBox1.Text = "GBP" Then
            Yen = 1.0 * 188.14
            txtAny.Text = txtGBP.Text * 188.14
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        FrmThankyouPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmQuestion1.Show()
        Me.Hide()
    End Sub
End Class