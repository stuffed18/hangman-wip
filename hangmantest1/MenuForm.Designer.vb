<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.ButtonTutorial = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonPlay
        '
        Me.ButtonPlay.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!)
        Me.ButtonPlay.Location = New System.Drawing.Point(584, 160)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(138, 69)
        Me.ButtonPlay.TabIndex = 0
        Me.ButtonPlay.Text = "Play"
        Me.ButtonPlay.UseVisualStyleBackColor = False
        '
        'ButtonSettings
        '
        Me.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ButtonSettings.Location = New System.Drawing.Point(584, 235)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(138, 40)
        Me.ButtonSettings.TabIndex = 1
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.UseVisualStyleBackColor = True
        '
        'ButtonTutorial
        '
        Me.ButtonTutorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTutorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonTutorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTutorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ButtonTutorial.Location = New System.Drawing.Point(584, 279)
        Me.ButtonTutorial.Name = "ButtonTutorial"
        Me.ButtonTutorial.Size = New System.Drawing.Size(138, 40)
        Me.ButtonTutorial.TabIndex = 2
        Me.ButtonTutorial.Text = "Tutorial"
        Me.ButtonTutorial.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.hangmantest1.My.Resources.Resources.BangmanLogo2
        Me.PictureBox1.Location = New System.Drawing.Point(405, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(399, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.hangmantest1.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(405, 310)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(138, 82)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.hangmantest1.My.Resources.Resources.bombdefusalwallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(804, 461)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ButtonTutorial)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        Me.TransparencyKey = System.Drawing.Color.RosyBrown
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonPlay As Button
    Friend WithEvents ButtonSettings As Button
    Friend WithEvents ButtonTutorial As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
