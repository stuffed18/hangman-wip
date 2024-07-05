<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MissionForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MissionForm))
        Me.MissionTextLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerWait = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonContinue = New System.Windows.Forms.Button()
        Me.TimerContinue = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MissionTextLabel
        '
        Me.MissionTextLabel.AutoSize = True
        Me.MissionTextLabel.BackColor = System.Drawing.Color.Transparent
        Me.MissionTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MissionTextLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MissionTextLabel.Location = New System.Drawing.Point(37, 102)
        Me.MissionTextLabel.Name = "MissionTextLabel"
        Me.MissionTextLabel.Size = New System.Drawing.Size(695, 240)
        Me.MissionTextLabel.TabIndex = 0
        Me.MissionTextLabel.Text = resources.GetString("MissionTextLabel.Text")
        Me.MissionTextLabel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(37, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENTER USERNAME:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(246, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(301, 21)
        Me.TextBox1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Timer2
        '
        Me.Timer2.Interval = 40
        '
        'TimerWait
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(653, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 54)
        Me.Button1.TabIndex = 4
        Me.Button1.TabStop = False
        Me.Button1.Text = "SKIP?"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonContinue
        '
        Me.ButtonContinue.BackColor = System.Drawing.Color.Transparent
        Me.ButtonContinue.FlatAppearance.BorderSize = 0
        Me.ButtonContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonContinue.Location = New System.Drawing.Point(-2, 366)
        Me.ButtonContinue.Name = "ButtonContinue"
        Me.ButtonContinue.Size = New System.Drawing.Size(231, 38)
        Me.ButtonContinue.TabIndex = 5
        Me.ButtonContinue.TabStop = False
        Me.ButtonContinue.Text = "CONTINUE..."
        Me.ButtonContinue.UseVisualStyleBackColor = False
        Me.ButtonContinue.Visible = False
        '
        'TimerContinue
        '
        Me.TimerContinue.Interval = 1000
        '
        'MissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.hangmantest1.My.Resources.Resources.grid_room_in_perspective_illustration_in_3d_style_indoor_wireframe_from_green_lines_template_interior_square_digital_empty_box_laser_beam_on_black_background_vector
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonContinue)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MissionTextLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MissionForm"
        Me.Text = "Bangman"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MissionTextLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TimerWait As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonContinue As Button
    Friend WithEvents TimerContinue As Timer
End Class
