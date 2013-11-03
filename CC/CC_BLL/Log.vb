Imports CC_DAL.CC_DBTableAdapters

Public Class Log
    Implements ICheckSum
    Private _LogAdapter As logTableAdapter
    Private Shared _instance As Log

    Private Sub New()

    End Sub

    Public Shared Function getInstance()
        If _instance Is Nothing Then
            _instance = New Log
        End If
        Return _instance
    End Function

    Public Shared Sub Record(ByVal action As String, ByVal idUsuarioActual As Long, ByVal ParamArray p() As String)
        Dim _log As Log = Log.getInstance()
        Dim _max As Integer
        Dim cadena As String = Join(p, "|")
        If cadena.Length > 255 Then
            _max = 255
        Else
            _max = cadena.Length
        End If
        cadena = cadena.Substring(0, _max)
        _log.Add(Date.Now, action, cadena, idUsuarioActual)
    End Sub

    Public Property Adapter() As logTableAdapter
        Get
            If _LogAdapter Is Nothing Then
                _LogAdapter = New logTableAdapter()
            End If
            Return _LogAdapter
        End Get
        Set(ByVal value As logTableAdapter)
            _LogAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Return dt
    End Function

    Public Overloads Function Add(ByVal insertDate As Date, ByVal action As String, ByVal parameters As String, ByVal id_usuario As Long) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("date") = insertDate
        dr("action") = action
        dr("id_usuario") = id_usuario
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id, dr("date"), dr("action"), dr("id_usuario"), strval, parameters)
        If Not SetCheckSum_e(Adapter.GetDataById(id)) Then
            id = 0
        End If
        Return id
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
        Return dt
    End Function

    Public Function GetDataByUsuario(ByVal idUsuario As Long, ByVal fechaDesde As Date, ByVal fechaHasta As Date, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataByUsuarioFecha(idUsuario, fechaDesde, fechaHasta)
        If validate Then
            'ValidateData_e(dt)
            unencryptDataTable(dt)
        End If
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
