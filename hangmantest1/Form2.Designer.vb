<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.ThemeRadio1 = New System.Windows.Forms.RadioButton()
        Me.ThemeRadio2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ThemeRadio3 = New System.Windows.Forms.RadioButton()
        Me.ThemeRadio4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ThemeRadio1
        '
        Me.ThemeRadio1.AutoSize = True
        Me.ThemeRadio1.Location = New System.Drawing.Point(348, 262)
        Me.ThemeRadio1.Margin = New System.Windows.Forms.Padding(4)
        Me.ThemeRadio1.Name = "ThemeRadio1"
        Me.ThemeRadio1.Size = New System.Drawing.Size(94, 20)
        Me.ThemeRadio1.TabIndex = 0
        Me.ThemeRadio1.TabStop = True
        Me.ThemeRadio1.Text = "Electronics"
        Me.ThemeRadio1.UseVisualStyleBackColor = True
        '
        'ThemeRadio2
        '
        Me.ThemeRadio2.AutoSize = True
        Me.ThemeRadio2.Location = New System.Drawing.Point(348, 290)
        Me.ThemeRadio2.Margin = New System.Windows.Forms.Padding(4)
        Me.ThemeRadio2.Name = "ThemeRadio2"
        Me.ThemeRadio2.Size = New System.Drawing.Size(63, 20)
        Me.ThemeRadio2.TabIndex = 1
        Me.ThemeRadio2.TabStop = True
        Me.ThemeRadio2.Text = "Tools"
        Me.ThemeRadio2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(281, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 48)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Settings"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 92)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 48)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ThemeRadio3
        '
        Me.ThemeRadio3.AutoSize = True
        Me.ThemeRadio3.Location = New System.Drawing.Point(348, 318)
        Me.ThemeRadio3.Margin = New System.Windows.Forms.Padding(4)
        Me.ThemeRadio3.Name = "ThemeRadio3"
        Me.ThemeRadio3.Size = New System.Drawing.Size(89, 20)
        Me.ThemeRadio3.TabIndex = 6
        Me.ThemeRadio3.TabStop = True
        Me.ThemeRadio3.Text = "Surnames"
        Me.ThemeRadio3.UseVisualStyleBackColor = True
        '
        'ThemeRadio4
        '
        Me.ThemeRadio4.AutoSize = True
        Me.ThemeRadio4.Location = New System.Drawing.Point(348, 346)
        Me.ThemeRadio4.Margin = New System.Windows.Forms.Padding(4)
        Me.ThemeRadio4.Name = "ThemeRadio4"
        Me.ThemeRadio4.Size = New System.Drawing.Size(67, 20)
        Me.ThemeRadio4.TabIndex = 7
        Me.ThemeRadio4.TabStop = True
        Me.ThemeRadio4.Text = "Mixed!"
        Me.ThemeRadio4.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ThemeRadio4)
        Me.Controls.Add(Me.ThemeRadio3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ThemeRadio2)
        Me.Controls.Add(Me.ThemeRadio1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ThemeRadio1 As RadioButton
    Friend WithEvents ThemeRadio2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ThemeRadio3 As RadioButton
    Friend WithEvents ThemeRadio4 As RadioButton
End Class
