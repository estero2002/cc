Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CC_BLL
Imports System.Data

<TestClass()> Public Class DescripcionPCTest

    Private Function CreateNewObject(ByVal id As Integer, ByVal nombre As String, ByVal activa As Integer) As Long
        Dim _DescripcionPCFactory As New ConcreteDescripcionPCFactory(Context.idUsuarioActual)
        Dim _DescripcionPC As DescripcionPC = _DescripcionPCFactory.GetDescripcionPC()
        Dim newid As Integer
        newid = _DescripcionPC.Add(id, nombre, activa)
        CreateNewObject = newid
        _DescripcionPC = Nothing
    End Function

    <TestMethod()> Public Sub DescripcionPCTest_Status()
        Dim _DescripcionPCFactory As New ConcreteDescripcionPCFactory(Context.idUsuarioActual)
        Dim _DescripcionPC As DescripcionPC = _DescripcionPCFactory.GetDescripcionPC()
        Dim newid As Integer
        newid = CreateNewObject(4, "TestPC", 0)
        If newid <> 0 Then
            Assert.AreEqual(1, _DescripcionPC.Status(3))
            Assert.AreEqual(0, _DescripcionPC.Status(newid))
            _DescripcionPC.Delete(newid)
        End If
    End Sub

    <TestMethod()> Public Sub DescripcionPCTest_UpdateDescripcionPC()
        Dim _DescripcionPCFactory As New ConcreteDescripcionPCFactory(Context.idUsuarioActual)
        Dim _DescripcionPC As DescripcionPC = _DescripcionPCFactory.GetDescripcionPC()
        Dim dtu As DataTable
        Dim newid As Integer
        newid = CreateNewObject(4, "TestPC", 0)
        If newid <> 0 Then
            Assert.IsTrue(_DescripcionPC.Update(newid, "TestPC5", 1))
            dtu = _DescripcionPC.GetDataById(newid)
            Assert.AreEqual("TestPC5", dtu.Rows(0)("pc_nombre").ToString())
            Assert.AreEqual("1", dtu.Rows(0)("pc_activa").ToString())
            _DescripcionPC.Delete(newid)
        End If
    End Sub

    <TestMethod()> Public Sub DescripcionPCTest_CambiarEstado()
        Dim _DescripcionPCFactory As New ConcreteDescripcionPCFactory(Context.idUsuarioActual)
        Dim _DescripcionPC As DescripcionPC = _DescripcionPCFactory.GetDescripcionPC()
        Dim dtu As DataTable
        Dim newid As Integer
        newid = CreateNewObject(4, "TestPC", 1)
        If newid <> 0 Then
            dtu = _DescripcionPC.GetDataById(newid)
            Assert.AreEqual("1", dtu.Rows(0)("pc_activa").ToString())
            _DescripcionPC.CambiarEstado(4, 0)
            dtu = _DescripcionPC.GetDataById(newid)
            Assert.AreEqual("0", dtu.Rows(0)("pc_activa").ToString())
            _DescripcionPC.Delete(newid)
        End If
    End Sub
End Class
