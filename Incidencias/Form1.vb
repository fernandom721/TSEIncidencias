Imports System.Data.SqlClient

Public Class Form1
    ' Conexión a la base de datos
    Dim connectionString As String = "Data Source=TuServidor;Initial Catalog=;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar el formulario, cargar los departamentos en el primer ComboBox
        CargarDepartamentos()
    End Sub

    Private Sub CargarDepartamentos()
        ' cargar los departamentos base de datos
        Dim departamentos As String() = {"Departamento1", "Departamento2", "Departamento3"}
        CargarEntidades()
        ' Llenar el ComboBox de departamentos
        CombDepartamento.Items.AddRange(departamentos)
    End Sub

    Private Sub CargarEntidades()

        Dim entidades As String() = {"CPPT", "CGE", "CNPRE", "Logistica"}

    End Sub
    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CombDepartamento.SelectedIndexChanged
        ' cargar los municipios en el segundo ComboBox
        CargarMunicipios()
    End Sub

    Private Sub CargarMunicipios()
        ' municipios relacionados con el departamento seleccionado

        Dim municipios As String() = {"Municipio1", "Municipio2", "Municipio3"}

        ' Llenar el ComboBox de municipios
        CombMunicipio.Items.Clear()
        CombMunicipio.Items.AddRange(municipios)
    End Sub

    Private Sub cmbMunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CombMunicipio.SelectedIndexChanged
        ' cargar los distritos en el tercer ComboBox
        CargarDistritos()
    End Sub

    Private Sub CargarDistritos()
        ' cargar los distritos relacionados con el municipio seleccionado

        Dim distritos As String() = {"Distrito1", "Distrito2", "Distrito3"}

        ' Llenar el ComboBox de distritos
        CombDistrito.Items.Clear()
        CombDistrito.Items.AddRange(distritos)
    End Sub

    'Private Sub CargarEntidades()
    ' Aquí deberías cargar las entidades desde tu base de datos o de alguna otra fuente
    ' Puedes modificar esto según la estructura de tu base de datos
    'Dim entidades As String() = {"CPPT", "CGE", "CNPRE", "Logistica"}

    ' Llenar el ComboBox de entidades
    ' combEntidad.Items.Clear()
    '  combEntidad.Items.AddRange(entidades)
    ' End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If CombDepartamento.SelectedItem IsNot Nothing AndAlso
           CombMunicipio.SelectedItem IsNot Nothing AndAlso
           CombDistrito.SelectedItem IsNot Nothing Then
            ' obtener valores seleccionados
            Dim departamento As String = CombDepartamento.SelectedItem.ToString()
            Dim municipio As String = CombMunicipio.SelectedItem.ToString()
            Dim distrito As String = CombDistrito.SelectedItem.ToString()
            'Dim entidad As String = combEntidad.SelectedItem.ToString()

            ' Generar la ruta y secuencia
            Dim ruta As String = $"{departamento}\{municipio}\{distrito}"
            Dim secuencia As String = GenerarSecuencia()


        Else
            MessageBox.Show("Por favor, selecciona un valor en cada ComboBox antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GenerarSecuencia() As String

        Return DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Sub Direccion_TextChanged(sender As Object, e As EventArgs) Handles Direccion.TextChanged

    End Sub
End Class
