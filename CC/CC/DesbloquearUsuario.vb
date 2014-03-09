Imports CC_BLL

Public Class DesbloquearUsuario

    Private Sub DesbloquearUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BuscarUsuariosBloqueados()
    End Sub

    Private Sub BuscarUsuariosBloqueados()
        Dim _factory As New ConcreteUsuariosBloqueadosFactory(Context.idUsuarioActual)
        Dim _usrs As UsuariosBloqueados = _factory.GetUsuariosBloqueados()
        grillaUsuarios.Columns.Clear()
        Try
            grillaUsuarios.DataSource = _usrs.GetDataConDataUsuario()
            grillaUsuarios.Columns("strval").Visible = False
            grillaUsuarios.Columns("apellido").Visible = False
            grillaUsuarios.Columns("nombre").Visible = False
            grillaUsuarios.Columns("id_usuario").HeaderText = "Id"
            grillaUsuarios.Columns("id_usuario").DisplayIndex = 0
            grillaUsuarios.Columns("usuario").HeaderText = "Usuario"
            grillaUsuarios.Columns("usuario").DisplayIndex = 1
            grillaUsuarios.Columns("fecha_bloqueo").HeaderText = "Fecha Bloqueo"
            grillaUsuarios.Columns("fecha_bloqueo").DisplayIndex = 2
        Catch ex As Exception
            Utilities.ShowErrorMessage(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class