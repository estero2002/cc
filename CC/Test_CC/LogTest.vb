Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CC_BLL
Imports System.Data

<TestClass()> Public Class LogTest

    Private Function CreateNewObject() As Long
        Dim _Log As Log
        _Log = Log.getInstance()
        Dim newid As Integer, insertDate As Date, action As String, id_usuario As Long
        action = "Test Automatico"
        insertDate = Date.Now
        id_usuario = 1
        newid = _Log.Add(insertDate, action, "parametros", id_usuario)
        CreateNewObject = newid
        _Log = Nothing
    End Function


    <TestMethod()> Public Sub LogTest_AddLogEntry()
        Dim newid As Long
        newid = CreateNewObject()
        Assert.IsTrue(newid)
    End Sub

End Class
