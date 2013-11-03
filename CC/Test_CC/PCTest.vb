Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CC_BLL
Imports System.Data

<TestClass()> Public Class PCTest

    Private Function CreateNewObject() As Long
        Dim _PCfactory As New ConcretePCFactory(Context.idUsuarioActual)
        Dim _PC As PC = _PCfactory.GetPC()
        Dim newid As Integer
        newid = _PC.Add(1, 1, 2)
        CreateNewObject = newid
        _PC = Nothing
    End Function

    <TestMethod()> Public Sub PCTest_AddPC()
        Dim newid As Long
        Dim _PCfactory As New ConcretePCFactory(Context.idUsuarioActual)
        Dim _PC As PC = _PCfactory.GetPC()
        newid = CreateNewObject()
        Assert.IsTrue(newid)
        _PC.Delete(newid)
    End Sub

    <TestMethod()> Public Sub PCTest_UpdatePC()
        Dim _PCfactory As New ConcretePCFactory(Context.idUsuarioActual)
        Dim _PC As PC = _PCfactory.GetPC()
        Dim newid As Integer
        newid = CreateNewObject()
        If newid <> 0 Then
            _PC.GetDataById(newid)
            _PC.Update()
            _PC.Delete(newid)
        End If
    End Sub

    <TestMethod()> Public Sub PCTest_DeletePC()
        Dim _PCfactory As New ConcretePCFactory(Context.idUsuarioActual)
        Dim _PC As PC = _PCfactory.GetPC()
        Dim dt As DataTable
        Dim newid As Integer
        newid = CreateNewObject()
        If newid <> 0 Then
            dt = _PC.GetDataById(newid)
            Assert.IsTrue(_PC.Delete(Int32.Parse(dt.Rows(0)("id").ToString())))
        End If
    End Sub

    <TestMethod()> Public Sub PCTest_SetCheckSumAll()
        Dim _PCfactory As New ConcretePCFactory(Context.idUsuarioActual)
        Dim _PC As PC = _PCfactory.GetPC()
        _PC.SetCheckSumAll_e()
    End Sub

    <TestMethod(), ExpectedException(GetType(ApplicationException))> _
    Public Sub PCTest_CheckSumViolation()
        Dim _PCfactory As New ConcretePCFactory(Context.idUsuarioActual)
        Dim _PC As PC = _PCfactory.GetPC()
        Dim dt As DataTable
        Dim newid As Integer

        newid = CreateNewObject()
        dt = _PC.GetDataById(newid)
        dt.Rows(0)("id_pc") = 9
        dt.Rows(0)("CantidadMinutos") = 3
        dt.Rows(0)("fecha") = Date.Now()
        dt.Rows(0)("id_cliente") = 99
        dt.Rows(0)("id_usuario") = 88
        _PC.T_UpdateWithoutCheckSum(dt)

        Try
            dt = _PC.GetDataById(newid)
        Catch ex As Exception
            _PC.Delete(Int32.Parse(dt.Rows(0)("id").ToString()))
            Throw (ex)
        Finally
        End Try
    End Sub


End Class
