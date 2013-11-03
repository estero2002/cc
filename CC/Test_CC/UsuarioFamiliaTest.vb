Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports CC_BLL
<TestClass()> Public Class UsuarioFamiliaTest
    Private Function CreateNewObject() As Long
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _UsuarioFamilias As UsuarioFamilias = _factory.GetUsuarioFamilias()
        Dim newid As Integer
        newid = _UsuarioFamilias.Add(1000, 1000)
        CreateNewObject = newid
        _UsuarioFamilias = Nothing
    End Function
    <TestMethod()> Public Sub FamiliaPermisosTest_UpdateSelected()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _UsuarioFamilias As UsuarioFamilias = _factory.GetUsuarioFamilias()
        Assert.IsTrue(_UsuarioFamilias.UpdateSelected(1000, "1,2,3,4", "1,2,3,4"))
    End Sub

    <TestMethod()> Public Sub UsuarioFamiliasTest_AddUsuarioFamilias()
        Dim newid As Long
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _UsuarioFamilias As UsuarioFamilias = _factory.GetUsuarioFamilias()
        newid = CreateNewObject()
        Assert.IsTrue(newid)
        _UsuarioFamilias.Delete(newid)
    End Sub
    <TestMethod()> Public Sub UsuarioFamiliasTest_DeleteUsuarioFamilias()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _UsuarioFamilias As UsuarioFamilias = _factory.GetUsuarioFamilias()
        Dim dt As DataTable
        Dim newid As Integer
        newid = CreateNewObject()
        If newid <> 0 Then
            dt = _UsuarioFamilias.GetDataById(newid)
            Assert.IsTrue(_UsuarioFamilias.Delete(Int32.Parse(dt.Rows(0)("id_usrfam").ToString())))
        End If
    End Sub
    <TestMethod()> Public Sub UsuarioFamiliasTest_SetCheckSumAll()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _UsuarioFamilias As UsuarioFamilias = _factory.GetUsuarioFamilias()
        _UsuarioFamilias.SetCheckSumAll_e()
    End Sub

    <TestMethod()> Public Sub UsuarioFamiliasTest_GetData()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _UsuarioFamilias As UsuarioFamilias = _factory.GetUsuarioFamilias()
        Assert.IsInstanceOfType(_UsuarioFamilias.GetData(), GetType(DataTable))
    End Sub

    <TestMethod(), ExpectedException(GetType(ApplicationException))> _
    Public Sub UsuarioFamiliasTest_CheckSumViolation()
        Dim _factory As New ConcreteUsuarioFactory(Context.idUsuarioActual)
        Dim _UsuarioFamilias As UsuarioFamilias = _factory.GetUsuarioFamilias()
        Dim dt As DataTable
        Dim newid As Integer

        newid = CreateNewObject()
        dt = _UsuarioFamilias.GetDataById(newid)
        dt.Rows(0)("id_usuario") = 1975
        _UsuarioFamilias.T_UpdateWithoutCheckSum(dt)

        Try
            dt = _UsuarioFamilias.GetDataById(newid)
        Catch ex As Exception
            _UsuarioFamilias.Delete(Int32.Parse(dt.Rows(0)("id_usrfam").ToString()))
            Throw (ex)
        Finally
        End Try
    End Sub
End Class
