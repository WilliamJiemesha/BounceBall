<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.levellabel = New System.Windows.Forms.Label()
        Me.startbutton = New System.Windows.Forms.Button()
        Me.updownnya = New System.Windows.Forms.NumericUpDown()
        CType(Me.updownnya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'levellabel
        '
        Me.levellabel.AutoSize = True
        Me.levellabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.levellabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.levellabel.Location = New System.Drawing.Point(121, 54)
        Me.levellabel.Name = "levellabel"
        Me.levellabel.Size = New System.Drawing.Size(42, 17)
        Me.levellabel.TabIndex = 0
        Me.levellabel.Text = "Level"
        '
        'startbutton
        '
        Me.startbutton.Location = New System.Drawing.Point(145, 82)
        Me.startbutton.Name = "startbutton"
        Me.startbutton.Size = New System.Drawing.Size(75, 23)
        Me.startbutton.TabIndex = 2
        Me.startbutton.Text = "Start!"
        Me.startbutton.UseVisualStyleBackColor = True
        '
        'updownnya
        '
        Me.updownnya.BackColor = System.Drawing.SystemColors.WindowText
        Me.updownnya.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.updownnya.Location = New System.Drawing.Point(170, 54)
        Me.updownnya.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.updownnya.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updownnya.Name = "updownnya"
        Me.updownnya.Size = New System.Drawing.Size(120, 22)
        Me.updownnya.TabIndex = 3
        Me.updownnya.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(396, 225)
        Me.Controls.Add(Me.updownnya)
        Me.Controls.Add(Me.startbutton)
        Me.Controls.Add(Me.levellabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.updownnya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents levellabel As Label
    Friend WithEvents startbutton As Button
    Friend WithEvents updownnya As NumericUpDown
End Class
