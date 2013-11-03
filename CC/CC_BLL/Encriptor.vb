Public Class Encriptor

    Public Shared Function ShiftK(ByVal Campo As String, ByVal Desplazamiento As Integer) As String
        ' Desplazamiento: +1 o -1
        Dim aux As String = ""
        For j = 1 To Len(Campo)
            If Desplazamiento > 0 Then
                aux = aux + Chr(Asc(Mid(Campo, j, 1)) + 1)
            Else
                aux = aux + Chr(Asc(Mid(Campo, j, 1)) - 1)
            End If
        Next
        ShiftK = aux
    End Function

End Class
