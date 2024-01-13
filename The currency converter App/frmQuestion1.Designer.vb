<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuestion1
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
        lblWelcomeTo = New Label()
        btnQuit = New Button()
        txtChoose1 = New TextBox()
        txtChoose2 = New TextBox()
        PictureBox1 = New PictureBox()
        chkChoose1 = New CheckBox()
        chkChoose2 = New CheckBox()
        btnNext = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelcomeTo
        ' 
        lblWelcomeTo.AutoSize = True
        lblWelcomeTo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblWelcomeTo.Location = New Point(81, 48)
        lblWelcomeTo.Name = "lblWelcomeTo"
        lblWelcomeTo.Size = New Size(124, 25)
        lblWelcomeTo.TabIndex = 0
        lblWelcomeTo.Text = "Welcome To:"
        ' 
        ' btnQuit
        ' 
        btnQuit.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnQuit.Location = New Point(713, 407)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(75, 31)
        btnQuit.TabIndex = 4
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' txtChoose1
        ' 
        txtChoose1.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtChoose1.Location = New Point(188, 169)
        txtChoose1.Name = "txtChoose1"
        txtChoose1.Size = New Size(351, 26)
        txtChoose1.TabIndex = 5
        txtChoose1.Text = "Choose Option 1 if you want to convert GBP To Any."
        ' 
        ' txtChoose2
        ' 
        txtChoose2.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtChoose2.Location = New Point(188, 248)
        txtChoose2.Name = "txtChoose2"
        txtChoose2.Size = New Size(351, 26)
        txtChoose2.TabIndex = 6
        txtChoose2.Text = "Choose Option 1 if you want to convert Any To Any."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_for_app
        PictureBox1.Location = New Point(211, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' chkChoose1
        ' 
        chkChoose1.Appearance = Appearance.Button
        chkChoose1.AutoSize = True
        chkChoose1.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkChoose1.Location = New Point(81, 173)
        chkChoose1.Name = "chkChoose1"
        chkChoose1.Size = New Size(78, 28)
        chkChoose1.TabIndex = 10
        chkChoose1.Text = "Choose 1"
        chkChoose1.UseVisualStyleBackColor = True
        ' 
        ' chkChoose2
        ' 
        chkChoose2.Appearance = Appearance.Button
        chkChoose2.AutoSize = True
        chkChoose2.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkChoose2.Location = New Point(81, 248)
        chkChoose2.Name = "chkChoose2"
        chkChoose2.Size = New Size(78, 28)
        chkChoose2.TabIndex = 11
        chkChoose2.Text = "Choose 2"
        chkChoose2.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnNext.Location = New Point(713, 372)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(75, 29)
        btnNext.TabIndex = 12
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' FrmQuestion1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(chkChoose2)
        Controls.Add(chkChoose1)
        Controls.Add(PictureBox1)
        Controls.Add(txtChoose2)
        Controls.Add(txtChoose1)
        Controls.Add(btnQuit)
        Controls.Add(lblWelcomeTo)
        Name = "FrmQuestion1"
        Text = "frmQuestion1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeTo As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtChoose1 As TextBox
    Friend WithEvents txtChoose2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chkChoose1 As CheckBox
    Friend WithEvents chkChoose2 As CheckBox
    Friend WithEvents btnNext As Button
End Class
