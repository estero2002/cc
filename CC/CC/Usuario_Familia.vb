Imports CC_BLL
Public Class Usuario_Familia
    Dim _usuario As Usuario
    Dim _family As Family
    Dim _usuarioFamilias As UsuarioFamilias
    Dim idUsuario As Long

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub cargarCombos()
        Try
            Dim d As DataTable = _family.GetDataByIdUsuarioDispo(idUsuario)
            For Each r As DataRow In d.Rows
                SelectControl1.Add(r("nombre").ToString(), r("id_family").ToString())
            Next
            d = Nothing

            d = _family.GetDataByIdUsuario(idUsuario)
            For Each r As DataRow In d.Rows
                SelectControl1.AddAlreadySelected(r("nombre").ToString(), r("id_family").ToString())
            Next
            d = Nothing
        Catch ex As Exception
            Utilities.ShowErrorMessage("Error en la carga de datos: " + ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub SetSelectControlLabels()
        SelectControl1.List1Label = "Familias Disponibles"
        SelectControl1.List2Label = "Familias Asociadas"
    End Sub

    Private Sub Usuario_Familia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _factoryUsuarioFamilias As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)

        _family = _familyfactory.GetFamily()
        _usuario = _factory.GetUsuario()
        _usuarioFamilias = _factoryUsuarioFamilias.GetUsuarioFamilias()
        cmbUsuario.DisplayMember = "usuario"
        cmbUsuario.ValueMember = "id_usuario"
        cmbUsuario.setGetDataFunction(AddressOf _usuario.GetDataFiltered)
        SetSelectControlLabels()

    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SelectControl1.ClearAll()
        idUsuario = cmbUsuario.SelectedValue
        If idUsuario <> 0 Then
            cargarCombos()
        End If
    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        If ValidarDatos() Then
            _usuarioFamilias.UpdateSelected(idUsuario, SelectControl1.csvAddedItems, SelectControl1.csvRemovedItems)
            MessageBox.Show("El registro se actualizó exitosamente.")
            Me.Close()
        End If
    End Sub
    Private Function ValidarDatos() As Boolean
        Dim res As Boolean = True
        'If (Utilities.Empty(txtNombre.Text.ToString())) Then
        '    res = False
        '    Utilities.ShowExclamationMessage("Debe completar el nombre")
        'End If
        ValidarDatos = res
    End Function

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class