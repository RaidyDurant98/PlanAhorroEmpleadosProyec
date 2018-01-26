Public Class Empleados

    Public EmpleadoId As Integer
    Public Nombres As String
    Public Direccion As String
    Public NumCel As String
    Public Sueldo As Double

    Public Sub New(empleadoId As Integer, nombres As String, direccion As String, numCel As String, sueldo As Double)
        Me.EmpleadoId = empleadoId
        Me.Nombres = nombres
        Me.Direccion = direccion
        Me.NumCel = numCel
        Me.Sueldo = sueldo
    End Sub

    Public Sub New()

    End Sub

End Class
