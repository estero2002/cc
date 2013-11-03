Imports CC_BLL

Public Class FrmFamily



    Private Sub Family_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BuscarFamilias()
    End Sub

    Private Sub BuscarFamilias()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _Family As Family = _familyfactory.GetFamily()
        Grid.Columns.Clear()
        Try
            Grid.DataSource = _Family.GetData()
            Grid.Columns("strval").Visible = False
            'Dar formato a la grilla
            Grid.Columns("id_Family").HeaderText = "Id Familia"
            Grid.Columns("id_Family").Width = 80
            Grid.Columns("id_Family").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Grid.Columns("id_Family").ReadOnly = True
            Grid.Columns("nombre").HeaderText = "Descripción"
            Grid.Columns("nombre").Width = 190
            Grid.Columns("nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Grid.Columns("nombre").ReadOnly = True
        Catch ex As Exception
            Utilities.ShowErrorMessage(ex.Message)
        End Try
    End Sub


    Private Sub Grid_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseDoubleClick
        Dim f As New FamiliaFicha()

        If Not Grid.CurrentRow Is Nothing Then
            f.idFamily = Int32.Parse(Grid.CurrentRow.Cells("id_Family").Value.ToString())
            f.ShowDialog()
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        FamiliaFicha.Show()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As New FamiliaFicha()
        If Not Grid.CurrentRow Is Nothing Then
            f.idFamily = Int32.Parse(Grid.CurrentRow.Cells("id_Family").Value.ToString())
            f.ShowDialog()
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Not Grid.CurrentRow Is Nothing Then
            If Utilities.YesNoDialog("Esta seguro que desea eliminar el registro?") = Windows.Forms.DialogResult.Yes Then
                Dim idFam As Long = Grid.CurrentRow.Cells("id_Family").Value.ToString()
                If (idFam = 1 Or idFam = 2) Then
                    Utilities.ShowExclamationMessage("Esta es una familia del sistema y no puede ser eliminada")
                    Return
                Else
                    Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
                    Dim _Family As Family = _familyfactory.GetFamily()
                    _Family.Delete(idFam)
                    Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
                    _FamiliaPermisos.DeleteAll(idFam)
                    _Family = Nothing
                    _FamiliaPermisos = Nothing
                End If
            End If
        Else
            Utilities.ShowExclamationMessage("No hay ninguna fila seleccionada en la grilla")
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        BuscarFamilias()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class