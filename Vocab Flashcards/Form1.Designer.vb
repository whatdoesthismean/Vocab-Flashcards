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
        Me.grpNihongo = New System.Windows.Forms.GroupBox()
        Me.lblKana = New System.Windows.Forms.Label()
        Me.grpEng = New System.Windows.Forms.GroupBox()
        Me.lblEng = New System.Windows.Forms.Label()
        Me.picStart = New System.Windows.Forms.PictureBox()
        Me.btnFlip = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rdoNihongo = New System.Windows.Forms.RadioButton()
        Me.rdoEnglish = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoVerbs = New System.Windows.Forms.RadioButton()
        Me.rdoAdj = New System.Windows.Forms.RadioButton()
        Me.rdoNouns = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoRandom = New System.Windows.Forms.RadioButton()
        Me.rdoOrdered = New System.Windows.Forms.RadioButton()
        Me.lstNihongo = New System.Windows.Forms.ListBox()
        Me.lstEng = New System.Windows.Forms.ListBox()
        Me.lstRand = New System.Windows.Forms.ListBox()
        Me.grpNihongo.SuspendLayout()
        Me.grpEng.SuspendLayout()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpNihongo
        '
        Me.grpNihongo.BackColor = System.Drawing.Color.White
        Me.grpNihongo.Controls.Add(Me.lblKana)
        Me.grpNihongo.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpNihongo.Location = New System.Drawing.Point(187, 12)
        Me.grpNihongo.Name = "grpNihongo"
        Me.grpNihongo.Size = New System.Drawing.Size(1146, 285)
        Me.grpNihongo.TabIndex = 2
        Me.grpNihongo.TabStop = False
        Me.grpNihongo.Text = "日本語"
        Me.ToolTip1.SetToolTip(Me.grpNihongo, "にほんご - Japanese Translation")
        Me.grpNihongo.Visible = False
        '
        'lblKana
        '
        Me.lblKana.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblKana.Font = New System.Drawing.Font("MingLiU-ExtB", 51.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblKana.Location = New System.Drawing.Point(6, 125)
        Me.lblKana.Name = "lblKana"
        Me.lblKana.Size = New System.Drawing.Size(1134, 64)
        Me.lblKana.TabIndex = 0
        Me.lblKana.Text = "かわいい"
        Me.lblKana.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblKana.Visible = False
        '
        'grpEng
        '
        Me.grpEng.BackColor = System.Drawing.Color.White
        Me.grpEng.Controls.Add(Me.lblEng)
        Me.grpEng.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpEng.Location = New System.Drawing.Point(187, 312)
        Me.grpEng.Name = "grpEng"
        Me.grpEng.Size = New System.Drawing.Size(1146, 285)
        Me.grpEng.TabIndex = 3
        Me.grpEng.TabStop = False
        Me.grpEng.Text = "英語"
        Me.ToolTip1.SetToolTip(Me.grpEng, "えいご - English Translation")
        Me.grpEng.Visible = False
        '
        'lblEng
        '
        Me.lblEng.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEng.Font = New System.Drawing.Font("MingLiU-ExtB", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEng.Location = New System.Drawing.Point(6, 125)
        Me.lblEng.Name = "lblEng"
        Me.lblEng.Size = New System.Drawing.Size(1134, 64)
        Me.lblEng.TabIndex = 1
        Me.lblEng.Text = "cute"
        Me.lblEng.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblEng.Visible = False
        '
        'picStart
        '
        Me.picStart.BackColor = System.Drawing.Color.Transparent
        Me.picStart.Image = Global.Vocab_Flashcards.My.Resources.Resources.click_to_start
        Me.picStart.Location = New System.Drawing.Point(173, 335)
        Me.picStart.Name = "picStart"
        Me.picStart.Size = New System.Drawing.Size(291, 232)
        Me.picStart.TabIndex = 14
        Me.picStart.TabStop = False
        '
        'btnFlip
        '
        Me.btnFlip.AutoSize = True
        Me.btnFlip.BackColor = System.Drawing.Color.LightYellow
        Me.btnFlip.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFlip.Location = New System.Drawing.Point(557, 607)
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(408, 62)
        Me.btnFlip.TabIndex = 2
        Me.btnFlip.Text = "フリップ"
        Me.ToolTip1.SetToolTip(Me.btnFlip, "Flip the Card")
        Me.btnFlip.UseVisualStyleBackColor = False
        Me.btnFlip.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.AliceBlue
        Me.btnNext.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(187, 607)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(157, 55)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "次のカード"
        Me.ToolTip1.SetToolTip(Me.btnNext, "つぎにカード - Next Card")
        Me.btnNext.UseVisualStyleBackColor = False
        Me.btnNext.Visible = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPrev.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPrev.Location = New System.Drawing.Point(1176, 607)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(157, 55)
        Me.btnPrev.TabIndex = 5
        Me.btnPrev.Text = "前のカード"
        Me.ToolTip1.SetToolTip(Me.btnPrev, "まえのカード - Previous Card")
        Me.btnPrev.UseVisualStyleBackColor = False
        Me.btnPrev.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAdd.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(12, 481)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(157, 55)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "新しいカード"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "あたらしいカード - Add New Cards")
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
        Me.btnExit.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(12, 542)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 55)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "閉じる"
        Me.ToolTip1.SetToolTip(Me.btnExit, "とじる - Close Program")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'rdoNihongo
        '
        Me.rdoNihongo.AutoSize = True
        Me.rdoNihongo.Checked = True
        Me.rdoNihongo.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdoNihongo.Location = New System.Drawing.Point(6, 24)
        Me.rdoNihongo.Name = "rdoNihongo"
        Me.rdoNihongo.Size = New System.Drawing.Size(116, 42)
        Me.rdoNihongo.TabIndex = 8
        Me.rdoNihongo.TabStop = True
        Me.rdoNihongo.Text = "日本語"
        Me.ToolTip1.SetToolTip(Me.rdoNihongo, "Show Japanese First")
        Me.rdoNihongo.UseVisualStyleBackColor = True
        '
        'rdoEnglish
        '
        Me.rdoEnglish.AutoSize = True
        Me.rdoEnglish.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdoEnglish.Location = New System.Drawing.Point(6, 68)
        Me.rdoEnglish.Name = "rdoEnglish"
        Me.rdoEnglish.Size = New System.Drawing.Size(89, 42)
        Me.rdoEnglish.TabIndex = 9
        Me.rdoEnglish.Text = "英語"
        Me.ToolTip1.SetToolTip(Me.rdoEnglish, "Show English First")
        Me.rdoEnglish.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoNihongo)
        Me.GroupBox3.Controls.Add(Me.rdoEnglish)
        Me.GroupBox3.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(157, 122)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "テスト"
        Me.ToolTip1.SetToolTip(Me.GroupBox3, "Choose Test Type")
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.PaleGreen
        Me.btnStart.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.Location = New System.Drawing.Point(12, 420)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(157, 55)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "スタート"
        Me.ToolTip1.SetToolTip(Me.btnStart, "Start / Restart Test")
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoVerbs)
        Me.GroupBox1.Controls.Add(Me.rdoAdj)
        Me.GroupBox1.Controls.Add(Me.rdoNouns)
        Me.GroupBox1.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 144)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "オプション"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Choose Test Option")
        '
        'rdoVerbs
        '
        Me.rdoVerbs.AutoSize = True
        Me.rdoVerbs.Location = New System.Drawing.Point(6, 101)
        Me.rdoVerbs.Name = "rdoVerbs"
        Me.rdoVerbs.Size = New System.Drawing.Size(74, 26)
        Me.rdoVerbs.TabIndex = 10
        Me.rdoVerbs.Text = "Verbs"
        Me.ToolTip1.SetToolTip(Me.rdoVerbs, "Test Verbs")
        Me.rdoVerbs.UseVisualStyleBackColor = True
        '
        'rdoAdj
        '
        Me.rdoAdj.AutoSize = True
        Me.rdoAdj.Checked = True
        Me.rdoAdj.Location = New System.Drawing.Point(6, 31)
        Me.rdoAdj.Name = "rdoAdj"
        Me.rdoAdj.Size = New System.Drawing.Size(114, 26)
        Me.rdoAdj.TabIndex = 8
        Me.rdoAdj.TabStop = True
        Me.rdoAdj.Text = "Adjectives"
        Me.ToolTip1.SetToolTip(Me.rdoAdj, "Test Adjectives")
        Me.rdoAdj.UseVisualStyleBackColor = True
        '
        'rdoNouns
        '
        Me.rdoNouns.AutoSize = True
        Me.rdoNouns.Location = New System.Drawing.Point(6, 65)
        Me.rdoNouns.Name = "rdoNouns"
        Me.rdoNouns.Size = New System.Drawing.Size(79, 26)
        Me.rdoNouns.TabIndex = 9
        Me.rdoNouns.Text = "Nouns"
        Me.ToolTip1.SetToolTip(Me.rdoNouns, "Test Nouns")
        Me.rdoNouns.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoRandom)
        Me.GroupBox2.Controls.Add(Me.rdoOrdered)
        Me.GroupBox2.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 306)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 100)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "順序"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "じゅんじょ  - Select Card Sequence")
        '
        'rdoRandom
        '
        Me.rdoRandom.AutoSize = True
        Me.rdoRandom.Location = New System.Drawing.Point(6, 62)
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.Size = New System.Drawing.Size(97, 26)
        Me.rdoRandom.TabIndex = 1
        Me.rdoRandom.Text = "Random"
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoOrdered
        '
        Me.rdoOrdered.AutoSize = True
        Me.rdoOrdered.Checked = True
        Me.rdoOrdered.Location = New System.Drawing.Point(7, 30)
        Me.rdoOrdered.Name = "rdoOrdered"
        Me.rdoOrdered.Size = New System.Drawing.Size(97, 26)
        Me.rdoOrdered.TabIndex = 0
        Me.rdoOrdered.TabStop = True
        Me.rdoOrdered.Text = "Ordered"
        Me.rdoOrdered.UseVisualStyleBackColor = True
        '
        'lstNihongo
        '
        Me.lstNihongo.FormattingEnabled = True
        Me.lstNihongo.ItemHeight = 15
        Me.lstNihongo.Location = New System.Drawing.Point(12, 675)
        Me.lstNihongo.Name = "lstNihongo"
        Me.lstNihongo.Size = New System.Drawing.Size(238, 649)
        Me.lstNihongo.TabIndex = 11
        '
        'lstEng
        '
        Me.lstEng.FormattingEnabled = True
        Me.lstEng.ItemHeight = 15
        Me.lstEng.Location = New System.Drawing.Point(273, 675)
        Me.lstEng.Name = "lstEng"
        Me.lstEng.Size = New System.Drawing.Size(238, 649)
        Me.lstEng.TabIndex = 12
        '
        'lstRand
        '
        Me.lstRand.FormattingEnabled = True
        Me.lstRand.ItemHeight = 15
        Me.lstRand.Location = New System.Drawing.Point(1016, 664)
        Me.lstRand.Name = "lstRand"
        Me.lstRand.Size = New System.Drawing.Size(120, 94)
        Me.lstRand.TabIndex = 15
        Me.lstRand.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vocab_Flashcards.My.Resources.Resources.japanesepattern02
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 674)
        Me.Controls.Add(Me.lstRand)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lstEng)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lstNihongo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFlip)
        Me.Controls.Add(Me.grpEng)
        Me.Controls.Add(Me.grpNihongo)
        Me.Controls.Add(Me.picStart)
        Me.Name = "Form1"
        Me.Text = "単語帳 - たんごちょう"
        Me.ToolTip1.SetToolTip(Me, "Flashcard Set")
        Me.grpNihongo.ResumeLayout(False)
        Me.grpEng.ResumeLayout(False)
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpNihongo As GroupBox
    Friend WithEvents lblKana As Label
    Friend WithEvents grpEng As GroupBox
    Friend WithEvents btnFlip As Button
    Friend WithEvents lblEng As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents rdoNihongo As RadioButton
    Friend WithEvents rdoEnglish As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnStart As Button
    Friend WithEvents lstNihongo As ListBox
    Friend WithEvents lstEng As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoVerbs As RadioButton
    Friend WithEvents rdoAdj As RadioButton
    Friend WithEvents rdoNouns As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoRandom As RadioButton
    Friend WithEvents rdoOrdered As RadioButton
    Friend WithEvents picStart As PictureBox
    Friend WithEvents lstRand As ListBox
End Class
