Imports CC_DAL.CC_DBTableAdapters
Public Class Permisos
    Private _PermisosAdapter As PermisosTableAdapter
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Property Adapter() As PermisosTableAdapter
        Get
            If _PermisosAdapter Is Nothing Then
                _PermisosAdapter = New PermisosTableAdapter()
            End If
            Return _PermisosAdapter
        End Get
        Set(ByVal value As PermisosTableAdapter)
            _PermisosAdapter = value
        End Set
    End Property
    Public Function GetDataByUsuario(ByVal id_usuario As Long) As DataTable
        Log.Record("Permisos.GetDataByUsuario", _idUsuarioActual, id_usuario)
        Return Adapter.GetDataByUsuario(id_usuario)
    End Function
    Public Function GetDataByIdFamiliaDispo(ByVal id_familia As Long) As DataTable
        Log.Record("Permisos.GetDataByIdFamiliaDispo", _idUsuarioActual, id_familia)
        Return Adapter.GetDataByIdFamiliaDispo(id_familia)
    End Function
    Public Function GetDataByIdFamilia(ByVal id_familia As Long) As DataTable
        Log.Record("Permisos.GetDataByIdFamilia", _idUsuarioActual, id_familia)
        Return Adapter.GetDataByIdFamilia(id_familia)
    End Function
    Public Sub Close()
        Adapter = Nothing
    End Sub

End Class
