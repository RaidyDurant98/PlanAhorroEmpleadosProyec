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
                    Dim sql As String = "Insert into InteresesAcumuladoDetalle(IntAcumuladoId, Empleado, PlanAhorro, IntAcumulado, Fecha) values(" & id & ", " & detalle.Empleado & ", " & detalle.PlanAhorro & ", " & detalle.IntAcumulado & ", '" & interesAcumulado.Fecha & "')"
                    coneccion.EjecutarComando(sql)
                    coneccion.EjecutarComando("update AfiliacionEmpleadosDetalle set FechaUltimoCargo = IntDet.Fecha 
                                                from InteresesAcumulados IntAc inner join InteresesAcumuladoDetalle IntDet 
	                                                on IntAc.IntAcumuladoId = IntDet.IntAcumuladoId
                                                inner join Empleados Emp on Emp.EmpleadoId = IntDet.Empleado
                                                inner join PlanAhorros Pl on Pl.PlanId = IntDet.PlanAhorro
                                                where DATEDIFF(day, FechaUltimoCargo, IntAc.Fecha) > 0 and IntAc.IntAcumuladoId = " & id & "")
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

    Public Shared Function GetAllSociosAfiliados(ByVal condicion As String) As DataTable
        Dim dt As DataTable = Nothing
        Using coneccion As New Coneccion()
            dt = coneccion.SeleccionarDatos("select Emp.EmpleadoId, Pl.PlanId, Emp.Nombres, Pl.Descripcion, Pl.PorcientoDesc, Emp.Sueldo, det.FechaUltimoCargo, Pl.Interes, Ap.Aporte
                                            from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det 
	                                            on afil.Id = det.Afiliacion
                                            inner join Empleados Emp on Emp.EmpleadoId = afil.Empleado
                                            inner join PlanAhorros Pl on Pl.PlanId = det.PlanAhorro
                                            left join Aportes Ap on Emp.EmpleadoId = Ap.Empleado And Pl.PlanId = Ap.PlanAhorro
                                            where " & condicion & "")
            Return dt
        End Using
    End Function

    Public Shared Function GetFechaCargoInteres() As DataTable
        Dim dt As DataTable = Nothing
        Using coneccion As New Coneccion()
            dt = coneccion.SeleccionarDatos("select intAc.IntAcumuladoId, intAc.Fecha
                                            from InteresesAcumulados intAc inner join InteresesAcumuladoDetalle intAcDet
	                                            on intAc.IntAcumuladoId = intAcDet.IntAcumuladoId")
            Return dt
        End Using
    End Function

End Class
