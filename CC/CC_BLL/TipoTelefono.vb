Imports CC_DAL.CC_DBTableAdapters
Public Class TipoTelefono
    Private _TipoTelefonoAdapter As tipo_telefonoTableAdapter
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Property Adapter() As tipo_telefonoTableAdapter
        Get

            If _TipoTelefonoAdapter Is Nothing Then
                _TipoTelefonoAdapter = New tipo_telefonoTableAdapter()
            End If
            Return _TipoTelefonoAdapter
        End Get
        Set(ByVal value As tipo_telefonoTableAdapter)
            _TipoTelefonoAdapter = value
        End Set
    End Property
    Public Function GetData() As DataTable
        Log.Record("TipoTelefono.GetData", _idUsuarioActual, "")
        Return Adapter.GetData()
    End Function
End Class
