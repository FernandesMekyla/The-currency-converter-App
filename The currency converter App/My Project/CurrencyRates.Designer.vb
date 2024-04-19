<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrencyRates
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
        Me.lblUSD = New System.Windows.Forms.Label()
        Me.lblGBP = New System.Windows.Forms.Label()
        Me.lblYEN = New System.Windows.Forms.Label()
        Me.lblEUR = New System.Windows.Forms.Label()
        Me.txtUSD = New System.Windows.Forms.TextBox()
        Me.txtGBP = New System.Windows.Forms.TextBox()
        Me.txtYEN = New System.Windows.Forms.TextBox()
        Me.txtEUR = New System.Windows.Forms.TextBox()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUSD
        '
        Me.lblUSD.AutoSize = True
        Me.lblUSD.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUSD.Location = New System.Drawing.Point(52, 49)
        Me.lblUSD.Name = "lblUSD"
        Me.lblUSD.Size = New System.Drawing.Size(39, 18)
        Me.lblUSD.TabIndex = 0
        Me.lblUSD.Text = "USD"
        '
        'lblGBP
        '
        Me.lblGBP.AutoSize = True
        Me.lblGBP.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGBP.Location = New System.Drawing.Point(52, 109)
        Me.lblGBP.Name = "lblGBP"
        Me.lblGBP.Size = New System.Drawing.Size(39, 18)
        Me.lblGBP.TabIndex = 1
        Me.lblGBP.Text = "GBP"
        '
        'lblYEN
        '
        Me.lblYEN.AutoSize = True
        Me.lblYEN.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblYEN.Location = New System.Drawing.Point(52, 176)
        Me.lblYEN.Name = "lblYEN"
        Me.lblYEN.Size = New System.Drawing.Size(41, 18)
        Me.lblYEN.TabIndex = 2
        Me.lblYEN.Text = "YEN"
        '
        'lblEUR
        '
        Me.lblEUR.AutoSize = True
        Me.lblEUR.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEUR.Location = New System.Drawing.Point(52, 242)
        Me.lblEUR.Name = "lblEUR"
        Me.lblEUR.Size = New System.Drawing.Size(41, 18)
        Me.lblEUR.TabIndex = 3
        Me.lblEUR.Text = "EUR"
        '
        'txtUSD
        '
        Me.txtUSD.Location = New System.Drawing.Point(174, 41)
        Me.txtUSD.Name = "txtUSD"
        Me.txtUSD.Size = New System.Drawing.Size(100, 23)
        Me.txtUSD.TabIndex = 4
        '
        'txtGBP
        '
        Me.txtGBP.Location = New System.Drawing.Point(174, 101)
        Me.txtGBP.Name = "txtGBP"
        Me.txtGBP.Size = New System.Drawing.Size(100, 23)
        Me.txtGBP.TabIndex = 5
        '
        'txtYEN
        '
        Me.txtYEN.Location = New System.Drawing.Point(174, 176)
        Me.txtYEN.Name = "txtYEN"
        Me.txtYEN.Size = New System.Drawing.Size(100, 23)
        Me.txtYEN.TabIndex = 6
        '
        'txtEUR
        '
        Me.txtEUR.Location = New System.Drawing.Point(174, 242)
        Me.txtEUR.Name = "txtEUR"
        Me.txtEUR.Size = New System.Drawing.Size(100, 23)
        Me.txtEUR.TabIndex = 7
        '
        'btnSAVE
        '
        Me.btnSAVE.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSAVE.Location = New System.Drawing.Point(430, 291)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(80, 29)
        Me.btnSAVE.TabIndex = 8
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = True
        '
        'CurrencyRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.txtEUR)
        Me.Controls.Add(Me.txtYEN)
        Me.Controls.Add(Me.txtGBP)
        Me.Controls.Add(Me.txtUSD)
        Me.Controls.Add(Me.lblEUR)
        Me.Controls.Add(Me.lblYEN)
        Me.Controls.Add(Me.lblGBP)
        Me.Controls.Add(Me.lblUSD)
        Me.Name = "CurrencyRates"
        Me.Text = "CurrencyRates"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUSD As Label
    Friend WithEvents lblGBP As Label
    Friend WithEvents lblYEN As Label
    Friend WithEvents lblEUR As Label
    Friend WithEvents txtUSD As TextBox
    Friend WithEvents txtGBP As TextBox
    Friend WithEvents txtYEN As TextBox
    Friend WithEvents txtEUR As TextBox
    Friend WithEvents btnSAVE As Button
End Class
