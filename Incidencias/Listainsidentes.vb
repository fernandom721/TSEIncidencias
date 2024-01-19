Imports MySql.Data.MySqlClient

Public Class Listainsidentes
    Private codINC As String
    Private Sub Listainsidentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DataGridView1.AutoGenerateColumns = True
        Dim timer As New Timer()
        timer.Interval = 5000
        AddHandler timer.Tick, AddressOf CargarDatos
        timer.Start()

        CargarDatos()

    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If e.RowIndex >= 0 Then
            codINC = DataGridView1.Rows(e.RowIndex).Cells("codINS").Value.ToString()
        End If

    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

    End Sub

    Private Sub btn_selectIns_Click(sender As Object, e As EventArgs) Handles btn_selectIns.Click
        'MessageBox.Show(codINC)
        If Not String.IsNullOrEmpty(codINC) Then
            Dim formedit As New Detalle_Insidencia(codINC)
            formedit.Show()
        Else
            MessageBox.Show("Por favor, seleccione una fila antes de hacer clic en el botón.")
        End If
    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click

    End Sub

    Private Sub CargarDatos()
        Try
            connection.Open()
            Dim consulta As String = "select i.COD_INSIDENCIA as codINS, c.CODIGO_CV_FINAL as CV, c.Nombre as CVNombre, i.Detalle as Detalle, i.Date_inci as Fecha
                                    from centrovotacion c join insidencias i on c.CODIGO_CV_FINAL = i.Cod_CV 
                                    join usuario u on u.COD_ENTIDAD = i.Cod_Entidad 
                                    where i.Estado < 3 and u.ID_USUARIO = @id_usuario
                                    order by Date_inci asc "
            Dim cmp As New MySqlDataAdapter(consulta, connection)
            cmp.SelectCommand.Parameters.AddWithValue("@id_usuario", id_usuario)

            Dim dataset As New DataSet()

            ' Llenar el conjunto de datos con los datos de la consulta
            cmp.Fill(dataset, "CentroVotacionIncidentes")

            ' Asignar el conjunto de datos como origen de datos para el DataGridView
            DataGridView1.DataSource = dataset.Tables("CentroVotacionIncidentes")


        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
        connection.Close()

    End Sub


End Class