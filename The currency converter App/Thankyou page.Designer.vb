<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmThankyouPage
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_currency_converter_App.My.Resources.Resources.logo_for_app
        Me.PictureBox1.Location = New System.Drawing.Point(268, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(353, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 33)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Thankyou!!!!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Californian FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(184, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(593, 33)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Successful, Thankyou for usiong World Money!!!"
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(829, 480)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 38)
        Me.btnQuit.TabIndex = 19
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(829, 434)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 40)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmThankyouPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 530)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmThankyouPage"
        Me.Text = "frmThankyouPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnBack As Button
End Class
