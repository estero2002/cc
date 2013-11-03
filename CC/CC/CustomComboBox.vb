Imports System.Data

Public Class CustomComboBox
    Private _ta As Object
    Private _search As Boolean = True

    Public Property TableAdapter() As Object
        Get
            Return _ta
        End Get
        Set(ByVal value As Object)
            _ta = value
        End Set
    End Property


    Private _displayMember As String
    Public Property DisplayMember() As String
        Get
            Return _displayMember
        End Get
        Set(ByVal value As String)
            _displayMember = value
            ComboBox1.DisplayMember = _displayMember
        End Set
    End Property



    Private _valueMember As String
    Public Property ValueMember() As String
        Get
            Return _valueMember
        End Get
        Set(ByVal value As String)
            _valueMember = value
            ComboBox1.ValueMember = _valueMember
        End Set
    End Property


    Public ReadOnly Property SelectedValue() As Integer
        Get
            Return ComboBox1.SelectedValue
        End Get
    End Property


    Public Delegate Function getDataDelegate(ByVal descri As String) As DataTable
    Private _getDataFunction As getDataDelegate

    Public Sub setGetDataFunction(ByVal getDataFunction As getDataDelegate)
        _getDataFunction = getDataFunction
    End Sub


    Private Sub ComboBox1_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDown
        'ComboBox1.DataSource = _ta.GetDataByDescri(ComboBox1.Text)
        If _search Then
            ComboBox1.DataSource = _getDataFunction(ComboBox1.Text)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        _search = False

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        _search = True
    End Sub

    Private Sub ComboBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox1.Validating
        'ComboBox1.DataSource = _ta.GetDataByDescri(ComboBox1.Text)
        If _search Then
            ComboBox1.DataSource = _getDataFunction(ComboBox1.Text)
        End If
    End Sub
End Class
