<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmchkChoose2
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtAmountAny1 = New System.Windows.Forms.TextBox()
        Me.txtAmountAny2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblAny1 = New System.Windows.Forms.Label()
        Me.lblAny2 = New System.Windows.Forms.Label()
        Me.ComboBoxAny1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAny2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConvertAny2toAny1 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(989, 621)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(86, 44)
        Me.btnQuit.TabIndex = 14
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(989, 527)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(86, 40)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtAmountAny1
        '
        Me.txtAmountAny1.Location = New System.Drawing.Point(80, 182)
        Me.txtAmountAny1.Name = "txtAmountAny1"
        Me.txtAmountAny1.Size = New System.Drawing.Size(197, 23)
        Me.txtAmountAny1.TabIndex = 20
        '
        'txtAmountAny2
        '
        Me.txtAmountAny2.Location = New System.Drawing.Point(707, 182)
        Me.txtAmountAny2.Name = "txtAmountAny2"
        Me.txtAmountAny2.Size = New System.Drawing.Size(187, 23)
        Me.txtAmountAny2.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_currency_converter_App.My.Resources.Resources.reverse_arrows
        Me.PictureBox1.Location = New System.Drawing.Point(383, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFrom.Location = New System.Drawing.Point(77, 72)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(59, 25)
        Me.lblFrom.TabIndex = 23
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTo.Location = New System.Drawing.Point(697, 72)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(35, 25)
        Me.lblTo.TabIndex = 24
        Me.lblTo.Text = "To:"
        '
        'lblAny1
        '
        Me.lblAny1.AutoSize = True
        Me.lblAny1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAny1.Location = New System.Drawing.Point(77, 117)
        Me.lblAny1.Name = "lblAny1"
        Me.lblAny1.Size = New System.Drawing.Size(48, 25)
        Me.lblAny1.TabIndex = 25
        Me.lblAny1.Text = "Any:"
        '
        'lblAny2
        '
        Me.lblAny2.AutoSize = True
        Me.lblAny2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAny2.Location = New System.Drawing.Point(697, 125)
        Me.lblAny2.Name = "lblAny2"
        Me.lblAny2.Size = New System.Drawing.Size(48, 25)
        Me.lblAny2.TabIndex = 26
        Me.lblAny2.Text = "Any:"
        '
        'ComboBoxAny1
        '
        Me.ComboBoxAny1.FormattingEnabled = True
        Me.ComboBoxAny1.Items.AddRange(New Object() {"Choose Your Currency", "Won", "Yen", "Swiss Franc", "USD", "Euro", "Canadian Dollar", "GBP"})
        Me.ComboBoxAny1.Location = New System.Drawing.Point(80, 211)
        Me.ComboBoxAny1.Name = "ComboBoxAny1"
        Me.ComboBoxAny1.Size = New System.Drawing.Size(197, 23)
        Me.ComboBoxAny1.TabIndex = 27
        '
        'ComboBoxAny2
        '
        Me.ComboBoxAny2.FormattingEnabled = True
        Me.ComboBoxAny2.Items.AddRange(New Object() {"Choose Your Currency", "Australian Dollar", "Polish Zloty", "Pakistan Rupee", "Baht", "New Zealand Dollar", "Forint", "DKK ", "UAH", "GBP"})
        Me.ComboBoxAny2.Location = New System.Drawing.Point(707, 211)
        Me.ComboBoxAny2.Name = "ComboBoxAny2"
        Me.ComboBoxAny2.Size = New System.Drawing.Size(187, 23)
        Me.ComboBoxAny2.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(80, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 107)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Convert Any currency to Any currency"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnConvertAny2toAny1
        '
        Me.btnConvertAny2toAny1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConvertAny2toAny1.Location = New System.Drawing.Point(697, 269)
        Me.btnConvertAny2toAny1.Name = "btnConvertAny2toAny1"
        Me.btnConvertAny2toAny1.Size = New System.Drawing.Size(197, 98)
        Me.btnConvertAny2toAny1.TabIndex = 30
        Me.btnConvertAny2toAny1.Text = "Convert Any currency to Any Currency"
        Me.btnConvertAny2toAny1.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(383, 315)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(132, 57)
        Me.btnReset.TabIndex = 31
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(989, 573)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(86, 42)
        Me.btnBack.TabIndex = 32
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmchkChoose2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 677)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConvertAny2toAny1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxAny2)
        Me.Controls.Add(Me.ComboBoxAny1)
        Me.Controls.Add(Me.lblAny2)
        Me.Controls.Add(Me.lblAny1)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtAmountAny2)
        Me.Controls.Add(Me.txtAmountAny1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnQuit)
        Me.Name = "FrmchkChoose2"
        Me.Text = "frmchkChoose2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtAmountAny1 As TextBox
    Friend WithEvents txtAmountAny2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblAny1 As Label
    Friend WithEvents lblAny2 As Label
    Friend WithEvents ComboBoxAny1 As ComboBox
    Friend WithEvents ComboBoxAny2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnConvertAny2toAny1 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnBack As Button
End Class
