Public Class PlanAhorros

    Public PlanId As Integer
    Public Descripcion As String
    Public PorcientoDesc As Double
    Public Interes As Double

    Public Sub New(planId As Integer, descripcion As String, porcientoDesc As Double, interes As Double)
        Me.PlanId = planId
        Me.Descripcion = descripcion
        Me.PorcientoDesc = porcientoDesc
        Me.Interes = interes
    End Sub

    Public Sub New()

    End Sub

End Class
