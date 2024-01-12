Public Class Selection
    Private Sub txtChoose1_TextChanged(sender As Object, e As EventArgs) Handles txtChoose1.TextChanged
        chkChoose1.Show()
        Me.Hide()
    End Sub
    Private Sub txtChoose2_TextChanged(sender As Object, e As EventArgs) Handles txtChoose2.TextChanged
        chkChoose2.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub
End Class
