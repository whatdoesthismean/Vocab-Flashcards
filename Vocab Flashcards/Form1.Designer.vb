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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblKana = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEng = New System.Windows.Forms.Label()
        Me.btnFlip = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rdoNihongo = New System.Windows.Forms.RadioButton()
        Me.rdoEnglish = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblKana)
        Me.GroupBox1.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 154)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "日本語"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Japanese Translation")
        '
        'lblKana
        '
        Me.lblKana.Font = New System.Drawing.Font("XANO-mincho-U32", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblKana.Location = New System.Drawing.Point(6, 71)
        Me.lblKana.Name = "lblKana"
        Me.lblKana.Size = New System.Drawing.Size(262, 42)
        Me.lblKana.TabIndex = 0
        Me.lblKana.Text = "かわいい"
        Me.lblKana.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblKana.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.lblEng)
        Me.GroupBox2.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(467, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 154)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "英語"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "English Translation")
        '
        'lblEng
        '
        Me.lblEng.Font = New System.Drawing.Font("XANO-mincho-U32", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEng.Location = New System.Drawing.Point(6, 71)
        Me.lblEng.Name = "lblEng"
        Me.lblEng.Size = New System.Drawing.Size(262, 42)
        Me.lblEng.TabIndex = 1
        Me.lblEng.Text = "cute"
        Me.lblEng.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblEng.Visible = False
        '
        'btnFlip
        '
        Me.btnFlip.AutoSize = True
        Me.btnFlip.BackColor = System.Drawing.Color.LightYellow
        Me.btnFlip.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFlip.Location = New System.Drawing.Point(304, 103)
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(157, 55)
        Me.btnFlip.TabIndex = 2
        Me.btnFlip.Text = "フリップ"
        Me.ToolTip1.SetToolTip(Me.btnFlip, "Flip the Card")
        Me.btnFlip.UseVisualStyleBackColor = False
        Me.btnFlip.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightBlue
        Me.btnNext.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(211, 205)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(87, 38)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "次のカード"
        Me.ToolTip1.SetToolTip(Me.btnNext, "Next Card")
        Me.btnNext.UseVisualStyleBackColor = False
        Me.btnNext.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightBlue
        Me.Button2.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(467, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 38)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "前のカード"
        Me.ToolTip1.SetToolTip(Me.Button2, "Previous Card")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAdd.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(336, 179)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 32)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "新しいカード"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add New Cards")
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
        Me.btnExit.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(336, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 32)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "終了"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Close Program")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'rdoNihongo
        '
        Me.rdoNihongo.AutoSize = True
        Me.rdoNihongo.Checked = True
        Me.rdoNihongo.Location = New System.Drawing.Point(6, 24)
        Me.rdoNihongo.Name = "rdoNihongo"
        Me.rdoNihongo.Size = New System.Drawing.Size(76, 26)
        Me.rdoNihongo.TabIndex = 8
        Me.rdoNihongo.TabStop = True
        Me.rdoNihongo.Text = "日本語"
        Me.ToolTip1.SetToolTip(Me.rdoNihongo, "Show Japanese First")
        Me.rdoNihongo.UseVisualStyleBackColor = True
        '
        'rdoEnglish
        '
        Me.rdoEnglish.AutoSize = True
        Me.rdoEnglish.Location = New System.Drawing.Point(6, 48)
        Me.rdoEnglish.Name = "rdoEnglish"
        Me.rdoEnglish.Size = New System.Drawing.Size(60, 26)
        Me.rdoEnglish.TabIndex = 9
        Me.rdoEnglish.Text = "英語"
        Me.ToolTip1.SetToolTip(Me.rdoEnglish, "Show English First")
        Me.rdoEnglish.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnStart)
        Me.GroupBox3.Controls.Add(Me.rdoNihongo)
        Me.GroupBox3.Controls.Add(Me.rdoEnglish)
        Me.GroupBox3.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(304, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(157, 80)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "テスト"
        Me.ToolTip1.SetToolTip(Me.GroupBox3, "Choose Test Type")
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.MistyRose
        Me.btnStart.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.Location = New System.Drawing.Point(88, 42)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(63, 32)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "スタート"
        Me.ToolTip1.SetToolTip(Me.btnStart, "Start / Restart Test")
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vocab_Flashcards.My.Resources.Resources.japanesepattern02
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(764, 270)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFlip)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "単語帳 ・ ボキャブラリー ・ フラッシュカード"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblKana As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnFlip As Button
    Friend WithEvents lblEng As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnNext As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents rdoNihongo As RadioButton
    Friend WithEvents rdoEnglish As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnStart As Button
End Class
