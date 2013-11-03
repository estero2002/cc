Public Class ItemCompra
    Private _idProducto As Long
    Private _tipoProducto As Long
    Private _cantidad As Integer
    Private _importe As Double
    Private _descripProducto As String
    Private _descripTipoProducto As String

    Public Sub New(ByVal idProducto As Long, ByVal tipoProducto As Long, ByVal cantidad As Integer, ByVal importe As Double)
        _idProducto = idProducto
        _tipoProducto = tipoProducto
        _cantidad = cantidad
        _importe = importe
    End Sub

    Public Property IdProducto() As Long
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Long)
            _idProducto = value
        End Set
    End Property

    Public Property TipoProducto() As Long
        Get
            Return _tipoProducto
        End Get
        Set(ByVal value As Long)
            _tipoProducto = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    Public Property DescripProducto() As String
        Get
            Return _descripProducto
        End Get
        Set(ByVal value As String)
            _descripProducto = value
        End Set
    End Property

    Public Property DescripTipoProducto() As String
        Get
            Return _descripTipoProducto
        End Get
        Set(ByVal value As String)
            _descripTipoProducto = value
        End Set
    End Property
End Class

Public Class ItemCompraComparer
    Implements IEqualityComparer(Of ItemCompra)

    Public Overloads Function Equals(ByVal i1 As ItemCompra, ByVal i2 As ItemCompra) As Boolean Implements IEqualityComparer(Of ItemCompra).Equals
        If i1.IdProducto = i2.IdProducto And i1.TipoProducto = i2.TipoProducto Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overloads Function GetHashCode(ByVal item As ItemCompra) As Integer Implements IEqualityComparer(Of ItemCompra).GetHashCode
        Dim hCode As Integer = item.IdProducto Xor item.TipoProducto Xor item.Cantidad Xor item.Importe Xor item.DescripProducto Xor item.DescripTipoProducto
        Return hCode.GetHashCode()
    End Function
End Class
