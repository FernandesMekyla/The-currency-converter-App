' This helps in giving the code a clear view of how you want the numbers to be entered and the output of the numbers.
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

    ' This Button Quit closes the full program.
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    ' This takes you to the ending page which displays Thank you message.
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        FrmThankyouPage.Show()
        Me.Hide()
    End Sub

    ' This button allows you to reset the text in Amount1 and Amount2
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        TextBoxAmountAny1.ResetText()
        TextBoxAmountAny2.ResetText()
    End Sub

    ' This Displays all the currency in the combobox for currencyAny1.
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

    'This Displays all the currency in the combobox for currencyAny2.
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

    ' This button takes you to FrmQuestion1.
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmQuestion1.Show()
        Me.Hide()
    End Sub

    'This is all of the code for AnyCurrency1 to AnyCurrency2, along with the exchange rate.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConvertAny1ToAny2.Click

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = KRW * 0.0011
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.0011
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = KRW * 0.003
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.003
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = KRW * 0.2
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.2
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Baht" Then
            THB = KRW * 0.027
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.027
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = KRW * 0.0012
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.0012
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "Forint" Then
            HUF = KRW * 0.26
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.26
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "DKK" Then
            DKK = KRW * 0.0051
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.0051
        End If

        If ComboBoxAny1.Text = "Won" And ComboBoxAny2.Text = "UAH" Then
            UAH = KRW * 0.028
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.028
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = JPY * 0.01
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.01
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = JPY * 0.027
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.027
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = JPY * 1.89
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 1.89
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Baht" Then
            THB = JPY * 0.24
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.24
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "Forint" Then
            HUF = JPY * 2.37
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 2.37
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "DKK" Then
            DKK = JPY * 0.046
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.046
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "UAH" Then
            UAH = JPY * 0.25
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.25
        End If

        If ComboBoxAny1.Text = "Yen" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = JPY * 0.0011
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.0011
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = CHF * 1.75
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 1.75
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = CHF * 4.61
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 4.61
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "Baht" Then
            THB = CHF * 40.85
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 40.85
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = CHF * 321.83
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 321.83
        End If

        If ComboBoxAny1.Text = "Swis Franc" And ComboBoxAny2.Text = "Forint" Then
            HUF = CHF * 403.76
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 403.76
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "DKK" Then
            DKK = CHF * 7.88
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 7.88
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "UAH" Then
            UAH = CHF * 43.13
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 43.14
        End If

        If ComboBoxAny1.Text = "Swiss Franc" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = CHF * 0.53
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.53
        End If
        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = INR * 0.018
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.018
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = INR * 0.048
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.048
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = INR * 3.36
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 3.36
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = INR * 0.02
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.02
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Baht" Then
            THB = INR * 0.43
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.43
        End If
        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "Forint" Then
            HUF = INR * 4.21
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 4.21
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "DKK" Then
            DKK = INR * 0.082
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.082
        End If

        If ComboBoxAny1.Text = "Rupees" And ComboBoxAny2.Text = "UAH" Then
            UAH = INR * 0.45
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 0.45
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = CAD * 1.13
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 1.13
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = CAD * 2.97
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 2.97
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = CAD * 208.12
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 208.12
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Baht" Then
            THB = CAD * 26.43
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 26.43
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = CAD * 1.22
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 1.22
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "Forint" Then
            HUF = CAD * 260.73
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 260.73
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "DKK" Then
            DKK = CAD * 5.09
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 5.09
        End If

        If ComboBoxAny1.Text = "Canadian Dollar" And ComboBoxAny2.Text = "UAH" Then
            UAH = CAD * 27.92
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 27.92
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = USD * 1.52
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 1.52
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = USD * 4.0
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 4.0
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = USD * 279.1
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 279.1
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Baht" Then
            THB = USD * 35.6
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 35.6
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = USD * 1.64
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 1.64
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "Forint" Then
            HUF = USD * 352.08
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 352.08
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "DKK" Then
            DKK = USD * 6.85
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 6.85
        End If

        If ComboBoxAny1.Text = "US Dollars" And ComboBoxAny2.Text = "UAH" Then
            UAH = USD * 37.42
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 37.42
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = GBP * 1.93
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 1.93
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = GBP * 5.09
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 5.09
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = GBP * 354.68
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 354.68
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Baht" Then
            THB = GBP * 45.23
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 45.23
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "New Zeland Dollar" Then
            NZD = GBP * 2.09
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 2.09
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "DKK" Then
            DKK = GBP * 8.71
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 8.71
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "UAH" Then
            UAH = GBP * 47.57
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 47.57
        End If

        If ComboBoxAny1.Text = "GBP" And ComboBoxAny2.Text = "Forint" Then
            HUF = GBP * 447.22
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 477.22
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Australian Dollar" Then
            AUD = Euro * 1.66
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 1.66
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Polish Zloty" Then
            PLN = Euro * 4.36
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 4.36
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Pakistan Rupee" Then
            PKR = Euro * 303.91
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 303.91
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Baht" Then
            THB = Euro * 38.76
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 38.76
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "New Zealand Dollar" Then
            NZD = Euro * 1.79
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 1.79
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "DKK" Then
            DKK = Euro * 7.46
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 7.46
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "UAH" Then
            UAH = Euro * 40.74
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 40.74
        End If

        If ComboBoxAny1.Text = "Euros" And ComboBoxAny2.Text = "Forint" Then
            HUF = Euro * 383.17
            TextBoxAmountAny2.Text = TextBoxAmountAny1.Text * 383.17
        End If
    End Sub

    ' This is the Currency exchange code for AnyCurrency2 to AnyCurrency1.
    Private Sub btnConvertAny2toAny1_Click(sender As Object, e As EventArgs) Handles btnConvertAny2toAny1.Click
        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Won" Then
            KRW = AUD * 878.55
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 878.55
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Yen" Then
            JPY = AUD * 97.36
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 97.36
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = AUD * 0.57
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.57
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "US Dollars" Then
            USD = AUD * 0.66
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.66
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = AUD * 0.89
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.89
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "GBP" Then
            GBP = AUD * 0.52
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.52
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Euros" Then
            Euro = AUD * 0.61
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.61
        End If

        If ComboBoxAny2.Text = "Australian Dollar" And ComboBoxAny1.Text = "Rupees" Then
            INR = AUD * 54.69
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 54.69
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Rupees" Then
            INR = PLN * 20.66
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 20.66
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Euros" Then
            Euro = PLN * 0.23
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.23
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "GBP" Then
            GBP = PLN * 0.2
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.2
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = PLN * 0.33
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.33
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "US Dollars" Then
            USD = PLN * 0.25
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.25
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = PLN * 0.21
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.21
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Yen" Then
            JPY = PLN * 36.8
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 36.8
        End If

        If ComboBoxAny2.Text = "Polish Zloty" And ComboBoxAny1.Text = "Won" Then
            KRW = PLN * 332.0
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 332.0
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Won" Then
            KRW = PKR * 4.76
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 4.76
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Yen" Then
            JPY = PKR * 0.53
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.53
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = PKR * 0.0031
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0031
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "US Dollars" Then
            USD = PKR * 0.0036
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0036
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = PKR * 0.0048
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0048
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "GBP" Then
            GBP = PKR * 0.0028
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0028
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Euros" Then
            Euro = PKR * 0.0033
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0033
        End If

        If ComboBoxAny2.Text = "Pakistan Rupee" And ComboBoxAny1.Text = "Rupees" Then
            INR = PKR * 0.3
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.3
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Rupees" Then
            INR = HUF * 0.23
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.23
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Euros" Then
            Euro = HUF * 0.0026
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0026
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = HUF * 0.0038
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0038
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "US Dollars" Then
            USD = HUF * 0.0028
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0028
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "GBP" Then
            GBP = HUF * 0.0022
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0022
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = HUF * 0.0024
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.0024
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Yen" Then
            JPY = HUF * 0.41
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.41
        End If

        If ComboBoxAny2.Text = "Forint" And ComboBoxAny1.Text = "Won" Then
            KRW = HUF * 3.74
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 3.74
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "US Dollars" Then
            USD = THB * 0.028
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.028
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Rupees" Then
            INR = THB * 2.33
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 2.33
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "GBP" Then
            GBP = THB * 0.022
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.022
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = THB * 0.038
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.038
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Euros" Then
            Euro = THB * 0.026
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.026
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = THB * 0.024
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.024
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Yen" Then
            JPY = THB * 4.16
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 4.16
        End If

        If ComboBoxAny2.Text = "Baht" And ComboBoxAny1.Text = "Won" Then
            KRW = THB * 37.48
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 37.48
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Yen" Then
            JPY = NZD * 90.28
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 90.28
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Won" Then
            KRW = NZD * 813.82
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 813.8
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = NZD * 0.53
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.53
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = NZD * 0.82
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.82
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "US Dollars" Then
            USD = NZD * 0.61
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.61
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "GBP" Then
            GBP = NZD * 0.48
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.48
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Rupees" Then
            INR = NZD * 50.65
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 50.65
        End If

        If ComboBoxAny2.Text = "New Zealand Dollar" And ComboBoxAny1.Text = "Euros" Then
            Euro = NZD * 0.56
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.56
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Won" Then
            KRW = DKK * 194.43
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 194.43
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Yen" Then
            JPY = DKK * 21.57
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 21.57
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = DKK * 0.13
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.13
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = DKK * 0.2
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.2
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "GBP" Then
            GBP = DKK * 0.11
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.11
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "US Dollars" Then
            USD = DKK * 0.15
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.15
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Rupees" Then
            INR = DKK * 12.11
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 12.11
        End If

        If ComboBoxAny2.Text = "DKK" And ComboBoxAny1.Text = "Euros" Then
            Euro = DKK * 0.13
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.13
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Won" Then
            KRW = UAH * 35.27
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 35.27
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Yen" Then
            JPY = UAH * 3.91
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 3.91
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Swiss Franc" Then
            CHF = UAH * 0.023
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.023
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Canadian Dollar" Then
            CAD = UAH * 0.036
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.036
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "GBP" Then
            GBP = UAH * 0.021
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.021
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "US Dollars " Then
            USD = UAH * 0.026
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.026
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Rupees" Then
            INR = UAH * 2.2
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 2.2
        End If

        If ComboBoxAny2.Text = "UAH" And ComboBoxAny1.Text = "Euros" Then
            Euro = UAH * 0.024
            TextBoxAmountAny1.Text = TextBoxAmountAny2.Text * 0.024
        End If
    End Sub

    'This helps you add you currency exchange as it displays the amount and once you reset the amount in
    'the textbox it saves your calculations in the listbox for Any1 to Any2.
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnAdd5.Click
        ListBox3.Items.Add(TextBoxAmountAny1.Text)
        ListBox3.Items.Add(TextBoxAmountAny2.Text)
    End Sub

    ' This clears the amounts in the listbox for Any1 To Any2.
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnClear6.Click
        ListBox3.Items.Clear()
    End Sub

    'This helps you add you currency exchange as it displays the amount and once you reset the amount in
    'the textbox it saves your calculations in the listbox for Any2 to Any1.
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnAdd7.Click
        ListBox4.Items.Add(TextBoxAmountAny2.Text)
        ListBox4.Items.Add(TextBoxAmountAny1.Text)
    End Sub

    ' This clears the amounts in the listbox for Any2 To Any1.
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnClear8.Click
        ListBox4.Items.Clear()
    End Sub
End Class