﻿Public Class InteresesAcumuladoDetalle

    Public Id As Integer
    Public IntAcumuladoId As Integer
    Public Empleado As Integer
    Public PlanAhorro As Integer
    Public IntAcumulado As Double

    Public Sub New(intAcumuladoId As Integer, empleado As Integer, planAhorro As Integer, descripcion As String, fecha As Date, intAcumulado As Double)
        Me.IntAcumuladoId = intAcumuladoId
        Me.Empleado = empleado
        Me.PlanAhorro = planAhorro
        Me.IntAcumulado = intAcumulado
    End Sub

    Public Sub New()

    End Sub

End Class
