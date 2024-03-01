' This is the last form which displays a Thankyou message.
Public Class FrmThankyouPage

    ' This button Quit Closes the full program.
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    ' This Button takes you back to the starting page which is FrmQuestion1.
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        FrmQuestion1.Show()
        Me.Hide()
    End Sub
End Class