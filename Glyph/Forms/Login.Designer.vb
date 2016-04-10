<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.AdobeTheme1 = New Glyph.AdobeTheme()
        Me.AdobeProgressBar1 = New Glyph.AdobeProgressBar()
        Me.AdobeButton3 = New Glyph.AdobeButton()
        Me.AdobeCheck1 = New Glyph.AdobeCheck()
        Me.AdobeButton2 = New Glyph.AdobeButton()
        Me.AdobeButton1 = New Glyph.AdobeButton()
        Me.AdobeTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdobeTheme1
        '
        Me.AdobeTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AdobeTheme1.Controls.Add(Me.AdobeProgressBar1)
        Me.AdobeTheme1.Controls.Add(Me.AdobeButton3)
        Me.AdobeTheme1.Controls.Add(Me.AdobeCheck1)
        Me.AdobeTheme1.Controls.Add(Me.AdobeButton2)
        Me.AdobeTheme1.Controls.Add(Me.AdobeButton1)
        Me.AdobeTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdobeTheme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AdobeTheme1.Image = Nothing
        Me.AdobeTheme1.Location = New System.Drawing.Point(0, 0)
        Me.AdobeTheme1.MoveHeight = 19
        Me.AdobeTheme1.Name = "AdobeTheme1"
        Me.AdobeTheme1.Resizable = False
        Me.AdobeTheme1.Size = New System.Drawing.Size(284, 262)
        Me.AdobeTheme1.TabIndex = 0
        Me.AdobeTheme1.TextAlignment = Glyph.AdobeTheme.TextAlign.Left
        Me.AdobeTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'AdobeProgressBar1
        '
        Me.AdobeProgressBar1.Image = Nothing
        Me.AdobeProgressBar1.Location = New System.Drawing.Point(22, 115)
        Me.AdobeProgressBar1.Maximum = 0
        Me.AdobeProgressBar1.Name = "AdobeProgressBar1"
        Me.AdobeProgressBar1.NoRounding = False
        Me.AdobeProgressBar1.Size = New System.Drawing.Size(122, 23)
        Me.AdobeProgressBar1.TabIndex = 4
        Me.AdobeProgressBar1.Text = "AdobeProgressBar1"
        Me.AdobeProgressBar1.Value = 0
        '
        'AdobeButton3
        '
        Me.AdobeButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AdobeButton3.Image = Nothing
        Me.AdobeButton3.Location = New System.Drawing.Point(33, 41)
        Me.AdobeButton3.Name = "AdobeButton3"
        Me.AdobeButton3.NoRounding = False
        Me.AdobeButton3.Orange = False
        Me.AdobeButton3.Size = New System.Drawing.Size(140, 23)
        Me.AdobeButton3.TabIndex = 3
        Me.AdobeButton3.Text = "AdobeButton3"
        '
        'AdobeCheck1
        '
        Me.AdobeCheck1.CheckedState = False
        Me.AdobeCheck1.Image = Nothing
        Me.AdobeCheck1.Location = New System.Drawing.Point(62, 173)
        Me.AdobeCheck1.MaximumSize = New System.Drawing.Size(600, 16)
        Me.AdobeCheck1.MinimumSize = New System.Drawing.Size(16, 16)
        Me.AdobeCheck1.Name = "AdobeCheck1"
        Me.AdobeCheck1.NoRounding = False
        Me.AdobeCheck1.Size = New System.Drawing.Size(147, 16)
        Me.AdobeCheck1.TabIndex = 2
        Me.AdobeCheck1.Text = "AdobeCheck1"
        '
        'AdobeButton2
        '
        Me.AdobeButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AdobeButton2.Image = Nothing
        Me.AdobeButton2.Location = New System.Drawing.Point(105, 144)
        Me.AdobeButton2.Name = "AdobeButton2"
        Me.AdobeButton2.NoRounding = False
        Me.AdobeButton2.Orange = False
        Me.AdobeButton2.Size = New System.Drawing.Size(122, 23)
        Me.AdobeButton2.TabIndex = 1
        Me.AdobeButton2.Text = "AdobeButton2"
        '
        'AdobeButton1
        '
        Me.AdobeButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AdobeButton1.Image = Nothing
        Me.AdobeButton1.Location = New System.Drawing.Point(82, 78)
        Me.AdobeButton1.Name = "AdobeButton1"
        Me.AdobeButton1.NoRounding = False
        Me.AdobeButton1.Orange = False
        Me.AdobeButton1.Size = New System.Drawing.Size(145, 23)
        Me.AdobeButton1.TabIndex = 0
        Me.AdobeButton1.Text = "AdobeButton1"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.AdobeTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AdobeTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdobeTheme1 As Glyph.AdobeTheme
    Friend WithEvents AdobeProgressBar1 As Glyph.AdobeProgressBar
    Friend WithEvents AdobeButton3 As Glyph.AdobeButton
    Friend WithEvents AdobeCheck1 As Glyph.AdobeCheck
    Friend WithEvents AdobeButton2 As Glyph.AdobeButton
    Friend WithEvents AdobeButton1 As Glyph.AdobeButton
End Class
