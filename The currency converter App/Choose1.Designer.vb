﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmchkChoose1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.TextBoxGBP = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnConverttoAnyCurrency = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBoxAny = New System.Windows.Forms.TextBox()
        Me.btnConvertToGBPCurrency = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Listbox1 = New System.Windows.Forms.ListBox()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btnClear4 = New System.Windows.Forms.Button()
        Me.btnAdd3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFrom.Location = New System.Drawing.Point(79, 50)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(59, 25)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTo.Location = New System.Drawing.Point(964, 50)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(35, 25)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "To:"
        '
        'TextBoxGBP
        '
        Me.TextBoxGBP.Location = New System.Drawing.Point(79, 78)
        Me.TextBoxGBP.Name = "TextBoxGBP"
        Me.TextBoxGBP.Size = New System.Drawing.Size(211, 23)
        Me.TextBoxGBP.TabIndex = 7
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(1177, 479)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(73, 30)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(1177, 549)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(73, 28)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_currency_converter_App.My.Resources.Resources.reverse_arrows
        Me.PictureBox1.Location = New System.Drawing.Point(539, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"GBP"})
        Me.ComboBox1.Location = New System.Drawing.Point(79, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 23)
        Me.ComboBox1.TabIndex = 15
        '
        'btnConverttoAnyCurrency
        '
        Me.btnConverttoAnyCurrency.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConverttoAnyCurrency.Location = New System.Drawing.Point(79, 134)
        Me.btnConverttoAnyCurrency.Name = "btnConverttoAnyCurrency"
        Me.btnConverttoAnyCurrency.Size = New System.Drawing.Size(197, 40)
        Me.btnConverttoAnyCurrency.TabIndex = 16
        Me.btnConverttoAnyCurrency.Text = "Convert To Any Currency"
        Me.btnConverttoAnyCurrency.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(541, 141)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(104, 33)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Choose Your Currency", "US Dollars", "Euros", "Canadian Dollar", "Rupees", "Swiss Franc", "Won", "Yen"})
        Me.ComboBox2.Location = New System.Drawing.Point(964, 107)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(212, 23)
        Me.ComboBox2.TabIndex = 19
        '
        'TextBoxAny
        '
        Me.TextBoxAny.Location = New System.Drawing.Point(964, 78)
        Me.TextBoxAny.Name = "TextBoxAny"
        Me.TextBoxAny.Size = New System.Drawing.Size(212, 23)
        Me.TextBoxAny.TabIndex = 20
        '
        'btnConvertToGBPCurrency
        '
        Me.btnConvertToGBPCurrency.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConvertToGBPCurrency.Location = New System.Drawing.Point(964, 134)
        Me.btnConvertToGBPCurrency.Name = "btnConvertToGBPCurrency"
        Me.btnConvertToGBPCurrency.Size = New System.Drawing.Size(212, 40)
        Me.btnConvertToGBPCurrency.TabIndex = 21
        Me.btnConvertToGBPCurrency.Text = "Convert To GBP Currency"
        Me.btnConvertToGBPCurrency.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(1177, 515)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(73, 28)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Listbox1
        '
        Me.Listbox1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Listbox1.FormattingEnabled = True
        Me.Listbox1.ItemHeight = 21
        Me.Listbox1.Location = New System.Drawing.Point(12, 213)
        Me.Listbox1.Name = "Listbox1"
        Me.Listbox1.Size = New System.Drawing.Size(264, 298)
        Me.Listbox1.TabIndex = 23
        '
        'btnAdd1
        '
        Me.btnAdd1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd1.Location = New System.Drawing.Point(282, 213)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(64, 33)
        Me.btnAdd1.TabIndex = 24
        Me.btnAdd1.Text = "Add"
        Me.btnAdd1.UseVisualStyleBackColor = True
        '
        'btnClear2
        '
        Me.btnClear2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear2.Location = New System.Drawing.Point(282, 252)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(64, 36)
        Me.btnClear2.TabIndex = 25
        Me.btnClear2.Text = "Clear"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 21
        Me.ListBox2.Location = New System.Drawing.Point(805, 192)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(261, 319)
        Me.ListBox2.TabIndex = 26
        '
        'btnClear4
        '
        Me.btnClear4.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear4.Location = New System.Drawing.Point(1072, 231)
        Me.btnClear4.Name = "btnClear4"
        Me.btnClear4.Size = New System.Drawing.Size(66, 36)
        Me.btnClear4.TabIndex = 28
        Me.btnClear4.Text = "Clear"
        Me.btnClear4.UseVisualStyleBackColor = True
        '
        'btnAdd3
        '
        Me.btnAdd3.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd3.Location = New System.Drawing.Point(1072, 192)
        Me.btnAdd3.Name = "btnAdd3"
        Me.btnAdd3.Size = New System.Drawing.Size(66, 33)
        Me.btnAdd3.TabIndex = 29
        Me.btnAdd3.Text = "Add"
        Me.btnAdd3.UseVisualStyleBackColor = True
        '
        'FrmchkChoose1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 589)
        Me.Controls.Add(Me.btnAdd3)
        Me.Controls.Add(Me.btnClear4)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.btnClear2)
        Me.Controls.Add(Me.btnAdd1)
        Me.Controls.Add(Me.Listbox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConvertToGBPCurrency)
        Me.Controls.Add(Me.TextBoxAny)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConverttoAnyCurrency)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.TextBoxGBP)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Name = "FrmchkChoose1"
        Me.Text = "frmchkChoose1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents TextBoxGBP As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnConverttoAnyCurrency As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBoxAny As TextBox
    Friend WithEvents btnConvertToGBPCurrency As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Listbox1 As ListBox
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents btnClear2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents btnClear4 As Button
    Friend WithEvents btnAdd3 As Button
End Class
