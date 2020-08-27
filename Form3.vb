Public Class Form3
    Public KU As String
    Public UH As String
    Public UNH As String
    Public KSH As String
    Public KSNH As String
    Public mumuH As String
    Public mumuNH As String
    Public NKH As String
    Public NKNH As String
    Public SBH As String
    Public SBNH As String
    Public GTH As String
    Public GTNH As String
    Public LH As String
    Public LNH As String
    Public KH As String
    Public KNH As String
    Public hasilH As String
    Public hasilNH As String
    Public kesimpulan As String
    Public jumlah_data As String
    Public H As String
    Public NH As String

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

    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.Image = My.Resources.Proses1
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.Image = My.Resources.Proses
    End Sub

    Private Sub PictureBox16_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox16.MouseEnter
        PictureBox16.Image = My.Resources.LDTR1
        PictureBox15.Image = My.Resources.LDTS2
    End Sub

    Private Sub PictureBox16_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox16.MouseLeave
        PictureBox16.Image = My.Resources.LDTR
        PictureBox15.Image = My.Resources.LDTS
    End Sub

    Private Sub PictureBox15_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox15.MouseEnter
        PictureBox16.Image = My.Resources.LDTR
        PictureBox15.Image = My.Resources.LDTS1
    End Sub

    Private Sub PictureBox15_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox15.MouseLeave
        PictureBox16.Image = My.Resources.LDTR
        PictureBox15.Image = My.Resources.LDTS
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

    Private kodekon As String

    Sub AutoKode()
        kodekon = ""
        Call Conn()
        DML = Database.CreateCommand
        DML.CommandText = "SELECT*FROM data_test WHERE kode_pasien IN(SELECT MAX(kode_pasien) FROM data_test)"
        Baca = DML.ExecuteReader
        Baca.Read()
        If Baca.HasRows = False Then
            kodekon = "TES00001"
            Baca.Close()
        Else
            kodekon = Val(Microsoft.VisualBasic.Mid(Baca.Item("kode_pasien").ToString, 4, 5)) + 1
            If Len(kodekon) = 1 Then
                kodekon = "TES0000" & kodekon
            ElseIf Len(kodekon) = 2 Then
                kodekon = "TES000" & kodekon
            ElseIf Len(kodekon) = 3 Then
                kodekon = "TES00" & kodekon
            ElseIf Len(kodekon) = 4 Then
                kodekon = "TES0" & kodekon
            ElseIf Len(kodekon) = 5 Then
                kodekon = "TES" & kodekon
            End If
            Baca.Close()
        End If
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("Field jenis kelamin masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Focus()
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Field umur masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Focus()
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Field alamat masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Focus()
        ElseIf TextBox8.Text = "" Then
            MessageBox.Show("Field sistol masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox8.Focus()
        ElseIf TextBox13.Text = "" Then
            MessageBox.Show("Field distol masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox13.Focus()
        ElseIf ComboBox2.Text = "" Then
            MessageBox.Show("Field kesadaran masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox2.Focus()
        ElseIf ComboBox3.Text = "" Then
            MessageBox.Show("Field mual muntah masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox3.Focus()
        ElseIf ComboBox4.Text = "" Then
            MessageBox.Show("Field nyeri kepala masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox4.Focus()
        ElseIf ComboBox5.Text = "" Then
            MessageBox.Show("Field sulit bicara masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox5.Focus()
        ElseIf ComboBox6.Text = "" Then
            MessageBox.Show("Field gerak terbatas masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox6.Focus()
        ElseIf ComboBox7.Text = "" Then
            MessageBox.Show("Field sistol lemas kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox7.Focus()
        ElseIf ComboBox8.Text = "" Then
            MessageBox.Show("Field sistol kejang kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox8.Focus()
        Else
            Dim i, nilai As Integer
            Call Conn()
            DML = Database.CreateCommand
            DML.CommandText = "select COUNT(*) from data_latih"
            Baca = DML.ExecuteReader()
            If Baca.HasRows Then
                While Baca.Read
                    jumlah_data = (Baca.Item("COUNT(*)").ToString())
                End While
            End If
            Baca.Close()

            Dim data(jumlah_data, 12) As String
            DML = Database.CreateCommand
            DML.CommandText = "select data_latih.jk AS DJK,data_latih.umur AS DUMUR,sistol.ket as DSISTOL, distol.ket AS DDISTOL,kesadaran.ket AS DKESADARAN,mual_muntah.ket AS DMUAL, nyeri_kepala.ket AS DNYERI,sulit_bicara.ket AS DBICARA,gerak_terbatas.ket AS DGERAK,lemas.ket AS DLEMAS,kejang.ket AS DKEJANG,data_latih.kesimpulan as DKESIMPULAN from data_latih,sistol,distol,kesadaran,mual_muntah,nyeri_kepala,sulit_bicara,gerak_terbatas,lemas,kejang where data_latih.kode_pasien=sistol.kode_pasien and data_latih.kode_pasien=distol.kode_pasien and data_latih.kode_pasien=kesadaran.kode_pasien and data_latih.kode_pasien=mual_muntah.kode_pasien and data_latih.kode_pasien=nyeri_kepala.kode_pasien and data_latih.kode_pasien=sulit_bicara.kode_pasien and data_latih.kode_pasien=gerak_terbatas.kode_pasien and data_latih.kode_pasien=lemas.kode_pasien and data_latih.kode_pasien=kejang.kode_pasien ORDER BY  data_latih.kode_pasien ASC"
            Baca = DML.ExecuteReader()
            If Baca.HasRows Then
                While Baca.Read
                    data(i, 0) = Baca.Item("DUMUR")
                    data(i, 1) = Baca.Item("DJK")
                    data(i, 2) = Baca.Item("DSISTOL")
                    data(i, 3) = Baca.Item("DDISTOL")
                    data(i, 4) = Baca.Item("DKESADARAN")
                    data(i, 5) = Baca.Item("DMUAL")
                    data(i, 6) = Baca.Item("DNYERI")
                    data(i, 7) = Baca.Item("DBICARA")
                    data(i, 8) = Baca.Item("DGERAK")
                    data(i, 9) = Baca.Item("DLEMAS")
                    data(i, 10) = Baca.Item("DKEJANG")
                    data(i, 11) = Baca.Item("DKESIMPULAN")
                    i = i + 1
                End While
            End If
            Baca.Close()

            For j = 0 To jumlah_data - 1
                If data(j, 11) = "Hemoragik" Then
                    nilai = nilai + 1
                End If
            Next
            H = nilai.ToString
            nilai = 0


            For j = 0 To jumlah_data - 1
                If data(j, 11) = "Infark" Then
                    nilai = nilai + 1
                End If
            Next
            NH = nilai.ToString
            nilai = 0

            If Int(TextBox3.Text) < 25 Then
                For j = 0 To jumlah_data - 1
                    If Int(Data(j, 0)) < 25 And Data(j, 11) = "Hemoragik" Then
                        nilai = nilai + 1
                    End If
                Next
                UH = nilai.ToString
                nilai = 0
                KU = "Kelompok 1"
            End If
            If Int(TextBox3.Text) >= 25 And Int(TextBox3.Text) < 45 Then
                For j = 0 To jumlah_data - 1
                    If Int(Data(j, 0)) >= 25 And Int(Data(j, 0)) < 45 And Data(j, 11) = "Hemoragik" Then
                        nilai = nilai + 1
                    End If
                Next
                UH = nilai.ToString
                nilai = 0
                KU = "Kelompok 2"
            End If
            If Int(TextBox3.Text) >= 45 Then
                For j = 0 To jumlah_data - 1
                    If Int(Data(j, 0)) >= 45 And Data(j, 11) = "Hemoragik" Then
                        nilai = nilai + 1
                    End If
                Next
                UH = nilai.ToString
                nilai = 0
                KU = "Kelompok 3"
            End If

            If Int(TextBox3.Text) < 25 Then
                For j = 0 To jumlah_data - 1
                    If Int(Data(j, 0)) < 25 And Data(j, 11) = "Infark" Then
                        nilai = nilai + 1
                    End If
                Next
                UNH = nilai.ToString
                nilai = 0
                KU = "Kelompok 1"
            End If
            If Int(TextBox3.Text) >= 25 And Int(TextBox3.Text) < 45 Then
                For j = 0 To jumlah_data - 1
                    If Int(Data(j, 0)) >= 25 And Int(Data(j, 0)) < 45 And Data(j, 11) = "Infark" Then
                        nilai = nilai + 1
                    End If
                Next
                UNH = nilai.ToString
                nilai = 0
                KU = "Kelompok 2"
            End If
            If Int(TextBox3.Text) >= 45 Then
                For j = 0 To jumlah_data - 1
                    If Int(Data(j, 0)) >= 45 And Data(j, 11) = "Infark" Then
                        nilai = nilai + 1
                    End If
                Next
                UNH = nilai.ToString
                nilai = 0
                KU = "Kelompok 3"
            End If

            For j = 0 To jumlah_data - 1
                If Data(j, 4) = ComboBox2.Text And Data(j, 11) = "Hemoragik" Then
                    nilai = nilai + 1
                End If
            Next
            KSH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 4) = ComboBox2.Text And Data(j, 11) = "Infark" Then
                    nilai = nilai + 1
                End If
            Next
            KSNH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 5) = ComboBox3.Text And Data(j, 11) = "Hemoragik" Then
                    nilai = nilai + 1
                End If
            Next
            mumuH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 5) = ComboBox3.Text And Data(j, 11) = "Infark" Then
                    nilai = nilai + 1
                End If
            Next
            mumuNH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 6) = ComboBox4.Text And Data(j, 11) = "Hemoragik" Then
                    nilai = nilai + 1
                End If
            Next
            NKH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 6) = ComboBox4.Text And Data(j, 11) = "Infark" Then
                    nilai = nilai + 1
                End If
            Next
            NKNH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 7) = ComboBox5.Text And Data(j, 11) = "Hemoragik" Then
                    nilai = nilai + 1
                End If
            Next
            SBH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 7) = ComboBox5.Text And Data(j, 11) = "Infark" Then
                    nilai = nilai + 1
                End If
            Next
            SBNH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 8) = ComboBox6.Text And Data(j, 11) = "Hemoragik" Then
                    nilai = nilai + 1
                End If
            Next
            GTH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 8) = ComboBox6.Text And Data(j, 11) = "Infark" Then
                    nilai = nilai + 1
                End If
            Next
            GTNH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 9) = ComboBox7.Text And Data(j, 11) = "Hemoragik" Then
                    nilai = nilai + 1
                End If
            Next
            LH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 9) = ComboBox7.Text And Data(j, 11) = "Infark" Then
                    nilai = nilai + 1
                End If
            Next
            LNH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 10) = ComboBox8.Text And Data(j, 11) = "Hemoragik" Then
                    nilai = nilai + 1
                End If
            Next
            KH = nilai.ToString
            nilai = 0

            For j = 0 To jumlah_data - 1
                If Data(j, 10) = ComboBox8.Text And Data(j, 11) = "Infark" Then
                    nilai = nilai + 1
                End If
            Next
            KNH = nilai.ToString
            nilai = 0
            hasilH = Convert.ToDecimal(Convert.ToDecimal(KSH / H) * Convert.ToDecimal(mumuH / H) * Convert.ToDecimal(NKH / H) * Convert.ToDecimal(SBH / H) * Convert.ToDecimal(GTH / H) * Convert.ToDecimal(LH / H) * Convert.ToDecimal(KH / H))
            hasilNH = Convert.ToDecimal(Convert.ToDecimal(KSNH / NH) * Convert.ToDecimal(mumuNH / NH) * Convert.ToDecimal(NKNH / NH) * Convert.ToDecimal(SBNH / NH) * Convert.ToDecimal(GTNH / NH) * Convert.ToDecimal(LNH / NH) * Convert.ToDecimal(KNH / NH))
            If Convert.ToDecimal(hasilH > hasilNH) Then
                kesimpulan = "Hemoragik"
            ElseIf Convert.ToDecimal(hasilH < hasilNH) Then
                kesimpulan = "Infark"
            Else
                If Convert.ToDecimal(H > NH) Then
                    kesimpulan = "Hemoragik"
                ElseIf Convert.ToDecimal(H < NH) Then
                    kesimpulan = "Infark"
                Else
                    kesimpulan = ""
                End If
            End If
            hasilH = AngkaDesimal(Convert.ToDecimal(Convert.ToDecimal(KSH / H) * Convert.ToDecimal(mumuH / H) * Convert.ToDecimal(NKH / H) * Convert.ToDecimal(SBH / H) * Convert.ToDecimal(GTH / H) * Convert.ToDecimal(LH / H) * Convert.ToDecimal(KH / H)), 5)
            hasilNH = AngkaDesimal(Convert.ToDecimal(Convert.ToDecimal(KSNH / NH) * Convert.ToDecimal(mumuNH / NH) * Convert.ToDecimal(NKNH / NH) * Convert.ToDecimal(SBNH / NH) * Convert.ToDecimal(GTNH / NH) * Convert.ToDecimal(LNH / NH) * Convert.ToDecimal(KNH / NH)), 5)

            ListBox1.Items.Clear()
            ListBox1.Items.Add("JUMLAH DATA TRAINING : " & jumlah_data)
            ListBox1.Items.Add("---------------------------------------------")
            ListBox1.Items.Add("HEMORAGIK")
            ListBox1.Items.Add("Jumlah Hemoragik : " & H)
            ListBox1.Items.Add("Kelompok Usia = " & TextBox3.Text & " Tahun (" & KU & "  [" & UH & " data])")
            ListBox1.Items.Add("Kesadaran = " & ComboBox2.Text & " (" & AngkaDesimal(Convert.ToDecimal(KSH / H), 5) & ")")
            ListBox1.Items.Add("Mual Muntah = " & ComboBox3.Text & " (" & AngkaDesimal(Convert.ToDecimal(mumuH / H), 5) & ")")
            ListBox1.Items.Add("Nyeri Kepala = " & ComboBox4.Text & " (" & AngkaDesimal(Convert.ToDecimal(NKH / H), 5) & ")")
            ListBox1.Items.Add("Sulit Bicara = " & ComboBox5.Text & " (" & AngkaDesimal(Convert.ToDecimal(SBH / H), 5) & ")")
            ListBox1.Items.Add("Gerak Terbatas = " & ComboBox6.Text & " (" & AngkaDesimal(Convert.ToDecimal(GTH / H), 5) & ")")
            ListBox1.Items.Add("Lemas = " & ComboBox7.Text & " (" & AngkaDesimal(Convert.ToDecimal(LH / H), 5) & ")")
            ListBox1.Items.Add("Kejang = " & ComboBox8.Text & " (" & AngkaDesimal(Convert.ToDecimal(KH / H), 5) & ")")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("Hasil Hemoragik = " & hasilH)
            ListBox1.Items.Add("---------------------------------------------")
            ListBox1.Items.Add("INFARK")
            ListBox1.Items.Add("Jumlah Infark : " & NH)
            ListBox1.Items.Add("Kelompok Usia = " & TextBox3.Text & " Tahun (" & KU & "  [" & UNH & " data])")
            ListBox1.Items.Add("Kesadaran = " & ComboBox2.Text & " (" & AngkaDesimal(Convert.ToDecimal(KSNH / NH), 5) & ")")
            ListBox1.Items.Add("Mual Muntah = " & ComboBox3.Text & " (" & AngkaDesimal(Convert.ToDecimal(mumuNH / NH), 5) & ")")
            ListBox1.Items.Add("Nyeri Kepala = " & ComboBox4.Text & " (" & AngkaDesimal(Convert.ToDecimal(NKNH / NH), 5) & ")")
            ListBox1.Items.Add("Sulit Bicara = " & ComboBox5.Text & " (" & AngkaDesimal(Convert.ToDecimal(SBNH / NH), 5) & ")")
            ListBox1.Items.Add("Gerak Terbatas = " & ComboBox6.Text & " (" & AngkaDesimal(Convert.ToDecimal(GTNH / NH), 5) & ")")
            ListBox1.Items.Add("Lemas = " & ComboBox7.Text & " (" & AngkaDesimal(Convert.ToDecimal(LNH / NH), 5) & ")")
            ListBox1.Items.Add("Kejang = " & ComboBox8.Text & " (" & AngkaDesimal(Convert.ToDecimal(KNH / NH), 5) & ")")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("Hasil Infark = " & hasilNH)

            If Convert.ToDecimal(hasilH > hasilNH) Then
                kesimpulan = "Hemoragik"
                ListBox1.Items.Add("")
                ListBox1.Items.Add("Membandingkan Hasil Nilai Probabilitas posterior kelas INF dan HEMO Karena aproksimasi nilai probabilitas posterior P(Y = INF)")
                ListBox1.Items.Add("lebih Besar dari aproksimasi nilai probabilitas posterior P(Y = HEMO) maka keputusanya adalah data testing masuk ke dalam kelas HEMORAGIK")
            ElseIf Convert.ToDecimal(hasilH < hasilNH) Then
                kesimpulan = "Infark"
                ListBox1.Items.Add("")
                ListBox1.Items.Add("Membandingkan Hasil Nilai Probabilitas posterior kelas INF dan HEMO Karena aproksimasi nilai probabilitas posterior P(Y = INF)")
                ListBox1.Items.Add("lebih kecil dari aproksimasi nilai probabilitas posterior P(Y = HEMO) maka keputusanya adalah data testing masuk ke dalam kelas INFARK")
            Else
                If Convert.ToDecimal(H > NH) Then
                    kesimpulan = "Hemoragik"
                    ListBox1.Items.Add("")
                    ListBox1.Items.Add("Karena aproksimasi nilai probabilitas posterior P(Y = INF) sama dengan aproksimasi nilai probabilitas posterior P(Y = HEMO)")
                    ListBox1.Items.Add("dan sebaran data HEMO lebih besar dari INF, maka keputusanya adalah data testing masuk ke dalam kelas HEMORAGIK")
                ElseIf Convert.ToDecimal(H < NH) Then
                    kesimpulan = "Infark"
                    ListBox1.Items.Add("")
                    ListBox1.Items.Add("Karena aproksimasi nilai probabilitas posterior P(Y = INF) sama dengan aproksimasi nilai probabilitas posterior P(Y = HEMO)")
                    ListBox1.Items.Add("dan sebaran data INF lebih besar dari HEMO, maka keputusanya adalah data testing masuk ke dalam kelas INFARK")
                Else
                    kesimpulan = ""
                    ListBox1.Items.Add("")
                    ListBox1.Items.Add("Karena aproksimasi nilai probabilitas posterior P(Y = INF) sama dengan aproksimasi nilai probabilitas posterior P(Y = HEMO)")
                    ListBox1.Items.Add("dan sebaran data INF sama dengan HEMO, maka sistem tidak dapat menarik kesimpulan")
                End If
            End If
            AutoKode()
            Call Conn()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into data_test VALUES(@kodepasien,@jk,@umur,@alamat,@kesimpulan,@sistol,@distol,@kesadaran,@mual_muntah,@nyeri_kepala,@sulit_bicara,@gerak_terbatas,@lemas,@kejang)"
            DML.Parameters.AddWithValue("@kodepasien", kodekon)
            DML.Parameters.AddWithValue("@jk", ComboBox1.Text)
            DML.Parameters.AddWithValue("@umur", TextBox3.Text)
            DML.Parameters.AddWithValue("@alamat", TextBox4.Text)
            DML.Parameters.AddWithValue("@sistol", TextBox8.Text)
            DML.Parameters.AddWithValue("@distol", TextBox13.Text)
            DML.Parameters.AddWithValue("@kesadaran", ComboBox2.Text)
            DML.Parameters.AddWithValue("@mual_muntah", ComboBox3.Text)
            DML.Parameters.AddWithValue("@nyeri_kepala", ComboBox4.Text)
            DML.Parameters.AddWithValue("@sulit_bicara", ComboBox5.Text)
            DML.Parameters.AddWithValue("@gerak_terbatas", ComboBox6.Text)
            DML.Parameters.AddWithValue("@lemas", ComboBox7.Text)
            DML.Parameters.AddWithValue("@kejang", ComboBox8.Text)
            DML.Parameters.AddWithValue("@kesimpulan", kesimpulan)
            DML.ExecuteNonQuery()
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            ComboBox3.SelectedIndex = -1
            ComboBox4.SelectedIndex = -1
            ComboBox5.SelectedIndex = -1
            ComboBox6.SelectedIndex = -1
            ComboBox7.SelectedIndex = -1
            ComboBox8.SelectedIndex = -1
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox8.Text = ""
            TextBox13.Text = ""
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        Form2.Show()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Call Conn()
    '    DML = Database.CreateCommand
    '    DML.CommandText = "select COUNT(*) from data_latih"
    '    Baca = DML.ExecuteReader()
    '    If Baca.HasRows Then
    '        While Baca.Read
    '            jumlah_data = (Baca.Item("COUNT(*)").ToString())
    '        End While
    '    End If
    '    Baca.Close()

    '    DML = Database.CreateCommand
    '    DML.CommandText = "select COUNT(*) from data_latih where kesimpulan='Hemoragik'"
    '    Baca = DML.ExecuteReader()
    '    If Baca.HasRows Then
    '        While Baca.Read
    '            H = (Baca.Item("COUNT(*)").ToString())
    '        End While
    '    End If
    '    Baca.Close()

    '    DML = Database.CreateCommand
    '    DML.CommandText = "select COUNT(*) from data_latih where kesimpulan='Infark'"
    '    Baca = DML.ExecuteReader()
    '    If Baca.HasRows Then
    '        While Baca.Read
    '            NH = (Baca.Item("COUNT(*)").ToString())
    '        End While
    '    End If
    '    Baca.Close()
    '    Dim data(jumlah_data, 12) As String
    '    Dim i, nilai As Integer
    '    Call Conn()
    '    cmd = Database.CreateCommand
    '    cmd.CommandText = "delete from data_test"
    '    cmd.ExecuteNonQuery()
    '    cmd = Database.CreateCommand
    '    cmd.CommandText = "select data_latih.jk AS DJK,data_latih.umur AS DUMUR,sistol.ket as DSISTOL, distol.ket AS DDISTOL,kesadaran.ket AS DKESADARAN,mual_muntah.ket AS DMUAL, nyeri_kepala.ket AS DNYERI,sulit_bicara.ket AS DBICARA,gerak_terbatas.ket AS DGERAK,lemas.ket AS DLEMAS,kejang.ket AS DKEJANG,data_latih.kesimpulan as DKESIMPULAN from data_latih,sistol,distol,kesadaran,mual_muntah,nyeri_kepala,sulit_bicara,gerak_terbatas,lemas,kejang where data_latih.kode_pasien=sistol.kode_pasien and data_latih.kode_pasien=distol.kode_pasien and data_latih.kode_pasien=kesadaran.kode_pasien and data_latih.kode_pasien=mual_muntah.kode_pasien and data_latih.kode_pasien=nyeri_kepala.kode_pasien and data_latih.kode_pasien=sulit_bicara.kode_pasien and data_latih.kode_pasien=gerak_terbatas.kode_pasien and data_latih.kode_pasien=lemas.kode_pasien and data_latih.kode_pasien=kejang.kode_pasien ORDER BY  data_latih.kode_pasien ASC"
    '    Reader = cmd.ExecuteReader()
    '    While Reader.Read
    '        data(i, 0) = Reader.Item("DUMUR")
    '        data(i, 1) = Reader.Item("DJK")
    '        data(i, 2) = Reader.Item("DSISTOL")
    '        data(i, 3) = Reader.Item("DDISTOL")
    '        data(i, 4) = Reader.Item("DKESADARAN")
    '        data(i, 5) = Reader.Item("DMUAL")
    '        data(i, 6) = Reader.Item("DNYERI")
    '        data(i, 7) = Reader.Item("DBICARA")
    '        data(i, 8) = Reader.Item("DGERAK")
    '        data(i, 9) = Reader.Item("DLEMAS")
    '        data(i, 10) = Reader.Item("DKEJANG")
    '        data(i, 11) = Reader.Item("DKESIMPULAN")
    '        i = i + 1
    '    End While
    '    Reader.Close()
    '    For i = 0 To jumlah_data - 1
    '        If Int(data(i, 0)) < 25 Then
    '            For j = 0 To jumlah_data - 1
    '                If Int(data(j, 0)) < 25 And data(j, 11) = "Hemoragik" Then
    '                    nilai = nilai + 1
    '                End If
    '            Next
    '            UH = nilai.ToString
    '            nilai = 0
    '            KU = "Kelompok 1"
    '        End If
    '        If Int(data(i, 0)) >= 25 And Int(data(i, 0)) < 45 Then
    '            For j = 0 To jumlah_data - 1
    '                If Int(data(j, 0)) >= 25 And Int(data(j, 0)) < 45 And data(j, 11) = "Hemoragik" Then
    '                    nilai = nilai + 1
    '                End If
    '            Next
    '            UH = nilai.ToString
    '            nilai = 0
    '            KU = "Kelompok 2"
    '        End If
    '        If Int(data(i, 0)) >= 45 Then
    '            For j = 0 To jumlah_data - 1
    '                If Int(data(j, 0)) >= 45 And data(j, 11) = "Hemoragik" Then
    '                    nilai = nilai + 1
    '                End If
    '            Next
    '            UH = nilai.ToString
    '            nilai = 0
    '            KU = "Kelompok 3"
    '        End If

    '        If Int(data(i, 0)) < 25 Then
    '            For j = 0 To jumlah_data - 1
    '                If Int(data(j, 0)) < 25 And data(j, 11) = "Infark" Then
    '                    nilai = nilai + 1
    '                End If
    '            Next
    '            UNH = nilai.ToString
    '            nilai = 0
    '            KU = "Kelompok 1"
    '        End If
    '        If Int(data(i, 0)) >= 25 And Int(data(i, 0)) < 45 Then
    '            For j = 0 To jumlah_data - 1
    '                If Int(data(j, 0)) >= 25 And Int(data(j, 0)) < 45 And data(j, 11) = "Infark" Then
    '                    nilai = nilai + 1
    '                End If
    '            Next
    '            UNH = nilai.ToString
    '            nilai = 0
    '            KU = "Kelompok 2"
    '        End If
    '        If Int(data(i, 0)) >= 45 Then
    '            For j = 0 To jumlah_data - 1
    '                If Int(data(j, 0)) >= 45 And data(j, 11) = "Infark" Then
    '                    nilai = nilai + 1
    '                End If
    '            Next
    '            UNH = nilai.ToString
    '            nilai = 0
    '            KU = "Kelompok 3"
    '        End If

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 4) = data(i, 4) And data(j, 11) = "Hemoragik" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        KSH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 4) = data(i, 4) And data(j, 11) = "Infark" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        KSNH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 5) = data(i, 5) And data(j, 11) = "Hemoragik" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        mumuH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 5) = data(i, 5) And data(j, 11) = "Infark" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        mumuNH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 6) = data(i, 6) And data(j, 11) = "Hemoragik" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        NKH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 6) = data(i, 6) And data(j, 11) = "Infark" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        NKNH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 7) = data(i, 7) And data(j, 11) = "Hemoragik" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        SBH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 7) = data(i, 7) And data(j, 11) = "Infark" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        SBNH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 8) = data(i, 8) And data(j, 11) = "Hemoragik" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        GTH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 8) = data(i, 8) And data(j, 11) = "Infark" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        GTNH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 9) = data(i, 9) And data(j, 11) = "Hemoragik" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        LH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 9) = data(i, 9) And data(j, 11) = "Infark" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        LNH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 10) = data(i, 10) And data(j, 11) = "Hemoragik" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        KH = nilai.ToString
    '        nilai = 0

    '        For j = 0 To jumlah_data - 1
    '            If data(j, 10) = data(i, 10) And data(j, 11) = "Infark" Then
    '                nilai = nilai + 1
    '            End If
    '        Next
    '        KNH = nilai.ToString
    '        nilai = 0

    '        hasilH = Convert.ToDecimal(Convert.ToDecimal(KSH / H) * Convert.ToDecimal(mumuH / H) * Convert.ToDecimal(NKH / H) * Convert.ToDecimal(SBH / H) * Convert.ToDecimal(GTH / H) * Convert.ToDecimal(LH / H) * Convert.ToDecimal(KH / H))
    '        hasilNH = Convert.ToDecimal(Convert.ToDecimal(KSNH / NH) * Convert.ToDecimal(mumuNH / NH) * Convert.ToDecimal(NKNH / NH) * Convert.ToDecimal(SBNH / NH) * Convert.ToDecimal(GTNH / NH) * Convert.ToDecimal(LNH / NH) * Convert.ToDecimal(KNH / NH))
    '        If Convert.ToDecimal(hasilH > hasilNH) Then
    '            kesimpulan = "Hemoragik"
    '        ElseIf Convert.ToDecimal(hasilH < hasilNH) Then
    '            kesimpulan = "Infark"
    '        Else
    '            If Convert.ToDecimal(H > NH) Then
    '                kesimpulan = "Hemoragik"
    '            ElseIf Convert.ToDecimal(H < NH) Then
    '                kesimpulan = "Infark"
    '            Else
    '                kesimpulan = ""
    '            End If
    '        End If
    '        AutoKode()
    '        Call Conn()
    '        DML = Database.CreateCommand
    '        DML.CommandText = "INSERT into data_test VALUES(@kodepasien,@jk,@umur,@alamat,@kesimpulan,@sistol,@distol,@kesadaran,@mual_muntah,@nyeri_kepala,@sulit_bicara,@gerak_terbatas,@lemas,@kejang)"
    '        DML.Parameters.AddWithValue("@kodepasien", kodekon)
    '        DML.Parameters.AddWithValue("@jk", data(i, 1))
    '        DML.Parameters.AddWithValue("@umur", data(i, 0))
    '        DML.Parameters.AddWithValue("@alamat", TextBox4.Text)
    '        DML.Parameters.AddWithValue("@sistol", data(i, 2))
    '        DML.Parameters.AddWithValue("@distol", data(i, 3))
    '        DML.Parameters.AddWithValue("@kesadaran", data(i, 4))
    '        DML.Parameters.AddWithValue("@mual_muntah", data(i, 5))
    '        DML.Parameters.AddWithValue("@nyeri_kepala", data(i, 6))
    '        DML.Parameters.AddWithValue("@sulit_bicara", data(i, 7))
    '        DML.Parameters.AddWithValue("@gerak_terbatas", data(i, 8))
    '        DML.Parameters.AddWithValue("@lemas", data(i, 9))
    '        DML.Parameters.AddWithValue("@kejang", data(i, 10))
    '        DML.Parameters.AddWithValue("@kesimpulan", kesimpulan)
    '        DML.ExecuteNonQuery()

    '        KU = ""
    '        UH = ""
    '        UNH = ""
    '        KSH = ""
    '        KSNH = ""
    '        mumuH = ""
    '        mumuNH = ""
    '        NKH = ""
    '        NKNH = ""
    '        SBH = ""
    '        SBNH = ""
    '        GTH = ""
    '        GTNH = ""
    '        LH = ""
    '        LNH = ""
    '        KH = ""
    '        KNH = ""
    '    Next

    '    Dim l As Integer
    '    l = 0
    '    Dim latih(Int(jumlah_data), 2) As String
    '    Dim tes(Int(jumlah_data), 2) As String
    '    DML = Database.CreateCommand
    '    DML.CommandText = "select kode_pasien, kesimpulan from data_latih ORDER BY kode_pasien ASC"
    '    Baca = DML.ExecuteReader()
    '    If Baca.HasRows Then
    '        While Baca.Read
    '            latih(l, 0) = (Baca.Item("kode_pasien"))
    '            latih(l, 1) = (Baca.Item("kesimpulan"))
    '            l = l + 1
    '        End While
    '    End If
    '    Baca.Close()
    '    l = 0
    '    DML = Database.CreateCommand
    '    DML.CommandText = "select kode_pasien, kesimpulan from data_test ORDER BY kode_pasien ASC"
    '    Baca = DML.ExecuteReader()
    '    If Baca.HasRows Then
    '        While Baca.Read
    '            tes(l, 0) = (Baca.Item("kode_pasien"))
    '            tes(l, 1) = (Baca.Item("kesimpulan"))
    '            l = l + 1
    '        End While
    '    End If
    '    Baca.Close()
    '    Dim persen As Double
    '    Dim K As Integer
    '    ListBox1.Items.Add("Tidak sama")
    '    For i = 0 To jumlah_data - 1
    '        If Not latih(i, 1) = tes(i, 1) Then
    '            ListBox1.Items.Add(latih(i, 0) & "   " & latih(i, 1) & "   " & tes(i, 1))
    '        ElseIf latih(i, 1) = tes(i, 1) Then
    '            K = K + 1
    '        End If
    '    Next
    '    persen = (K / jumlah_data) * 100
    '    ListBox1.Items.Add("Persentase : " & persen.ToString)
    'End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Image = My.Resources.Training
        PictureBox4.Image = My.Resources.Testing3
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = My.Resources.Training1
        PictureBox4.Image = My.Resources.Testing1
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
        Form4.Show()
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.Diagram3
        PictureBox16.Image = My.Resources.LDTR2
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.Diagram2
        PictureBox16.Image = My.Resources.LDTR
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Close()
        Form5.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Close()
        Form6.Show()
    End Sub

    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label1.Text = Form1.username
    End Sub
End Class