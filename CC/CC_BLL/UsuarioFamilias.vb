Imports CC_DAL.CC_DBTableAdapters
Public Class UsuarioFamilias
    Implements ICheckSum
    Private _PermisosAdapter As usuario_famTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As usuario_famTableAdapter
        Get
            If _PermisosAdapter Is Nothing Then
                _PermisosAdapter = New usuario_famTableAdapter()
            End If
            Return _PermisosAdapter
        End Get
        Set(ByVal value As usuario_famTableAdapter)
            _PermisosAdapter = value
        End Set
    End Property
    

    Public Function GetData() As DataTable
        Log.Record("UsuarioFamilias.GetData", _idUsuarioActual, "")
        Return Adapter.GetData()
    End Function
    Public Function UpdateSelected(ByVal id_usu As Long, ByVal FamiliesToAdd As String, ByVal FamiliesToRemove As String) As Long
        Dim spliter(0) As String
        Dim res As Long
        If (FamiliesToAdd.Length > 0) Then
            Dim toAdd() As String = FamiliesToAdd.Split(",")
            For i As Integer = 0 To toAdd.Length - 1
                res = Me.Add(id_usu, Int32.Parse(toAdd(i)))
            Next
        End If

        If (FamiliesToRemove.Length > 0) Then
            Dim toRemove() As String = FamiliesToRemove.Split(",")
            For i As Integer = 0 To toRemove.Length - 1
                res = Me.Delete(id_usu, Int32.Parse(toRemove(i)))
            Next
        End If
        Log.Record("UsuarioFamilias.UpdateSelected", _idUsuarioActual, id_usu, FamiliesToAdd, FamiliesToRemove)
        Return res
    End Function

    Public Function Add(ByVal id_usuario As Long, ByVal id_family As Long) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("id_family") = id_family
        dr("id_usuario") = id_usuario
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id, dr("id_family"), dr("id_usuario"), strval)
        If Not SetCheckSum_e(Adapter.GetDataById(id)) Then
            id = 0
        End If
        Log.Record("UsuarioFamilias.Add", _idUsuarioActual, id_usuario, id_family)
        Return id
    End Function
    Public Overloads Function Delete(ByVal id As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id, False)
        dt.Rows(0).Delete()
        Log.Record("UsuarioFamilias.Delete", _idUsuarioActual, id)
        Return Adapter.Update(dt) = 1
    End Function
    Public Overloads Function Delete(ByVal id_usu As Long, ByVal id_family As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataByUsuFam_e(id_usu, id_family, False)
        dt.Rows(0).Delete()
        Log.Record("UsuarioFamilias.Delete", _idUsuarioActual, id_usu, id_family)
        Return Adapter.Update(dt) = 1
    End Function
    Private Function GetDataByUsuFam_e(ByVal id_usu As Long, ByVal id_family As Long, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataByUsuFam(id_usu, id_family)
        If validate Then
            ValidateData_e(dt)
        End If
        Return dt
    End Function


    Private Overloads Function GetDataById_e(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
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
        Log.Record("UsuarioFamilias.GetDataById", _idUsuarioActual, id)
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
