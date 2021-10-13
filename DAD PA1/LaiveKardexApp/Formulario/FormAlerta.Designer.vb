<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlerta
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
        Me.LAlert = New System.Windows.Forms.Label()
        Me.LTextAlert = New System.Windows.Forms.Label()
        Me.BAlertaSi = New System.Windows.Forms.Button()
        Me.BAlertaOmitir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LAlert
        '
        Me.LAlert.AutoSize = True
        Me.LAlert.Font = New System.Drawing.Font("Mont Demo Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAlert.ForeColor = System.Drawing.Color.Black
        Me.LAlert.Location = New System.Drawing.Point(83, 9)
        Me.LAlert.Name = "LAlert"
        Me.LAlert.Size = New System.Drawing.Size(67, 22)
        Me.LAlert.TabIndex = 0
        Me.LAlert.Text = "Alerta!"
        '
        'LTextAlert
        '
        Me.LTextAlert.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTextAlert.ForeColor = System.Drawing.Color.Black
        Me.LTextAlert.Location = New System.Drawing.Point(12, 31)
        Me.LTextAlert.Name = "LTextAlert"
        Me.LTextAlert.Size = New System.Drawing.Size(210, 91)
        Me.LTextAlert.TabIndex = 1
        Me.LTextAlert.Text = "Existen productos con observaciones, Desea visualizarlos?"
        Me.LTextAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BAlertaSi
        '
        Me.BAlertaSi.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAlertaSi.Location = New System.Drawing.Point(147, 120)
        Me.BAlertaSi.Name = "BAlertaSi"
        Me.BAlertaSi.Size = New System.Drawing.Size(75, 23)
        Me.BAlertaSi.TabIndex = 2
        Me.BAlertaSi.Text = "SI"
        Me.BAlertaSi.UseVisualStyleBackColor = True
        '
        'BAlertaOmitir
        '
        Me.BAlertaOmitir.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAlertaOmitir.Location = New System.Drawing.Point(12, 120)
        Me.BAlertaOmitir.Name = "BAlertaOmitir"
        Me.BAlertaOmitir.Size = New System.Drawing.Size(75, 23)
        Me.BAlertaOmitir.TabIndex = 3
        Me.BAlertaOmitir.Text = "Omitir"
        Me.BAlertaOmitir.UseVisualStyleBackColor = True
        '
        'FormAlerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(236, 155)
        Me.Controls.Add(Me.BAlertaOmitir)
        Me.Controls.Add(Me.BAlertaSi)
        Me.Controls.Add(Me.LTextAlert)
        Me.Controls.Add(Me.LAlert)
        Me.Name = "FormAlerta"
        Me.Text = "FormAlerta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LAlert As Label
    Friend WithEvents LTextAlert As Label
    Friend WithEvents BAlertaSi As Button
    Friend WithEvents BAlertaOmitir As Button
End Class
