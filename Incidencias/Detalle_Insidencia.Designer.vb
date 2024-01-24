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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxArea = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txbDetalle = New System.Windows.Forms.TextBox()
        Me.Detalle = New System.Windows.Forms.Label()
        Me.txbContactoSol = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbSolicitante = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbDis = New System.Windows.Forms.TextBox()
        Me.txbMun = New System.Windows.Forms.TextBox()
        Me.txbDep = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBoxCV = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(386, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Centro de Votacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(402, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 37)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Detalle Incidencia"
        '
        'cbxArea
        '
        Me.cbxArea.FormattingEnabled = True
        Me.cbxArea.Location = New System.Drawing.Point(718, 385)
        Me.cbxArea.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxArea.Name = "cbxArea"
        Me.cbxArea.Size = New System.Drawing.Size(258, 28)
        Me.cbxArea.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(718, 357)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Area Asignada"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(393, 671)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(240, 54)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Guardar Cambios"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txbDetalle
        '
        Me.txbDetalle.Location = New System.Drawing.Point(56, 526)
        Me.txbDetalle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txbDetalle.Multiline = True
        Me.txbDetalle.Name = "txbDetalle"
        Me.txbDetalle.Size = New System.Drawing.Size(920, 133)
        Me.txbDetalle.TabIndex = 31
        '
        'Detalle
        '
        Me.Detalle.AutoSize = True
        Me.Detalle.Location = New System.Drawing.Point(51, 502)
        Me.Detalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Size = New System.Drawing.Size(59, 20)
        Me.Detalle.TabIndex = 30
        Me.Detalle.Text = "Detalle"
        '
        'txbContactoSol
        '
        Me.txbContactoSol.Location = New System.Drawing.Point(390, 383)
        Me.txbContactoSol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txbContactoSol.Name = "txbContactoSol"
        Me.txbContactoSol.Size = New System.Drawing.Size(258, 26)
        Me.txbContactoSol.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(390, 358)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Contacto de Solicitante"
        '
        'txbSolicitante
        '
        Me.txbSolicitante.Location = New System.Drawing.Point(56, 385)
        Me.txbSolicitante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txbSolicitante.Name = "txbSolicitante"
        Me.txbSolicitante.Size = New System.Drawing.Size(258, 26)
        Me.txbSolicitante.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 358)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Solicitante"
        '
        'txbDis
        '
        Me.txbDis.Location = New System.Drawing.Point(718, 282)
        Me.txbDis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txbDis.Name = "txbDis"
        Me.txbDis.Size = New System.Drawing.Size(258, 26)
        Me.txbDis.TabIndex = 25
        '
        'txbMun
        '
        Me.txbMun.Location = New System.Drawing.Point(390, 282)
        Me.txbMun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txbMun.Name = "txbMun"
        Me.txbMun.Size = New System.Drawing.Size(258, 26)
        Me.txbMun.TabIndex = 24
        '
        'txbDep
        '
        Me.txbDep.Location = New System.Drawing.Point(56, 282)
        Me.txbDep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txbDep.Name = "txbDep"
        Me.txbDep.Size = New System.Drawing.Size(258, 26)
        Me.txbDep.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(714, 257)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Distrito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 257)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 257)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Departamento"
        '
        'txbDireccion
        '
        Me.txbDireccion.Location = New System.Drawing.Point(56, 200)
        Me.txbDireccion.Name = "txbDireccion"
        Me.txbDireccion.Size = New System.Drawing.Size(920, 26)
        Me.txbDireccion.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Direccion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 428)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 20)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Estado Incidente"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(56, 452)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 28)
        Me.ComboBox1.TabIndex = 38
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(55, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 26)
        Me.TextBox1.TabIndex = 39
        '
        'ComboBoxCV
        '
        Me.ComboBoxCV.FormattingEnabled = True
        Me.ComboBoxCV.Location = New System.Drawing.Point(390, 113)
        Me.ComboBoxCV.Name = "ComboBoxCV"
        Me.ComboBoxCV.Size = New System.Drawing.Size(586, 28)
        Me.ComboBoxCV.TabIndex = 40
        '
        'Detalle_Insidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 749)
        Me.Controls.Add(Me.ComboBoxCV)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txbDireccion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbxArea)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txbDetalle)
        Me.Controls.Add(Me.Detalle)
        Me.Controls.Add(Me.txbContactoSol)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbSolicitante)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txbDis)
        Me.Controls.Add(Me.txbMun)
        Me.Controls.Add(Me.txbDep)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Detalle_Insidencia"
        Me.Text = "Detalle_Insidencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxArea As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txbDetalle As TextBox
    Friend WithEvents Detalle As Label
    Friend WithEvents txbContactoSol As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txbSolicitante As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbDis As TextBox
    Friend WithEvents txbMun As TextBox
    Friend WithEvents txbDep As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBoxCV As ComboBox
End Class
