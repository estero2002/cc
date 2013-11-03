Imports CC_BLL

Public Class FrmCliente

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BuscarCliente()
    End Sub

    Private Sub BuscarCliente()
        Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
        Dim _cli As Cliente = _factory.GetCliente()
        Grid.Columns.Clear()
        Try
            Grid.DataSource = _cli.GetData()
            'Dar formato a la grilla
            Grid.Columns("id_cliente").Visible = False
            Grid.Columns("dni").Visible = False
            Grid.Columns("direccion").Visible = False
            Grid.Columns("strval").Visible = False 'los campos que no queremos ver los ponemos en invisible
            Grid.Columns("email").HeaderText = lblEmail.Text 'los campos que quermos ver, agregar nombre del campo, ancho y alineacion
            Grid.Columns("email").Width = 120
            Grid.Columns("email").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Grid.Columns("email").ReadOnly = True
            Grid.Columns("apellido").HeaderText = lblApellido.Text
            Grid.Columns("apellido").Width = 190
            Grid.Columns("apellido").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Grid.Columns("apellido").ReadOnly = True
            Grid.Columns("nombre").HeaderText = lblNombre.Text
            Grid.Columns("nombre").Width = 190
            Grid.Columns("nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Grid.Columns("nombre").ReadOnly = True
        Catch ex As Exception
            Utilities.ShowErrorMessage(ex.Message)
        End Try
    End Sub


    Private Sub Grid_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseDoubleClick
        Dim f As New ClienteFicha()

        If Not Grid.CurrentRow Is Nothing Then
            f.idCliente = Int32.Parse(Grid.CurrentRow.Cells("id_cliente").Value.ToString())
            f.ShowDialog()
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla") 'poner en ingles, agregar label
        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        ClienteFicha.Show()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim f As New ClienteFicha()
        If Not Grid.CurrentRow Is Nothing Then
            f.idCliente = Int32.Parse(Grid.CurrentRow.Cells("id_cliente").Value.ToString())
            f.ShowDialog()
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla") 'poner en ingles, agregar
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Not Grid.CurrentRow Is Nothing Then
            If Utilities.YesNoDialog("Esta seguro que desea eliminar el registro?") = Windows.Forms.DialogResult.Yes Then
                Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
                Dim _cliente As Cliente = _factory.GetCliente()
                _cliente.Delete(Grid.CurrentRow.Cells("id_cliente").Value.ToString())
                _cliente = Nothing
            End If
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla") 'poner en ingles, agregar
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        BuscarCliente()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click

    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class