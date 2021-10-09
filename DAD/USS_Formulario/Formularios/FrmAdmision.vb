Imports CapaNegocio
Public Class FrmAdmision
    'Dim conexion As ConexionSQL = New ConexionSQL()
    Dim objNegocio As New CpNegocio

    Private Sub FrmAdmision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewClient()
        'Me.DataGridView1.DataSource = conexion.ClientList
    End Sub

    Sub ViewClient()
        Dim dt As DataTable = objNegocio.Neg_ClientList
        Me.DataGridView1.DataSource = dt


    End Sub

    Private Sub BTAgregar_Click(sender As Object, e As EventArgs) Handles BTAgregar.Click
        Dim FormAgregar As New FormAgregar
        FormAgregar.ShowDialog()
        ViewClient()
    End Sub
End Class