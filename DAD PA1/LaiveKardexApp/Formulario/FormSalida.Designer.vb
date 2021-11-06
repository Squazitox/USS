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
        Me.DTCreacion = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBSalidaArea = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBSalidaTrabajador = New System.Windows.Forms.ComboBox()
        Me.CBSalidaUbicacion = New System.Windows.Forms.ComboBox()
        Me.CBSalidaCodigo = New System.Windows.Forms.ComboBox()
        Me.BSalidaEliminar = New System.Windows.Forms.Button()
        Me.BSalidaIngresar = New System.Windows.Forms.Button()
        Me.DTPSalida = New System.Windows.Forms.DateTimePicker()
        Me.TBSalidaCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PSalidaData = New System.Windows.Forms.Panel()
        Me.DGVSalida = New System.Windows.Forms.DataGridView()
        Me.PSalidaBotones = New System.Windows.Forms.Panel()
        Me.BSalidaCancelar = New System.Windows.Forms.Button()
        Me.BSalidaGuardar = New System.Windows.Forms.Button()
        Me.CBSalidaLote = New System.Windows.Forms.ComboBox()
        Me.PSalidaFiltros.SuspendLayout()
        Me.PSalidaData.SuspendLayout()
        CType(Me.DGVSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PSalidaBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PSalidaFiltros
        '
        Me.PSalidaFiltros.BackColor = System.Drawing.Color.ForestGreen
        Me.PSalidaFiltros.Controls.Add(Me.CBSalidaLote)
        Me.PSalidaFiltros.Controls.Add(Me.DTCreacion)
        Me.PSalidaFiltros.Controls.Add(Me.Label7)
        Me.PSalidaFiltros.Controls.Add(Me.CBSalidaArea)
        Me.PSalidaFiltros.Controls.Add(Me.Label6)
        Me.PSalidaFiltros.Controls.Add(Me.CBSalidaTrabajador)
        Me.PSalidaFiltros.Controls.Add(Me.CBSalidaUbicacion)
        Me.PSalidaFiltros.Controls.Add(Me.CBSalidaCodigo)
        Me.PSalidaFiltros.Controls.Add(Me.BSalidaEliminar)
        Me.PSalidaFiltros.Controls.Add(Me.BSalidaIngresar)
        Me.PSalidaFiltros.Controls.Add(Me.DTPSalida)
        Me.PSalidaFiltros.Controls.Add(Me.TBSalidaCantidad)
        Me.PSalidaFiltros.Controls.Add(Me.Label5)
        Me.PSalidaFiltros.Controls.Add(Me.Label4)
        Me.PSalidaFiltros.Controls.Add(Me.Label3)
        Me.PSalidaFiltros.Controls.Add(Me.Label2)
        Me.PSalidaFiltros.Controls.Add(Me.Label1)
        Me.PSalidaFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSalidaFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PSalidaFiltros.Name = "PSalidaFiltros"
        Me.PSalidaFiltros.Size = New System.Drawing.Size(800, 128)
        Me.PSalidaFiltros.TabIndex = 0
        '
        'DTCreacion
        '
        Me.DTCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTCreacion.Location = New System.Drawing.Point(689, 13)
        Me.DTCreacion.MinDate = New Date(2021, 10, 1, 0, 0, 0, 0)
        Me.DTCreacion.Name = "DTCreacion"
        Me.DTCreacion.Size = New System.Drawing.Size(99, 20)
        Me.DTCreacion.TabIndex = 26
        Me.DTCreacion.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(396, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Lote:"
        '
        'CBSalidaArea
        '
        Me.CBSalidaArea.FormattingEnabled = True
        Me.CBSalidaArea.Location = New System.Drawing.Point(526, 45)
        Me.CBSalidaArea.Name = "CBSalidaArea"
        Me.CBSalidaArea.Size = New System.Drawing.Size(161, 21)
        Me.CBSalidaArea.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Trabajador"
        '
        'CBSalidaTrabajador
        '
        Me.CBSalidaTrabajador.FormattingEnabled = True
        Me.CBSalidaTrabajador.Location = New System.Drawing.Point(96, 41)
        Me.CBSalidaTrabajador.Name = "CBSalidaTrabajador"
        Me.CBSalidaTrabajador.Size = New System.Drawing.Size(263, 21)
        Me.CBSalidaTrabajador.TabIndex = 18
        '
        'CBSalidaUbicacion
        '
        Me.CBSalidaUbicacion.FormattingEnabled = True
        Me.CBSalidaUbicacion.Location = New System.Drawing.Point(526, 13)
        Me.CBSalidaUbicacion.Name = "CBSalidaUbicacion"
        Me.CBSalidaUbicacion.Size = New System.Drawing.Size(106, 21)
        Me.CBSalidaUbicacion.TabIndex = 17
        '
        'CBSalidaCodigo
        '
        Me.CBSalidaCodigo.FormattingEnabled = True
        Me.CBSalidaCodigo.Location = New System.Drawing.Point(96, 15)
        Me.CBSalidaCodigo.Name = "CBSalidaCodigo"
        Me.CBSalidaCodigo.Size = New System.Drawing.Size(263, 21)
        Me.CBSalidaCodigo.TabIndex = 1
        '
        'BSalidaEliminar
        '
        Me.BSalidaEliminar.BackColor = System.Drawing.Color.White
        Me.BSalidaEliminar.Location = New System.Drawing.Point(632, 86)
        Me.BSalidaEliminar.Name = "BSalidaEliminar"
        Me.BSalidaEliminar.Size = New System.Drawing.Size(75, 33)
        Me.BSalidaEliminar.TabIndex = 16
        Me.BSalidaEliminar.Text = "Eliminar"
        Me.BSalidaEliminar.UseVisualStyleBackColor = False
        '
        'BSalidaIngresar
        '
        Me.BSalidaIngresar.BackColor = System.Drawing.Color.White
        Me.BSalidaIngresar.Location = New System.Drawing.Point(713, 86)
        Me.BSalidaIngresar.Name = "BSalidaIngresar"
        Me.BSalidaIngresar.Size = New System.Drawing.Size(75, 33)
        Me.BSalidaIngresar.TabIndex = 15
        Me.BSalidaIngresar.Text = "Ingresar"
        Me.BSalidaIngresar.UseVisualStyleBackColor = False
        '
        'DTPSalida
        '
        Me.DTPSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPSalida.Location = New System.Drawing.Point(130, 99)
        Me.DTPSalida.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DTPSalida.Name = "DTPSalida"
        Me.DTPSalida.Size = New System.Drawing.Size(96, 20)
        Me.DTPSalida.TabIndex = 13
        '
        'TBSalidaCantidad
        '
        Me.TBSalidaCantidad.Location = New System.Drawing.Point(96, 68)
        Me.TBSalidaCantidad.Name = "TBSalidaCantidad"
        Me.TBSalidaCantidad.Size = New System.Drawing.Size(83, 20)
        Me.TBSalidaCantidad.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(396, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ubicacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "F. Vencimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(396, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Planta de Destino:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 76)
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
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'PSalidaData
        '
        Me.PSalidaData.Controls.Add(Me.DGVSalida)
        Me.PSalidaData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSalidaData.Location = New System.Drawing.Point(0, 128)
        Me.PSalidaData.Name = "PSalidaData"
        Me.PSalidaData.Size = New System.Drawing.Size(800, 285)
        Me.PSalidaData.TabIndex = 1
        '
        'DGVSalida
        '
        Me.DGVSalida.AllowUserToAddRows = False
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
        Me.PSalidaBotones.Controls.Add(Me.BSalidaCancelar)
        Me.PSalidaBotones.Controls.Add(Me.BSalidaGuardar)
        Me.PSalidaBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSalidaBotones.Location = New System.Drawing.Point(0, 413)
        Me.PSalidaBotones.Name = "PSalidaBotones"
        Me.PSalidaBotones.Size = New System.Drawing.Size(800, 44)
        Me.PSalidaBotones.TabIndex = 2
        '
        'BSalidaCancelar
        '
        Me.BSalidaCancelar.BackColor = System.Drawing.Color.White
        Me.BSalidaCancelar.Location = New System.Drawing.Point(583, 16)
        Me.BSalidaCancelar.Name = "BSalidaCancelar"
        Me.BSalidaCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BSalidaCancelar.TabIndex = 2
        Me.BSalidaCancelar.Text = "Cancelar"
        Me.BSalidaCancelar.UseVisualStyleBackColor = False
        '
        'BSalidaGuardar
        '
        Me.BSalidaGuardar.BackColor = System.Drawing.Color.White
        Me.BSalidaGuardar.Location = New System.Drawing.Point(678, 16)
        Me.BSalidaGuardar.Name = "BSalidaGuardar"
        Me.BSalidaGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BSalidaGuardar.TabIndex = 1
        Me.BSalidaGuardar.Text = "Guardar"
        Me.BSalidaGuardar.UseVisualStyleBackColor = False
        '
        'CBSalidaLote
        '
        Me.CBSalidaLote.FormattingEnabled = True
        Me.CBSalidaLote.Location = New System.Drawing.Point(442, 71)
        Me.CBSalidaLote.Name = "CBSalidaLote"
        Me.CBSalidaLote.Size = New System.Drawing.Size(134, 21)
        Me.CBSalidaLote.TabIndex = 27
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
        Me.Text = "FormSalida"
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
    Friend WithEvents TBSalidaCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PSalidaData As Panel
    Friend WithEvents DGVSalida As DataGridView
    Friend WithEvents PSalidaBotones As Panel
    Friend WithEvents BSalidaCancelar As Button
    Friend WithEvents BSalidaGuardar As Button
    Friend WithEvents BSalidaEliminar As Button
    Friend WithEvents CBSalidaUbicacion As ComboBox
    Friend WithEvents CBSalidaCodigo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CBSalidaArea As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CBSalidaTrabajador As ComboBox
    Friend WithEvents DTCreacion As DateTimePicker
    Friend WithEvents CBSalidaLote As ComboBox
End Class
