<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ExtendedTextBox = New System.Windows.Forms.TextBox()
        Me.ShippingAmountTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTaxTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateSaleButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.YesRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IsTaxableLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.SalesTaxLabel = New System.Windows.Forms.Label()
        Me.ShippingAmountLabel = New System.Windows.Forms.Label()
        Me.ExtendedPriceLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(10, 71)
        Me.TitleTextBox.Multiline = True
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(223, 40)
        Me.TitleTextBox.TabIndex = 0
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(10, 147)
        Me.QuantityTextBox.Multiline = True
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(227, 40)
        Me.QuantityTextBox.TabIndex = 1
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(10, 233)
        Me.PriceTextBox.Multiline = True
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(233, 40)
        Me.PriceTextBox.TabIndex = 2
        '
        'ExtendedTextBox
        '
        Me.ExtendedTextBox.Enabled = False
        Me.ExtendedTextBox.Location = New System.Drawing.Point(26, 60)
        Me.ExtendedTextBox.Multiline = True
        Me.ExtendedTextBox.Name = "ExtendedTextBox"
        Me.ExtendedTextBox.Size = New System.Drawing.Size(180, 40)
        Me.ExtendedTextBox.TabIndex = 3
        '
        'ShippingAmountTextBox
        '
        Me.ShippingAmountTextBox.Enabled = False
        Me.ShippingAmountTextBox.Location = New System.Drawing.Point(26, 145)
        Me.ShippingAmountTextBox.Multiline = True
        Me.ShippingAmountTextBox.Name = "ShippingAmountTextBox"
        Me.ShippingAmountTextBox.Size = New System.Drawing.Size(180, 40)
        Me.ShippingAmountTextBox.TabIndex = 4
        '
        'SalesTaxTextBox
        '
        Me.SalesTaxTextBox.Enabled = False
        Me.SalesTaxTextBox.Location = New System.Drawing.Point(22, 236)
        Me.SalesTaxTextBox.Multiline = True
        Me.SalesTaxTextBox.Name = "SalesTaxTextBox"
        Me.SalesTaxTextBox.Size = New System.Drawing.Size(184, 40)
        Me.SalesTaxTextBox.TabIndex = 5
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Location = New System.Drawing.Point(22, 383)
        Me.TotalTextBox.Multiline = True
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(184, 40)
        Me.TotalTextBox.TabIndex = 6
        '
        'CalculateSaleButton
        '
        Me.CalculateSaleButton.Location = New System.Drawing.Point(6, 380)
        Me.CalculateSaleButton.Name = "CalculateSaleButton"
        Me.CalculateSaleButton.Size = New System.Drawing.Size(233, 55)
        Me.CalculateSaleButton.TabIndex = 7
        Me.CalculateSaleButton.Text = "Calculate Sale"
        Me.CalculateSaleButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(6, 459)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(233, 45)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'YesRadioButton
        '
        Me.YesRadioButton.AutoSize = True
        Me.YesRadioButton.Location = New System.Drawing.Point(6, 338)
        Me.YesRadioButton.Name = "YesRadioButton"
        Me.YesRadioButton.Size = New System.Drawing.Size(62, 24)
        Me.YesRadioButton.TabIndex = 9
        Me.YesRadioButton.Text = "Yes"
        Me.YesRadioButton.UseVisualStyleBackColor = True
        '
        'NoRadioButton
        '
        Me.NoRadioButton.AutoSize = True
        Me.NoRadioButton.Checked = True
        Me.NoRadioButton.Location = New System.Drawing.Point(118, 338)
        Me.NoRadioButton.Name = "NoRadioButton"
        Me.NoRadioButton.Size = New System.Drawing.Size(54, 24)
        Me.NoRadioButton.TabIndex = 10
        Me.NoRadioButton.TabStop = True
        Me.NoRadioButton.Text = "No"
        Me.NoRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IsTaxableLabel)
        Me.GroupBox1.Controls.Add(Me.PriceLabel)
        Me.GroupBox1.Controls.Add(Me.QuantityLabel)
        Me.GroupBox1.Controls.Add(Me.TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.NoRadioButton)
        Me.GroupBox1.Controls.Add(Me.CalculateSaleButton)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.YesRadioButton)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 519)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Information"
        '
        'IsTaxableLabel
        '
        Me.IsTaxableLabel.Location = New System.Drawing.Point(6, 290)
        Me.IsTaxableLabel.Name = "IsTaxableLabel"
        Me.IsTaxableLabel.Size = New System.Drawing.Size(125, 34)
        Me.IsTaxableLabel.TabIndex = 14
        Me.IsTaxableLabel.Text = "Is Taxable ?"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(6, 210)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(48, 20)
        Me.PriceLabel.TabIndex = 13
        Me.PriceLabel.Text = "Price:"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(6, 124)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(72, 20)
        Me.QuantityLabel.TabIndex = 12
        Me.QuantityLabel.Text = "Quantity:"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(6, 38)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(38, 20)
        Me.TitleLabel.TabIndex = 11
        Me.TitleLabel.Text = "Title"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ExitButton)
        Me.GroupBox2.Controls.Add(Me.TotalLabel)
        Me.GroupBox2.Controls.Add(Me.SalesTaxLabel)
        Me.GroupBox2.Controls.Add(Me.ShippingAmountLabel)
        Me.GroupBox2.Controls.Add(Me.ExtendedPriceLabel)
        Me.GroupBox2.Controls.Add(Me.ExtendedTextBox)
        Me.GroupBox2.Controls.Add(Me.ShippingAmountTextBox)
        Me.GroupBox2.Controls.Add(Me.TotalTextBox)
        Me.GroupBox2.Controls.Add(Me.SalesTaxTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(313, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 508)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sale Totals"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(26, 448)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(135, 44)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(18, 345)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(44, 20)
        Me.TotalLabel.TabIndex = 10
        Me.TotalLabel.Text = "Total"
        '
        'SalesTaxLabel
        '
        Me.SalesTaxLabel.AutoSize = True
        Me.SalesTaxLabel.Location = New System.Drawing.Point(22, 199)
        Me.SalesTaxLabel.Name = "SalesTaxLabel"
        Me.SalesTaxLabel.Size = New System.Drawing.Size(78, 20)
        Me.SalesTaxLabel.TabIndex = 9
        Me.SalesTaxLabel.Text = "Sales Tax"
        '
        'ShippingAmountLabel
        '
        Me.ShippingAmountLabel.AutoSize = True
        Me.ShippingAmountLabel.Location = New System.Drawing.Point(22, 113)
        Me.ShippingAmountLabel.Name = "ShippingAmountLabel"
        Me.ShippingAmountLabel.Size = New System.Drawing.Size(135, 20)
        Me.ShippingAmountLabel.TabIndex = 8
        Me.ShippingAmountLabel.Text = "Shipping Amount:"
        '
        'ExtendedPriceLabel
        '
        Me.ExtendedPriceLabel.AutoSize = True
        Me.ExtendedPriceLabel.Location = New System.Drawing.Point(22, 29)
        Me.ExtendedPriceLabel.Name = "ExtendedPriceLabel"
        Me.ExtendedPriceLabel.Size = New System.Drawing.Size(116, 20)
        Me.ExtendedPriceLabel.TabIndex = 7
        Me.ExtendedPriceLabel.Text = "Extended Price"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 543)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Book Sale"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents ExtendedTextBox As TextBox
    Friend WithEvents ShippingAmountTextBox As TextBox
    Friend WithEvents SalesTaxTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents CalculateSaleButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents YesRadioButton As RadioButton
    Friend WithEvents NoRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IsTaxableLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TotalLabel As Label
    Friend WithEvents SalesTaxLabel As Label
    Friend WithEvents ShippingAmountLabel As Label
    Friend WithEvents ExtendedPriceLabel As Label
    Friend WithEvents ExitButton As Button
End Class
