<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKanaNew = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEngNew = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEngPlease = New System.Windows.Forms.Label()
        Me.lblNihongoPlease = New System.Windows.Forms.Label()
        Me.lblSaved = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox1.Controls.Add(Me.txtKanaNew)
        Me.GroupBox1.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.GroupBox1.Location = New System.Drawing.Point(9, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 154)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "日本語"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "にほんご - Add A Japanese Translation")
        '
        'txtKanaNew
        '
        Me.txtKanaNew.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtKanaNew.Location = New System.Drawing.Point(6, 61)
        Me.txtKanaNew.Name = "txtKanaNew"
        Me.txtKanaNew.Size = New System.Drawing.Size(262, 52)
        Me.txtKanaNew.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtKanaNew, "Add A Japanese Translation")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox2.Controls.Add(Me.txtEngNew)
        Me.GroupBox2.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 154)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "英語"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "えいご - Add An English Translation")
        '
        'txtEngNew
        '
        Me.txtEngNew.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtEngNew.Location = New System.Drawing.Point(6, 61)
        Me.txtEngNew.Name = "txtEngNew"
        Me.txtEngNew.Size = New System.Drawing.Size(262, 52)
        Me.txtEngNew.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtEngNew, "Add An Enlgish Translation")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(50, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 52)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "新しいカード"
        '
        'btnAddNew
        '
        Me.btnAddNew.AutoSize = True
        Me.btnAddNew.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAddNew.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddNew.Location = New System.Drawing.Point(34, 567)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(225, 48)
        Me.btnAddNew.TabIndex = 7
        Me.btnAddNew.Text = "新しいカードを追加"
        Me.ToolTip1.SetToolTip(Me.btnAddNew, "あたらしいカードをついか - Add New Card")
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.AutoSize = True
        Me.btnReturn.BackColor = System.Drawing.Color.LightCoral
        Me.btnReturn.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReturn.Location = New System.Drawing.Point(97, 625)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(98, 48)
        Me.btnReturn.TabIndex = 8
        Me.btnReturn.Text = "戻る"
        Me.ToolTip1.SetToolTip(Me.btnReturn, "もどる - Return to Test")
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblEngPlease
        '
        Me.lblEngPlease.BackColor = System.Drawing.Color.MistyRose
        Me.lblEngPlease.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEngPlease.Location = New System.Drawing.Point(21, 499)
        Me.lblEngPlease.Name = "lblEngPlease"
        Me.lblEngPlease.Size = New System.Drawing.Size(250, 55)
        Me.lblEngPlease.TabIndex = 9
        Me.lblEngPlease.Text = "Please Add An English Translation"
        Me.lblEngPlease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEngPlease.Visible = False
        '
        'lblNihongoPlease
        '
        Me.lblNihongoPlease.BackColor = System.Drawing.Color.Thistle
        Me.lblNihongoPlease.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNihongoPlease.Location = New System.Drawing.Point(21, 428)
        Me.lblNihongoPlease.Name = "lblNihongoPlease"
        Me.lblNihongoPlease.Size = New System.Drawing.Size(250, 55)
        Me.lblNihongoPlease.TabIndex = 10
        Me.lblNihongoPlease.Text = "Please Add A Japanese Translation"
        Me.lblNihongoPlease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNihongoPlease.Visible = False
        '
        'lblSaved
        '
        Me.lblSaved.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblSaved.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaved.Location = New System.Drawing.Point(21, 465)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(250, 55)
        Me.lblSaved.TabIndex = 11
        Me.lblSaved.Text = "New Card Saved"
        Me.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSaved.Visible = False
        '
        'lblType
        '
        Me.lblType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblType.Font = New System.Drawing.Font("Corporate Logo Rounded ver2 Bd", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblType.Location = New System.Drawing.Point(9, 54)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(274, 27)
        Me.lblType.TabIndex = 12
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(293, 686)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblNihongoPlease)
        Me.Controls.Add(Me.lblEngPlease)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "単語帳 - たんごちょう"
        Me.ToolTip1.SetToolTip(Me, "Add Flashcard(s)")
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKanaNew As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEngNew As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddNew As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblEngPlease As Label
    Friend WithEvents lblNihongoPlease As Label
    Friend WithEvents lblSaved As Label
    Friend WithEvents lblType As Label
End Class

