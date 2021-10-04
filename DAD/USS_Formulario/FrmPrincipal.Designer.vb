<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.PnIzquierda = New System.Windows.Forms.Panel()
        Me.BtnTransparencia = New FontAwesome.Sharp.IconButton()
        Me.BtnBiblioteca = New FontAwesome.Sharp.IconButton()
        Me.BtnEscuela = New FontAwesome.Sharp.IconButton()
        Me.BtnAdmision = New FontAwesome.Sharp.IconButton()
        Me.BtnInicio = New FontAwesome.Sharp.IconButton()
        Me.PnLogo = New System.Windows.Forms.Panel()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.PnSuperior = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPrincipal = New FontAwesome.Sharp.IconPictureBox()
        Me.PnPrincipal = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnIzquierda.SuspendLayout()
        Me.PnLogo.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnSuperior.SuspendLayout()
        CType(Me.IconPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnIzquierda
        '
        Me.PnIzquierda.BackColor = System.Drawing.Color.DarkGreen
        Me.PnIzquierda.Controls.Add(Me.BtnTransparencia)
        Me.PnIzquierda.Controls.Add(Me.BtnBiblioteca)
        Me.PnIzquierda.Controls.Add(Me.BtnEscuela)
        Me.PnIzquierda.Controls.Add(Me.BtnAdmision)
        Me.PnIzquierda.Controls.Add(Me.BtnInicio)
        Me.PnIzquierda.Controls.Add(Me.PnLogo)
        Me.PnIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.PnIzquierda.Name = "PnIzquierda"
        Me.PnIzquierda.Size = New System.Drawing.Size(200, 640)
        Me.PnIzquierda.TabIndex = 0
        '
        'BtnTransparencia
        '
        Me.BtnTransparencia.BackColor = System.Drawing.Color.Teal
        Me.BtnTransparencia.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTransparencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransparencia.ForeColor = System.Drawing.Color.White
        Me.BtnTransparencia.IconChar = FontAwesome.Sharp.IconChar.SearchPlus
        Me.BtnTransparencia.IconColor = System.Drawing.Color.White
        Me.BtnTransparencia.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTransparencia.Location = New System.Drawing.Point(0, 380)
        Me.BtnTransparencia.Name = "BtnTransparencia"
        Me.BtnTransparencia.Size = New System.Drawing.Size(200, 70)
        Me.BtnTransparencia.TabIndex = 5
        Me.BtnTransparencia.Text = "TRANSPARENCIA"
        Me.BtnTransparencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTransparencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTransparencia.UseVisualStyleBackColor = False
        '
        'BtnBiblioteca
        '
        Me.BtnBiblioteca.BackColor = System.Drawing.Color.Teal
        Me.BtnBiblioteca.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBiblioteca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBiblioteca.ForeColor = System.Drawing.Color.White
        Me.BtnBiblioteca.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        Me.BtnBiblioteca.IconColor = System.Drawing.Color.White
        Me.BtnBiblioteca.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnBiblioteca.Location = New System.Drawing.Point(0, 310)
        Me.BtnBiblioteca.Name = "BtnBiblioteca"
        Me.BtnBiblioteca.Size = New System.Drawing.Size(200, 70)
        Me.BtnBiblioteca.TabIndex = 4
        Me.BtnBiblioteca.Text = "BIBLIOTECA"
        Me.BtnBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBiblioteca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBiblioteca.UseVisualStyleBackColor = False
        '
        'BtnEscuela
        '
        Me.BtnEscuela.BackColor = System.Drawing.Color.Teal
        Me.BtnEscuela.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEscuela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEscuela.ForeColor = System.Drawing.Color.White
        Me.BtnEscuela.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.BtnEscuela.IconColor = System.Drawing.Color.White
        Me.BtnEscuela.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEscuela.Location = New System.Drawing.Point(0, 240)
        Me.BtnEscuela.Name = "BtnEscuela"
        Me.BtnEscuela.Size = New System.Drawing.Size(200, 70)
        Me.BtnEscuela.TabIndex = 3
        Me.BtnEscuela.Text = "ESCUELA"
        Me.BtnEscuela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEscuela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEscuela.UseVisualStyleBackColor = False
        '
        'BtnAdmision
        '
        Me.BtnAdmision.BackColor = System.Drawing.Color.Teal
        Me.BtnAdmision.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAdmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmision.ForeColor = System.Drawing.Color.White
        Me.BtnAdmision.IconChar = FontAwesome.Sharp.IconChar.UserTie
        Me.BtnAdmision.IconColor = System.Drawing.Color.White
        Me.BtnAdmision.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnAdmision.Location = New System.Drawing.Point(0, 170)
        Me.BtnAdmision.Name = "BtnAdmision"
        Me.BtnAdmision.Size = New System.Drawing.Size(200, 70)
        Me.BtnAdmision.TabIndex = 2
        Me.BtnAdmision.Text = "ADMISION"
        Me.BtnAdmision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdmision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdmision.UseVisualStyleBackColor = False
        '
        'BtnInicio
        '
        Me.BtnInicio.BackColor = System.Drawing.Color.Teal
        Me.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.ForeColor = System.Drawing.Color.White
        Me.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.BtnInicio.IconColor = System.Drawing.Color.White
        Me.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnInicio.Location = New System.Drawing.Point(0, 100)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(200, 70)
        Me.BtnInicio.TabIndex = 1
        Me.BtnInicio.Text = "INICIO"
        Me.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInicio.UseVisualStyleBackColor = False
        '
        'PnLogo
        '
        Me.PnLogo.Controls.Add(Me.PicLogo)
        Me.PnLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnLogo.Location = New System.Drawing.Point(0, 0)
        Me.PnLogo.Name = "PnLogo"
        Me.PnLogo.Size = New System.Drawing.Size(200, 100)
        Me.PnLogo.TabIndex = 0
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(27, 8)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(143, 85)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 0
        Me.PicLogo.TabStop = False
        '
        'PnSuperior
        '
        Me.PnSuperior.BackColor = System.Drawing.Color.Teal
        Me.PnSuperior.Controls.Add(Me.Label1)
        Me.PnSuperior.Controls.Add(Me.IconPrincipal)
        Me.PnSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnSuperior.Location = New System.Drawing.Point(200, 0)
        Me.PnSuperior.Name = "PnSuperior"
        Me.PnSuperior.Size = New System.Drawing.Size(816, 100)
        Me.PnSuperior.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 1
        '
        'IconPrincipal
        '
        Me.IconPrincipal.BackColor = System.Drawing.Color.Teal
        Me.IconPrincipal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPrincipal.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPrincipal.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPrincipal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPrincipal.IconSize = 57
        Me.IconPrincipal.Location = New System.Drawing.Point(19, 29)
        Me.IconPrincipal.Name = "IconPrincipal"
        Me.IconPrincipal.Size = New System.Drawing.Size(57, 62)
        Me.IconPrincipal.TabIndex = 0
        Me.IconPrincipal.TabStop = False
        '
        'PnPrincipal
        '
        Me.PnPrincipal.Controls.Add(Me.PictureBox1)
        Me.PnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnPrincipal.Location = New System.Drawing.Point(200, 100)
        Me.PnPrincipal.Name = "PnPrincipal"
        Me.PnPrincipal.Size = New System.Drawing.Size(816, 540)
        Me.PnPrincipal.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(816, 540)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 640)
        Me.Controls.Add(Me.PnPrincipal)
        Me.Controls.Add(Me.PnSuperior)
        Me.Controls.Add(Me.PnIzquierda)
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.PnIzquierda.ResumeLayout(False)
        Me.PnLogo.ResumeLayout(False)
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnSuperior.ResumeLayout(False)
        Me.PnSuperior.PerformLayout()
        CType(Me.IconPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnPrincipal.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnIzquierda As Panel
    Friend WithEvents BtnTransparencia As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnBiblioteca As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnEscuela As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnAdmision As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents PnLogo As Panel
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents PnSuperior As Panel
    Friend WithEvents IconPrincipal As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PnPrincipal As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
