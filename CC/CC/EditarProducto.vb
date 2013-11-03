Imports CC_BLL
Imports System.Data

Public Class EditarProducto
    Dim _producto As Producto
    Private _idproducto As Integer
    Public Property idproducto() As Integer
        Get
            Return _idproducto
        End Get
        Set(ByVal value As Integer)
            _idproducto = value
        End Set
    End Property
    Private Sub Editarproducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)
        _producto = _factory.GetProducto()
        If idproducto <> 0 Then
            CargarRegistro()
        Else
        End If
    End Sub

    Private Sub CargarRegistro()
        Try
            Dim dt As DataTable = _producto.GetDataById(_idproducto)
            descrip.Text = dt.Rows(0)("descripcion").ToString()
            precio.Text = dt.Rows(0)("precio").ToString()
           
        Catch ex As Exception
            Utilities.ShowErrorMessage("Error en la carga de datos: " + ex.Message)
            Me.Close()

        End Try
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If ValidarDatos() Then
            If idproducto = 0 Then
                Dim newIdProduct As Long = _producto.Add(descrip.Text.ToString(), 1, Double.Parse(precio.Text.ToString()))
                MessageBox.Show("El registro se agregó exitosamente. Id: " + newIdProduct.ToString())
            Else
                _producto.Update(idproducto, descrip.Text.ToString(), 1, Double.Parse(precio.Text.ToString()))
            End If
            Me.Close()
        End If
        
    End Sub

    Private Function ValidarDatos() As Boolean
        Dim res As Boolean = True
        If (Utilities.Empty(descrip.Text.ToString())) Then
            res = False
            Utilities.ShowExclamationMessage("Debe completar producto")
        End If

        If (Utilities.Empty(precio.Text.ToString())) Then
            res = False
            Utilities.ShowExclamationMessage("Debe completar precio")
        End If
        ValidarDatos = res
    End Function



    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub


    'Private Sub precio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles precio.TextChanged
    '    If Not IsNumeric(e.KeyChar) Then
    '        If (Asc(e.KeyChar) <> Utilities.BACKSPACE) Then
    '            e.Handled = True
    '        End If
    '    End If

    'End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class