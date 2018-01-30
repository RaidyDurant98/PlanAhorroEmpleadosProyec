Imports DAL
Imports Entidades

Public Class AfiliacionEmpleadosBLL

    Public Shared Function Guardar(ByVal afiliacion As AfiliacionEmpleados) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Insert into AfiliacionEmpleados(Empleado, FechaAfiliacion) Values('" & afiliacion.Empleado & "', '" & afiliacion.FechaAfiliacion & "')") Then

                Dim dt = coneccion.SeleccionarDatos("SELECT MAX(Id) as Id from AfiliacionEmpleados")
                Dim id = 0

                If dt.Rows.Count > 0 Then
                    id = dt.Rows(0)("Id")
                End If

                For Each detalle As AfiliacionEmpleadosDetalle In afiliacion.Detalle
                    coneccion.EjecutarComando("Insert into AfiliacionEmpleadosDetalle(PlanAhorro, Afiliacion, Descripcion, PorcientoDesc, Interes, FondoMinimo) values(" & detalle.PlanAhorro & ", " & id & ", '" & detalle.Descripcion & "', " & detalle.PorcientoDesc & ", " & detalle.Interes & ", " & detalle.FondoMinimo & ");")
                Next

                afiliacion.Id = id

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
                afiliacion.FechaAfiliacion = dt.Rows(0)("FechaAfiliacion")
            End If

            dt = coneccion.SeleccionarDatos("select * from AfiliacionEmpleadosDetalle where Afiliacion = " & afiliacion.Id & "")
            For Each detalle As DataRow In dt.Rows
                afiliacion.Detalle.Add(New AfiliacionEmpleadosDetalle(detalle("PlanAhorro"), detalle("Afiliacion"), detalle("Descripcion"), detalle("PorcientoDesc"), detalle("Interes"), detalle("FondoMinimo")))
            Next

            If afiliacion IsNot Nothing Then
                Return afiliacion
            End If

        End Using

        Return Nothing

    End Function

    Public Shared Function Eliminar(ByVal id As Integer) As Boolean

        Dim afiliacion = New AfiliacionEmpleados()

        Using coneccion As New Coneccion()
            Try
                If coneccion.EjecutarComando("Delete from AfiliacionEmpleadosDetalle where Afiliacion = " & id & "") > 0 Then


                    coneccion.EjecutarComando("Delete from AfiliacionEmpleados where Id =" & id & ";")
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Shared Function Modificar(ByVal afiliacion As AfiliacionEmpleados) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Update AfiliacionEmpleados set Empleado = '" & afiliacion.Empleado & "', FechaAfiliacion = '" & afiliacion.FechaAfiliacion & "' where Id = " & afiliacion.Id & "") Then

                coneccion.EjecutarComando("Delete from AfiliacionEmpleadosDetalle where Afiliacion = " & afiliacion.Id & "")

                For Each detalle As AfiliacionEmpleadosDetalle In afiliacion.Detalle

                    coneccion.EjecutarComando("Insert into AfiliacionEmpleadosDetalle(PlanAhorro, Afiliacion, Descripcion, PorcientoDesc, Interes, FondoMinimo) 
                                                values(" & detalle.PlanAhorro & ", " & afiliacion.Id & ", '" & detalle.Descripcion & "', " & detalle.PorcientoDesc & ", " & detalle.Interes & ", " & detalle.FondoMinimo & ")")

                Next
                Return True
            End If

        End Using

        Return False
    End Function
End Class
