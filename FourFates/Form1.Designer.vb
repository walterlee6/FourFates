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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnHow = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Liberation Mono", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStart.Location = New System.Drawing.Point(12, 237)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(382, 86)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnHow
        '
        Me.btnHow.BackColor = System.Drawing.Color.Transparent
        Me.btnHow.FlatAppearance.BorderSize = 0
        Me.btnHow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHow.Font = New System.Drawing.Font("Liberation Mono", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHow.Location = New System.Drawing.Point(12, 329)
        Me.btnHow.Name = "btnHow"
        Me.btnHow.Size = New System.Drawing.Size(382, 86)
        Me.btnHow.TabIndex = 1
        Me.btnHow.Text = "How To Play"
        Me.btnHow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHow.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Liberation Mono", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(12, 421)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(382, 86)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(-5, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 126)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(837, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 88)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnHow)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnHow As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
