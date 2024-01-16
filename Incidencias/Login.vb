Imports MySql.Data.MySqlClient

Public Class Login


    Public Class Usuario
        Public Property NombreUsuario As String
        Public Property Contrasena As String
        Public Property IngVentana As String
    End Class

    Private Usuarios As New List(Of Usuario)()

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar algunos usuarios de ejemplo
        Usuarios.Add(New Usuario With {.NombreUsuario = "usuario1", .Contrasena = "contraseña1", .IngVentana = "ingventana1"})
        Usuarios.Add(New Usuario With {.NombreUsuario = "usuario2", .Contrasena = "contraseña2", .IngVentana = "ingventana2"})
        ' Puedes agregar más usuarios según sea necesario

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ' Verificar el inicio de sesión
        Dim nombreUsuario = txtUser.Text
        Dim contrasena = txtPass.Text

        'Dim usuario = Usuarios.FirstOrDefault(Function(u) u.NombreUsuario = nombreUsuario AndAlso u.Contrasena = contrasena)

        Try

            connection.Open()

            Dim query As String = "SELECT Tipo_Usuario FROM usuario WHERE Nombre=@nombreUsuario AND Pass=@contrasena"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
            cmd.Parameters.AddWithValue("@contrasena", contrasena)

            Dim tipousuario As Object = cmd.ExecuteScalar()
            'MessageBox.Show(tipousuario)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()


            If reader.HasRows Then
                'MessageBox.Show("Inicio de sesión exitoso")
                ' Aquí puedes abrir el formulario principal o realizar otras acciones después del inicio de sesión exitoso
                If tipousuario IsNot Nothing Then
                    tipousuario.ToString()

                    AbrirVentana(tipousuario)
                End If
            Else
                MessageBox.Show("Credenciales incorrectas")
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()

        End Try

    End Sub

    Private Sub AbrirVentana(ingVentana As String)
        ' Según el valor de ingVentana, abrir la ventana correspondiente
        If ingVentana = "2" Then
            Dim ventana1 As New Form1()
            ventana1.Show()
        ElseIf ingVentana = "1" Then
            Dim ventana2 As New Listainsidentes()
            ventana2.Show()
        End If


    End Sub


End Class