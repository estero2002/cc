Imports CC_BLL

Public Class caja
    Private mvar_cliente As Integer
    Private mvar_queryasignaProditem As Integer
    Private mvar_queryasignaTProditem As Integer
    Private mvar_queryasignaCantitem As Integer
    Private mvar_queryasignaPrecioitem As Double
    Private mvar_queryasignastrProdItem As String

    Private id_caja As Integer

    Const TYPE_BTN_TI = 1
    Const TYPE_BTN_I = 2
    Const TYPE_BTN_D = 3
    Const TYPE_BTN_TD = 4

    Public GstrPK As String
    Public strOpcion As String

    Private _CajaTable As CajaTable
    Private _CajaDetalle As CajaDetalle
    Private _Cliente As Cliente
    Private _TipoProducto As TipoProducto
    Private _Producto As Producto
    Private _Secuencia As Secuencia

    Public compraActual As Compra = Nothing

    Public Property Cliente() As Integer
        Get
            Return mvar_cliente
        End Get
        Set(ByVal value As Integer)
            mvar_cliente = value
        End Set
    End Property

    Public Property QueryAsignaProd() As Integer
        Get
            Return mvar_queryasignaProditem
        End Get
        Set(ByVal value As Integer)
            mvar_queryasignaProditem = value
        End Set
    End Property

    Public Property QueryAsignaTProd() As Integer
        Get
            Return mvar_queryasignaTProditem
        End Get
        Set(ByVal value As Integer)
            mvar_queryasignaTProditem = value
        End Set
    End Property

    Public Property QueryAsignaCant() As Integer
        Get
            Return mvar_queryasignaCantitem
        End Get
        Set(ByVal value As Integer)
            mvar_queryasignaCantitem = value
        End Set
    End Property

    Public Property QueryAsignaPrecio() As Double
        Get
            Return mvar_queryasignaPrecioitem
        End Get
        Set(ByVal value As Double)
            mvar_queryasignaPrecioitem = value
        End Set
    End Property

    Public Property QueryAsignastrProd() As String
        Get
            Return mvar_queryasignastrProdItem
        End Get
        Set(ByVal value As String)
            mvar_queryasignastrProdItem = value
        End Set
    End Property

    Private Sub caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _CajaTableFactory As New ConcreteCajaTableFactory(Context.idUsuarioActual)
        _CajaTable = _CajaTableFactory.GetCajaTable()
        Dim _CajaDetalleFactory As New ConcreteCajaDetalleFactory(Context.idUsuarioActual)
        _CajaDetalle = _CajaDetalleFactory.GetCajaDetalle()
        Dim _ClienteFactory As New ConcreteClienteFactory(Context.idUsuarioActual)
        _Cliente = _ClienteFactory.GetCliente()
        Dim _ProductoFactory As New ConcreteProductoFactory(Context.idUsuarioActual)
        _Producto = _ProductoFactory.GetProducto()
        _TipoProducto = _ProductoFactory.GetTipoProducto()
        Dim _SecuenciaFactory As New ConcreteSecuenciaFactory(Context.idUsuarioActual)
        _Secuencia = _SecuenciaFactory.GetSecuencia()

        'Dim query As String
        'CentrarFormulario(Me, 10095, 6780)
        GstrPK = ""
        'Grilla.Clear()
        'CambiarLenguaje(Me, idiusu)
        'iPkInterna = 0
        Operacion(Me.strOpcion)
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        If Not compraActual Is Nothing Then
            Dim result As DialogResult = Utilities.YesNoDialog(lblMsjSalida.Text)
            If result = DialogResult.Yes Then
                compraActual = Nothing
                Me.Close()
            Else
                Return
            End If
        End If
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If (Asc(e.KeyChar) <> Utilities.BACKSPACE) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Operacion(ByVal strOpcion As String)

        Select Case strOpcion
            Case "A"
                Cursor = Cursors.WaitCursor

                HabilitarNavegador(False)
                groupBoxSelProd.Enabled = True
                btnNuevo.Enabled = False
                btnFinalizarCompra.Enabled = True
                btnAgregar.Enabled = True
                btnLimpiarGrilla.Enabled = True
                btnGenerarReportes.Enabled = False
                Grilla.Enabled = False
                LimpiarForm()

                Dim dtSecuencia As DataTable = _Secuencia.GetDataById(3)
                Dim nuevoTicket As Long = dtSecuencia.Rows(0)("secuencia") + 1
                compraActual = New Compra(nuevoTicket, Date.Now)

                lblTicket.Text = compraActual.IdCompra
                lblFecha.Text = compraActual.Fecha.ToString("d")

                Dim dtClientes As DataTable = _Cliente.GetDataFiltered("")
                cmbCliente.DataSource = dtClientes
                cmbCliente.DisplayMember = "cliente"
                cmbCliente.ValueMember = "id_cliente"

                compraActual.IdCliente = cmbCliente.SelectedValue

                Dim tipoProdDt As DataTable = _TipoProducto.GetDataForCajaForm()
                cmbTipoProducto.Items.Clear()
                cmbTipoProducto.DataSource = tipoProdDt
                cmbTipoProducto.DisplayMember = "descripcion"
                cmbTipoProducto.ValueMember = "tipo_producto"

                If (tipoProdDt.Rows.Count > 0) Then
                    Dim tipoProducto As Long = cmbTipoProducto.SelectedValue
                    cmbProducto.DataSource = Nothing
                    cmbProducto.Items.Clear()
                    cmbProducto.DataSource = _Producto.GetDataByTipoProducto(tipoProducto)
                    cmbProducto.DisplayMember = "descripcion"
                    cmbProducto.ValueMember = "id_producto"
                End If

                Cursor = Cursors.Default

            Case "B"

            Case "S"
                Cursor = Cursors.WaitCursor

                HabilitarNavegador(False)
                groupBoxSelProd.Enabled = True
                btnNuevo.Enabled = False
                btnFinalizarCompra.Enabled = True
                btnAgregar.Enabled = True
                btnLimpiarGrilla.Enabled = True
                btnGenerarReportes.Enabled = False
                Grilla.Enabled = False
                LimpiarForm()

                Dim dtSecuencia As DataTable = _Secuencia.GetDataById(3)
                Dim nuevoTicket As Long = dtSecuencia.Rows(0)("secuencia") + 1
                compraActual = New Compra(nuevoTicket, Date.Now)

                lblTicket.Text = compraActual.IdCompra
                lblFecha.Text = compraActual.Fecha.ToString("d")

                Dim dtClientes As DataTable = _Cliente.GetDataByIdConApeNom(Me.Cliente)
                cmbCliente.DataSource = dtClientes
                cmbCliente.DisplayMember = "cliente"
                cmbCliente.ValueMember = "id_cliente"

                compraActual.IdCliente = Me.Cliente

                Dim tipoProdDt As DataTable = _TipoProducto.GetDataForCajaForm()
                cmbTipoProducto.Items.Clear()
                cmbTipoProducto.DataSource = tipoProdDt
                cmbTipoProducto.DisplayMember = "descripcion"
                cmbTipoProducto.ValueMember = "tipo_producto"

                If (tipoProdDt.Rows.Count > 0) Then
                    Dim tipoProducto As Long = cmbTipoProducto.SelectedValue
                    cmbProducto.DataSource = Nothing
                    cmbProducto.Items.Clear()
                    cmbProducto.DataSource = _Producto.GetDataByTipoProducto(tipoProducto)
                    cmbProducto.DisplayMember = "descripcion"
                    cmbProducto.ValueMember = "id_producto"
                End If

                Dim itemCompra As ItemCompra = New ItemCompra(Me.QueryAsignaProd, Me.QueryAsignaTProd, Me.QueryAsignaCant, Me.QueryAsignaPrecio)
                itemCompra.DescripProducto = Me.QueryAsignastrProd

                compraActual.Items.Add(itemCompra)
                ActualizarGrilla()
                ActualizarTotal()

                Cursor = Cursors.Default

            Case Else
                HabilitarNavegador(True)
                groupBoxSelProd.Enabled = False
                btnAgregar.Enabled = False
                btnNuevo.Enabled = False
                btnFinalizarCompra.Enabled = False
                btnLimpiarGrilla.Enabled = False
                Grilla.Enabled = False

                If GstrPK = "" Then
                    Navegar(TYPE_BTN_TD, GstrPK)
                Else
                    PrepararNavegador(CInt(GstrPK))

                    If Not CargarForm(CLng(GstrPK)) Then
                        GstrPK = ""
                    End If
                End If

                btnNuevo.Enabled = True

                If GstrPK = "" Then
                    LimpiarForm()
                End If
        End Select

    End Sub

    Private Sub HabilitarNavegador(ByVal habilitar As Boolean)
        btnTopIzq.Enabled = habilitar
        btnIzq.Enabled = habilitar
        btnDer.Enabled = habilitar
        btnTopDer.Enabled = habilitar
    End Sub

    Private Sub LimpiarForm()
        'strpk = ""
        lblTicket.Text = ""
        lblTotal.Text = ""
        txtCantidad.Text = ""
        lblFecha.Text = ""
        Grilla.DataSource = Nothing
        Grilla.Refresh()
    End Sub

    Private Function Navegar(ByVal iBtn As Integer, Optional ByVal strpk As String = "") As String
        Dim iPk As Long
        Dim dt As DataTable = New DataTable()

        Cursor = Cursors.WaitCursor

        Select Case iBtn
            Case TYPE_BTN_TI
                dt = _CajaTable.GetFirstTwo()
            Case TYPE_BTN_I
                dt = _CajaTable.GetPreviousTwoFromId(CInt(strpk))
            Case TYPE_BTN_D
                dt = _CajaTable.GetNextTwoFromId(CInt(strpk))
            Case TYPE_BTN_TD
                dt = _CajaTable.GetLastTwo()
        End Select

        If dt.Rows.Count = 0 Then
            HabilitarNavegador(False)
        Else
            iPk = dt.Rows(0)("id_caja")
            If dt.Rows.Count = 1 Then
                Select Case iBtn
                    Case TYPE_BTN_TI, TYPE_BTN_TD
                        HabilitarNavegador(False)
                    Case TYPE_BTN_I
                        btnTopIzq.Enabled = False
                        btnIzq.Enabled = False
                        btnDer.Enabled = True
                        btnTopDer.Enabled = True
                        btnDer.Focus()
                    Case TYPE_BTN_D
                        btnTopIzq.Enabled = True
                        btnIzq.Enabled = True
                        btnDer.Enabled = False
                        btnTopDer.Enabled = False
                        btnIzq.Focus()
                End Select
            Else
                Select Case iBtn
                    Case TYPE_BTN_TI
                        btnTopIzq.Enabled = False
                        btnIzq.Enabled = False
                        btnDer.Enabled = True
                        btnTopDer.Enabled = True
                    Case TYPE_BTN_I
                        btnDer.Enabled = True
                        btnTopDer.Enabled = True
                    Case TYPE_BTN_D
                        btnTopIzq.Enabled = True
                        btnIzq.Enabled = True
                    Case TYPE_BTN_TD
                        btnTopIzq.Enabled = True
                        btnIzq.Enabled = True
                        btnDer.Enabled = False
                        btnTopDer.Enabled = False
                End Select
            End If

            If Not CargarForm(iPk) Then
                LimpiarForm()
            End If
            GstrPK = iPk
        End If

        Cursor = Cursors.Default
        Return CStr(iPk)
    End Function

    Private Sub PrepararNavegador(ByVal cajaId As Integer)
        Dim dt As DataTable

        Cursor = Cursors.WaitCursor

        dt = _CajaTable.GetPreviousTwoFromId(cajaId)

        btnTopIzq.Enabled = (dt.Rows.Count > 0)
        btnIzq.Enabled = (dt.Rows.Count > 0)

        dt = Nothing
        dt = _CajaTable.GetNextTwoFromId(cajaId)

        btnTopDer.Enabled = (dt.Rows.Count > 0)
        btnDer.Enabled = (dt.Rows.Count > 0)

        Cursor = Cursors.Default
    End Sub

    Private Function CargarForm(ByVal idCaja As Long) As Boolean
        Dim idcliente As Integer

        Dim dt As DataTable = _CajaTable.GetDataById(idCaja)

        If (dt.Rows.Count = 0) Then
            Return False
        End If

        idcliente = dt.Rows(0)("id_cliente")
        lblTicket.Text = idCaja
        Dim fecha As Date = dt.Rows(0)("fecha")
        lblFecha.Text = fecha.Date

        If dt.Rows(0)("monto_compra") IsNot Nothing Then
            lblTotal.Text = dt.Rows(0)("monto_compra")
        End If

        If (idcliente <> 0) Then
            cmbCliente.DataSource = _Cliente.GetDataByIdConApeNom(idcliente)
            cmbCliente.DisplayMember = "cliente"
            cmbCliente.ValueMember = "id_cliente"
        End If

        Grilla.DataSource = _CajaDetalle.GetDataByCajaId(idCaja)
        Grilla.Columns("id_detalle").Visible = False
        Grilla.Columns("id_caja").Visible = False
        Grilla.Columns("tipo_producto").Visible = False
        Grilla.Columns("strval").Visible = False

        Grilla.Columns("id_producto").DisplayIndex = 0
        Grilla.Columns("id_producto").HeaderText = "ID"
        Grilla.Columns("Descripcion").DisplayIndex = 1
        Grilla.Columns("cantidad").DisplayIndex = 2
        Grilla.Columns("cantidad").HeaderText = lblColCantidad.Text
        Grilla.Columns("importe").DisplayIndex = 3
        Grilla.Columns("importe").HeaderText = lblColImporte.Text
        Return True
    End Function

    Private Sub btnTopDer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopDer.Click
        Navegar(TYPE_BTN_TD, GstrPK)
    End Sub

    Private Sub btnDer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDer.Click
        Navegar(TYPE_BTN_D, GstrPK)
    End Sub

    Private Sub btnIzq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzq.Click
        Navegar(TYPE_BTN_I, GstrPK)
    End Sub

    Private Sub btnTopIzq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopIzq.Click
        Navegar(TYPE_BTN_TI, GstrPK)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        strOpcion = "A"
        Operacion(strOpcion)
    End Sub

    Private Sub cmbTipoProducto_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoProducto.SelectionChangeCommitted
        Dim tipoProducto As Long = cmbTipoProducto.SelectedValue
        cmbProducto.DataSource = Nothing
        cmbProducto.Items.Clear()
        cmbProducto.DataSource = _Producto.GetDataByTipoProducto(tipoProducto)
        cmbProducto.DisplayMember = "descripcion"
        cmbProducto.ValueMember = "id_producto"
    End Sub

    Private Sub cmbCliente_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectionChangeCommitted
        If Not compraActual Is Nothing Then
            compraActual.IdCliente = cmbCliente.SelectedValue
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Not ValidarNuevoItem() Then
            Return
        End If

        Dim productoRow As DataRowView = cmbProducto.SelectedItem
        Dim tipoProductoRow As DataRowView = cmbTipoProducto.SelectedItem

        Dim idProducto As Long = productoRow.Item("id_producto")
        Dim descripProducto As String = productoRow.Item("descripcion")
        Dim idTipoProducto As Long = tipoProductoRow.Item("tipo_producto")
        Dim descripTipoProducto As String = tipoProductoRow.Item("descripcion")
        Dim importe As Double = productoRow.Item("precio")
        Dim cantidad As Integer = txtCantidad.Text

        Dim itemCompra As ItemCompra = New ItemCompra(idProducto, idTipoProducto, cantidad, importe)
        itemCompra.DescripProducto = descripProducto
        itemCompra.DescripTipoProducto = descripTipoProducto

        If (compraActual.Items.Contains(itemCompra, New ItemCompraComparer())) Then
            Utilities.ShowInformationMessage(lblMsjItemDup.Text)
            Return
        End If

        compraActual.Items.Add(itemCompra)

        ActualizarGrilla()
        ActualizarTotal()
    End Sub

    Private Function ValidarNuevoItem() As Boolean
        Dim msg As String = ""
        Dim result As Boolean = True

        If (Trim(txtCantidad.Text) = "") Then
            msg = msg + lblMsjCant.Text
            result = False
        End If

        If (cmbTipoProducto.SelectedIndex = -1) Then
            msg = msg + lblMsjSelTipoProd.Text
            result = False
        End If

        If (cmbProducto.SelectedIndex = -1) Then
            msg = msg + lblMsjProd.Text
            result = False
        End If

        If (msg <> "") Then
            Utilities.ShowInformationMessage(msg)
        End If

        Return result

    End Function

    Private Sub ActualizarGrilla()

        If compraActual Is Nothing Or compraActual.Items.Count = 0 Then
            Grilla.DataSource = Nothing
        End If

        Dim itemsBindingSource As New BindingSource
        itemsBindingSource.DataSource = compraActual.Items
        Grilla.DataSource = itemsBindingSource

        Grilla.Columns("TipoProducto").Visible = False
        Grilla.Columns("DescripTipoProducto").Visible = False

        Grilla.Columns("IdProducto").DisplayIndex = 0
        Grilla.Columns("IdProducto").HeaderText = "ID"
        Grilla.Columns("DescripProducto").DisplayIndex = 1
        Grilla.Columns("DescripProducto").HeaderText = lblColDescrip.Text
        Grilla.Columns("Cantidad").DisplayIndex = 2
        Grilla.Columns("Importe").DisplayIndex = 3
    End Sub

    Private Sub ActualizarTotal()
        If compraActual Is Nothing Then
            Return
        End If

        Dim total As Double = 0

        For Each item As ItemCompra In compraActual.Items
            total = total + (item.Cantidad * item.Importe)
        Next

        lblTotal.Text = total
    End Sub

    Private Sub btnLimpiarGrilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarGrilla.Click
        If compraActual Is Nothing Or compraActual.Items.Count = 0 Then
            Return
        End If

        Dim result As DialogResult = Utilities.YesNoDialog(lblMsjLimpiarGrilla.Text)

        If (result = DialogResult.Yes) Then
            compraActual.Items.Clear()
            ActualizarGrilla()
            ActualizarTotal()
        End If

    End Sub

    Private Sub btnFinalizarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizarCompra.Click
        If compraActual Is Nothing Then
            Return
        End If

        If Not ValidarCompra() Then
            Return
        End If

        compraActual.TotalCompra = 0
        For Each item As ItemCompra In compraActual.Items
            compraActual.TotalCompra += (item.Cantidad * item.Importe)
        Next

        'TODO: Control de errores
        _CajaTable.Add(compraActual.IdCompra, compraActual.TotalCompra, compraActual.Fecha, compraActual.IdCliente)

        For Each item As ItemCompra In compraActual.Items
            _CajaDetalle.Add(compraActual.IdCompra, item.IdProducto, item.TipoProducto, item.Cantidad, item.Importe)
        Next

        _Secuencia.Update(3, compraActual.IdCompra)

        compraActual = Nothing
        Me.Close()

    End Sub

    Private Function ValidarCompra() As Boolean
        Dim msg As String = ""
        Dim result As Boolean = True

        If (cmbCliente.SelectedIndex = -1) Then
            msg = msg + lblMsjCliente.Text
            result = False
        End If

        If (compraActual.Items.Count = 0) Then
            msg = msg + lblMsjItems.Text
            result = False
        End If

        If (msg <> "") Then
            Utilities.ShowInformationMessage(msg)
        End If

        Return result
    End Function
End Class