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
    Public Function GetDataByIdUsuarioDispo(ByVal id_usuario As Long) As DataTable
        Log.Record("Permisos.GetDataByIdUsuarioDispo", _idUsuarioActual, id_usuario)
        Return Adapter.GetDataByIdUsuarioDispo(id_usuario)
    End Function
    Public Function GetDataByIdUsuario(ByVal id_usuario As Long) As DataTable
        Log.Record("Permisos.GetDataByIdUsuario", _idUsuarioActual, id_usuario)
        Return Adapter.GetDataByIdUsuario(id_usuario)
    End Function
    Public Function GetDataByIdUsuarioNeg(ByVal id_usuario As Long) As DataTable
        Log.Record("Permisos.GetDataByIdUsuarioNeg", _idUsuarioActual, id_usuario)
        Return Adapter.GetDataByIdUsuarioNeg(id_usuario)
    End Function
    Public Function GetDataByIdUsuarioDispoNeg(ByVal id_usuario As Long) As DataTable
        Log.Record("Permisos.GetDataByIdUsuarioDispoNeg", _idUsuarioActual, id_usuario)
        Return Adapter.GetDataByIdUsuarioDispoNeg(id_usuario)
    End Function
    Public Function GetPermisosByUsuario(ByVal id_usuario As Long) As DataTable
        Log.Record("Permisos.GetPermisosByUsuario", _idUsuarioActual, id_usuario)
        Return Adapter.GetPermisosByUsuario(id_usuario, id_usuario)
    End Function
    Public Sub Close()
        Adapter = Nothing
    End Sub

End Class
