Imports DAL
Imports Entidades

Public Class EmpleadosBLL

    Public Shared Function Guardar(ByVal empleado As Empleados) As Boolean

        Using coneccion As New Coneccion()
            If coneccion.EjecutarComando("Insert into Empleados(Nombres, Direccion, NumCel, Sueldo) Values('" & empleado.Nombres & "' , '" & empleado.Direccion & "' , '" & empleado.NumCel & "' , '" & empleado.Sueldo & "');") > 0 Then

                Dim dt = coneccion.SeleccionarDatos("SELECT MAX(EmpleadoId) as Id from Empleados")
                Dim id = 0

                If dt.Rows.Count > 0 Then
                    id = dt.Rows(0)("Id")
                End If

                empleado.EmpleadoId = id
                Return True
            End If
        End Using
        Return False

    End Function

    Public Shared Function Buscar(ByVal Id As Object) As Empleados

        Dim empleado = New Empleados()

        Using coneccion As New Coneccion()

            Dim dt = coneccion.SeleccionarDatos("Select * from Empleados where EmpleadoId = " & Id & ";")

            If dt.Rows.Count > 0 Then
                empleado.EmpleadoId = dt.Rows(0)("EmpleadoId")
                empleado.Nombres = dt.Rows(0)("Nombres")
                empleado.Direccion = dt.Rows(0)("Direccion")
                empleado.NumCel = dt.Rows(0)("NumCel")
                empleado.Sueldo = dt.Rows(0)("Sueldo")
            End If

            If empleado IsNot Nothing Then
                Return empleado
            End If

        End Using

        Return Nothing

    End Function

    Public Shared Function Eliminar(ByVal id As Integer) As Boolean
        Using coneccion As New Coneccion()
            Try
                If coneccion.EjecutarComando("Delete from Empleados where EmpleadoId =" & id & ";") > 0 Then

                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Shared Function Modificar(ByVal empleado As Empleados) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Update Empleados set Nombres = '" & empleado.Nombres & "', Direccion = '" & empleado.Direccion & "', NumCel = '" & empleado.NumCel & "', Sueldo = '" & empleado.Sueldo & "' where EmpleadoId = " & empleado.EmpleadoId & "") Then
                Return True
            End If

        End Using

        Return False
    End Function

    Public Shared Function GetAllSociosAfiliados() As DataTable
        Dim dt As DataTable = Nothing
        Using coneccion As New Coneccion()
            dt = coneccion.SeleccionarDatos("select Emp.EmpleadoId, Emp.Nombres, Pl.Descripcion as Descripcion
                                            from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det
	                                            on afil.Id = det.Afiliacion
                                            inner join Empleados Emp on Emp.EmpleadoId = afil.Empleado
                                            inner join PlanAhorros Pl on Pl.PlanId = det.PlanAhorro")
            Return dt
        End Using
    End Function

    Public Shared Function GetSocioAfiliado(ByVal condicion As Object) As DataTable
        Dim dt As DataTable = Nothing
        Using coneccion As New Coneccion()
            dt = coneccion.SeleccionarDatos("select Emp.EmpleadoId, Emp.Nombres, Pl.Descripcion
                                            from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det
	                                            on afil.Id = det.Afiliacion
                                            inner join Empleados Emp on Emp.EmpleadoId = afil.Empleado
                                            inner join PlanAhorros Pl on Pl.PlanId = det.PlanAhorro where " & condicion & "")
            Return dt
        End Using
    End Function

End Class
