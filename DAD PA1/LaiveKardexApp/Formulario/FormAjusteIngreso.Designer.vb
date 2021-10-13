<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAjusteIngreso
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
        Me.PanelAjPosFiltros = New System.Windows.Forms.Panel()
        Me.PanelAjPosTabla = New System.Windows.Forms.Panel()
        Me.PanelAjPosMod = New System.Windows.Forms.Panel()
        Me.PanelAjPosBotones = New System.Windows.Forms.Panel()
        Me.LAjuPosCodigo = New System.Windows.Forms.Label()
        Me.LAjuPosProducto = New System.Windows.Forms.Label()
        Me.LAjuPosLote = New System.Windows.Forms.Label()
        Me.LAjuPosFecha = New System.Windows.Forms.Label()
        Me.TBAjuPosCodigo = New System.Windows.Forms.TextBox()
        Me.TBAjuPosProducto = New System.Windows.Forms.TextBox()
        Me.TBAjuPosLote = New System.Windows.Forms.TextBox()
        Me.DTPAjuPos = New System.Windows.Forms.DateTimePicker()
        Me.BAjustePos = New System.Windows.Forms.Button()
        Me.DGVAjuPositivo = New System.Windows.Forms.DataGridView()
        Me.LAjuNegMotivo = New System.Windows.Forms.Label()
        Me.CBAjuNegMotivo = New System.Windows.Forms.ComboBox()
        Me.TBAjuNegCantidad = New System.Windows.Forms.TextBox()
        Me.LAjuNegCantidad = New System.Windows.Forms.Label()
        Me.BAjuPosGuardar = New System.Windows.Forms.Button()
        Me.BAjuPosCancelar = New System.Windows.Forms.Button()
        Me.PanelAjPosFiltros.SuspendLayout()
        Me.PanelAjPosTabla.SuspendLayout()
        Me.PanelAjPosMod.SuspendLayout()
        Me.PanelAjPosBotones.SuspendLayout()
        CType(Me.DGVAjuPositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAjPosFiltros
        '
        Me.PanelAjPosFiltros.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelAjPosFiltros.Controls.Add(Me.BAjustePos)
        Me.PanelAjPosFiltros.Controls.Add(Me.DTPAjuPos)
        Me.PanelAjPosFiltros.Controls.Add(Me.TBAjuPosLote)
        Me.PanelAjPosFiltros.Controls.Add(Me.TBAjuPosProducto)
        Me.PanelAjPosFiltros.Controls.Add(Me.TBAjuPosCodigo)
        Me.PanelAjPosFiltros.Controls.Add(Me.LAjuPosFecha)
        Me.PanelAjPosFiltros.Controls.Add(Me.LAjuPosLote)
        Me.PanelAjPosFiltros.Controls.Add(Me.LAjuPosProducto)
        Me.PanelAjPosFiltros.Controls.Add(Me.LAjuPosCodigo)
        Me.PanelAjPosFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjPosFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelAjPosFiltros.Name = "PanelAjPosFiltros"
        Me.PanelAjPosFiltros.Size = New System.Drawing.Size(800, 91)
        Me.PanelAjPosFiltros.TabIndex = 0
        '
        'PanelAjPosTabla
        '
        Me.PanelAjPosTabla.Controls.Add(Me.DGVAjuPositivo)
        Me.PanelAjPosTabla.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjPosTabla.Location = New System.Drawing.Point(0, 91)
        Me.PanelAjPosTabla.Name = "PanelAjPosTabla"
        Me.PanelAjPosTabla.Size = New System.Drawing.Size(800, 225)
        Me.PanelAjPosTabla.TabIndex = 1
        '
        'PanelAjPosMod
        '
        Me.PanelAjPosMod.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelAjPosMod.Controls.Add(Me.LAjuNegMotivo)
        Me.PanelAjPosMod.Controls.Add(Me.CBAjuNegMotivo)
        Me.PanelAjPosMod.Controls.Add(Me.TBAjuNegCantidad)
        Me.PanelAjPosMod.Controls.Add(Me.LAjuNegCantidad)
        Me.PanelAjPosMod.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjPosMod.Location = New System.Drawing.Point(0, 316)
        Me.PanelAjPosMod.Name = "PanelAjPosMod"
        Me.PanelAjPosMod.Size = New System.Drawing.Size(800, 56)
        Me.PanelAjPosMod.TabIndex = 2
        '
        'PanelAjPosBotones
        '
        Me.PanelAjPosBotones.Controls.Add(Me.BAjuPosCancelar)
        Me.PanelAjPosBotones.Controls.Add(Me.BAjuPosGuardar)
        Me.PanelAjPosBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjPosBotones.Location = New System.Drawing.Point(0, 372)
        Me.PanelAjPosBotones.Name = "PanelAjPosBotones"
        Me.PanelAjPosBotones.Size = New System.Drawing.Size(800, 69)
        Me.PanelAjPosBotones.TabIndex = 3
        '
        'LAjuPosCodigo
        '
        Me.LAjuPosCodigo.AutoSize = True
        Me.LAjuPosCodigo.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuPosCodigo.ForeColor = System.Drawing.Color.White
        Me.LAjuPosCodigo.Location = New System.Drawing.Point(16, 13)
        Me.LAjuPosCodigo.Name = "LAjuPosCodigo"
        Me.LAjuPosCodigo.Size = New System.Drawing.Size(157, 19)
        Me.LAjuPosCodigo.TabIndex = 0
        Me.LAjuPosCodigo.Text = "Codigo de Producto:"
        '
        'LAjuPosProducto
        '
        Me.LAjuPosProducto.AutoSize = True
        Me.LAjuPosProducto.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuPosProducto.ForeColor = System.Drawing.Color.White
        Me.LAjuPosProducto.Location = New System.Drawing.Point(16, 53)
        Me.LAjuPosProducto.Name = "LAjuPosProducto"
        Me.LAjuPosProducto.Size = New System.Drawing.Size(195, 19)
        Me.LAjuPosProducto.TabIndex = 1
        Me.LAjuPosProducto.Text = "Descripcion del Producto:"
        '
        'LAjuPosLote
        '
        Me.LAjuPosLote.AutoSize = True
        Me.LAjuPosLote.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuPosLote.ForeColor = System.Drawing.Color.White
        Me.LAjuPosLote.Location = New System.Drawing.Point(359, 9)
        Me.LAjuPosLote.Name = "LAjuPosLote"
        Me.LAjuPosLote.Size = New System.Drawing.Size(40, 19)
        Me.LAjuPosLote.TabIndex = 2
        Me.LAjuPosLote.Text = "Lote"
        '
        'LAjuPosFecha
        '
        Me.LAjuPosFecha.AutoSize = True
        Me.LAjuPosFecha.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuPosFecha.ForeColor = System.Drawing.Color.White
        Me.LAjuPosFecha.Location = New System.Drawing.Point(359, 52)
        Me.LAjuPosFecha.Name = "LAjuPosFecha"
        Me.LAjuPosFecha.Size = New System.Drawing.Size(113, 19)
        Me.LAjuPosFecha.TabIndex = 3
        Me.LAjuPosFecha.Text = "F. Vencimiento"
        '
        'TBAjuPosCodigo
        '
        Me.TBAjuPosCodigo.Location = New System.Drawing.Point(217, 8)
        Me.TBAjuPosCodigo.Name = "TBAjuPosCodigo"
        Me.TBAjuPosCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TBAjuPosCodigo.TabIndex = 4
        '
        'TBAjuPosProducto
        '
        Me.TBAjuPosProducto.Location = New System.Drawing.Point(217, 52)
        Me.TBAjuPosProducto.Name = "TBAjuPosProducto"
        Me.TBAjuPosProducto.Size = New System.Drawing.Size(100, 20)
        Me.TBAjuPosProducto.TabIndex = 5
        '
        'TBAjuPosLote
        '
        Me.TBAjuPosLote.Location = New System.Drawing.Point(478, 8)
        Me.TBAjuPosLote.Name = "TBAjuPosLote"
        Me.TBAjuPosLote.Size = New System.Drawing.Size(100, 20)
        Me.TBAjuPosLote.TabIndex = 6
        '
        'DTPAjuPos
        '
        Me.DTPAjuPos.Location = New System.Drawing.Point(478, 49)
        Me.DTPAjuPos.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DTPAjuPos.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DTPAjuPos.Name = "DTPAjuPos"
        Me.DTPAjuPos.Size = New System.Drawing.Size(200, 20)
        Me.DTPAjuPos.TabIndex = 7
        '
        'BAjustePos
        '
        Me.BAjustePos.Location = New System.Drawing.Point(691, 12)
        Me.BAjustePos.Name = "BAjustePos"
        Me.BAjustePos.Size = New System.Drawing.Size(75, 23)
        Me.BAjustePos.TabIndex = 8
        Me.BAjustePos.Text = "Buscar"
        Me.BAjustePos.UseVisualStyleBackColor = True
        '
        'DGVAjuPositivo
        '
        Me.DGVAjuPositivo.AllowUserToOrderColumns = True
        Me.DGVAjuPositivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAjuPositivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAjuPositivo.Location = New System.Drawing.Point(0, 0)
        Me.DGVAjuPositivo.Name = "DGVAjuPositivo"
        Me.DGVAjuPositivo.Size = New System.Drawing.Size(800, 225)
        Me.DGVAjuPositivo.TabIndex = 0
        '
        'LAjuNegMotivo
        '
        Me.LAjuNegMotivo.AutoSize = True
        Me.LAjuNegMotivo.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuNegMotivo.ForeColor = System.Drawing.Color.White
        Me.LAjuNegMotivo.Location = New System.Drawing.Point(468, 18)
        Me.LAjuNegMotivo.Name = "LAjuNegMotivo"
        Me.LAjuNegMotivo.Size = New System.Drawing.Size(63, 19)
        Me.LAjuNegMotivo.TabIndex = 21
        Me.LAjuNegMotivo.Text = "Motivo:"
        '
        'CBAjuNegMotivo
        '
        Me.CBAjuNegMotivo.FormattingEnabled = True
        Me.CBAjuNegMotivo.Location = New System.Drawing.Point(554, 17)
        Me.CBAjuNegMotivo.Name = "CBAjuNegMotivo"
        Me.CBAjuNegMotivo.Size = New System.Drawing.Size(121, 21)
        Me.CBAjuNegMotivo.TabIndex = 20
        '
        'TBAjuNegCantidad
        '
        Me.TBAjuNegCantidad.Location = New System.Drawing.Point(261, 17)
        Me.TBAjuNegCantidad.Name = "TBAjuNegCantidad"
        Me.TBAjuNegCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TBAjuNegCantidad.TabIndex = 19
        '
        'LAjuNegCantidad
        '
        Me.LAjuNegCantidad.AutoSize = True
        Me.LAjuNegCantidad.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuNegCantidad.ForeColor = System.Drawing.Color.White
        Me.LAjuNegCantidad.Location = New System.Drawing.Point(60, 19)
        Me.LAjuNegCantidad.Name = "LAjuNegCantidad"
        Me.LAjuNegCantidad.Size = New System.Drawing.Size(190, 19)
        Me.LAjuNegCantidad.TabIndex = 18
        Me.LAjuNegCantidad.Text = "Cantidad a Incrementar:"
        '
        'BAjuPosGuardar
        '
        Me.BAjuPosGuardar.Location = New System.Drawing.Point(691, 26)
        Me.BAjuPosGuardar.Name = "BAjuPosGuardar"
        Me.BAjuPosGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BAjuPosGuardar.TabIndex = 0
        Me.BAjuPosGuardar.Text = "Guardar"
        Me.BAjuPosGuardar.UseVisualStyleBackColor = True
        '
        'BAjuPosCancelar
        '
        Me.BAjuPosCancelar.Location = New System.Drawing.Point(610, 26)
        Me.BAjuPosCancelar.Name = "BAjuPosCancelar"
        Me.BAjuPosCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BAjuPosCancelar.TabIndex = 1
        Me.BAjuPosCancelar.Text = "Cancelar"
        Me.BAjuPosCancelar.UseVisualStyleBackColor = True
        '
        'FormAjusteIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 441)
        Me.Controls.Add(Me.PanelAjPosBotones)
        Me.Controls.Add(Me.PanelAjPosMod)
        Me.Controls.Add(Me.PanelAjPosTabla)
        Me.Controls.Add(Me.PanelAjPosFiltros)
        Me.Name = "FormAjusteIngreso"
        Me.Text = "FormAjusteIngreso"
        Me.PanelAjPosFiltros.ResumeLayout(False)
        Me.PanelAjPosFiltros.PerformLayout()
        Me.PanelAjPosTabla.ResumeLayout(False)
        Me.PanelAjPosMod.ResumeLayout(False)
        Me.PanelAjPosMod.PerformLayout()
        Me.PanelAjPosBotones.ResumeLayout(False)
        CType(Me.DGVAjuPositivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAjPosFiltros As Panel
    Friend WithEvents PanelAjPosTabla As Panel
    Friend WithEvents PanelAjPosMod As Panel
    Friend WithEvents PanelAjPosBotones As Panel
    Friend WithEvents TBAjuPosLote As TextBox
    Friend WithEvents TBAjuPosProducto As TextBox
    Friend WithEvents TBAjuPosCodigo As TextBox
    Friend WithEvents LAjuPosFecha As Label
    Friend WithEvents LAjuPosLote As Label
    Friend WithEvents LAjuPosProducto As Label
    Friend WithEvents LAjuPosCodigo As Label
    Friend WithEvents BAjustePos As Button
    Friend WithEvents DTPAjuPos As DateTimePicker
    Friend WithEvents DGVAjuPositivo As DataGridView
    Friend WithEvents LAjuNegMotivo As Label
    Friend WithEvents CBAjuNegMotivo As ComboBox
    Friend WithEvents TBAjuNegCantidad As TextBox
    Friend WithEvents LAjuNegCantidad As Label
    Friend WithEvents BAjuPosCancelar As Button
    Friend WithEvents BAjuPosGuardar As Button
End Class
