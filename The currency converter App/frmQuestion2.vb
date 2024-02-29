Public Class FrmQuestion2

    ' The Button next allows you to go to the next form according to which option you have chosen from Option 1 or Option 2.

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Name = txtName.Text
        Me.Hide()
        ' As you can see down below it shows us how the code it inputted; if you press on ChkChoose1 and then after you go to FrmQuestion2 it will autoamtically
        ' take you to FrmChkChoose1 form. 
        If FrmQuestion1.chkChoose1.Checked Then
            FrmchkChoose1.Show()
            Me.Hide()
        End If
        ' And if you press on ChkChoose2, it will take you to FrmChkChoose2 form.
        If FrmQuestion1.chkChoose2.Checked Then
            FrmchkChoose2.Show()
            Me.Hide()
        End If
    End Sub

    'Again this Button quit closes the program.
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
    'This button allows you to go back to the previous form in case you have chosen the wrong option.
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmQuestion1.Show()
        Me.Hide()
    End Sub
End Class