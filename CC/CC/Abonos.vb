Imports CC_BLL

Public Class Abonos
    Private _AbonoCliente As AbonoCliente
    Private _Cliente As Cliente

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnasignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnasignar.Click
        If cmbCliente.SelectedValue > 0 Then
            Dim cliente As Integer = cmbCliente.SelectedValue
            Dim tiempoAgregado As Integer = txtTiempo.Text
            If _AbonoCliente.TieneAbono(cliente) Then
                _AbonoCliente.SumarTiempoAbono(cliente, tiempoAgregado)
            Else
                _AbonoCliente.Add(cliente, tiempoAgregado, 6)
            End If

            Dim _factory As New ConcreteTarifaFactory(Context.idUsuarioActual)
            Dim _tarifa As Tarifa = _factory.GetTarifa()
            Dim dt As DataTable = _tarifa.GetDataById(1, False)

            If dt.Rows.Count > 0 Then
                Dim monto As Integer = tiempoAgregado * dt.Rows(0)("importe")

                caja.Cliente = cliente
                caja.QueryAsignaProd = 750
                caja.QueryAsignaTProd = 6
                caja.QueryAsignastrProd = "Carga Abono"
                caja.QueryAsignaCant = 1
                caja.QueryAsignaPrecio = monto
                caja.strOpcion = "S"
                caja.Show()
            End If

            CargarGrillaAbonos()
        Else
            Utilities.ShowInformationMessage("Seleccione un cliente")
        End If
    End Sub

    Private Sub Abonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        _AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()
        Dim _ClienteFactory As New ConcreteClienteFactory(Context.idUsuarioActual)
        _Cliente = _ClienteFactory.GetCliente()

        CargarGrillaAbonos()
        CargarComboClientes()
    End Sub

    Private Sub txtTiempo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If (Asc(e.KeyChar) <> Utilities.BACKSPACE) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CargarGrillaAbonos()
        DataGridView1.DataSource = _Cliente.GetDataConAbono()

        For Each column In DataGridView1.Columns
            column.Visible = False
        Next

        DataGridView1.Columns("cliente").Visible = True
        DataGridView1.Columns("cliente").DisplayIndex = 0
        DataGridView1.Columns("cliente").HeaderText = "Cliente"
        DataGridView1.Columns("tiempo_restante").Visible = True
        DataGridView1.Columns("tiempo_restante").DisplayIndex = 1
        DataGridView1.Columns("tiempo_restante").HeaderText = "Tiempo Abono"
    End Sub

    Private Sub CargarComboClientes()
        cmbCliente.DisplayMember = "cliente"
        cmbCliente.ValueMember = "id_cliente"
        cmbCliente.setGetDataFunction(AddressOf _Cliente.GetDataFiltered)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Not DataGridView1.CurrentRow Is Nothing Then
            If Utilities.YesNoDialog("Esta seguro que desea eliminar el abono?") = Windows.Forms.DialogResult.Yes Then
                Dim idcliente As Long = DataGridView1.CurrentRow.Cells("id_cliente").Value.ToString()
                Dim tiempo As Integer = DataGridView1.CurrentRow.Cells("tiempo_restante").Value.ToString()

                If tiempo = 0 Then
                    _AbonoCliente.Delete(idcliente)
                    Utilities.ShowInformationMessage("El abono se eliminó exitosamente")
                    CargarGrillaAbonos()
                Else
                    Utilities.ShowExclamationMessage("Solo puede eliminar abonos con tiempo 0")
                End If
            End If
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If
    End Sub
End Class