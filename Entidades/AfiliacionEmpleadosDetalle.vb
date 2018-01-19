Public Class AfiliacionEmpleadosDetalle

    Public Id As Integer
    Public Empleado As Integer
    Public PlanAhorro As Integer
    Public Descripcion As String
    Public PorcientoDesc As Double
    Public Interes As Double

    Public Sub New(id As Integer, empleado As Integer, planAhorro As Integer, descripcion As String, porcientoDesc As Double, interes As Double)
        Me.Empleado = empleado
        Me.PlanAhorro = planAhorro
        Me.Descripcion = descripcion
        Me.PorcientoDesc = porcientoDesc
        Me.Interes = interes
    End Sub

    Public Sub New()

    End Sub

End Class
