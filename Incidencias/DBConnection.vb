Imports MySql.Data.MySqlClient

Module DBConnection

    Public conectionSring As String = "Server=192.168.10.3;Database=DBCallCenter;UserId=rootdb;Password=;"
    Public connection As New MySqlConnection(conectionSring)

End Module
