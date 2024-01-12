Public Class Mainpage
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        Username = txtUsername.Text
        Choose1.Show()
        Me.Hide()
    End Sub
End Class