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
                    coneccion.EjecutarComando("Insert into RetiroAhorrosDetalle(RetiroId, PlanId, Ahorro, Retiro) values(" & id & ", " & detalle.PlanId & ", " & detalle.Ahorro & ", " & detalle.Retiro & " )")
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
                retiro.Detalle.Add(New RetiroAhorrosDetalle(detalle("RetiroId"), detalle("PlanId"), detalle("Ahorro"), detalle("Retiro")))
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

            dt = coneccion.SeleccionarDatos("select pl.PlanId, Pl.Descripcion, sum((IntAcDet.Ahorro + IntAcDet.IntAcumulado)) as Ahorro
                                            from InteresesAcumulados IntAc inner join InteresesAcumuladoDetalle IntAcDet
                                                on IntAc.IntAcumuladoId = IntAcDet.IntAcumuladoId
                                            inner join Empleados Emp on Emp.EmpleadoId = IntAcDet.Empleado
                                            inner join PlanAhorros Pl on pl.PlanId = IntAcDet.PlanAhorro
                                            where Emp.EmpleadoId = " & id & "
                                            group by pl.PlanId, Pl.Descripcion")
        End Using

        Return dt
    End Function

    Public Shared Function ObtenerRetirosAnteriores(ByVal id As Integer) As DataTable

        Dim dt = New DataTable

        Using coneccion As New Coneccion()

            dt = coneccion.SeleccionarDatos("select ret.Empleado, retDet.PlanId, sum(retDet.Retiro) as Retiro
                                            from RetiroAhorros ret inner join RetiroAhorrosDetalle retDet
	                                            on ret.RetiroId = retDet.RetiroId
                                            where ret.Empleado = " & id & "
                                            group by ret.Empleado, retDet.PlanId")

        End Using

        Return dt
    End Function

    Public Shared Function Eliminar(ByVal id As Integer) As Boolean

        Using coneccion As New Coneccion()
            Try
                If coneccion.EjecutarComando("Delete from RetiroAhorrosDetalle where RetiroId = " & id & "") > 0 Then

                    coneccion.EjecutarComando("Delete from RetiroAhorros where RetiroId =" & id & ";")
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Shared Function Modificar(ByVal retiro As RetiroAhorros) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Update RetiroAhorros set Empleado = '" & retiro.Empleado & "', Fecha = '" & retiro.Fecha & "', RetiroTotal = " & retiro.RetiroTotal & " where RetiroId = " & retiro.RetiroId & "") Then

                coneccion.EjecutarComando("Delete from RetiroAhorrosDetalle where RetiroId = " & retiro.RetiroId & "")

                For Each detalle As RetiroAhorrosDetalle In retiro.Detalle

                    coneccion.EjecutarComando("Insert into RetiroAhorrosDetalle(RetiroId, PlanId, Ahorro, Retiro) 
                                                values(" & detalle.RetiroId & ", " & detalle.PlanId & ", " & detalle.Ahorro & ", " & detalle.Retiro & ")")

                Next
                Return True
            End If

        End Using

        Return False
    End Function

    Public Shared Function GetTotalRetiros(Optional ByVal condicion As String = "") As DataTable
        Dim dt As DataTable = Nothing
        Using coneccion As New Coneccion()
            dt = coneccion.SeleccionarDatos("Select Emp.EmpleadoId, Emp.Nombres, Emp.Direccion, Emp.NumCel, Pl.PlanId, Pl.Descripcion, Sum(retDet.retiro) as Retiro
                                            from RetiroAhorros ret inner join RetiroAhorrosDetalle retDet
	                                            on ret.RetiroId =  retDet.RetiroId
                                            inner join Empleados Emp on Emp.EmpleadoId = ret.Empleado
                                            inner join PlanAhorros Pl on Pl.PlanId = retDet.PlanId
                                            " & condicion & "
                                            group by Emp.EmpleadoId, Emp.Nombres, Emp.Direccion, Emp.NumCel, Pl.PlanId, Pl.Descripcion")
            Return dt
        End Using
    End Function
End Class
