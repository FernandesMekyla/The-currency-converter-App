Public Class FrmchkChoose2
    Dim Any As Decimal
    Dim GBP As Decimal
    Dim USD As Decimal
    Dim Euros As Decimal
    Dim CAD As Decimal
    Dim Rupees As Decimal
    Dim CHF As Decimal
    Dim Won As Decimal
    Dim Yen As Decimal
    Dim AUD As Decimal
    Dim PLN As Decimal
    Dim PKR As Decimal
    Dim THB As Decimal
    Dim NZD As Decimal
    Dim HUF As Decimal
    Dim DKK As Decimal
    Dim UAH As Decimal
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        FrmThankyouPage.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        txtAmountAny1.ResetText()
        txtAmountAny2.ResetText()
    End Sub

    Private Sub ComboBoxAny1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAny1.SelectedIndexChanged
        ComboBoxAny1.Items.Add("Won")
        ComboBoxAny1.Items.Add("Yen")
        ComboBoxAny1.Items.Add("Swiss Franc")
        ComboBoxAny1.Items.Add("USD")
        ComboBoxAny1.Items.Add("Euro")
        ComboBoxAny1.Items.Add("Canadian Dollar")
        ComboBoxAny1.Items.Add("GBP")
    End Sub

    Private Sub ComboBoxAny2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAny2.SelectedIndexChanged
        ComboBoxAny2.Items.Add("AUD")
        ComboBoxAny2.Items.Add("Polish Zloty")
        ComboBoxAny2.Items.Add("Pakistan Rupee")
        ComboBoxAny2.Items.Add("Baht")
        ComboBoxAny2.Items.Add("New Zealand Dollar")
        ComboBoxAny2.Items.Add("Forint")
        ComboBoxAny2.Items.Add("DKK")
        ComboBoxAny2.Items.Add("UAH")
        ComboBoxAny2.Items.Add("GBP")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmQuestion1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = WON * 0.0011
            txtAmountAny2.Text = txtAmountAny1.Text * 0.0011
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = Won * 0.003
            txtAmountAny2.Text = txtAmountAny1.Text * 0.003
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = Won * 0.2
            txtAmountAny2.Text = txtAmountAny1.Text * 0.2
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Baht" Then
            THB = Won * 0.027
            txtAmountAny2.Text = txtAmountAny1.Text * 0.027
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = Won * 0.0012
            txtAmountAny2.Text = txtAmountAny1.Text * 0.0012
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Forint" Then
            HUF = Won * 0.26
            txtAmountAny2.Text = txtAmountAny1.Text * 0.26
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "DKK" Then
            DKK = Won * 0.0051
            txtAmountAny2.Text = txtAmountAny1.Text * 0.0051
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "UAH" Then
            UAH = Won * 0.028
            txtAmountAny2.Text = txtAmountAny1.Text * 0.028
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "AUD" Then
            AUD =
            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "PLN" Then
            PLN =
            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "PKR" Then
            PKR =
            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "THB" Then
            THB =
            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "NZD" Then
            NZD =
            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "HUF" Then
            HUF =
            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "DKK" Then
            DKK = Yen *
            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "UAH" Then
            UAH =
            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "CHF" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then
            UAH = Won * 0.028
            txtAmountAny2.Text = txtAmountAny1.Text * 0.028
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then
            UAH = Won * 0.028
            txtAmountAny2.Text = txtAmountAny1.Text * 0.028
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then
            UAH = Won * 0.028
            txtAmountAny2.Text = txtAmountAny1.Text * 0.028
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text *
        End If

        If ComboBoxAny1.Text = "" And ComboBoxAny2.Text = "" Then

            txtAmountAny2.Text = txtAmountAny1.Text * 
        End If
    End Sub
End Class