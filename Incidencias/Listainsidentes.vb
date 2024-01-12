Public Class Listainsidentes

    Dim dataTable As New DataTable()
    Private Sub Listainsidentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dataTable.Columns.Add("ID", GetType(Integer))
        DataTable.Columns.Add("Centro Votacion", GetType(String))
        DataTable.Columns.Add("Detalle", GetType(String))
        DataTable.Columns.Add("Estado", GetType(String))

        DataTable.Rows.Add(1, "CV3", "detalle1", "activo5")
        DataTable.Rows.Add(2, "CV4", "detalle2", "activo5")
        DataTable.Rows.Add(3, "CV4", "detalle1", "activo6")
        DataTable.Rows.Add(4, "CV3", "detalle2", "activo6")

        DataGridView1.DataSource = DataTable
    End Sub

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

    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click

    End Sub

End Class