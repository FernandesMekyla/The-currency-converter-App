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
        Me.lblWelcomeTo = New System.Windows.Forms.Label()
        Me.lblChoose1 = New System.Windows.Forms.Label()
        Me.lblChoose2 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtChoose1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeTo
        '
        Me.lblWelcomeTo.AutoSize = True
        Me.lblWelcomeTo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcomeTo.Location = New System.Drawing.Point(81, 48)
        Me.lblWelcomeTo.Name = "lblWelcomeTo"
        Me.lblWelcomeTo.Size = New System.Drawing.Size(124, 25)
        Me.lblWelcomeTo.TabIndex = 0
        Me.lblWelcomeTo.Text = "Welcome To:"
        '
        'lblChoose1
        '
        Me.lblChoose1.AutoSize = True
        Me.lblChoose1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblChoose1.Location = New System.Drawing.Point(81, 169)
        Me.lblChoose1.Name = "lblChoose1"
        Me.lblChoose1.Size = New System.Drawing.Size(88, 18)
        Me.lblChoose1.TabIndex = 1
        Me.lblChoose1.Text = "Choose 1:"
        '
        'lblChoose2
        '
        Me.lblChoose2.AutoSize = True
        Me.lblChoose2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblChoose2.Location = New System.Drawing.Point(81, 256)
        Me.lblChoose2.Name = "lblChoose2"
        Me.lblChoose2.Size = New System.Drawing.Size(88, 18)
        Me.lblChoose2.TabIndex = 2
        Me.lblChoose2.Text = "Choose 2:"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(713, 381)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 29)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(713, 416)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 31)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtChoose1
        '
        Me.txtChoose1.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtChoose1.Location = New System.Drawing.Point(188, 169)
        Me.txtChoose1.Name = "txtChoose1"
        Me.txtChoose1.Size = New System.Drawing.Size(351, 26)
        Me.txtChoose1.TabIndex = 5
        Me.txtChoose1.Text = "Choose Option 1 if you want to convert GBP To Any."
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(188, 248)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(351, 26)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "Choose Option 1 if you want to convert Any To Any."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_currency_converter_App.My.Resources.Resources.logo_for_app
        Me.PictureBox1.Location = New System.Drawing.Point(211, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtChoose1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblChoose2)
        Me.Controls.Add(Me.lblChoose1)
        Me.Controls.Add(Me.lblWelcomeTo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeTo As Label
    Friend WithEvents lblChoose1 As Label
    Friend WithEvents lblChoose2 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtChoose1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
