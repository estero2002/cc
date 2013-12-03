Imports CC_BLL

Public Class AsignadorPC
    Private _PC As PC
    Private _DescripcionPC As DescripcionPC
    Private _AbonoCliente As AbonoCliente
    Private computers As Dictionary(Of String, PictureBox) = New Dictionary(Of String, PictureBox)
    Private selectedPC As String

    Private Sub AsignadorPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _PCfactory As New ConcretePCFactory(Context.idUsuarioActual)
        Dim _DescripcionPCFactory As New ConcreteDescripcionPCFactory(Context.idUsuarioActual)
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        _PC = _PCfactory.GetPC()
        _DescripcionPC = _DescripcionPCFactory.GetDescripcionPC()
        _AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()

        computers.Add(PC0.Name, PC0)
        computers.Add(PC1.Name, PC1)
        computers.Add(PC2.Name, PC2)
        computers.Add(PC3.Name, PC3)
        UpdatePcIcons()
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Utilities.ShowExclamationMessage(LblMsgSalida.Text)
        Me.Close()
    End Sub

    Private Sub HabilitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabilitarToolStripMenuItem.Click
        Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)

        Dim status As Integer = _DescripcionPC.Status(GetIdFromName(cms.SourceControl.Name))
        If Not status = 1 Then
            Utilities.ShowInformationMessage(lblMsgHabilitada.Text)
        Else
            selectedPC = cms.SourceControl.Name

            Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
            Dim _c As Cliente = _factory.GetCliente()
            cmbCliente.DisplayMember = "cliente"
            cmbCliente.ValueMember = "id_cliente"
            cmbCliente.setGetDataFunction(AddressOf _c.GetDataParaCombo)

            EnableControlsForAssignation(True)
        End If

    End Sub

    Private Sub FinalizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalizarToolStripMenuItem.Click
        Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
        Dim id_pc = GetIdFromName(cms.SourceControl.Name)

        Dim status As Integer = _DescripcionPC.Status(id_pc)
        If Not status = 0 Then
            Utilities.ShowInformationMessage("La PC no se encuentra en uso")
        Else
            Dim dtCons As DataTable = _PC.GetConsumptionById(id_pc)

            If (dtCons.Rows.Count > 0) Then
                Dim tiempoACobrar As Integer = dtCons.Rows(0)("Tiempo")
                Dim cliente As Integer = dtCons.Rows(0)("cliente")

                'Descuento el tiempo de abono, si hubiera, y obtengo el monto final
                Dim tiempoACobrarFinal As Integer = _AbonoCliente.DescontarTiempoAbono(cliente, tiempoACobrar)
                Dim dtFinalCons As DataTable = _PC.GetConsumptionByTime(tiempoACobrarFinal, id_pc)

                computers(cms.SourceControl.Name).Image = CC.My.Resources.Resources.cyoffline
                _PC.DeleteBy_Id_PC(id_pc)
                _DescripcionPC.CambiarEstado(id_pc, 1)

                If (tiempoACobrarFinal > 0) Then
                    caja.Cliente = cliente
                    caja.QueryAsignaProd = 749
                    caja.QueryAsignaTProd = 5
                    caja.QueryAsignastrProd = "Consumo Internet"
                    caja.QueryAsignaCant = 1
                    caja.QueryAsignaPrecio = dtFinalCons.Rows(0)("Monto")
                    caja.strOpcion = "S"
                    caja.Show()
                Else
                    Utilities.ShowInformationMessage("No hay tiempo a cobrar")
                End If

            Else
                Utilities.ShowInformationMessage("La PC no se encuentra en uso")
            End If
        End If
    End Sub

    Private Sub FueraDeUsoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FueraDeUsoToolStripMenuItem.Click
        Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
        Dim id_pc = GetIdFromName(cms.SourceControl.Name)

        Dim status As Integer = _DescripcionPC.Status(id_pc)
        If Not status = 1 Then
            Utilities.ShowInformationMessage("La PC se encuentra en uso o deshabilitada")
        Else
            computers(cms.SourceControl.Name).Image = CC.My.Resources.Resources.CYERROR
            _PC.DeleteBy_Id_PC(id_pc)
            _DescripcionPC.CambiarEstado(id_pc, 2)
        End If
    End Sub

    Private Sub RehabilitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RehabilitarToolStripMenuItem.Click
        Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
        Dim id_pc = GetIdFromName(cms.SourceControl.Name)

        Dim status As Integer = _DescripcionPC.Status(id_pc)
        If Not status = 2 Then
            Utilities.ShowInformationMessage("La PC ya se encuentra habilitada")
        Else
            computers(cms.SourceControl.Name).Image = CC.My.Resources.Resources.cyoffline
            _PC.DeleteBy_Id_PC(id_pc)
            _DescripcionPC.CambiarEstado(id_pc, 1)
        End If
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _PC.Update()
        DataGridView1.DataSource = _PC.GetDataConCliente()

        DataGridView1.Columns("Id").Visible = False
        DataGridView1.Columns("id_pc").HeaderText = "PC"
        DataGridView1.Columns("id_pc").DisplayIndex = 0
        DataGridView1.Columns("CantidadMinutos").HeaderText = "Minutos"
        DataGridView1.Columns("CantidadMinutos").DisplayIndex = 1
        DataGridView1.Columns("fecha").HeaderText = "Fecha"
        DataGridView1.Columns("fecha").DisplayIndex = 2
        DataGridView1.Columns("id_cliente").Visible = False
        'DataGridView1.Columns("id_tarifa").Visible = False
        DataGridView1.Columns("horaInicio").HeaderText = "Inicio"
        DataGridView1.Columns("horaInicio").DisplayIndex = 4
        DataGridView1.Columns("id_usuario").Visible = False
        DataGridView1.Columns("strval").Visible = False
        DataGridView1.Columns("nombre").Visible = False
        DataGridView1.Columns("apellido").Visible = False
        DataGridView1.Columns("cliente").HeaderText = "Cliente"
        DataGridView1.Columns("cliente").DisplayIndex = 3
    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        If cmbCliente.SelectedValue = 0 Then
            Utilities.ShowInformationMessage("Debe seleccionar un cliente")
        Else
            Dim id_pc = GetIdFromName(selectedPC)
            computers(selectedPC).Image = CC.My.Resources.Resources.CYONLINE
            _PC.Add(id_pc, cmbCliente.SelectedValue, Context.idUsuarioActual)
            _DescripcionPC.CambiarEstado(id_pc, 0)

            Utilities.ShowInformationMessage("La asignacion ha sido completada")
            selectedPC = ""
            EnableControlsForAssignation(False)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        selectedPC = ""
        EnableControlsForAssignation(False)
    End Sub

    Private Function GetIdFromName(ByVal pcName As String) As Integer
        Select Case pcName
            Case "PC0"
                Return 0
            Case "PC1"
                Return 1
            Case "PC2"
                Return 2
            Case "PC3"
                Return 3
        End Select
    End Function

    Private Sub EnableControlsForAssignation(ByVal enable As Boolean)
        If enable Then
            GroupBox2.Visible = True
            GroupBox1.Enabled = False
            btnsalir.Enabled = False
        Else
            GroupBox2.Visible = False
            GroupBox1.Enabled = True
            btnsalir.Enabled = True
        End If
    End Sub

    Private Sub UpdatePcIcons()
        For Each pc As String In computers.Keys
            Dim id_pc As Integer = GetIdFromName(pc)
            Dim status As Integer = _DescripcionPC.Status(id_pc)
            Select Case status
                Case 0
                    computers(pc).Image = CC.My.Resources.Resources.CYONLINE
                Case 1
                    computers(pc).Image = CC.My.Resources.Resources.cyoffline
                Case 2
                    computers(pc).Image = CC.My.Resources.Resources.CYERROR
            End Select
        Next
    End Sub
End Class