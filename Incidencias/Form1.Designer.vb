<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbCV = New System.Windows.Forms.TextBox()
        Me.cmbCV = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbDep = New System.Windows.Forms.TextBox()
        Me.txbMun = New System.Windows.Forms.TextBox()
        Me.txbDis = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbSolicitante = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbContactoSol = New System.Windows.Forms.TextBox()
        Me.Detalle = New System.Windows.Forms.Label()
        Me.txbDetalle = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar Nuevo Incidente"
        '
        'txbCV
        '
        Me.txbCV.Location = New System.Drawing.Point(47, 70)
        Me.txbCV.Name = "txbCV"
        Me.txbCV.Size = New System.Drawing.Size(198, 20)
        Me.txbCV.TabIndex = 1
        '
        'cmbCV
        '
        Me.cmbCV.FormattingEnabled = True
        Me.cmbCV.Location = New System.Drawing.Point(279, 70)
        Me.cmbCV.Name = "cmbCV"
        Me.cmbCV.Size = New System.Drawing.Size(342, 21)
        Me.cmbCV.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingresar Centro de Votacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Municipio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(486, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Distrito"
        '
        'txbDep
        '
        Me.txbDep.Location = New System.Drawing.Point(47, 148)
        Me.txbDep.Name = "txbDep"
        Me.txbDep.Size = New System.Drawing.Size(173, 20)
        Me.txbDep.TabIndex = 7
        '
        'txbMun
        '
        Me.txbMun.Location = New System.Drawing.Point(270, 148)
        Me.txbMun.Name = "txbMun"
        Me.txbMun.Size = New System.Drawing.Size(173, 20)
        Me.txbMun.TabIndex = 8
        '
        'txbDis
        '
        Me.txbDis.Location = New System.Drawing.Point(489, 148)
        Me.txbDis.Name = "txbDis"
        Me.txbDis.Size = New System.Drawing.Size(173, 20)
        Me.txbDis.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Solicitante"
        '
        'txbSolicitante
        '
        Me.txbSolicitante.Location = New System.Drawing.Point(47, 215)
        Me.txbSolicitante.Name = "txbSolicitante"
        Me.txbSolicitante.Size = New System.Drawing.Size(173, 20)
        Me.txbSolicitante.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Contacto de Solicitante"
        '
        'txbContactoSol
        '
        Me.txbContactoSol.Location = New System.Drawing.Point(270, 214)
        Me.txbContactoSol.Name = "txbContactoSol"
        Me.txbContactoSol.Size = New System.Drawing.Size(173, 20)
        Me.txbContactoSol.TabIndex = 13
        '
        'Detalle
        '
        Me.Detalle.AutoSize = True
        Me.Detalle.Location = New System.Drawing.Point(44, 256)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Size = New System.Drawing.Size(40, 13)
        Me.Detalle.TabIndex = 14
        Me.Detalle.Text = "Detalle"
        '
        'txbDetalle
        '
        Me.txbDetalle.Location = New System.Drawing.Point(47, 272)
        Me.txbDetalle.Multiline = True
        Me.txbDetalle.Name = "txbDetalle"
        Me.txbDetalle.Size = New System.Drawing.Size(615, 88)
        Me.txbDetalle.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(273, 385)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 35)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 446)
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
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCV)
        Me.Controls.Add(Me.txbCV)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txbCV As TextBox
    Friend WithEvents cmbCV As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txbDep As TextBox
    Friend WithEvents txbMun As TextBox
    Friend WithEvents txbDis As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbSolicitante As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txbContactoSol As TextBox
    Friend WithEvents Detalle As Label
    Friend WithEvents txbDetalle As TextBox
    Friend WithEvents btnSave As Button
End Class
