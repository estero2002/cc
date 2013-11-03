Imports CC_BLL

Public Class CambioContraseña

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click

        If (Not ValidarDatos()) Then
            Return
        End If

        Dim _factory As New CC_BLL.ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As CC_BLL.Usuario = _factory.GetUsuario()
        Dim loginuser As String = Context.NickUsuarioActual
        Dim loginpass As String = txtPasswordActual.Text

        If Not _usuario.ValidateUser(loginuser, loginpass) Then
            Utilities.ShowExclamationMessage("La contraseña actual ingresada es incorrecta")
            Exit Sub
        End If

        Dim result As Boolean = _usuario.UpdatePassword(loginuser, txtPasswordNueva.Text)

        If (result) Then
            Utilities.ShowInformationMessage("La contraseña se actualizo correctamente")
            Me.Close()
        Else
            Utilities.ShowInformationMessage("No se pudo actualizar la contraseña")
        End If

    End Sub

    Private Function ValidarDatos() As Boolean
        Dim msg As String = ""
        Dim res As Boolean = True

        If txtPasswordActual.Text.Length = 0 Then
            res = False
            msg = msg + Environment.NewLine + "Debe ingresar contraseña actual."
        End If

        If txtPasswordNueva.Text.Length = 0 Then
            res = False
            msg = msg + Environment.NewLine + "Debe ingresar la nueva contraseña."
        End If

        If txtPasswordNueva2.Text.Length = 0 Then
            res = False
            msg = msg + Environment.NewLine + "Debe reescribir la nueva contraseña."
        End If

        If txtPasswordNueva.Text <> txtPasswordNueva2.Text Then
            res = False
            msg = msg + Environment.NewLine + "La nueva contraseña y su reescritura no coinciden."
        End If

        If (msg <> "") Then
            msg = "Error de validacion:" + msg
            Utilities.ShowInformationMessage(msg)
        End If

        Return res
    End Function
End Class