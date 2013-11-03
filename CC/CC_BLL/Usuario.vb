Imports CC_DAL.CC_DBTableAdapters

Public Class Usuario
    Implements ICheckSum
    Private _UsuarioAdapter As usuarioTableAdapter
    Private _idUsuario As Integer
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Private ReadOnly Property idUsuario() As Integer
        Get
            Return _idUsuario
        End Get
    End Property
    Public Property Adapter() As usuarioTableAdapter
        Get
            If _UsuarioAdapter Is Nothing Then
                _UsuarioAdapter = New usuarioTableAdapter()
            End If
            Return _UsuarioAdapter
        End Get
        Set(ByVal value As usuarioTableAdapter)
            _UsuarioAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("Usuario.GetData", _idUsuarioActual, "")
        Return dt
    End Function
    Public Function GetDataFiltered(ByVal ape As String) As DataTable
        Dim dt As CC_DAL.CC_DB.usuarioDataTable
        Dim row As DataRow
        ape = Encriptor.ShiftK(ape, 1)
        dt = Adapter.GetDataByApeNom(ape, ape)
        'dt.Columns.Add("clienteDisplay")
        Dim col As New DataColumn
        col.ColumnName = "usuario"
        dt.Columns.Add(col)
        For Each row In dt.Rows
            row("usuario") = Encriptor.ShiftK(row("apellido"), -1) + ", " + Encriptor.ShiftK(row("nombre"), -1)
        Next
        Log.Record("Usuario.GetDataFiltered", _idUsuarioActual, ape)

        Return dt
    End Function


    Public Function GetDataByUserName(ByVal userName As String) As DataTable
        Dim dt As DataTable = Adapter.GetDataByUsu(Encriptor.ShiftK(userName, 1))
        _idUsuario = Int32.Parse(dt(0)("id_usuario").ToString())
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("Usuario.GetDataByUserName", _idUsuarioActual, userName)
        Return dt
    End Function

    Public Function UpdatePassword(ByVal userName As String, ByVal newPassword As String) As Boolean
        Dim dt As DataTable = Adapter.GetDataByUsu(Encriptor.ShiftK(userName, 1))

        If dt.Rows.Count = 0 Then
            Return False
        End If

        Dim dr As DataRow = dt.Rows(0)
        dr("password") = Encriptor.ShiftK(newPassword, 1)
        Log.Record("Usuario.UpdatePassword", _idUsuarioActual, userName)
        Return SetCheckSum_e(dt)
    End Function

    Public Function ValidateUser(ByVal loginuser As String, ByVal loginpass As String) As Boolean
        Dim loginEncPass As String = Nothing
        Dim dbEncPass As String = Nothing
        Log.Record("Usuario.ValidateUser", _idUsuarioActual, loginuser)
        'Validation Rules 
        If loginuser.Length = 0 Then
            Throw New ApplicationException("Debe completar el nombre de usuario")
        End If
        If loginpass.Length = 0 Then
            Throw New ApplicationException("Debe completar la password")
        End If
        ' End Validation Rules
        Try
            dbEncPass = GetPassByUser(Encriptor.ShiftK(loginuser, 1))
        Catch
            Return False
        End Try
        If dbEncPass <> Nothing Then
            If dbEncPass.Length > 0 Then
                loginEncPass = Encriptor.ShiftK(loginpass, 1)
                If loginEncPass <> Nothing Then
                    Return (loginEncPass = dbEncPass)
                End If
            End If
        End If
        Return False
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
    Public Function GetDataByIdUsuario(ByVal usu As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataByIdUsuario(usu)
        _idUsuario = Int32.Parse(dt(0)("id_usuario").ToString())
        If validate Then
            ValidateData_e(dt)
            unencryptDataTable(dt)
        End If
        Log.Record("Usuario.GetDataByIdUsuario", _idUsuarioActual, usu)
        Return dt
    End Function

    Private Function GetDataByIdUsuario_e(ByVal usu As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataByIdUsuario(usu)
        If validate Then
            ValidateData_e(dt)
        End If
        Return dt
    End Function

    Public Function GetPassByUser(ByVal user As String) As String
        Dim pass As String = Nothing
        Dim dt As DataTable = Adapter.GetDataByUsu(user)
        ValidateData_e(dt)
        If dt.Rows.Count > 0 Then
            pass = dt.Rows(0)("password").ToString()
        Else
            pass = Nothing
        End If
        Return pass
    End Function
    Public Function SetCheckSum_e(ByVal dt As DataTable) As Boolean Implements ICheckSum.SetCheckSum_e
        CheckSum.Generate(dt)
        Return Adapter.Update(dt) = 1
    End Function

    Public Function SetCheckSumAll_e() As Boolean Implements ICheckSum.SetCheckSumAll_e
        Dim dt As DataTable = Adapter.GetData()
        Return SetCheckSum_e(dt)
    End Function


    Public Overloads Function Add(ByVal legajo As Long, ByVal dni As Long, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal username As String, ByVal password As String, ByVal idlang As Integer) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataByIdUsuario_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("legajo") = legajo
        dr("dni") = dni
        dr("nombre") = nombre
        dr("apellido") = apellido
        dr("direccion") = direccion
        dr("username") = username
        dr("password") = password
        dr("id_lang") = idlang
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long = 1
        Adapter.Insert(id, dr("legajo"), dr("dni"), dr("apellido"), dr("nombre"), dr("direccion"), dr("username"), dr("password"), dr("id_lang"), strval)
        Log.Record("Usuario.Add", _idUsuarioActual, id, legajo, dni, nombre, apellido, direccion, username, password, idlang)
        If Not SetCheckSum_e(Adapter.GetDataByIdUsuario(id)) Then
            id = 0
        End If
        Return id
    End Function
    Public Sub unencryptDataTable(ByRef dt As DataTable)
        For Each row As DataRow In dt.Rows
            row.Item("apellido") = Encriptor.ShiftK(row.Item("apellido"), -1)
            row.Item("nombre") = Encriptor.ShiftK(row.Item("nombre"), -1)
            row.Item("direccion") = Encriptor.ShiftK(row.Item("direccion"), -1)
            row.Item("username") = Encriptor.ShiftK(row.Item("username"), -1)
            row.Item("password") = Encriptor.ShiftK(row.Item("password"), -1)
        Next
    End Sub
    Public Sub encryptDataTable(ByRef dt As DataTable)
        For Each row As DataRow In dt.Rows
            row.Item("apellido") = Encriptor.ShiftK(row.Item("apellido"), 1)
            row.Item("nombre") = Encriptor.ShiftK(row.Item("nombre"), 1)
            row.Item("direccion") = Encriptor.ShiftK(row.Item("direccion"), 1)
            row.Item("username") = Encriptor.ShiftK(row.Item("username"), 1)
            row.Item("password") = Encriptor.ShiftK(row.Item("password"), 1)
        Next
    End Sub

    Public Function Delete(ByVal id As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataByIdUsuario_e(id, False)
        dt.Rows(0).Delete()
        Log.Record("Usuario.Delete", _idUsuarioActual, id)
        Return Adapter.Update(dt) = 1
    End Function

    Public Overloads Function Update(ByVal id As Long, ByVal legajo As Long, ByVal dni As Long, _
        ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, _
        ByVal username As String, ByVal password As String, ByVal idlang As Integer) As Boolean
        Dim dt As DataTable
        dt = GetDataByIdUsuario_e(id)
        Dim dr As DataRow = dt.Rows(0)
        dr("id_usuario") = id
        dr("legajo") = legajo
        dr("dni") = dni
        dr("nombre") = nombre
        dr("apellido") = apellido
        dr("direccion") = direccion
        dr("username") = username
        dr("password") = password
        dr("id_lang") = idlang
        encryptDataTable(dt)
        Log.Record("Usuario.Update", _idUsuarioActual, id, legajo, dni, nombre, apellido, direccion, username, idlang)
        Return SetCheckSum_e(dt)
    End Function

    'Public Overloads Function Update(ByVal dt As DataTable)
    '    encryptDataTable(dt)
    '    Return SetCheckSum_e(dt)
    'End Function

    Public Function T_UpdateWithoutCheckSum(ByVal dt As DataTable) As Boolean
        For Each row As DataRow In dt.Rows
            row("apellido") = Encriptor.ShiftK(row("apellido"), 1)
            row("nombre") = Encriptor.ShiftK(row("nombre"), 1)
            row("direccion") = Encriptor.ShiftK(row("direccion"), 1)
            row("username") = Encriptor.ShiftK(row("username"), 1)
            row("password") = Encriptor.ShiftK(row("password"), 1)
        Next
        Return Adapter.Update(dt)
    End Function

    Public Sub Close()
        Adapter = Nothing
    End Sub

End Class

