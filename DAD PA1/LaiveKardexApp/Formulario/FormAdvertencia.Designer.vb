<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdvertencia
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
        Me.DGVVencimiento = New System.Windows.Forms.DataGridView()
        Me.DGVStock = New System.Windows.Forms.DataGridView()
        Me.LAdvVencer = New System.Windows.Forms.Label()
        Me.LAdvStock = New System.Windows.Forms.Label()
        Me.BAdvExportar = New System.Windows.Forms.Button()
        Me.BAdvOk = New System.Windows.Forms.Button()
        Me.PAdvVencimiento = New System.Windows.Forms.Panel()
        Me.PAdvStock = New System.Windows.Forms.Panel()
        Me.PAdvBotones = New System.Windows.Forms.Panel()
        CType(Me.DGVVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAdvVencimiento.SuspendLayout()
        Me.PAdvStock.SuspendLayout()
        Me.PAdvBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVVencimiento
        '
        Me.DGVVencimiento.AllowUserToAddRows = False
        Me.DGVVencimiento.AllowUserToDeleteRows = False
        Me.DGVVencimiento.AllowUserToOrderColumns = True
        Me.DGVVencimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVencimiento.Location = New System.Drawing.Point(12, 34)
        Me.DGVVencimiento.Name = "DGVVencimiento"
        Me.DGVVencimiento.ReadOnly = True
        Me.DGVVencimiento.Size = New System.Drawing.Size(759, 166)
        Me.DGVVencimiento.TabIndex = 0
        '
        'DGVStock
        '
        Me.DGVStock.AllowUserToAddRows = False
        Me.DGVStock.AllowUserToDeleteRows = False
        Me.DGVStock.AllowUserToOrderColumns = True
        Me.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStock.Location = New System.Drawing.Point(13, 52)
        Me.DGVStock.Name = "DGVStock"
        Me.DGVStock.ReadOnly = True
        Me.DGVStock.Size = New System.Drawing.Size(758, 187)
        Me.DGVStock.TabIndex = 1
        '
        'LAdvVencer
        '
        Me.LAdvVencer.AutoSize = True
        Me.LAdvVencer.Font = New System.Drawing.Font("Mont Demo Heavy", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAdvVencer.Location = New System.Drawing.Point(12, 10)
        Me.LAdvVencer.Name = "LAdvVencer"
        Me.LAdvVencer.Size = New System.Drawing.Size(241, 21)
        Me.LAdvVencer.TabIndex = 2
        Me.LAdvVencer.Text = "Productos proximos a vencer:"
        '
        'LAdvStock
        '
        Me.LAdvStock.AutoSize = True
        Me.LAdvStock.Font = New System.Drawing.Font("Mont Demo Heavy", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAdvStock.Location = New System.Drawing.Point(12, 28)
        Me.LAdvStock.Name = "LAdvStock"
        Me.LAdvStock.Size = New System.Drawing.Size(195, 21)
        Me.LAdvStock.TabIndex = 3
        Me.LAdvStock.Text = "Poructo con bajo stock:"
        '
        'BAdvExportar
        '
        Me.BAdvExportar.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAdvExportar.Location = New System.Drawing.Point(575, 21)
        Me.BAdvExportar.Name = "BAdvExportar"
        Me.BAdvExportar.Size = New System.Drawing.Size(89, 30)
        Me.BAdvExportar.TabIndex = 4
        Me.BAdvExportar.Text = "Exportar"
        Me.BAdvExportar.UseVisualStyleBackColor = True
        '
        'BAdvOk
        '
        Me.BAdvOk.BackColor = System.Drawing.Color.ForestGreen
        Me.BAdvOk.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAdvOk.ForeColor = System.Drawing.Color.White
        Me.BAdvOk.Location = New System.Drawing.Point(681, 21)
        Me.BAdvOk.Name = "BAdvOk"
        Me.BAdvOk.Size = New System.Drawing.Size(90, 30)
        Me.BAdvOk.TabIndex = 5
        Me.BAdvOk.Text = "Continuar"
        Me.BAdvOk.UseVisualStyleBackColor = False
        '
        'PAdvVencimiento
        '
        Me.PAdvVencimiento.Controls.Add(Me.DGVVencimiento)
        Me.PAdvVencimiento.Controls.Add(Me.LAdvVencer)
        Me.PAdvVencimiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAdvVencimiento.Location = New System.Drawing.Point(0, 0)
        Me.PAdvVencimiento.Name = "PAdvVencimiento"
        Me.PAdvVencimiento.Size = New System.Drawing.Size(800, 206)
        Me.PAdvVencimiento.TabIndex = 6
        '
        'PAdvStock
        '
        Me.PAdvStock.Controls.Add(Me.DGVStock)
        Me.PAdvStock.Controls.Add(Me.LAdvStock)
        Me.PAdvStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAdvStock.Location = New System.Drawing.Point(0, 206)
        Me.PAdvStock.Name = "PAdvStock"
        Me.PAdvStock.Size = New System.Drawing.Size(800, 245)
        Me.PAdvStock.TabIndex = 7
        '
        'PAdvBotones
        '
        Me.PAdvBotones.Controls.Add(Me.BAdvExportar)
        Me.PAdvBotones.Controls.Add(Me.BAdvOk)
        Me.PAdvBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAdvBotones.Location = New System.Drawing.Point(0, 451)
        Me.PAdvBotones.Name = "PAdvBotones"
        Me.PAdvBotones.Size = New System.Drawing.Size(800, 69)
        Me.PAdvBotones.TabIndex = 8
        '
        'FormAdvertencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 520)
        Me.Controls.Add(Me.PAdvBotones)
        Me.Controls.Add(Me.PAdvStock)
        Me.Controls.Add(Me.PAdvVencimiento)
        Me.Name = "FormAdvertencia"
        Me.Text = "FormAdvertencia"
        CType(Me.DGVVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAdvVencimiento.ResumeLayout(False)
        Me.PAdvVencimiento.PerformLayout()
        Me.PAdvStock.ResumeLayout(False)
        Me.PAdvStock.PerformLayout()
        Me.PAdvBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVVencimiento As DataGridView
    Friend WithEvents DGVStock As DataGridView
    Friend WithEvents LAdvVencer As Label
    Friend WithEvents LAdvStock As Label
    Friend WithEvents BAdvExportar As Button
    Friend WithEvents BAdvOk As Button
    Friend WithEvents PAdvVencimiento As Panel
    Friend WithEvents PAdvStock As Panel
    Friend WithEvents PAdvBotones As Panel
End Class
