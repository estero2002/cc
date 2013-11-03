Imports CC_BLL
Imports System.Data

Public Class UsuarioFicha
    Dim _usuario As Usuario
    Dim _Lang As Lang
    Dim _telefono As Telefono
    Dim _usuarioFamilias As UsuarioFamilias

    Private _idUsuario As Integer
    Public Property idUsuario() As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If ValidarDatos() Then
            If idUsuario = 0 Then
                txtPassword.Text = RandomPassword.Generate()
                Dim newIdUsuario As Long = _usuario.Add(Long.Parse(txtLegajo.Text.ToString()), Long.Parse(txtDNI.Text.ToString()), txtNombre.Text.ToString(), txtApellido.Text.ToString(), _
                             txtDireccion.Text.ToString(), txtUsuario.Text.ToString(), txtPassword.Text.ToString(), Int32.Parse(cmbIdioma.SelectedValue.ToString()))
                SetNewIdUsuario(newIdUsuario)
                Utilities.ShowInformationMessage(Utilities.SendEmail(txtEmail.Text, txtUsuario.Text, txtPassword.Text))
                Dim famId = _usuarioFamilias.Add(newIdUsuario, 2)
                If famId = 0 Then
                    Utilities.ShowExclamationMessage("No se pudo agregar el usuario a la familia 'Usuario'. Agreguelo manualmente.")
                Else
                    Utilities.ShowInformationMessage("Se ha agregado el nuevo usuario a la familia 'Usuario'.")
                End If
            Else
                _usuario.Update(idUsuario, Long.Parse(txtLegajo.Text.ToString()), Long.Parse(txtDNI.Text.ToString()), txtNombre.Text.ToString(), txtApellido.Text.ToString(), _
                             txtDireccion.Text.ToString(), txtUsuario.Text.ToString(), txtPassword.Text.ToString(), Int32.Parse(cmbIdioma.SelectedValue.ToString()))
            End If
            _telefono.Update(telefonosGrid.DataSource)
            Utilities.ShowInformationMessage("El registro se actualizó exitosamente.")
            Me.Close()
        End If
    End Sub
    Private Sub SetNewIdUsuario(ByVal id As Long)
        Dim i As Integer = 0
        Dim dt As DataTable = telefonosGrid.DataSource
        For i = 0 To dt.Rows.Count - 1
            dt(i)("id_usuario") = id
        Next
    End Sub
    Private Function ValidarDatos() As Boolean
        Dim msg As String = ""
        Dim res As Boolean = True

        If (Utilities.Empty(txtLegajo.Text.ToString())) Then
            res = False
            msg = msg + Environment.NewLine + "Debe completar el legajo."
        End If
        If (Utilities.Empty(txtDNI.Text.ToString())) Then
            res = False
            msg = msg + Environment.NewLine + "Debe completar el DNI."
        End If
        If (Utilities.Empty(txtApellido.Text.ToString())) Then
            res = False
            msg = msg + Environment.NewLine + "Debe completar el apellido."
        End If
        If (Utilities.Empty(txtNombre.Text.ToString())) Then
            res = False
            msg = msg + Environment.NewLine + lblMsjValidNombre.Text
        End If
        If (Utilities.Empty(txtDireccion.Text.ToString())) Then
            res = False
            msg = msg + Environment.NewLine + "Debe completar la direccion."
        End If
        If (Utilities.Empty(txtEmail.Text.ToString())) Then
            res = False
            msg = msg + Environment.NewLine + "Debe completar el e-mail."
        End If
        If (Not Utilities.IsEmail(txtEmail.Text.ToString())) Then
            res = False
            msg = msg + Environment.NewLine + "Debe ingresar un e-mail valido."
        End If
        If (Utilities.Empty(txtUsuario.Text.ToString())) Then
            res = False
            msg = msg + Environment.NewLine + "Debe completar el usuario."
        End If

        If (msg <> "") Then
            msg = "Error de validacion:" + msg
            Utilities.ShowInformationMessage(msg)
        End If

        Return res
    End Function

    Private Sub NuevoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _telefonofactory As New ConcreteTelefonoFactory(Context.idUsuarioActual)
        Dim _Langfactory As New ConcreteLangFactory(Context.idUsuarioActual)
        Dim _factoryUsuarioFamilias As New ConcreteUsuarioFactory(Context.idUsuarioActual)

        _usuario = _factory.GetUsuario()
        _telefono = _telefonofactory.GetTelefono()
        _Lang = _Langfactory.GetLang()
        _usuarioFamilias = _factoryUsuarioFamilias.GetUsuarioFamilias()

        If idUsuario <> 0 Then
            'Carga usuario seleccionado
            CargarRegistro()
            lblMsjEnvioPassword.Visible = False
            txtEmail.Visible = False
            lblEmail.Visible = False
        Else
            'Es un usuario nuevo
            cargarCombos()
            lblMsjEnvioPassword.Visible = True
            txtEmail.Visible = True
            lblEmail.Visible = True
        End If
    End Sub
    Private Sub cargarCombos()
        Dim dtLang As DataTable = _Lang.GetData()
        cmbIdioma.DataSource = dtLang
        cmbIdioma.DisplayMember = "nombre"
        cmbIdioma.ValueMember = "id_lang"

        telefonosGrid.DataSource = _telefono.GetDataByIdUsuario(idUsuario, False)
        telefonosGrid.Columns("id_usuario").Visible = False
        telefonosGrid.Columns("clave").Visible = False
        telefonosGrid.Columns("id_tipo_num").Visible = False
        telefonosGrid.Columns("strval").Visible = False
        telefonosGrid.Columns("numero").Visible = True
        telefonosGrid.Columns("numero").HeaderText = "Número"
        telefonosGrid.Columns("descripcion").Visible = True
        telefonosGrid.Columns("descripcion").HeaderText = "Tipo"
    End Sub

    Private Sub CargarRegistro()
        Try
            'Carga del registro para posterior edición de usuario
            cargarCombos()
            Dim dt As DataTable = _usuario.GetDataByIdUsuario(idUsuario)
            txtApellido.Text = dt.Rows(0)("Apellido").ToString()
            txtDireccion.Text = dt.Rows(0)("Direccion").ToString()
            txtDNI.Text = dt.Rows(0)("dni").ToString()
            txtLegajo.Text = dt.Rows(0)("legajo").ToString()
            txtNombre.Text = dt.Rows(0)("Nombre").ToString()
            txtPassword.Text = dt.Rows(0)("password").ToString()
            txtUsuario.Text = dt.Rows(0)("username").ToString()
            cmbIdioma.SelectedValue = dt.Rows(0)("id_lang").ToString()
        Catch ex As Exception
            Utilities.ShowErrorMessage("Error en la carga de datos: " + ex.Message)
            Me.Close()

        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If (Asc(e.KeyChar) <> Utilities.BACKSPACE) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLegajo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLegajo.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If (Asc(e.KeyChar) <> Utilities.BACKSPACE) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTelefono.Click
        Dim f As TelefonoFicha
        If Not telefonosGrid.CurrentRow Is Nothing Then
            f = New TelefonoFicha
            f.Mode = "Modif"
            f.RowId = telefonosGrid.CurrentRow.Index
            f.IdUsuario = idUsuario
            f.DataTable = telefonosGrid.DataSource
            f.ShowDialog()
            telefonosGrid.DataSource = f.DataTable
            telefonosGrid.Refresh()
            f = Nothing
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If
    End Sub

    Private Sub btnNewTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTelefono.Click
        Dim f As TelefonoFicha
        f = New TelefonoFicha
        f.Mode = "Alta"
        f.IdUsuario = idUsuario
        f.DataTable = telefonosGrid.DataSource
        f.ShowDialog()
        telefonosGrid.DataSource = f.DataTable
        f = Nothing
    End Sub

    Private Sub btnDeleteTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteTelefono.Click
        If Not telefonosGrid.CurrentRow Is Nothing Then
            If Utilities.YesNoDialog("Esta seguro que desea eliminar el registro?") = Windows.Forms.DialogResult.Yes Then
                '_telefono.Delete(telefonosGrid.CurrentRow.Cells("clave").Value.ToString())
                Dim _dt As DataTable = telefonosGrid.DataSource
                _dt.Rows(Utilities.SearchRecord(_dt, "clave", telefonosGrid.CurrentRow.Cells("clave").Value.ToString())).Delete()
                _dt = Nothing
            End If
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If

    End Sub
End Class