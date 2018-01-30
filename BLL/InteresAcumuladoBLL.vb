Imports DAL
Imports Entidades

Public Class InteresAcumuladoBLL

    Public Shared Function Guardar(ByVal interesAcumulado As InteresesAcumulados) As Boolean

        Using coneccion As New Coneccion()
            If coneccion.EjecutarComando("Insert into InteresesAcumulados(Fecha, Total) 
                                        Values('" & interesAcumulado.Fecha & "', " & interesAcumulado.Total & ")") Then

                Dim dt = coneccion.SeleccionarDatos("SELECT MAX(IntAcumuladoId) as Id from InteresesAcumulados")
                Dim id = 0

                If dt.Rows.Count > 0 Then
                    id = dt.Rows(0)("Id")
                End If

                For Each detalle As InteresesAcumuladoDetalle In interesAcumulado.Detalle
                    coneccion.EjecutarComando("Insert into InteresesAcumuladoDetalle(IntAcumuladoId, Empleado, PlanAhorro, IntAcumulado) values(" & detalle.IntAcumuladoId & ", " & detalle.Empleado & ", " & detalle.PlanAhorro & ", " & detalle.IntAcumulado & ")")
                Next

                interesAcumulado.IntAcumuladoId = id
                Return True
            End If
        End Using

        Return False
    End Function

    Public Shared Function Buscar(ByVal id As Integer) As InteresesAcumulados

        Dim interesAcumulado = New InteresesAcumulados()

        Using coneccion As New Coneccion()

            Dim dt = coneccion.SeleccionarDatos("Select * from InteresesAcumulados where IntAcumuladoId =" & id & ";")

            If dt.Rows.Count > 0 Then
                interesAcumulado.IntAcumuladoId = dt.Rows(0)("IntAcumuladoId")
                interesAcumulado.Fecha = dt.Rows(0)("Fecha")
                interesAcumulado.Total = dt.Rows(0)("Total")
            End If

            dt = coneccion.SeleccionarDatos("select * from InteresesAcumuladoDetalle where IntAcumuladoId = " & interesAcumulado.IntAcumuladoId & "")
            For Each detalle As DataRow In dt.Rows
                interesAcumulado.Detalle.Add(New InteresesAcumuladoDetalle(detalle("IntAcumuladoId"), detalle("Empleado"), detalle("PlanAhorro"), detalle("IntAcumulado")))
            Next

            If interesAcumulado IsNot Nothing Then
                Return interesAcumulado
            End If

        End Using

        Return Nothing

    End Function

    Public Shared Function GetAllSociosAfiliados() As DataTable
        Dim dt As DataTable = Nothing
        Using coneccion As New Coneccion()
            dt = coneccion.SeleccionarDatos("select Emp.EmpleadoId, Pl.PlanId, Emp.Nombres, Emp.Sueldo, Pl.Descripcion, Pl.PorcientoDesc, sum(Ap.Aporte) as Aporte, DATEDIFF(MONTH, afil.FechaAfiliacion, getdate()) as diferenciameses, Pl.Interes
                                            from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det
	                                            on afil.Id = det.Afiliacion
                                            inner join Empleados Emp on Emp.EmpleadoId = afil.Empleado
                                            inner join PlanAhorros Pl on Pl.PlanId = det.PlanAhorro
                                            left join Aportes Ap on Emp.EmpleadoId = Ap.Empleado And Pl.PlanId = Ap.PlanAhorro where DATEDIFF(MONTH, afil.FechaAfiliacion, getdate()) > 0
                                            group by ap.Aporte, Emp.EmpleadoId,Emp.Nombres, Emp.Sueldo, Pl.Descripcion, Pl.PorcientoDesc, Afil.FechaAfiliacion, Pl.Interes, Pl.PlanId")
            Return dt
        End Using
    End Function

End Class
