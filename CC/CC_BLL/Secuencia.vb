Imports CC_DAL.CC_DBTableAdapters

Public Class Secuencia
    Implements ICheckSum
    Private _SecuenciaAdapter As secuenciaTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Property Adapter() As secuenciaTableAdapter
        Get
            If _SecuenciaAdapter Is Nothing Then
                _SecuenciaAdapter = New secuenciaTableAdapter()
            End If
            Return _SecuenciaAdapter
        End Get
        Set(ByVal value As secuenciaTableAdapter)
            _SecuenciaAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Dim dt As DataTable = Adapter.GetData()
        ValidateData_e(dt)
        Log.Record("Secuencia.GetData", _idUsuarioActual, "")
        Return dt
    End Function

    Public Function GetDataById(ByVal id As Integer, Optional ByVal validate As Boolean = True) As DataTable
        Dim dt As DataTable = Adapter.GetDataById(id)
        If validate Then
            ValidateData_e(dt)
        End If
        Log.Record("Secuencia.GetDataById", _idUsuarioActual, id)
        Return dt
    End Function

    Public Function Update(ByVal idsecuencia As Long, ByVal secuencia As Long) As Boolean
        Dim dt As DataTable
        dt = GetDataById(idsecuencia)
        Dim dr As DataRow = dt.Rows(0)
        dr("secuencia") = secuencia
        Log.Record("Secuencia.Update", _idUsuarioActual, idsecuencia, secuencia)
        Return SetCheckSum_e(dt)
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
