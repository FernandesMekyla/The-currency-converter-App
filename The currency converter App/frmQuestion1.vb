Public Class FrmQuestion1
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub ChkChoose1_CheckedChanged(sender As Object, e As EventArgs) Handles chkChoose1.CheckedChanged
        If chkChoose1.Checked Then
            FrmQuestion2.Show()
            Me.Hide()
        End If

        If chkChoose2.Checked Then
            FrmQuestion2.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub ChkChoose2_CheckedChanged(sender As Object, e As EventArgs) Handles chkChoose2.CheckedChanged
        FrmQuestion2.Show()
        Me.Hide()
    End Sub
End Class
