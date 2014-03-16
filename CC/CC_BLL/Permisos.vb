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
    Public Function GetDataByIdPatt(ByVal id_patt As Long) As DataTable
        Log.Record("Permisos.GetDataByIdPatt", _idUsuarioActual, id_patt)
        Return Adapter.GetDataByIdPatt(id_patt)
    End Function
    Public Function GetDataPermisoFamByUsuPatt(ByVal id_usuario As Long, ByVal id_patt As Long) As DataTable
        Log.Record("Permisos.GetDataPermisoFamByUsuPatt", _idUsuarioActual, id_usuario, id_patt)
        Return Adapter.GetDataPermisoFamByUsuPatt(id_usuario, id_patt)
    End Function
    Public Function ViolaPattVitales(ByVal id_usuario As Long) As Boolean
        Log.Record("Permisos.ViolaPattVitales", _idUsuarioActual, id_usuario)
        Dim dtIndividual As DataTable = Adapter.GetDataUsuPattVitalesIndividual(id_usuario)
        If (dtIndividual.Rows.Count > 0) Then
            Return False
        End If

        Dim dtFamilia As DataTable = Adapter.GetDataUsuPattVitalesPorFam(id_usuario)
        If (dtFamilia.Rows.Count > 0) Then
            Return False
        End If

        Return True
    End Function
    Public Function TienePattVitalesPorFam(ByVal id_usuario As Long) As Boolean
        Log.Record("Permisos.TienePattVitalesPorFam", _idUsuarioActual, id_usuario)
        Dim dtFam As DataTable = Adapter.GetDataTienePattVitalesPorFam(id_usuario)
        If (dtFam.Rows.Count > 0) Then
            Return True
        End If
        Return False
    End Function
    Public Function TienePattVitalesIndividual(ByVal id_usuario As Long) As Boolean
        Log.Record("Permisos.TienePattVitalesIndividual", _idUsuarioActual, id_usuario)
        Dim dtUsu As DataTable = Adapter.GetDataTienePattVitalesIndividual(id_usuario)
        If (dtUsu.Rows.Count > 0) Then
            Return True
        End If
        Return False
    End Function
    Public Sub Close()
        Adapter = Nothing
    End Sub

End Class
