<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTraspaso
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
        Me.PanelTraspBotProd = New System.Windows.Forms.Panel()
        Me.PanelTraspFiltProd = New System.Windows.Forms.Panel()
        Me.PanelTraspBotConfirm = New System.Windows.Forms.Panel()
        Me.PanelTrasProdIzq = New System.Windows.Forms.Panel()
        Me.PanelTrasProdDer = New System.Windows.Forms.Panel()
        Me.BTrasPro1 = New System.Windows.Forms.Button()
        Me.BTrasPro2 = New System.Windows.Forms.Button()
        Me.BTrasPos = New System.Windows.Forms.Button()
        Me.DTrasPos = New System.Windows.Forms.DateTimePicker()
        Me.TTrasLote = New System.Windows.Forms.TextBox()
        Me.TTrasProducto = New System.Windows.Forms.TextBox()
        Me.TTrasCodigo = New System.Windows.Forms.TextBox()
        Me.LTrasFecha = New System.Windows.Forms.Label()
        Me.LTrasLote = New System.Windows.Forms.Label()
        Me.LTrasProducto = New System.Windows.Forms.Label()
        Me.LTrasCodigo = New System.Windows.Forms.Label()
        Me.LTrasPro1 = New System.Windows.Forms.Label()
        Me.LTrasPro2 = New System.Windows.Forms.Label()
        Me.DGVTrasProd1 = New System.Windows.Forms.DataGridView()
        Me.DGVTrasProd2 = New System.Windows.Forms.DataGridView()
        Me.BTrasEnvioProd1 = New System.Windows.Forms.Button()
        Me.BTrasEnvioProd2 = New System.Windows.Forms.Button()
        Me.BTrasGuardar = New System.Windows.Forms.Button()
        Me.BTrasCancelar = New System.Windows.Forms.Button()
        Me.PanelTraspBotProd.SuspendLayout()
        Me.PanelTraspFiltProd.SuspendLayout()
        Me.PanelTraspBotConfirm.SuspendLayout()
        Me.PanelTrasProdIzq.SuspendLayout()
        Me.PanelTrasProdDer.SuspendLayout()
        CType(Me.DGVTrasProd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVTrasProd2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTraspBotProd
        '
        Me.PanelTraspBotProd.Controls.Add(Me.BTrasPro2)
        Me.PanelTraspBotProd.Controls.Add(Me.BTrasPro1)
        Me.PanelTraspBotProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTraspBotProd.Location = New System.Drawing.Point(0, 0)
        Me.PanelTraspBotProd.Name = "PanelTraspBotProd"
        Me.PanelTraspBotProd.Size = New System.Drawing.Size(797, 57)
        Me.PanelTraspBotProd.TabIndex = 0
        '
        'PanelTraspFiltProd
        '
        Me.PanelTraspFiltProd.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelTraspFiltProd.Controls.Add(Me.BTrasPos)
        Me.PanelTraspFiltProd.Controls.Add(Me.DTrasPos)
        Me.PanelTraspFiltProd.Controls.Add(Me.TTrasLote)
        Me.PanelTraspFiltProd.Controls.Add(Me.TTrasProducto)
        Me.PanelTraspFiltProd.Controls.Add(Me.TTrasCodigo)
        Me.PanelTraspFiltProd.Controls.Add(Me.LTrasFecha)
        Me.PanelTraspFiltProd.Controls.Add(Me.LTrasLote)
        Me.PanelTraspFiltProd.Controls.Add(Me.LTrasProducto)
        Me.PanelTraspFiltProd.Controls.Add(Me.LTrasCodigo)
        Me.PanelTraspFiltProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTraspFiltProd.Location = New System.Drawing.Point(0, 57)
        Me.PanelTraspFiltProd.Name = "PanelTraspFiltProd"
        Me.PanelTraspFiltProd.Size = New System.Drawing.Size(797, 100)
        Me.PanelTraspFiltProd.TabIndex = 1
        '
        'PanelTraspBotConfirm
        '
        Me.PanelTraspBotConfirm.Controls.Add(Me.BTrasCancelar)
        Me.PanelTraspBotConfirm.Controls.Add(Me.BTrasGuardar)
        Me.PanelTraspBotConfirm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTraspBotConfirm.Location = New System.Drawing.Point(0, 394)
        Me.PanelTraspBotConfirm.Name = "PanelTraspBotConfirm"
        Me.PanelTraspBotConfirm.Size = New System.Drawing.Size(797, 54)
        Me.PanelTraspBotConfirm.TabIndex = 2
        '
        'PanelTrasProdIzq
        '
        Me.PanelTrasProdIzq.Controls.Add(Me.BTrasEnvioProd1)
        Me.PanelTrasProdIzq.Controls.Add(Me.DGVTrasProd1)
        Me.PanelTrasProdIzq.Controls.Add(Me.LTrasPro1)
        Me.PanelTrasProdIzq.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelTrasProdIzq.Location = New System.Drawing.Point(0, 157)
        Me.PanelTrasProdIzq.Name = "PanelTrasProdIzq"
        Me.PanelTrasProdIzq.Size = New System.Drawing.Size(400, 237)
        Me.PanelTrasProdIzq.TabIndex = 3
        '
        'PanelTrasProdDer
        '
        Me.PanelTrasProdDer.Controls.Add(Me.BTrasEnvioProd2)
        Me.PanelTrasProdDer.Controls.Add(Me.DGVTrasProd2)
        Me.PanelTrasProdDer.Controls.Add(Me.LTrasPro2)
        Me.PanelTrasProdDer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTrasProdDer.Location = New System.Drawing.Point(400, 157)
        Me.PanelTrasProdDer.Name = "PanelTrasProdDer"
        Me.PanelTrasProdDer.Size = New System.Drawing.Size(397, 237)
        Me.PanelTrasProdDer.TabIndex = 4
        '
        'BTrasPro1
        '
        Me.BTrasPro1.BackColor = System.Drawing.Color.White
        Me.BTrasPro1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTrasPro1.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.BTrasPro1.FlatAppearance.BorderSize = 3
        Me.BTrasPro1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTrasPro1.Location = New System.Drawing.Point(0, 0)
        Me.BTrasPro1.Name = "BTrasPro1"
        Me.BTrasPro1.Size = New System.Drawing.Size(127, 57)
        Me.BTrasPro1.TabIndex = 0
        Me.BTrasPro1.Text = "Producto 1"
        Me.BTrasPro1.UseVisualStyleBackColor = False
        '
        'BTrasPro2
        '
        Me.BTrasPro2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTrasPro2.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.BTrasPro2.FlatAppearance.BorderSize = 3
        Me.BTrasPro2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTrasPro2.Location = New System.Drawing.Point(127, 0)
        Me.BTrasPro2.Name = "BTrasPro2"
        Me.BTrasPro2.Size = New System.Drawing.Size(127, 57)
        Me.BTrasPro2.TabIndex = 1
        Me.BTrasPro2.Text = "Producto 2"
        Me.BTrasPro2.UseVisualStyleBackColor = True
        '
        'BTrasPos
        '
        Me.BTrasPos.Location = New System.Drawing.Point(700, 22)
        Me.BTrasPos.Name = "BTrasPos"
        Me.BTrasPos.Size = New System.Drawing.Size(75, 23)
        Me.BTrasPos.TabIndex = 17
        Me.BTrasPos.Text = "Buscar"
        Me.BTrasPos.UseVisualStyleBackColor = True
        '
        'DTrasPos
        '
        Me.DTrasPos.Location = New System.Drawing.Point(487, 59)
        Me.DTrasPos.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DTrasPos.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DTrasPos.Name = "DTrasPos"
        Me.DTrasPos.Size = New System.Drawing.Size(200, 20)
        Me.DTrasPos.TabIndex = 16
        '
        'TTrasLote
        '
        Me.TTrasLote.Location = New System.Drawing.Point(487, 18)
        Me.TTrasLote.Name = "TTrasLote"
        Me.TTrasLote.Size = New System.Drawing.Size(100, 20)
        Me.TTrasLote.TabIndex = 15
        '
        'TTrasProducto
        '
        Me.TTrasProducto.Location = New System.Drawing.Point(226, 62)
        Me.TTrasProducto.Name = "TTrasProducto"
        Me.TTrasProducto.Size = New System.Drawing.Size(100, 20)
        Me.TTrasProducto.TabIndex = 14
        '
        'TTrasCodigo
        '
        Me.TTrasCodigo.Location = New System.Drawing.Point(226, 18)
        Me.TTrasCodigo.Name = "TTrasCodigo"
        Me.TTrasCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TTrasCodigo.TabIndex = 13
        '
        'LTrasFecha
        '
        Me.LTrasFecha.AutoSize = True
        Me.LTrasFecha.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTrasFecha.ForeColor = System.Drawing.Color.White
        Me.LTrasFecha.Location = New System.Drawing.Point(368, 62)
        Me.LTrasFecha.Name = "LTrasFecha"
        Me.LTrasFecha.Size = New System.Drawing.Size(113, 19)
        Me.LTrasFecha.TabIndex = 12
        Me.LTrasFecha.Text = "F. Vencimiento"
        '
        'LTrasLote
        '
        Me.LTrasLote.AutoSize = True
        Me.LTrasLote.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTrasLote.ForeColor = System.Drawing.Color.White
        Me.LTrasLote.Location = New System.Drawing.Point(368, 19)
        Me.LTrasLote.Name = "LTrasLote"
        Me.LTrasLote.Size = New System.Drawing.Size(40, 19)
        Me.LTrasLote.TabIndex = 11
        Me.LTrasLote.Text = "Lote"
        '
        'LTrasProducto
        '
        Me.LTrasProducto.AutoSize = True
        Me.LTrasProducto.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTrasProducto.ForeColor = System.Drawing.Color.White
        Me.LTrasProducto.Location = New System.Drawing.Point(25, 63)
        Me.LTrasProducto.Name = "LTrasProducto"
        Me.LTrasProducto.Size = New System.Drawing.Size(195, 19)
        Me.LTrasProducto.TabIndex = 10
        Me.LTrasProducto.Text = "Descripcion del Producto:"
        '
        'LTrasCodigo
        '
        Me.LTrasCodigo.AutoSize = True
        Me.LTrasCodigo.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTrasCodigo.ForeColor = System.Drawing.Color.White
        Me.LTrasCodigo.Location = New System.Drawing.Point(25, 23)
        Me.LTrasCodigo.Name = "LTrasCodigo"
        Me.LTrasCodigo.Size = New System.Drawing.Size(157, 19)
        Me.LTrasCodigo.TabIndex = 9
        Me.LTrasCodigo.Text = "Codigo de Producto:"
        '
        'LTrasPro1
        '
        Me.LTrasPro1.AutoSize = True
        Me.LTrasPro1.Location = New System.Drawing.Point(13, 7)
        Me.LTrasPro1.Name = "LTrasPro1"
        Me.LTrasPro1.Size = New System.Drawing.Size(89, 13)
        Me.LTrasPro1.TabIndex = 0
        Me.LTrasPro1.Text = "Producto 1 - Lote"
        '
        'LTrasPro2
        '
        Me.LTrasPro2.AutoSize = True
        Me.LTrasPro2.Location = New System.Drawing.Point(295, 7)
        Me.LTrasPro2.Name = "LTrasPro2"
        Me.LTrasPro2.Size = New System.Drawing.Size(89, 13)
        Me.LTrasPro2.TabIndex = 0
        Me.LTrasPro2.Text = "Producto 2 - Lote"
        '
        'DGVTrasProd1
        '
        Me.DGVTrasProd1.AllowUserToOrderColumns = True
        Me.DGVTrasProd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTrasProd1.Location = New System.Drawing.Point(14, 23)
        Me.DGVTrasProd1.Name = "DGVTrasProd1"
        Me.DGVTrasProd1.Size = New System.Drawing.Size(294, 191)
        Me.DGVTrasProd1.TabIndex = 1
        '
        'DGVTrasProd2
        '
        Me.DGVTrasProd2.AllowUserToOrderColumns = True
        Me.DGVTrasProd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTrasProd2.Location = New System.Drawing.Point(90, 23)
        Me.DGVTrasProd2.Name = "DGVTrasProd2"
        Me.DGVTrasProd2.Size = New System.Drawing.Size(294, 191)
        Me.DGVTrasProd2.TabIndex = 2
        '
        'BTrasEnvioProd1
        '
        Me.BTrasEnvioProd1.Location = New System.Drawing.Point(314, 76)
        Me.BTrasEnvioProd1.Name = "BTrasEnvioProd1"
        Me.BTrasEnvioProd1.Size = New System.Drawing.Size(75, 46)
        Me.BTrasEnvioProd1.TabIndex = 2
        Me.BTrasEnvioProd1.Text = "Enviar a  Derecha"
        Me.BTrasEnvioProd1.UseVisualStyleBackColor = True
        '
        'BTrasEnvioProd2
        '
        Me.BTrasEnvioProd2.Location = New System.Drawing.Point(6, 76)
        Me.BTrasEnvioProd2.Name = "BTrasEnvioProd2"
        Me.BTrasEnvioProd2.Size = New System.Drawing.Size(75, 46)
        Me.BTrasEnvioProd2.TabIndex = 3
        Me.BTrasEnvioProd2.Text = "Enviar a Izquierda"
        Me.BTrasEnvioProd2.UseVisualStyleBackColor = True
        '
        'BTrasGuardar
        '
        Me.BTrasGuardar.Location = New System.Drawing.Point(698, 19)
        Me.BTrasGuardar.Name = "BTrasGuardar"
        Me.BTrasGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTrasGuardar.TabIndex = 0
        Me.BTrasGuardar.Text = "Guardar"
        Me.BTrasGuardar.UseVisualStyleBackColor = True
        '
        'BTrasCancelar
        '
        Me.BTrasCancelar.Location = New System.Drawing.Point(600, 19)
        Me.BTrasCancelar.Name = "BTrasCancelar"
        Me.BTrasCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTrasCancelar.TabIndex = 1
        Me.BTrasCancelar.Text = "Cancelar"
        Me.BTrasCancelar.UseVisualStyleBackColor = True
        '
        'FormTraspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 448)
        Me.Controls.Add(Me.PanelTrasProdDer)
        Me.Controls.Add(Me.PanelTrasProdIzq)
        Me.Controls.Add(Me.PanelTraspBotConfirm)
        Me.Controls.Add(Me.PanelTraspFiltProd)
        Me.Controls.Add(Me.PanelTraspBotProd)
        Me.Name = "FormTraspaso"
        Me.Text = "FormTraspaso"
        Me.PanelTraspBotProd.ResumeLayout(False)
        Me.PanelTraspFiltProd.ResumeLayout(False)
        Me.PanelTraspFiltProd.PerformLayout()
        Me.PanelTraspBotConfirm.ResumeLayout(False)
        Me.PanelTrasProdIzq.ResumeLayout(False)
        Me.PanelTrasProdIzq.PerformLayout()
        Me.PanelTrasProdDer.ResumeLayout(False)
        Me.PanelTrasProdDer.PerformLayout()
        CType(Me.DGVTrasProd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVTrasProd2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTraspBotProd As Panel
    Friend WithEvents PanelTraspFiltProd As Panel
    Friend WithEvents PanelTraspBotConfirm As Panel
    Friend WithEvents PanelTrasProdIzq As Panel
    Friend WithEvents PanelTrasProdDer As Panel
    Friend WithEvents BTrasPro2 As Button
    Friend WithEvents BTrasPro1 As Button
    Friend WithEvents BTrasPos As Button
    Friend WithEvents DTrasPos As DateTimePicker
    Friend WithEvents TTrasLote As TextBox
    Friend WithEvents TTrasProducto As TextBox
    Friend WithEvents TTrasCodigo As TextBox
    Friend WithEvents LTrasFecha As Label
    Friend WithEvents LTrasLote As Label
    Friend WithEvents LTrasProducto As Label
    Friend WithEvents LTrasCodigo As Label
    Friend WithEvents DGVTrasProd1 As DataGridView
    Friend WithEvents LTrasPro1 As Label
    Friend WithEvents DGVTrasProd2 As DataGridView
    Friend WithEvents LTrasPro2 As Label
    Friend WithEvents BTrasCancelar As Button
    Friend WithEvents BTrasGuardar As Button
    Friend WithEvents BTrasEnvioProd1 As Button
    Friend WithEvents BTrasEnvioProd2 As Button
End Class
