Imports MySql.Data.MySqlClient

Module DBConnection

    Public conectionString As String = "Server=192.168.10.3;Database=DBCallCenter;UserId=rootdb;Password=;"
    Public connection As New MySqlConnection(conectionString)

End Module
