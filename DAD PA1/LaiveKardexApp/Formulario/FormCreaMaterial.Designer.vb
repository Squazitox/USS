<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreaMaterial
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
        Me.TBMaterialDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBMaterialTProducto = New System.Windows.Forms.ComboBox()
        Me.CBMaterialUMedida = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBMaterialDescripcion
        '
        Me.TBMaterialDescripcion.Location = New System.Drawing.Point(12, 168)
        Me.TBMaterialDescripcion.Name = "TBMaterialDescripcion"
        Me.TBMaterialDescripcion.Size = New System.Drawing.Size(121, 20)
        Me.TBMaterialDescripcion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de Producto"
        '
        'CBMaterialTProducto
        '
        Me.CBMaterialTProducto.FormattingEnabled = True
        Me.CBMaterialTProducto.Location = New System.Drawing.Point(12, 25)
        Me.CBMaterialTProducto.Name = "CBMaterialTProducto"
        Me.CBMaterialTProducto.Size = New System.Drawing.Size(121, 21)
        Me.CBMaterialTProducto.TabIndex = 2
        '
        'CBMaterialUMedida
        '
        Me.CBMaterialUMedida.FormattingEnabled = True
        Me.CBMaterialUMedida.Location = New System.Drawing.Point(12, 92)
        Me.CBMaterialUMedida.Name = "CBMaterialUMedida"
        Me.CBMaterialUMedida.Size = New System.Drawing.Size(121, 21)
        Me.CBMaterialUMedida.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Unidad de Medida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción"
        '
        'FormCreaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(175, 225)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBMaterialUMedida)
        Me.Controls.Add(Me.CBMaterialTProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBMaterialDescripcion)
        Me.Name = "FormCreaMaterial"
        Me.Text = "FormCreaMaterial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBMaterialDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBMaterialTProducto As ComboBox
    Friend WithEvents CBMaterialUMedida As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
