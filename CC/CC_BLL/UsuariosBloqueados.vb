Imports CC_DAL.CC_DBTableAdapters
Public Class UsuariosBloqueados
    Implements ICheckSum
    Private _usuariosBloqueadosAdapter As usuarios_bloqueadosTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As usuarios_bloqueadosTableAdapter
        Get
            If _usuariosBloqueadosAdapter Is Nothing Then
                _usuariosBloqueadosAdapter = New usuarios_bloqueadosTableAdapter()
            End If
            Return _usuariosBloqueadosAdapter
        End Get
        Set(ByVal value As usuarios_bloqueadosTableAdapter)
            _usuariosBloqueadosAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("UsuariosBloqueados.GetData", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataConDataUsuario() As DataTable
        Dim dt As CC_DAL.CC_DB.usuarios_bloqueadosDataTable
        Dim row As DataRow
        dt = Adapter.GetDataConDataUsuario()
        Dim col As New DataColumn
        col.ColumnName = "usuario"
        dt.Columns.Add(col)
        For Each row In dt.Rows
            row("usuario") = Encriptor.ShiftK(row("apellido"), -1) + ", " + Encriptor.ShiftK(row("nombre"), -1)
        Next
        Log.Record("UsuariosBloqueados.GetDataConDataUsuario", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataByIdUsuario(ByVal id_usuario As Long, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id_usuario)
        If validate Then
            ValidateData_e(dt)
            unencryptDataTable(dt)
        End If
        Log.Record("UsuariosBloqueados.GetDataByIdUsuario", _idUsuarioActual, id_usuario)
        Return dt
    End Function

    Public Function Delete(ByVal id_usuario As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id_usuario, False)
        dt.Rows(0).Delete()
        Log.Record("UsuariosBloqueados.Delete", _idUsuarioActual, id_usuario)
        Return Adapter.Update(dt) = 1
    End Function

    Public Sub Add(ByVal id_usuario As Long)
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("id_usuario") = id_usuario
        dr("fecha_bloqueo") = Date.Now
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Adapter.Insert(dr("id_usuario"), dr("fecha_bloqueo"), strval)
        SetCheckSum_e(Adapter.GetDataById(id_usuario))
        Log.Record("UsuariosBloqueados.Add", _idUsuarioActual, id_usuario)
    End Sub

    Private Function ValidateData_e(ByVal dt As DataTable) As Boolean Implements ICheckSum.ValidateData_e
        Dim dtErrors As New DataTable
        If Not CheckSum.Check(dt, dtErrors) Then
            dt = Nothing
            Throw New ApplicationException("Existen registros inconsistentes")
            Return False
        End If
        Return True
    End Function

    Public Function SetCheckSum_e(ByVal dt As DataTable) As Boolean Implements ICheckSum.SetCheckSum_e
        CheckSum.Generate(dt)
        Return Adapter.Update(dt) = 1
    End Function

    Public Function SetCheckSumAll_e() As Boolean Implements ICheckSum.SetCheckSumAll_e
        Dim dt As DataTable = Adapter.GetData()
        Return SetCheckSum_e(dt)
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

    Private Function GetDataById_e(ByVal id_usuario As Long, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id_usuario)
        If validate Then
            ValidateData_e(dt)
        End If
        Return dt
    End Function
End Class
