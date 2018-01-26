Public Class InteresesAcumulados

    Public IntAcumuladoId As Integer
    Public Empleado As Integer
    Public PlanAhorro As Integer
    Public Fecha As Date
    Public IntAcumulado As Double

    Public Sub New(intAcumuladoId As Integer, empleado As Integer, planAhorro As Integer, fecha As Date, intAcumulado As Double)
        Me.IntAcumuladoId = intAcumuladoId
        Me.Empleado = empleado
        Me.PlanAhorro = planAhorro
        Me.Fecha = fecha
        Me.IntAcumulado = intAcumulado
    End Sub

    Public Sub New()

    End Sub

End Class
