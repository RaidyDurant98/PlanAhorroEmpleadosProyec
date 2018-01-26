Imports DAL
Imports Entidades

Public Class InteresAcumuladoBLL

    Public Shared Function Guardar(ByVal interesAcumulado As InteresesAcumulados) As Boolean

        Using coneccion As New Coneccion()
            If coneccion.EjecutarComando("Insert into InteresesAcumulados(Empleado, PlanAhorro, Fecha, IntAcumulado) 
                                        Values(" & interesAcumulado.Empleado & " , " & interesAcumulado.PlanAhorro & " , 
                                            " & interesAcumulado.Fecha & ", " & interesAcumulado.IntAcumulado & ")") Then

                Dim dt = coneccion.SeleccionarDatos("SELECT MAX(IntAcumuladoId) as Id from InteresesAcumulados")
                Dim id = 0

                If dt.Rows.Count > 0 Then
                    id = dt.Rows(0)("Id")
                End If

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
                interesAcumulado.Empleado = dt.Rows(0)("Empleado")
                interesAcumulado.PlanAhorro = dt.Rows(0)("PlanAhorro")
                interesAcumulado.Fecha = dt.Rows(0)("Fecha")
                interesAcumulado.IntAcumulado = dt.Rows(0)("IntAcumulado")
            End If

            If interesAcumulado IsNot Nothing Then
                Return interesAcumulado
            End If

        End Using

        Return Nothing

    End Function

End Class
