Public Class AfiliacionEmpleadosDetalle

    Public Id As Integer
    Public Afiliacion As Integer
    Public PlanAhorro As Integer
    Public Descripcion As String
    Public PorcientoDesc As Double
    Public Interes As Double
    Public FondoMinimo As Double

    Public Sub New(planAhorro As Integer, afiliacion As Integer, descripcion As String, porcientoDesc As Double, interes As Double, fondoMinimo As Double)
        Me.PlanAhorro = planAhorro
        Me.Afiliacion = afiliacion
        Me.Descripcion = descripcion
        Me.PorcientoDesc = porcientoDesc
        Me.Interes = interes
        Me.FondoMinimo = fondoMinimo
    End Sub

    Public Sub New()

    End Sub

End Class
