' This helps in giving the code a clear view of how you want the numbers to be entered and the output of the numbers.
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

    ' This button Quit closes the full program.
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
    Public Function FormisOK()

        Dim userInput As String = TextBoxGBP.Text.Trim()

        ' Check if the text box is empty
        If String.IsNullOrEmpty(userInput) Then
            MessageBox.Show("Please enter a value. The field cannot be blank.")
            TextBoxGBP.Focus() ' Set focus back to the TextBox for user correction
            Return False
        End If

        ' Check if the input is numerical
        Dim isNumeric As Boolean = True
        For Each c As Char In userInput
            If Not Char.IsDigit(c) Then
                isNumeric = False
                Exit For
            End If
        Next

        If Not isNumeric Then
            MessageBox.Show("Please enter a valid numerical value.")
            TextBoxGBP.Focus()
            Return False
        End If

        ' If all checks are passed, proceed with further processing
        Return True

    End Function
    ' This helps you to select from the combobox which currency you want to convert your GBP money to.
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.Items.Add("US Dollars")
        ComboBox2.Items.Add("Euros")
        ComboBox2.Items.Add("CAD")
        ComboBox2.Items.Add("Rupees")
        ComboBox2.Items.Add("CHF")
        ComboBox2.Items.Add("Won")
        ComboBox2.Items.Add("Yen")
    End Sub

    ' This code below is for the button to convert GBP currency to any other currency along with the currency rate.
    Private Sub BtnConverttoAnyCurrency_Click(sender As Object, e As EventArgs) Handles btnConverttoAnyCurrency.Click
        If FormisOK() Then
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
        End If
    End Sub

    ' This button reset your amount on both the sides of the converter 
    ' from GBP to Any and Any to GBP
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        TextBoxGBP.ResetText()
        TextBoxAny.ResetText()
    End Sub

    ' This Converts Any to GBP currency 
    Private Sub btnConvertToGBPCurrency_Click(sender As Object, e As EventArgs) Handles btnConvertToGBPCurrency.Click
        If FormisOK() Then
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
        End If
    End Sub

    ' This takes you to the ending page which displays Thank you message.
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        FrmThankyouPage.Show()
        Me.Hide()
    End Sub

    'This button takes you to FrmQuestion1
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        FrmQuestion1.Show()
        Me.Hide()
    End Sub

    'This helps you add you currency exchange as it displays the amount and once you reset the amount in
    'the textbox it saves your calculations in the listbox for GBP to Any.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Listbox1.Items.Add(TextBoxGBP.Text)
        Listbox1.Items.Add(TextBoxAny.Text)
    End Sub

    ' This clears the amounts in the listbox for GBP To Any. 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        Listbox1.Items.Clear()
    End Sub

    ' This helps you add currency for Any to GBP and it saves it in the listbox even if you reset the amounts in the textbox where the amount is displayed.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        ListBox2.Items.Add(TextBoxAny.Text)
        ListBox2.Items.Add(TextBoxGBP.Text)
    End Sub

    ' This Clear the amounts in the listbox for Any to GBP.
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnClear4.Click
        ListBox2.Items.Clear()
    End Sub
End Class