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
        Me.btn_selectIns = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 76)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(672, 317)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTA INCIDENTES"
        '
        'btn_reporte
        '
        Me.btn_reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reporte.Location = New System.Drawing.Point(9, 425)
        Me.btn_reporte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(124, 28)
        Me.btn_reporte.TabIndex = 2
        Me.btn_reporte.Text = "Crear Reporte"
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'btn_selectIns
        '
        Me.btn_selectIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectIns.Location = New System.Drawing.Point(290, 405)
        Me.btn_selectIns.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_selectIns.Name = "btn_selectIns"
        Me.btn_selectIns.Size = New System.Drawing.Size(196, 39)
        Me.btn_selectIns.TabIndex = 5
        Me.btn_selectIns.Text = "Seleccionar Insidencia"
        Me.btn_selectIns.UseVisualStyleBackColor = True
        '
        'Listainsidentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 463)
        Me.Controls.Add(Me.btn_selectIns)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Listainsidentes"
        Me.Text = "Listainsidentes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_reporte As Button
    Friend WithEvents btn_selectIns As Button
End Class
