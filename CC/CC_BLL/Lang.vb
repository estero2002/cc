Imports CC_DAL.CC_DBTableAdapters

Public Class Lang
    Private _LanguageAdapter As langTableAdapter
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Property Adapter() As langTableAdapter
        Get
            If _LanguageAdapter Is Nothing Then
                _LanguageAdapter = New langTableAdapter()
            End If
            Return _LanguageAdapter
        End Get
        Set(ByVal value As langTableAdapter)
            _LanguageAdapter = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Return Adapter.GetData()
    End Function

    Public Function GetLangCodeByIdLang(ByVal idLang As Integer) As String
        Dim pass As String = Nothing
        Dim dt As DataTable = Adapter.GetDataByIdLang(idLang)
        If dt.Rows.Count > 0 Then
            pass = dt.Rows(0)("lang_code").ToString()
        Else
            pass = Nothing
        End If
        Log.Record("Lang.GetLangCodeByIdLang", _idUsuarioActual, idLang)
        Return pass
    End Function
    Public Sub Close()
        Adapter = Nothing
    End Sub

End Class
