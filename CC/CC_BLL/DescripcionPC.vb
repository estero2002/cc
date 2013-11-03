Imports CC_DAL.CC_DBTableAdapters

Public Class DescripcionPC
    Implements ICheckSum

    Private _descripcion_pcAdapter As descripcion_pcTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As descripcion_pcTableAdapter
        Get
            If _descripcion_pcAdapter Is Nothing Then
                _descripcion_pcAdapter = New descripcion_pcTableAdapter()
            End If
            Return _descripcion_pcAdapter
        End Get
        Set(ByVal value As descripcion_pcTableAdapter)
            _descripcion_pcAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("Descripcion_pc.GetData", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataById(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id)
        If validate Then
            ValidateData_e(dt)
            unencryptDataTable(dt)
        End If
        Log.Record("Descripcion_pc.GetDataById", _idUsuarioActual, id)
        Return dt
    End Function

    Public Overloads Function Add(ByVal id_pc As Integer, ByVal pc_nombre As String, ByVal pc_activa As Integer) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("id_pc") = id_pc
        dr("pc_nombre") = pc_nombre
        dr("pc_activa") = pc_activa
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id_pc, pc_nombre, pc_activa, 1)
        id = id_pc
        If Not SetCheckSum_e(Adapter.GetDataById(id_pc)) Then
            id = 0
        End If
        Log.Record("Descripcion_pc.Add", _idUsuarioActual, id_pc, pc_nombre, pc_activa)
        Return id
    End Function

    Public Overloads Function Update(ByVal id_pc As Integer, ByVal pc_nombre As String, ByVal pc_activa As Integer) As Long
        Dim dt As DataTable
        dt = GetDataById_e(id_pc, False)
        Dim dr As DataRow = dt.Rows(0)
        dr("pc_nombre") = pc_nombre
        dr("pc_activa") = pc_activa
        encryptDataTable(dt)
        Log.Record("Descripcion_pc.Update", _idUsuarioActual, id_pc, pc_nombre, pc_activa)
        Return SetCheckSum_e(dt)
    End Function

    Public Function Delete(ByVal id As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id, False)
        dt.Rows(0).Delete()
        Log.Record("Descripcion_pc.Delete", _idUsuarioActual, id)
        Return Adapter.Update(dt) = 1
    End Function

    Public Function CambiarEstado(ByVal id_pc As Integer, ByVal estado As Integer) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id_pc, False)
        Dim dr As DataRow = dt.Rows(0)
        dr("pc_activa") = estado
        encryptDataTable(dt)
        Log.Record("Descripcion_pc.CambiarEstado", _idUsuarioActual, id_pc, estado)
        Return SetCheckSum_e(dt)
    End Function

    Public Function Status(ByVal id_pc As Integer) As Integer
        Dim dt As DataTable
        dt = GetDataById_e(id_pc, False)
        If dt.Rows(0)("pc_activa") = 0 Then
            Return 0 'En Uso
        End If
        If dt.Rows(0)("pc_activa") = 1 Then
            Return 1 'Habilitada
        End If
        If dt.Rows(0)("pc_activa") = 2 Then
            Return 2 'Error
        End If

        Log.Record("Descripcion_pc.Status", _idUsuarioActual, id_pc)
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

    Private Function GetDataById_e(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id)
        If validate Then
            ValidateData_e(dt)
        End If
        Return dt
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

End Class
