Public Class FrmThankyouPage
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        FrmQuestion1.Show()
        Me.Hide()
    End Sub
End Class