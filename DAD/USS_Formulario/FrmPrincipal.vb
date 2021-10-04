Imports FontAwesome.Sharp
Public Class FrmPrincipal

    Private BtnActual As IconButton
    Private LeftBorderBtn As Panel
    Private FormHijo As Form

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        'Iguala el Icono con el del boton
        IconPrincipal.IconChar = BtnInicio.IconChar
        'Iguala el label de texto con el del boton
        Label1.Text = BtnInicio.Text
        'ejecuta los cambios de boton activo
        ActivateButton(sender, PaletaRGB.Color1)
        'ejecuta los cambios de formulario activo
        OpenForm(New FrmInicio)
    End Sub

    Private Sub BtnAdmision_Click(sender As Object, e As EventArgs) Handles BtnAdmision.Click
        IconPrincipal.IconChar = BtnAdmision.IconChar
        Label1.Text = BtnAdmision.Text
        ActivateButton(sender, PaletaRGB.Color2)
        OpenForm(New FrmAdmision)
    End Sub

    Private Sub BtnEscuela_Click(sender As Object, e As EventArgs) Handles BtnEscuela.Click
        IconPrincipal.IconChar = BtnEscuela.IconChar
        Label1.Text = BtnEscuela.Text
        ActivateButton(sender, PaletaRGB.Color3)
        OpenForm(New FrmEscuela)

    End Sub

    Private Sub BtnBiblioteca_Click(sender As Object, e As EventArgs) Handles BtnBiblioteca.Click
        IconPrincipal.IconChar = BtnBiblioteca.IconChar
        Label1.Text = BtnBiblioteca.Text
        ActivateButton(sender, PaletaRGB.Color4)
        OpenForm(New FrmBiblioteca)
    End Sub

    Private Sub BtnTransparencia_Click(sender As Object, e As EventArgs) Handles BtnTransparencia.Click
        IconPrincipal.IconChar = BtnTransparencia.IconChar
        Label1.Text = BtnTransparencia.Text
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FrmTransparencia)
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LeftBorderBtn = New Panel With {
            .Size = New Size(8, 75)
        }
        PnIzquierda.Controls.Add(LeftBorderBtn)



    End Sub
    Private Sub ActivateButton(SenderBtn As Object, customcolor As Color)
        If SenderBtn IsNot Nothing Then
            'Creacion de los cambios para el boton
            BtnActual = CType(SenderBtn, IconButton)
            BtnActual.BackColor = Color.FromArgb(45, 46, 124)
            BtnActual.ForeColor = customcolor
            BtnActual.IconColor = customcolor
            BtnActual.TextAlign = ContentAlignment.MiddleCenter
            'BtnActual.ImageAlign = ContentAlignment.MiddleCenter
            BtnActual.TextImageRelation = TextImageRelation.TextBeforeImage
            'Cambios para el Borde y el icono principal
            LeftBorderBtn.BackColor = customcolor
            LeftBorderBtn.Visible = True
            LeftBorderBtn.BringToFront()
            LeftBorderBtn.Location = New Point(0, BtnActual.Location.Y)
            IconPrincipal.IconChar = BtnActual.IconChar
            IconPrincipal.IconColor = customcolor
            Label1.ForeColor = customcolor
        End If
    End Sub

    Private Sub ButtonOff()
        If BtnActual IsNot Nothing Then
            'Codigo para la desactivacion de los cambio
            BtnActual.BackColor = Color.Teal
            BtnActual.ForeColor = Color.White
            BtnActual.IconColor = Color.White
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

        PnPrincipal.Controls.Add(Hijo)
        PnPrincipal.Tag = Hijo
        Hijo.BringToFront()
        Hijo.Show()

    End Sub


End Class