Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form6
    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Image = My.Resources.Training
        PictureBox4.Image = My.Resources.Testing
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = My.Resources.Training1
        PictureBox4.Image = My.Resources.Testing2
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.Testing1
        PictureBox3.Image = My.Resources.Diagram2
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.Testing2
        PictureBox3.Image = My.Resources.Diagram
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.Diagram1
        PictureBox16.Image = My.Resources.LDTR2
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.Diagram
        PictureBox16.Image = My.Resources.LDTR
    End Sub

    Private Sub PictureBox11_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox11.MouseEnter
        PictureBox11.Image = My.Resources.Print1
    End Sub

    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox11.MouseLeave
        PictureBox11.Image = My.Resources.Print
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
        Form4.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Close()
        Form3.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Close()
        Form2.Show()
    End Sub

    Private Sub Form6_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Label1.Text = Form1.username
        ComboBox1.Items.Clear()
        Call Conn()
        DML = Database.CreateCommand
        DML.CommandText = "SELECT kesimpulan FROM data_test GROUP BY kesimpulan"
        Baca = DML.ExecuteReader
        ComboBox1.Items.Add("Semua")
        While Baca.Read
            ComboBox1.Items.Add(Baca.Item("kesimpulan"))
        End While
        Baca.Close()
        CrystalReportViewer1.RefreshReport()
        ComboBox1.Text = ComboBox1.Items.Item(0)
    End Sub
    Sub repeat()
        Dim cryRpt As New ReportDocument
        cryRpt.Load(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) & "\CrystalReport2.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Semua" Then
            Dim cryRpt As New ReportDocument
            cryRpt.Load(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) & "\CrystalReport2.rpt")
            CrystalReportViewer1.ReportSource = cryRpt
            repeat()
        Else
            CrystalReportViewer1.SelectionFormula = "{data_test1.kesimpulan}= '" & ComboBox1.Text & "'"
            CrystalReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Close()
        Form5.Show()
    End Sub

    Private Sub PictureBox16_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox16.MouseEnter
        PictureBox15.Image = My.Resources.LDTS3
        PictureBox16.Image = My.Resources.LDTR1
    End Sub

    Private Sub PictureBox16_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox16.MouseLeave
        PictureBox15.Image = My.Resources.LDTS1
        PictureBox16.Image = My.Resources.LDTR
    End Sub
End Class