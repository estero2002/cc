Imports CC_DAL.CC_DBTableAdapters
Public Class UsuarioPermisosNeg
    Implements ICheckSum
    Private _usuarioPermsisosNegAdapter As usuario_pattern_negTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As usuario_pattern_negTableAdapter
        Get
            If _usuarioPermsisosNegAdapter Is Nothing Then
                _usuarioPermsisosNegAdapter = New usuario_pattern_negTableAdapter()
            End If
            Return _usuarioPermsisosNegAdapter
        End Get
        Set(ByVal value As usuario_pattern_negTableAdapter)
            _usuarioPermsisosNegAdapter = value
        End Set
    End Property

    Public Function UpdateSelected(ByVal id_usuario As Long, ByVal PermisosToAdd As String, ByVal PermisosToRemove As String) As Long
        Dim spliter(0) As String
        Dim res As Long
        If (PermisosToAdd.Length > 0) Then
            Dim toAdd() As String = PermisosToAdd.Split(",")
            For i As Integer = 0 To toAdd.Length - 1
                res = Me.Add(id_usuario, Int32.Parse(toAdd(i)))
            Next
        End If

        If (PermisosToRemove.Length > 0) Then
            Dim toRemove() As String = PermisosToRemove.Split(",")
            For i As Integer = 0 To toRemove.Length - 1
                res = Me.Delete(id_usuario, Int32.Parse(toRemove(i)))
            Next
        End If
        Log.Record("UsuarioPermisosNeg.UpdateSelected", _idUsuarioActual, id_usuario, PermisosToAdd, PermisosToRemove)
        Return res
    End Function

    Public Overloads Function Add(ByVal id_usuario As Long, ByVal id_patt As Long) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("id_usuario") = id_usuario
        dr("id_patt") = id_patt
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id, dr("id_usuario"), dr("id_patt"), strval)
        If Not SetCheckSum_e(Adapter.GetDataById(id)) Then
            id = 0
        End If
        Log.Record("UsuarioPermisosNeg.Add", _idUsuarioActual, id_usuario, id_patt)
        Return id
    End Function

    Public Overloads Function Delete(ByVal id_usuario As Long, ByVal id_patt As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataByUsuPatt_e(id_usuario, id_patt, False)
        dt.Rows(0).Delete()
        Log.Record("UsuarioPermisosNeg.Delete", _idUsuarioActual, id_usuario, id_patt)
        Return Adapter.Update(dt) = 1
    End Function

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
        Log.Record("UsuarioPermisosNeg.GetDataById", _idUsuarioActual, id)
        Return dt
    End Function

    Private Overloads Function GetDataById_e(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id)
        If validate Then
            ValidateData_e(dt)
        End If
        Return dt
    End Function

    Private Overloads Function GetDataByUsuPatt_e(ByVal id_usuario As Long, ByVal id_patt As Long, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataByUsuPatt(id_usuario, id_patt)
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
End Class
