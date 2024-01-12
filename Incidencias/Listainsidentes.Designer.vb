<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listainsidentes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.txb_buscar = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_selectIns = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(896, 390)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTA INSIDENTES"
        '
        'btn_reporte
        '
        Me.btn_reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reporte.Location = New System.Drawing.Point(12, 523)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(166, 35)
        Me.btn_reporte.TabIndex = 2
        Me.btn_reporte.Text = "Crear Reporte"
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'txb_buscar
        '
        Me.txb_buscar.Location = New System.Drawing.Point(52, 66)
        Me.txb_buscar.Name = "txb_buscar"
        Me.txb_buscar.Size = New System.Drawing.Size(207, 22)
        Me.txb_buscar.TabIndex = 3
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(265, 65)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(131, 23)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_selectIns
        '
        Me.btn_selectIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectIns.Location = New System.Drawing.Point(386, 499)
        Me.btn_selectIns.Name = "btn_selectIns"
        Me.btn_selectIns.Size = New System.Drawing.Size(262, 48)
        Me.btn_selectIns.TabIndex = 5
        Me.btn_selectIns.Text = "Seleccionar Insidencia"
        Me.btn_selectIns.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Buscar por Centro de Votacion"
        '
        'Listainsidentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 570)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_selectIns)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txb_buscar)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Listainsidentes"
        Me.Text = "Listainsidentes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_reporte As Button
    Friend WithEvents txb_buscar As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_selectIns As Button
    Friend WithEvents Label2 As Label
End Class
