Module modFunctions
    Public Function IsAlphabetic(ByRef strToCheck As String) As Boolean
        For i As Integer = 0 To strToCheck.Length - 1
            If Not UCase(strToCheck(i)) Like "[ABCDEFGHIJKLMNOPQRSTUVWXYZ ]" Then
                Return False
            End If
        Next
        Return True
    End Function

End Module
