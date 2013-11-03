Imports CC_DAL.CC_DBTableAdapters

Public Class Producto
    Implements ICheckSum
    Private _ProductoAdapter As ProductoTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As ProductoTableAdapter
        Get
            If _ProductoAdapter Is Nothing Then
                _ProductoAdapter = New ProductoTableAdapter()
            End If
            Return _ProductoAdapter
        End Get
        Set(ByVal value As ProductoTableAdapter)
            _ProductoAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("Producto.GetData", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataByTipoProducto(ByVal tipoProducto As Integer) As DataTable
        Dim dt As DataTable = Adapter.GetDataByTipoProducto(tipoProducto)
        'ValidateData_e(dt)
        Log.Record("Producto.GetDataByTipoProducto", _idUsuarioActual, tipoProducto)
        Return dt
    End Function

    Public Function GetDataFiltered(ByVal descri As String) As DataTable
        Dim dt As CC_DAL.CC_DB.ProductoDataTable
        'Dim row As DataRow
        dt = Adapter.GetDataByDescri(descri)
        'For Each row In dt.Rows
        '    row("Producto") = Encriptor.ShiftK(row("Producto"), -1)
        'Next
        Log.Record("Producto.GetDataFiltered", _idUsuarioActual, descri)
        Return dt
    End Function

    Public Overloads Function Add(ByVal descripcion As String, ByVal tipoproducto As Integer, ByVal precio As Double) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("descripcion") = descripcion
        dr("tipo_producto") = tipoproducto
        dr("precio") = precio
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id, dr("descripcion"), dr("precio"), dr("tipo_producto"), strval)
        If Not SetCheckSum_e(Adapter.GetDataById(id)) Then
            id = 0
        End If
        Log.Record("Producto.Add", _idUsuarioActual, id, descripcion, tipoproducto, precio)
        Return id
    End Function

    Public Overloads Function Update(ByVal id As Long, _
        ByVal descripcion As String, ByVal tipoproducto As Integer, ByVal precio As Double) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id)
        Dim dr As DataRow = dt.Rows(0)
        dr("id_Producto") = id
        dr("descripcion") = descripcion
        dr("tipo_producto") = tipoproducto
        dr("precio") = precio
        encryptDataTable(dt)
        Log.Record("Producto.Update", _idUsuarioActual, id, descripcion, tipoproducto, precio)
        Return SetCheckSum_e(dt)
    End Function
    Public Function Delete(ByVal id As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id, False)
        dt.Rows(0).Delete()
        Log.Record("Producto.Delete", _idUsuarioActual, id)
        Return Adapter.Update(dt) = 1
    End Function


    Private Function GetDataById_e(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id)
        If validate Then
            ValidateData_e(dt)
        End If
        Return dt
    End Function

    Private Sub unencryptDataTable(ByRef dt As DataTable)
        'For Each row As DataRow In dt.Rows
        '    row.Item("apellido") = Encriptor.ShiftK(row.Item("apellido"), -1)
        '    row.Item("nombre") = Encriptor.ShiftK(row.Item("nombre"), -1)
        '    row.Item("direccion") = Encriptor.ShiftK(row.Item("direccion"), -1)
        '    row.Item("email") = Encriptor.ShiftK(row.Item("email"), -1)
        'Next
    End Sub
    Private Sub encryptDataTable(ByRef dt As DataTable)
        'For Each row As DataRow In dt.Rows
        '    row.Item("apellido") = Encriptor.ShiftK(row.Item("apellido"), 1)
        '    row.Item("nombre") = Encriptor.ShiftK(row.Item("nombre"), 1)
        '    row.Item("direccion") = Encriptor.ShiftK(row.Item("direccion"), 1)
        '    row.Item("email") = Encriptor.ShiftK(row.Item("email"), 1)
        'Next
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

    Public Function GetDataById(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id)
        If validate Then
            ValidateData_e(dt)
            unencryptDataTable(dt)
        End If
        Log.Record("Producto.GetDataById", _idUsuarioActual, id)
        Return dt
    End Function

    Public Function T_UpdateWithoutCheckSum(ByVal dt As DataTable) As Boolean
        For Each row As DataRow In dt.Rows
            'row("apellido") = Encriptor.ShiftK(row("apellido"), 1)
            'row("nombre") = Encriptor.ShiftK(row("nombre"), 1)
            'row("direccion") = Encriptor.ShiftK(row("direccion"), 1)
            'row("email") = Encriptor.ShiftK(row("email"), 1)
        Next
        Return Adapter.Update(dt)
    End Function

End Class
