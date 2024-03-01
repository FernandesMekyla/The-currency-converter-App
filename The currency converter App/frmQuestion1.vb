Public Class FrmQuestion1
    ' This following command closes the whole program when pressed.
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    ' This function below allows you to choose either one of the options. 
    ' As you can down below in the code if you press ChkChoose1 it will take you the FrmQuestion2 which will ask you to enter your name.
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

    ' As you can see in the code below that if you press ChkChoose2 it will automatically take you to FrmQuestion2 to enter your name.
    Private Sub ChkChoose2_CheckedChanged(sender As Object, e As EventArgs) Handles chkChoose2.CheckedChanged
        Hide()
        FrmQuestion2.Show()
        Me.Hide()
    End Sub
End Class
