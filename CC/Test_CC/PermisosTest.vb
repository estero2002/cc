Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports CC_BLL


<TestClass()> Public Class PermisosTest
    <TestMethod()> Public Sub PermisosTest_GetPermisos()
        Dim _permisosfactory As New ConcretePermisosFactory(Context.idUsuarioActual)
        Dim _permisos As Permisos = _permisosfactory.GetPermisos()
        Assert.IsInstanceOfType(_permisos.GetDataByUsuario(1), GetType(DataTable))
    End Sub


    <TestMethod()> Public Sub PermisosTest_GetDataByIdFamiliaDispo()
        Dim _permisosfactory As New ConcretePermisosFactory(Context.idUsuarioActual)
        Dim _permisos As Permisos = _permisosfactory.GetPermisos() 
        Assert.IsInstanceOfType(_permisos.GetDataByIdFamiliaDispo(1), GetType(DataTable))
    End Sub


    <TestMethod()> Public Sub PermisosTest_GetDataByIdFamilia()
        Dim _permisosfactory As New ConcretePermisosFactory(Context.idUsuarioActual)
        Dim _permisos As Permisos = _permisosfactory.GetPermisos()
        Assert.IsInstanceOfType(_permisos.GetDataByIdFamilia(1), GetType(DataTable))
    End Sub
End Class
