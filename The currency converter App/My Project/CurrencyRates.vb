Imports System.IO
'takes code from the provided output file to take the exchange rates and save the exchange rates.
Public Class CurrencyRates
    Private Sub CurrencyRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using reader As New StreamReader("D:\output.txt")

            txtUSD.Text = If(reader.ReadLine(), "")
            txtGBP.Text = If(reader.ReadLine(), "")
            txtYEN.Text = If(reader.ReadLine(), "")
            txtEUR.Text = If(reader.ReadLine(), "")

        End Using
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Using writer As New StreamWriter("D:\output.txt")
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