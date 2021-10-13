<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResumen
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
        Me.PData = New System.Windows.Forms.Panel()
        Me.PResumenIngreso = New System.Windows.Forms.Panel()
        Me.PSalidaResumen = New System.Windows.Forms.Panel()
        Me.PSalidaAjuste = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PData.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PData
        '
        Me.PData.Controls.Add(Me.DataGridView1)
        Me.PData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PData.Location = New System.Drawing.Point(0, 131)
        Me.PData.Name = "PData"
        Me.PData.Size = New System.Drawing.Size(887, 319)
        Me.PData.TabIndex = 0
        '
        'PResumenIngreso
        '
        Me.PResumenIngreso.BackColor = System.Drawing.Color.PowderBlue
        Me.PResumenIngreso.Dock = System.Windows.Forms.DockStyle.Left
        Me.PResumenIngreso.Location = New System.Drawing.Point(0, 0)
        Me.PResumenIngreso.Name = "PResumenIngreso"
        Me.PResumenIngreso.Size = New System.Drawing.Size(300, 131)
        Me.PResumenIngreso.TabIndex = 1
        '
        'PSalidaResumen
        '
        Me.PSalidaResumen.BackColor = System.Drawing.Color.LightGreen
        Me.PSalidaResumen.Dock = System.Windows.Forms.DockStyle.Left
        Me.PSalidaResumen.Location = New System.Drawing.Point(300, 0)
        Me.PSalidaResumen.Name = "PSalidaResumen"
        Me.PSalidaResumen.Size = New System.Drawing.Size(299, 131)
        Me.PSalidaResumen.TabIndex = 2
        '
        'PSalidaAjuste
        '
        Me.PSalidaAjuste.BackColor = System.Drawing.Color.PapayaWhip
        Me.PSalidaAjuste.Dock = System.Windows.Forms.DockStyle.Left
        Me.PSalidaAjuste.Location = New System.Drawing.Point(599, 0)
        Me.PSalidaAjuste.Name = "PSalidaAjuste"
        Me.PSalidaAjuste.Size = New System.Drawing.Size(288, 131)
        Me.PSalidaAjuste.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(887, 319)
        Me.DataGridView1.TabIndex = 0
        '
        'FormResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 450)
        Me.Controls.Add(Me.PSalidaAjuste)
        Me.Controls.Add(Me.PSalidaResumen)
        Me.Controls.Add(Me.PResumenIngreso)
        Me.Controls.Add(Me.PData)
        Me.Name = "FormResumen"
        Me.Text = "FormResumen"
        Me.PData.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PData As Panel
    Friend WithEvents PResumenIngreso As Panel
    Friend WithEvents PSalidaResumen As Panel
    Friend WithEvents PSalidaAjuste As Panel
    Friend WithEvents DataGridView1 As DataGridView
End Class
