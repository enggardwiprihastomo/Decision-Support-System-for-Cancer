<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1173, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Username"
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.BorderWidth = 0
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.Gray
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleFont = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(376, 154)
        Me.Chart2.Name = "Chart2"
        Series1.BorderWidth = 0
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Series1.IsValueShownAsLabel = True
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(735, 487)
        Me.Chart2.TabIndex = 89
        Me.Chart2.Text = "Chart2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 24.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(738, 644)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 39)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "0000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 24.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(522, 644)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 39)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "TOTAL DATA :"
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.Image = Global.NaiveBayes.My.Resources.Resources.LDTR2
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
        Me.PictureBox15.Image = Global.NaiveBayes.My.Resources.Resources.LDTS
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
        Me.PictureBox3.Image = Global.NaiveBayes.My.Resources.Resources.Diagram1
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
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = Global.NaiveBayes.My.Resources.Resources._Exit
        Me.PictureBox11.Location = New System.Drawing.Point(1269, 702)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(40, 42)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 88
        Me.PictureBox11.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.NaiveBayes.My.Resources.Resources.UName
        Me.PictureBox2.Location = New System.Drawing.Point(1121, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(245, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
