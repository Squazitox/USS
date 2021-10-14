Public Class FormLogin
    'Definir variables globales; estas van despues de la linea de inherits
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario.

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        Arrastre = False

    End Sub

    Private Sub BLoginCancelar_Click(sender As Object, e As EventArgs) Handles BLoginCancelar.Click
        End
    End Sub

    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        Dim usuario As String
        Dim Contraseña As String

        usuario = TBUser.Text
        Contraseña = TBPassword.Text

        If (usuario = "manuel") And Contraseña = "manuel" Then
            FormAlerta.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña errada, por favor verificar")
        End If

        TBPassword.Text = ""
        TBUser.Text = ""


    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex - 8, MousePosition.Y - Me.Location.Y - ey - 60))

    End Sub

End Class
