<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDetalles = New System.Windows.Forms.TextBox()
        Me.lbDetalles = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.CombMunicipio = New System.Windows.Forms.ComboBox()
        Me.CombCentroVotacion = New System.Windows.Forms.ComboBox()
        Me.CombDistrito = New System.Windows.Forms.ComboBox()
        Me.CombDepartamento = New System.Windows.Forms.ComboBox()
        Me.lbCentroVotacion = New System.Windows.Forms.Label()
        Me.lbDistrito = New System.Windows.Forms.Label()
        Me.lbMunicipio = New System.Windows.Forms.Label()
        Me.lbDepartamento = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Direccion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDetalles)
        Me.GroupBox1.Controls.Add(Me.lbDetalles)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.CombMunicipio)
        Me.GroupBox1.Controls.Add(Me.CombCentroVotacion)
        Me.GroupBox1.Controls.Add(Me.CombDistrito)
        Me.GroupBox1.Controls.Add(Me.CombDepartamento)
        Me.GroupBox1.Controls.Add(Me.lbCentroVotacion)
        Me.GroupBox1.Controls.Add(Me.lbDistrito)
        Me.GroupBox1.Controls.Add(Me.lbMunicipio)
        Me.GroupBox1.Controls.Add(Me.lbDepartamento)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(699, 401)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Direccion
        '
        Me.Direccion.Location = New System.Drawing.Point(17, 164)
        Me.Direccion.Margin = New System.Windows.Forms.Padding(2)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(440, 20)
        Me.Direccion.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Direccion"
        '
        'txtDetalles
        '
        Me.txtDetalles.Location = New System.Drawing.Point(17, 270)
        Me.txtDetalles.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDetalles.Multiline = True
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDetalles.Size = New System.Drawing.Size(449, 50)
        Me.txtDetalles.TabIndex = 16
        '
        'lbDetalles
        '
        Me.lbDetalles.AutoSize = True
        Me.lbDetalles.Location = New System.Drawing.Point(15, 241)
        Me.lbDetalles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDetalles.Name = "lbDetalles"
        Me.lbDetalles.Size = New System.Drawing.Size(45, 13)
        Me.lbDetalles.TabIndex = 15
        Me.lbDetalles.Text = "Detalles"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(314, 361)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(56, 19)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'CombMunicipio
        '
        Me.CombMunicipio.FormattingEnabled = True
        Me.CombMunicipio.Location = New System.Drawing.Point(173, 70)
        Me.CombMunicipio.Margin = New System.Windows.Forms.Padding(2)
        Me.CombMunicipio.Name = "CombMunicipio"
        Me.CombMunicipio.Size = New System.Drawing.Size(110, 21)
        Me.CombMunicipio.TabIndex = 9
        '
        'CombCentroVotacion
        '
        Me.CombCentroVotacion.FormattingEnabled = True
        Me.CombCentroVotacion.Location = New System.Drawing.Point(512, 70)
        Me.CombCentroVotacion.Margin = New System.Windows.Forms.Padding(2)
        Me.CombCentroVotacion.Name = "CombCentroVotacion"
        Me.CombCentroVotacion.Size = New System.Drawing.Size(120, 21)
        Me.CombCentroVotacion.TabIndex = 7
        '
        'CombDistrito
        '
        Me.CombDistrito.FormattingEnabled = True
        Me.CombDistrito.Location = New System.Drawing.Point(337, 70)
        Me.CombDistrito.Margin = New System.Windows.Forms.Padding(2)
        Me.CombDistrito.Name = "CombDistrito"
        Me.CombDistrito.Size = New System.Drawing.Size(108, 21)
        Me.CombDistrito.TabIndex = 6
        '
        'CombDepartamento
        '
        Me.CombDepartamento.FormattingEnabled = True
        Me.CombDepartamento.Location = New System.Drawing.Point(17, 70)
        Me.CombDepartamento.Margin = New System.Windows.Forms.Padding(2)
        Me.CombDepartamento.Name = "CombDepartamento"
        Me.CombDepartamento.Size = New System.Drawing.Size(110, 21)
        Me.CombDepartamento.TabIndex = 5
        '
        'lbCentroVotacion
        '
        Me.lbCentroVotacion.AutoSize = True
        Me.lbCentroVotacion.Location = New System.Drawing.Point(510, 29)
        Me.lbCentroVotacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCentroVotacion.Name = "lbCentroVotacion"
        Me.lbCentroVotacion.Size = New System.Drawing.Size(97, 13)
        Me.lbCentroVotacion.TabIndex = 3
        Me.lbCentroVotacion.Text = "Centro de votacion"
        '
        'lbDistrito
        '
        Me.lbDistrito.AutoSize = True
        Me.lbDistrito.Location = New System.Drawing.Point(334, 29)
        Me.lbDistrito.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDistrito.Name = "lbDistrito"
        Me.lbDistrito.Size = New System.Drawing.Size(39, 13)
        Me.lbDistrito.TabIndex = 2
        Me.lbDistrito.Text = "Distrito"
        '
        'lbMunicipio
        '
        Me.lbMunicipio.AutoSize = True
        Me.lbMunicipio.Location = New System.Drawing.Point(171, 29)
        Me.lbMunicipio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMunicipio.Name = "lbMunicipio"
        Me.lbMunicipio.Size = New System.Drawing.Size(52, 13)
        Me.lbMunicipio.TabIndex = 1
        Me.lbMunicipio.Text = "Municipio"
        '
        'lbDepartamento
        '
        Me.lbDepartamento.AutoSize = True
        Me.lbDepartamento.Location = New System.Drawing.Point(15, 29)
        Me.lbDepartamento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDepartamento.Name = "lbDepartamento"
        Me.lbDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lbDepartamento.TabIndex = 0
        Me.lbDepartamento.Text = "Departamento"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 422)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbCentroVotacion As Label
    Friend WithEvents lbDistrito As Label
    Friend WithEvents lbMunicipio As Label
    Friend WithEvents lbDepartamento As Label
    Friend WithEvents CombMunicipio As ComboBox
    Friend WithEvents CombCentroVotacion As ComboBox
    Friend WithEvents CombDistrito As ComboBox
    Friend WithEvents CombDepartamento As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDetalles As TextBox
    Friend WithEvents lbDetalles As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Direccion As TextBox
End Class
