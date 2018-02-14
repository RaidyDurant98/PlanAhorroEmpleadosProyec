Public Class Utilidades

    Public Shared Function ToDouble(ByVal str As String) As Double
        If str = String.Empty Then
            Return 0
        End If
        Dim numero As Double
        Double.TryParse(str, numero)
        Return numero

    End Function

End Class
