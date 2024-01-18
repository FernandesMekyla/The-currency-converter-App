Public Class FrmchkChoose2
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmThankyouPage.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        txtAmountAny1.ResetText()
        txtAmountAny2.ResetText()
    End Sub

    Private Sub ComboBoxAny1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAny1.SelectedIndexChanged
        ComboBoxAny1.Text = "Choose your Currency"
        ComboBoxAny1.Items.Add("Won")
        ComboBoxAny1.Items.Add("Yen")
        ComboBoxAny1.Items.Add("Swiss Franc")
        ComboBoxAny1.Items.Add("USD")
        ComboBoxAny1.Items.Add("Euro")
        ComboBoxAny1.Items.Add("Canadian Dollar")
        ComboBoxAny1.Items.Add("GBP")
    End Sub

    Private Sub ComboBoxAny2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAny2.SelectedIndexChanged
        ComboBoxAny2.Text = "Choose your Currency"
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
End Class