<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAjusteSalida
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
        Me.PanelAjNegBotones = New System.Windows.Forms.Panel()
        Me.PanelAjNegMod = New System.Windows.Forms.Panel()
        Me.PanelAjNegData = New System.Windows.Forms.Panel()
        Me.PanelAjNegFiltros = New System.Windows.Forms.Panel()
        Me.BAjusteNeg = New System.Windows.Forms.Button()
        Me.DTPAjuNeg = New System.Windows.Forms.DateTimePicker()
        Me.TBAjuNegLote = New System.Windows.Forms.TextBox()
        Me.TBAjuNegProducto = New System.Windows.Forms.TextBox()
        Me.TBAjuNegCodigo = New System.Windows.Forms.TextBox()
        Me.LAjuNegFecha = New System.Windows.Forms.Label()
        Me.LAjuNegLote = New System.Windows.Forms.Label()
        Me.LAjuNegProducto = New System.Windows.Forms.Label()
        Me.LAjuNegCodigo = New System.Windows.Forms.Label()
        Me.DGVAjuNegativo = New System.Windows.Forms.DataGridView()
        Me.TBAjuNegCantidad = New System.Windows.Forms.TextBox()
        Me.LAjuNegCantidad = New System.Windows.Forms.Label()
        Me.CBAjuNegMotivo = New System.Windows.Forms.ComboBox()
        Me.LAjuNegMotivo = New System.Windows.Forms.Label()
        Me.BAjuNegCancelar = New System.Windows.Forms.Button()
        Me.BAjuNegGuardar = New System.Windows.Forms.Button()
        Me.PanelAjNegBotones.SuspendLayout()
        Me.PanelAjNegMod.SuspendLayout()
        Me.PanelAjNegData.SuspendLayout()
        Me.PanelAjNegFiltros.SuspendLayout()
        CType(Me.DGVAjuNegativo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAjNegBotones
        '
        Me.PanelAjNegBotones.Controls.Add(Me.BAjuNegCancelar)
        Me.PanelAjNegBotones.Controls.Add(Me.BAjuNegGuardar)
        Me.PanelAjNegBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjNegBotones.Location = New System.Drawing.Point(0, 381)
        Me.PanelAjNegBotones.Name = "PanelAjNegBotones"
        Me.PanelAjNegBotones.Size = New System.Drawing.Size(800, 67)
        Me.PanelAjNegBotones.TabIndex = 7
        '
        'PanelAjNegMod
        '
        Me.PanelAjNegMod.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelAjNegMod.Controls.Add(Me.LAjuNegMotivo)
        Me.PanelAjNegMod.Controls.Add(Me.CBAjuNegMotivo)
        Me.PanelAjNegMod.Controls.Add(Me.TBAjuNegCantidad)
        Me.PanelAjNegMod.Controls.Add(Me.LAjuNegCantidad)
        Me.PanelAjNegMod.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjNegMod.Location = New System.Drawing.Point(0, 325)
        Me.PanelAjNegMod.Name = "PanelAjNegMod"
        Me.PanelAjNegMod.Size = New System.Drawing.Size(800, 56)
        Me.PanelAjNegMod.TabIndex = 6
        '
        'PanelAjNegData
        '
        Me.PanelAjNegData.Controls.Add(Me.DGVAjuNegativo)
        Me.PanelAjNegData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjNegData.Location = New System.Drawing.Point(0, 100)
        Me.PanelAjNegData.Name = "PanelAjNegData"
        Me.PanelAjNegData.Size = New System.Drawing.Size(800, 225)
        Me.PanelAjNegData.TabIndex = 5
        '
        'PanelAjNegFiltros
        '
        Me.PanelAjNegFiltros.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelAjNegFiltros.Controls.Add(Me.BAjusteNeg)
        Me.PanelAjNegFiltros.Controls.Add(Me.DTPAjuNeg)
        Me.PanelAjNegFiltros.Controls.Add(Me.TBAjuNegLote)
        Me.PanelAjNegFiltros.Controls.Add(Me.TBAjuNegProducto)
        Me.PanelAjNegFiltros.Controls.Add(Me.TBAjuNegCodigo)
        Me.PanelAjNegFiltros.Controls.Add(Me.LAjuNegFecha)
        Me.PanelAjNegFiltros.Controls.Add(Me.LAjuNegLote)
        Me.PanelAjNegFiltros.Controls.Add(Me.LAjuNegProducto)
        Me.PanelAjNegFiltros.Controls.Add(Me.LAjuNegCodigo)
        Me.PanelAjNegFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjNegFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelAjNegFiltros.Name = "PanelAjNegFiltros"
        Me.PanelAjNegFiltros.Size = New System.Drawing.Size(800, 100)
        Me.PanelAjNegFiltros.TabIndex = 4
        '
        'BAjusteNeg
        '
        Me.BAjusteNeg.Location = New System.Drawing.Point(700, 22)
        Me.BAjusteNeg.Name = "BAjusteNeg"
        Me.BAjusteNeg.Size = New System.Drawing.Size(75, 23)
        Me.BAjusteNeg.TabIndex = 17
        Me.BAjusteNeg.Text = "Buscar"
        Me.BAjusteNeg.UseVisualStyleBackColor = True
        '
        'DTPAjuNeg
        '
        Me.DTPAjuNeg.Location = New System.Drawing.Point(487, 59)
        Me.DTPAjuNeg.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DTPAjuNeg.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DTPAjuNeg.Name = "DTPAjuNeg"
        Me.DTPAjuNeg.Size = New System.Drawing.Size(200, 20)
        Me.DTPAjuNeg.TabIndex = 16
        '
        'TBAjuNegLote
        '
        Me.TBAjuNegLote.Location = New System.Drawing.Point(487, 18)
        Me.TBAjuNegLote.Name = "TBAjuNegLote"
        Me.TBAjuNegLote.Size = New System.Drawing.Size(100, 20)
        Me.TBAjuNegLote.TabIndex = 15
        '
        'TBAjuNegProducto
        '
        Me.TBAjuNegProducto.Location = New System.Drawing.Point(226, 62)
        Me.TBAjuNegProducto.Name = "TBAjuNegProducto"
        Me.TBAjuNegProducto.Size = New System.Drawing.Size(100, 20)
        Me.TBAjuNegProducto.TabIndex = 14
        '
        'TBAjuNegCodigo
        '
        Me.TBAjuNegCodigo.Location = New System.Drawing.Point(226, 18)
        Me.TBAjuNegCodigo.Name = "TBAjuNegCodigo"
        Me.TBAjuNegCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TBAjuNegCodigo.TabIndex = 13
        '
        'LAjuNegFecha
        '
        Me.LAjuNegFecha.AutoSize = True
        Me.LAjuNegFecha.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuNegFecha.ForeColor = System.Drawing.Color.White
        Me.LAjuNegFecha.Location = New System.Drawing.Point(368, 62)
        Me.LAjuNegFecha.Name = "LAjuNegFecha"
        Me.LAjuNegFecha.Size = New System.Drawing.Size(113, 19)
        Me.LAjuNegFecha.TabIndex = 12
        Me.LAjuNegFecha.Text = "F. Vencimiento"
        '
        'LAjuNegLote
        '
        Me.LAjuNegLote.AutoSize = True
        Me.LAjuNegLote.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuNegLote.ForeColor = System.Drawing.Color.White
        Me.LAjuNegLote.Location = New System.Drawing.Point(368, 19)
        Me.LAjuNegLote.Name = "LAjuNegLote"
        Me.LAjuNegLote.Size = New System.Drawing.Size(40, 19)
        Me.LAjuNegLote.TabIndex = 11
        Me.LAjuNegLote.Text = "Lote"
        '
        'LAjuNegProducto
        '
        Me.LAjuNegProducto.AutoSize = True
        Me.LAjuNegProducto.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuNegProducto.ForeColor = System.Drawing.Color.White
        Me.LAjuNegProducto.Location = New System.Drawing.Point(25, 63)
        Me.LAjuNegProducto.Name = "LAjuNegProducto"
        Me.LAjuNegProducto.Size = New System.Drawing.Size(195, 19)
        Me.LAjuNegProducto.TabIndex = 10
        Me.LAjuNegProducto.Text = "Descripcion del Producto:"
        '
        'LAjuNegCodigo
        '
        Me.LAjuNegCodigo.AutoSize = True
        Me.LAjuNegCodigo.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuNegCodigo.ForeColor = System.Drawing.Color.White
        Me.LAjuNegCodigo.Location = New System.Drawing.Point(25, 23)
        Me.LAjuNegCodigo.Name = "LAjuNegCodigo"
        Me.LAjuNegCodigo.Size = New System.Drawing.Size(157, 19)
        Me.LAjuNegCodigo.TabIndex = 9
        Me.LAjuNegCodigo.Text = "Codigo de Producto:"
        '
        'DGVAjuNegativo
        '
        Me.DGVAjuNegativo.AllowUserToOrderColumns = True
        Me.DGVAjuNegativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAjuNegativo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAjuNegativo.Location = New System.Drawing.Point(0, 0)
        Me.DGVAjuNegativo.Name = "DGVAjuNegativo"
        Me.DGVAjuNegativo.Size = New System.Drawing.Size(800, 225)
        Me.DGVAjuNegativo.TabIndex = 1
        '
        'TBAjuNegCantidad
        '
        Me.TBAjuNegCantidad.Location = New System.Drawing.Point(226, 18)
        Me.TBAjuNegCantidad.Name = "TBAjuNegCantidad"
        Me.TBAjuNegCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TBAjuNegCantidad.TabIndex = 15
        '
        'LAjuNegCantidad
        '
        Me.LAjuNegCantidad.AutoSize = True
        Me.LAjuNegCantidad.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuNegCantidad.ForeColor = System.Drawing.Color.White
        Me.LAjuNegCantidad.Location = New System.Drawing.Point(25, 20)
        Me.LAjuNegCantidad.Name = "LAjuNegCantidad"
        Me.LAjuNegCantidad.Size = New System.Drawing.Size(190, 19)
        Me.LAjuNegCantidad.TabIndex = 14
        Me.LAjuNegCantidad.Text = "Cantidad a Incrementar:"
        '
        'CBAjuNegMotivo
        '
        Me.CBAjuNegMotivo.FormattingEnabled = True
        Me.CBAjuNegMotivo.Location = New System.Drawing.Point(519, 18)
        Me.CBAjuNegMotivo.Name = "CBAjuNegMotivo"
        Me.CBAjuNegMotivo.Size = New System.Drawing.Size(121, 21)
        Me.CBAjuNegMotivo.TabIndex = 16
        '
        'LAjuNegMotivo
        '
        Me.LAjuNegMotivo.AutoSize = True
        Me.LAjuNegMotivo.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAjuNegMotivo.ForeColor = System.Drawing.Color.White
        Me.LAjuNegMotivo.Location = New System.Drawing.Point(433, 19)
        Me.LAjuNegMotivo.Name = "LAjuNegMotivo"
        Me.LAjuNegMotivo.Size = New System.Drawing.Size(63, 19)
        Me.LAjuNegMotivo.TabIndex = 17
        Me.LAjuNegMotivo.Text = "Motivo:"
        '
        'BAjuNegCancelar
        '
        Me.BAjuNegCancelar.Location = New System.Drawing.Point(606, 28)
        Me.BAjuNegCancelar.Name = "BAjuNegCancelar"
        Me.BAjuNegCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BAjuNegCancelar.TabIndex = 3
        Me.BAjuNegCancelar.Text = "Cancelar"
        Me.BAjuNegCancelar.UseVisualStyleBackColor = True
        '
        'BAjuNegGuardar
        '
        Me.BAjuNegGuardar.Location = New System.Drawing.Point(687, 28)
        Me.BAjuNegGuardar.Name = "BAjuNegGuardar"
        Me.BAjuNegGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BAjuNegGuardar.TabIndex = 2
        Me.BAjuNegGuardar.Text = "Guardar"
        Me.BAjuNegGuardar.UseVisualStyleBackColor = True
        '
        'FormAjusteSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 448)
        Me.Controls.Add(Me.PanelAjNegBotones)
        Me.Controls.Add(Me.PanelAjNegMod)
        Me.Controls.Add(Me.PanelAjNegData)
        Me.Controls.Add(Me.PanelAjNegFiltros)
        Me.Name = "FormAjusteSalida"
        Me.Text = "FormAjusteSalida"
        Me.PanelAjNegBotones.ResumeLayout(False)
        Me.PanelAjNegMod.ResumeLayout(False)
        Me.PanelAjNegMod.PerformLayout()
        Me.PanelAjNegData.ResumeLayout(False)
        Me.PanelAjNegFiltros.ResumeLayout(False)
        Me.PanelAjNegFiltros.PerformLayout()
        CType(Me.DGVAjuNegativo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAjNegBotones As Panel
    Friend WithEvents PanelAjNegMod As Panel
    Friend WithEvents PanelAjNegData As Panel
    Friend WithEvents PanelAjNegFiltros As Panel
    Friend WithEvents BAjusteNeg As Button
    Friend WithEvents DTPAjuNeg As DateTimePicker
    Friend WithEvents TBAjuNegLote As TextBox
    Friend WithEvents TBAjuNegProducto As TextBox
    Friend WithEvents TBAjuNegCodigo As TextBox
    Friend WithEvents LAjuNegFecha As Label
    Friend WithEvents LAjuNegLote As Label
    Friend WithEvents LAjuNegProducto As Label
    Friend WithEvents LAjuNegCodigo As Label
    Friend WithEvents DGVAjuNegativo As DataGridView
    Friend WithEvents LAjuNegMotivo As Label
    Friend WithEvents CBAjuNegMotivo As ComboBox
    Friend WithEvents TBAjuNegCantidad As TextBox
    Friend WithEvents LAjuNegCantidad As Label
    Friend WithEvents BAjuNegCancelar As Button
    Friend WithEvents BAjuNegGuardar As Button
End Class
