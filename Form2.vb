Public Class Form2
    Private status As String
    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Image = My.Resources.Save1
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Image = My.Resources.Save
    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.Image = My.Resources.Edit1
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.Image = My.Resources.Edit
    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.Image = My.Resources.Hapus1
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.Image = My.Resources.Hapus
    End Sub

    Private Sub PictureBox11_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox11.MouseEnter
        If status = "Keluar" Then
            PictureBox11.Image = My.Resources.Exit1
        Else
            PictureBox11.Image = My.Resources.Cancel1
        End If
    End Sub

    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox11.MouseLeave
        If status = "Keluar" Then
            PictureBox11.Image = My.Resources._Exit
        Else
            PictureBox11.Image = My.Resources.Cancel
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If status = "Keluar" Then
            Close()
            Form1.Show()
            Form1.TextBox1.Text = ""
            Form1.TextBox2.Text = ""
        Else
            reset()
        End If
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.Testing3
        PictureBox3.Image = My.Resources.Diagram2
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.Testing
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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Close()
        Form3.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
        Form4.Show()
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label1.Text = Form1.username
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status = "Keluar"
        Tampil()
    End Sub

    Private Sub PictureBox14_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox14.MouseEnter
        PictureBox14.Image = My.Resources.Add1
    End Sub

    Private Sub PictureBox14_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox14.MouseLeave
        PictureBox14.Image = My.Resources.Add
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        status = "Batal"
        PictureBox11.Image = My.Resources.Cancel
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        ComboBox4.Enabled = True
        ComboBox5.Enabled = True
        ComboBox6.Enabled = True
        ComboBox7.Enabled = True
        ComboBox8.Enabled = True
        ComboBox9.Enabled = True
        TextBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox8.Enabled = True
        TextBox13.Enabled = True
        PictureBox14.Enabled = False
        PictureBox6.Enabled = True
        PictureBox7.Enabled = False
        PictureBox8.Enabled = False
        ComboBox1.Focus()
        AutoKode()
        TextBox1.Text = kodekon
    End Sub
    Sub Reset()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        ComboBox6.SelectedIndex = -1
        ComboBox7.SelectedIndex = -1
        ComboBox8.SelectedIndex = -1
        ComboBox9.SelectedIndex = -1
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        ComboBox5.Enabled = False
        ComboBox6.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        ComboBox9.Enabled = False
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox8.Text = ""
        TextBox13.Text = ""
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox8.Enabled = False
        TextBox13.Enabled = False
        PictureBox14.Enabled = True
        PictureBox6.Enabled = False
        PictureBox7.Enabled = False
        PictureBox8.Enabled = False
        PictureBox11.Image = My.Resources._Exit
        status = "Keluar"
    End Sub
    Sub Tampil()
        Call Conn()
        DML = Database.CreateCommand
        DML.CommandText = "select data_latih.kode_pasien, data_latih.jk,data_latih.umur,data_latih.alamat,sistol.ket, distol.ket,kesadaran.ket,mual_muntah.ket, nyeri_kepala.ket,sulit_bicara.ket,gerak_terbatas.ket,lemas.ket,kejang.ket,data_latih.kesimpulan from data_latih,sistol,distol,kesadaran,mual_muntah,nyeri_kepala,sulit_bicara,gerak_terbatas,lemas,kejang where data_latih.kode_pasien=sistol.kode_pasien and data_latih.kode_pasien=distol.kode_pasien and data_latih.kode_pasien=kesadaran.kode_pasien and data_latih.kode_pasien=mual_muntah.kode_pasien and data_latih.kode_pasien=nyeri_kepala.kode_pasien and data_latih.kode_pasien=sulit_bicara.kode_pasien and data_latih.kode_pasien=gerak_terbatas.kode_pasien and data_latih.kode_pasien=lemas.kode_pasien and data_latih.kode_pasien=kejang.kode_pasien"
        Baca = DML.ExecuteReader
        Dt = New DataTable
        Dt.Load(Baca)
        DataGridView1.DataSource = Dt
        DataGridView1.Columns(0).HeaderText = "KODE PASIEN"
        DataGridView1.Columns(1).HeaderText = "JENIS KELAMIN"
        DataGridView1.Columns(2).HeaderText = "UMUR"
        DataGridView1.Columns(3).HeaderText = "ALAMAT"
        DataGridView1.Columns(4).HeaderText = "SISTOL"
        DataGridView1.Columns(5).HeaderText = "DISTOL"
        DataGridView1.Columns(6).HeaderText = "KESADARAN"
        DataGridView1.Columns(7).HeaderText = "MUAL MUNTAH"
        DataGridView1.Columns(8).HeaderText = "NYERI KEPALA"
        DataGridView1.Columns(9).HeaderText = "SULIT BICARA"
        DataGridView1.Columns(10).HeaderText = "GERAK TERBATAS"
        DataGridView1.Columns(11).HeaderText = "LEMAS"
        DataGridView1.Columns(12).HeaderText = "KEJANG"
        DataGridView1.Columns(13).HeaderText = "KESIMPULAN"
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 80
        DataGridView1.Columns(2).Width = 80
        DataGridView1.Columns(3).Width = 250
        DataGridView1.Columns(4).Width = 80
        DataGridView1.Columns(5).Width = 80
        DataGridView1.Columns(6).Width = 80
        DataGridView1.Columns(7).Width = 80
        DataGridView1.Columns(8).Width = 80
        DataGridView1.Columns(9).Width = 80
        DataGridView1.Columns(10).Width = 80
        DataGridView1.Columns(11).Width = 80
        DataGridView1.Columns(12).Width = 80
        DataGridView1.Columns(12).Width = 100
        Baca.Close()
    End Sub

    Private kodekon As String
    Sub AutoKode()
        kodekon = ""
        Call Conn()
        DML = Database.CreateCommand
        DML.CommandText = "SELECT*FROM data_latih WHERE kode_pasien IN(SELECT MAX(kode_pasien) FROM data_latih)"
        Baca = DML.ExecuteReader
        Baca.Read()
        If Baca.HasRows = False Then
            kodekon = "PAS00001"
            Baca.Close()
        Else
            kodekon = Val(Microsoft.VisualBasic.Mid(Baca.Item("kode_pasien").ToString, 4, 5)) + 1
            If Len(kodekon) = 1 Then
                kodekon = "PAS0000" & kodekon
            ElseIf Len(kodekon) = 2 Then
                kodekon = "PAs000" & kodekon
            ElseIf Len(kodekon) = 3 Then
                kodekon = "PAS00" & kodekon
            ElseIf Len(kodekon) = 4 Then
                kodekon = "PAS0" & kodekon
            ElseIf Len(kodekon) = 5 Then
                kodekon = "PAS" & kodekon
            End If
            Baca.Close()
        End If
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
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
        ElseIf ComboBox9.Text = "" Then
            MessageBox.Show("Field kesimpulan masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox9.Focus()
        Else
            Call Conn()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into data_latih VALUES('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox9.Text & "')"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into distol VALUES('" & TextBox1.Text & "','" & TextBox13.Text & "')"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into sistol VALUES('" & TextBox1.Text & "','" & TextBox8.Text & "')"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into kesadaran VALUES('" & TextBox1.Text & "','" & ComboBox2.Text & "')"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into mual_muntah VALUES('" & TextBox1.Text & "','" & ComboBox3.Text & "')"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into nyeri_kepala VALUES('" & TextBox1.Text & "','" & ComboBox4.Text & "')"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into sulit_bicara VALUES('" & TextBox1.Text & "','" & ComboBox5.Text & "')"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into gerak_terbatas VALUES('" & TextBox1.Text & "','" & ComboBox6.Text & "')"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into lemas VALUES('" & TextBox1.Text & "','" & ComboBox7.Text & "')"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "INSERT into kejang VALUES('" & TextBox1.Text & "','" & ComboBox8.Text & "')"
            DML.ExecuteNonQuery()
            Reset()
            Tampil()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
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
        ElseIf ComboBox9.Text = "" Then
            MessageBox.Show("Field kesimpulan masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox9.Focus()
        Else
            Call Conn()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE data_latih SET jk='" & ComboBox1.Text & "',umur='" & TextBox3.Text & "',alamat='" & TextBox4.Text & "', kesimpulan='" & ComboBox9.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE distol SET ket='" & TextBox13.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE sistol SET ket='" & TextBox8.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE kesadaran SET ket='" & ComboBox2.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE mual_muntah SET ket='" & ComboBox3.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE nyeri_kepala SET ket='" & ComboBox4.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE sulit_bicara SET ket='" & ComboBox5.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE gerak_terbatas SET ket='" & ComboBox6.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE lemas SET ket='" & ComboBox7.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            DML = Database.CreateCommand
            DML.CommandText = "UPDATE kejang SET ket='" & ComboBox8.Text & "' WHERE kode_pasien='" & TextBox1.Text & "'"
            DML.ExecuteNonQuery()
            Reset()
            Tampil()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Tidak ada data yang akan dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Kode Pasien: " & TextBox1.Text & vbCrLf & "Apakah Anda yakin akan menghapus data ini ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call Conn()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM data_latih WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM sistol WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM distol WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM kesadaran WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM mual_muntah WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM nyeri_kepala WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM sulit_bicara WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM gerak_terbatas WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM lemas WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                DML = Database.CreateCommand
                DML.CommandText = "DELETE FROM kejang WHERE kode_pasien='" & TextBox1.Text & "'"
                DML.ExecuteNonQuery()
                Reset()
                Tampil()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBox1.Text = DataGridView1.SelectedCells(0).Value.ToString
        TextBox3.Text = DataGridView1.SelectedCells(2).Value.ToString
        TextBox4.Text = DataGridView1.SelectedCells(3).Value.ToString
        TextBox8.Text = DataGridView1.SelectedCells(4).Value.ToString
        TextBox13.Text = DataGridView1.SelectedCells(5).Value.ToString
        Dim i As Integer
        Call Conn()
        i = 0
        DML = Database.CreateCommand
        DML.CommandText = "SELECT jk FROM data_latih WHERE kode_pasien='" & TextBox1.Text & "'"
        Baca = DML.ExecuteReader
        Baca.Read()
        While Not ComboBox1.Items.Item(i) = Baca.Item("jk")
            i = i + 1
        End While
        ComboBox1.Text = ComboBox1.Items.Item(i)
        Baca.Close()

        i = 0
        DML = Database.CreateCommand
        DML.CommandText = "SELECT ket FROM kesadaran WHERE kode_pasien='" & TextBox1.Text & "'"
        Baca = DML.ExecuteReader
        Baca.Read()
        While Not ComboBox2.Items.Item(i) = Baca.Item("ket")
            i = i + 1
        End While
        ComboBox2.Text = ComboBox2.Items.Item(i)
        Baca.Close()

        i = 0
        DML = Database.CreateCommand
        DML.CommandText = "SELECT ket FROM mual_muntah WHERE kode_pasien='" & TextBox1.Text & "'"
        Baca = DML.ExecuteReader
        Baca.Read()
        While Not ComboBox3.Items.Item(i) = Baca.Item("ket")
            i = i + 1
        End While
        ComboBox3.Text = ComboBox3.Items.Item(i)
        Baca.Close()

        i = 0
        DML = Database.CreateCommand
        DML.CommandText = "SELECT ket FROM nyeri_kepala WHERE kode_pasien='" & TextBox1.Text & "'"
        Baca = DML.ExecuteReader
        Baca.Read()
        While Not ComboBox4.Items.Item(i) = Baca.Item("ket")
            i = i + 1
        End While
        ComboBox4.Text = ComboBox4.Items.Item(i)
        Baca.Close()

        i = 0
        DML = Database.CreateCommand
        DML.CommandText = "SELECT ket FROM sulit_bicara WHERE kode_pasien='" & TextBox1.Text & "'"
        Baca = DML.ExecuteReader
        Baca.Read()
        While Not ComboBox5.Items.Item(i) = Baca.Item("ket")
            i = i + 1
        End While
        ComboBox5.Text = ComboBox5.Items.Item(i)
        Baca.Close()

        i = 0
        DML = Database.CreateCommand
        DML.CommandText = "SELECT ket FROM gerak_terbatas WHERE kode_pasien='" & TextBox1.Text & "'"
        Baca = DML.ExecuteReader
        Baca.Read()
        While Not ComboBox6.Items.Item(i) = Baca.Item("ket")
            i = i + 1
        End While
        ComboBox6.Text = ComboBox6.Items.Item(i)
        Baca.Close()

        i = 0
        DML = Database.CreateCommand
        DML.CommandText = "SELECT ket FROM lemas WHERE kode_pasien='" & TextBox1.Text & "'"
        Baca = DML.ExecuteReader
        Baca.Read()
        While Not ComboBox7.Items.Item(i) = Baca.Item("ket")
            i = i + 1
        End While
        ComboBox7.Text = ComboBox7.Items.Item(i)
        Baca.Close()

        i = 0
        DML = Database.CreateCommand
        DML.CommandText = "SELECT ket FROM kejang WHERE kode_pasien='" & TextBox1.Text & "'"
        Baca = DML.ExecuteReader
        Baca.Read()
        While Not ComboBox8.Items.Item(i) = Baca.Item("ket")
            i = i + 1
        End While
        ComboBox8.Text = ComboBox8.Items.Item(i)
        Baca.Close()

        i = 0
        DML = Database.CreateCommand
        DML.CommandText = "SELECT kesimpulan FROM data_latih WHERE kode_pasien='" & TextBox1.Text & "'"
        Baca = DML.ExecuteReader
        Baca.Read()
        While Not ComboBox9.Items.Item(i) = Baca.Item("kesimpulan")
            i = i + 1
        End While
        ComboBox9.Text = ComboBox9.Items.Item(i)
        Baca.Close()
        status = "Batal"
        PictureBox11.Image = My.Resources.Cancel
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        ComboBox4.Enabled = True
        ComboBox5.Enabled = True
        ComboBox6.Enabled = True
        ComboBox7.Enabled = True
        ComboBox8.Enabled = True
        ComboBox9.Enabled = True
        TextBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox8.Enabled = True
        TextBox13.Enabled = True
        PictureBox14.Enabled = False
        PictureBox6.Enabled = False
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        ComboBox1.Focus()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9") And Not e.KeyChar = ControlChars.Back Then
            e.Handled = True
        End If
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

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Close()
        Form5.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Close()
        Form6.Show()
    End Sub
End Class