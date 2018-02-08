Public Class RetiroAhorros

    Public RetiroId As Integer
    Public Empleado As Integer
    Public Fecha As Date
    Public RetiroTotal As Double

    Public Detalle As List(Of RetiroAhorrosDetalle)

    Public Sub New(retiroId As Integer, empleado As Integer, fecha As Date, retiroTotal As Double, detalle As List(Of RetiroAhorrosDetalle))
        Me.RetiroId = retiroId
        Me.Empleado = empleado
        Me.Fecha = fecha
        Me.RetiroTotal = retiroTotal
        Me.Detalle = detalle
    End Sub

    Public Sub New()
        Detalle = New List(Of RetiroAhorrosDetalle)
    End Sub

End Class
