Imports CC_BLL
Public Class TelefonoFicha
    Private _dt As DataTable
    Private _Mode As String
    Private _RowId As Long
    Private _IdUsuario As Long
    Private _TipoTelefono As TipoTelefono

    Public Property DataTable()
        Get
            Return _dt
        End Get
        Set(ByVal value)
            _dt = value
        End Set
    End Property
    Public Property RowId()
        Get
            Return _RowId
        End Get
        Set(ByVal value)
            _RowId = value
        End Set
    End Property
    Public Property IdUsuario()
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value)
            _IdUsuario = value
        End Set
    End Property

    Public Property Mode()
        Get
            Return _Mode
        End Get
        Set(ByVal value)
            _Mode = value
        End Set
    End Property

    Private Sub TelefonoFicha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _telefonofactory As New ConcreteTelefonoFactory(Context.idUsuarioActual)
        _TipoTelefono = _telefonofactory.GetTipoTelefono()
        cargarCombos()
        If _Mode = "Alta" Then
            txtNumero.Text = ""
        Else
            txtNumero.Text = _dt(_RowId)("numero").ToString()
            cmbTipoTelefono.SelectedValue = _dt(_RowId)("id_tipo_num").ToString()
        End If

    End Sub
    Private Sub cargarCombos()
        Dim dtTipoTelefono As DataTable = _TipoTelefono.GetData()
        cmbTipoTelefono.DataSource = dtTipoTelefono
        cmbTipoTelefono.DisplayMember = "descripcion"
        cmbTipoTelefono.ValueMember = "id_tipo_num"

    End Sub
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If _Mode = "Alta" Then
            Dim r As DataRow = _dt.NewRow()
            r("id_usuario") = _IdUsuario
            r("descripcion") = cmbTipoTelefono.Text
            r("id_tipo_num") = cmbTipoTelefono.SelectedValue
            r("numero") = txtNumero.Text
            _dt.Rows.Add(r)
        Else
            _dt(_RowId)("id_tipo_num") = cmbTipoTelefono.SelectedValue
            _dt(_RowId)("descripcion") = cmbTipoTelefono.Text
            _dt(_RowId)("numero") = txtNumero.Text
        End If
        Me.Close()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class