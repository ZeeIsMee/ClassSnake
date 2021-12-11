<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameBoard
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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.pctSnake = New System.Windows.Forms.PictureBox()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picborderright = New System.Windows.Forms.PictureBox()
        Me.picborderbottom = New System.Windows.Forms.PictureBox()
        Me.picbordertop = New System.Windows.Forms.PictureBox()
        Me.picborderleft = New System.Windows.Forms.PictureBox()
        CType(Me.pctSnake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picborderright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picborderbottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbordertop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picborderleft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblScore.Location = New System.Drawing.Point(617, 75)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(69, 30)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "Score:"
        '
        'pctSnake
        '
        Me.pctSnake.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pctSnake.Location = New System.Drawing.Point(262, 118)
        Me.pctSnake.Name = "pctSnake"
        Me.pctSnake.Size = New System.Drawing.Size(13, 13)
        Me.pctSnake.TabIndex = 0
        Me.pctSnake.TabStop = False
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.BackColor = System.Drawing.Color.Transparent
        Me.lblcount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblcount.Location = New System.Drawing.Point(692, 75)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(24, 30)
        Me.lblcount.TabIndex = 3
        Me.lblcount.Text = "0"
        '
        'picborderright
        '
        Me.picborderright.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.picborderright.Location = New System.Drawing.Point(565, 24)
        Me.picborderright.Margin = New System.Windows.Forms.Padding(2)
        Me.picborderright.Name = "picborderright"
        Me.picborderright.Size = New System.Drawing.Size(15, 342)
        Me.picborderright.TabIndex = 5
        Me.picborderright.TabStop = False
        '
        'picborderbottom
        '
        Me.picborderbottom.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.picborderbottom.Location = New System.Drawing.Point(28, 363)
        Me.picborderbottom.Margin = New System.Windows.Forms.Padding(2)
        Me.picborderbottom.Name = "picborderbottom"
        Me.picborderbottom.Size = New System.Drawing.Size(552, 14)
        Me.picborderbottom.TabIndex = 6
        Me.picborderbottom.TabStop = False
        '
        'picbordertop
        '
        Me.picbordertop.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.picbordertop.Location = New System.Drawing.Point(28, 14)
        Me.picbordertop.Margin = New System.Windows.Forms.Padding(2)
        Me.picbordertop.Name = "picbordertop"
        Me.picbordertop.Size = New System.Drawing.Size(552, 14)
        Me.picbordertop.TabIndex = 7
        Me.picbordertop.TabStop = False
        '
        'picborderleft
        '
        Me.picborderleft.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.picborderleft.Location = New System.Drawing.Point(16, 14)
        Me.picborderleft.Margin = New System.Windows.Forms.Padding(2)
        Me.picborderleft.Name = "picborderleft"
        Me.picborderleft.Size = New System.Drawing.Size(15, 363)
        Me.picborderleft.TabIndex = 8
        Me.picborderleft.TabStop = False
        '
        'GameBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 406)
        Me.Controls.Add(Me.picborderleft)
        Me.Controls.Add(Me.picbordertop)
        Me.Controls.Add(Me.picborderbottom)
        Me.Controls.Add(Me.picborderright)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.pctSnake)
        Me.Controls.Add(Me.lblScore)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.Name = "GameBoard"
        Me.Text = "GameBoard"
        Me.TopMost = True
        CType(Me.pctSnake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picborderright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picborderbottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbordertop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picborderleft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents pctSnake As PictureBox
    Friend WithEvents lblcount As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picborderright As PictureBox
    Friend WithEvents picborderbottom As PictureBox
    Friend WithEvents picbordertop As PictureBox
    Friend WithEvents picborderleft As PictureBox
End Class
