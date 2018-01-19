Imports DAL
Imports Entidades

Public Class AfiliacionEmpleadosBLL

    Public Shared Function Guardar(ByVal afiliacion As AfiliacionEmpleados) As Boolean

        Using conexion As New Coneccion()

            If conexion.EjecutarComando("Insert into AfiliacionEmpleados(Empleado, PlanAhorro, Descripcion, PorcientoDesc, Interes) 
                                        Values('" & afiliacion.Empleado & "', '" & afiliacion.PlanAhorro & "',  '" & afiliacion.Descripcion & "', 
                                        '" & afiliacion.PorcientoDesc & "', '" & afiliacion.Interes & "');") > 0 Then
                Return True
            End If

        End Using
        Return False

    End Function

    Public Shared Function Buscar(ByVal id As Integer) As AfiliacionEmpleados

        Dim afiliacion = New AfiliacionEmpleados()

        Using coneccion As New Coneccion()

            Dim dt = coneccion.SeleccionarDatos("Select * from AfiliacionEmpleados where Id =" & id & ";")

            If dt.Rows.Count > 0 Then
                afiliacion.Id = dt.Rows(0)("Id")
                afiliacion.Empleado = dt.Rows(0)("Empleado")
                afiliacion.PlanAhorro = dt.Rows(0)("PlanAhorro")
                afiliacion.Descripcion = dt.Rows(0)("Descripcion")
                afiliacion.PorcientoDesc = dt.Rows(0)("PorcientoDesc")
                afiliacion.Interes = dt.Rows(0)("Interes")
            End If

            If afiliacion IsNot Nothing Then
                Return afiliacion
            End If

        End Using

        Return Nothing

    End Function

    Public Shared Function Eliminar(ByVal id As Integer) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Delete from AfiliacionEmpleados where Id =" & id & ";") > 0 Then

                Return True
            End If

        End Using

        Return False
    End Function

    Public Shared Function Modificar(ByVal afiliacion As AfiliacionEmpleados) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Update AfiliacionEmpleados set Empleado = '" & afiliacion.Empleado & "', PlanAhorro = '" & afiliacion.PlanAhorro & "', 
                Descripcion = '" & afiliacion.Descripcion & "', PorcentoDesc = '" & afiliacion.PorcientoDesc & "', Interes = '" & afiliacion.Interes & "' where Id = '" & afiliacion.Id & "'") Then
                Return True
            End If

        End Using

        Return False
    End Function

End Class
