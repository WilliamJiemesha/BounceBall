<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(level3))
        Me.pantulanbar = New System.Windows.Forms.Button()
        Me.jalan = New System.Windows.Forms.Timer(Me.components)
        Me.bola = New System.Windows.Forms.Button()
        Me.itemdrop = New System.Windows.Forms.Timer(Me.components)
        Me.score = New System.Windows.Forms.Label()
        Me.Lives = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pantulanbar
        '
        Me.pantulanbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pantulanbar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pantulanbar.Location = New System.Drawing.Point(318, 53)
        Me.pantulanbar.Name = "pantulanbar"
        Me.pantulanbar.Size = New System.Drawing.Size(165, 23)
        Me.pantulanbar.TabIndex = 4
        Me.pantulanbar.UseVisualStyleBackColor = False
        '
        'jalan
        '
        Me.jalan.Enabled = True
        Me.jalan.Interval = 10
        '
        'bola
        '
        Me.bola.BackColor = System.Drawing.SystemColors.Highlight
        Me.bola.BackgroundImage = CType(resources.GetObject("bola.BackgroundImage"), System.Drawing.Image)
        Me.bola.Image = CType(resources.GetObject("bola.Image"), System.Drawing.Image)
        Me.bola.Location = New System.Drawing.Point(318, 375)
        Me.bola.Name = "bola"
        Me.bola.Size = New System.Drawing.Size(25, 23)
        Me.bola.TabIndex = 5
        Me.bola.UseVisualStyleBackColor = False
        '
        'itemdrop
        '
        Me.itemdrop.Enabled = True
        Me.itemdrop.Interval = 20
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Location = New System.Drawing.Point(350, 633)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(65, 17)
        Me.score.TabIndex = 7
        Me.score.Text = "Score : 0"
        '
        'Lives
        '
        Me.Lives.AutoSize = True
        Me.Lives.Location = New System.Drawing.Point(350, 600)
        Me.Lives.Name = "Lives"
        Me.Lives.Size = New System.Drawing.Size(61, 17)
        Me.Lives.TabIndex = 6
        Me.Lives.Text = "Lives : 1"
        '
        'level3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.Lives)
        Me.Controls.Add(Me.pantulanbar)
        Me.Controls.Add(Me.bola)
        Me.Name = "level3"
        Me.Text = "Level 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pantulanbar As Button
    Friend WithEvents jalan As Timer
    Friend WithEvents bola As Button
    Friend WithEvents itemdrop As Timer
    Friend WithEvents score As Label
    Friend WithEvents Lives As Label
End Class
