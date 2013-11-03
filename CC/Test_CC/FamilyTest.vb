Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports CC_BLL

<TestClass()> Public Class FamilyTest

  
    '<TestMethod()> Public Sub FamilyTest_GetCount()
    '    Dim _Family As New Family()
    '    Assert.AreEqual(5, _Family.GetCount())
    'End Sub

    <TestMethod()> Public Sub FamilyTest_GetFamilyByName()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _Family As Family = _familyfactory.GetFamily()
        Assert.AreEqual("1", _Family.GetFamilyByName("Administrador"))
    End Sub


    Private Function CreateNewObject() As Long
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _Family As Family = _familyfactory.GetFamily()
        Dim newid As Integer
        Dim nombre As String
        nombre = "nombrePA"
        newid = _Family.Add(nombre)
        CreateNewObject = newid
        _Family = Nothing
    End Function

    <TestMethod()> Public Sub FamilyTest_AddFamily()
        Dim newid As Long
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _Family As Family = _familyfactory.GetFamily()
        newid = CreateNewObject()
        Assert.IsTrue(newid)
        _Family.Delete(newid)
    End Sub

    <TestMethod()> Public Sub FamilyTest_UpdateFamily()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _Family As Family = _familyfactory.GetFamily()
        Dim newid As Integer
        Dim nombre As String
        newid = CreateNewObject()
        If newid <> 0 Then
            _Family.GetDataById(newid)
            nombre = "nombrePAmodificada"
            _Family.Update(newid, nombre)
            _Family.Delete(newid)
        End If
    End Sub

    <TestMethod()> Public Sub FamilyTest_DeleteFamily()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _Family As Family = _familyfactory.GetFamily()
        Dim dt As DataTable
        Dim newid As Integer
        newid = CreateNewObject()
        If newid <> 0 Then
            dt = _Family.GetDataById(newid)
            Assert.IsTrue(_Family.Delete(Int32.Parse(dt.Rows(0)("id_Family").ToString())))
        End If
    End Sub

    <TestMethod()> Public Sub FamilyTest_SetCheckSumAll()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _Family As Family = _familyfactory.GetFamily()
        _Family.SetCheckSumAll_e()
    End Sub

    <TestMethod()> Public Sub FamilyTest_GetData()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _Family As Family = _familyfactory.GetFamily()
        Assert.IsInstanceOfType(_Family.GetData(), GetType(DataTable))
    End Sub

    <TestMethod(), ExpectedException(GetType(ApplicationException))> _
    Public Sub FamilyTest_CheckSumViolation()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _Family As Family = _familyfactory.GetFamily()
        Dim dt As DataTable
        Dim newid As Integer

        newid = CreateNewObject()
        dt = _Family.GetDataById(newid)
        dt.Rows(0)("nombre") = "nombrePAmodifDT"
        _Family.T_UpdateWithoutCheckSum(dt)

        Try
            dt = _Family.GetDataById(newid)
        Catch ex As Exception
            _Family.Delete(Int32.Parse(dt.Rows(0)("id_Family").ToString()))
            Throw (ex)
        Finally
        End Try
    End Sub



End Class
