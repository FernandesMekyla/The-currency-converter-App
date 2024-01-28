Public Class FrmchkChoose1
    Dim Any As Decimal
    Dim GBP As Decimal
    Dim USD As Decimal
    Dim Euro As Decimal
    Dim CAD As Decimal
    Dim INR As Decimal
    Dim CHF As Decimal
    Dim KRW As Decimal
    Dim JPY As Decimal
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
            TextBoxAny.Text = TextBoxGBP.Text * 1.27
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Euros" Then
            Euro = 1.0 * 1.17
            TextBoxAny.Text = TextBoxGBP.Text * 1.17
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Canadian Dollar" Then
            CAD = 1.0 * 1.71
            TextBoxAny.Text = TextBoxGBP.Text * 1.71
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Rupees" Then
            INR = 1.0 * 105.52
            TextBoxAny.Text = TextBoxGBP.Text * 105.52
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Swiss Franc" Then
            CHF = 1.0 * 1.1
            TextBoxAny.Text = TextBoxGBP.Text * 1.1
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Won" Then
            KRW = 1.0 * 1693.75
            TextBoxAny.Text = TextBoxGBP.Text * 1693.75
        End If

        If ComboBox1.Text = "GBP" And ComboBox2.Text = "Yen" Then
            JPY = 1.0 * 188.14
            TextBoxAny.Text = TextBoxGBP.Text * 188.14
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        TextBoxGBP.ResetText()
        TextBoxAny.ResetText()
    End Sub

    Private Sub btnConvertToGBPCurrency_Click(sender As Object, e As EventArgs) Handles btnConvertToGBPCurrency.Click
        If ComboBox2.Text = "US Dollars" And ComboBox1.Text = "GBP" Then
            USD = 1.0 * 0.79
            TextBoxGBP.Text = TextBoxAny.Text * 0.79
        End If

        If ComboBox2.Text = "Euros" And ComboBox1.Text = "GBP" Then
            Euro = 1.0 * 0.86
            TextBoxGBP.Text = TextBoxAny.Text * 0.86
        End If

        If ComboBox2.Text = "Canadian Dollar" And ComboBox1.Text = "GBP" Then
            CAD = 1.0 * 0.59
            TextBoxGBP.Text = TextBoxAny.Text * 0.86
        End If

        If ComboBox2.Text = "Rupees" And ComboBox1.Text = "GBP" Then
            INR = 1.0 * 0.0095
            TextBoxGBP.Text = TextBoxAny.Text * 0.0095
        End If

        If ComboBox2.Text = "Swiss Franc" And ComboBox1.Text = "GBP" Then
            CHF = 1.0 * 0.91
            TextBoxGBP.Text = TextBoxAny.Text * 0.91
        End If

        If ComboBox2.Text = "Won" And ComboBox1.Text = "GBP" Then
            KRW = 1.0 * 0.00059
            TextBoxGBP.Text = TextBoxAny.Text * 0.00059
        End If

        If ComboBox2.Text = "Yen" And ComboBox1.Text = "GBP" Then
            JPY = 1.0 * 0.0053
            TextBoxGBP.Text = TextBoxAny.Text * 0.0053
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Listbox1.Items.Add(TextBoxGBP.Text)
        Listbox1.Items.Add(TextBoxAny.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Listbox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.Items.Add(TextBoxAny.Text)
        ListBox2.Items.Add(TextBoxGBP.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox2.Items.Clear()
    End Sub
End Class