Imports FontAwesome.Sharp
Public Class FrmPrincipal

    Private BtnActual As IconButton
    Private LeftBorderBtn As Panel
    Dim Cálculos As FrmPrincipal
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        IconPrincipal.IconChar = BtnInicio.IconChar
        Label1.Text = BtnInicio.Text
    End Sub

    Private Sub BtnAdmision_Click(sender As Object, e As EventArgs) Handles BtnAdmision.Click
        IconPrincipal.IconChar = BtnAdmision.IconChar
        Label1.Text = BtnAdmision.Text
    End Sub

    Private Sub BtnEscuela_Click(sender As Object, e As EventArgs) Handles BtnEscuela.Click
        IconPrincipal.IconChar = BtnEscuela.IconChar
        Label1.Text = BtnEscuela.Text
    End Sub

    Private Sub BtnBiblioteca_Click(sender As Object, e As EventArgs) Handles BtnBiblioteca.Click
        IconPrincipal.IconChar = BtnBiblioteca.IconChar
        Label1.Text = BtnBiblioteca.Text
    End Sub

    Private Sub BtnTransparencia_Click(sender As Object, e As EventArgs) Handles BtnTransparencia.Click
        IconPrincipal.IconChar = BtnTransparencia.IconChar
        Label1.Text = BtnTransparencia.Text
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LeftBorderBtn = New Panel()
        LeftBorderBtn.Size = New Size(8, 55)
        PnIzquierda.Controls.Add(LeftBorderBtn)



    End Sub
    Private Sub ActivateButton(SenderBtn As Object, customcolor As Color)
        If SenderBtn IsNot Nothing Then
            BtnActual = CType(SenderBtn, IconButton)
            BtnActual.BackColor = Color.FromArgb(37, 36, 81)
            BtnActual.ForeColor = customcolor
            BtnActual.IconColor = customcolor
            BtnActual.TextAlign = ContentAlignment.MiddleCenter
            BtnActual.ImageAlign = TextImageRelation.TextBeforeImage

            LeftBorderBtn.BackColor = customcolor
            LeftBorderBtn.Visible = True
            LeftBorderBtn.BringToFront()
            LeftBorderBtn.Location = New Point(0, BtnActual.Location.Y)
            IconPrincipal.IconChar = BtnActual.IconChar
            IconPrincipal.IconColor = BtnActual.IconColor
        End If
    End Sub

End Class