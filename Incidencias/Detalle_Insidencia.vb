Imports System.Windows.Forms.MonthCalendar
Imports MySql.Data.MySqlClient

Public Class Detalle_Insidencia

    Private _codINC As String
    Dim idEntidad As String
    Dim idEstado As String
    Public Sub New(codINC As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _codINC = codINC
    End Sub

    Private Sub Detalle_Insidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentroVotacion.ReadOnly = True
        txbDireccion.ReadOnly = True
        txbDep.ReadOnly = True
        txbMun.ReadOnly = True
        txbDis.ReadOnly = True
        txbSolicitante.ReadOnly = True
        txbContactoSol.ReadOnly = True
        txbDetalle.ReadOnly = True


        CargarDatos()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CentroVotacion_TextChanged(sender As Object, e As EventArgs) Handles CentroVotacion.TextChanged

    End Sub

    Private Sub txbDireccion_TextChanged(sender As Object, e As EventArgs) Handles txbDireccion.TextChanged

    End Sub

    Private Sub txbDep_TextChanged(sender As Object, e As EventArgs) Handles txbDep.TextChanged

    End Sub

    Private Sub txbMun_TextChanged(sender As Object, e As EventArgs) Handles txbMun.TextChanged

    End Sub

    Private Sub txbDis_TextChanged(sender As Object, e As EventArgs) Handles txbDis.TextChanged

    End Sub

    Private Sub txbSolicitante_TextChanged(sender As Object, e As EventArgs) Handles txbSolicitante.TextChanged

    End Sub

    Private Sub txbContactoSol_TextChanged(sender As Object, e As EventArgs) Handles txbContactoSol.TextChanged

    End Sub

    Private Sub cbxArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxArea.SelectedIndexChanged
        idEntidad = DirectCast(cbxArea.SelectedItem, DataRowView)("COD_ENTIDAD").ToString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        idEstado = DirectCast(ComboBox1.SelectedItem, DataRowView)("ID_ESTADO").ToString()
    End Sub

    Private Sub txbDetalle_TextChanged(sender As Object, e As EventArgs) Handles txbDetalle.TextChanged

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        connection.Open()
        Try
            Dim queryUpdate As String = $"UPDATE insidencias SET Cod_Entidad = {idEntidad}, Estado={idEstado}, 
                                    Date_inci=NOW() where COD_INSIDENCIA = {_codINC}"
            'MessageBox.Show(idEntidad & idEstado & _codINC)
            Using cmd As New MySqlCommand(queryUpdate, connection)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("La incidencia ha sido actualizada")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos: " & ex.Message)
        End Try
        connection.Close()
        Me.Close()

    End Sub

    Private Sub CargarArea()

        Dim consultaEntidades As String = "SELECT COD_ENTIDAD, Nombre_Entidad FROM entidad"
        Using adapter As New MySqlDataAdapter(consultaEntidades, connection)
            Dim tabla As New DataTable()
            adapter.Fill(tabla)

            cbxArea.DataSource = tabla
            cbxArea.DisplayMember = "Nombre_Entidad"
        End Using

        Dim consultaEstado As String = "SELECT ID_ESTADO, Nombre FROM estado"
        Using adapter As New MySqlDataAdapter(consultaEstado, connection)
            Dim tabla As New DataTable()
            adapter.Fill(tabla)

            ComboBox1.DataSource = tabla
            ComboBox1.DisplayMember = "Nombre"
        End Using

    End Sub

    Private Sub CargarDatos()

        Dim consulta As String = $"select c.Nombre as NombreCV, c.Direccion as Direccion, d2.Nombre as Departamento, m.Nombre as Municipio, d.Nombre as Distrito,
                                i.Solicitante as Solicitante, i.Contacto as Contacto, i.Detalle as Detalle, e.Nombre_Entidad as Entidad, e2.Nombre  as Estado
                                from insidencias i join centrovotacion c on i.Cod_CV=c.CODIGO_CV_FINAL 
                                join distrito d on c.COD_DIST = d.COD_DIST 
                                join municipio m on d.COD_MUN = m.COD_MUN 
                                join departamento d2 on m.COD_DEPT = d2.COD_DPTO 
                                join entidad e on i.Cod_Entidad = e.COD_ENTIDAD 
                                join estado e2 on i.Estado = e2.ID_ESTADO 
                                where i.COD_INSIDENCIA ={_codINC}"

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        CargarArea()
        Using command As New MySqlCommand(consulta, connection)
            Using lector As MySqlDataReader = command.ExecuteReader()
                If lector.Read() Then
                    CentroVotacion.Text = lector("NombreCV").ToString()
                    txbDireccion.Text = lector("Direccion").ToString()
                    txbDep.Text = lector("Departamento").ToString()
                    txbMun.Text = lector("Municipio").ToString()
                    txbDis.Text = lector("Distrito").ToString()
                    txbSolicitante.Text = lector("Solicitante").ToString()
                    txbContactoSol.Text = lector("Contacto").ToString()
                    txbDetalle.Text = lector("Detalle").ToString()
                    cbxArea.Text = lector("Entidad").ToString()
                    ComboBox1.Text = lector("Estado").ToString()
                End If
            End Using
        End Using
        connection.Close()
    End Sub


End Class