Imports System.Math
Public Class Form4

    Private TotalData As Integer
    Private Sub Form4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label1.Text = Form1.username
        Dim i As Integer
        i = 0
        Call Conn()
        DML = Database.CreateCommand
        DML.CommandText = "SELECT COUNT(*) AS TOTALDATA FROM data_latih"
        Baca = DML.ExecuteReader
        Baca.Read()
        TotalData = Baca.Item("TOTALDATA")
        Baca.Close()
        DML = Database.CreateCommand
        DML.CommandText = "SELECT COUNT(*) AS TOTALGRUP FROM (SELECT count(*) FROM data_latih GROUP BY kesimpulan) AS TGRUP"
        Baca = DML.ExecuteReader
        Baca.Read()
        Dim Jumlah(Baca.Item("TOTALGRUP")) As Integer
        Dim Jenis(Baca.Item("TOTALGRUP")) As String
        Baca.Close()
        i = 0
        Call Conn()
        DML = Database.CreateCommand
        DML.CommandText = "SELECT count(kesimpulan) AS JKESIMPULAN FROM data_latih GROUP BY kesimpulan"
        Baca = DML.ExecuteReader
        While Baca.Read()
            Jumlah(i) = Baca.Item("JKESIMPULAN")
            i = i + 1
        End While
        Baca.Close()
        i = 0
        Call Conn()
        DML = Database.CreateCommand
        DML.CommandText = "SELECT kesimpulan FROM data_latih GROUP BY kesimpulan"
        Baca = DML.ExecuteReader
        While Baca.Read()
            Jenis(i) = Baca.Item("kesimpulan") & "(" & AngkaDesimal((Jumlah(i) / TotalData) * 100, 2) & "%)"
            i = i + 1
        End While
        Baca.Close()
        Chart2.Series("Series1").Points.DataBindXY(Jenis, Jumlah)
        Label2.Text = TotalData.ToString
    End Sub
    Function AngkaDesimal(Nilai As Double, Digit As Integer) As Double
        If Digit < 0 Then
            MessageBox.Show("You must input positive decimal digit value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Else
            Dim ConvS As String = Nilai.ToString
            Dim TempS1, TempS2, TempS3 As String
            Dim TempI As Integer = 0
            For i = 0 To ConvS.Length - 1
                If ConvS(i) = "." Then
                    If Digit = 0 Then
                        For j = 0 To i + Digit - 2
                            TempS1 = TempS1 + ConvS(j)
                        Next
                        TempS2 = ConvS(i + Digit + 1)
                        TempS3 = ConvS(i + Digit - 1)
                        If Int(TempS2) > 5 Then
                            TempI = Int(TempS3) + 1
                        Else
                            TempI = Int(TempS3)
                        End If
                        TempS1 = TempS1 + TempI.ToString
                        Nilai = Convert.ToDouble(TempS1)
                    Else
                        If ConvS.Length - 1 - i > Digit Then
                            For j = 0 To i + Digit - 1
                                TempS1 = TempS1 + ConvS(j)
                            Next
                            TempS2 = ConvS(i + Digit + 1)
                            TempS3 = ConvS(i + Digit)
                            If Int(TempS2) > 5 Then
                                TempI = Int(TempS3) + 1
                            Else
                                TempI = Int(TempS3)
                            End If
                            TempS1 = TempS1 + TempI.ToString
                            Nilai = Convert.ToDouble(TempS1)
                        Else
                            For j = 0 To ConvS.Length - 1
                                TempS1 = TempS1 + ConvS(j)
                            Next
                            Nilai = Convert.ToDouble(TempS1)
                        End If
                    End If
                End If
            Next
            Return Nilai
        End If
    End Function

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Close()
        Form1.Show()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
    End Sub

    Private Sub PictureBox11_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox11.MouseEnter
        PictureBox11.Image = My.Resources.Exit1
    End Sub

    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox11.MouseLeave
        PictureBox11.Image = My.Resources._Exit
    End Sub

    Private Sub PictureBox16_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox16.MouseEnter
        PictureBox16.Image = My.Resources.LDTR3
        PictureBox15.Image = My.Resources.LDTS2
    End Sub

    Private Sub PictureBox16_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox16.MouseLeave
        PictureBox16.Image = My.Resources.LDTR2
        PictureBox15.Image = My.Resources.LDTS
    End Sub

    Private Sub PictureBox15_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox15.MouseEnter
        PictureBox15.Image = My.Resources.LDTS1
    End Sub

    Private Sub PictureBox15_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox15.MouseLeave
        PictureBox15.Image = My.Resources.LDTS
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Close()
        Form2.Show()
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Image = My.Resources.Training
        PictureBox4.Image = My.Resources.Testing
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = My.Resources.Training1
        PictureBox4.Image = My.Resources.Testing2
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Close()
        Form3.Show()
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.Testing1
        PictureBox3.Image = My.Resources.Diagram3
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.Testing2
        PictureBox3.Image = My.Resources.Diagram1
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Close()
        Form5.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Close()
        Form6.Show()
    End Sub
End Class