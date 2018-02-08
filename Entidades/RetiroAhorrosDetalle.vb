Public Class RetiroAhorrosDetalle

    Public Id As Integer
    Public RetiroId As Integer
    Public PlanId As Integer
    Public Retiro As Double

    Public Sub New(retiroId As Integer, planId As Integer, retiro As Double)
        Me.RetiroId = retiroId
        Me.PlanId = planId
        Me.Retiro = retiro
    End Sub

    Public Sub New()

    End Sub

End Class
