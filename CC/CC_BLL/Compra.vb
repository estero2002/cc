Public Class Compra
    Private _idCompra As Long
    Private _fecha As Date
    Private _idCliente As Long
    Private _totalCompra As Double
    Private _items As List(Of ItemCompra)

    Public Sub New(ByVal idCompra As Long, ByVal fecha As Date)
        _idCompra = idCompra
        _fecha = fecha
        _items = New List(Of ItemCompra)
    End Sub

    Public Property IdCompra() As Long
        Get
            Return _idCompra
        End Get
        Set(ByVal value As Long)
            _idCompra = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Public Property IdCliente() As Long
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Long)
            _idCliente = value
        End Set
    End Property

    Public Property TotalCompra() As Double
        Get
            Return _totalCompra
        End Get
        Set(ByVal value As Double)
            _totalCompra = value
        End Set
    End Property

    Public Property Items() As List(Of ItemCompra)
        Get
            Return _items
        End Get
        Set(ByVal value As List(Of ItemCompra))
            _items = value
        End Set
    End Property
End Class
