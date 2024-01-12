<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle_Insidencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CentroVotacion = New System.Windows.Forms.TextBox()
        Me.InsDetalle = New System.Windows.Forms.TextBox()
        Me.INSEstado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(694, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'CentroVotacion
        '
        Me.CentroVotacion.Location = New System.Drawing.Point(98, 96)
        Me.CentroVotacion.Name = "CentroVotacion"
        Me.CentroVotacion.Size = New System.Drawing.Size(100, 22)
        Me.CentroVotacion.TabIndex = 3
        '
        'InsDetalle
        '
        Me.InsDetalle.Location = New System.Drawing.Point(377, 96)
        Me.InsDetalle.Name = "InsDetalle"
        Me.InsDetalle.Size = New System.Drawing.Size(100, 22)
        Me.InsDetalle.TabIndex = 4
        '
        'INSEstado
        '
        Me.INSEstado.Location = New System.Drawing.Point(697, 95)
        Me.INSEstado.Name = "INSEstado"
        Me.INSEstado.Size = New System.Drawing.Size(100, 22)
        Me.INSEstado.TabIndex = 5
        '
        'Detalle_Insidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 527)
        Me.Controls.Add(Me.INSEstado)
        Me.Controls.Add(Me.InsDetalle)
        Me.Controls.Add(Me.CentroVotacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Detalle_Insidencia"
        Me.Text = "Detalle_Insidencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CentroVotacion As TextBox
    Friend WithEvents InsDetalle As TextBox
    Friend WithEvents INSEstado As TextBox
End Class
