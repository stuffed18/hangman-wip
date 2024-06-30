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
        Me.SuspendLayout()
        '
        'ButtonPlay
        '
        Me.ButtonPlay.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!)
        Me.ButtonPlay.Location = New System.Drawing.Point(761, 202)
        Me.ButtonPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(184, 85)
        Me.ButtonPlay.TabIndex = 0
        Me.ButtonPlay.Text = "Play"
        Me.ButtonPlay.UseVisualStyleBackColor = False
        '
        'ButtonSettings
        '
        Me.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ButtonSettings.Location = New System.Drawing.Point(761, 290)
        Me.ButtonSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(184, 49)
        Me.ButtonSettings.TabIndex = 1
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.UseVisualStyleBackColor = True
        '
        'ButtonTutorial
        '
        Me.ButtonTutorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTutorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTutorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ButtonTutorial.Location = New System.Drawing.Point(761, 343)
        Me.ButtonTutorial.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonTutorial.Name = "ButtonTutorial"
        Me.ButtonTutorial.Size = New System.Drawing.Size(184, 49)
        Me.ButtonTutorial.TabIndex = 2
        Me.ButtonTutorial.Text = "Tutorial"
        Me.ButtonTutorial.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.hangmantest1.My.Resources.Resources.bombdefusalwallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ButtonTutorial)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        Me.TransparencyKey = System.Drawing.Color.RosyBrown
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonPlay As Button
    Friend WithEvents ButtonSettings As Button
    Friend WithEvents ButtonTutorial As Button
End Class
