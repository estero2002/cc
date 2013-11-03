Imports CC_BLL
Imports System.Data

Public Class ClienteFicha
    Dim _cliente As Cliente
    Private _idCliente As Integer
    Dim _telefono As Telefono

    Public Property idCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property

    Private Sub EditarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
        _cliente = _factory.GetCliente()
        Dim _telefonofactory As New ConcreteTelefonoFactory(Context.idUsuarioActual)
        _telefono = _telefonofactory.GetTelefono()
        If idCliente <> 0 Then
            CargarRegistro()
        Else
            'Es un cliente nuevo
            cargarCombos()
        End If
    End Sub
    Private Sub cargarCombos()
        'Dim dtLang As DataTable = _Lang.GetData()
        'cmbIdioma.DataSource = dtLang
        'cmbIdioma.DisplayMember = "nombre"
        'cmbIdioma.ValueMember = "id_lang"

        telefonosGrid.DataSource = _telefono.GetDataByIdUsuario(idCliente, False)  'no es un error está bien q use GetDataByIdUsuario aunque le pase idCliente
        telefonosGrid.Columns("id_usuario").Visible = False
        telefonosGrid.Columns("clave").Visible = False
        telefonosGrid.Columns("id_tipo_num").Visible = False
        telefonosGrid.Columns("strval").Visible = False
        telefonosGrid.Columns("numero").Visible = True
        telefonosGrid.Columns("numero").HeaderText = lblNumero.Text
        telefonosGrid.Columns("descripcion").Visible = True
        telefonosGrid.Columns("descripcion").HeaderText = lblTipo.Text
    End Sub

    Private Sub CargarRegistro()
        Try
            cargarCombos()
            Dim dt As DataTable = _cliente.GetDataById(idCliente)
            txtApellido.Text = dt.Rows(0)("Apellido").ToString()
            txtDireccion.Text = dt.Rows(0)("Direccion").ToString()
            txtDNI.Text = dt.Rows(0)("dni").ToString()
            txtNombre.Text = dt.Rows(0)("Nombre").ToString()
            txtemail.Text = dt.Rows(0)("email").ToString()

        Catch ex As Exception
            Utilities.ShowErrorMessage("Error en la carga de datos: " + ex.Message)
            Me.Close()

        End Try
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If ValidarDatos() Then
            If idCliente = 0 Then
                Dim newIdCliente As Long = _cliente.Add(Long.Parse(txtDNI.Text.ToString()), txtNombre.Text.ToString(), txtApellido.Text.ToString(), _
                             txtDireccion.Text.ToString(), txtemail.Text.ToString())
                MessageBox.Show("El registro se agregó exitosamente. Id: " + newIdCliente.ToString())
            Else
                _cliente.Update(idCliente, Long.Parse(txtDNI.Text.ToString()), txtNombre.Text.ToString(), txtApellido.Text.ToString(), _
                            txtDireccion.Text.ToString(), txtemail.Text.ToString())
            End If
            _telefono.Update(telefonosGrid.DataSource)
            MessageBox.Show("El registro se actualizó exitosamente.")
            Me.Close()
        End If

    End Sub

    Private Function ValidarDatos() As Boolean
        Dim res As Boolean = True
        If (Utilities.Empty(txtNombre.Text.ToString())) Then
            res = False
            Utilities.ShowExclamationMessage(lblEmptyMsg.Text + " " + Label4.Text)
        End If
        If (Utilities.Empty(txtApellido.Text.ToString())) Then
            res = False
            Utilities.ShowExclamationMessage(lblEmptyMsg.Text)
        End If
        If (txtApellido.Text.ToString().Length > 50) Then
            res = False
            Utilities.ShowExclamationMessage(lblEmptyMsg.Text)
        End If

        ValidarDatos = res
    End Function
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTelefono.Click
        Dim f As TelefonoFicha
        If Not telefonosGrid.CurrentRow Is Nothing Then
            f = New TelefonoFicha
            f.Mode = "Modif"
            f.RowId = telefonosGrid.CurrentRow.Index
            f.IdUsuario = idCliente
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
        f.IdUsuario = idCliente
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
    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class