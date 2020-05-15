<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookChoice
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
        Me.lblAppropriateBooks = New System.Windows.Forms.Label()
        Me.rchBookChoices = New System.Windows.Forms.RichTextBox()
        Me.picNum1 = New System.Windows.Forms.PictureBox()
        Me.picNum2 = New System.Windows.Forms.PictureBox()
        Me.picNum3 = New System.Windows.Forms.PictureBox()
        CType(Me.picNum1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNum2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNum3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAppropriateBooks
        '
        Me.lblAppropriateBooks.AutoSize = True
        Me.lblAppropriateBooks.BackColor = System.Drawing.Color.Transparent
        Me.lblAppropriateBooks.Font = New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppropriateBooks.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblAppropriateBooks.Location = New System.Drawing.Point(119, 23)
        Me.lblAppropriateBooks.Name = "lblAppropriateBooks"
        Me.lblAppropriateBooks.Size = New System.Drawing.Size(231, 50)
        Me.lblAppropriateBooks.TabIndex = 1
        Me.lblAppropriateBooks.Text = "Book Choices" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for You"
        Me.lblAppropriateBooks.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rchBookChoices
        '
        Me.rchBookChoices.BackColor = System.Drawing.SystemColors.Control
        Me.rchBookChoices.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rchBookChoices.ForeColor = System.Drawing.Color.LimeGreen
        Me.rchBookChoices.Location = New System.Drawing.Point(12, 97)
        Me.rchBookChoices.Name = "rchBookChoices"
        Me.rchBookChoices.Size = New System.Drawing.Size(487, 490)
        Me.rchBookChoices.TabIndex = 2
        Me.rchBookChoices.Text = ""
        '
        'picNum1
        '
        Me.picNum1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picNum1.Location = New System.Drawing.Point(644, 23)
        Me.picNum1.Name = "picNum1"
        Me.picNum1.Size = New System.Drawing.Size(178, 137)
        Me.picNum1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picNum1.TabIndex = 3
        Me.picNum1.TabStop = False
        '
        'picNum2
        '
        Me.picNum2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picNum2.Location = New System.Drawing.Point(538, 283)
        Me.picNum2.Name = "picNum2"
        Me.picNum2.Size = New System.Drawing.Size(178, 137)
        Me.picNum2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picNum2.TabIndex = 4
        Me.picNum2.TabStop = False
        '
        'picNum3
        '
        Me.picNum3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picNum3.Location = New System.Drawing.Point(644, 450)
        Me.picNum3.Name = "picNum3"
        Me.picNum3.Size = New System.Drawing.Size(178, 137)
        Me.picNum3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picNum3.TabIndex = 5
        Me.picNum3.TabStop = False
        '
        'BookChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(834, 611)
        Me.Controls.Add(Me.picNum3)
        Me.Controls.Add(Me.picNum2)
        Me.Controls.Add(Me.picNum1)
        Me.Controls.Add(Me.rchBookChoices)
        Me.Controls.Add(Me.lblAppropriateBooks)
        Me.Name = "BookChoice"
        Me.Text = "Book Choice"
        CType(Me.picNum1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNum2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNum3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAppropriateBooks As Label
    Friend WithEvents rchBookChoices As RichTextBox
    Friend WithEvents picNum1 As PictureBox
    Friend WithEvents picNum2 As PictureBox
    Friend WithEvents picNum3 As PictureBox
End Class
