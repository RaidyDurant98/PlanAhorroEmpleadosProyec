Imports Entidades

Public Class RetiroAhorrosForm

    Dim Empleado As Empleados = Nothing

    Private Function CargarDatosEmpleado() As Empleados

        If Not String.IsNullOrEmpty(EmpleadoIdMaskedTextBox.Text) Then

            Empleado = BLL.EmpleadosBLL.Buscar(EmpleadoIdMaskedTextBox.Text)

            If Empleado.EmpleadoId <> 0 Then
                NombreEmpleadoTextBox.Text = Empleado.Nombres
                DetalleDataGridView.DataSource = BLL.RetirosBLL.ObtenerInteresAcumulado(Empleado.EmpleadoId)
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

    Private Sub RetiroAhorrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Empleado = New Empleados
    End Sub

    Private Sub CalcularTotalRetiro()

        Dim suma As Double = 0

        For Each row As DataGridViewRow In DetalleDataGridView.Rows
            suma += row.Cells("Cantidad").Value
        Next

        TotalRetiroTextBox.Text = suma.ToString("N2")

    End Sub

    Private Sub DetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DetalleDataGridView.CellEndEdit
        CalcularTotalRetiro()
    End Sub
End Class