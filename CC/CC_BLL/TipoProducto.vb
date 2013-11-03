Imports CC_DAL.CC_DBTableAdapters
Public Class TipoProducto
    Implements ICheckSum
    Private _TipoProductoAdapter As tipo_productoTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Property Adapter() As tipo_productoTableAdapter
        Get
            If _TipoProductoAdapter Is Nothing Then
                _TipoProductoAdapter = New tipo_productoTableAdapter()
            End If
            Return _TipoProductoAdapter
        End Get
        Set(ByVal value As tipo_productoTableAdapter)
            _TipoProductoAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("TipoProducto.GetData", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataForCajaForm() As DataTable
        Dim dt As DataTable = Adapter.GetDataForCajaForm()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("TipoProducto.GetDataForCajaForm", _idUsuarioActual, "")
        Return dt
    End Function

    Private Sub unencryptDataTable(ByRef dt As DataTable)
        For Each row As DataRow In dt.Rows
            row.Item("descripcion") = Encriptor.ShiftK(row.Item("descripcion"), -1)
        Next
    End Sub
    Private Sub encryptDataTable(ByRef dt As DataTable)
        For Each row As DataRow In dt.Rows
            row.Item("descripcion") = Encriptor.ShiftK(row.Item("descripcion"), 1)
        Next
    End Sub

    Private Function SetCheckSum_e(ByVal dt As DataTable) As Boolean Implements ICheckSum.SetCheckSum_e
        CheckSum.Generate(dt)
        Return Adapter.Update(dt) = 1
    End Function

    Private Function SetCheckSumAll_e() As Boolean Implements ICheckSum.SetCheckSumAll_e
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
