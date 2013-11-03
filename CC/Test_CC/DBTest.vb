Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CC_BLL
<TestClass()> Public Class DBTest
    <TestMethod()> Public Sub DBTest_BackupTest()
        Dim _factory As New ConcreteDBFactory(Context.idUsuarioActual)
        Dim bck As DB = _factory.GetDB()
        Assert.IsTrue(bck.backup("d:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\CC\CC\bin\Debug\ciber2.mdb", "d:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\CC\CC\bin\Debug\backup.mdb"))
        System.IO.File.Delete("d:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\CC\CC\bin\Debug\backup.mdb")
    End Sub
    <TestMethod(), ExpectedException(GetType(ApplicationException))> Public Sub DBTest_BackupValidTargetDiretoryTest()
        Dim _factory As New ConcreteDBFactory(Context.idUsuarioActual)
        Dim bck As DB = _factory.GetDB()
        bck.backup("d:\Documents and Settings\Admxxxxinistrator\My Documents\Visual Studio 2008\Projects\CC\CC\bin\Debug\ciber2.mdb", "d:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\CC\CC\bin\Debug\backup.mdb")
    End Sub

    <TestMethod()> Public Sub DBTest_RestoreBackupTest()
        Dim _factory As New ConcreteDBFactory(Context.idUsuarioActual)
        Dim bck As DB = _factory.GetDB()
        Assert.IsTrue(bck.backup("d:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\CC\CC\bin\Debug\ciber2.mdb", "d:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\CC\CC\bin\Debug\backup.mdb"))
        bck.restore("d:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\CC\CC\bin\Debug\ciber2.mdb", "d:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\CC\CC\bin\Debug\backup.mdb")
    End Sub

End Class
