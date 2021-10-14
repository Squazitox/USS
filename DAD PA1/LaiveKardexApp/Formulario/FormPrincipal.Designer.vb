<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.PNBorde = New System.Windows.Forms.Panel()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.PnIzquierdo = New System.Windows.Forms.Panel()
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.PSubMenuReportes = New System.Windows.Forms.Panel()
        Me.IBResumen = New FontAwesome.Sharp.IconButton()
        Me.IBKardex = New FontAwesome.Sharp.IconButton()
        Me.IBReportes = New FontAwesome.Sharp.IconButton()
        Me.PSubMenuInventario = New System.Windows.Forms.Panel()
        Me.IBSalida = New FontAwesome.Sharp.IconButton()
        Me.IBIngreso = New FontAwesome.Sharp.IconButton()
        Me.IBInventario = New FontAwesome.Sharp.IconButton()
        Me.PSubMenuAdmin = New System.Windows.Forms.Panel()
        Me.IBTraspaso = New FontAwesome.Sharp.IconButton()
        Me.IBAjusteNeg = New FontAwesome.Sharp.IconButton()
        Me.IBAjustePos = New FontAwesome.Sharp.IconButton()
        Me.IBAdmin = New FontAwesome.Sharp.IconButton()
        Me.PLogo = New System.Windows.Forms.Panel()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.PTitulo = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.IPTitulo = New FontAwesome.Sharp.IconPictureBox()
        Me.PNBase = New System.Windows.Forms.Panel()
        Me.PBCentral = New System.Windows.Forms.PictureBox()
        Me.PNBorde.SuspendLayout()
        Me.PnIzquierdo.SuspendLayout()
        Me.PMenu.SuspendLayout()
        Me.PSubMenuReportes.SuspendLayout()
        Me.PSubMenuInventario.SuspendLayout()
        Me.PSubMenuAdmin.SuspendLayout()
        Me.PLogo.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PTitulo.SuspendLayout()
        CType(Me.IPTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNBase.SuspendLayout()
        CType(Me.PBCentral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNBorde
        '
        Me.PNBorde.Controls.Add(Me.LUsuario)
        Me.PNBorde.Controls.Add(Me.BSalir)
        Me.PNBorde.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNBorde.Location = New System.Drawing.Point(0, 530)
        Me.PNBorde.Name = "PNBorde"
        Me.PNBorde.Size = New System.Drawing.Size(874, 28)
        Me.PNBorde.TabIndex = 1
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.Location = New System.Drawing.Point(13, 7)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(0, 15)
        Me.LUsuario.TabIndex = 1
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(787, 3)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 0
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'PnIzquierdo
        '
        Me.PnIzquierdo.Controls.Add(Me.PMenu)
        Me.PnIzquierdo.Controls.Add(Me.PLogo)
        Me.PnIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnIzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.PnIzquierdo.Name = "PnIzquierdo"
        Me.PnIzquierdo.Size = New System.Drawing.Size(263, 530)
        Me.PnIzquierdo.TabIndex = 2
        '
        'PMenu
        '
        Me.PMenu.AutoScroll = True
        Me.PMenu.Controls.Add(Me.PSubMenuReportes)
        Me.PMenu.Controls.Add(Me.IBReportes)
        Me.PMenu.Controls.Add(Me.PSubMenuInventario)
        Me.PMenu.Controls.Add(Me.IBInventario)
        Me.PMenu.Controls.Add(Me.PSubMenuAdmin)
        Me.PMenu.Controls.Add(Me.IBAdmin)
        Me.PMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PMenu.Location = New System.Drawing.Point(0, 60)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(260, 470)
        Me.PMenu.TabIndex = 2
        '
        'PSubMenuReportes
        '
        Me.PSubMenuReportes.Controls.Add(Me.IBResumen)
        Me.PSubMenuReportes.Controls.Add(Me.IBKardex)
        Me.PSubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSubMenuReportes.Location = New System.Drawing.Point(0, 336)
        Me.PSubMenuReportes.Name = "PSubMenuReportes"
        Me.PSubMenuReportes.Size = New System.Drawing.Size(260, 84)
        Me.PSubMenuReportes.TabIndex = 5
        '
        'IBResumen
        '
        Me.IBResumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBResumen.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBResumen.IconChar = FontAwesome.Sharp.IconChar.FileSignature
        Me.IBResumen.IconColor = System.Drawing.Color.Black
        Me.IBResumen.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBResumen.Location = New System.Drawing.Point(0, 42)
        Me.IBResumen.Name = "IBResumen"
        Me.IBResumen.Size = New System.Drawing.Size(260, 42)
        Me.IBResumen.TabIndex = 1
        Me.IBResumen.Text = "Resumen"
        Me.IBResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBResumen.UseVisualStyleBackColor = True
        '
        'IBKardex
        '
        Me.IBKardex.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBKardex.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBKardex.IconChar = FontAwesome.Sharp.IconChar.FileSignature
        Me.IBKardex.IconColor = System.Drawing.Color.Black
        Me.IBKardex.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBKardex.Location = New System.Drawing.Point(0, 0)
        Me.IBKardex.Name = "IBKardex"
        Me.IBKardex.Size = New System.Drawing.Size(260, 42)
        Me.IBKardex.TabIndex = 0
        Me.IBKardex.Text = "Kardex"
        Me.IBKardex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBKardex.UseVisualStyleBackColor = True
        '
        'IBReportes
        '
        Me.IBReportes.BackColor = System.Drawing.Color.ForestGreen
        Me.IBReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBReportes.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBReportes.ForeColor = System.Drawing.Color.White
        Me.IBReportes.IconChar = FontAwesome.Sharp.IconChar.FolderPlus
        Me.IBReportes.IconColor = System.Drawing.Color.Black
        Me.IBReportes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IBReportes.Location = New System.Drawing.Point(0, 294)
        Me.IBReportes.Name = "IBReportes"
        Me.IBReportes.Size = New System.Drawing.Size(260, 42)
        Me.IBReportes.TabIndex = 4
        Me.IBReportes.Text = "Reportes"
        Me.IBReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBReportes.UseVisualStyleBackColor = False
        '
        'PSubMenuInventario
        '
        Me.PSubMenuInventario.Controls.Add(Me.IBSalida)
        Me.PSubMenuInventario.Controls.Add(Me.IBIngreso)
        Me.PSubMenuInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSubMenuInventario.Location = New System.Drawing.Point(0, 210)
        Me.PSubMenuInventario.Name = "PSubMenuInventario"
        Me.PSubMenuInventario.Size = New System.Drawing.Size(260, 84)
        Me.PSubMenuInventario.TabIndex = 3
        '
        'IBSalida
        '
        Me.IBSalida.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBSalida.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.IBSalida.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBSalida.IconChar = FontAwesome.Sharp.IconChar.Dolly
        Me.IBSalida.IconColor = System.Drawing.Color.Black
        Me.IBSalida.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBSalida.IconSize = 40
        Me.IBSalida.Location = New System.Drawing.Point(0, 42)
        Me.IBSalida.Name = "IBSalida"
        Me.IBSalida.Size = New System.Drawing.Size(260, 42)
        Me.IBSalida.TabIndex = 1
        Me.IBSalida.Text = "Salida"
        Me.IBSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBSalida.UseVisualStyleBackColor = True
        '
        'IBIngreso
        '
        Me.IBIngreso.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBIngreso.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBIngreso.IconChar = FontAwesome.Sharp.IconChar.Dolly
        Me.IBIngreso.IconColor = System.Drawing.Color.Black
        Me.IBIngreso.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBIngreso.IconSize = 40
        Me.IBIngreso.Location = New System.Drawing.Point(0, 0)
        Me.IBIngreso.Name = "IBIngreso"
        Me.IBIngreso.Size = New System.Drawing.Size(260, 42)
        Me.IBIngreso.TabIndex = 0
        Me.IBIngreso.Text = "Ingreso"
        Me.IBIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBIngreso.UseVisualStyleBackColor = True
        '
        'IBInventario
        '
        Me.IBInventario.BackColor = System.Drawing.Color.ForestGreen
        Me.IBInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBInventario.ForeColor = System.Drawing.Color.White
        Me.IBInventario.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed
        Me.IBInventario.IconColor = System.Drawing.Color.Black
        Me.IBInventario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IBInventario.Location = New System.Drawing.Point(0, 168)
        Me.IBInventario.Name = "IBInventario"
        Me.IBInventario.Size = New System.Drawing.Size(260, 42)
        Me.IBInventario.TabIndex = 2
        Me.IBInventario.Text = "Inventario"
        Me.IBInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBInventario.UseVisualStyleBackColor = False
        '
        'PSubMenuAdmin
        '
        Me.PSubMenuAdmin.Controls.Add(Me.IBTraspaso)
        Me.PSubMenuAdmin.Controls.Add(Me.IBAjusteNeg)
        Me.PSubMenuAdmin.Controls.Add(Me.IBAjustePos)
        Me.PSubMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSubMenuAdmin.Location = New System.Drawing.Point(0, 42)
        Me.PSubMenuAdmin.Name = "PSubMenuAdmin"
        Me.PSubMenuAdmin.Size = New System.Drawing.Size(260, 126)
        Me.PSubMenuAdmin.TabIndex = 1
        '
        'IBTraspaso
        '
        Me.IBTraspaso.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBTraspaso.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBTraspaso.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.IBTraspaso.IconColor = System.Drawing.Color.Black
        Me.IBTraspaso.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBTraspaso.IconSize = 40
        Me.IBTraspaso.Location = New System.Drawing.Point(0, 84)
        Me.IBTraspaso.Name = "IBTraspaso"
        Me.IBTraspaso.Size = New System.Drawing.Size(260, 42)
        Me.IBTraspaso.TabIndex = 2
        Me.IBTraspaso.Text = "Traspaso"
        Me.IBTraspaso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBTraspaso.UseVisualStyleBackColor = True
        '
        'IBAjusteNeg
        '
        Me.IBAjusteNeg.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBAjusteNeg.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBAjusteNeg.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.IBAjusteNeg.IconColor = System.Drawing.Color.Black
        Me.IBAjusteNeg.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBAjusteNeg.IconSize = 40
        Me.IBAjusteNeg.Location = New System.Drawing.Point(0, 42)
        Me.IBAjusteNeg.Name = "IBAjusteNeg"
        Me.IBAjusteNeg.Size = New System.Drawing.Size(260, 42)
        Me.IBAjusteNeg.TabIndex = 1
        Me.IBAjusteNeg.Text = "Ajuste de Salida"
        Me.IBAjusteNeg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBAjusteNeg.UseVisualStyleBackColor = True
        '
        'IBAjustePos
        '
        Me.IBAjustePos.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBAjustePos.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBAjustePos.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.IBAjustePos.IconColor = System.Drawing.Color.Black
        Me.IBAjustePos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBAjustePos.IconSize = 40
        Me.IBAjustePos.Location = New System.Drawing.Point(0, 0)
        Me.IBAjustePos.Name = "IBAjustePos"
        Me.IBAjustePos.Size = New System.Drawing.Size(260, 42)
        Me.IBAjustePos.TabIndex = 0
        Me.IBAjustePos.Text = "Ajuste de Ingreso"
        Me.IBAjustePos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBAjustePos.UseVisualStyleBackColor = True
        '
        'IBAdmin
        '
        Me.IBAdmin.BackColor = System.Drawing.Color.ForestGreen
        Me.IBAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBAdmin.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBAdmin.ForeColor = System.Drawing.Color.White
        Me.IBAdmin.IconChar = FontAwesome.Sharp.IconChar.Clipboard
        Me.IBAdmin.IconColor = System.Drawing.Color.Black
        Me.IBAdmin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBAdmin.IconSize = 40
        Me.IBAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IBAdmin.Location = New System.Drawing.Point(0, 0)
        Me.IBAdmin.Name = "IBAdmin"
        Me.IBAdmin.Size = New System.Drawing.Size(260, 42)
        Me.IBAdmin.TabIndex = 0
        Me.IBAdmin.Text = "Administración"
        Me.IBAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBAdmin.UseVisualStyleBackColor = False
        '
        'PLogo
        '
        Me.PLogo.Controls.Add(Me.PBLogo)
        Me.PLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLogo.Location = New System.Drawing.Point(0, 0)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(263, 60)
        Me.PLogo.TabIndex = 1
        '
        'PBLogo
        '
        Me.PBLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBLogo.Image = CType(resources.GetObject("PBLogo.Image"), System.Drawing.Image)
        Me.PBLogo.Location = New System.Drawing.Point(0, 0)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(263, 60)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBLogo.TabIndex = 0
        Me.PBLogo.TabStop = False
        '
        'PTitulo
        '
        Me.PTitulo.Controls.Add(Me.LTitulo)
        Me.PTitulo.Controls.Add(Me.IPTitulo)
        Me.PTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitulo.Location = New System.Drawing.Point(263, 0)
        Me.PTitulo.Name = "PTitulo"
        Me.PTitulo.Size = New System.Drawing.Size(611, 57)
        Me.PTitulo.TabIndex = 3
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Mont Demo Heavy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(65, 20)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(0, 15)
        Me.LTitulo.TabIndex = 1
        '
        'IPTitulo
        '
        Me.IPTitulo.BackColor = System.Drawing.Color.White
        Me.IPTitulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IPTitulo.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IPTitulo.IconColor = System.Drawing.SystemColors.ControlText
        Me.IPTitulo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IPTitulo.IconSize = 48
        Me.IPTitulo.Location = New System.Drawing.Point(8, 3)
        Me.IPTitulo.Name = "IPTitulo"
        Me.IPTitulo.Size = New System.Drawing.Size(51, 48)
        Me.IPTitulo.TabIndex = 0
        Me.IPTitulo.TabStop = False
        '
        'PNBase
        '
        Me.PNBase.Controls.Add(Me.PBCentral)
        Me.PNBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNBase.Location = New System.Drawing.Point(263, 57)
        Me.PNBase.Name = "PNBase"
        Me.PNBase.Size = New System.Drawing.Size(611, 473)
        Me.PNBase.TabIndex = 4
        '
        'PBCentral
        '
        Me.PBCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBCentral.Image = CType(resources.GetObject("PBCentral.Image"), System.Drawing.Image)
        Me.PBCentral.Location = New System.Drawing.Point(0, 0)
        Me.PBCentral.Name = "PBCentral"
        Me.PBCentral.Size = New System.Drawing.Size(611, 473)
        Me.PBCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBCentral.TabIndex = 0
        Me.PBCentral.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(874, 558)
        Me.Controls.Add(Me.PNBase)
        Me.Controls.Add(Me.PTitulo)
        Me.Controls.Add(Me.PnIzquierdo)
        Me.Controls.Add(Me.PNBorde)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaiveApp"
        Me.TopMost = True
        Me.PNBorde.ResumeLayout(False)
        Me.PNBorde.PerformLayout()
        Me.PnIzquierdo.ResumeLayout(False)
        Me.PMenu.ResumeLayout(False)
        Me.PSubMenuReportes.ResumeLayout(False)
        Me.PSubMenuInventario.ResumeLayout(False)
        Me.PSubMenuAdmin.ResumeLayout(False)
        Me.PLogo.ResumeLayout(False)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PTitulo.ResumeLayout(False)
        Me.PTitulo.PerformLayout()
        CType(Me.IPTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNBase.ResumeLayout(False)
        CType(Me.PBCentral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PNBorde As Panel
    Friend WithEvents PnIzquierdo As Panel
    Friend WithEvents LUsuario As Label
    Friend WithEvents BSalir As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents PMenu As Panel
    Friend WithEvents PLogo As Panel
    Friend WithEvents PSubMenuReportes As Panel
    Friend WithEvents IBResumen As FontAwesome.Sharp.IconButton
    Friend WithEvents IBKardex As FontAwesome.Sharp.IconButton
    Friend WithEvents IBReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents PSubMenuInventario As Panel
    Friend WithEvents IBSalida As FontAwesome.Sharp.IconButton
    Friend WithEvents IBIngreso As FontAwesome.Sharp.IconButton
    Friend WithEvents IBInventario As FontAwesome.Sharp.IconButton
    Friend WithEvents PSubMenuAdmin As Panel
    Friend WithEvents IBTraspaso As FontAwesome.Sharp.IconButton
    Friend WithEvents IBAjusteNeg As FontAwesome.Sharp.IconButton
    Friend WithEvents IBAjustePos As FontAwesome.Sharp.IconButton
    Friend WithEvents IBAdmin As FontAwesome.Sharp.IconButton
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents PTitulo As Panel
    Friend WithEvents LTitulo As Label
    Friend WithEvents IPTitulo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PNBase As Panel
    Friend WithEvents PBCentral As PictureBox

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
    End Sub
End Class
