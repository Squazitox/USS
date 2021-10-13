Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class CpDatos
    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("AppUSS").ConnectionString)

    'Para ver los clientes
    Public Function ClientList() As DataTable
        'Dim dt As New DataTable
        'Dim da As New SqlDataAdapter("sp_ListarClientes", conexion)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        'da.Fill(dt)
        'Return dt

        Dim cmd As New SqlCommand("Select idCliente, nombres, apellidos, dni, ruc FROM Cliente WHERE ruc <> '' ", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.Text
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function

    Public Sub D_ClientList(EntClient As CpEntidad)
        Dim cmd As New SqlCommand("Insert into Cliente Values (@nombres, @apellidos, @dni, @fechnacimiento, @genero, @tipocliente, @ruc, @estado)", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@nombres", EntClient.NomCliente)
            .AddWithValue("@apellidos", EntClient.ApeCliente)
            .AddWithValue("@dni", EntClient.DNICliente)
            .AddWithValue("@fechnacimiento", EntClient.FechaNacimientoCliente)
            .AddWithValue("@genero", EntClient.GeneroCliente)
            .AddWithValue("@tipocliente", EntClient.TipoCliente)
            .AddWithValue("@ruc", EntClient.RUCCliente)
            .AddWithValue("@estado", EntClient.EstCliente)

        End With

        cmd.ExecuteNonQuery()
        conexion.Close()
        cmd.Parameters.Clear()
    End Sub




End Class
