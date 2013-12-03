Imports CC_BLL

Public Class ActualizadorProducto
    Private _prod As Producto
    Dim _tipoproducto As Tipoproducto


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim f As New EditarProducto()
        f.ShowDialog()
        f = Nothing
        Grid.DataSource = _prod.GetData()
        Grid.Refresh()
    End Sub

    Private Sub B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim f As New EditarProducto()
        If Not Grid.CurrentRow Is Nothing Then
            f.idproducto = Int32.Parse(Grid.CurrentRow.Cells("id_producto").Value.ToString())
            f.ShowDialog()
            Grid.DataSource = _prod.GetData()
            Grid.Refresh()
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla") 'poner en ingles, agregar
        End If
    End Sub

    Private Sub ActualizadorProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BuscarProducto()
    End Sub
    Private Sub BuscarProducto()
        Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)

        _prod = _factory.GetProducto()
        Grid.Columns.Clear()
        Try

            Grid.DataSource = _prod.GetData()
            'Dar formato a la grilla
            Grid.Columns("id_producto").Visible = False
            Grid.Columns("tipo_producto").Visible = False
            Grid.Columns("strval").Visible = False 'los campos que no queremos ver los ponemos en invisible

            Grid.Columns("Descripcion").HeaderText = "Producto" 'los campos que quermos ver, agregar nombre del campo, ancho y alineacion
            Grid.Columns("Descripcion").Width = 200
            Grid.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Grid.Columns("Descripcion").ReadOnly = True

            Grid.Columns("Precio").HeaderText = "Precio"
            Grid.Columns("Precio").Width = 80
            Grid.Columns("Precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Grid.Columns("Precio").ReadOnly = True
        Catch ex As Exception
            Utilities.ShowErrorMessage(ex.Message)
        End Try
    End Sub
    Private Sub Grid_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseDoubleClick
        Dim f As New EditarProducto()

        If Not Grid.CurrentRow Is Nothing Then
            f.idproducto = Int32.Parse(Grid.CurrentRow.Cells("id_producto").Value.ToString())
            f.ShowDialog()
            Grid.DataSource = _prod.GetData()
            Grid.Refresh()
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla") 'poner en ingles, agregar label
        End If

    End Sub


    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    
    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Not Grid.CurrentRow Is Nothing Then
            If Utilities.YesNoDialog("Esta seguro que desea eliminar el registro?") = Windows.Forms.DialogResult.Yes Then
                Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)
                Dim _producto As Producto = _factory.GetProducto()
                _producto.Delete(Grid.CurrentRow.Cells("id_producto").Value.ToString())
                _producto = Nothing
                Grid.DataSource = _prod.GetData()
                Grid.Refresh()
            End If
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If
    End Sub

    Private Sub cmbProd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProd.SelectedValueChanged

    End Sub
    Private Sub cargarCombos()
        Dim prod As DataTable = _tipoproducto.GetData()
        cmbProd.DataSource = prod
        cmbProd.DisplayMember = "descripcion"
        cmbProd.ValueMember = "tipo_producto"
    End Sub
End Class