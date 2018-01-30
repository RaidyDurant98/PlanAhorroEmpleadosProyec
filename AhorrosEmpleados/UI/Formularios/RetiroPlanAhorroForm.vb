Imports Entidades

Public Class RetiroPlanAhorroForm

    Dim Empleado As Empleados = Nothing

    Private Function CargarDatosEmpleado() As Empleados

        If Not String.IsNullOrEmpty(EmpleadoIdMaskedTextBox.Text) Then

            Empleado = BLL.EmpleadosBLL.Buscar(EmpleadoIdMaskedTextBox.Text)

            If Empleado.EmpleadoId <> 0 Then
                NombreEmpleadoTextBox.Text = Empleado.Nombres
                DetalleDataGridView.DataSource = BLL.AportesBLL.ObtenerPlanAhorro(Empleado.EmpleadoId)
            Else
                MessageBox.Show("No existe empleado con ese id")
            End If
        Else
            MessageBox.Show("Por favor digite el id del empleado")
        End If

        Return Empleado
    End Function

    Private Sub BuscarEmpleadoButton_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoButton.Click
        CargarDatosEmpleado()
    End Sub

    Private Sub RetiroPlanAhorroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Empleado = New Empleados
    End Sub
End Class