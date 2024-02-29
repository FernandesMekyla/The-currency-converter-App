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
        Me.TextBoxAmountAny1 = New System.Windows.Forms.TextBox()
        Me.TextBoxAmountAny2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblAny1 = New System.Windows.Forms.Label()
        Me.lblAny2 = New System.Windows.Forms.Label()
        Me.ComboBoxAny1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAny2 = New System.Windows.Forms.ComboBox()
        Me.BtnConvertAny1ToAny2 = New System.Windows.Forms.Button()
        Me.btnConvertAny2toAny1 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.btnAdd5 = New System.Windows.Forms.Button()
        Me.btnClear6 = New System.Windows.Forms.Button()
        Me.btnAdd7 = New System.Windows.Forms.Button()
        Me.btnClear8 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(1149, 521)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(86, 35)
        Me.btnQuit.TabIndex = 14
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(1149, 444)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(86, 30)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'TextBoxAmountAny1
        '
        Me.TextBoxAmountAny1.Location = New System.Drawing.Point(88, 110)
        Me.TextBoxAmountAny1.Name = "TextBoxAmountAny1"
        Me.TextBoxAmountAny1.Size = New System.Drawing.Size(222, 23)
        Me.TextBoxAmountAny1.TabIndex = 20
        '
        'TextBoxAmountAny2
        '
        Me.TextBoxAmountAny2.Location = New System.Drawing.Point(840, 101)
        Me.TextBoxAmountAny2.Name = "TextBoxAmountAny2"
        Me.TextBoxAmountAny2.Size = New System.Drawing.Size(219, 23)
        Me.TextBoxAmountAny2.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_currency_converter_App.My.Resources.Resources.reverse_arrows
        Me.PictureBox1.Location = New System.Drawing.Point(530, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFrom.Location = New System.Drawing.Point(88, 48)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(59, 25)
        Me.lblFrom.TabIndex = 23
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTo.Location = New System.Drawing.Point(840, 48)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(35, 25)
        Me.lblTo.TabIndex = 24
        Me.lblTo.Text = "To:"
        '
        'lblAny1
        '
        Me.lblAny1.AutoSize = True
        Me.lblAny1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAny1.Location = New System.Drawing.Point(88, 73)
        Me.lblAny1.Name = "lblAny1"
        Me.lblAny1.Size = New System.Drawing.Size(48, 25)
        Me.lblAny1.TabIndex = 25
        Me.lblAny1.Text = "Any:"
        '
        'lblAny2
        '
        Me.lblAny2.AutoSize = True
        Me.lblAny2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAny2.Location = New System.Drawing.Point(840, 73)
        Me.lblAny2.Name = "lblAny2"
        Me.lblAny2.Size = New System.Drawing.Size(48, 25)
        Me.lblAny2.TabIndex = 26
        Me.lblAny2.Text = "Any:"
        '
        'ComboBoxAny1
        '
        Me.ComboBoxAny1.FormattingEnabled = True
        Me.ComboBoxAny1.Items.AddRange(New Object() {"Choose Your Currency", "Won", "Yen", "Swiss Franc", "USD", "Euro", "Canadian Dollar", "GBP", "Rupees"})
        Me.ComboBoxAny1.Location = New System.Drawing.Point(88, 139)
        Me.ComboBoxAny1.Name = "ComboBoxAny1"
        Me.ComboBoxAny1.Size = New System.Drawing.Size(222, 23)
        Me.ComboBoxAny1.TabIndex = 27
        '
        'ComboBoxAny2
        '
        Me.ComboBoxAny2.FormattingEnabled = True
        Me.ComboBoxAny2.Items.AddRange(New Object() {"Choose Your Currency", "Australian Dollar", "Polish Zloty", "Pakistan Rupee", "Baht", "New Zealand Dollar", "Forint", "DKK ", "UAH", "GBP"})
        Me.ComboBoxAny2.Location = New System.Drawing.Point(840, 130)
        Me.ComboBoxAny2.Name = "ComboBoxAny2"
        Me.ComboBoxAny2.Size = New System.Drawing.Size(219, 23)
        Me.ComboBoxAny2.TabIndex = 28
        '
        'BtnConvertAny1ToAny2
        '
        Me.BtnConvertAny1ToAny2.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnConvertAny1ToAny2.Location = New System.Drawing.Point(88, 168)
        Me.BtnConvertAny1ToAny2.Name = "BtnConvertAny1ToAny2"
        Me.BtnConvertAny1ToAny2.Size = New System.Drawing.Size(222, 53)
        Me.BtnConvertAny1ToAny2.TabIndex = 29
        Me.BtnConvertAny1ToAny2.Text = "Convert Any currency to Any currency"
        Me.BtnConvertAny1ToAny2.UseVisualStyleBackColor = True
        '
        'btnConvertAny2toAny1
        '
        Me.btnConvertAny2toAny1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConvertAny2toAny1.Location = New System.Drawing.Point(840, 159)
        Me.btnConvertAny2toAny1.Name = "btnConvertAny2toAny1"
        Me.btnConvertAny2toAny1.Size = New System.Drawing.Size(228, 62)
        Me.btnConvertAny2toAny1.TabIndex = 30
        Me.btnConvertAny2toAny1.Text = "Convert Any currency to Any Currency"
        Me.btnConvertAny2toAny1.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(540, 159)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 34)
        Me.btnReset.TabIndex = 31
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(1149, 480)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(86, 35)
        Me.btnBack.TabIndex = 32
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 21
        Me.ListBox3.Location = New System.Drawing.Point(35, 258)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(321, 298)
        Me.ListBox3.TabIndex = 33
        '
        'ListBox4
        '
        Me.ListBox4.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 21
        Me.ListBox4.Location = New System.Drawing.Point(668, 258)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(321, 298)
        Me.ListBox4.TabIndex = 36
        '
        'btnAdd5
        '
        Me.btnAdd5.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd5.Location = New System.Drawing.Point(362, 258)
        Me.btnAdd5.Name = "btnAdd5"
        Me.btnAdd5.Size = New System.Drawing.Size(76, 33)
        Me.btnAdd5.TabIndex = 37
        Me.btnAdd5.Text = "Add"
        Me.btnAdd5.UseVisualStyleBackColor = True
        '
        'btnClear6
        '
        Me.btnClear6.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear6.Location = New System.Drawing.Point(362, 297)
        Me.btnClear6.Name = "btnClear6"
        Me.btnClear6.Size = New System.Drawing.Size(76, 36)
        Me.btnClear6.TabIndex = 38
        Me.btnClear6.Text = "Clear"
        Me.btnClear6.UseVisualStyleBackColor = True
        '
        'btnAdd7
        '
        Me.btnAdd7.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd7.Location = New System.Drawing.Point(995, 258)
        Me.btnAdd7.Name = "btnAdd7"
        Me.btnAdd7.Size = New System.Drawing.Size(73, 33)
        Me.btnAdd7.TabIndex = 39
        Me.btnAdd7.Text = "Add"
        Me.btnAdd7.UseVisualStyleBackColor = True
        '
        'btnClear8
        '
        Me.btnClear8.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear8.Location = New System.Drawing.Point(995, 297)
        Me.btnClear8.Name = "btnClear8"
        Me.btnClear8.Size = New System.Drawing.Size(73, 36)
        Me.btnClear8.TabIndex = 40
        Me.btnClear8.Text = "Clear"
        Me.btnClear8.UseVisualStyleBackColor = True
        '
        'FrmchkChoose2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 568)
        Me.Controls.Add(Me.btnClear8)
        Me.Controls.Add(Me.btnAdd7)
        Me.Controls.Add(Me.btnClear6)
        Me.Controls.Add(Me.btnAdd5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConvertAny2toAny1)
        Me.Controls.Add(Me.BtnConvertAny1ToAny2)
        Me.Controls.Add(Me.ComboBoxAny2)
        Me.Controls.Add(Me.ComboBoxAny1)
        Me.Controls.Add(Me.lblAny2)
        Me.Controls.Add(Me.lblAny1)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxAmountAny2)
        Me.Controls.Add(Me.TextBoxAmountAny1)
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
    Friend WithEvents TextBoxAmountAny1 As TextBox
    Friend WithEvents TextBoxAmountAny2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblAny1 As Label
    Friend WithEvents lblAny2 As Label
    Friend WithEvents ComboBoxAny1 As ComboBox
    Friend WithEvents ComboBoxAny2 As ComboBox
    Friend WithEvents BtnConvertAny1ToAny2 As Button
    Friend WithEvents btnConvertAny2toAny1 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents btnAdd5 As Button
    Friend WithEvents btnClear6 As Button
    Friend WithEvents btnAdd7 As Button
    Friend WithEvents btnClear8 As Button
End Class
