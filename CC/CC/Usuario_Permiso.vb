Imports CC_BLL

Public Class Usuario_Permiso
    Dim _usuario As Usuario
    Dim _Permisos As Permisos
    Dim _usuarioPermisos As UsuarioPermisos
    Dim idUsuario As Long

    Dim asignadosAgregados As New ArrayList()
    Dim asignadosRemovidos As New ArrayList()
    Dim denegadosAgregados As New ArrayList()
    Dim denegadosRemovidos As New ArrayList()

    Private Sub Usuario_Permiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _usuarioFactory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _permisosfactory As New ConcretePermisosFactory(Context.idUsuarioActual)

        _usuario = _usuarioFactory.GetUsuario()
        _Permisos = _permisosfactory.GetPermisos()
        _usuarioPermisos = _usuarioFactory.GetUsuarioPermisos()

        cmbUsuario.DisplayMember = "usuario"
        cmbUsuario.ValueMember = "id_usuario"
        cmbUsuario.setGetDataFunction(AddressOf _usuario.GetDataParaCombo)
        cmbUsuario.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        idUsuario = cmbUsuario.SelectedValue
        If idUsuario <> 0 Then
            lstDisponibles.Items.Clear()
            lstAsignados.Items.Clear()
            lstDenegados.Items.Clear()
            cargarPermisosDeUsuario()
        End If
    End Sub

    Private Sub cargarPermisosDeUsuario()
        Try
            Dim d As DataTable = _Permisos.GetDataByIdUsuarioDispo(idUsuario)
            For Each r As DataRow In d.Rows
                lstDisponibles.Items.Add(New cItem(r("descripcion").ToString(), r("id_patt").ToString()))
            Next
            d = Nothing

            d = _Permisos.GetDataByIdUsuario(idUsuario)
            For Each r As DataRow In d.Rows
                lstAsignados.Items.Add(New cItem(r("descripcion").ToString(), r("id_patt").ToString()))
            Next
            d = Nothing

            d = _Permisos.GetDataByIdUsuarioNeg(idUsuario)
            For Each r As DataRow In d.Rows
                lstDenegados.Items.Add(New cItem(r("descripcion").ToString(), r("id_patt").ToString()))
            Next
            d = Nothing
        Catch ex As Exception
            Utilities.ShowErrorMessage("Error en la carga de datos: " + ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub btnAsignarDisponible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarDisponible.Click
        Dim a As ArrayList = New ArrayList()
        For Each item As Object In lstDisponibles.SelectedItems
            a.Add(item)
        Next
        For Each item As Object In a
            lstDisponibles.Items.Remove(item)
            lstAsignados.Items.Add(item)

            If (asignadosRemovidos.Contains(item)) Then
                asignadosRemovidos.Remove(item)
            Else
                asignadosAgregados.Add(item)
            End If
        Next
    End Sub

    Private Sub btnDenegarDisponible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDenegarDisponible.Click
        Dim a As ArrayList = New ArrayList()
        For Each item As Object In lstDisponibles.SelectedItems
            a.Add(item)
        Next
        For Each item As Object In a
            lstDisponibles.Items.Remove(item)
            lstDenegados.Items.Add(item)

            If (denegadosRemovidos.Contains(item)) Then
                denegadosRemovidos.Remove(item)
            Else
                denegadosAgregados.Add(item)
            End If
        Next
    End Sub

    Private Sub btnQuitarAsignado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarAsignado.Click
        Dim a As ArrayList = New ArrayList()
        For Each item As Object In lstAsignados.SelectedItems
            a.Add(item)
        Next
        For Each item As Object In a
            lstAsignados.Items.Remove(item)
            lstDisponibles.Items.Add(item)

            If (asignadosAgregados.Contains(item)) Then
                asignadosAgregados.Remove(item)
            Else
                asignadosRemovidos.Add(item)
            End If
        Next
    End Sub

    Private Sub btnDenegarAsignado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDenegarAsignado.Click
        Dim a As ArrayList = New ArrayList()
        For Each item As Object In lstAsignados.SelectedItems
            a.Add(item)
        Next
        For Each item As Object In a
            lstAsignados.Items.Remove(item)
            lstDenegados.Items.Add(item)

            If (asignadosAgregados.Contains(item)) Then
                asignadosAgregados.Remove(item)
            Else
                asignadosRemovidos.Add(item)
            End If

            If (denegadosRemovidos.Contains(item)) Then
                denegadosRemovidos.Remove(item)
            Else
                denegadosAgregados.Add(item)
            End If
        Next
    End Sub

    Private Sub btnAsignarDenegado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarDenegado.Click
        Dim a As ArrayList = New ArrayList()
        For Each item As Object In lstDenegados.SelectedItems
            a.Add(item)
        Next
        For Each item As Object In a
            lstDenegados.Items.Remove(item)
            lstAsignados.Items.Add(item)

            If (denegadosAgregados.Contains(item)) Then
                denegadosAgregados.Remove(item)
            Else
                denegadosRemovidos.Add(item)
            End If

            If (asignadosRemovidos.Contains(item)) Then
                asignadosRemovidos.Remove(item)
            Else
                asignadosAgregados.Add(item)
            End If
        Next
    End Sub

    Private Sub btnQuitarDenegado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDenegado.Click
        Dim a As ArrayList = New ArrayList()
        For Each item As Object In lstDenegados.SelectedItems
            a.Add(item)
        Next
        For Each item As Object In a
            lstDenegados.Items.Remove(item)
            lstDisponibles.Items.Add(item)

            If (denegadosAgregados.Contains(item)) Then
                denegadosAgregados.Remove(item)
            Else
                denegadosRemovidos.Add(item)
            End If
        Next
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        _usuarioPermisos.UpdateSelected(idUsuario, AsignadosAgregadosToCsv(), AsignadosRemovidosToCsv())
        MessageBox.Show("El registro se actualizó exitosamente")
        Me.Close()
    End Sub

    Private Function AsignadosAgregadosToCsv() As String
        Dim s As String = ""
        For Each item As Object In asignadosAgregados
            s = s + (CType(item, cItem)).id + ","
        Next
        If (s.Length > 0) Then
            s = s.Substring(0, s.Length - 1)
        End If
        Return s
    End Function

    Private Function AsignadosRemovidosToCsv() As String
        Dim s As String = ""
        For Each item As Object In asignadosRemovidos
            s = s + (CType(item, cItem)).id + ","
        Next
        If (s.Length > 0) Then
            s = s.Substring(0, s.Length - 1)
        End If
        Return s
    End Function
End Class
