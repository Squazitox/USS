Imports System.Data.SqlClient
Imports CapaDatos.CpDatos


Public Class OrdenSuministro
    Inherits ConnectionSQL

    Public Function GetBestSupply(DesdeFecha As DateTime, HastaFecha As DateTime) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "IngresosProductos"
                command.Parameters.AddWithValue("@DesdeFecha", DesdeFecha)
                command.Parameters.AddWithValue("@HastaFecha", HastaFecha)
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

