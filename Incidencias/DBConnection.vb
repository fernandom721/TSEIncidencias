Imports MySql.Data.MySqlClient

Module DBConnection

    Public conectionString As String = "Server=192.168.50.10;Database=DBCallCenter;UserId=rootdb;Password=;"
    Public connection As New MySqlConnection(conectionString)

    Public id_usuario As Integer

End Module
