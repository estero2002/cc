Imports CC_DAL.CC_DBTableAdapters

Public Class Cliente
    Implements ICheckSum
    Private _ClienteAdapter As clienteTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As clienteTableAdapter
        Get
            If _ClienteAdapter Is Nothing Then
                _ClienteAdapter = New clienteTableAdapter()
            End If
            Return _ClienteAdapter
        End Get
        Set(ByVal value As clienteTableAdapter)
            _ClienteAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("Cliente.GetData", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataFiltered(ByVal ape As String) As DataTable
        Dim dt As CC_DAL.CC_DB.clienteDataTable
        Dim row As DataRow
        ape = Encriptor.ShiftK(ape, 1)
        dt = Adapter.GetDataByApeNom(ape, ape)
        'dt.Columns.Add("clienteDisplay")
        Dim col As New DataColumn
        col.ColumnName = "cliente"
        dt.Columns.Add(col)
        For Each row In dt.Rows
            row("cliente") = Encriptor.ShiftK(row("apellido"), -1) + ", " + Encriptor.ShiftK(row("nombre"), -1)
        Next
        Log.Record("Cliente.GetDataFiltered", _idUsuarioActual, ape)
        Return dt
    End Function

    Public Function GetDataParaCombo() As DataTable
        Dim dt As CC_DAL.CC_DB.clienteDataTable
        Dim row As DataRow
        dt = Adapter.GetData()

        Dim col As New DataColumn
        col.ColumnName = "cliente"
        dt.Columns.Add(col)
        For Each row In dt.Rows
            row("cliente") = Encriptor.ShiftK(row("apellido"), -1) + ", " + Encriptor.ShiftK(row("nombre"), -1)
        Next

        Log.Record("Cliente.GetDataParaCombo", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataConAbono() As DataTable
        Dim dt As DataTable = Adapter.GetDataConAbono()
        'ValidateData_e(dt)
        'unencryptDataTable(dt)
        Dim col As New DataColumn
        col.ColumnName = "cliente"
        dt.Columns.Add(col)
        For Each row In dt.Rows
            row("cliente") = Encriptor.ShiftK(row("apellido"), -1) + ", " + Encriptor.ShiftK(row("nombre"), -1)
        Next
        Log.Record("Cliente.GetDataConAbono", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataByIdConApeNom(ByVal id As Long)
        Dim dt As DataTable = GetDataById_e(id, True)
        unencryptDataTable(dt)
        Dim col As New DataColumn
        col.ColumnName = "cliente"
        dt.Columns.Add(col)
        For Each row In dt.Rows
            row("cliente") = row("apellido") + ", " + row("nombre")
        Next
        Log.Record("Cliente.GetDataByIdConApeNom", _idUsuarioActual, id)
        Return dt
    End Function

    Public Overloads Function Add(ByVal dni As Long, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal email As String) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("dni") = dni
        dr("nombre") = nombre
        dr("apellido") = apellido
        dr("direccion") = direccion
        dr("email") = email
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id, dr("dni"), dr("apellido"), dr("nombre"), dr("direccion"), dr("email"), strval)
        If Not SetCheckSum_e(Adapter.GetDataById(id)) Then
            id = 0
        End If
        Log.Record("Cliente.Add", _idUsuarioActual, dni, nombre, apellido, direccion, email)
        Return id
    End Function

    Public Overloads Function Update(ByVal id As Long, ByVal dni As Long, _
        ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, _
        ByVal email As String) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id)
        Dim dr As DataRow = dt.Rows(0)
        'dr("id_cliente") = id
        dr("dni") = dni
        dr("nombre") = nombre
        dr("apellido") = apellido
        dr("direccion") = direccion
        dr("email") = email
        encryptDataTable(dt)
        Log.Record("Cliente.Update", _idUsuarioActual, id, dni, nombre, apellido, direccion, email)
        Return SetCheckSum_e(dt)
    End Function
    Public Function Delete(ByVal id As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id, False)
        dt.Rows(0).Delete()
        Log.Record("Cliente.Add", _idUsuarioActual, id)
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
        For Each row As DataRow In dt.Rows
            row.Item("apellido") = Encriptor.ShiftK(row.Item("apellido"), -1)
            row.Item("nombre") = Encriptor.ShiftK(row.Item("nombre"), -1)
            row.Item("direccion") = Encriptor.ShiftK(row.Item("direccion"), -1)
            row.Item("email") = Encriptor.ShiftK(row.Item("email"), -1)
        Next
    End Sub
    Private Sub encryptDataTable(ByRef dt As DataTable)
        For Each row As DataRow In dt.Rows
            row.Item("apellido") = Encriptor.ShiftK(row.Item("apellido"), 1)
            row.Item("nombre") = Encriptor.ShiftK(row.Item("nombre"), 1)
            row.Item("direccion") = Encriptor.ShiftK(row.Item("direccion"), 1)
            row.Item("email") = Encriptor.ShiftK(row.Item("email"), 1)
        Next
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
        Log.Record("Cliente.GetDataById", _idUsuarioActual, id)
        Return dt
    End Function

    Public Function T_UpdateWithoutCheckSum(ByVal dt As DataTable) As Boolean
        For Each row As DataRow In dt.Rows
            row("apellido") = Encriptor.ShiftK(row("apellido"), 1)
            row("nombre") = Encriptor.ShiftK(row("nombre"), 1)
            row("direccion") = Encriptor.ShiftK(row("direccion"), 1)
            row("email") = Encriptor.ShiftK(row("email"), 1)
        Next
        Return Adapter.Update(dt)
    End Function

End Class
