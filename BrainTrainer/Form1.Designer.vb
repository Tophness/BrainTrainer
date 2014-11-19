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
        Me.components = New System.ComponentModel.Container
        Me.bottomimg = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.topimg = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.bottomimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bottomimg
        '
        Me.bottomimg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bottomimg.Location = New System.Drawing.Point(0, 0)
        Me.bottomimg.Name = "bottomimg"
        Me.bottomimg.Size = New System.Drawing.Size(504, 462)
        Me.bottomimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bottomimg.TabIndex = 0
        Me.bottomimg.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Begin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'topimg
        '
        Me.topimg.Location = New System.Drawing.Point(147, 282)
        Me.topimg.Name = "topimg"
        Me.topimg.Size = New System.Drawing.Size(196, 168)
        Me.topimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.topimg.TabIndex = 3
        Me.topimg.TabStop = False
        Me.topimg.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 110)
        Me.Label1.TabIndex = 4
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Visible = False
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 462)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.topimg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bottomimg)
        Me.Name = "Form1"
        Me.Text = "Subconscious Trainer"
        CType(Me.bottomimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bottomimg As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents topimg As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

End Class
