<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSalida
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
        Me.PSalidaFiltros = New System.Windows.Forms.Panel()
        Me.BSalidaIngresar = New System.Windows.Forms.Button()
        Me.DTPSalida = New System.Windows.Forms.DateTimePicker()
        Me.TBSalidaProveedor = New System.Windows.Forms.TextBox()
        Me.TBSalidaLote = New System.Windows.Forms.TextBox()
        Me.TBSalidaCantidad = New System.Windows.Forms.TextBox()
        Me.TBSalidaCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PSalidaData = New System.Windows.Forms.Panel()
        Me.DGVSalida = New System.Windows.Forms.DataGridView()
        Me.PSalidaBotones = New System.Windows.Forms.Panel()
        Me.BSalidaImprimir = New FontAwesome.Sharp.IconButton()
        Me.BSalidaCancelar = New System.Windows.Forms.Button()
        Me.BSalidaGuardar = New System.Windows.Forms.Button()
        Me.BSalidaExportar = New System.Windows.Forms.Button()
        Me.BSalidaEliminar = New System.Windows.Forms.Button()
        Me.PSalidaFiltros.SuspendLayout()
        Me.PSalidaData.SuspendLayout()
        CType(Me.DGVSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PSalidaBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PSalidaFiltros
        '
        Me.PSalidaFiltros.BackColor = System.Drawing.Color.ForestGreen
        Me.PSalidaFiltros.Controls.Add(Me.BSalidaEliminar)
        Me.PSalidaFiltros.Controls.Add(Me.BSalidaIngresar)
        Me.PSalidaFiltros.Controls.Add(Me.DTPSalida)
        Me.PSalidaFiltros.Controls.Add(Me.TBSalidaProveedor)
        Me.PSalidaFiltros.Controls.Add(Me.TBSalidaLote)
        Me.PSalidaFiltros.Controls.Add(Me.TBSalidaCantidad)
        Me.PSalidaFiltros.Controls.Add(Me.TBSalidaCodigo)
        Me.PSalidaFiltros.Controls.Add(Me.Label5)
        Me.PSalidaFiltros.Controls.Add(Me.Label4)
        Me.PSalidaFiltros.Controls.Add(Me.Label3)
        Me.PSalidaFiltros.Controls.Add(Me.Label2)
        Me.PSalidaFiltros.Controls.Add(Me.Label1)
        Me.PSalidaFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSalidaFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PSalidaFiltros.Name = "PSalidaFiltros"
        Me.PSalidaFiltros.Size = New System.Drawing.Size(800, 115)
        Me.PSalidaFiltros.TabIndex = 0
        '
        'BSalidaIngresar
        '
        Me.BSalidaIngresar.Location = New System.Drawing.Point(678, 68)
        Me.BSalidaIngresar.Name = "BSalidaIngresar"
        Me.BSalidaIngresar.Size = New System.Drawing.Size(75, 33)
        Me.BSalidaIngresar.TabIndex = 15
        Me.BSalidaIngresar.Text = "Ingresar"
        Me.BSalidaIngresar.UseVisualStyleBackColor = True
        '
        'DTPSalida
        '
        Me.DTPSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPSalida.Location = New System.Drawing.Point(243, 75)
        Me.DTPSalida.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DTPSalida.Name = "DTPSalida"
        Me.DTPSalida.Size = New System.Drawing.Size(96, 20)
        Me.DTPSalida.TabIndex = 13
        '
        'TBSalidaProveedor
        '
        Me.TBSalidaProveedor.Location = New System.Drawing.Point(520, 12)
        Me.TBSalidaProveedor.Name = "TBSalidaProveedor"
        Me.TBSalidaProveedor.Size = New System.Drawing.Size(242, 20)
        Me.TBSalidaProveedor.TabIndex = 11
        '
        'TBSalidaLote
        '
        Me.TBSalidaLote.Location = New System.Drawing.Point(520, 38)
        Me.TBSalidaLote.Name = "TBSalidaLote"
        Me.TBSalidaLote.Size = New System.Drawing.Size(242, 20)
        Me.TBSalidaLote.TabIndex = 9
        '
        'TBSalidaCantidad
        '
        Me.TBSalidaCantidad.Location = New System.Drawing.Point(175, 40)
        Me.TBSalidaCantidad.Name = "TBSalidaCantidad"
        Me.TBSalidaCantidad.Size = New System.Drawing.Size(164, 20)
        Me.TBSalidaCantidad.TabIndex = 8
        '
        'TBSalidaCodigo
        '
        Me.TBSalidaCodigo.Location = New System.Drawing.Point(175, 14)
        Me.TBSalidaCodigo.Name = "TBSalidaCodigo"
        Me.TBSalidaCodigo.Size = New System.Drawing.Size(164, 20)
        Me.TBSalidaCodigo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(396, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Planta Destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 76)
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
        Me.Label3.Location = New System.Drawing.Point(435, 41)
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
        Me.Label2.Location = New System.Drawing.Point(12, 43)
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
        'PSalidaData
        '
        Me.PSalidaData.Controls.Add(Me.DGVSalida)
        Me.PSalidaData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSalidaData.Location = New System.Drawing.Point(0, 115)
        Me.PSalidaData.Name = "PSalidaData"
        Me.PSalidaData.Size = New System.Drawing.Size(800, 285)
        Me.PSalidaData.TabIndex = 1
        '
        'DGVSalida
        '
        Me.DGVSalida.AllowUserToOrderColumns = True
        Me.DGVSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVSalida.Location = New System.Drawing.Point(0, 0)
        Me.DGVSalida.Name = "DGVSalida"
        Me.DGVSalida.Size = New System.Drawing.Size(800, 285)
        Me.DGVSalida.TabIndex = 0
        '
        'PSalidaBotones
        '
        Me.PSalidaBotones.BackColor = System.Drawing.Color.ForestGreen
        Me.PSalidaBotones.Controls.Add(Me.BSalidaImprimir)
        Me.PSalidaBotones.Controls.Add(Me.BSalidaCancelar)
        Me.PSalidaBotones.Controls.Add(Me.BSalidaGuardar)
        Me.PSalidaBotones.Controls.Add(Me.BSalidaExportar)
        Me.PSalidaBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSalidaBotones.Location = New System.Drawing.Point(0, 400)
        Me.PSalidaBotones.Name = "PSalidaBotones"
        Me.PSalidaBotones.Size = New System.Drawing.Size(800, 64)
        Me.PSalidaBotones.TabIndex = 2
        '
        'BSalidaImprimir
        '
        Me.BSalidaImprimir.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.BSalidaImprimir.IconColor = System.Drawing.Color.Black
        Me.BSalidaImprimir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BSalidaImprimir.IconSize = 20
        Me.BSalidaImprimir.Location = New System.Drawing.Point(109, 11)
        Me.BSalidaImprimir.Name = "BSalidaImprimir"
        Me.BSalidaImprimir.Size = New System.Drawing.Size(39, 32)
        Me.BSalidaImprimir.TabIndex = 3
        Me.BSalidaImprimir.UseVisualStyleBackColor = True
        '
        'BSalidaCancelar
        '
        Me.BSalidaCancelar.Location = New System.Drawing.Point(583, 16)
        Me.BSalidaCancelar.Name = "BSalidaCancelar"
        Me.BSalidaCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BSalidaCancelar.TabIndex = 2
        Me.BSalidaCancelar.Text = "Cancelar"
        Me.BSalidaCancelar.UseVisualStyleBackColor = True
        '
        'BSalidaGuardar
        '
        Me.BSalidaGuardar.Location = New System.Drawing.Point(678, 16)
        Me.BSalidaGuardar.Name = "BSalidaGuardar"
        Me.BSalidaGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BSalidaGuardar.TabIndex = 1
        Me.BSalidaGuardar.Text = "Guardar"
        Me.BSalidaGuardar.UseVisualStyleBackColor = True
        '
        'BSalidaExportar
        '
        Me.BSalidaExportar.Location = New System.Drawing.Point(12, 16)
        Me.BSalidaExportar.Name = "BSalidaExportar"
        Me.BSalidaExportar.Size = New System.Drawing.Size(75, 23)
        Me.BSalidaExportar.TabIndex = 0
        Me.BSalidaExportar.Text = "Exportar"
        Me.BSalidaExportar.UseVisualStyleBackColor = True
        '
        'BSalidaEliminar
        '
        Me.BSalidaEliminar.Location = New System.Drawing.Point(597, 68)
        Me.BSalidaEliminar.Name = "BSalidaEliminar"
        Me.BSalidaEliminar.Size = New System.Drawing.Size(75, 33)
        Me.BSalidaEliminar.TabIndex = 16
        Me.BSalidaEliminar.Text = "Eliminar"
        Me.BSalidaEliminar.UseVisualStyleBackColor = True
        '
        'FormSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 456)
        Me.Controls.Add(Me.PSalidaBotones)
        Me.Controls.Add(Me.PSalidaData)
        Me.Controls.Add(Me.PSalidaFiltros)
        Me.Name = "FormSalida"
        Me.Text = "FormIngreso"
        Me.PSalidaFiltros.ResumeLayout(False)
        Me.PSalidaFiltros.PerformLayout()
        Me.PSalidaData.ResumeLayout(False)
        CType(Me.DGVSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PSalidaBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PSalidaFiltros As Panel
    Friend WithEvents BSalidaIngresar As Button
    Friend WithEvents DTPSalida As DateTimePicker
    Friend WithEvents TBSalidaProveedor As TextBox
    Friend WithEvents TBSalidaLote As TextBox
    Friend WithEvents TBSalidaCantidad As TextBox
    Friend WithEvents TBSalidaCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PSalidaData As Panel
    Friend WithEvents DGVSalida As DataGridView
    Friend WithEvents PSalidaBotones As Panel
    Friend WithEvents BSalidaImprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents BSalidaCancelar As Button
    Friend WithEvents BSalidaGuardar As Button
    Friend WithEvents BSalidaExportar As Button
    Friend WithEvents BSalidaEliminar As Button
End Class
