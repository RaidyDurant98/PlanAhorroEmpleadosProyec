Imports DAL
Imports Entidades

Public Class AportesBLL

    Public Shared Function ObtenerPlanAhorro(ByVal id As Integer) As DataTable

        Dim dt = New DataTable

        Using coneccion As New Coneccion()

            dt = coneccion.SeleccionarDatos("select pl.PlanId, Pl.Descripcion
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

    Public Shared Function Guardar(ByVal aporte As Aportes) As Boolean

        Using coneccion As New Coneccion()
            If coneccion.EjecutarComando("Insert into Aportes(Empleado, PlanAhorro, Aporte, Fecha) Values(" & aporte.Empleado & " , " & aporte.PlanAHorro & " , " & aporte.Aporte & ", '" & aporte.Fecha & "')") Then

                Dim dt = coneccion.SeleccionarDatos("SELECT MAX(AporteId) as Id from Aportes")
                Dim id = 0

                If dt.Rows.Count > 0 Then
                    id = dt.Rows(0)("Id")
                End If

                aporte.AporteId = id
                Return True
            End If
        End Using
        Return False

    End Function

    Public Shared Function Buscar(ByVal id As Integer) As Aportes

        Dim aporte = New Aportes()

        Using coneccion As New Coneccion()

            Dim dt = coneccion.SeleccionarDatos("Select * from Aportes where AporteId =" & id & ";")

            If dt.Rows.Count > 0 Then
                aporte.AporteId = dt.Rows(0)("AporteId")
                aporte.Empleado = dt.Rows(0)("Empleado")
                aporte.PlanAHorro = dt.Rows(0)("PlanAhorro")
                aporte.Aporte = dt.Rows(0)("Aporte")
                aporte.Fecha = dt.Rows(0)("Fecha")
            End If

            If aporte IsNot Nothing Then
                Return aporte
            End If

        End Using

        Return Nothing

    End Function

    Public Shared Function Eliminar(ByVal id As Integer) As Boolean

        Using coneccion As New Coneccion()
            Try
                If coneccion.EjecutarComando("Delete from Aportes where AporteId =" & id & ";") > 0 Then

                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Shared Function Modificar(ByVal aporte As Aportes) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Update Aportes set Empleado = " & aporte.Empleado & ", PlanAhorro = " & aporte.PlanAHorro & ", Aporte = " & aporte.Aporte & ", Fecha = '" & aporte.Fecha & "' where AporteId = " & aporte.AporteId & "") Then
                Return True
            End If

        End Using

        Return False
    End Function

    Public Shared Function GetAportes(Optional ByVal condicion As String = "") As DataTable
        Dim dt As DataTable = Nothing
        Using coneccion As New Coneccion()
            dt = coneccion.SeleccionarDatos("select Emp.EmpleadoId, Emp.Nombres, Emp.Direccion, Emp.NumCel, Pl.PlanId, Pl.Descripcion, Ap.Aporte, ap.Fecha, Ap.AporteId
                                             from Empleados Emp inner join Aportes Ap
	                                            on Emp.EmpleadoId = Ap.Empleado 
                                             inner join PlanAhorros Pl on Pl.PlanId = Ap.PlanAhorro " & condicion & "")
            Return dt
        End Using
    End Function

End Class
