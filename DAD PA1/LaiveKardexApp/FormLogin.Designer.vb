<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.LLogin = New System.Windows.Forms.Label()
        Me.PBLogin = New System.Windows.Forms.PictureBox()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.TBUser = New System.Windows.Forms.TextBox()
        Me.LPassword = New System.Windows.Forms.Label()
        Me.LUser = New System.Windows.Forms.Label()
        Me.LLostPassword = New System.Windows.Forms.LinkLabel()
        Me.BLoginCancelar = New System.Windows.Forms.Button()
        CType(Me.PBLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LLogin
        '
        Me.LLogin.AutoSize = True
        Me.LLogin.Font = New System.Drawing.Font("Mont Demo Heavy", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLogin.ForeColor = System.Drawing.Color.White
        Me.LLogin.Location = New System.Drawing.Point(12, 9)
        Me.LLogin.Name = "LLogin"
        Me.LLogin.Size = New System.Drawing.Size(128, 28)
        Me.LLogin.TabIndex = 1
        Me.LLogin.Text = "Bienvenido"
        '
        'PBLogin
        '
        Me.PBLogin.Image = CType(resources.GetObject("PBLogin.Image"), System.Drawing.Image)
        Me.PBLogin.Location = New System.Drawing.Point(17, 40)
        Me.PBLogin.Name = "PBLogin"
        Me.PBLogin.Size = New System.Drawing.Size(109, 83)
        Me.PBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBLogin.TabIndex = 7
        Me.PBLogin.TabStop = False
        '
        'BLogin
        '
        Me.BLogin.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogin.Location = New System.Drawing.Point(339, 130)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(91, 23)
        Me.BLogin.TabIndex = 12
        Me.BLogin.Text = "iniciar Sesión"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(254, 59)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(159, 20)
        Me.TBPassword.TabIndex = 11
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(254, 26)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(159, 20)
        Me.TBUser.TabIndex = 10
        '
        'LPassword
        '
        Me.LPassword.AutoSize = True
        Me.LPassword.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPassword.ForeColor = System.Drawing.Color.White
        Me.LPassword.Location = New System.Drawing.Point(153, 59)
        Me.LPassword.Name = "LPassword"
        Me.LPassword.Size = New System.Drawing.Size(99, 19)
        Me.LPassword.TabIndex = 9
        Me.LPassword.Text = "Contraseña:"
        '
        'LUser
        '
        Me.LUser.AutoSize = True
        Me.LUser.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUser.ForeColor = System.Drawing.Color.White
        Me.LUser.Location = New System.Drawing.Point(153, 26)
        Me.LUser.Name = "LUser"
        Me.LUser.Size = New System.Drawing.Size(68, 19)
        Me.LUser.TabIndex = 8
        Me.LUser.Text = "Usuario:"
        '
        'LLostPassword
        '
        Me.LLostPassword.AutoSize = True
        Me.LLostPassword.Location = New System.Drawing.Point(283, 91)
        Me.LLostPassword.Name = "LLostPassword"
        Me.LLostPassword.Size = New System.Drawing.Size(130, 13)
        Me.LLostPassword.TabIndex = 13
        Me.LLostPassword.TabStop = True
        Me.LLostPassword.Text = "¿Olvidaste la contraseña?"
        '
        'BLoginCancelar
        '
        Me.BLoginCancelar.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLoginCancelar.Location = New System.Drawing.Point(203, 130)
        Me.BLoginCancelar.Name = "BLoginCancelar"
        Me.BLoginCancelar.Size = New System.Drawing.Size(91, 23)
        Me.BLoginCancelar.TabIndex = 14
        Me.BLoginCancelar.Text = "Cerrar"
        Me.BLoginCancelar.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(459, 165)
        Me.Controls.Add(Me.BLoginCancelar)
        Me.Controls.Add(Me.LLostPassword)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.TBUser)
        Me.Controls.Add(Me.LPassword)
        Me.Controls.Add(Me.LUser)
        Me.Controls.Add(Me.PBLogin)
        Me.Controls.Add(Me.LLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PBLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LLogin As Label
    Friend WithEvents PBLogin As PictureBox
    Friend WithEvents BLogin As Button
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents TBUser As TextBox
    Friend WithEvents LPassword As Label
    Friend WithEvents LUser As Label
    Friend WithEvents LLostPassword As LinkLabel
    Friend WithEvents BLoginCancelar As Button
End Class
