Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.

        Dim filePath As String = ""


        If File.Exists(filePath) Then

            Dim lines As String() = File.ReadAllLines(filePath)


            If lines.Length >= 3 Then

                TextBox1.Text = lines(0)
                TextBox2.Text = lines(1)
                TextBox3.Text = lines(2)


            Else
                MessageBox.Show("Not enough lines in the file to fill all text boxes.")
            End If
        Else
            MessageBox.Show("File does not exist.")
        End If
    End Sub
End Class