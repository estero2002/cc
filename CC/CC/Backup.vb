Imports System.IO
Imports CC_BLL
Public Class Backup
    Private _bck As DB
    Private Sub Backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _factory As New ConcreteDBFactory(Context.idUsuarioActual)
        _bck = _factory.GetDB()
    End Sub

    Private Sub cmdExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExecute.Click
        Dim bfc() As Char = Path.GetInvalidFileNameChars()
        Dim filename As String
        Dim databasePath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ciber2.mdb")

        If Not Directory.Exists(txtTargetFile.Text) And txtTargetFile.Text.Length > 0 Then
            If Directory.Exists(Mid(txtTargetFile.Text, 1, txtTargetFile.Text.LastIndexOf("\"))) Then
                filename = txtTargetFile.Text.Substring(txtTargetFile.Text.LastIndexOf("\") + 1)
                If filename.IndexOfAny(bfc) = -1 Then
                    '_bck.backup(databasePath, txtTargetFile.Text)
                    Try
                        _bck.backupSql(txtTargetFile.Text)
                        Utilities.ShowInformationMessage("El backup se realizó correctamente")
                    Catch ex As Exception
                        Utilities.ShowInformationMessage("Error realizando el backup: " & ex.Message)
                    End Try

                Else
                    Utilities.ShowExclamationMessage("El nombre del archivo contiene caracteres incorrectos")
                End If
            Else
                Utilities.ShowExclamationMessage("El directorio ingresado no existe")
            End If
        Else
            Utilities.ShowExclamationMessage("Debe ingresar un nombre de archivo")
        End If
    End Sub

    Private Sub cmdFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFolder.Click
        Dim result As DialogResult
        result = Me.FolderBrowserDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtTargetFile.Text = FolderBrowserDialog1.SelectedPath + "\CCback-" + Date.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak"
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class