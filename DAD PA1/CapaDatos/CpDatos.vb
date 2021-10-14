Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class CpDatos
    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("AppLaive").ConnectionString)

    Public Function Login() As DataTable

        Dim cmd As New SqlCommand("sp_Login", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function

    Public Sub LoginUser(EntClient As CpEntidad)
        Dim cmd As New SqlCommand("sp_Login", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@user", EntClient.Usuario)
            .AddWithValue("@password", EntClient.Password)

        End With

        cmd.ExecuteNonQuery()
        conexion.Close()
        cmd.Parameters.Clear()
    End Sub




End Class
