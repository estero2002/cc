Imports CC_BLL
Public Class Login

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim _factory As New CC_BLL.ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As CC_BLL.Usuario = _factory.GetUsuario()
        Dim _Langfactory As New ConcreteLangFactory(Context.idUsuarioActual)
        Dim _lang As Lang = _Langfactory.GetLang()
        Dim loginuser As String
        Dim loginpass As String
        Dim dt As DataTable
        'Validaciones preliminares
        If txtNombre.Text.ToString().Length = 0 Then
            Utilities.ShowExclamationMessage("Debe completar el usuario")
            Exit Sub
        End If
        loginuser = txtNombre.Text

        If txtClave.Text.ToString().Length = 0 Then
            Utilities.ShowExclamationMessage("Debe completar la password")
            Exit Sub
        End If
        loginpass = txtClave.Text
        'End Validaciones preliminares

        If _usuario.ValidateUser(loginuser, loginpass) Then
            dt = _usuario.GetDataByUserName(loginuser)
            Context.idUsuarioActual = Int32.Parse(dt(0)("id_usuario").ToString())
            Context.NickUsuarioActual = loginuser
            Context.idioma = _lang.GetLangCodeByIdLang(dt(0)("id_lang").ToString())
            _usuario.Close()
            _lang.Close()
            MDI_CC.Show()
            Me.Hide()
        Else
            Utilities.ShowExclamationMessage("Usuario o contraseña incorrectos")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Application.Exit()
    End Sub
End Class