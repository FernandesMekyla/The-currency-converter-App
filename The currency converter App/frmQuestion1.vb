Public Class FrmQuestion1
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmQuestion2.Show()
        Me.Hide()
    End Sub

    Private Sub ChkChoose1_CheckedChanged(sender As Object, e As EventArgs) Handles chkChoose1.CheckedChanged
        FrmchkChoose1.Show()
        Me.Hide()
    End Sub

    Private Sub ChkChoose2_CheckedChanged(sender As Object, e As EventArgs) Handles chkChoose2.CheckedChanged
        frmchkChoose2.Show()
        Me.Hide()
    End Sub
End Class
