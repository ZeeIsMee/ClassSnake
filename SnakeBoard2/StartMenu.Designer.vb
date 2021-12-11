<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadExtreme = New System.Windows.Forms.RadioButton()
        Me.RadHard = New System.Windows.Forms.RadioButton()
        Me.RadMedium = New System.Windows.Forms.RadioButton()
        Me.RadEasy = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(214, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 96)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SNAKE!"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(286, 262)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(107, 38)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(286, 360)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 38)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadExtreme)
        Me.GroupBox1.Controls.Add(Me.RadHard)
        Me.GroupBox1.Controls.Add(Me.RadMedium)
        Me.GroupBox1.Controls.Add(Me.RadEasy)
        Me.GroupBox1.Location = New System.Drawing.Point(429, 248)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(187, 158)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Difficulty"
        '
        'RadExtreme
        '
        Me.RadExtreme.AutoSize = True
        Me.RadExtreme.Location = New System.Drawing.Point(3, 122)
        Me.RadExtreme.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.RadExtreme.Name = "RadExtreme"
        Me.RadExtreme.Size = New System.Drawing.Size(100, 29)
        Me.RadExtreme.TabIndex = 3
        Me.RadExtreme.TabStop = True
        Me.RadExtreme.Text = "Extreme"
        Me.RadExtreme.UseVisualStyleBackColor = True
        '
        'RadHard
        '
        Me.RadHard.AutoSize = True
        Me.RadHard.Location = New System.Drawing.Point(3, 92)
        Me.RadHard.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.RadHard.Name = "RadHard"
        Me.RadHard.Size = New System.Drawing.Size(76, 29)
        Me.RadHard.TabIndex = 2
        Me.RadHard.TabStop = True
        Me.RadHard.Text = "Hard"
        Me.RadHard.UseVisualStyleBackColor = True
        '
        'RadMedium
        '
        Me.RadMedium.AutoSize = True
        Me.RadMedium.Location = New System.Drawing.Point(3, 60)
        Me.RadMedium.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.RadMedium.Name = "RadMedium"
        Me.RadMedium.Size = New System.Drawing.Size(103, 29)
        Me.RadMedium.TabIndex = 1
        Me.RadMedium.TabStop = True
        Me.RadMedium.Text = "Medium"
        Me.RadMedium.UseVisualStyleBackColor = True
        '
        'RadEasy
        '
        Me.RadEasy.AutoSize = True
        Me.RadEasy.Location = New System.Drawing.Point(3, 30)
        Me.RadEasy.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.RadEasy.Name = "RadEasy"
        Me.RadEasy.Size = New System.Drawing.Size(72, 29)
        Me.RadEasy.TabIndex = 0
        Me.RadEasy.TabStop = True
        Me.RadEasy.Text = "Easy"
        Me.RadEasy.UseVisualStyleBackColor = True
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 692)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StartMenu"
        Me.Text = "SNAKE!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadHard As RadioButton
    Friend WithEvents RadMedium As RadioButton
    Friend WithEvents RadEasy As RadioButton
    Friend WithEvents RadExtreme As RadioButton
End Class
