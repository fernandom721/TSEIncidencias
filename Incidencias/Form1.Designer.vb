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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 485)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtDetalles
        '
        Me.txtDetalles.Location = New System.Drawing.Point(23, 332)
        Me.txtDetalles.Multiline = True
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDetalles.Size = New System.Drawing.Size(597, 60)
        Me.txtDetalles.TabIndex = 16
        '
        'lbDetalles
        '
        Me.lbDetalles.AutoSize = True
        Me.lbDetalles.Location = New System.Drawing.Point(20, 297)
        Me.lbDetalles.Name = "lbDetalles"
        Me.lbDetalles.Size = New System.Drawing.Size(57, 16)
        Me.lbDetalles.TabIndex = 15
        Me.lbDetalles.Text = "Detalles"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(419, 444)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'CombMunicipio
        '
        Me.CombMunicipio.FormattingEnabled = True
        Me.CombMunicipio.Location = New System.Drawing.Point(231, 86)
        Me.CombMunicipio.Name = "CombMunicipio"
        Me.CombMunicipio.Size = New System.Drawing.Size(146, 24)
        Me.CombMunicipio.TabIndex = 9
        '
        'CombCentroVotacion
        '
        Me.CombCentroVotacion.FormattingEnabled = True
        Me.CombCentroVotacion.Location = New System.Drawing.Point(683, 86)
        Me.CombCentroVotacion.Name = "CombCentroVotacion"
        Me.CombCentroVotacion.Size = New System.Drawing.Size(159, 24)
        Me.CombCentroVotacion.TabIndex = 7
        '
        'CombDistrito
        '
        Me.CombDistrito.FormattingEnabled = True
        Me.CombDistrito.Location = New System.Drawing.Point(449, 86)
        Me.CombDistrito.Name = "CombDistrito"
        Me.CombDistrito.Size = New System.Drawing.Size(143, 24)
        Me.CombDistrito.TabIndex = 6
        '
        'CombDepartamento
        '
        Me.CombDepartamento.FormattingEnabled = True
        Me.CombDepartamento.Location = New System.Drawing.Point(23, 86)
        Me.CombDepartamento.Name = "CombDepartamento"
        Me.CombDepartamento.Size = New System.Drawing.Size(145, 24)
        Me.CombDepartamento.TabIndex = 5
        '
        'lbCentroVotacion
        '
        Me.lbCentroVotacion.AutoSize = True
        Me.lbCentroVotacion.Location = New System.Drawing.Point(680, 36)
        Me.lbCentroVotacion.Name = "lbCentroVotacion"
        Me.lbCentroVotacion.Size = New System.Drawing.Size(119, 16)
        Me.lbCentroVotacion.TabIndex = 3
        Me.lbCentroVotacion.Text = "Centro de votacion"
        '
        'lbDistrito
        '
        Me.lbDistrito.AutoSize = True
        Me.lbDistrito.Location = New System.Drawing.Point(446, 36)
        Me.lbDistrito.Name = "lbDistrito"
        Me.lbDistrito.Size = New System.Drawing.Size(48, 16)
        Me.lbDistrito.TabIndex = 2
        Me.lbDistrito.Text = "Distrito"
        '
        'lbMunicipio
        '
        Me.lbMunicipio.AutoSize = True
        Me.lbMunicipio.Location = New System.Drawing.Point(228, 36)
        Me.lbMunicipio.Name = "lbMunicipio"
        Me.lbMunicipio.Size = New System.Drawing.Size(64, 16)
        Me.lbMunicipio.TabIndex = 1
        Me.lbMunicipio.Text = "Municipio"
        '
        'lbDepartamento
        '
        Me.lbDepartamento.AutoSize = True
        Me.lbDepartamento.Location = New System.Drawing.Point(20, 36)
        Me.lbDepartamento.Name = "lbDepartamento"
        Me.lbDepartamento.Size = New System.Drawing.Size(93, 16)
        Me.lbDepartamento.TabIndex = 0
        Me.lbDepartamento.Text = "Departamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Direccion"
        '
        'Direccion
        '
        Me.Direccion.Location = New System.Drawing.Point(23, 202)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(585, 22)
        Me.Direccion.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 519)
        Me.Controls.Add(Me.GroupBox1)
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
