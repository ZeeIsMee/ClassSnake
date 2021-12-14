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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadExtreme = New System.Windows.Forms.RadioButton()
        Me.RadHard = New System.Windows.Forms.RadioButton()
        Me.RadMedium = New System.Windows.Forms.RadioButton()
        Me.RadEasy = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(150, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SNAKE!"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Gainsboro
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.Location = New System.Drawing.Point(200, 183)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(200, 238)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
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
        Me.GroupBox1.Location = New System.Drawing.Point(308, 183)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox1.Size = New System.Drawing.Size(131, 95)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Difficulty"
        '
        'RadExtreme
        '
        Me.RadExtreme.AutoSize = True
        Me.RadExtreme.Location = New System.Drawing.Point(2, 73)
        Me.RadExtreme.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.RadExtreme.Name = "RadExtreme"
        Me.RadExtreme.Size = New System.Drawing.Size(68, 19)
        Me.RadExtreme.TabIndex = 3
        Me.RadExtreme.TabStop = True
        Me.RadExtreme.Text = "Extreme"
        Me.RadExtreme.UseVisualStyleBackColor = True
        '
        'RadHard
        '
        Me.RadHard.AutoSize = True
        Me.RadHard.Location = New System.Drawing.Point(2, 55)
        Me.RadHard.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.RadHard.Name = "RadHard"
        Me.RadHard.Size = New System.Drawing.Size(51, 19)
        Me.RadHard.TabIndex = 2
        Me.RadHard.TabStop = True
        Me.RadHard.Text = "Hard"
        Me.RadHard.UseVisualStyleBackColor = True
        '
        'RadMedium
        '
        Me.RadMedium.AutoSize = True
        Me.RadMedium.Location = New System.Drawing.Point(2, 36)
        Me.RadMedium.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.RadMedium.Name = "RadMedium"
        Me.RadMedium.Size = New System.Drawing.Size(70, 19)
        Me.RadMedium.TabIndex = 1
        Me.RadMedium.TabStop = True
        Me.RadMedium.Text = "Medium"
        Me.RadMedium.UseVisualStyleBackColor = True
        '
        'RadEasy
        '
        Me.RadEasy.AutoSize = True
        Me.RadEasy.Location = New System.Drawing.Point(2, 18)
        Me.RadEasy.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.RadEasy.Name = "RadEasy"
        Me.RadEasy.Size = New System.Drawing.Size(48, 19)
        Me.RadEasy.TabIndex = 0
        Me.RadEasy.TabStop = True
        Me.RadEasy.Text = "Easy"
        Me.RadEasy.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 200)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(498, 415)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartMenu"
        Me.Text = "SNAKE!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
