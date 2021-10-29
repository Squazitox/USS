Imports System.Data.SqlClient
Imports CapaDatos.CpDatos


Public Class OrdenSuministro
    Inherits ConnectionSQL

    Public Function GetBestSupply(DesdeFecha As DateTime, HastaFecha As DateTime, Producto As Object) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "IngresosProductos"
                command.Parameters.Add("@DesdeFecha", SqlDbType.Date).Value = DesdeFecha
                command.Parameters.Add("@HastaFecha", SqlDbType.Date).Value = HastaFecha
                command.Parameters.AddWithValue("@producto", Producto)
                command.CommandType = CommandType.StoredProcedure
                Dim reader = command.ExecuteReader()
                Dim table = New DataTable()
                table.Load(reader)
                reader.Dispose()
                Return table
            End Using
        End Using
    End Function


    Public Function GetBestSupply1(DesdeFecha As DateTime, HastaFecha As DateTime) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "sp_ReporteIngreso"
                command.Parameters.Add("@DesdeFecha", SqlDbType.Date).Value = DesdeFecha
                command.Parameters.Add("@HastaFecha", SqlDbType.Date).Value = HastaFecha
                command.CommandType = CommandType.StoredProcedure
                Dim reader = command.ExecuteReader()
                Dim table = New DataTable()
                table.Load(reader)
                reader.Dispose()
                Return table
            End Using
        End Using
    End Function
End Class

