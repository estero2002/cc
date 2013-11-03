Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports CC_BLL


<TestClass()> Public Class TipoProductoTest


    <TestMethod()> Public Sub TipoProductoTest_GetData()
        Dim _factory As New ConcreteProductoFactory(Context.idUsuarioActual)
        Dim _tipoproducto As TipoProducto = _factory.GetTipoProducto()
        Assert.IsInstanceOfType(_tipoproducto.GetData(), GetType(DataTable))
    End Sub

End Class