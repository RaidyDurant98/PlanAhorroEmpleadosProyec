Public Class InteresesAcumulados

    Public IntAcumuladoId As Integer
    Public Fecha As Date

    Public Detalle As List(Of InteresesAcumuladoDetalle)

    Public Sub New(intAcumuladoId As Integer, fecha As Date, detalle As List(Of InteresesAcumuladoDetalle))
        Me.IntAcumuladoId = intAcumuladoId
        Me.Fecha = fecha
        Me.Detalle = detalle
    End Sub

    Public Sub New()
        Detalle = New List(Of InteresesAcumuladoDetalle)
    End Sub

End Class
