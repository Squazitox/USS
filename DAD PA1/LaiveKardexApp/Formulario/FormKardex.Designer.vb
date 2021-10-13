<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKardex
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
        Me.PKArdexFiltro = New System.Windows.Forms.Panel()
        Me.PKArdexData = New System.Windows.Forms.Panel()
        Me.PKArdexBotones = New System.Windows.Forms.Panel()
        Me.DPTKardexFecha = New System.Windows.Forms.DateTimePicker()
        Me.TBKardexLote = New System.Windows.Forms.TextBox()
        Me.TBKardexProducto = New System.Windows.Forms.TextBox()
        Me.TBKardexCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BKardexImprimir = New FontAwesome.Sharp.IconButton()
        Me.BKardexCancelar = New System.Windows.Forms.Button()
        Me.BKardexGuardar = New System.Windows.Forms.Button()
        Me.BKardexExportar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PKArdexFiltro.SuspendLayout()
        Me.PKArdexData.SuspendLayout()
        Me.PKArdexBotones.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PKArdexFiltro
        '
        Me.PKArdexFiltro.BackColor = System.Drawing.Color.ForestGreen
        Me.PKArdexFiltro.Controls.Add(Me.DPTKardexFecha)
        Me.PKArdexFiltro.Controls.Add(Me.TBKardexLote)
        Me.PKArdexFiltro.Controls.Add(Me.TBKardexProducto)
        Me.PKArdexFiltro.Controls.Add(Me.TBKardexCodigo)
        Me.PKArdexFiltro.Controls.Add(Me.Label4)
        Me.PKArdexFiltro.Controls.Add(Me.Label3)
        Me.PKArdexFiltro.Controls.Add(Me.Label2)
        Me.PKArdexFiltro.Controls.Add(Me.Label1)
        Me.PKArdexFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PKArdexFiltro.Location = New System.Drawing.Point(0, 0)
        Me.PKArdexFiltro.Name = "PKArdexFiltro"
        Me.PKArdexFiltro.Size = New System.Drawing.Size(800, 99)
        Me.PKArdexFiltro.TabIndex = 0
        '
        'PKArdexData
        '
        Me.PKArdexData.Controls.Add(Me.DataGridView1)
        Me.PKArdexData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PKArdexData.Location = New System.Drawing.Point(0, 99)
        Me.PKArdexData.Name = "PKArdexData"
        Me.PKArdexData.Size = New System.Drawing.Size(800, 305)
        Me.PKArdexData.TabIndex = 1
        '
        'PKArdexBotones
        '
        Me.PKArdexBotones.BackColor = System.Drawing.Color.ForestGreen
        Me.PKArdexBotones.Controls.Add(Me.BKardexImprimir)
        Me.PKArdexBotones.Controls.Add(Me.BKardexCancelar)
        Me.PKArdexBotones.Controls.Add(Me.BKardexGuardar)
        Me.PKArdexBotones.Controls.Add(Me.BKardexExportar)
        Me.PKArdexBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PKArdexBotones.Location = New System.Drawing.Point(0, 404)
        Me.PKArdexBotones.Name = "PKArdexBotones"
        Me.PKArdexBotones.Size = New System.Drawing.Size(800, 62)
        Me.PKArdexBotones.TabIndex = 2
        '
        'DPTKardexFecha
        '
        Me.DPTKardexFecha.Location = New System.Drawing.Point(525, 12)
        Me.DPTKardexFecha.Name = "DPTKardexFecha"
        Me.DPTKardexFecha.Size = New System.Drawing.Size(200, 20)
        Me.DPTKardexFecha.TabIndex = 21
        '
        'TBKardexLote
        '
        Me.TBKardexLote.Location = New System.Drawing.Point(626, 60)
        Me.TBKardexLote.Name = "TBKardexLote"
        Me.TBKardexLote.Size = New System.Drawing.Size(99, 20)
        Me.TBKardexLote.TabIndex = 20
        '
        'TBKardexProducto
        '
        Me.TBKardexProducto.Location = New System.Drawing.Point(226, 60)
        Me.TBKardexProducto.Name = "TBKardexProducto"
        Me.TBKardexProducto.Size = New System.Drawing.Size(271, 20)
        Me.TBKardexProducto.TabIndex = 19
        '
        'TBKardexCodigo
        '
        Me.TBKardexCodigo.Location = New System.Drawing.Point(226, 12)
        Me.TBKardexCodigo.Name = "TBKardexCodigo"
        Me.TBKardexCodigo.Size = New System.Drawing.Size(164, 20)
        Me.TBKardexCodigo.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(406, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "F. Vencimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(556, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Lote:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripción del Producto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Codigo de Producto:"
        '
        'BKardexImprimir
        '
        Me.BKardexImprimir.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.BKardexImprimir.IconColor = System.Drawing.Color.Black
        Me.BKardexImprimir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BKardexImprimir.IconSize = 20
        Me.BKardexImprimir.Location = New System.Drawing.Point(134, 17)
        Me.BKardexImprimir.Name = "BKardexImprimir"
        Me.BKardexImprimir.Size = New System.Drawing.Size(39, 32)
        Me.BKardexImprimir.TabIndex = 7
        Me.BKardexImprimir.UseVisualStyleBackColor = True
        '
        'BKardexCancelar
        '
        Me.BKardexCancelar.Location = New System.Drawing.Point(604, 26)
        Me.BKardexCancelar.Name = "BKardexCancelar"
        Me.BKardexCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BKardexCancelar.TabIndex = 6
        Me.BKardexCancelar.Text = "Cancelar"
        Me.BKardexCancelar.UseVisualStyleBackColor = True
        '
        'BKardexGuardar
        '
        Me.BKardexGuardar.Location = New System.Drawing.Point(697, 26)
        Me.BKardexGuardar.Name = "BKardexGuardar"
        Me.BKardexGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BKardexGuardar.TabIndex = 5
        Me.BKardexGuardar.Text = "Consultar"
        Me.BKardexGuardar.UseVisualStyleBackColor = True
        '
        'BKardexExportar
        '
        Me.BKardexExportar.Location = New System.Drawing.Point(31, 22)
        Me.BKardexExportar.Name = "BKardexExportar"
        Me.BKardexExportar.Size = New System.Drawing.Size(75, 23)
        Me.BKardexExportar.TabIndex = 4
        Me.BKardexExportar.Text = "Exportar"
        Me.BKardexExportar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(800, 305)
        Me.DataGridView1.TabIndex = 0
        '
        'FormKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.Controls.Add(Me.PKArdexBotones)
        Me.Controls.Add(Me.PKArdexData)
        Me.Controls.Add(Me.PKArdexFiltro)
        Me.Name = "FormKardex"
        Me.Text = "FormKardex"
        Me.PKArdexFiltro.ResumeLayout(False)
        Me.PKArdexFiltro.PerformLayout()
        Me.PKArdexData.ResumeLayout(False)
        Me.PKArdexBotones.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PKArdexFiltro As Panel
    Friend WithEvents PKArdexData As Panel
    Friend WithEvents PKArdexBotones As Panel
    Friend WithEvents DPTKardexFecha As DateTimePicker
    Friend WithEvents TBKardexLote As TextBox
    Friend WithEvents TBKardexProducto As TextBox
    Friend WithEvents TBKardexCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BKardexImprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents BKardexCancelar As Button
    Friend WithEvents BKardexGuardar As Button
    Friend WithEvents BKardexExportar As Button
End Class
