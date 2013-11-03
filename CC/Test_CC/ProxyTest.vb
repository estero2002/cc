Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CC_BLL
Imports System.Data

<TestClass()> Public Class ProxyTest
    <TestMethod()> Public Sub ProxyTest_CallMethodGetDataTest()
        Dim _proxy As New Proxy()
        Dim _dt As DataTable
        Dim _obj As Object = _proxy.CallMethod("Usuario", "GetData", "")
        _dt = CType(_obj, DataTable)


    End Sub

End Class
