<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngreso
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
        Me.PIngresoFiltros = New System.Windows.Forms.Panel()
        Me.BIngresoEliminar = New System.Windows.Forms.Button()
        Me.BIngresoIngresar = New System.Windows.Forms.Button()
        Me.CBIngresoOrigen = New System.Windows.Forms.ComboBox()
        Me.DTPIngreso = New System.Windows.Forms.DateTimePicker()
        Me.TBIngresoFactura = New System.Windows.Forms.TextBox()
        Me.TBIngresoProveedor = New System.Windows.Forms.TextBox()
        Me.TBIngresoLote = New System.Windows.Forms.TextBox()
        Me.TBIngresoCantidad = New System.Windows.Forms.TextBox()
        Me.TBIngresoCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PIngresoData = New System.Windows.Forms.Panel()
        Me.DGVIngreso = New System.Windows.Forms.DataGridView()
        Me.PIngresoBotones = New System.Windows.Forms.Panel()
        Me.BIngresoCancelar = New System.Windows.Forms.Button()
        Me.BIngresoGuardar = New System.Windows.Forms.Button()
        Me.BIngresoExportar = New System.Windows.Forms.Button()
        Me.PIngresoFiltros.SuspendLayout()
        Me.PIngresoData.SuspendLayout()
        CType(Me.DGVIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PIngresoBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PIngresoFiltros
        '
        Me.PIngresoFiltros.BackColor = System.Drawing.Color.ForestGreen
        Me.PIngresoFiltros.Controls.Add(Me.BIngresoEliminar)
        Me.PIngresoFiltros.Controls.Add(Me.BIngresoIngresar)
        Me.PIngresoFiltros.Controls.Add(Me.CBIngresoOrigen)
        Me.PIngresoFiltros.Controls.Add(Me.DTPIngreso)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoFactura)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoProveedor)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoLote)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoCantidad)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoCodigo)
        Me.PIngresoFiltros.Controls.Add(Me.Label7)
        Me.PIngresoFiltros.Controls.Add(Me.Label6)
        Me.PIngresoFiltros.Controls.Add(Me.Label5)
        Me.PIngresoFiltros.Controls.Add(Me.Label4)
        Me.PIngresoFiltros.Controls.Add(Me.Label3)
        Me.PIngresoFiltros.Controls.Add(Me.Label2)
        Me.PIngresoFiltros.Controls.Add(Me.Label1)
        Me.PIngresoFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PIngresoFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PIngresoFiltros.Name = "PIngresoFiltros"
        Me.PIngresoFiltros.Size = New System.Drawing.Size(800, 146)
        Me.PIngresoFiltros.TabIndex = 0
        '
        'BIngresoEliminar
        '
        Me.BIngresoEliminar.Location = New System.Drawing.Point(632, 100)
        Me.BIngresoEliminar.Name = "BIngresoEliminar"
        Me.BIngresoEliminar.Size = New System.Drawing.Size(75, 33)
        Me.BIngresoEliminar.TabIndex = 16
        Me.BIngresoEliminar.Text = "Eliminar"
        Me.BIngresoEliminar.UseVisualStyleBackColor = True
        '
        'BIngresoIngresar
        '
        Me.BIngresoIngresar.Location = New System.Drawing.Point(713, 100)
        Me.BIngresoIngresar.Name = "BIngresoIngresar"
        Me.BIngresoIngresar.Size = New System.Drawing.Size(75, 33)
        Me.BIngresoIngresar.TabIndex = 15
        Me.BIngresoIngresar.Text = "Ingresar"
        Me.BIngresoIngresar.UseVisualStyleBackColor = True
        '
        'CBIngresoOrigen
        '
        Me.CBIngresoOrigen.FormattingEnabled = True
        Me.CBIngresoOrigen.Items.AddRange(New Object() {"Nacional", "Importado"})
        Me.CBIngresoOrigen.Location = New System.Drawing.Point(490, 73)
        Me.CBIngresoOrigen.Name = "CBIngresoOrigen"
        Me.CBIngresoOrigen.Size = New System.Drawing.Size(121, 21)
        Me.CBIngresoOrigen.TabIndex = 14
        '
        'DTPIngreso
        '
        Me.DTPIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPIngreso.Location = New System.Drawing.Point(226, 107)
        Me.DTPIngreso.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DTPIngreso.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DTPIngreso.Name = "DTPIngreso"
        Me.DTPIngreso.Size = New System.Drawing.Size(113, 20)
        Me.DTPIngreso.TabIndex = 13
        '
        'TBIngresoFactura
        '
        Me.TBIngresoFactura.Location = New System.Drawing.Point(491, 40)
        Me.TBIngresoFactura.Name = "TBIngresoFactura"
        Me.TBIngresoFactura.Size = New System.Drawing.Size(100, 20)
        Me.TBIngresoFactura.TabIndex = 12
        '
        'TBIngresoProveedor
        '
        Me.TBIngresoProveedor.Location = New System.Drawing.Point(490, 12)
        Me.TBIngresoProveedor.Name = "TBIngresoProveedor"
        Me.TBIngresoProveedor.Size = New System.Drawing.Size(272, 20)
        Me.TBIngresoProveedor.TabIndex = 11
        '
        'TBIngresoLote
        '
        Me.TBIngresoLote.Location = New System.Drawing.Point(175, 73)
        Me.TBIngresoLote.Name = "TBIngresoLote"
        Me.TBIngresoLote.Size = New System.Drawing.Size(164, 20)
        Me.TBIngresoLote.TabIndex = 9
        '
        'TBIngresoCantidad
        '
        Me.TBIngresoCantidad.Location = New System.Drawing.Point(175, 43)
        Me.TBIngresoCantidad.Name = "TBIngresoCantidad"
        Me.TBIngresoCantidad.Size = New System.Drawing.Size(164, 20)
        Me.TBIngresoCantidad.TabIndex = 8
        '
        'TBIngresoCodigo
        '
        Me.TBIngresoCodigo.Location = New System.Drawing.Point(175, 14)
        Me.TBIngresoCodigo.Name = "TBIngresoCodigo"
        Me.TBIngresoCodigo.Size = New System.Drawing.Size(164, 20)
        Me.TBIngresoCodigo.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(396, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Origen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(396, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nº Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(396, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "F. Vencimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad en UMV"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Producto:"
        '
        'PIngresoData
        '
        Me.PIngresoData.Controls.Add(Me.DGVIngreso)
        Me.PIngresoData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PIngresoData.Location = New System.Drawing.Point(0, 146)
        Me.PIngresoData.Name = "PIngresoData"
        Me.PIngresoData.Size = New System.Drawing.Size(800, 285)
        Me.PIngresoData.TabIndex = 1
        '
        'DGVIngreso
        '
        Me.DGVIngreso.AllowUserToOrderColumns = True
        Me.DGVIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVIngreso.Location = New System.Drawing.Point(0, 0)
        Me.DGVIngreso.Name = "DGVIngreso"
        Me.DGVIngreso.Size = New System.Drawing.Size(800, 285)
        Me.DGVIngreso.TabIndex = 0
        '
        'PIngresoBotones
        '
        Me.PIngresoBotones.BackColor = System.Drawing.Color.ForestGreen
        Me.PIngresoBotones.Controls.Add(Me.BIngresoCancelar)
        Me.PIngresoBotones.Controls.Add(Me.BIngresoGuardar)
        Me.PIngresoBotones.Controls.Add(Me.BIngresoExportar)
        Me.PIngresoBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PIngresoBotones.Location = New System.Drawing.Point(0, 431)
        Me.PIngresoBotones.Name = "PIngresoBotones"
        Me.PIngresoBotones.Size = New System.Drawing.Size(800, 64)
        Me.PIngresoBotones.TabIndex = 2
        '
        'BIngresoCancelar
        '
        Me.BIngresoCancelar.Location = New System.Drawing.Point(583, 16)
        Me.BIngresoCancelar.Name = "BIngresoCancelar"
        Me.BIngresoCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BIngresoCancelar.TabIndex = 2
        Me.BIngresoCancelar.Text = "Cancelar"
        Me.BIngresoCancelar.UseVisualStyleBackColor = True
        '
        'BIngresoGuardar
        '
        Me.BIngresoGuardar.Location = New System.Drawing.Point(678, 16)
        Me.BIngresoGuardar.Name = "BIngresoGuardar"
        Me.BIngresoGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BIngresoGuardar.TabIndex = 1
        Me.BIngresoGuardar.Text = "Guardar"
        Me.BIngresoGuardar.UseVisualStyleBackColor = True
        '
        'BIngresoExportar
        '
        Me.BIngresoExportar.Location = New System.Drawing.Point(12, 16)
        Me.BIngresoExportar.Name = "BIngresoExportar"
        Me.BIngresoExportar.Size = New System.Drawing.Size(75, 23)
        Me.BIngresoExportar.TabIndex = 0
        Me.BIngresoExportar.Text = "Exportar"
        Me.BIngresoExportar.UseVisualStyleBackColor = True
        '
        'FormIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.PIngresoBotones)
        Me.Controls.Add(Me.PIngresoData)
        Me.Controls.Add(Me.PIngresoFiltros)
        Me.Name = "FormIngreso"
        Me.Text = "FormIngreso"
        Me.PIngresoFiltros.ResumeLayout(False)
        Me.PIngresoFiltros.PerformLayout()
        Me.PIngresoData.ResumeLayout(False)
        CType(Me.DGVIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PIngresoBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PIngresoFiltros As Panel
    Friend WithEvents BIngresoIngresar As Button
    Friend WithEvents CBIngresoOrigen As ComboBox
    Friend WithEvents DTPIngreso As DateTimePicker
    Friend WithEvents TBIngresoFactura As TextBox
    Friend WithEvents TBIngresoProveedor As TextBox
    Friend WithEvents TBIngresoLote As TextBox
    Friend WithEvents TBIngresoCantidad As TextBox
    Friend WithEvents TBIngresoCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PIngresoData As Panel
    Friend WithEvents DGVIngreso As DataGridView
    Friend WithEvents PIngresoBotones As Panel
    Friend WithEvents BIngresoCancelar As Button
    Friend WithEvents BIngresoGuardar As Button
    Friend WithEvents BIngresoExportar As Button
    Friend WithEvents BIngresoEliminar As Button
End Class
