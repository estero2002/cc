Interface ICheckSum
    Function SetCheckSum_e(ByVal dt As DataTable) As Boolean
    Function SetCheckSumAll_e() As Boolean
    Function ValidateData_e(ByVal dt As DataTable) As Boolean
End Interface

Public Class CheckSum

    Public Overloads Shared Function Generate(ByVal ParamArray p() As String) As Long
        Dim cadena As String = Join(p, "")
        Return CheckSum.Generate(cadena)
    End Function

    Public Overloads Shared Function Generate(ByVal s As String) As Long
        Dim i As Integer
        Dim res As Long
        For i = 1 To Len(s)
            res = res + Asc(Mid(s, i, 1))
        Next
        Return res
    End Function
    Public Overloads Shared Function Generate(ByVal dt As DataTable) As Long
        Dim res As Long = 0
        Dim db_checksum As Long
        Dim cad As String
        For Each row As DataRow In dt.Rows
            cad = ""
            For Each dc As DataColumn In row.Table.Columns
                If row.RowState <> DataRowState.Deleted Then
                    If UCase(dc.ColumnName) = UCase("strval") Then
                        db_checksum = IIf(IsDBNull(row.Item(dc.ColumnName)), 0, row.Item(dc.ColumnName))

                    Else
                        cad = cad + row.Item(dc.ColumnName).ToString()
                    End If
                End If
            Next
            If row.RowState <> DataRowState.Deleted Then
                If CheckSum.Generate(cad) <> db_checksum Then
                    row("strval") = CheckSum.Generate(cad)
                    res = res + 1
                End If
            End If
        Next
        Return res
    End Function

    Public Overloads Shared Function Check(ByVal dt As DataTable, ByRef dtErrors As DataTable) As Boolean
        Dim res As Boolean = True
        Dim db_checksum As Long
        Dim cad As String
        dtErrors = dt.Clone()
        For Each row As DataRow In dt.Rows
            If row.RowState <> DataRowState.Deleted Then
                cad = ""
                For Each dc As DataColumn In row.Table.Columns
                    If UCase(dc.ColumnName) = UCase("strval") Then
                        db_checksum = row.Item(dc.ColumnName)
                    Else
                        cad = cad + row.Item(dc.ColumnName).ToString()
                    End If
                Next
                If row.RowState <> DataRowState.Deleted Then
                    If CheckSum.Generate(cad) <> db_checksum Then
                        res = False
                        dtErrors.ImportRow(row)
                    End If
                End If
            End If
        Next
        If Not res Then
            dtErrors = Nothing
        End If
        Return res
    End Function
End Class
