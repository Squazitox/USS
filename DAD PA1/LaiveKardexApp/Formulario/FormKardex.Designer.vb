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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PKArdexFiltro = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DPTKardexTo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DPTKardexFrom = New System.Windows.Forms.DateTimePicker()
        Me.TBKardexLote = New System.Windows.Forms.TextBox()
        Me.TBKardexProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PKArdexData = New System.Windows.Forms.Panel()
        Me.PKArdexBotones = New System.Windows.Forms.Panel()
        Me.BKardexCancelar = New System.Windows.Forms.Button()
        Me.BKardexConsultar = New System.Windows.Forms.Button()
        Me.BKardexExportar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PKArdexFiltro.SuspendLayout()
        Me.PKArdexData.SuspendLayout()
        Me.PKArdexBotones.SuspendLayout()
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PKArdexFiltro
        '
        Me.PKArdexFiltro.BackColor = System.Drawing.Color.ForestGreen
        Me.PKArdexFiltro.Controls.Add(Me.Label1)
        Me.PKArdexFiltro.Controls.Add(Me.DPTKardexTo)
        Me.PKArdexFiltro.Controls.Add(Me.Label5)
        Me.PKArdexFiltro.Controls.Add(Me.DPTKardexFrom)
        Me.PKArdexFiltro.Controls.Add(Me.TBKardexLote)
        Me.PKArdexFiltro.Controls.Add(Me.TBKardexProducto)
        Me.PKArdexFiltro.Controls.Add(Me.Label4)
        Me.PKArdexFiltro.Controls.Add(Me.Label3)
        Me.PKArdexFiltro.Controls.Add(Me.Label2)
        Me.PKArdexFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PKArdexFiltro.Location = New System.Drawing.Point(0, 0)
        Me.PKArdexFiltro.Name = "PKArdexFiltro"
        Me.PKArdexFiltro.Size = New System.Drawing.Size(800, 99)
        Me.PKArdexFiltro.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(571, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Desde:"
        '
        'DPTKardexTo
        '
        Me.DPTKardexTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPTKardexTo.Location = New System.Drawing.Point(645, 61)
        Me.DPTKardexTo.Name = "DPTKardexTo"
        Me.DPTKardexTo.Size = New System.Drawing.Size(93, 20)
        Me.DPTKardexTo.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(571, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Hasta:"
        '
        'DPTKardexFrom
        '
        Me.DPTKardexFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPTKardexFrom.Location = New System.Drawing.Point(645, 28)
        Me.DPTKardexFrom.Name = "DPTKardexFrom"
        Me.DPTKardexFrom.Size = New System.Drawing.Size(93, 20)
        Me.DPTKardexFrom.TabIndex = 21
        '
        'TBKardexLote
        '
        Me.TBKardexLote.Location = New System.Drawing.Point(98, 43)
        Me.TBKardexLote.Name = "TBKardexLote"
        Me.TBKardexLote.Size = New System.Drawing.Size(99, 20)
        Me.TBKardexLote.TabIndex = 20
        '
        'TBKardexProducto
        '
        Me.TBKardexProducto.Location = New System.Drawing.Point(98, 8)
        Me.TBKardexProducto.Name = "TBKardexProducto"
        Me.TBKardexProducto.Size = New System.Drawing.Size(378, 20)
        Me.TBKardexProducto.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(521, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 44)
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
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Producto:"
        '
        'PKArdexData
        '
        Me.PKArdexData.Controls.Add(Me.ReportViewer1)
        Me.PKArdexData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PKArdexData.Location = New System.Drawing.Point(0, 99)
        Me.PKArdexData.Name = "PKArdexData"
        Me.PKArdexData.Size = New System.Drawing.Size(800, 305)
        Me.PKArdexData.TabIndex = 1
        '
        'PKArdexBotones
        '
        Me.PKArdexBotones.BackColor = System.Drawing.Color.ForestGreen
        Me.PKArdexBotones.Controls.Add(Me.BKardexCancelar)
        Me.PKArdexBotones.Controls.Add(Me.BKardexConsultar)
        Me.PKArdexBotones.Controls.Add(Me.BKardexExportar)
        Me.PKArdexBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PKArdexBotones.Location = New System.Drawing.Point(0, 404)
        Me.PKArdexBotones.Name = "PKArdexBotones"
        Me.PKArdexBotones.Size = New System.Drawing.Size(800, 62)
        Me.PKArdexBotones.TabIndex = 2
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
        'BKardexConsultar
        '
        Me.BKardexConsultar.Location = New System.Drawing.Point(697, 26)
        Me.BKardexConsultar.Name = "BKardexConsultar"
        Me.BKardexConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BKardexConsultar.TabIndex = 5
        Me.BKardexConsultar.Text = "Consultar"
        Me.BKardexConsultar.UseVisualStyleBackColor = True
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Kardex"
        ReportDataSource1.Value = Me.ReporteBindingSource
        ReportDataSource2.Name = "DataKardex"
        ReportDataSource2.Value = Me.ReporteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LaiveKardexApp.Ingresos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 305)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReporteBindingSource
        '
        Me.ReporteBindingSource.DataSource = GetType(CapaNegocio.Reporte)
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
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PKArdexFiltro As Panel
    Friend WithEvents PKArdexData As Panel
    Friend WithEvents PKArdexBotones As Panel
    Friend WithEvents DPTKardexFrom As DateTimePicker
    Friend WithEvents TBKardexLote As TextBox
    Friend WithEvents TBKardexProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BKardexCancelar As Button
    Friend WithEvents BKardexConsultar As Button
    Friend WithEvents BKardexExportar As Button
    Friend WithEvents ReporteBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents DPTKardexTo As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
