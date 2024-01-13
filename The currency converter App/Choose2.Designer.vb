<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose2
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
        btnQuit = New Button()
        btnNext = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        PictureBox1 = New PictureBox()
        lblFrom = New Label()
        lblTo = New Label()
        lblAny1 = New Label()
        lblAny2 = New Label()
        ComboBoxAny1 = New ComboBox()
        ComboBoxAny2 = New ComboBox()
        Button1 = New Button()
        btnConvertAny2toAny1 = New Button()
        btnReset = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnQuit
        ' 
        btnQuit.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnQuit.Location = New Point(713, 415)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(75, 31)
        btnQuit.TabIndex = 14
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnNext.Location = New Point(713, 380)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(75, 29)
        btnNext.TabIndex = 15
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(77, 135)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 20
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(584, 135)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 21
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.reverse_arrows
        PictureBox1.Location = New Point(338, 72)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(109, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.Location = New Point(77, 72)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(38, 15)
        lblFrom.TabIndex = 23
        lblFrom.Text = "From:"
        ' 
        ' lblTo
        ' 
        lblTo.AutoSize = True
        lblTo.Location = New Point(584, 72)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(22, 15)
        lblTo.TabIndex = 24
        lblTo.Text = "To:"
        ' 
        ' lblAny1
        ' 
        lblAny1.AutoSize = True
        lblAny1.Location = New Point(77, 117)
        lblAny1.Name = "lblAny1"
        lblAny1.Size = New Size(31, 15)
        lblAny1.TabIndex = 25
        lblAny1.Text = "Any:"
        ' 
        ' lblAny2
        ' 
        lblAny2.AutoSize = True
        lblAny2.Location = New Point(584, 117)
        lblAny2.Name = "lblAny2"
        lblAny2.Size = New Size(31, 15)
        lblAny2.TabIndex = 26
        lblAny2.Text = "Any:"
        ' 
        ' ComboBoxAny1
        ' 
        ComboBoxAny1.FormattingEnabled = True
        ComboBoxAny1.Location = New Point(77, 164)
        ComboBoxAny1.Name = "ComboBoxAny1"
        ComboBoxAny1.Size = New Size(157, 23)
        ComboBoxAny1.TabIndex = 27
        ComboBoxAny1.Text = " Choose your Currency "
        ' 
        ' ComboBoxAny2
        ' 
        ComboBoxAny2.FormattingEnabled = True
        ComboBoxAny2.Location = New Point(584, 164)
        ComboBoxAny2.Name = "ComboBoxAny2"
        ComboBoxAny2.Size = New Size(152, 23)
        ComboBoxAny2.TabIndex = 28
        ComboBoxAny2.Text = "Choose your Currency"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bodoni MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(80, 213)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 76)
        Button1.TabIndex = 29
        Button1.Text = "Convert Any currency to Any currency"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnConvertAny2toAny1
        ' 
        btnConvertAny2toAny1.Font = New Font("Bodoni MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnConvertAny2toAny1.Location = New Point(582, 213)
        btnConvertAny2toAny1.Name = "btnConvertAny2toAny1"
        btnConvertAny2toAny1.Size = New Size(154, 76)
        btnConvertAny2toAny1.TabIndex = 30
        btnConvertAny2toAny1.Text = "Convert Any currency to Any Currency"
        btnConvertAny2toAny1.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Georgia Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(338, 246)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(109, 43)
        btnReset.TabIndex = 31
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Choose2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnConvertAny2toAny1)
        Controls.Add(Button1)
        Controls.Add(ComboBoxAny2)
        Controls.Add(ComboBoxAny1)
        Controls.Add(lblAny2)
        Controls.Add(lblAny1)
        Controls.Add(lblTo)
        Controls.Add(lblFrom)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnNext)
        Controls.Add(btnQuit)
        Name = "Choose2"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
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
End Class
