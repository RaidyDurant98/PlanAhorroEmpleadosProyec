Imports DAL

Public Class RetirosBLL

    'Public Shared Function Guardar(ByVal retiro As re) As Boolean

    '    Using coneccion As New Coneccion()

    '        If coneccion.EjecutarComando("Insert into PlanAhorros(Descripcion, PorcientoDesc, Interes, FondoMinimo) Values('" & planAhorro.Descripcion & "' , '" & planAhorro.PorcientoDesc & "' , '" & planAhorro.Interes & "', " & planAhorro.FondoMinimo & ");") > 0 Then
    '            Dim dt = coneccion.SeleccionarDatos("SELECT MAX(PlanId) as Id from PlanAhorros")
    '            Dim id = 0

    '            If dt.Rows.Count > 0 Then
    '                id = dt.Rows(0)("Id")
    '            End If

    '            planAhorro.PlanId = id

    '            Return True
    '        End If
    '    End Using

    '    Return False

    'End Function

    Public Shared Function ObtenerInteresAcumulado(ByVal id As Integer) As DataTable

        Dim dt = New DataTable

        Using coneccion As New Coneccion()

            dt = coneccion.SeleccionarDatos("select pl.PlanId, Pl.Descripcion, Sum(IntAcDet.IntAcumulado) total, 0.00 as Cantidad
                                            from InteresesAcumulados IntAc inner join InteresesAcumuladoDetalle IntAcDet
                                             on IntAc.IntAcumuladoId = IntAcDet.IntAcumuladoId
                                            inner join Empleados Emp on Emp.EmpleadoId = IntAcDet.Empleado
                                            inner join PlanAhorros Pl on pl.PlanId = IntAcDet.PlanAhorro
                                            where Emp.EmpleadoId = " & id & "
                                            group by Pl.PlanId, Pl.Descripcion
                                                ")
        End Using

        Return dt
    End Function

End Class
