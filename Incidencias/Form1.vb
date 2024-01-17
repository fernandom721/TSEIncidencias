Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbDep.ReadOnly = True
        txbMun.ReadOnly = True
        txbDis.ReadOnly = True
        connection.Open()
        CargarDatos()
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
                m.Nombre AS NombreMunicipio , d2.Nombre AS NombreDepartamento
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

    End Sub

    Private Sub CargarDatos()

        Dim consulta As String = "SELECT Nombre FROM centrovotacion"
        Using adapter As New MySqlDataAdapter(consulta, connection)
            Dim tabla As New DataTable()
            adapter.Fill(tabla)

            cmbCV.DataSource = tabla
            cmbCV.DisplayMember = "Nombre"
        End Using

    End Sub



End Class
