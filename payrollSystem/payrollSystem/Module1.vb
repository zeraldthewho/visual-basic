Imports MySql.Data.MySqlClient
Module Module1
    Public connection As New MySqlConnection
    Public cmd As New MySqlCommand
    Sub openConnection()
        connection.ConnectionString = "server=localhost;username=root;password=;database=prsdb"
        connection.Open()
    End Sub
End Module
