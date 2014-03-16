Imports CC_BLL

Public Class FrmUsuario

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BuscarUsuarios()
    End Sub

    Private Sub BuscarUsuarios()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usu As Usuario = _factory.GetUsuario()
        Grid.Columns.Clear()
        Try
            Grid.DataSource = _usu.GetData()
            'Grid.DataSource = CType(_pxy.CallMethod("Usuario", "GetData", ""), DataTable)
            'Dar formato a la grilla
            Grid.Columns("legajo").Visible = False
            Grid.Columns("dni").Visible = False
            Grid.Columns("direccion").Visible = False
            Grid.Columns("username").Visible = False
            Grid.Columns("password").Visible = False
            Grid.Columns("id_lang").Visible = False
            Grid.Columns("strval").Visible = False
            'Grid.Columns("id_tel").Visible = False
            Grid.Columns("id_usuario").HeaderText = "Id Usuario"
            Grid.Columns("id_usuario").Width = 80
            Grid.Columns("id_usuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Grid.Columns("id_usuario").ReadOnly = True
            Grid.Columns("apellido").HeaderText = "Apellido"
            Grid.Columns("apellido").Width = 190
            Grid.Columns("apellido").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Grid.Columns("apellido").ReadOnly = True
            Grid.Columns("nombre").HeaderText = "Nombre"
            Grid.Columns("nombre").Width = 190
            Grid.Columns("nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Grid.Columns("nombre").ReadOnly = True
        Catch ex As Exception
            Utilities.ShowErrorMessage(ex.Message)
        End Try
    End Sub


    Private Sub Grid_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseDoubleClick
        Dim f As New UsuarioFicha()

        If Not Grid.CurrentRow Is Nothing Then
            f.idUsuario = Int32.Parse(Grid.CurrentRow.Cells("id_usuario").Value.ToString())
            f.ShowDialog()
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        UsuarioFicha.Show()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As New UsuarioFicha()
        If Not Grid.CurrentRow Is Nothing Then
            f.idUsuario = Int32.Parse(Grid.CurrentRow.Cells("id_usuario").Value.ToString())
            f.ShowDialog()
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Not Grid.CurrentRow Is Nothing Then
            If Utilities.YesNoDialog("Esta seguro que desea eliminar el registro?") = Windows.Forms.DialogResult.Yes Then
                Dim _factoryp As New ConcretePermisosFactory(Context.idUsuarioActual)
                Dim _permisos As Permisos = _factoryp.GetPermisos()
                If (_permisos.ViolaPattVitales(Grid.CurrentRow.Cells("id_usuario").Value.ToString())) Then
                    Utilities.ShowExclamationMessage("No se puede eliminar este usuario. Ningun otro usuario posee las patentes vitales.")
                Else
                    Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
                    Dim _usuario As Usuario = _factory.GetUsuario()
                    _usuario.Delete(Grid.CurrentRow.Cells("id_usuario").Value.ToString())
                    _usuario = Nothing
                End If
                _permisos = Nothing
            End If
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        BuscarUsuarios()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    
End Class