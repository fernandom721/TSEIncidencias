Public Class Detalle_Insidencia
    Private Sub CentroVotacion_TextChanged(sender As Object, e As EventArgs) Handles CentroVotacion.TextChanged

    End Sub

    Private Sub InsDetalle_TextChanged(sender As Object, e As EventArgs) Handles InsDetalle.TextChanged

    End Sub

    Private Sub INSEstado_TextChanged(sender As Object, e As EventArgs) Handles INSEstado.TextChanged

    End Sub

    Public Sub New(id As Integer, CV As String, detalle As String, estado As String)
        ' Lógica para inicializar la ventana con la información proporcionada
        InitializeComponent()

        ' Puedes asignar los valores a los controles de tu ventana (por ejemplo, TextBoxes)
        'txtId.Text = id.ToString()
        CentroVotacion.Text = CV
        InsDetalle.Text = detalle
        INSEstado.Text = estado
    End Sub

End Class