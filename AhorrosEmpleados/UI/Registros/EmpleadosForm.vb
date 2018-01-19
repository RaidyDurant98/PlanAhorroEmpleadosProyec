Imports BLL
Imports Entidades

Public Class EmpleadosForm

    Dim Empleados As Empleados = New Empleados()

    Private Sub Limpiar()
        Empleados = New Empleados()
        EmpleadoIdMaskedTextBox.Clear()
        NombresTextBox.Clear()
        DireccionTextBox.Clear()
        NumCelMaskedTextBox.Clear()
        SueldoMaskedTextBox.Clear()
    End Sub

    Private Function LlenarInstancia() As Empleados

        Empleados = New Empleados(Empleados.EmpleadoId, NombresTextBox.Text, DireccionTextBox.Text,
                                  NumCelMaskedTextBox.Text, Convert.ToDouble(SueldoMaskedTextBox.Text))
        Return Empleados

    End Function

    Private Function Validar() As Boolean
        Dim interruptor = True

        If String.IsNullOrEmpty(NombresTextBox.Text) Then
            ErrorProvider.SetError(NombresTextBox, "Por favor digite el nombre.")
            interruptor = False
        End If
        If String.IsNullOrEmpty(DireccionTextBox.Text) Then
            ErrorProvider.SetError(DireccionTextBox, "Por favor digite la direccion.")
            interruptor = False
        End If
        If String.IsNullOrEmpty(NumCelMaskedTextBox.Text) Then
            ErrorProvider.SetError(NumCelMaskedTextBox, "Por favor digite el numero de celular.")
            interruptor = False
        End If
        If String.IsNullOrEmpty(SueldoMaskedTextBox.Text) Then
            ErrorProvider.SetError(SueldoMaskedTextBox, "Por favor digite el sueldo.")
            interruptor = False
        End If

        Return interruptor
    End Function

    Private Sub CargarDatosEmpleados()
        NombresTextBox.Text = Empleados.Nombres
        DireccionTextBox.Text = Empleados.Direccion
        NumCelMaskedTextBox.Text = Empleados.NumCel
        SueldoMaskedTextBox.Text = Empleados.Sueldo
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Validar() = True Then
            If EmpleadosBLL.Guardar(LlenarInstancia()) Then
                MessageBox.Show("Empleado guardado con exito.")
            Else
                MessageBox.Show("No se pudo guardar el empleado.")
            End If
        End If
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        If (String.IsNullOrEmpty(EmpleadoIdMaskedTextBox.Text) = False) Then

            Empleados = BLL.EmpleadosBLL.Buscar(EmpleadoIdMaskedTextBox.Text)

            If Empleados.EmpleadoId <> 0 Then
                CargarDatosEmpleados()
            Else
                MessageBox.Show("No existe plan de ahorro con ese id.")
            End If

        Else
            MessageBox.Show("Por favor digite el id que desea buscar.")
        End If
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        If (String.IsNullOrEmpty(EmpleadoIdMaskedTextBox.Text) = False) Then

            Empleados = BLL.EmpleadosBLL.Buscar(EmpleadoIdMaskedTextBox.Text)

            If BLL.EmpleadosBLL.Eliminar(Empleados.EmpleadoId) Then
                Limpiar()
                MessageBox.Show("Empleado eliminado con exito.")
            Else
                MessageBox.Show("No se pudo eliminar el empleado.")
            End If
        Else
            MessageBox.Show("Por favor digite el id que desea eliminar.")
        End If
    End Sub

End Class