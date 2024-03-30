<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class level1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(level1))
        Me.back = New System.Windows.Forms.PictureBox()
        Me.playerChar = New System.Windows.Forms.PictureBox()
        Me.moveTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerChar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.Location = New System.Drawing.Point(12, 24)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(1160, 625)
        Me.back.TabIndex = 0
        Me.back.TabStop = False
        '
        'playerChar
        '
        Me.playerChar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.playerChar.Image = CType(resources.GetObject("playerChar.Image"), System.Drawing.Image)
        Me.playerChar.Location = New System.Drawing.Point(544, 519)
        Me.playerChar.Name = "playerChar"
        Me.playerChar.Size = New System.Drawing.Size(100, 120)
        Me.playerChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerChar.TabIndex = 1
        Me.playerChar.TabStop = False
        '
        'moveTimer
        '
        Me.moveTimer.Interval = 1
        '
        'level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.playerChar)
        Me.Controls.Add(Me.back)
        Me.Name = "level1"
        Me.Text = "level1"
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerChar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents back As PictureBox
    Friend WithEvents playerChar As PictureBox
    Friend WithEvents moveTimer As Timer
End Class
