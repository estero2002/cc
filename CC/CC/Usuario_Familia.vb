Imports CC_BLL
Public Class Usuario_Familia
    Dim _usuario As Usuario
    Dim _family As Family
    Dim _usuarioFamilias As UsuarioFamilias
    Dim _usuarioPermisosNeg As UsuarioPermisosNeg
    Dim _permisos As Permisos
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
        Dim _permisosFactory As New ConcretePermisosFactory(Context.idUsuarioActual)

        _family = _familyfactory.GetFamily()
        _usuario = _factory.GetUsuario()
        _usuarioFamilias = _factoryUsuarioFamilias.GetUsuarioFamilias()
        _usuarioPermisosNeg = _factory.GetUsuarioPermisosNeg()
        _permisos = _permisosFactory.GetPermisos()

        cmbUsuario.DisplayMember = "usuario"
        cmbUsuario.ValueMember = "id_usuario"
        cmbUsuario.setGetDataFunction(AddressOf _usuario.GetDataParaCombo)
        cmbUsuario.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
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
            Dim familiesToAdd As String = SelectControl1.csvAddedItems
            If (familiesToAdd.Length > 0) Then
                Dim toAdd() As String = familiesToAdd.Split(",")
                For i As Integer = 0 To toAdd.Length - 1
                    If (_usuarioPermisosNeg.EsFamiliaNegada(Long.Parse(toAdd(i)), idUsuario)) Then
                        Dim dtFamilia As DataTable = _family.GetDataById(Long.Parse(toAdd(i)), False)
                        Utilities.ShowExclamationMessage("No se puede asignar la familia " + dtFamilia.Rows(0)("nombre").ToString() + ". Uno de sus permisos esta denegado para este usuario.")
                        Return
                    End If
                Next
            End If

            Dim familiesToRemove As String = SelectControl1.csvRemovedItems
            If (familiesToRemove.Length > 0) Then
                Dim toRemove() As String = familiesToRemove.Split(",")
                For i As Integer = 0 To toRemove.Length - 1
                    Dim _factoryp As New ConcretePermisosFactory(Context.idUsuarioActual)
                    Dim _permisos As Permisos = _factoryp.GetPermisos()
                    If (_permisos.ViolaPattVitales(idUsuario)) Then
                        If Not _permisos.TienePattVitalesIndividual(idUsuario) Then
                            Dim dtFamilia As DataTable = _family.GetDataById(Long.Parse(toRemove(i)), False)
                            Utilities.ShowExclamationMessage("No se puede remover la familia " + dtFamilia.Rows(0)("nombre").ToString() + ". Ningun otro usuario posee las patentes vitales.")
                            Return
                        End If
                    End If
                Next
            End If

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