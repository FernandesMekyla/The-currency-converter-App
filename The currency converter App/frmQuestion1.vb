Public Class FrmQuestion1
    Private Sub TxtChoose1_TextChanged(sender As Object, e As EventArgs) Handles txtChoose1.TextChanged
        chkChoose1.Show()
        Me.Hide()
    End Sub
    Private Sub TxtChoose2_TextChanged(sender As Object, e As EventArgs) Handles txtChoose2.TextChanged
        chkChoose2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
    End Sub
End Class
