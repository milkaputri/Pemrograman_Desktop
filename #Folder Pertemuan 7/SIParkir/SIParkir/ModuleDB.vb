Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI
Module ModuleDB
    Public pengguna As String = "sharon"
    Public ppassword As String = "sharon"
    Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
    Public myConn As MySqlConnection
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    Public jns As String = String.Empty
    Public tbluser As String = "users" 'nama tabel user
    Public bts As Integer = 5
    Public Sub CreateConnection()
        myStrCon.UserID = "root"
        myStrCon.Server = "localhost"
        myStrCon.Password = ""
        myStrCon.Database = "siparkir" 'sesuaikan nama databasenya
        myConn = New MySqlConnection(myStrCon.ToString)
    End Sub
End Module
