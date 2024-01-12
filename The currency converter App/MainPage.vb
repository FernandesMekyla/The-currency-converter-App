Public Class frmMain
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        Username = txtUsername.Text
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub
End Class