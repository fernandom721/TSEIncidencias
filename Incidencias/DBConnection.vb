Imports MySql.Data.MySqlClient

Module DBConnection
    'CONEXION REAL PARA EL SERVER
    Public conectionString As String = "Server=192.168.50.10;Database=DBCallCenter;UserId=rootdb;Password=;"
    'CONEXION FALSA PARA LAS PRUEBAS
    'Public conectionString As String = "Server=localhost;Database=DBCallCenterSafe1;UserId=root;Password=root;"
    Public connection As New MySqlConnection(conectionString)

    Public id_usuario As Integer

End Module
