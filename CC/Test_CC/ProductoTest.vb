Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CC_BLL
Imports System.Data

<TestClass()> Public Class ProductoTest

    Private Function CreateNewObject() As Long
        Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)
        Dim _Producto As Producto = _factory.GetProducto()
        Dim newid As Integer, tipoproducto As Integer, precio As Double
        Dim descripcion As String
        tipoproducto = 1
        descripcion = "descripcionPA"
        precio = 33.93
        newid = _Producto.Add(descripcion, tipoproducto, precio)
        CreateNewObject = newid
        _Producto = Nothing
    End Function

    <TestMethod()> Public Sub ProductoTest_AddProducto()
        Dim newid As Long
        Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)
        Dim _Producto As Producto = _factory.GetProducto()
        newid = CreateNewObject()
        Assert.IsTrue(newid)
        _Producto.Delete(newid)
    End Sub

    <TestMethod()> Public Sub ProductoTest_UpdateProducto()
        Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)
        Dim _Producto As Producto = _factory.GetProducto()
        Dim newid As Integer, tipoproducto As Integer
        Dim descripcion As String
        Dim precio As Double
        newid = CreateNewObject()
        If newid <> 0 Then
            _Producto.GetDataById(newid)
            descripcion = "descripcionPAmodificada"
            precio = 77.76
            tipoproducto = 2
            _Producto.Update(newid, descripcion, tipoproducto, precio)
            _Producto.Delete(newid)
        End If
    End Sub

    <TestMethod()> Public Sub ProductoTest_DeleteProducto()
        Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)
        Dim _Producto As Producto = _factory.GetProducto()
        Dim dt As DataTable
        Dim newid As Integer
        newid = CreateNewObject()
        If newid <> 0 Then
            dt = _Producto.GetDataById(newid)
            Assert.IsTrue(_Producto.Delete(Int32.Parse(dt.Rows(0)("id_Producto").ToString())))
        End If
    End Sub

    <TestMethod()> Public Sub ProductoTest_SetCheckSumAll()
        Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)
        Dim _Producto As Producto = _factory.GetProducto()
        _Producto.SetCheckSumAll_e()
    End Sub

    <TestMethod(), ExpectedException(GetType(ApplicationException))> _
    Public Sub ProductoTest_CheckSumViolation()
        Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)
        Dim _Producto As Producto = _factory.GetProducto()
        Dim dt As DataTable
        Dim newid As Integer

        newid = CreateNewObject()
        dt = _Producto.GetDataById(newid)
        dt.Rows(0)("descripcion") = "descripcionPAmodifDT"
        dt.Rows(0)("tipo_producto") = 3
        dt.Rows(0)("precio") = 43.21
        _Producto.T_UpdateWithoutCheckSum(dt)

        Try
            dt = _Producto.GetDataById(newid)
        Catch ex As Exception
            _Producto.Delete(Int32.Parse(dt.Rows(0)("id_Producto").ToString()))
            Throw (ex)
        Finally
        End Try
    End Sub


End Class
