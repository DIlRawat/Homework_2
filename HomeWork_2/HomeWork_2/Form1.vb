'Author: Dil
'Date: 03/30/2020
'Course: CSIS 3726
'Homework 2

'a project to calculate the amount of a book sale order based
'On quantity and price of a given book.
'Sales tax And shipping charges will apply.

Public Class Form1
    'sales tax constant 
    Const SALES_TAX_DECIMAL As Decimal = 0.0725
    'Dim SalesTaxDecimal As Decimal
    Dim TotalsDecimal As Decimal
    Private Sub CalculateSaleButton_Click(sender As Object, e As EventArgs) Handles CalculateSaleButton.Click
        'creating variables
        'Dim TitleString As String
        Dim QuantityInteger As Integer
        Dim PriceDecimal As Decimal

        Dim ExtendedPriceDecimal As Decimal
        Dim ShippingAmountDecimal As Decimal
        Dim SalesTax As Decimal


        'if title has been entered
        If TitleTextBox.Text IsNot "" Then
            Try
                'convert quantity if valid entry is made
                QuantityInteger = Integer.Parse(QuantityTextBox.Text)

                Try
                    'convert price if valid entry is made
                    PriceDecimal = Decimal.Parse(PriceTextBox.Text)

                    'calling function to calculate extended price
                    ExtendedPriceDecimal = CalcualteExtendedPrice(QuantityInteger, PriceDecimal)
                    ExtendedTextBox.Text = ExtendedPriceDecimal.ToString("C")

                    'calling function to calculate shipping amount 
                    ShippingAmountDecimal = CalculateShippingDecimal(ExtendedPriceDecimal)
                    ShippingAmountTextBox.Text = ShippingAmountDecimal.ToString("C")

                    'calling subroutine to calculate sales tax
                    If NoRadioButton.Checked Then
                        SalesTaxTextBox.Text = SalesTax.ToString("C")
                    Else
                        CalculateSalesTaxDecimal(ExtendedPriceDecimal, SalesTax)
                        SalesTaxTextBox.Text = SalesTax.ToString("C")
                    End If

                    'calling subroutine to display the total price
                    If NoRadioButton.Checked Then
                        SalesTax = 0
                        DisplayTotals(ExtendedPriceDecimal, ShippingAmountDecimal, SalesTax)
                        TotalTextBox.Text = TotalsDecimal.ToString("C")
                    Else
                        DisplayTotals(ExtendedPriceDecimal, ShippingAmountDecimal, SalesTax)
                        TotalTextBox.Text = TotalsDecimal.ToString("C")
                    End If



                Catch PriceException As FormatException
                    MessageBox.Show("Price should be number", "Price entry error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    PriceTextBox.Focus()
                    PriceTextBox.SelectAll()
                End Try


            Catch QuantityException As FormatException
                MessageBox.Show("Qunatity should be number", "Quantity entry error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                QuantityTextBox.Focus()
                QuantityTextBox.SelectAll()
            End Try
        Else
            MessageBox.Show("Please enter title", "Title entry error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TitleTextBox.Focus()
        End If



    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TitleTextBox.Clear()
        QuantityTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedTextBox.Clear()
        ShippingAmountTextBox.Clear()
        SalesTaxTextBox.Clear()
        TotalTextBox.Clear()
        TitleTextBox.Focus()
    End Sub

    'function to calculate extended price decimal
    Function CalcualteExtendedPrice(QuantityInteger As Integer, PriceDecimal As Decimal) As Decimal

        Dim ExtendedPriceDecimal As Decimal
        ExtendedPriceDecimal = QuantityInteger * PriceDecimal
        Return ExtendedPriceDecimal
    End Function

    'function to calcuate the shipping amount based on extended price
    Function CalculateShippingDecimal(ExtendedPriceDecimal As Decimal) As Decimal
        Dim ShippingAmount As Decimal
        Select Case ExtendedPriceDecimal
            Case 0 To 100
                ShippingAmount = 15
            Case 101 To 250
                ShippingAmount = 25
            Case 251 To 500
                ShippingAmount = 40
            Case Else
                ShippingAmount = 0

        End Select
        Return ShippingAmount
    End Function

    'subroutine to calculate sales tax
    Sub CalculateSalesTaxDecimal(ExtendedPriceDecimal As Decimal, ByRef SalesTax As Decimal)

        SalesTax = ExtendedPriceDecimal * SALES_TAX_DECIMAL

    End Sub
    'subroutine to display totals
    Sub DisplayTotals(ExtendedPriceDecimal As Decimal, ShippingDecimal As Decimal, SalesTaxDecimal As Decimal)

        TotalsDecimal = ExtendedPriceDecimal + ShippingDecimal + SalesTaxDecimal

    End Sub

    Private Sub TitleTextBox_TextChanged(sender As Object, e As EventArgs) Handles TitleTextBox.TextChanged

    End Sub
End Class
