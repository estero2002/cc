Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports CC_BLL

<TestClass()> Public Class CheckSumTest
    <TestMethod()> Public Sub CheckSumTest_Generate()
        Assert.IsTrue(CheckSum.Generate("1", "pepe", "l a a a a", "-45") > 0)

    End Sub

    <TestMethod()> Public Sub CheckSumTest_Generate2()
        Assert.IsTrue(CheckSum.Generate("jamon", "2", "", " ") > 0)
    End Sub


    <TestMethod()> Public Sub CheckSumTest_Generate_always_same_result()
        Dim a As Long = CheckSum.Generate("lo q sea", "##", "!#$%&/()=?'{}[]´+-.,:;")
        Dim b As Long = CheckSum.Generate("lo q sea", "##", "!#$%&/()=?'{}[]´+-.,:;")
        Assert.AreEqual(a, b)
    End Sub

    <TestMethod()> Public Sub CheckSumTest_Generate_Overloads()
        Dim a As Long = CheckSum.Generate("lo q sea", "##", "!#$%&/()=?'{}[]´+-.,:;")
        Dim b As Long = CheckSum.Generate("lo q sea##!#$%&/()=?'{}[]´+-.,:;")
        Assert.AreEqual(a, b)
    End Sub

    'Este test ya no es valido ya que el strval se genera con los datos encriptados y 
    'el getdata los desencripta para q se puedan mostrar por la aplicación.
    'En todo caso habría que hacer una getdata para test que no desencripte.
    '<TestMethod()> Public Sub CheckSumTest_Check_DataTable()
    'Dim usu As New Usuario()
    'Dim dt As DataTable = usu.GetData()
    'Dim dtErrors As New DataTable
    '    Assert.IsTrue(CheckSum.Check(dt, dtErrors))
    'End Sub

    <TestMethod()> Public Sub CheckSumTest_Generate_DataTable()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim usu As Usuario = _factory.GetUsuario()
        Dim dt As DataTable = usu.GetData()
        Dim dtErrors As New DataTable
        Assert.IsTrue(CheckSum.Generate(dt) >= 0)
    End Sub


End Class
