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
        Me.cbubicacion = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbproveedor = New System.Windows.Forms.ComboBox()
        Me.cbcodproducto = New System.Windows.Forms.ComboBox()
        Me.TBIngresoValor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BIngresoEliminar = New System.Windows.Forms.Button()
        Me.BIngresoIngresar = New System.Windows.Forms.Button()
        Me.cbpais = New System.Windows.Forms.ComboBox()
        Me.DTPIngreso = New System.Windows.Forms.DateTimePicker()
        Me.TBIngresoFactura = New System.Windows.Forms.TextBox()
        Me.TBIngresoLote = New System.Windows.Forms.TextBox()
        Me.TBIngresoCantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PIngresoData = New System.Windows.Forms.Panel()
        Me.dgproductos = New System.Windows.Forms.DataGridView()
        Me.PIngresoBotones = New System.Windows.Forms.Panel()
        Me.BIngresoCancelar = New System.Windows.Forms.Button()
        Me.BIngresoGuardar = New System.Windows.Forms.Button()
        Me.BIngresoExportar = New System.Windows.Forms.Button()
        Me.DTCreacion = New System.Windows.Forms.DateTimePicker()
        Me.PIngresoFiltros.SuspendLayout()
        Me.PIngresoData.SuspendLayout()
        CType(Me.dgproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PIngresoBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PIngresoFiltros
        '
        Me.PIngresoFiltros.BackColor = System.Drawing.Color.ForestGreen
        Me.PIngresoFiltros.Controls.Add(Me.DTCreacion)
        Me.PIngresoFiltros.Controls.Add(Me.cbubicacion)
        Me.PIngresoFiltros.Controls.Add(Me.Button1)
        Me.PIngresoFiltros.Controls.Add(Me.Label10)
        Me.PIngresoFiltros.Controls.Add(Me.cbproveedor)
        Me.PIngresoFiltros.Controls.Add(Me.cbcodproducto)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoValor)
        Me.PIngresoFiltros.Controls.Add(Me.Label8)
        Me.PIngresoFiltros.Controls.Add(Me.BIngresoEliminar)
        Me.PIngresoFiltros.Controls.Add(Me.BIngresoIngresar)
        Me.PIngresoFiltros.Controls.Add(Me.cbpais)
        Me.PIngresoFiltros.Controls.Add(Me.DTPIngreso)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoFactura)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoLote)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoCantidad)
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
        'cbubicacion
        '
        Me.cbubicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbubicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbubicacion.FormattingEnabled = True
        Me.cbubicacion.Location = New System.Drawing.Point(511, 88)
        Me.cbubicacion.Name = "cbubicacion"
        Me.cbubicacion.Size = New System.Drawing.Size(153, 21)
        Me.cbubicacion.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Nuevo Producto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(431, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ubicación:"
        '
        'cbproveedor
        '
        Me.cbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbproveedor.FormattingEnabled = True
        Me.cbproveedor.Location = New System.Drawing.Point(511, 10)
        Me.cbproveedor.Name = "cbproveedor"
        Me.cbproveedor.Size = New System.Drawing.Size(196, 21)
        Me.cbproveedor.TabIndex = 20
        '
        'cbcodproducto
        '
        Me.cbcodproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbcodproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbcodproducto.FormattingEnabled = True
        Me.cbcodproducto.Location = New System.Drawing.Point(117, 7)
        Me.cbcodproducto.Name = "cbcodproducto"
        Me.cbcodproducto.Size = New System.Drawing.Size(308, 21)
        Me.cbcodproducto.TabIndex = 19
        '
        'TBIngresoValor
        '
        Me.TBIngresoValor.Location = New System.Drawing.Point(511, 120)
        Me.TBIngresoValor.Name = "TBIngresoValor"
        Me.TBIngresoValor.Size = New System.Drawing.Size(81, 20)
        Me.TBIngresoValor.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(431, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Valor :"
        '
        'BIngresoEliminar
        '
        Me.BIngresoEliminar.Location = New System.Drawing.Point(713, 49)
        Me.BIngresoEliminar.Name = "BIngresoEliminar"
        Me.BIngresoEliminar.Size = New System.Drawing.Size(75, 33)
        Me.BIngresoEliminar.TabIndex = 16
        Me.BIngresoEliminar.Text = "Eliminar"
        Me.BIngresoEliminar.UseVisualStyleBackColor = True
        '
        'BIngresoIngresar
        '
        Me.BIngresoIngresar.Location = New System.Drawing.Point(713, 102)
        Me.BIngresoIngresar.Name = "BIngresoIngresar"
        Me.BIngresoIngresar.Size = New System.Drawing.Size(75, 33)
        Me.BIngresoIngresar.TabIndex = 15
        Me.BIngresoIngresar.Text = "Ingresar"
        Me.BIngresoIngresar.UseVisualStyleBackColor = True
        '
        'cbpais
        '
        Me.cbpais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbpais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbpais.FormattingEnabled = True
        Me.cbpais.Location = New System.Drawing.Point(511, 35)
        Me.cbpais.Name = "cbpais"
        Me.cbpais.Size = New System.Drawing.Size(153, 21)
        Me.cbpais.TabIndex = 14
        '
        'DTPIngreso
        '
        Me.DTPIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPIngreso.Location = New System.Drawing.Point(119, 120)
        Me.DTPIngreso.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DTPIngreso.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DTPIngreso.Name = "DTPIngreso"
        Me.DTPIngreso.Size = New System.Drawing.Size(162, 20)
        Me.DTPIngreso.TabIndex = 13
        '
        'TBIngresoFactura
        '
        Me.TBIngresoFactura.Location = New System.Drawing.Point(511, 62)
        Me.TBIngresoFactura.Name = "TBIngresoFactura"
        Me.TBIngresoFactura.Size = New System.Drawing.Size(153, 20)
        Me.TBIngresoFactura.TabIndex = 12
        '
        'TBIngresoLote
        '
        Me.TBIngresoLote.Location = New System.Drawing.Point(117, 90)
        Me.TBIngresoLote.Name = "TBIngresoLote"
        Me.TBIngresoLote.Size = New System.Drawing.Size(164, 20)
        Me.TBIngresoLote.TabIndex = 9
        '
        'TBIngresoCantidad
        '
        Me.TBIngresoCantidad.Location = New System.Drawing.Point(117, 62)
        Me.TBIngresoCantidad.Name = "TBIngresoCantidad"
        Me.TBIngresoCantidad.Size = New System.Drawing.Size(164, 20)
        Me.TBIngresoCantidad.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(431, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Origen:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(431, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nº Factura:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(431, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "F. Vencimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lote:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'PIngresoData
        '
        Me.PIngresoData.Controls.Add(Me.dgproductos)
        Me.PIngresoData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PIngresoData.Location = New System.Drawing.Point(0, 146)
        Me.PIngresoData.Name = "PIngresoData"
        Me.PIngresoData.Size = New System.Drawing.Size(800, 285)
        Me.PIngresoData.TabIndex = 1
        '
        'dgproductos
        '
        Me.dgproductos.AllowUserToAddRows = False
        Me.dgproductos.AllowUserToOrderColumns = True
        Me.dgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgproductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgproductos.Location = New System.Drawing.Point(0, 0)
        Me.dgproductos.Name = "dgproductos"
        Me.dgproductos.Size = New System.Drawing.Size(800, 285)
        Me.dgproductos.TabIndex = 0
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
        'DTCreacion
        '
        Me.DTCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTCreacion.Location = New System.Drawing.Point(15, 36)
        Me.DTCreacion.MinDate = New Date(2021, 10, 1, 0, 0, 0, 0)
        Me.DTCreacion.Name = "DTCreacion"
        Me.DTCreacion.Size = New System.Drawing.Size(78, 20)
        Me.DTCreacion.TabIndex = 25
        Me.DTCreacion.Visible = False
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
        CType(Me.dgproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PIngresoBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PIngresoFiltros As Panel
    Friend WithEvents BIngresoIngresar As Button
    Friend WithEvents cbpais As ComboBox
    Friend WithEvents DTPIngreso As DateTimePicker
    Friend WithEvents TBIngresoFactura As TextBox
    Friend WithEvents TBIngresoLote As TextBox
    Friend WithEvents TBIngresoCantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PIngresoData As Panel
    Friend WithEvents dgproductos As DataGridView
    Friend WithEvents PIngresoBotones As Panel
    Friend WithEvents BIngresoCancelar As Button
    Friend WithEvents BIngresoGuardar As Button
    Friend WithEvents BIngresoExportar As Button
    Friend WithEvents BIngresoEliminar As Button
    Friend WithEvents TBIngresoValor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbproveedor As ComboBox
    Friend WithEvents cbcodproducto As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbubicacion As ComboBox
    Friend WithEvents DTCreacion As DateTimePicker
End Class
