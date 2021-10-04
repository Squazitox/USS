Public Class FrmAdmision
    Dim conexion As ConexionSQL = New ConexionSQL()

    Private Sub FrmAdmision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = conexion.ClientList
    End Sub
End Class