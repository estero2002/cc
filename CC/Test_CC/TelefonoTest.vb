Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CC_BLL
Imports System.Data

<TestClass()> Public Class TelefonoTest

    Private Function CreateNewObject(ByRef id_usuario As Long) As Long
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _telefonofactory As New ConcreteTelefonoFactory(Context.idUsuarioActual)
        Dim _Telefono As Telefono = _telefonofactory.GetTelefono()
        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim legajo, dni, idlang As Integer
        Dim nombre, apellido, direccion, username, password As String
        Dim newid As Integer
        legajo = 999998
        dni = 23876990
        idlang = 1
        nombre = "nombrePA"
        apellido = "apellidoPA"
        direccion = "direccionPA"
        username = "usernamePA"
        password = "passwordPA"
        id_usuario = _usuario.Add(legajo, dni, nombre, apellido, direccion, username, password, idlang)
        newid = _telefono.Add(id_usuario, 1, "93939393939393")
        CreateNewObject = newid
        _usuario = Nothing
    End Function

    <TestMethod()> Public Sub TelefonoTest_GetTelefonosByIdUsuario()
        Dim _telefonofactory As New ConcreteTelefonoFactory(Context.idUsuarioActual)
        Dim _Telefono As Telefono = _telefonofactory.GetTelefono()
        Dim idUsuario As Long = 27
        Dim dt As DataTable
        dt = _telefono.GetDataByIdUsuario(idUsuario, False)
        Assert.AreNotEqual(0, dt.Rows.Count)
    End Sub

    <TestMethod()> Public Sub TelefonoTest_AddTelefono()
        Dim newid As Long, id_usuario As Long
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _telefonofactory As New ConcreteTelefonoFactory(Context.idUsuarioActual)
        Dim _Telefono As Telefono = _telefonofactory.GetTelefono()
        Dim _Usuario As Usuario = _factory.GetUsuario()
        newid = CreateNewObject(id_usuario)
        Assert.IsTrue(newid <> 0)
        _Telefono.DeleteByIdUsuario(id_usuario)
        _Usuario.Delete(id_usuario)
    End Sub

    <TestMethod()> Public Sub TelefonoTest_UpdateTelefono()
        Dim newid As Long, id_usuario As Long
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _telefonofactory As New ConcreteTelefonoFactory(Context.idUsuarioActual)
        Dim _Telefono As Telefono = _telefonofactory.GetTelefono()
        Dim _Usuario As Usuario = _factory.GetUsuario()
        newid = CreateNewObject(id_usuario)
        Dim dt As DataTable = _Telefono.GetDataByIdUsuario(id_usuario)
        dt.Rows(0)("numero") = "1010101010"
        Dim r As DataRow = dt.NewRow()
        r("id_usuario") = id_usuario
        r("id_tipo_num") = 2
        r("numero") = "8484848484"
        dt.Rows.Add(r)
        Assert.IsTrue(_Telefono.Update(dt))
        _Telefono.DeleteByIdUsuario(id_usuario)
        _Usuario.Delete(id_usuario)
    End Sub
    <TestMethod()> Public Sub TelefonoTest_SetCheckSumAll()
        Dim _telefonofactory As New ConcreteTelefonoFactory(Context.idUsuarioActual)
        Dim _Telefono As Telefono = _telefonofactory.GetTelefono()
        _Telefono.SetCheckSumAll_e()
    End Sub

    <TestMethod()> Public Sub TelefonoTest_DeleteTelefono()
        Dim newid As Long, id_usuario As Long
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _telefonofactory As New ConcreteTelefonoFactory(Context.idUsuarioActual)
        Dim _Telefono As Telefono = _telefonofactory.GetTelefono()
        Dim _Usuario As Usuario = _factory.GetUsuario()
        newid = CreateNewObject(id_usuario)
        Assert.IsTrue(_Telefono.Delete(newid))
        _Usuario.Delete(id_usuario)
    End Sub

End Class
