Imports DAL
Imports Entidades

Public Class PlanAhorrosBLL

    Public Shared Function Guardar(ByVal planAhorro As PlanAhorros) As Boolean

        Using coneccion As New Coneccion()

            If planAhorro.PlanId = 0 Then
                If coneccion.EjecutarComando("Insert into PlanAhorros(Descripcion, PorcientoDesc) Values('" & planAhorro.Descripcion & "' , '" & planAhorro.PorcientoDesc & "');") > 0 Then
                    Return True
                End If
            Else
                Modificar(planAhorro)
                Return True
            End If
        End Using

        Return False

    End Function

    Public Shared Function Buscar(ByVal id As Integer) As PlanAhorros

        Dim planAhorro = New PlanAhorros()

        Using coneccion As New Coneccion()

            Dim dt = coneccion.SeleccionarDatos("Select * from PLanAhorros where PlanId =" & id & ";")

            If dt.Rows.Count > 0 Then
                planAhorro.PlanId = dt.Rows(0)("PlanId")
                planAhorro.Descripcion = dt.Rows(0)("Descripcion")
                planAhorro.PorcientoDesc = dt.Rows(0)("PorcientoDesc")
            End If

            If planAhorro IsNot Nothing Then
                Return planAhorro
            End If

        End Using

        Return Nothing

    End Function

    Public Shared Function Eliminar(ByVal id As Integer) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Delete from PlanAhorros where PLanId =" & id & ";") > 0 Then

                Return True
            End If

        End Using

        Return False
    End Function

    Public Shared Function Modificar(ByVal planAhorro As PlanAhorros) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Update PlanAhorros set Descripcion = '" & planAhorro.Descripcion & "', PorcientoDesc = '" & planAhorro.PorcientoDesc & "' where PlanId = '" & planAhorro.PlanId & "'") Then
                Return True
            End If

        End Using

        Return False
    End Function

    Public Shared Function GetList(ByVal comandoString As String) As DataTable
        Dim dt As DataTable = Nothing
        Using coneccion As New Coneccion()
            dt = coneccion.SeleccionarDatos(comandoString)
            Return dt
        End Using

    End Function

End Class
