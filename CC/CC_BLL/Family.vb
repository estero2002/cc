Imports CC_DAL.CC_DBTableAdapters

Public Class Family
    Implements ICheckSum
    Private _FamilyAdapter As familyTableAdapter
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As FamilyTableAdapter
        Get
            If _FamilyAdapter Is Nothing Then
                _FamilyAdapter = New familyTableAdapter()
            End If
            Return _FamilyAdapter
        End Get
        Set(ByVal value As FamilyTableAdapter)
            _FamilyAdapter = value
        End Set
    End Property
    Public Function GetDataByIdUsuarioDispo(ByVal id_usuario As Long) As DataTable
        Log.Record("Family.GetDataByIdUsuarioDispo", _idUsuarioActual, id_usuario)
        Return Adapter.GetDataByIdUsuarioDispo(id_usuario)
    End Function
    Public Function GetDataByIdUsuario(ByVal id_usuario As Long) As DataTable
        Log.Record("Family.GetDataByIdUsuario", _idUsuarioActual, id_usuario)
        Return Adapter.GetDataByIdUsuario(id_usuario)
    End Function
    Public Function GetData() As DataTable
        Log.Record("Family.GetData", _idUsuarioActual, "")
        Return Adapter.GetData()
    End Function

    Public Function GetCount() As Integer
        Return Adapter.GetData().Count
    End Function


    Public Function GetFamilyByName(ByVal nom As String) As String
        Dim pass As String = Nothing
        Dim dt As DataTable = Adapter.GetDataByName(nom)
        If dt.Rows.Count > 0 Then

            pass = dt.Rows(0)("id_Family").ToString()
        Else
            pass = Nothing
        End If
        Log.Record("Family.GetFamilyByName", _idUsuarioActual, nom)
        Return pass
    End Function

    Public Overloads Function Add(ByVal nombre As String) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("nombre") = nombre
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id, dr("nombre"), strval)
        If Not SetCheckSum_e(Adapter.GetDataById(id)) Then
            id = 0
        End If
        Log.Record("Family.Add", _idUsuarioActual, nombre)
        Return id
    End Function

    Public Overloads Function Update(ByVal id As Long, _
        ByVal nombre As String) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id)
        Dim dr As DataRow = dt.Rows(0)
        dr("id_Family") = id
        dr("nombre") = nombre
        encryptDataTable(dt)
        Log.Record("Family.Update", _idUsuarioActual, id, nombre)
        Return SetCheckSum_e(dt)
    End Function
    Public Function Delete(ByVal id As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id, False)
        dt.Rows(0).Delete()
        Log.Record("Family.Delete", _idUsuarioActual, id)
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
        Log.Record("Family.GetDataById", _idUsuarioActual, id)
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
