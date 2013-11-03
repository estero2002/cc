Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports CC_BLL


<TestClass()> Public Class LanguageTest


    <TestMethod()> Public Sub LanguageTest_GetData()
        Dim _Langfactory As New ConcreteLangFactory(Context.idUsuarioActual)
        Dim _language As Lang = _Langfactory.GetLang()
        Assert.IsInstanceOfType(_language.GetData(), GetType(DataTable))
    End Sub

    <TestMethod()> Public Sub LanguageTest_GetLangCodeByIdLang()
        Dim _Langfactory As New ConcreteLangFactory(Context.idUsuarioActual)
        Dim _language As Lang = _Langfactory.GetLang()
        Assert.AreEqual("es-AR", _language.GetLangCodeByIdLang(1))
    End Sub



End Class