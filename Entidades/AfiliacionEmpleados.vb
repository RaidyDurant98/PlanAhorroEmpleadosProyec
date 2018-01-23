Public Class AfiliacionEmpleados

    Public Id As Integer
    Public Empleado As Integer
    Public FechaAfiliacion As Date

    Public Detalle As List(Of AfiliacionEmpleadosDetalle)

    Public Sub New(empleado As Integer, fechaAfiliacion As Date, detalle As List(Of AfiliacionEmpleadosDetalle))
        Me.Empleado = empleado
        Me.FechaAfiliacion = fechaAfiliacion
        Me.Detalle = detalle
    End Sub

    Public Sub New()
        Detalle = New List(Of AfiliacionEmpleadosDetalle)
    End Sub

End Class
