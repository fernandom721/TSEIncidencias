Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim idCV As String
    Dim idarea As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbDep.ReadOnly = True
        txbMun.ReadOnly = True
        txbDis.ReadOnly = True
        connection.Open()
        CargarDatos()
        CargarAreas()
    End Sub

    Private Sub txbCV_TextChanged(sender As Object, e As EventArgs) Handles txbCV.TextChanged

        Dim filtro As String = txbCV.Text
        If String.IsNullOrEmpty(filtro) Then
            CargarDatos()

        Else
            Dim vista As New DataView(CType(cmbCV.DataSource, DataTable))
            vista.RowFilter = $"Nombre LIKE '%{filtro}%'"
            cmbCV.DataSource = vista.ToTable()
        End If



    End Sub

    Private Sub cmbCV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCV.SelectedIndexChanged

        If cmbCV.SelectedIndex <> -1 Then

            Dim filaSeleccionada As DataRowView = CType(cmbCV.SelectedItem, DataRowView)
            ' Obtén el valor seleccionado en el ComboBox
            Dim valorSeleccionado As String = filaSeleccionada("Nombre").ToString()

            Dim consultaDetalle As String = $"SELECT d.Nombre AS NombreDistrito , 
                m.Nombre AS NombreMunicipio , d2.Nombre AS NombreDepartamento, c.CODIGO_CV_FINAL as codigocv
                FROM centrovotacion c 
                JOIN distrito d ON c.COD_DIST = d.COD_DIST 
                JOIN municipio m ON d.COD_MUN = m.COD_MUN
                JOIN departamento d2 ON m.COD_DEPT = d2.COD_DPTO
                WHERE c.Nombre = '{valorSeleccionado}'"


            Using comando As New MySqlCommand(consultaDetalle, connection)
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    If lector.Read() Then
                        txbDep.Text = lector("NombreDepartamento").ToString()
                        txbMun.Text = lector("NombreMunicipio").ToString()
                        txbDis.Text = lector("NombreDistrito").ToString()
                        idCV = lector("codigocv").ToString()

                    End If

                End Using
            End Using
        End If

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

    Private Sub txbDetalle_TextChanged(sender As Object, e As EventArgs) Handles txbDetalle.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        id_usuario = 2
        Dim solicitante As String = txbSolicitante.Text
        Dim contacto As String = txbContactoSol.Text
        Dim detalle As String = txbDetalle.Text
        Dim fechaingreso As DateTime = DateTime.Now()
        'MessageBox.Show(solicitante & contacto & detalle & fechaingreso & idCV & idarea & id_usuario)
        Try
            Dim query As String = "INSERT INTO insidencias (Solicitante, Contacto, Cod_CV, Detalle, Cod_Entidad, Estado, ID_Usuario, Date_inci) 
                        VALUES (@solicitante, @contacto, @idCV, @detalle, @idarea, 1, @id_usuario, @fechaingreso)"

            Dim command As MySqlCommand = New MySqlCommand(query, connection)

            command.Parameters.AddWithValue("@solicitante", solicitante)
            command.Parameters.AddWithValue("@contacto", contacto)
            command.Parameters.AddWithValue("@idCV", Convert.ToInt32(idCV))
            command.Parameters.AddWithValue("@detalle", detalle)
            command.Parameters.AddWithValue("@idarea", Convert.ToInt32(idarea))
            command.Parameters.AddWithValue("@id_usuario", Convert.ToInt32(id_usuario))
            command.Parameters.AddWithValue("@fechaingreso", fechaingreso)

            command.ExecuteNonQuery()
            MessageBox.Show("Incidencias ingresada con exito")
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message)
        End Try

    End Sub

    Private Sub cbxArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxArea.SelectedIndexChanged
        idarea = DirectCast(cbxArea.SelectedItem, DataRowView)("COD_ENTIDAD").ToString()
    End Sub

    Public Sub CargarAreas()
        Dim consultaarea As String = "SELECT Nombre_Entidad, COD_ENTIDAD FROM entidad  WHERE COD_ENTIDAD < 5"
        Using adapter2 As New MySqlDataAdapter(consultaarea, connection)
            Dim tabla As New DataTable()
            adapter2.Fill(tabla)

            cbxArea.DataSource = tabla
            cbxArea.DisplayMember = "Nombre_Entidad"

        End Using

        AddHandler cbxArea.SelectedIndexChanged, AddressOf cbxArea_SelectedIndexChanged
    End Sub

    Private Sub CargarDatos()

        Dim consulta As String = "SELECT Nombre, CODIGO_CV_FINAL FROM centrovotacion"
        Using adapter As New MySqlDataAdapter(consulta, connection)
            Dim tabla As New DataTable()
            adapter.Fill(tabla)

            cmbCV.DataSource = tabla
            cmbCV.DisplayMember = "Nombre"

        End Using
    End Sub

End Class
