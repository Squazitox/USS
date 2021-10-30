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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PKArdexFiltro = New System.Windows.Forms.Panel()
        Me.CBProdKardex = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DPTKardexTo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DPTKardexFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PKArdexData = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PKArdexBotones = New System.Windows.Forms.Panel()
        Me.BKardexConsultar = New System.Windows.Forms.Button()
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PKArdexFiltro.SuspendLayout()
        Me.PKArdexData.SuspendLayout()
        Me.PKArdexBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReporteBindingSource
        '
        Me.ReporteBindingSource.DataSource = GetType(CapaNegocio.Reporte)
        '
        'PKArdexFiltro
        '
        Me.PKArdexFiltro.BackColor = System.Drawing.Color.ForestGreen
        Me.PKArdexFiltro.Controls.Add(Me.CBProdKardex)
        Me.PKArdexFiltro.Controls.Add(Me.Label1)
        Me.PKArdexFiltro.Controls.Add(Me.DPTKardexTo)
        Me.PKArdexFiltro.Controls.Add(Me.Label5)
        Me.PKArdexFiltro.Controls.Add(Me.DPTKardexFrom)
        Me.PKArdexFiltro.Controls.Add(Me.Label4)
        Me.PKArdexFiltro.Controls.Add(Me.Label2)
        Me.PKArdexFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PKArdexFiltro.Location = New System.Drawing.Point(0, 0)
        Me.PKArdexFiltro.Name = "PKArdexFiltro"
        Me.PKArdexFiltro.Size = New System.Drawing.Size(849, 46)
        Me.PKArdexFiltro.TabIndex = 0
        '
        'CBProdKardex
        '
        Me.CBProdKardex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBProdKardex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CBProdKardex.FormattingEnabled = True
        Me.CBProdKardex.Location = New System.Drawing.Point(98, 9)
        Me.CBProdKardex.Name = "CBProdKardex"
        Me.CBProdKardex.Size = New System.Drawing.Size(329, 21)
        Me.CBProdKardex.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(504, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Desde:"
        '
        'DPTKardexTo
        '
        Me.DPTKardexTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPTKardexTo.Location = New System.Drawing.Point(718, 13)
        Me.DPTKardexTo.Name = "DPTKardexTo"
        Me.DPTKardexTo.Size = New System.Drawing.Size(93, 20)
        Me.DPTKardexTo.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(663, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Hasta:"
        '
        'DPTKardexFrom
        '
        Me.DPTKardexFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPTKardexFrom.Location = New System.Drawing.Point(554, 12)
        Me.DPTKardexFrom.Name = "DPTKardexFrom"
        Me.DPTKardexFrom.Size = New System.Drawing.Size(93, 20)
        Me.DPTKardexFrom.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(446, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Producto:"
        '
        'PKArdexData
        '
        Me.PKArdexData.Controls.Add(Me.ReportViewer1)
        Me.PKArdexData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PKArdexData.Location = New System.Drawing.Point(0, 46)
        Me.PKArdexData.Name = "PKArdexData"
        Me.PKArdexData.Size = New System.Drawing.Size(849, 566)
        Me.PKArdexData.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "Kardex"
        ReportDataSource3.Value = Me.ReporteBindingSource
        ReportDataSource4.Name = "DataKardex"
        ReportDataSource4.Value = Me.ReporteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LaiveKardexApp.Ingresos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(849, 566)
        Me.ReportViewer1.TabIndex = 0
        '
        'PKArdexBotones
        '
        Me.PKArdexBotones.BackColor = System.Drawing.Color.ForestGreen
        Me.PKArdexBotones.Controls.Add(Me.BKardexConsultar)
        Me.PKArdexBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PKArdexBotones.Location = New System.Drawing.Point(0, 536)
        Me.PKArdexBotones.Name = "PKArdexBotones"
        Me.PKArdexBotones.Size = New System.Drawing.Size(849, 76)
        Me.PKArdexBotones.TabIndex = 2
        '
        'BKardexConsultar
        '
        Me.BKardexConsultar.BackColor = System.Drawing.Color.White
        Me.BKardexConsultar.Location = New System.Drawing.Point(747, 26)
        Me.BKardexConsultar.Name = "BKardexConsultar"
        Me.BKardexConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BKardexConsultar.TabIndex = 5
        Me.BKardexConsultar.Text = "Consultar"
        Me.BKardexConsultar.UseVisualStyleBackColor = False
        '
        'FormKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(849, 612)
        Me.Controls.Add(Me.PKArdexBotones)
        Me.Controls.Add(Me.PKArdexData)
        Me.Controls.Add(Me.PKArdexFiltro)
        Me.Name = "FormKardex"
        Me.Text = "FormKardex"
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PKArdexFiltro.ResumeLayout(False)
        Me.PKArdexFiltro.PerformLayout()
        Me.PKArdexData.ResumeLayout(False)
        Me.PKArdexBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PKArdexFiltro As Panel
    Friend WithEvents PKArdexData As Panel
    Friend WithEvents PKArdexBotones As Panel
    Friend WithEvents DPTKardexFrom As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BKardexConsultar As Button
    Friend WithEvents ReporteBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents DPTKardexTo As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CBProdKardex As ComboBox
End Class
