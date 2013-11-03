Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CC_BLL
Imports System.Data

<TestClass()> Public Class AbonoClienteTest
    Private Function CreateNewObject() As Long
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        Dim _AbonoCliente As AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()
        Dim id_cliente As Integer
        id_cliente = _AbonoCliente.Add(0, 60, 6)
        CreateNewObject = id_cliente
        _AbonoCliente = Nothing
    End Function

    <TestMethod()> Public Sub AbonoClienteTest_AddAbono()
        Dim id_cliente As Long
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        Dim _AbonoCliente As AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()
        id_cliente = CreateNewObject()

        Dim abono As DataTable = _AbonoCliente.GetDataById(id_cliente, False)
        Assert.AreEqual(60, abono.Rows(0)("tiempo_restante"))
        Assert.AreEqual(6, abono.Rows(0)("tipo_producto"))
        _AbonoCliente.Delete(id_cliente)
    End Sub

    <TestMethod()> Public Sub AbonoClienteTest_UpdateAbono()
        Dim id_cliente As Long
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        Dim _AbonoCliente As AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()
        id_cliente = CreateNewObject()

        Dim abono As DataTable = _AbonoCliente.GetDataById(id_cliente, False)
        Assert.AreEqual(60, abono.Rows(0)("tiempo_restante"))
        Assert.AreEqual(6, abono.Rows(0)("tipo_producto"))

        _AbonoCliente.Update(id_cliente, 70, 7)

        Dim abonou As DataTable = _AbonoCliente.GetDataById(id_cliente, False)
        Assert.AreEqual(70, abonou.Rows(0)("tiempo_restante"))
        Assert.AreEqual(7, abonou.Rows(0)("tipo_producto"))

        _AbonoCliente.Delete(id_cliente)
    End Sub

    <TestMethod()> Public Sub AbonoClienteTest_DeleteAbono()
        Dim id_cliente As Long
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        Dim _AbonoCliente As AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()
        id_cliente = CreateNewObject()

        Assert.IsTrue(_AbonoCliente.Delete(id_cliente))

    End Sub

    <TestMethod()> Public Sub AbonoClienteTest_ActualizarTiempoAbono()
        Dim id_cliente As Long
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        Dim _AbonoCliente As AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()
        id_cliente = CreateNewObject()

        Dim abono As DataTable = _AbonoCliente.GetDataById(id_cliente, False)
        Assert.AreEqual(60, abono.Rows(0)("tiempo_restante"))
        Assert.AreEqual(6, abono.Rows(0)("tipo_producto"))

        _AbonoCliente.ActualizarTiempoAbono(id_cliente, 70)

        Dim abonou As DataTable = _AbonoCliente.GetDataById(id_cliente, False)
        Assert.AreEqual(70, abonou.Rows(0)("tiempo_restante"))
        Assert.AreEqual(6, abonou.Rows(0)("tipo_producto"))

        _AbonoCliente.Delete(id_cliente)
    End Sub

    <TestMethod()> Public Sub AbonoClienteTest_DescontarTiempoAbonoMayor()
        Dim id_cliente As Long
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        Dim _AbonoCliente As AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()
        id_cliente = CreateNewObject()

        Dim tiempoACobrarFinal = _AbonoCliente.DescontarTiempoAbono(id_cliente, 55)
        Dim abonou As DataTable = _AbonoCliente.GetDataById(id_cliente, False)

        Assert.AreEqual(5, abonou.Rows(0)("tiempo_restante"))
        Assert.AreEqual(0, tiempoACobrarFinal)

        _AbonoCliente.Delete(id_cliente)
    End Sub

    <TestMethod()> Public Sub AbonoClienteTest_DescontarTiempoAbonoMenor()
        Dim id_cliente As Long
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        Dim _AbonoCliente As AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()
        id_cliente = CreateNewObject()

        Dim tiempoACobrarFinal = _AbonoCliente.DescontarTiempoAbono(id_cliente, 65)
        Dim abonou As DataTable = _AbonoCliente.GetDataById(id_cliente, False)

        Assert.AreEqual(0, abonou.Rows(0)("tiempo_restante"))
        Assert.AreEqual(5, tiempoACobrarFinal)

        _AbonoCliente.Delete(id_cliente)
    End Sub

    <TestMethod()> Public Sub AbonoClienteTest_TieneAbono()
        Dim id_cliente As Long
        Dim _AbonoClienteFactory As New ConcreteAbonoClienteFactory(Context.idUsuarioActual)
        Dim _AbonoCliente As AbonoCliente = _AbonoClienteFactory.GetAbonoCliente()

        Assert.IsFalse(_AbonoCliente.TieneAbono(0))

        id_cliente = CreateNewObject()

        Assert.IsTrue(_AbonoCliente.TieneAbono(0))

        _AbonoCliente.Delete(0)
    End Sub
End Class
