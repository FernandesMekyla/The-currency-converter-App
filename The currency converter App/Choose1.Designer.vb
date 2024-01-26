<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.txtGBP = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnConverttoAnyCurrency = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.txtAny = New System.Windows.Forms.TextBox()
        Me.btnConvertToGBPCurrency = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFrom.Location = New System.Drawing.Point(79, 129)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(59, 25)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTo.Location = New System.Drawing.Point(588, 129)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(35, 25)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "To:"
        '
        'txtGBP
        '
        Me.txtGBP.Location = New System.Drawing.Point(79, 176)
        Me.txtGBP.Name = "txtGBP"
        Me.txtGBP.Size = New System.Drawing.Size(211, 23)
        Me.txtGBP.TabIndex = 7
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(846, 435)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 38)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(846, 524)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(101, 39)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_currency_converter_App.My.Resources.Resources.reverse_arrows
        Me.PictureBox1.Location = New System.Drawing.Point(338, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"GBP"})
        Me.ComboBox1.Location = New System.Drawing.Point(79, 222)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 23)
        Me.ComboBox1.TabIndex = 15
        '
        'btnConverttoAnyCurrency
        '
        Me.btnConverttoAnyCurrency.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConverttoAnyCurrency.Location = New System.Drawing.Point(79, 265)
        Me.btnConverttoAnyCurrency.Name = "btnConverttoAnyCurrency"
        Me.btnConverttoAnyCurrency.Size = New System.Drawing.Size(211, 106)
        Me.btnConverttoAnyCurrency.TabIndex = 16
        Me.btnConverttoAnyCurrency.Text = "Convert To Any Currency"
        Me.btnConverttoAnyCurrency.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(378, 341)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(119, 51)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Choose Your Currency", "US Dollars", "Euros", "Canadian Dollar", "Rupees", "Swiss Franc", "Won", "Yen"})
        Me.ComboBox2.Location = New System.Drawing.Point(588, 222)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(212, 23)
        Me.ComboBox2.TabIndex = 19
        '
        'txtAny
        '
        Me.txtAny.Location = New System.Drawing.Point(588, 176)
        Me.txtAny.Name = "txtAny"
        Me.txtAny.Size = New System.Drawing.Size(212, 23)
        Me.txtAny.TabIndex = 20
        '
        'btnConvertToGBPCurrency
        '
        Me.btnConvertToGBPCurrency.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConvertToGBPCurrency.Location = New System.Drawing.Point(588, 265)
        Me.btnConvertToGBPCurrency.Name = "btnConvertToGBPCurrency"
        Me.btnConvertToGBPCurrency.Size = New System.Drawing.Size(212, 94)
        Me.btnConvertToGBPCurrency.TabIndex = 21
        Me.btnConvertToGBPCurrency.Text = "Convert To GBP Currency"
        Me.btnConvertToGBPCurrency.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(846, 479)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(101, 39)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(37, 409)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(279, 169)
        Me.ListBox1.TabIndex = 23
        '
        'FrmchkChoose1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 595)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConvertToGBPCurrency)
        Me.Controls.Add(Me.txtAny)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConverttoAnyCurrency)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtGBP)
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
    Friend WithEvents txtGBP As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnConverttoAnyCurrency As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents txtAny As TextBox
    Friend WithEvents btnConvertToGBPCurrency As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents ListBox1 As ListBox
End Class
