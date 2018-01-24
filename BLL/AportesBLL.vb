Imports DAL
Imports Entidades

Public Class AportesBLL

    Public Shared Function ObtenerPlanAhorro(ByVal id As Integer) As DataTable

        Dim dt = New DataTable

        Using coneccion As New Coneccion()

            dt = coneccion.SeleccionarDatos("Select pl.PlanId, pl.Descripcion 
                                                from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det
	                                                 on afil.Id = det.Afiliacion 
                                                inner join PlanAhorros pl on pl.PlanId = det.PlanAhorro
                                                where afil.Empleado = " & id & "")
        End Using

        Return dt
    End Function

    Public Shared Function Guardar(ByVal aporte As Aportes) As Boolean

        Using coneccion As New Coneccion()
            If aporte.AporteId = 0 Then
                If coneccion.EjecutarComando("Insert into Aportes(Empleado, PlanAhorro, Aporte) Values(" & aporte.Empleado & " , " & aporte.PlanAHorro & " , " & aporte.Aporte & ")") Then

                    Dim dt = coneccion.SeleccionarDatos("SELECT MAX(AporteId) as Id from Aportes")
                    Dim id = 0

                    If dt.Rows.Count > 0 Then
                        id = dt.Rows(0)("Id")
                    End If

                    aporte.AporteId = id
                    Return True
                End If
            Else
                Modificar(aporte)
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
            End If

            If aporte IsNot Nothing Then
                Return aporte
            End If

        End Using

        Return Nothing

    End Function

    Public Shared Function Eliminar(ByVal id As Integer) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Delete from Aportes where AporteId =" & id & ";") > 0 Then

                Return True
            End If

        End Using

        Return False
    End Function

    Public Shared Function Modificar(ByVal aporte As Aportes) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Update Aportes set Empleado = " & aporte.Empleado & ", PlanAhorro = " & aporte.PlanAHorro & ", Aporte = " & aporte.Aporte & "") Then
                Return True
            End If

        End Using

        Return False
    End Function

End Class
