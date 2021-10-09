<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregar
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
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBDNI = New System.Windows.Forms.TextBox()
        Me.TBFechadeNacimiento = New System.Windows.Forms.TextBox()
        Me.TBRUC = New System.Windows.Forms.TextBox()
        Me.CBGenero = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTAceptar = New System.Windows.Forms.Button()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(39, 40)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombres"
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(39, 86)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(100, 20)
        Me.TBApellido.TabIndex = 0
        '
        'TBDNI
        '
        Me.TBDNI.Location = New System.Drawing.Point(39, 133)
        Me.TBDNI.Name = "TBDNI"
        Me.TBDNI.Size = New System.Drawing.Size(100, 20)
        Me.TBDNI.TabIndex = 0
        '
        'TBFechadeNacimiento
        '
        Me.TBFechadeNacimiento.Location = New System.Drawing.Point(39, 180)
        Me.TBFechadeNacimiento.Name = "TBFechadeNacimiento"
        Me.TBFechadeNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.TBFechadeNacimiento.TabIndex = 0
        '
        'TBRUC
        '
        Me.TBRUC.Location = New System.Drawing.Point(39, 264)
        Me.TBRUC.Name = "TBRUC"
        Me.TBRUC.Size = New System.Drawing.Size(100, 20)
        Me.TBRUC.TabIndex = 0
        '
        'CBGenero
        '
        Me.CBGenero.FormattingEnabled = True
        Me.CBGenero.Items.AddRange(New Object() {"M", "F"})
        Me.CBGenero.Location = New System.Drawing.Point(91, 217)
        Me.CBGenero.Name = "CBGenero"
        Me.CBGenero.Size = New System.Drawing.Size(48, 21)
        Me.CBGenero.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Genero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "RUC"
        '
        'BTAceptar
        '
        Me.BTAceptar.Location = New System.Drawing.Point(10, 312)
        Me.BTAceptar.Name = "BTAceptar"
        Me.BTAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BTAceptar.TabIndex = 3
        Me.BTAceptar.Text = "Aceptar"
        Me.BTAceptar.UseVisualStyleBackColor = True
        '
        'BTCancelar
        '
        Me.BTCancelar.Location = New System.Drawing.Point(107, 312)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTCancelar.TabIndex = 4
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = True
        '
        'FormAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 354)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTAceptar)
        Me.Controls.Add(Me.CBGenero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBRUC)
        Me.Controls.Add(Me.TBFechadeNacimiento)
        Me.Controls.Add(Me.TBDNI)
        Me.Controls.Add(Me.TBApellido)
        Me.Controls.Add(Me.TBNombre)
        Me.Name = "FormAgregar"
        Me.Text = "FormAgregar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents TBFechadeNacimiento As TextBox
    Friend WithEvents TBRUC As TextBox
    Friend WithEvents CBGenero As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTAceptar As Button
    Friend WithEvents BTCancelar As Button
End Class
