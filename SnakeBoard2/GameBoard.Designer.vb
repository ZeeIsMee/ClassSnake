<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameBoard
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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.pctSnake = New System.Windows.Forms.PictureBox()
        Me.lblcount = New System.Windows.Forms.Label()
        CType(Me.pctSnake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblScore.Location = New System.Drawing.Point(228, 13)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(69, 30)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "Score:"
        '
        'pctSnake
        '
        Me.pctSnake.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pctSnake.Location = New System.Drawing.Point(348, 218)
        Me.pctSnake.Name = "pctSnake"
        Me.pctSnake.Size = New System.Drawing.Size(13, 13)
        Me.pctSnake.TabIndex = 0
        Me.pctSnake.TabStop = False
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblcount.Location = New System.Drawing.Point(303, 13)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(24, 30)
        Me.lblcount.TabIndex = 3
        Me.lblcount.Text = "0"
        '
        'GameBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.pctSnake)
        Me.Controls.Add(Me.lblScore)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.Name = "GameBoard"
        Me.Text = "GameBoard"
        Me.TopMost = True
        CType(Me.pctSnake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents pctSnake As PictureBox
    Friend WithEvents lblcount As Label
End Class
