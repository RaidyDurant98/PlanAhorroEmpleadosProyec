Public Class Aportes

    Public AporteId As Integer
    Public Empleado As Integer
    Public PlanAHorro As Integer
    Public Aporte As Double

    Public Sub New(aporteId As Integer, empleado As Integer, planAhorro As Integer, aporte As Integer)
        Me.AporteId = aporteId
        Me.Empleado = empleado
        Me.PlanAHorro = planAhorro
        Me.Aporte = aporte
    End Sub

    Public Sub New()

    End Sub
End Class
