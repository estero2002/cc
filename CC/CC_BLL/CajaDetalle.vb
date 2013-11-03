Imports CC_DAL.CC_DBTableAdapters

Public Class CajaDetalle
    Implements ICheckSum
    Private _CajaDetalleAdapter As CajaDetalleTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As CajaDetalleTableAdapter
        Get
            If _CajaDetalleAdapter Is Nothing Then
                _CajaDetalleAdapter = New CajaDetalleTableAdapter()
            End If
            Return _CajaDetalleAdapter
        End Get
        Set(ByVal value As CajaDetalleTableAdapter)
            _CajaDetalleAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Return Adapter.GetData()
    End Function

    Public Function GetDataByCajaId(ByVal id As Long) As DataTable
        Dim dt As DataTable = Adapter.GetDataByCajaId(id)
        Log.Record("CajaDetalle.GetDataByCajaId", _idUsuarioActual, id)
        Return dt
    End Function

    Public Sub Add(ByVal id_caja As Long, ByVal id_producto As Long, ByVal tipo_producto As Long, ByVal cantidad As Integer, ByVal importe As Double)
        Dim id As Long = 0
        Adapter.Insert(id, id_caja, id_producto, tipo_producto, cantidad, importe, 0)
        If Not SetCheckSum_e(Adapter.GetDataById(id)) Then
            Throw New DataException("Error al actualizar el digito verificador")
        End If
        Log.Record("CajaDetalle.Add", _idUsuarioActual, id, id_caja, id_producto, tipo_producto, cantidad, importe)
    End Sub

    Public Function SetCheckSum_e(ByVal dt As DataTable) As Boolean Implements ICheckSum.SetCheckSum_e
        CheckSum.Generate(dt)
        Return Adapter.Update(dt) = 1
    End Function

    Public Function SetCheckSumAll_e() As Boolean Implements ICheckSum.SetCheckSumAll_e
        Dim dt As DataTable = Adapter.GetData()
        Return SetCheckSum_e(dt)
    End Function

    Private Function ValidateData_e(ByVal dt As DataTable) As Boolean Implements ICheckSum.ValidateData_e
        Dim dtErrors As New DataTable
        If Not CheckSum.Check(dt, dtErrors) Then
            dt = Nothing
            Throw New ApplicationException("Existen registros inconsistentes")
            Return False
        End If
        Return True
    End Function
End Class
