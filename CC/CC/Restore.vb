Imports System.IO
Imports CC_BLL
Public Class Restore
    Private _bck As DB
    Private Sub Backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _factory As New ConcreteDBFactory(Context.idUsuarioActual)
        _bck = _factory.GetDB()
    End Sub

    Private Sub cmdExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExecute.Click
        If File.Exists(txtSourceFile.Text) Then
            'Dim databasePath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ciber2.mdb")
            '_bck.restore(txtSourceFile.Text, databasePath)
            Try
                _bck.restoreSql(txtSourceFile.Text)
                Utilities.ShowInformationMessage("La restauración se realizó correctamente")
            Catch ex As Exception
                Utilities.ShowInformationMessage("Error realizando la restauracion: " & ex.Message)
            End Try
        Else
            Utilities.ShowExclamationMessage("El archivo a restaruar no existe")
        End If
    End Sub

    Private Sub cmdFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFolder.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Seleccionar Archivo"
        fd.InitialDirectory = "C:\"
        fd.Filter = "BAK files (*.bak)|*.bak"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            txtSourceFile.Text = fd.FileName
        End If
        
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class