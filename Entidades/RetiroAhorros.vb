Public Class RetiroAhorros

    Public RetiroId As Integer
    Public Empleado As Integer
    Public Fecha As Date
    Public Retiro As Double

    Public Sub New(retiroId As Integer, empleado As Integer, fecha As Date, retiro As Double)
        Me.RetiroId = retiroId
        Me.Empleado = empleado
        Me.Fecha = fecha
        Me.Retiro = retiro
    End Sub

    Public Sub New()

    End Sub

End Class
