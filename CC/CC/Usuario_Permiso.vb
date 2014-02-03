Imports CC_BLL

Public Class Usuario_Permiso
    Dim _usuario As Usuario
    Dim idUsuario As Long

    Private Sub Usuario_Permiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _usuarioFactory As New ConcreteUsuarioFactory(Context.idUsuarioActual)

        _usuario = _usuarioFactory.GetUsuario()

        cmbUsuario.DisplayMember = "usuario"
        cmbUsuario.ValueMember = "id_usuario"
        cmbUsuario.setGetDataFunction(AddressOf _usuario.GetDataParaCombo)
        cmbUsuario.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        idUsuario = cmbUsuario.SelectedValue
        If idUsuario <> 0 Then
            lstDisponibles.Items.Clear()
            lstAsignados.Items.Clear()
            lstDenegados.Items.Clear()
            cargarPermisosDeUsuario()
        End If
    End Sub

    Private Sub cargarPermisosDeUsuario()

    End Sub
End Class
