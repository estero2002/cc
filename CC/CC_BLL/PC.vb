Imports CC_DAL.CC_DBTableAdapters

Public Class PC
    Implements ICheckSum
    Private _PCAdapter As PCTableAdapter
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Property Adapter() As pcTableAdapter
        Get
            If _PCAdapter Is Nothing Then
                _PCAdapter = New pcTableAdapter()
            End If
            Return _PCAdapter
        End Get
        Set(ByVal value As pcTableAdapter)
            _PCAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("PC.GetData", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataConCliente() As DataTable
        Dim dt As DataTable = Adapter.GetDataConCliente()

        Dim col As New DataColumn
        col.ColumnName = "cliente"
        dt.Columns.Add(col)
        For Each row In dt.Rows
            row("nombre") = Encriptor.ShiftK(row("nombre"), -1)
            row("apellido") = Encriptor.ShiftK(row("apellido"), -1)
            row("cliente") = row("apellido") + ", " + row("nombre")
        Next

        Log.Record("PC.GetDataConCliente", _idUsuarioActual, "")
        Return dt
    End Function

    Public Overloads Function Add(ByVal id_pc As Integer, ByVal id_cliente As Long, ByVal id_usuario As Long) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("id_pc") = id_pc
        dr("id_cliente") = id_cliente
        dr("id_usuario") = id_usuario
        dr("horainicio") = Now()
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id, id_pc, 0, Now(), id_cliente, id_usuario, 1, dr("horainicio"))
        If Not SetCheckSum_e(Adapter.GetDataById(id)) Then
            id = 0
        End If
        Log.Record("PC.Add", _idUsuarioActual, id_pc, id_cliente, id_usuario)
        Return id
    End Function

    Public Overloads Function Update() As Boolean
        Dim dt As DataTable
        'dt = GetDataById_e(id)
        dt = GetData()
        Dim dr As DataRow
        For Each dr In dt.Rows
            dr("CantidadMinutos") = DateDiff(DateInterval.Minute, dr("horainicio"), Now())
        Next
        Log.Record("PC.Update", _idUsuarioActual, "")
        encryptDataTable(dt)
        Return SetCheckSum_e(dt)
    End Function
    Public Function Delete(ByVal id As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id, False)
        dt.Rows(0).Delete()
        Log.Record("PC.Delete", _idUsuarioActual, id)
        Return Adapter.Update(dt) = 1
    End Function

    Public Function DeleteBy_Id_PC(ByVal id_PC As Long) As Boolean
        Log.Record("PC.DeleteBy_Id_PC", _idUsuarioActual, id_PC)
        Return Adapter.DeleteById_PC(id_PC) = 1
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
        Log.Record("PC.GetDataById", _idUsuarioActual, id)
        Return dt
    End Function

    Public Function GetConsumptionById(ByVal idMaq As Integer) As DataTable
        Dim dt As DataTable = Adapter.GetConsumptionById(idMaq)
        Log.Record("PC.GetConsumptionById", _idUsuarioActual, idMaq)
        Return dt
    End Function

    Public Function GetConsumptionByTime(ByVal tiempoACobrar As Integer, ByVal idMaq As Integer) As DataTable
        Dim dt As DataTable = Adapter.GetConsumptionByTime(tiempoACobrar, idMaq)
        Log.Record("PC.GetConsumptionByTime", _idUsuarioActual, tiempoACobrar, idMaq)
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
