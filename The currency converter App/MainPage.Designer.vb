﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainpage
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
        lblWelcomeTo = New Label()
        lblUserName = New Label()
        txtUsername = New TextBox()
        btnNext = New Button()
        btnSkip = New Button()
        btnQuit = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelcomeTo
        ' 
        lblWelcomeTo.AutoSize = True
        lblWelcomeTo.Location = New Point(91, 102)
        lblWelcomeTo.Name = "lblWelcomeTo"
        lblWelcomeTo.Size = New Size(71, 15)
        lblWelcomeTo.TabIndex = 1
        lblWelcomeTo.Text = "Welcome to"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblUserName.Location = New Point(91, 184)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(88, 19)
        lblUserName.TabIndex = 2
        lblUserName.Text = "UserName:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(211, 186)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(262, 23)
        txtUsername.TabIndex = 6
        ' 
        ' btnNext
        ' 
        btnNext.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnNext.Location = New Point(713, 344)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(75, 29)
        btnNext.TabIndex = 8
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnSkip
        ' 
        btnSkip.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSkip.Location = New Point(713, 379)
        btnSkip.Name = "btnSkip"
        btnSkip.Size = New Size(75, 32)
        btnSkip.TabIndex = 9
        btnSkip.Text = "Skip"
        btnSkip.UseVisualStyleBackColor = True
        ' 
        ' btnQuit
        ' 
        btnQuit.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnQuit.Location = New Point(713, 417)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(75, 31)
        btnQuit.TabIndex = 10
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_for_app
        PictureBox1.Location = New Point(211, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(181, 112)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Mainpage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(btnQuit)
        Controls.Add(btnSkip)
        Controls.Add(btnNext)
        Controls.Add(txtUsername)
        Controls.Add(lblUserName)
        Controls.Add(lblWelcomeTo)
        Name = "Mainpage"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeTo As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSkip As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
