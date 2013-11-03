Imports CC_BLL

Public Class Bitacora
    Private _Usuario As Usuario

    Private Sub Bitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim UsuarioFactory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        _Usuario = UsuarioFactory.GetUsuario()
        CargarComboUsuarios()
        cmbUsuario.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CargarComboUsuarios()
        cmbUsuario.DisplayMember = "usuario"
        cmbUsuario.ValueMember = "id_usuario"
        cmbUsuario.setGetDataFunction(AddressOf _Usuario.GetDataParaCombo)
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        If cmbUsuario.SelectedValue > 0 Then
            Dim _log As Log = Log.getInstance()
            Dim nFechaDesde As Date = New Date(fechaDesde.Value.Year, fechaDesde.Value.Month, fechaDesde.Value.Day, 0, 0, 1)
            Dim fechaHastaNext As Date = fechaHasta.Value.AddDays(1)
            Dim nFechaHasta As Date = New Date(fechaHastaNext.Year, fechaHastaNext.Month, fechaHastaNext.Day, 0, 0, 1)
            grillaBitacora.DataSource = _log.GetDataByUsuario(cmbUsuario.SelectedValue, nFechaDesde, nFechaHasta)

            For Each column In grillaBitacora.Columns
                column.Visible = False
            Next

            grillaBitacora.Columns("id_log").Visible = True
            grillaBitacora.Columns("id_log").DisplayIndex = 0
            grillaBitacora.Columns("id_log").HeaderText = "ID"
            grillaBitacora.Columns("id_log").Width = 50
            grillaBitacora.Columns("date").Visible = True
            grillaBitacora.Columns("date").DisplayIndex = 1
            grillaBitacora.Columns("date").HeaderText = "Fecha"
            grillaBitacora.Columns("date").Width = 125
            grillaBitacora.Columns("action").Visible = True
            grillaBitacora.Columns("action").DisplayIndex = 2
            grillaBitacora.Columns("action").HeaderText = "Operacion"
            grillaBitacora.Columns("action").Width = 175
            grillaBitacora.Columns("parameters").Visible = True
            grillaBitacora.Columns("parameters").DisplayIndex = 3
            grillaBitacora.Columns("parameters").HeaderText = "Parametros"
            grillaBitacora.Columns("parameters").Width = 100
        Else
            Utilities.ShowInformationMessage("Debe seleccionar un ususario")
        End If
    End Sub

End Class