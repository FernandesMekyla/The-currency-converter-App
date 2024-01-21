Public Class FrmThankyouPage
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmQuestion1.Show()
        Me.Hide()
    End Sub
End Class