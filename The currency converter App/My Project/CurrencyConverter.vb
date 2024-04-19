Public Class CurrencyConverter
    'Dictionary to hold the Currency Conversion Rates
    Private ConversionRates As Dictionary(Of String, Double)

    Public Sub New()
        ' Initialize the dictionary with conversion rates
        ConversionRates = New Dictionary(Of String, Double) From {
            {"Won-Australian Dollar", 0.0011},
            {"Won-Polish Zloty", 0.00029},
            {"Won-Pakistan Rupee", 0.2},
            {"Won-Baht", 0.027},
            {"Won-NZD", 0.0012},
            {"Yen-Australian Dollar", 0.01},
            {"Yen-Polish Zloty", 0.027},
            {"US Dollars-Australian Dollar", 1.52},
            {"Euros-Forint", 383.17}
            }
    End Sub

    Public Function ConvertCurrency(fromCurrency As String, toCurrency As String, amount As Double) As Double
        Dim key As String = fromCurrency + "-" + toCurrency
        If ConversionRates.ContainsKey(key) Then
            Return amount * ConversionRates(key)
        Else
            Throw New Exception("Conversion rate not found.")
        End If
    End Function

End Class
