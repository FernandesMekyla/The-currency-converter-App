Public Class FrmQuestion2
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Name = txtName.Text
        Me.Hide()

        If FrmQuestion1.chkChoose1.Checked Then
            FrmchkChoose1.Show()
            Me.Hide()
        End If

        If FrmQuestion1.chkChoose2.Checked Then
            FrmchkChoose2.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmQuestion1.Show()
        Me.Hide()
    End Sub
End Class