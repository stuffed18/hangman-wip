<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogoForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LogoPicture = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'LogoPicture
        '
        Me.LogoPicture.Image = Global.hangmantest1.My.Resources.Resources.companylogo1
        Me.LogoPicture.Location = New System.Drawing.Point(93, 53)
        Me.LogoPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPicture.Name = "LogoPicture"
        Me.LogoPicture.Size = New System.Drawing.Size(605, 352)
        Me.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPicture.TabIndex = 4
        Me.LogoPicture.TabStop = False
        Me.LogoPicture.Visible = False
        '
        'LogoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LogoPicture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogoForm"
        Me.Text = "Bangman"
        CType(Me.LogoPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents LogoPicture As PictureBox
End Class
