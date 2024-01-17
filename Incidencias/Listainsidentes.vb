Imports MySql.Data.MySqlClient

Public Class Listainsidentes

    Dim dataTable As New DataTable()

    ''

    ' ...


    ' ...
    ''

    Private nombreUsuario As Integer

    Private Sub Listainsidentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configurar el usuario actual (esto puede variar según cómo obtengas el usuario después del inicio de sesión)
        ObtenerUsuarioActual()

        dataTable.Columns.Add("ID", GetType(Integer))
        dataTable.Columns.Add("Centro Votacion", GetType(String))
        dataTable.Columns.Add("Detalle", GetType(String))
        dataTable.Columns.Add("Estado", GetType(String))
        dataTable.Columns.Add("Entidad", GetType(String))

        dataTable.Rows.Add(1, "CV3", "detalle1", "activo5")
        dataTable.Rows.Add(2, "CV4", "detalle2", "activo5")
        dataTable.Rows.Add(3, "CV4", "detalle1", "activo6")
        dataTable.Rows.Add(4, "CV3", "detalle2", "activo6")
        dataTable.Rows.Add(5, "COT", "detalle3", "activo7")
        dataTable.Rows.Add(6, "Log", "detalle4", "activo8")


        DataGridView1.DataSource = dataTable

        ' Filtrar las filas del DataTable basado en el usuario actual
        Dim filasFiltradas() As DataRow = FiltrarFilasPorTipoUsuario(nombreUsuario)

        ' Crear un nuevo DataTable con las filas filtradas
        Dim dataTableFiltrado As New DataTable()
        If filasFiltradas.Length > 0 Then
            dataTableFiltrado = filasFiltradas.CopyToDataTable()
        Else
            ' Si no hay coincidencias, crear un DataTable vacío con la misma estructura
            dataTableFiltrado = dataTable.Clone()
        End If

        ' Asignar el DataTable filtrado al DataGridView
        DataGridView1.DataSource = dataTableFiltrado
    End Sub

    ' Método para filtrar las filas del DataTable basado en el usuario
    Private Function FiltrarFilasPorTipoUsuario(tipoUsuario As Integer) As DataRow()
        ' Ejemplo de lógica de filtrado, ajusta según tu estructura de datos
        Select Case tipoUsuario
            Case 1
                Return dataTable.Select("[ID] IN (1, 2)")
            Case 2
                Return dataTable.Select("[ID] IN (3, 4)")
            Case Else
                Return New DataRow() {} ' 
        End Select
    End Function

    ' Método ficticio para obtener el usuario actual (debes adaptarlo según tu sistema de inicio de sesión)


    Private idUsuarioActual As Integer
    Private tipoUsuarioActual As String

    ' ...

    ' Método ficticio para obtener el ID y el Tipo de usuario actual (ajusta según tu sistema de inicio de sesión)
    Private Sub ObtenerUsuarioActual()
        ' Ejemplo: Supongamos que tienes una tabla de usuarios con columnas 'ID' y 'TipoUsuario'
        Dim query As String = "SELECT ID_USUARIO, Tipo_Usuario FROM Usuario"
        ' Aquí deberías ejecutar tu consulta SQL para obtener el ID y el TipoUsuario según el nombre de usuario y la contraseña
        ' ..

        Using command As New MySqlCommand(query, connection)
            Try
                ' Open the connection
                connection.Open()

                ' Execute the query and get the result
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Check if there are rows in the result
                If reader.HasRows Then
                    ' Loop through the rows
                    While reader.Read()
                        ' Access data using reader
                        Dim column1Value As Integer = reader.GetInt32(0) ' Assuming the first column is of type string
                        Dim column2Value As Integer = reader.GetInt32(1) ' Assuming the second column is of type integer

                        ' Do something with the data
                        ' For example, display it in a MessageBox
                        MessageBox.Show($"Column 1: {column1Value}, Column 2: {column2Value}")
                    End While
                Else
                    MessageBox.Show("No rows found.")
                End If

                ' Close the reader
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using



        ' Establecer los valores obtenidos en las variables de la clase
        idUsuarioActual = 1 ' Reemplaza con el valor obtenido de la base de datos
        tipoUsuarioActual = 2 ' Reemplaza con el valor obtenido de la base de datos
    End Sub


    'End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        ' texto de bisqueda
        Dim buscador As String = txb_buscar.Text.Trim()


        ' Filtrar las filas del DataTable basado en el término de búsqueda
        Dim filasFiltradas() As DataRow = dataTable.Select($"[Centro Votacion] LIKE '%{buscador}%'")

        ' Crear un nuevo DataTable con las filas filtradas
        Dim dataTableFiltrado As New DataTable()
        If filasFiltradas.Length > 0 Then
            dataTableFiltrado = filasFiltradas.CopyToDataTable()
        Else
            ' Si no hay coincidencias, crear un DataTable vacío con la misma estructura
            dataTableFiltrado = dataTable.Clone()
        End If

        ' Asignar el DataTable filtrado al DataGridView
        DataGridView1.DataSource = dataTableFiltrado

    End Sub

    Private Sub btn_selectIns_Click(sender As Object, e As EventArgs) Handles btn_selectIns.Click

        ' Verificar si se hizo clic en el botón de la celda deseada (puedes cambiar el índice de la columna según tu diseño)
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtener la primera fila seleccionada (puedes ajustar esto si permites la selección múltiple)
            Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)


            ' Obtener los valores de las celdas necesarias (puedes cambiar los índices de las columnas según tu diseño)
            Dim id As Integer = Convert.ToInt32(filaSeleccionada.Cells("ID").Value)
            Dim centroVotacion As String = filaSeleccionada.Cells("Centro Votacion").Value.ToString()
            Dim detalle As String = filaSeleccionada.Cells("Detalle").Value.ToString()
            Dim estado As String = filaSeleccionada.Cells("Estado").Value.ToString()

            ' Crear una nueva instancia de la ventana de detalles y pasar la información
            Dim ventanaDetalles As New Detalle_Insidencia(id, centroVotacion, detalle, estado)

            ' Mostrar la ventana de detalles
            ventanaDetalles.Show()
        Else
            ' Mostrar un mensaje de advertencia si no hay filas seleccionadas
            MessageBox.Show("Por favor, selecciona una fila antes de hacer clic en 'Seleccionar'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click

    End Sub


End Class