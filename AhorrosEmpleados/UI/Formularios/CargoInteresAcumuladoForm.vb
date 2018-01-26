Imports Entidades

Public Class CargoInteresAcumuladoForm

    Dim Empleado As Empleados = Nothing

    Private Sub CargoInteresAcumuladoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Empleado = New Empleados()
    End Sub

    Private Sub LlenarCombo(id As Integer)
        PlanAhorroComboBox.DataSource = BLL.AportesBLL.ObtenerPlanAhorro(id)
        PlanAhorroComboBox.DisplayMember = "Descripcion"
        PlanAhorroComboBox.ValueMember = "PlanId"
    End Sub

    Private Function CargarDatosEmpleado() As Empleados

        If Not String.IsNullOrEmpty(EmpleadoIdMaskedTextBox.Text) Then

            Empleado = BLL.EmpleadosBLL.Buscar(EmpleadoIdMaskedTextBox.Text)

            If Empleado.EmpleadoId <> 0 Then
                NombresEmpleadoTextBox.Text = Empleado.Nombres
                LlenarCombo(Empleado.EmpleadoId)
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

End Class