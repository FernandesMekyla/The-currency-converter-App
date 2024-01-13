<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose1
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
        lblFrom = New Label()
        lblTo = New Label()
        lblGBP = New Label()
        lblAny = New Label()
        GBPAmount = New TextBox()
        TextBox2 = New TextBox()
        btnNext = New Button()
        btnQuit = New Button()
        PictureBox1 = New PictureBox()
        ComboBox1 = New ComboBox()
        btnConverttoAnyCurrency = New Button()
        btnConvertToGBPCurrency = New Button()
        btnReset = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.Location = New Point(91, 87)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(38, 15)
        lblFrom.TabIndex = 2
        lblFrom.Text = "From:"
        ' 
        ' lblTo
        ' 
        lblTo.AutoSize = True
        lblTo.Location = New Point(579, 87)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(22, 15)
        lblTo.TabIndex = 3
        lblTo.Text = "To:"
        ' 
        ' lblGBP
        ' 
        lblGBP.AutoSize = True
        lblGBP.Location = New Point(91, 129)
        lblGBP.Name = "lblGBP"
        lblGBP.Size = New Size(32, 15)
        lblGBP.TabIndex = 4
        lblGBP.Text = "GBP:"
        ' 
        ' lblAny
        ' 
        lblAny.AutoSize = True
        lblAny.Location = New Point(579, 129)
        lblAny.Name = "lblAny"
        lblAny.Size = New Size(31, 15)
        lblAny.TabIndex = 5
        lblAny.Text = "Any:"
        ' 
        ' GBPAmount
        ' 
        GBPAmount.Location = New Point(91, 147)
        GBPAmount.Name = "GBPAmount"
        GBPAmount.Size = New Size(100, 23)
        GBPAmount.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(579, 147)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 8
        ' 
        ' btnNext
        ' 
        btnNext.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnNext.Location = New Point(713, 363)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(75, 30)
        btnNext.TabIndex = 12
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnQuit
        ' 
        btnQuit.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnQuit.Location = New Point(713, 399)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(75, 27)
        btnQuit.TabIndex = 13
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.reverse_arrows
        PictureBox1.Location = New Point(311, 87)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(109, 57)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(579, 176)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(149, 23)
        ComboBox1.TabIndex = 15
        ComboBox1.Text = "Choose your Currency"
        ' 
        ' btnConverttoAnyCurrency
        ' 
        btnConverttoAnyCurrency.Font = New Font("Bodoni MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnConverttoAnyCurrency.Location = New Point(79, 204)
        btnConverttoAnyCurrency.Name = "btnConverttoAnyCurrency"
        btnConverttoAnyCurrency.Size = New Size(140, 55)
        btnConverttoAnyCurrency.TabIndex = 16
        btnConverttoAnyCurrency.Text = "Convert To Any Currency"
        btnConverttoAnyCurrency.UseVisualStyleBackColor = True
        ' 
        ' btnConvertToGBPCurrency
        ' 
        btnConvertToGBPCurrency.Font = New Font("Bodoni MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnConvertToGBPCurrency.Location = New Point(585, 206)
        btnConvertToGBPCurrency.Name = "btnConvertToGBPCurrency"
        btnConvertToGBPCurrency.Size = New Size(143, 53)
        btnConvertToGBPCurrency.TabIndex = 17
        btnConvertToGBPCurrency.Text = "Convert to GBP Currency"
        btnConvertToGBPCurrency.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Georgia Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(311, 245)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(109, 42)
        btnReset.TabIndex = 18
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Choose1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnConvertToGBPCurrency)
        Controls.Add(btnConverttoAnyCurrency)
        Controls.Add(ComboBox1)
        Controls.Add(PictureBox1)
        Controls.Add(btnQuit)
        Controls.Add(btnNext)
        Controls.Add(TextBox2)
        Controls.Add(GBPAmount)
        Controls.Add(lblAny)
        Controls.Add(lblGBP)
        Controls.Add(lblTo)
        Controls.Add(lblFrom)
        Name = "Choose1"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

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
