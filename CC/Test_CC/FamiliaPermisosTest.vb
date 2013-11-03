Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports CC_BLL


<TestClass()> Public Class FamiliaFamiliaPermisosTest



    Private Function CreateNewObject() As Long
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        Dim newid As Integer
        newid = _FamiliaPermisos.Add(1000, 1000)
        CreateNewObject = newid
        _FamiliaPermisos = Nothing
    End Function


    <TestMethod()> Public Sub FamiliaPermisosTest_UpdateSelected()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        Assert.IsTrue(_FamiliaPermisos.UpdateSelected(1000, "1,2,3,4", "1,2,3,4"))
    End Sub

    <TestMethod()> Public Sub FamiliaPermisosTest_AddFamiliaPermisos()
        Dim newid As Long
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        newid = CreateNewObject()
        Assert.IsTrue(newid)
        _FamiliaPermisos.Delete(newid)
    End Sub


    <TestMethod()> Public Sub FamiliaPermisosTest_DeleteFamiliaPermisos()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        Dim dt As DataTable
        Dim newid As Integer
        newid = CreateNewObject()
        If newid <> 0 Then
            dt = _FamiliaPermisos.GetDataById(newid)
            Assert.IsTrue(_FamiliaPermisos.Delete(Int32.Parse(dt.Rows(0)("id_fampat").ToString())))
        End If
    End Sub
    <TestMethod()> Public Sub FamiliaPermisosTest_DeleteByFamPatt()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        Dim dt As DataTable
        Dim newid As Integer
        newid = CreateNewObject()
        If newid <> 0 Then
            dt = _FamiliaPermisos.GetDataById(newid)
            Assert.IsTrue(_FamiliaPermisos.Delete(Long.Parse(dt.Rows(0)("id_fam").ToString()), Long.Parse(dt.Rows(0)("id_patt").ToString())))
        End If
    End Sub
    <TestMethod()> Public Sub FamiliaPermisosTest_DeleteAll()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        Dim dt As DataTable
        Dim newid As Integer
        newid = CreateNewObject()
        If newid <> 0 Then
            dt = _FamiliaPermisos.GetDataById(newid)
            Assert.IsTrue(_FamiliaPermisos.DeleteAll(Long.Parse(dt.Rows(0)("id_fam").ToString())))
        End If
    End Sub
    <TestMethod()> Public Sub FamiliaPermisosTest_SetCheckSumAll()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        _FamiliaPermisos.SetCheckSumAll_e()
    End Sub

    <TestMethod()> Public Sub FamiliaPermisosTest_GetData()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        Assert.IsInstanceOfType(_FamiliaPermisos.GetData(), GetType(DataTable))
    End Sub

    <TestMethod(), ExpectedException(GetType(ApplicationException))> _
    Public Sub FamiliaPermisosTest_CheckSumViolation()
        Dim _familyfactory As New ConcreteFamilyFactory(Context.idUsuarioActual)
        Dim _FamiliaPermisos As FamiliaPermisos = _familyfactory.GetFamiliaPermisos()
        Dim dt As DataTable
        Dim newid As Integer

        newid = CreateNewObject()
        dt = _FamiliaPermisos.GetDataById(newid)
        dt.Rows(0)("id_patt") = 1975
        _FamiliaPermisos.T_UpdateWithoutCheckSum(dt)

        Try
            dt = _FamiliaPermisos.GetDataById(newid)
        Catch ex As Exception
            _FamiliaPermisos.Delete(Int32.Parse(dt.Rows(0)("id_fampat").ToString()))
            Throw (ex)
        Finally
        End Try
    End Sub
End Class
