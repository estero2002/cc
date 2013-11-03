Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports CC_BLL


<TestClass()> Public Class UsuarioTest

    Private Function CreateNewObject() As Long
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
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
        newid = _usuario.Add(legajo, dni, nombre, apellido, direccion, username, password, idlang)
        CreateNewObject = newid
        _usuario = Nothing
    End Function

    <TestMethod()> Public Sub UsuarioTest_ValidateUser()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim loginuser As String = "adm"
        Dim loginpass As String = "adm"
        Assert.AreEqual(_usuario.ValidateUser(loginuser, loginpass), True)
    End Sub

    <TestMethod()> Public Sub UsuarioTest_ValidateWrongPassword()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim loginuser As String = "adm"
        Dim loginpass As String = "admx"
        Assert.AreEqual(_usuario.ValidateUser(loginuser, loginpass), False)
    End Sub

    <TestMethod()> Public Sub UsuarioTest_ValidateWrongUser()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim loginuser As String = "ad"
        Dim loginpass As String = "adm"
        Assert.AreEqual(_usuario.ValidateUser(loginuser, loginpass), False)
    End Sub

    <TestMethod()> Public Sub UsuarioTest_ValidateEmptyPassword()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)

        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim loginuser As String = "adm"
        Dim loginpass As String = ""
        Try
            _usuario.ValidateUser(loginuser, loginpass)
        Catch ex As Exception
            AssertFailedException.Equals(ex, New ApplicationException)
        End Try

    End Sub

    <TestMethod()> Public Sub UsuarioTest_ValidateEmptyUser()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim loginuser As String = ""
        Dim loginpass As String = "admx"
        Try
            _usuario.ValidateUser(loginuser, loginpass)
        Catch ex As Exception
            AssertFailedException.Equals(ex, New ApplicationException)
        End Try

    End Sub

    <TestMethod()> Public Sub UsuarioTest_GetUserByUserName()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim loginuser As String = "adm"
        Dim dt As DataTable
        dt = _usuario.GetDataByUserName(loginuser)
        Assert.AreEqual(1, dt.Rows.Count)
    End Sub


    <TestMethod()> Public Sub UsuarioTest_AddUsuario()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim newid As Long
        Dim _usuario As Usuario = _factory.GetUsuario()
        newid = CreateNewObject()
        Assert.IsTrue(newid)
        _usuario.Delete(newid)
    End Sub

    <TestMethod()> Public Sub UsuarioTest_UpdateUsuario()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim newid As Integer
        Dim legajo, dni, idlang As Integer
        Dim nombre, apellido, direccion, username, password As String
        Dim dt As DataTable
        newid = CreateNewObject()
        If newid <> 0 Then
            dt = _usuario.GetDataByIdUsuario(newid)
            legajo = 1000001
            dni = 1000002
            idlang = 2
            nombre = "nombrePAmodificada"
            apellido = "apellidoPAmodificada"
            direccion = "direccionPAmodificada"
            username = "usernamePAmodificada"
            password = "passwordPAmodificada"
            Assert.IsTrue(_usuario.Update(Long.Parse(dt.Rows(0)("id_usuario").ToString()), legajo, dni, nombre, apellido, direccion, username, password, idlang))
            _usuario.Delete(newid)
        End If
    End Sub

    '<TestMethod()> Public Sub UsuarioTest_UpdateUsuario_DataTable()
    '    Dim _usuario As New Usuario()
    '    Dim loginuser As String = "usernamePADT"
    '    Dim dt As DataTable
    '    Dim legajo, dni, idlang As Integer
    '    Dim nombre, apellido, direccion, username, password As String

    '    legajo = 997798
    '    dni = 23000090
    '    idlang = 1
    '    nombre = "nombrePADT"
    '    apellido = "apellidoPADT"
    '    direccion = "direccionPADT"
    '    username = "usernamePADT"
    '    password = "passwordPADT"
    '    _usuario.Add(legajo, dni, nombre, apellido, direccion, username, password, idlang)

    '    dt = _usuario.GetDataByUserName(loginuser)
    '    dt.Rows(0)("legajo") = 1000002
    '    dt.Rows(0)("dni") = 1000002
    '    dt.Rows(0)("id_lang") = 2
    '    dt.Rows(0)("nombre") = "nombrePAmodifDT"
    '    dt.Rows(0)("apellido") = "apellidoPAmodifDT"
    '    dt.Rows(0)("direccion") = "direccionPAmodifDT"
    '    dt.Rows(0)("username") = "usernamePAmodifDT"
    '    dt.Rows(0)("password") = "passwordPAmodifDT"
    '    _usuario.Update(dt)

    '    loginuser = "usernamePAmodifDT"
    '    dt = _usuario.GetDataByUserName(loginuser)
    '    Assert.IsTrue(_usuario.Delete(Int32.Parse(dt.Rows(0)("id_usuario").ToString())))

    'End Sub

    <TestMethod()> Public Sub UsuarioTest_DeleteUsuario()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim newid As Integer
        newid = CreateNewObject()
        Assert.IsTrue(_usuario.Delete(newid))
    End Sub

    '<TestMethod()> Public Sub UsuarioTest_SetCheckSum()
    '    Dim _usuario As New Usuario()
    '    Dim legajo, dni, idlang As Integer
    '    Dim nombre, apellido, direccion, username, password As String
    '    legajo = 999998
    '    dni = 23876990
    '    idlang = 1
    '    nombre = "nombrePA"
    '    apellido = "apellidoPA"
    '    direccion = "direccionPA"
    '    username = "usernamePA"
    '    password = "passwordPA"
    '    Dim id As Long = _usuario.Add(legajo, dni, nombre, apellido, direccion, username, password, idlang)
    '    Dim cs As Long = CheckSum.Generate(id.ToString(), legajo.ToString(), dni.ToString(), nombre, apellido, direccion, username, password, idlang.ToString())
    '    _usuario.SetCheckSum(cs, id)
    '    Dim dt As DataTable
    '    dt = _usuario.GetDataByUserName(username)
    '    Assert.IsTrue(dt.Rows(0)("strval") = cs)
    '    _usuario.Delete(id)
    'End Sub

    <TestMethod()> Public Sub UsuarioTest_SetCheckSumAll()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As Usuario = _factory.GetUsuario()
        _usuario.SetCheckSumAll_e()
    End Sub


    <TestMethod(), ExpectedException(GetType(ApplicationException))> _
    Public Sub UsuarioTest_CheckSumViolation()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _usuario As Usuario = _factory.GetUsuario()
        Dim dt As DataTable
        Dim legajo, dni, idlang As Integer
        Dim nombre, apellido, direccion, username, password As String

        legajo = 997798
        dni = 23000090
        idlang = 1
        nombre = "nombrePADT"
        apellido = "apellidoPADT"
        direccion = "direccionPADT"
        username = "usernamePADT"
        password = "passwordPADT"
        _usuario.Add(legajo, dni, nombre, apellido, direccion, username, password, idlang)

        dt = _usuario.GetDataByUserName(username)
        dt.Rows(0)("legajo") = 1000002
        dt.Rows(0)("dni") = 1000002
        dt.Rows(0)("id_lang") = 2
        dt.Rows(0)("nombre") = "nombrePAmodifDT"
        dt.Rows(0)("apellido") = "apellidoPAmodifDT"
        dt.Rows(0)("direccion") = "direccionPAmodifDT"
        dt.Rows(0)("username") = "usernamePAmodifDT"
        dt.Rows(0)("password") = "passwordPAmodifDT"
        _usuario.T_UpdateWithoutCheckSum(dt)

        username = "usernamePAmodifDT"
        Try
            dt = _usuario.GetDataByUserName(username)
        Catch ex As Exception
            _usuario.Delete(Int32.Parse(dt.Rows(0)("id_usuario").ToString()))
            Throw (ex)
        Finally
        End Try
    End Sub

    
    
End Class
