Imports CapaEntidad
Imports CapaDatos
Public Class Reporte
    'Attributes
    Private _reportDate As DateTime
    Private _startDate As DateTime
    Private _endDAte As DateTime
    Private _listBestProducts As List(Of CpEntidad)
    Private _total As Double
    'Propiertes
    Public Property ReportDate As Date
        Get
            Return _reportDate
        End Get
        Private Set(value As Date)
            _reportDate = value
        End Set
    End Property

    Public Property StartDate As Date
        Get
            Return _startDate
        End Get
        Private Set(value As Date)
            _startDate = value
        End Set
    End Property

    Public Property EndDAte As Date
        Get
            Return _endDAte
        End Get
        Private Set(value As Date)
            _endDAte = value
        End Set
    End Property

    Public Property ListBestProducts As List(Of CpEntidad)
        Get
            Return _listBestProducts
        End Get
        Private Set(value As List(Of CpEntidad))
            _listBestProducts = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property
    'Constructors
    'Methods
    Public Sub GetBestSupplyReport(DesdeFecha As DateTime, HastaFecha As DateTime, Producto As Object)
        'implement dates
        ReportDate = Date.Now()
        StartDate = DesdeFecha
        EndDAte = HastaFecha
        ListBestProducts = New List(Of CpEntidad)()

        Dim OrdenSuministro = New OrdenSuministro()
        Dim resultTable = OrdenSuministro.GetBestSupply(DesdeFecha, HastaFecha, Producto
                                                        )

        For Each row As DataRow In resultTable.Rows
            Dim bestProductModel = New CpEntidad() With
                {
            .idProducto = Convert.ToString(row(0)),
            .descripcion = Convert.ToString(row(1)),
            .precio_compra = Convert.ToDouble(row(2)),
            .cantidad = Convert.ToDouble(row(3)),
            .Total = Convert.ToDouble(row(4))
            }
            ListBestProducts.Add(bestProductModel)
            Total += Convert.ToDouble(row(4))
        Next
    End Sub

    Public Sub SupplyReport(DesdeFecha As DateTime, HastaFecha As DateTime)
        'implement dates
        ReportDate = Date.Now()
        StartDate = DesdeFecha
        EndDAte = HastaFecha
        ListBestProducts = New List(Of CpEntidad)()

        Dim OrdenSuministro = New OrdenSuministro()
        Dim resultTable = OrdenSuministro.GetBestSupply1(DesdeFecha, HastaFecha)

        For Each row As DataRow In resultTable.Rows
            Dim bestProductModel = New CpEntidad() With
                {
            .idProducto = Convert.ToString(row(0)),
            .descripcion = Convert.ToString(row(1)),
            .precio_compra = Convert.ToDouble(row(2)),
            .cantidad = Convert.ToDouble(row(3)),
            .Total = Convert.ToDouble(row(4))
            }
            ListBestProducts.Add(bestProductModel)
            Total += Convert.ToDouble(row(4))
        Next
    End Sub

End Class
