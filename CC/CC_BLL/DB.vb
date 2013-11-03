Imports System.IO
Imports CC_DAL
Public Class DB
    Dim JRO As New JRO.JetEngine
    Private _idUsuarioActual As Long

    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub

    Public Function backup(ByVal SourceFile As String, ByVal TargetFile As String) As Boolean
        Dim ok As Boolean = True
        Dim tmpfile As String
        Dim dir As New DirectoryInfo(Mid(TargetFile, 1, TargetFile.LastIndexOf("\")))
        ' AppDomain.CurrentDomain.GetData("DataDirectory")
        ' Configuration.ConfigurationSettings.AppSettings.Get("DataDirectory")

        If Not dir.Exists Then
            Throw New ApplicationException("El directorio no existe")
        End If
        Try
            tmpfile = Mid(TargetFile, 1, TargetFile.LastIndexOf("\")) + "\tmbdb.mdb"
            If File.Exists(tmpfile) Then
                System.IO.File.Delete(tmpfile)
            End If
            System.IO.File.Copy(SourceFile, tmpfile)
            JRO.CompactDatabase("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=adm;Data Source=" + tmpfile, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + TargetFile)
            System.IO.File.Delete(tmpfile)
        Catch ex As Exception
            ok = False
            Throw New ApplicationException(ex.Message)
        End Try
        Return ok
    End Function

    Public Function restore(ByVal SourceFile As String, ByVal TargetFile As String) As Boolean
        Dim ok As Boolean = True
        Try
            System.IO.File.Delete(TargetFile)
            System.IO.File.Copy(SourceFile, TargetFile)
        Catch ex As Exception
            ok = False
            Throw New ApplicationException(ex.Message)
        End Try
        Return ok
    End Function

End Class

