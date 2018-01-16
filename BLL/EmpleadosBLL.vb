Imports DAL
Imports Entidades

Public Class EmpleadosBLL

    Public Shared Function Guardar(ByVal empleado As Empleados) As Boolean

        Using conexion As New Coneccion()

            If conexion.EjecutarComando("Insert into Empleados(Nombres, Sueldo, PLanAhorro) Values('" & empleado.Nombres & "' , '" & empleado.Sueldo & "' , '" & empleado.PlanAhorro & "');") > 0 Then
                Return True
            End If

        End Using

        Return False

    End Function

    Public Shared Function Buscar(ByVal id As Integer) As Empleados

        Dim empleado = New Empleados()

        Using coneccion As New Coneccion()

            Dim dt = coneccion.SeleccionarDatos("Select * from Empleados where EmpleadoId =" & id & ";")

            If dt.Rows.Count > 0 Then
                empleado.EmpleadoId = dt.Rows(0)("EmpleadoId")
                empleado.Nombres = dt.Rows(0)("Nombres")
                empleado.Sueldo = dt.Rows(0)("Sueldo")
                empleado.PlanAhorro = dt.Rows(0)("PlanAhorro")
            End If

            If empleado IsNot Nothing Then
                Return empleado
            End If

        End Using

        Return Nothing

    End Function

End Class
