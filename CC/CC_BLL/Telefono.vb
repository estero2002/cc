Imports CC_DAL.CC_DBTableAdapters

Public Class Telefono
    Implements ICheckSum
    Private _TelefonoAdapter As telefonoTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As telefonoTableAdapter
        Get
            If _TelefonoAdapter Is Nothing Then
                _TelefonoAdapter = New telefonoTableAdapter()
            End If
            Return _TelefonoAdapter
        End Get
        Set(ByVal value As telefonoTableAdapter)
            _TelefonoAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("Telefono.GetData", _idUsuarioActual, "")
        Return dt
    End Function
    Public Overloads Function Add(ByVal id_usuario As Long, ByVal id_tipo_num As Integer, ByVal numero As String) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataByIdUsuario_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("id_usuario") = id_usuario
        dr("id_tipo_num") = id_tipo_num
        dr("numero") = numero
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id, dr("id_usuario"), dr("id_tipo_num"), dr("numero"), strval)
        If Not SetCheckSum_e(Adapter.GetDataByIdUsuario(id_usuario)) Then
            id = 0
        End If
        Log.Record("Telefono.Add", _idUsuarioActual, id_usuario, id_tipo_num, numero)
        Return id
    End Function

    Public Overloads Function Update(ByVal dt As DataTable) As Boolean
        Log.Record("Telefono.Update", _idUsuarioActual, "")
        encryptDataTable(dt)
        Return SetCheckSum_e(dt)
    End Function


    Public Function DeleteByIdUsuario(ByVal id As Long) As Boolean
        Dim dt As DataTable, row As DataRow
        dt = GetDataByIdUsuario_e(id, False)
        For Each row In dt.Rows
            row.Delete()
        Next
        Log.Record("Telefono.DeleteByIdUsuario", _idUsuarioActual, id)
        Return Adapter.Update(dt) = 1
    End Function
    Public Function Delete(ByVal id As Long)
        Dim dt As DataTable
        dt = GetDataById_e(id, False)
        dt.Rows(0).Delete()
        Log.Record("Telefono.Delete", _idUsuarioActual, id)
        Return Adapter.Update(dt) = 1
    End Function
    Private Function GetDataById_e(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id)
        If validate Then
            ValidateData_e(dt)
        End If
        Return dt
    End Function


    Private Function GetDataByIdUsuario_e(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataByIdUsuario(id)
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
        Return Adapter.Update(dt) > 0
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

    Public Function GetDataByIdUsuario(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataByIdUsuario(id)
        If validate Then
            ValidateData_e(dt)
            unencryptDataTable(dt)
        End If
        Log.Record("Telefono.GetDataByIdUsuario", _idUsuarioActual, id)
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
