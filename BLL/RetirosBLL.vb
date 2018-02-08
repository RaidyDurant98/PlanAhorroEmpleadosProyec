Imports DAL
Imports Entidades

Public Class RetirosBLL

    Public Shared Function Guardar(ByVal retiro As RetiroAhorros) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Insert into RetiroAhorros(Empleado, Fecha, RetiroTotal) Values(" & retiro.Empleado & " , '" & retiro.Fecha & "' , " & retiro.RetiroTotal & ")") > 0 Then
                Dim dt = coneccion.SeleccionarDatos("SELECT MAX(RetiroId) as Id from RetiroAhorros")
                Dim id = 0

                If dt.Rows.Count > 0 Then
                    id = dt.Rows(0)("Id")
                End If

                For Each detalle As RetiroAhorrosDetalle In retiro.Detalle
                    coneccion.EjecutarComando("Insert into RetiroAhorrosDetalle(RetiroId, PlanId, Retiro) values(" & id & ", " & detalle.PlanId & ", " & detalle.Retiro & " )")
                    coneccion.EjecutarComando("update InteresesAcumuladoDetalle set IntAcumulado = IntAcDet.IntAcumulado - " & detalle.Retiro & "
                                                from InteresesAcumulados IntAc inner join InteresesAcumuladoDetalle IntAcDet
                                                    on IntAc.IntAcumuladoId = IntAcDet.IntAcumuladoId
                                                inner join Empleados Emp on Emp.EmpleadoId = IntAcDet.Empleado
                                                inner join PlanAhorros Pl on pl.PlanId = IntAcDet.PlanAhorro
                                               where Emp.EmpleadoId = " & id & "")
                    'preguntar a enel sobre este update que me da problema en la tabla de cargo de intereses

                Next
                retiro.RetiroId = id

                Return True
            End If
        End Using

        Return False

    End Function

    Public Shared Function Buscar(ByVal id As Integer) As RetiroAhorros

        Dim retiro = New RetiroAhorros()

        Using coneccion As New Coneccion()

            Dim dt = coneccion.SeleccionarDatos("Select * from RetiroAhorros where RetiroId =" & id & ";")

            If dt.Rows.Count > 0 Then
                retiro.RetiroId = dt.Rows(0)("RetiroId")
                retiro.Empleado = dt.Rows(0)("Empleado")
                retiro.Fecha = dt.Rows(0)("Fecha")
                retiro.RetiroTotal = dt.Rows(0)("RetiroTotal")
            End If

            dt = coneccion.SeleccionarDatos("select * from RetiroAhorrosDetalle where RetiroId = " & retiro.RetiroId & "")
            For Each detalle As DataRow In dt.Rows
                retiro.Detalle.Add(New RetiroAhorrosDetalle(detalle("RetiroId"), detalle("PlanId"), detalle("Retiro")))
            Next

            If retiro IsNot Nothing Then
                Return retiro
            End If

        End Using

        Return Nothing

    End Function

    Public Shared Function ObtenerInteresAcumulado(ByVal id As Integer) As DataTable

        Dim dt = New DataTable

        Using coneccion As New Coneccion()

            dt = coneccion.SeleccionarDatos("select pl.PlanId, Pl.Descripcion, IntAcDet.Ahorro
                                            from InteresesAcumulados IntAc inner join InteresesAcumuladoDetalle IntAcDet
                                             on IntAc.IntAcumuladoId = IntAcDet.IntAcumuladoId
                                            inner join Empleados Emp on Emp.EmpleadoId = IntAcDet.Empleado
                                            inner join PlanAhorros Pl on pl.PlanId = IntAcDet.PlanAhorro
                                            where Emp.EmpleadoId = " & id & "
                                            ")
        End Using

        Return dt
    End Function
End Class
