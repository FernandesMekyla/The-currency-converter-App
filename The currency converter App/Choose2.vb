Public Class FrmchkChoose2
    Dim Any As Decimal
    Dim GBP As Decimal
    Dim USD As Decimal
    Dim Euro As Decimal
    Dim CAD As Decimal
    Dim INR As Decimal
    Dim CHF As Decimal
    Dim KRW As Decimal
    Dim JPY As Decimal
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
        ComboBoxAny1.Items.Add("US Dollars")
        ComboBoxAny1.Items.Add("Euros")
        ComboBoxAny1.Items.Add("Canadian Dollar")
        ComboBoxAny1.Items.Add("GBP")
        ComboBoxAny1.Items.Add("Rupees")
    End Sub

    Private Sub ComboBoxAny2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAny2.SelectedIndexChanged
        ComboBoxAny2.Items.Add("Australian Dollar")
        ComboBoxAny2.Items.Add("Polish Zloty")
        ComboBoxAny2.Items.Add("Pakistan Rupee")
        ComboBoxAny2.Items.Add("Baht")
        ComboBoxAny2.Items.Add("New Zealand Dollar")
        ComboBoxAny2.Items.Add("Forint")
        ComboBoxAny2.Items.Add("DKK")
        ComboBoxAny2.Items.Add("UAH")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmQuestion1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConvertAny1ToAny2.Click

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = KRW * 0.0011
            txtAmountAny2.Text = txtAmountAny1.Text * 0.0011
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = KRW * 0.003
            txtAmountAny2.Text = txtAmountAny1.Text * 0.003
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = KRW * 0.2
            txtAmountAny2.Text = txtAmountAny1.Text * 0.2
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Baht" Then
            THB = KRW * 0.027
            txtAmountAny2.Text = txtAmountAny1.Text * 0.027
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = KRW * 0.0012
            txtAmountAny2.Text = txtAmountAny1.Text * 0.0012
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Forint" Then
            HUF = KRW * 0.26
            txtAmountAny2.Text = txtAmountAny1.Text * 0.26
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "DKK" Then
            DKK = KRW * 0.0051
            txtAmountAny2.Text = txtAmountAny1.Text * 0.0051
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "UAH" Then
            UAH = KRW * 0.028
            txtAmountAny2.Text = txtAmountAny1.Text * 0.028
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = JPY * 0.01
            txtAmountAny2.Text = txtAmountAny1.Text * 0.01
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = JPY * 0.027
            txtAmountAny2.Text = txtAmountAny1.Text * 0.027
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = JPY * 1.89
            txtAmountAny2.Text = txtAmountAny1.Text * 1.89
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Baht" Then
            THB = JPY * 0.24
            txtAmountAny2.Text = txtAmountAny1.Text * 0.24
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Forint" Then
            HUF = JPY * 2.37
            txtAmountAny2.Text = txtAmountAny1.Text * 2.37
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "DKK" Then
            DKK = JPY * 0.046
            txtAmountAny2.Text = txtAmountAny1.Text * 0.046
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "UAH" Then
            UAH = JPY * 0.25
            txtAmountAny2.Text = txtAmountAny1.Text * 0.25
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = JPY * 0.0011
            txtAmountAny2.Text = txtAmountAny1.Text * 0.0011
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = CHF * 1.75
            txtAmountAny2.Text = txtAmountAny1.Text * 1.75
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = CHF * 4.61
            txtAmountAny2.Text = txtAmountAny1.Text * 4.61
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "Baht" Then
            THB = CHF * 40.85
            txtAmountAny2.Text = txtAmountAny1.Text * 40.85
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = CHF * 321.83
            txtAmountAny2.Text = txtAmountAny1.Text * 321.83
        End If

        If ComboBoxAny1.Text = "Swis Franc" And ComboBoxAny2.Text = "Forint" Then
            HUF = CHF * 403.76
            txtAmountAny2.Text = txtAmountAny1.Text * 403.76
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "DKK" Then
            DKK = CHF * 7.88
            txtAmountAny2.Text = txtAmountAny1.Text * 7.88
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "UAH" Then
            UAH = CHF * 43.13
            txtAmountAny2.Text = txtAmountAny1.Text * 43.14
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = CHF * 0.53
            txtAmountAny2.Text = txtAmountAny1.Text * 0.53
        End If
        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = INR * 0.018
            txtAmountAny2.Text = txtAmountAny1.Text * 0.018
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = INR * 0.048
            txtAmountAny2.Text = txtAmountAny1.Text * 0.048
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = INR * 3.36
            txtAmountAny2.Text = txtAmountAny1.Text * 3.36
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = INR * 0.02
            txtAmountAny2.Text = txtAmountAny1.Text * 0.02
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Baht" Then
            THB = INR * 0.43
            txtAmountAny2.Text = txtAmountAny1.Text * 0.43
        End If
        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Forint" Then
            HUF = INR * 4.21
            txtAmountAny2.Text = txtAmountAny1.Text * 4.21
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "DKK" Then
            DKK = INR * 0.082
            txtAmountAny2.Text = txtAmountAny1.Text * 0.082
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "UAH" Then
            UAH = INR * 0.45
            txtAmountAny2.Text = txtAmountAny1.Text * 0.45
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = CAD * 1.13
            txtAmountAny2.Text = txtAmountAny1.Text * 1.13
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = CAD * 2.97
            txtAmountAny2.Text = txtAmountAny1.Text * 2.97
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = CAD * 208.12
            txtAmountAny2.Text = txtAmountAny1.Text * 208.12
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Baht" Then
            THB = CAD * 26.43
            txtAmountAny2.Text = txtAmountAny1.Text * 26.43
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = CAD * 1.22
            txtAmountAny2.Text = txtAmountAny1.Text * 1.22
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Forint" Then
            HUF = CAD * 260.73
            txtAmountAny2.Text = txtAmountAny1.Text * 260.73
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "DKK" Then
            DKK = CAD * 5.09
            txtAmountAny2.Text = txtAmountAny1.Text * 5.09
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "UAH" Then
            UAH = CAD * 27.92
            txtAmountAny2.Text = txtAmountAny1.Text * 27.92
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = USD * 1.52
            txtAmountAny2.Text = txtAmountAny1.Text * 1.52
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = USD * 4.0
            txtAmountAny2.Text = txtAmountAny1.Text * 4.0
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = USD * 279.1
            txtAmountAny2.Text = txtAmountAny1.Text * 279.1
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Baht" Then
            THB = USD * 35.6
            txtAmountAny2.Text = txtAmountAny1.Text * 35.6
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = USD * 1.64
            txtAmountAny2.Text = txtAmountAny1.Text * 1.64
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Forint" Then
            HUF = USD * 352.08
            txtAmountAny2.Text = txtAmountAny1.Text * 352.08
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "DKK" Then
            DKK = USD * 6.85
            txtAmountAny2.Text = txtAmountAny1.Text * 6.85
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "UAH" Then
            UAH = USD * 37.42
            txtAmountAny2.Text = txtAmountAny1.Text * 37.42
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = GBP * 1.93
            txtAmountAny2.Text = txtAmountAny1.Text * 1.93
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = GBP * 5.09
            txtAmountAny2.Text = txtAmountAny1.Text * 5.09
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = GBP * 354.68
            txtAmountAny2.Text = txtAmountAny1.Text * 354.68
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Baht" Then
            THB = GBP * 45.23
            txtAmountAny2.Text = txtAmountAny1.Text * 45.23
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "New Zeland Dollar" Then
            NZD = GBP * 2.09
            txtAmountAny2.Text = txtAmountAny1.Text * 2.09
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "DKK" Then
            DKK = GBP * 8.71
            txtAmountAny2.Text = txtAmountAny1.Text * 8.71
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "UAH" Then
            UAH = GBP * 47.57
            txtAmountAny2.Text = txtAmountAny1.Text * 47.57
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Forint" Then
            HUF = GBP * 447.22
            txtAmountAny2.Text = txtAmountAny1.Text * 477.22
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = Euro * 1.66
            txtAmountAny2.Text = txtAmountAny1.Text * 1.66
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = Euro * 4.36
            txtAmountAny2.Text = txtAmountAny1.Text * 4.36
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = Euro * 303.91
            txtAmountAny2.Text = txtAmountAny1.Text * 303.91
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Baht" Then
            THB = Euro * 38.76
            txtAmountAny2.Text = txtAmountAny1.Text * 38.76
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = Euro * 1.79
            txtAmountAny2.Text = txtAmountAny1.Text * 1.79
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "DKK" Then
            DKK = Euro * 7.46
            txtAmountAny2.Text = txtAmountAny1.Text * 7.46
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "UAH" Then
            UAH = Euro * 40.74
            txtAmountAny2.Text = txtAmountAny1.Text * 40.74
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Forint" Then
            HUF = Euro * 383.17
            txtAmountAny2.Text = txtAmountAny1.Text * 383.17
        End If
    End Sub

    Private Sub btnConvertAny2toAny1_Click(sender As Object, e As EventArgs) Handles btnConvertAny2toAny1.Click
        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Won" Then
            KRW = AUD * 878.55
            txtAmountAny1.Text = txtAmountAny2.Text * 878.55
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Yen" Then
            JPY = AUD * 97.36
            txtAmountAny1.Text = txtAmountAny2.Text * 97.36
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = AUD * 0.57
            txtAmountAny1.Text = txtAmountAny2.Text * 0.57
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "US Dollars" Then
            USD = AUD * 0.66
            txtAmountAny1.Text = txtAmountAny2.Text * 0.66
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = AUD * 0.89
            txtAmountAny1.Text = txtAmountAny2.Text * 0.89
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "GBP" Then
            GBP = AUD * 0.52
            txtAmountAny1.Text = txtAmountAny2.Text * 0.52
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Euros" Then
            Euro = AUD * 0.61
            txtAmountAny1.Text = txtAmountAny2.Text * 0.61
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Rupees" Then
            INR = AUD * 54.69
            txtAmountAny1.Text = txtAmountAny2.Text * 54.69
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Rupees" Then
            INR = PLN * 20.66
            txtAmountAny1.Text = txtAmountAny2.Text * 20.66
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Euros" Then
            Euro = PLN * 0.23
            txtAmountAny1.Text = txtAmountAny2.Text * 0.23
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "GBP" Then
            GBP = PLN * 0.2
            txtAmountAny1.Text = txtAmountAny2.Text * 0.2
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = PLN * 0.33
            txtAmountAny1.Text = txtAmountAny2.Text * 0.33
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "US Dollars" Then
            USD = PLN * 0.25
            txtAmountAny1.Text = txtAmountAny2.Text * 0.25
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = PLN * 0.21
            txtAmountAny1.Text = txtAmountAny2.Text * 0.21
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Yen" Then
            JPY = PLN * 36.8
            txtAmountAny1.Text = txtAmountAny2.Text * 36.8
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Won" Then
            KRW = PLN * 332.0
            txtAmountAny1.Text = txtAmountAny2.Text * 332.0
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Won" Then
            KRW = PKR * 4.76
            txtAmountAny1.Text = txtAmountAny2.Text * 4.76
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Yen" Then
            JPY = PKR * 0.53
            txtAmountAny1.Text = txtAmountAny2.Text * 0.53
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = PKR * 0.0031
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0031
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "US Dollars" Then
            USD = PKR * 0.0036
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0036
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = PKR * 0.0048
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0048
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "GBP" Then
            GBP = PKR * 0.0028
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0028
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Euros" Then
            Euro = PKR * 0.0033
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0033
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Rupees" Then
            INR = PKR * 0.3
            txtAmountAny1.Text = txtAmountAny2.Text * 0.3
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Rupees" Then
            INR = HUF * 0.23
            txtAmountAny1.Text = txtAmountAny2.Text * 0.23
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Euros" Then
            Euro = HUF * 0.0026
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0026
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = HUF * 0.0038
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0038
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "US Dollars" Then
            USD = HUF * 0.0028
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0028
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "GBP" Then
            GBP = HUF * 0.0022
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0022
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = HUF * 0.0024
            txtAmountAny1.Text = txtAmountAny2.Text * 0.0024
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Yen" Then
            JPY = HUF * 0.41
            txtAmountAny1.Text = txtAmountAny2.Text * 0.41
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Won" Then
            KRW = HUF * 3.74
            txtAmountAny1.Text = txtAmountAny2.Text * 3.74
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "US Dollars" Then
            USD = THB * 0.028
            txtAmountAny1.Text = txtAmountAny2.Text * 0.028
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Rupees" Then
            INR = THB * 2.33
            txtAmountAny1.Text = txtAmountAny2.Text * 2.33
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "GBP" Then
            GBP = THB * 0.022
            txtAmountAny1.Text = txtAmountAny2.Text * 0.022
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = THB * 0.038
            txtAmountAny1.Text = txtAmountAny2.Text * 0.038
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Euros" Then
            Euro = THB * 0.026
            txtAmountAny1.Text = txtAmountAny2.Text * 0.026
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = THB * 0.024
            txtAmountAny1.Text = txtAmountAny2.Text * 0.024
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Yen" Then
            JPY = THB * 4.16
            txtAmountAny1.Text = txtAmountAny2.Text * 4.16
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Won" Then
            KRW = THB * 37.48
            txtAmountAny1.Text = txtAmountAny2.Text * 37.48
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Yen" Then
            JPY = NZD * 90.28
            txtAmountAny1.Text = txtAmountAny2.Text * 90.28
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Won" Then
            KRW = NZD * 813.82
            txtAmountAny1.Text = txtAmountAny2.Text * 813.8
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = NZD * 0.53
            txtAmountAny1.Text = txtAmountAny2.Text * 0.53
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = NZD * 0.82
            txtAmountAny1.Text = txtAmountAny2.Text * 0.82
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "US Dollars" Then
            USD = NZD * 0.61
            txtAmountAny1.Text = txtAmountAny2.Text * 0.61
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "GBP" Then
            GBP = NZD * 0.48
            txtAmountAny1.Text = txtAmountAny2.Text * 0.48
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Rupees" Then
            INR = NZD * 50.65
            txtAmountAny1.Text = txtAmountAny2.Text * 50.65
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Euros" Then
            Euro = NZD * 0.56
            txtAmountAny1.Text = txtAmountAny2.Text * 0.56
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Won" Then
            KRW = DKK * 194.43
            txtAmountAny1.Text = txtAmountAny2.Text * 194.43
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Yen" Then
            JPY = DKK * 21.57
            txtAmountAny1.Text = txtAmountAny2.Text * 21.57
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = DKK * 0.13
            txtAmountAny1.Text = txtAmountAny2.Text * 0.13
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = DKK * 0.2
            txtAmountAny1.Text = txtAmountAny2.Text * 0.2
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "GBP" Then
            GBP = DKK * 0.11
            txtAmountAny1.Text = txtAmountAny2.Text * 0.11
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "US Dollars" Then
            USD = DKK * 0.15
            txtAmountAny1.Text = txtAmountAny2.Text * 0.15
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Rupees" Then
            INR = DKK * 12.11
            txtAmountAny1.Text = txtAmountAny2.Text * 12.11
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Euros" Then
            Euro = DKK * 0.13
            txtAmountAny1.Text = txtAmountAny2.Text * 0.13
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Won" Then
            KRW = UAH * 35.27
            txtAmountAny1.Text = txtAmountAny2.Text * 35.27
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Yen" Then
            JPY = UAH * 3.91
            txtAmountAny1.Text = txtAmountAny2.Text * 3.91
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = UAH * 0.023
            txtAmountAny1.Text = txtAmountAny2.Text * 0.023
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = UAH * 0.036
            txtAmountAny1.Text = txtAmountAny2.Text * 0.036
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "GBP" Then
            GBP = UAH * 0.021
            txtAmountAny1.Text = txtAmountAny2.Text * 0.021
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "US Dollars " Then
            USD = UAH * 0.026
            txtAmountAny1.Text = txtAmountAny2.Text * 0.026
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Rupees" Then
            INR = UAH * 2.2
            txtAmountAny1.Text = txtAmountAny2.Text * 2.2
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Euros" Then
            Euro = UAH * 0.024
            txtAmountAny1.Text = txtAmountAny2.Text * 0.024
        End If
    End Sub
End Class