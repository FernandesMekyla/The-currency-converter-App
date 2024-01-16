<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchkChoose1
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
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblGBP = New System.Windows.Forms.Label()
        Me.lblAny = New System.Windows.Forms.Label()
        Me.GBPAmount = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnConverttoAnyCurrency = New System.Windows.Forms.Button()
        Me.btnConvertToGBPCurrency = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(91, 87)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(38, 15)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(579, 87)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(22, 15)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "To:"
        '
        'lblGBP
        '
        Me.lblGBP.AutoSize = True
        Me.lblGBP.Location = New System.Drawing.Point(91, 129)
        Me.lblGBP.Name = "lblGBP"
        Me.lblGBP.Size = New System.Drawing.Size(32, 15)
        Me.lblGBP.TabIndex = 4
        Me.lblGBP.Text = "GBP:"
        '
        'lblAny
        '
        Me.lblAny.AutoSize = True
        Me.lblAny.Location = New System.Drawing.Point(579, 129)
        Me.lblAny.Name = "lblAny"
        Me.lblAny.Size = New System.Drawing.Size(31, 15)
        Me.lblAny.TabIndex = 5
        Me.lblAny.Text = "Any:"
        '
        'GBPAmount
        '
        Me.GBPAmount.Location = New System.Drawing.Point(91, 147)
        Me.GBPAmount.Name = "GBPAmount"
        Me.GBPAmount.Size = New System.Drawing.Size(100, 23)
        Me.GBPAmount.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(579, 147)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 8
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(713, 363)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 30)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(713, 399)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 27)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_currency_converter_App.My.Resources.Resources.reverse_arrows
        Me.PictureBox1.Location = New System.Drawing.Point(311, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(91, 176)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 23)
        Me.ComboBox1.TabIndex = 15
        '
        'btnConverttoAnyCurrency
        '
        Me.btnConverttoAnyCurrency.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConverttoAnyCurrency.Location = New System.Drawing.Point(79, 204)
        Me.btnConverttoAnyCurrency.Name = "btnConverttoAnyCurrency"
        Me.btnConverttoAnyCurrency.Size = New System.Drawing.Size(140, 55)
        Me.btnConverttoAnyCurrency.TabIndex = 16
        Me.btnConverttoAnyCurrency.Text = "Convert To Any Currency"
        Me.btnConverttoAnyCurrency.UseVisualStyleBackColor = True
        '
        'btnConvertToGBPCurrency
        '
        Me.btnConvertToGBPCurrency.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConvertToGBPCurrency.Location = New System.Drawing.Point(585, 206)
        Me.btnConvertToGBPCurrency.Name = "btnConvertToGBPCurrency"
        Me.btnConvertToGBPCurrency.Size = New System.Drawing.Size(143, 53)
        Me.btnConvertToGBPCurrency.TabIndex = 17
        Me.btnConvertToGBPCurrency.Text = "Convert to GBP Currency"
        Me.btnConvertToGBPCurrency.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Georgia Pro Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(311, 245)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 42)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmchkChoose1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConvertToGBPCurrency)
        Me.Controls.Add(Me.btnConverttoAnyCurrency)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GBPAmount)
        Me.Controls.Add(Me.lblAny)
        Me.Controls.Add(Me.lblGBP)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Name = "frmchkChoose1"
        Me.Text = "frmchkChoose1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblGBP As Label
    Friend WithEvents lblAny As Label
    Friend WithEvents GBPAmount As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnConverttoAnyCurrency As Button
    Friend WithEvents btnConvertToGBPCurrency As Button
    Friend WithEvents btnReset As Button
End Class
