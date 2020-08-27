<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport21 = New NaiveBayes.CrystalReport2()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox16)
        Me.Panel1.Controls.Add(Me.PictureBox15)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 189)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Location = New System.Drawing.Point(1121, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(231, 29)
        Me.Panel2.TabIndex = 104
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.Gray
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.ComboBox1.Location = New System.Drawing.Point(5, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(220, 25)
        Me.ComboBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(937, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 19)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Lihat data berdasarkan"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1173, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 19)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Username"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.NaiveBayes.My.Resources.Resources.UName
        Me.PictureBox2.Location = New System.Drawing.Point(1121, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(245, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 101
        Me.PictureBox2.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.Image = Global.NaiveBayes.My.Resources.Resources.LDTR
        Me.PictureBox16.Location = New System.Drawing.Point(486, 83)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(162, 41)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 100
        Me.PictureBox16.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.Image = Global.NaiveBayes.My.Resources.Resources.LDTS1
        Me.PictureBox15.Location = New System.Drawing.Point(648, 83)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(184, 41)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 99
        Me.PictureBox15.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.NaiveBayes.My.Resources.Resources.Training1
        Me.PictureBox5.Location = New System.Drawing.Point(0, 83)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(162, 41)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 98
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.NaiveBayes.My.Resources.Resources.Testing2
        Me.PictureBox4.Location = New System.Drawing.Point(162, 83)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(162, 41)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 97
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.NaiveBayes.My.Resources.Resources.Diagram
        Me.PictureBox3.Location = New System.Drawing.Point(324, 83)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(162, 41)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 96
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.NaiveBayes.My.Resources.Resources.Bar
        Me.PictureBox1.Location = New System.Drawing.Point(0, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1366, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox11)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 675)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1366, 93)
        Me.Panel3.TabIndex = 4
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = Global.NaiveBayes.My.Resources.Resources.Print
        Me.PictureBox11.Location = New System.Drawing.Point(660, 23)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(46, 47)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 91
        Me.PictureBox11.TabStop = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 189)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport21
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1366, 486)
        Me.CrystalReportViewer1.TabIndex = 6
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport21 As NaiveBayes.CrystalReport2
End Class
