Imports System.Collections
Public Class SelectControl

    Dim RemovedItems As New ArrayList()
    Dim AddedItems As New ArrayList()
    Dim dtSelected As DataTable

    Public WriteOnly Property List1Label() As String
        Set(ByVal value As String)
            LblListbox1.Text = value
        End Set
    End Property

    Public WriteOnly Property List2Label() As String
        Set(ByVal value As String)
            LblListbox2.Text = value
        End Set
    End Property

    Public Function HasSelectedElements() As Boolean
        Return listBox2.Items.Count > 0
    End Function

    Public Sub Enable(ByVal enabled As Boolean)
        btnAdd.Enabled = enabled
        btnRemove.Enabled = enabled
        listBox1.Enabled = enabled
        listBox2.Enabled = enabled
    End Sub


    Public Sub DataTable(ByVal dt As DataTable, ByVal displayMember As String, ByVal valueMember As String)
        listBox1.DataSource = dt
        listBox1.DisplayMember = displayMember
        listBox1.ValueMember = valueMember
        dtSelected = New DataTable()
        dtSelected.Columns.Add(valueMember, Type.GetType("System.String"))
        dtSelected.Columns.Add(displayMember, Type.GetType("System.String"))
        listBox2.DataSource = dtSelected
        listBox2.DisplayMember = displayMember
        listBox2.ValueMember = valueMember
    End Sub

    Public Sub Add(ByVal displayMember As String, ByVal valueMember As String)
        Dim i As cItem = New cItem(displayMember, valueMember)
        listBox1.Items.Add(i)
    End Sub

    Public Sub AddAlreadySelected(ByVal displayMember As String, ByVal valueMember As String)
        Dim i As cItem = New cItem(displayMember, valueMember)
        listBox2.Items.Add(i)
    End Sub

    Public Sub ClearAll()
        listBox1.Items.Clear()
        listBox2.Items.Clear()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim a As ArrayList = New ArrayList()
        For Each item As Object In listBox1.SelectedItems
            a.Add(item)
        Next
        For Each item As Object In a
            listBox1.Items.Remove(item)
            listBox2.Items.Add(item)
            If (RemovedItems.Contains(item)) Then
                RemovedItems.Remove(item)
            Else
                AddedItems.Add(item)
            End If
        Next
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim a As ArrayList = New ArrayList()
        For Each item As Object In listBox2.SelectedItems
            a.Add(item)
        Next
        For Each item As Object In a
            listBox2.Items.Remove(item)
            listBox1.Items.Add(item)
            If (AddedItems.Contains(item)) Then
                AddedItems.Remove(item)
            Else
                RemovedItems.Add(item)
            End If
        Next
    End Sub

    Public Function csvSelectedItems() As String
        Dim s As String = ""
        For Each item As Object In listBox2.Items
            s = s + (CType(item, cItem)).id + ","
        Next
        If (s.Length > 0) Then
            s = s.Substring(0, s.Length - 1)
        End If
        Return s
    End Function


    Public Function csvAddedItems() As String

        Dim s As String = ""
        For Each item As Object In AddedItems
            s = s + (CType(item, cItem)).id + ","
        Next
        If (s.Length > 0) Then
            s = s.Substring(0, s.Length - 1)
        End If
        Return s
    End Function

    Public Function csvRemovedItems() As String
        Dim s As String = ""
        For Each item As Object In RemovedItems
            s = s + (CType(item, cItem)).id + ","
        Next
        If (s.Length > 0) Then
            s = s.Substring(0, s.Length - 1)
        End If
        Return s
    End Function


End Class

Public Class cItem
    Private _name As String
    Private _id As String

    Public Sub New(ByVal name As String, ByVal id As String)
        _name = name
        _id = id
    End Sub

    Public Overrides Function ToString() As String
        Return _name
    End Function


    Public ReadOnly Property id() As String
        Get
            Return _id
        End Get
    End Property

    Public ReadOnly Property name() As String
        Get
            Return _name
        End Get
    End Property

End Class
