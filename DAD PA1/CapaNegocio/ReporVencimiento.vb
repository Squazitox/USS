Imports CapaDatos
Public Class ReporVencimiento
    Private _reportDate As DateTime
    Private _starDate As DateTime
    Private _endDate As DateTime
    Private _listaProVencer As List(Of ProductosVencimiento)

    Public Property ReportDate As Date
        Get
            Return _reportDate
        End Get
        Private Set(value As Date)
            _reportDate = value
        End Set
    End Property

    Public Property StarDate As Date
        Get
            Return _starDate
        End Get
        Private Set(value As Date)
            _starDate = value
        End Set
    End Property

    Public Property EndDate As Date
        Get
            Return _endDate
        End Get
        Private Set(value As Date)
            _endDate = value
        End Set
    End Property

    Public Property ListaProVencer As List(Of ProductosVencimiento)
        Get
            Return _listaProVencer
        End Get
        Private Set(value As List(Of ProductosVencimiento))
            _listaProVencer = value
        End Set
    End Property

    Public Sub ProductosProximosVencimeinto(fromDate As DateTime, toDate As DateTime)
        ReportDate = Date.Now()
        StarDate = fromDate
        EndDate = toDate
        ListaProVencer = New List(Of ProductosVencimiento)()
        Dim ProxVencerDAO = New ProxVencerDAO()
        Dim resulTable = ProxVencerDAO.GetBestSellingVencimiento(fromDate, toDate)

        For Each row As DataRow In resulTable.Rows
            Dim ProductosVencimientoModelo = New ProductosVencimiento() With
                {
                .IdSuministra = Convert.ToString(row(0)),
                .Nombre_Producto = Convert.ToString(row(1)),
                .Fecha_Caducidad = Convert.ToDateTime(row(2)),
                .Proveedor = Convert.ToString(row(3)),
                .lote = Convert.ToInt32(row(4)),
                .Ubicación = Convert.ToString(row(5))
            }
            ListaProVencer.Add(ProductosVencimientoModelo)

        Next


    End Sub
End Class
