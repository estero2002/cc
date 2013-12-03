Imports CC_BLL
Imports System.Data

Public Class FamiliaFicha
    Dim _Family As Family
    Dim _Permisos As Permisos
    Dim _FamiliaPermisos As FamiliaPermisos
    Dim _Lang As Lang

    Private _idFamily As Integer
    Public Property idFamily() As Integer
        Get
            Return _idFamily
        End Get
        Set(ByVal value As Integer)
            _idFamily = value
        End Set
    End Property

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If ValidarDatos() Then
            If idFamily = 0 Then

                If Not ValidarNombreDuplicado() Then
                    Return
                End If

                Dim newIdFamily As Long = _Family.Add(txtNombre.Text.ToString())
                idFamily = newIdFamily
            Else
                _Family.Update(idFamily, txtNombre.Text.ToString())
            End If
            _FamiliaPermisos.UpdateSelected(idFamily, SelectControl1.csvAddedItems, SelectControl1.csvRemovedItems)
            MessageBox.Show("El registro se actualizó exitosamente")
            Me.Close()
        End If
    End Sub
    Private Function ValidarDatos() As Boolean
        Dim res As Boolean = True
        If (Utilities.Empty(txtNombre.Text.ToString())) Then
            res = False
            Utilities.ShowExclamationMessage("Debe completar el nombre")
        End If
        ValidarDatos = res
    End Function

    Private Function ValidarNombreDuplicado() As Boolean
        Dim res As Boolean = True
        Dim familias As DataTable = _Family.GetData()

        If (Utilities.ExistsRecord(familias, "nombre", txtNombre.Text)) Then
            res = False
            Utilities.ShowExclamationMessage("Ya existe una familia con ese nombre")
        End If

        Return res
    End Function

    Private Sub NuevoFamily_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _permisosfactory As New ConcretePermisosFactory(Context.idUsuarioActual)
        Dim _Langfactory As New ConcreteLangFactory(Context.idUsuarioActual)
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        _Family = _familyfactory.GetFamily()
        _Permisos = _permisosfactory.GetPermisos()
        _FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        _Lang = _Langfactory.GetLang()
        If idFamily <> 0 Then
            'Carga Family seleccionado
            CargarRegistro()
        Else
            'Es un Family nuevo
            cargarCombos()
        End If
    End Sub
    Private Sub cargarCombos()
        Try
            SetSelectControlLabels()
            Dim d As DataTable = _Permisos.GetDataByIdFamiliaDispo(idFamily)
            For Each r As DataRow In d.Rows
                SelectControl1.Add(r("descripcion").ToString(), r("id_patt").ToString())
            Next
            d = Nothing

            d = _Permisos.GetDataByIdFamilia(idFamily)
            For Each r As DataRow In d.Rows
                SelectControl1.AddAlreadySelected(r("descripcion").ToString(), r("id_patt").ToString())
            Next
            d = Nothing
        Catch ex As Exception
            Utilities.ShowErrorMessage("Error en la carga de datos: " + ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub CargarRegistro()
        Try
            'Carga del registro para posterior edición de Family
            cargarCombos()
            Dim dt As DataTable = _Family.GetDataById(idFamily)
            txtNombre.Text = dt.Rows(0)("Nombre").ToString()
        Catch ex As Exception
            Utilities.ShowErrorMessage("Error en la carga de datos: " + ex.Message)
            Me.Close()

        End Try
    End Sub
    Private Sub SetSelectControlLabels()
        SelectControl1.List1Label = "Patterns Disponibles"
        SelectControl1.List2Label = "Patterns Asociados"
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class