Imports MySql.Data.MySqlClient
Imports MySql.Data
Module Module1
    Public Database As MySqlConnection
    Public DML As MySqlCommand
    Public Reader As MySqlDataReader
    Public cmd As MySqlCommand
    Public Baca As MySqlDataReader
    Public Dt As DataTable
    Public Da As MySqlDataAdapter

    Public Sub Conn()
        Database = New MySqlConnection("server=localhost;database=rekammedik;uid=root;pwd=")
        Database.Open()
    End Sub
End Module
