Imports System.Runtime.InteropServices
Public Class Form1
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.TextBox1.Handle, &H1501, 0, "Username")
        SendMessage(Me.TextBox2.Handle, &H1501, 0, "Password")
    End Sub

    Private Sub PictureBox5_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseDown
        PictureBox5.Image = My.Resources.Password1
        TextBox2.PasswordChar = ""
    End Sub

    Private Sub PictureBox5_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseUp
        PictureBox5.Image = My.Resources.Password
        TextBox2.PasswordChar = "●"
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Image = My.Resources._In
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Image = My.Resources.In1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub
    Private maxlogin As Integer
    Public Shared username As String
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Field username masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Field password masih kosong, silahkan diisi terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
        Else
            If maxlogin < 3 Then
                Call Conn()
                DML = Database.CreateCommand
                DML.CommandText = "SELECT * FROM login WHERE Nama='" & TextBox1.Text & "'"
                Baca = DML.ExecuteReader
                Baca.Read()
                If Baca.HasRows = True Then
                    If TextBox2.Text = Baca.Item("Sandi").ToString Then
                        username = TextBox1.Text
                        maxlogin = 0
                        Form2.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Password yang Anda masukkan salah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        maxlogin = maxlogin + 1
                        TextBox2.Focus()
                    End If
                Else
                    MessageBox.Show("Username yang Anda masukkan belum terdaftar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    maxlogin = maxlogin + 1
                    TextBox1.Focus()
                End If
            Else
                MessageBox.Show("Anda tidak dapat mengakses sistem ini", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.UExit
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.Login
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Image = My.Resources.Password2
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = My.Resources.Password
    End Sub
End Class
