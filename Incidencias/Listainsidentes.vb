Imports MySql.Data.MySqlClient

Public Class Listainsidentes
    Private codINC As String
    Dim timer As New Timer()

    Private Sub Listainsidentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DataGridView1.AutoGenerateColumns = True

        updatetimer()
        CargarDatos()


    End Sub

    Private Sub Listaididentes_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If e.RowIndex >= 0 Then
            codINC = DataGridView1.Rows(e.RowIndex).Cells("codINS").Value.ToString()
        End If

    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs)
        If Not ActiveForm Is Nothing AndAlso ActiveForm.Name = "Detalle_Insidencia" AndAlso ActiveForm.Visible Then
            ' El formulario que estás buscando está activo y visible
            ' Realiza las acciones que necesitas hacer cuando el formulario está activo y visible
            timer.Stop()
        Else
            ' El formulario no está activo o no está visible
            timer.Start()
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs)

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

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CargarDatos()
        Try
            connection.Open()
            Dim consulta As String = "select i.COD_INSIDENCIA as codINS, c.CODIGO_CV_FINAL as CV, c.Nombre as CVNombre, i.Detalle as Detalle, i.Date_inci as Fecha, e.Nombre as Estado
                                    from centrovotacion c join insidencias i on c.CODIGO_CV_FINAL = i.Cod_CV 
                                    join usuario u on u.COD_ENTIDAD = i.Cod_Entidad 
                                    join estado e on e.ID_ESTADO = i.Estado 
                                    where i.Estado < 3 and u.ID_USUARIO = @id_usuario
                                    order by i.Estado  asc ,Date_inci asc "
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim filtro As String = TextBox1.Text.Trim()

        If filtro <> "" Then
            timer.Stop()
            Dim dv As New DataView(CType(DataGridView1.DataSource, DataTable))
            Dim filtroExpresion As String = String.Format("Convert(codINS, 'System.String') LIKE '%{0}%' OR CVNombre LIKE '%{0}%' OR Detalle LIKE '%{0}%' OR Convert(Fecha, 'System.String') LIKE '%{0}%' OR Estado LIKE '%{0}%'", filtro)
            dv.RowFilter = filtroExpresion

            ' Crear un DataTable temporal y asignar el DataView filtrado
            Dim dtFiltrado As DataTable = dv.ToTable()
            DataGridView1.DataSource = dtFiltrado
        Else
            ' Si el cuadro de texto está vacío, vuelve a cargar todos los datos
            timer.Start()
            CargarDatos()
        End If

    End Sub

    Private Sub updatetimer()
        timer.Interval = 5000
        AddHandler timer.Tick, AddressOf CargarDatos
        timer.Start()
    End Sub
End Class