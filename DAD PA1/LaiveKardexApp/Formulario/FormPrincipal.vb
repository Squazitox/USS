Imports FontAwesome.Sharp
Public Class FormPrincipal

    Private BtnActual As IconButton
    Private LeftBorderBtn As Panel
    Private FormHijo As Form

    Private Sub HideSubMenu()
        PSubMenuAdmin.Visible = False
        PSubMenuInventario.Visible = False
        PSubMenuReportes.Visible = False

    End Sub

    Private Sub ShowSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False

        End If
    End Sub
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LeftBorderBtn = New Panel With {
            .Size = New Size(3, 42)
        }
        PnIzquierdo.Controls.Add(LeftBorderBtn)

    End Sub
    Private Sub ActivateButton(SenderBtn As Object, customcolor As Color)
        If SenderBtn IsNot Nothing Then
            ButtonOff()
            'Creacion de los cambios para el boton
            BtnActual = CType(SenderBtn, IconButton)
            BtnActual.BackColor = Color.FromArgb(245, 222, 0)
            BtnActual.ForeColor = Color.FromArgb(245, 63, 0)
            BtnActual.IconColor = Color.FromArgb(245, 63, 0)
            BtnActual.TextAlign = ContentAlignment.MiddleCenter
            'BtnActual.ImageAlign = ContentAlignment.MiddleCenter
            BtnActual.TextImageRelation = TextImageRelation.TextBeforeImage
            'Cambios para el Borde y el icono principal
            LeftBorderBtn.BackColor = customcolor
            LeftBorderBtn.Visible = False
            LeftBorderBtn.BringToFront()
            LeftBorderBtn.Location = New Point(0, BtnActual.Location.Y)
            IPTitulo.IconChar = BtnActual.IconChar
            IPTitulo.IconColor = Color.ForestGreen
            LTitulo.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub ButtonOff()
        If BtnActual IsNot Nothing Then
            'Codigo para la desactivacion de los cambio
            BtnActual.BackColor = Color.White
            BtnActual.ForeColor = Color.Black
            BtnActual.IconColor = Color.Black
            BtnActual.TextAlign = ContentAlignment.MiddleLeft
            BtnActual.ImageAlign = ContentAlignment.MiddleCenter
            BtnActual.TextImageRelation = TextImageRelation.ImageBeforeText


        End If
    End Sub

    'Para abrir un formulario
    Private Sub OpenForm(Hijo As Form)
        If FormHijo IsNot Nothing Then
            FormHijo.Close()
        End If
        FormHijo = Hijo
        Hijo.TopLevel = False
        Hijo.FormBorderStyle = FormBorderStyle.None
        Hijo.Dock = DockStyle.Fill


        PNBase.Controls.Add(Hijo)
        PNBase.Tag = Hijo
        Hijo.BringToFront()
        Hijo.Show()

    End Sub
    Private Sub IBAdmin_Click(sender As Object, e As EventArgs) Handles IBAdmin.Click
        ShowSubMenu(PSubMenuAdmin)

    End Sub

    Private Sub IBInventario_Click(sender As Object, e As EventArgs) Handles IBInventario.Click
        ShowSubMenu(PSubMenuInventario)
    End Sub

    Private Sub IBReportes_Click(sender As Object, e As EventArgs) Handles IBReportes.Click
        ShowSubMenu(PSubMenuReportes)

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End
    End Sub

    Private Sub IBAjustePos_Click(sender As Object, e As EventArgs) Handles IBAjustePos.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormAjusteIngreso)
        LTitulo.Text = IBAjustePos.Text
    End Sub

    Private Sub IBAjusteNeg_Click(sender As Object, e As EventArgs) Handles IBAjusteNeg.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormAjusteSalida)
        LTitulo.Text = IBAjusteNeg.Text
    End Sub

    Private Sub IBTraspaso_Click(sender As Object, e As EventArgs) Handles IBTraspaso.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormTraspaso)
        LTitulo.Text = IBTraspaso.Text
    End Sub

    Private Sub IBIngreso_Click(sender As Object, e As EventArgs) Handles IBIngreso.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormIngreso)
        LTitulo.Text = IBIngreso.Text
    End Sub

    Private Sub IBSalida_Click(sender As Object, e As EventArgs) Handles IBSalida.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormSalida)
        LTitulo.Text = IBSalida.Text
    End Sub

    Private Sub IBKardex_Click(sender As Object, e As EventArgs) Handles IBKardex.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormKardex)
        LTitulo.Text = IBKardex.Text
    End Sub

    Private Sub IBResumen_Click(sender As Object, e As EventArgs) Handles IBResumen.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormResumen)
        LTitulo.Text = IBResumen.Text
    End Sub
End Class