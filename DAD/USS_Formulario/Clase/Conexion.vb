Imports System.Data
Imports System.Data.SqlClient

'Conexion
Public Class ConexionSQL
    Public conexion As SqlConnection = New SqlConnection("data source = SQUAZ-PC; initial catalog = BDSupermercado; user id = sa; password = Manuel+10")
    'Aplicacion de la conecion
    Public Sub connection()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("No Conectado")
        End Try
    End Sub

    'Para ver los clientes
    Public Function ClientList() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("sp_ListarClientes", conexion)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt

    End Function
End Class
