<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProVencimiento
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReporVencimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosVencimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.ReporVencimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosVencimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReporVencimientoBindingSource
        '
        Me.ReporVencimientoBindingSource.DataSource = GetType(CapaNegocio.ReporVencimiento)
        '
        'ProductosVencimientoBindingSource
        '
        Me.ProductosVencimientoBindingSource.DataSource = GetType(CapaNegocio.ProductosVencimiento)
        '
        'ReportViewer1
        '
        ReportDataSource11.Name = "ProductosVencimiento01"
        ReportDataSource11.Value = Me.ReporVencimientoBindingSource
        ReportDataSource12.Name = "ProductosVencimiento2"
        ReportDataSource12.Value = Me.ProductosVencimientoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource12)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LaiveKardexApp.VencimientoProductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 92)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(815, 573)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 63)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lista de Productos Proximos a Vencer"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(650, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "El Presente Mes"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(383, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "El dia de Hoy"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(522, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = " En 2 Dias"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FormProVencimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 677)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormProVencimiento"
        Me.Text = "Form1"
        CType(Me.ReporVencimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosVencimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporVencimientoBindingSource As BindingSource
    Friend WithEvents ProductosVencimientoBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
