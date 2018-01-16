Imports System.Data.SqlClient

Public Class Coneccion : Implements IDisposable

    Private Coneccion As SqlConnection

    Public Sub Dispose() Implements IDisposable.Dispose
        Coneccion = Nothing
    End Sub

    Private Sub AbrirConeccion()
        Coneccion = New SqlConnection("server = Raidy-PC\SQLEXPRESS; database = PlanAhorroDb; integrated security = true")
        Coneccion.Open()
    End Sub

    Public Function EjecutarComando(ByVal comandoString As String) As Integer

        AbrirConeccion()

        Dim comando = New SqlCommand(comandoString, Coneccion)
        Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
        Coneccion.Close()

        Return filasAfectadas

    End Function

    Public Function SeleccionarDatos(ByVal comandoString As String) As DataTable

        Dim dataTable As DataTable = Nothing

        AbrirConeccion()

        Dim comando = New SqlDataAdapter(comandoString, Coneccion)
        dataTable = New DataTable("DataTable")
        comando.Fill(dataTable)

        Coneccion.Close()

        Return dataTable

    End Function

End Class
