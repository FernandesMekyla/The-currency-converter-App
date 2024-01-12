<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        btnQuit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_for_app
        PictureBox1.Location = New Point(268, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(294, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Californian FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(353, 258)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 24)
        Label1.TabIndex = 17
        Label1.Text = "Thankyou!!!!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Californian FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(184, 300)
        Label2.Name = "Label2"
        Label2.Size = New Size(435, 24)
        Label2.TabIndex = 18
        Label2.Text = "Successful, Thankyou for usiong World Money!!!"
        ' 
        ' btnQuit
        ' 
        btnQuit.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnQuit.Location = New Point(713, 415)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(75, 30)
        btnQuit.TabIndex = 19
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnQuit)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form5"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuit As Button
End Class
