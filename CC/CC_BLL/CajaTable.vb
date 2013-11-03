Imports CC_DAL.CC_DBTableAdapters

Public Class CajaTable
    Implements ICheckSum
    Private _CajaAdapter As cajaTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As cajaTableAdapter
        Get
            If _CajaAdapter Is Nothing Then
                _CajaAdapter = New cajaTableAdapter()
            End If
            Return _CajaAdapter
        End Get
        Set(ByVal value As cajaTableAdapter)
            _CajaAdapter = value
        End Set
    End Property

    Public Function GetDataById(ByVal id As Long, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id)
        If validate Then
            'ValidateData_e(dt)
        End If
        Log.Record("Caja.GetDataById", _idUsuarioActual, id)
        Return dt
    End Function

    Public Function GetFirstTwo() As DataTable
        Dim dt As DataTable = Adapter.GetDataFirstTwo()
        Log.Record("Caja.GetDataFirstTwo", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetLastTwo() As DataTable
        Dim dt As DataTable = Adapter.GetDataLastTwo()
        Log.Record("Caja.GetDataLastTwo", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetPreviousTwoFromId(ByVal id As Integer) As DataTable
        Dim dt As DataTable = Adapter.GetDataPreviousTwoFromId(id)
        Log.Record("Caja.GetDataPreviousTwoFromId", _idUsuarioActual, id)
        Return dt
    End Function

    Public Function GetNextTwoFromId(ByVal id As Integer) As DataTable
        Dim dt As DataTable = Adapter.GetDataNextTwoFromId(id)
        Log.Record("Caja.GetDataNextTwoFromId", _idUsuarioActual, id)
        Return dt
    End Function

    Public Sub Add(ByVal id_caja As Long, ByVal monto_compra As Double, ByVal fecha As Date, ByVal id_cliente As Long)
        'Dim dt As DataTable = New CC_DAL.CC_DB.cajaDataTable()
        'Dim dr As DataRow = dt.NewRow()
        'dr("id_caja") = id_caja
        'dr("caja_mov") = 1
        'dr("monto_compra") = monto_compra
        'dr("fecha") = fecha
        'dr("hora") = fecha
        'dr("id_cliente") = id_cliente
        'dr("tipo_producto") = 1
        'dt.Rows.Add(dr)
        Adapter.Insert(id_caja, 1, monto_compra, fecha, New Nullable(Of Date), id_cliente, 1, 0)
        If Not SetCheckSum_e(Adapter.GetDataById(id_caja)) Then
            Throw New DataException("Error al actualizar el digito verificador")
        End If
        Log.Record("CajaTable.Add", _idUsuarioActual, id_caja, monto_compra, fecha, id_cliente)

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
