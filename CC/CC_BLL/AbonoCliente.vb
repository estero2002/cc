Imports CC_DAL.CC_DBTableAdapters

Public Class AbonoCliente
    Implements ICheckSum

    Private _abono_clienteAdapter As abono_clienteTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As abono_clienteTableAdapter
        Get
            If _abono_clienteAdapter Is Nothing Then
                _abono_clienteAdapter = New abono_clienteTableAdapter()
            End If
            Return _abono_clienteAdapter
        End Get
        Set(ByVal value As abono_clienteTableAdapter)
            _abono_clienteAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        unencryptDataTable(dt)
        Log.Record("Abono_cliente.GetData", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataById(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id)
        If validate Then
            ValidateData_e(dt)
            unencryptDataTable(dt)
        End If
        Log.Record("Abono_cliente.GetDataById", _idUsuarioActual, id)
        Return dt
    End Function

    Public Overloads Function Add(ByVal id_cliente As Integer, ByVal tiempo_restante As Integer, ByVal tipo_producto As Integer) As Long
        Dim dt As DataTable
        Dim strval As Long = 0
        dt = GetDataById_e(0, False)
        Dim dr As DataRow = dt.NewRow()
        dr("id_cliente") = id_cliente
        dr("tiempo_restante") = tiempo_restante
        dr("tipo_producto") = tipo_producto
        dt.Rows.Add(dr)
        encryptDataTable(dt)
        Dim id As Long
        Adapter.Insert(id_cliente, tiempo_restante, tipo_producto, 1)
        id = id_cliente
        If Not SetCheckSum_e(Adapter.GetDataById(id_cliente)) Then
            id = 0
        End If
        Log.Record("Abono_cliente.Add", _idUsuarioActual, id_cliente, tiempo_restante, tipo_producto)
        Return id
    End Function

    Public Overloads Function Update(ByVal id_cliente As Integer, ByVal tiempo_restante As Integer, ByVal tipo_producto As Integer) As Long
        Dim dt As DataTable
        dt = GetDataById_e(id_cliente, False)
        Dim dr As DataRow = dt.Rows(0)
        dr("tiempo_restante") = tiempo_restante
        dr("tipo_producto") = tipo_producto
        encryptDataTable(dt)
        Log.Record("Abono_cliente.Update", _idUsuarioActual, id_cliente, tiempo_restante, tipo_producto)
        Return SetCheckSum_e(dt)
    End Function

    Public Function Delete(ByVal id As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id, False)
        dt.Rows(0).Delete()
        Log.Record("Abono_cliente.Delete", _idUsuarioActual, id)
        Return Adapter.Update(dt) = 1
    End Function

    Public Overloads Function ActualizarTiempoAbono(ByVal id_cliente As Integer, ByVal tiempo_abono As Integer) As Long
        Dim dt As DataTable
        dt = GetDataById_e(id_cliente, False)
        Dim dr As DataRow = dt.Rows(0)
        dr("tiempo_restante") = tiempo_abono
        encryptDataTable(dt)
        Log.Record("Abono_cliente.ActualizarTiempoAbono", _idUsuarioActual, id_cliente, tiempo_abono)
        Return SetCheckSum_e(dt)
    End Function

    Public Function DescontarTiempoAbono(ByVal id_cliente As Integer, ByVal tiempoACobrar As Integer) As Integer
        Dim dt As DataTable
        dt = GetDataById_e(id_cliente, False)

        If dt.Rows.Count = 0 Then
            Return tiempoACobrar
        Else
            Dim tiempoAbono As Integer = dt.Rows(0)("tiempo_restante")
            If tiempoAbono >= tiempoACobrar Then
                ActualizarTiempoAbono(id_cliente, tiempoAbono - tiempoACobrar)
                Return 0
            Else
                ActualizarTiempoAbono(id_cliente, 0)
                Return tiempoACobrar - tiempoAbono
            End If
        End If
    End Function

    Public Function TieneAbono(ByVal id_cliente As Integer) As Boolean
        Dim dt As DataTable
        dt = GetDataById_e(id_cliente, False)
        Log.Record("Abono_cliente.TieneAbono", _idUsuarioActual, id_cliente)
        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Overloads Function SumarTiempoAbono(ByVal id_cliente As Integer, ByVal tiempo_abono As Integer) As Long
        Dim dt As DataTable
        dt = GetDataById_e(id_cliente, False)
        Dim dr As DataRow = dt.Rows(0)
        dr("tiempo_restante") = dr("tiempo_restante") + tiempo_abono
        encryptDataTable(dt)
        Log.Record("Abono_cliente.SumarTiempoAbono", _idUsuarioActual, id_cliente, tiempo_abono)
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
