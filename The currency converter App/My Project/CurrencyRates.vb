Imports System.IO
Public Class CurrencyRates
    Private Sub CurrencyRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using reader As New StreamReader("Z:\output.txt")

            txtUSD.Text = If(reader.ReadLine(), "")
            txtGBP.Text = If(reader.ReadLine(), "")
            txtYEN.Text = If(reader.ReadLine(), "")
            txtEUR.Text = If(reader.ReadLine(), "")

        End Using
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Using writer As New StreamWriter("Z:\output.txt")
            writer.WriteLine(txtUSD.Text)
            writer.WriteLine(txtGBP.Text)
            writer.WriteLine(txtYEN.Text)
            writer.WriteLine(txtEUR.Text)
        End Using
    End Sub

    Private Sub btnNEXT_Click(sender As Object, e As EventArgs) Handles btnNEXT.Click
        FrmThankyouPage.Show()
        Me.Hide()
    End Sub
End Class