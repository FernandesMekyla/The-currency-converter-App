<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmQuestion1
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
        Me.lblWelcomeTo = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtChoose1 = New System.Windows.Forms.TextBox()
        Me.txtChoose2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkChoose1 = New System.Windows.Forms.CheckBox()
        Me.chkChoose2 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeTo
        '
        Me.lblWelcomeTo.AutoSize = True
        Me.lblWelcomeTo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcomeTo.Location = New System.Drawing.Point(81, 48)
        Me.lblWelcomeTo.Name = "lblWelcomeTo"
        Me.lblWelcomeTo.Size = New System.Drawing.Size(160, 32)
        Me.lblWelcomeTo.TabIndex = 0
        Me.lblWelcomeTo.Text = "Welcome To:"
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(825, 502)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(91, 44)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtChoose1
        '
        Me.txtChoose1.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtChoose1.Location = New System.Drawing.Point(240, 224)
        Me.txtChoose1.Name = "txtChoose1"
        Me.txtChoose1.Size = New System.Drawing.Size(457, 31)
        Me.txtChoose1.TabIndex = 5
        Me.txtChoose1.Text = "Choose Option 1 if you want to convert GBP To Any."
        '
        'txtChoose2
        '
        Me.txtChoose2.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtChoose2.Location = New System.Drawing.Point(240, 290)
        Me.txtChoose2.Name = "txtChoose2"
        Me.txtChoose2.Size = New System.Drawing.Size(457, 31)
        Me.txtChoose2.TabIndex = 6
        Me.txtChoose2.Text = "Choose Option 1 if you want to convert Any To Any."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_currency_converter_App.My.Resources.Resources.logo_for_app
        Me.PictureBox1.Location = New System.Drawing.Point(268, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'chkChoose1
        '
        Me.chkChoose1.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkChoose1.AutoSize = True
        Me.chkChoose1.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkChoose1.Location = New System.Drawing.Point(81, 224)
        Me.chkChoose1.Name = "chkChoose1"
        Me.chkChoose1.Size = New System.Drawing.Size(112, 37)
        Me.chkChoose1.TabIndex = 10
        Me.chkChoose1.Text = "Choose 1"
        Me.chkChoose1.UseVisualStyleBackColor = True
        '
        'chkChoose2
        '
        Me.chkChoose2.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkChoose2.AutoSize = True
        Me.chkChoose2.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkChoose2.Location = New System.Drawing.Point(81, 281)
        Me.chkChoose2.Name = "chkChoose2"
        Me.chkChoose2.Size = New System.Drawing.Size(112, 37)
        Me.chkChoose2.TabIndex = 11
        Me.chkChoose2.Text = "Choose 2"
        Me.chkChoose2.UseVisualStyleBackColor = True
        '
        'FrmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 558)
        Me.Controls.Add(Me.chkChoose2)
        Me.Controls.Add(Me.chkChoose1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtChoose2)
        Me.Controls.Add(Me.txtChoose1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblWelcomeTo)
        Me.Name = "FrmQuestion1"
        Me.Text = "frmQuestion1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeTo As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtChoose1 As TextBox
    Friend WithEvents txtChoose2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chkChoose1 As CheckBox
    Friend WithEvents chkChoose2 As CheckBox
End Class
