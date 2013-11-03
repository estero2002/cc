Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports CC_BLL

<TestClass()> Public Class ClienteTest

    Private Function CreateNewObject() As Long
        Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
        Dim _cliente As Cliente = _factory.GetCliente()
        Dim dni As Integer, newid As Integer
        Dim nombre, apellido, direccion, email As String
        dni = 23876990
        nombre = "nombrePA"
        apellido = "apellidoPA"
        direccion = "direccionPA"
        email = "pepe@nosequecosa.com.ar"
        newid = _cliente.Add(dni, nombre, apellido, direccion, email)
        CreateNewObject = newid
        _cliente = Nothing
    End Function

    <TestMethod()> Public Sub ClienteTest_AddCliente()
        Dim newid As Long
        Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
        Dim _cliente As Cliente = _factory.GetCliente()
        newid = CreateNewObject()
        Assert.IsTrue(newid)
        _cliente.Delete(newid)
    End Sub

    <TestMethod()> Public Sub ClienteTest_UpdateCliente()
        Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
        Dim _cliente As Cliente = _factory.GetCliente()
        Dim dni As Integer, newid As Integer
        Dim nombre, apellido, direccion, email As String
        newid = CreateNewObject()
        If newid <> 0 Then
            _cliente.GetDataById(newid)
            dni = 99999999
            nombre = "nombrePAmodificada"
            apellido = "apellidoPAmodificada"
            direccion = "direccionPAmodificada"
            email = "pepe@nosequecosamodificada.com.ar"
            _cliente.Update(newid, dni, nombre, apellido, direccion, email)
            _cliente.Delete(newid)
        End If
    End Sub

    <TestMethod()> Public Sub ClienteTest_DeleteCliente()
        Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
        Dim _cliente As Cliente = _factory.GetCliente()
        Dim dt As DataTable
        Dim newid As Integer
        newid = CreateNewObject()
        If newid <> 0 Then
            dt = _cliente.GetDataById(newid)
            Assert.IsTrue(_cliente.Delete(Int32.Parse(dt.Rows(0)("id_cliente").ToString())))
        End If
    End Sub

    <TestMethod()> Public Sub ClienteTest_SetCheckSumAll()
        Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
        Dim _cliente As Cliente = _factory.GetCliente()
        _cliente.SetCheckSumAll_e()
    End Sub

    <TestMethod(), ExpectedException(GetType(ApplicationException))> _
    Public Sub ClienteTest_CheckSumViolation()
        Dim _factory As New ConcreteClienteFactory(Context.idUsuarioActual)
        Dim _cliente As Cliente = _factory.GetCliente()
        Dim dt As DataTable
        Dim newid As Integer

        newid = CreateNewObject()
        dt = _cliente.GetDataById(newid)
        dt.Rows(0)("dni") = 1000002
        dt.Rows(0)("nombre") = "nombrePAmodifDT"
        dt.Rows(0)("apellido") = "apellidoPAmodifDT"
        dt.Rows(0)("direccion") = "direccionPAmodifDT"
        dt.Rows(0)("email") = "usernamePAmodifDT"
        _cliente.T_UpdateWithoutCheckSum(dt)

        Try
            dt = _cliente.GetDataById(newid)
        Catch ex As Exception
            _cliente.Delete(Int32.Parse(dt.Rows(0)("id_cliente").ToString()))
            Throw (ex)
        Finally
        End Try
    End Sub

End Class
