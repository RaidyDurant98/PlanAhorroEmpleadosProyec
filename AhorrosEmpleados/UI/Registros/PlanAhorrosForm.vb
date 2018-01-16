Imports BLL
Imports Entidades

Public Class PlanAhorrosForm

    Dim PlanAhorro As PlanAhorros = New PlanAhorros

    Private Sub Limpiar()

        PlanAhorro = New PlanAhorros
        PlanIdTextBox.Clear()
        DescripcionTextBox.Clear()
        PorcientoDescTextBox.Clear()
    End Sub

    Private Function LlenarInstancia() As PlanAhorros

        PlanAhorro = New PlanAhorros(PlanAhorro.PlanId, DescripcionTextBox.Text, Convert.ToDouble(PorcientoDescTextBox.Text))
        Return PlanAhorro

    End Function

    Private Function Validar() As Boolean

        Dim interruptor As Boolean = True

        If (String.IsNullOrEmpty(DescripcionTextBox.Text)) Then
            ErrorProvider.SetError(DescripcionTextBox, "Por favor digite la descripcion.")
            interruptor = False
        End If
        If (String.IsNullOrEmpty(PorcientoDescTextBox.Text)) Then
            ErrorProvider.SetError(PorcientoDescTextBox, "Por favor digite el porciento de descuento.")
            interruptor = False
        End If

        Return interruptor

    End Function

    Private Sub CargarDatosPlanAhorro()
        DescripcionTextBox.Text = PlanAhorro.Descripcion
        PorcientoDescTextBox.Text = PlanAhorro.PorcientoDesc
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        If Validar() = True Then
            If PlanAhorrosBLL.Guardar(LlenarInstancia()) = True Then
                MessageBox.Show("PLan de ahorro guardado con exito.")
            Else
                MessageBox.Show("No se pudo guardar el plan de ahorro.")
            End If
        End If

    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        If (String.IsNullOrEmpty(PlanIdTextBox.Text) = False) Then

            PlanAhorro = BLL.PlanAhorrosBLL.Buscar(PlanIdTextBox.Text)

            If PlanAhorro.PlanId <> 0 Then
                CargarDatosPlanAhorro()
            Else
                MessageBox.Show("No existe plan de ahorro con ese id.")
            End If

        Else
            MessageBox.Show("Por favor digite el id que desea buscar.")
        End If

    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click

        If (String.IsNullOrEmpty(PlanIdTextBox.Text) = False) Then

            PlanAhorro = BLL.PlanAhorrosBLL.Buscar(PlanIdTextBox.Text)

            If BLL.PlanAhorrosBLL.Eliminar(PlanAhorro.PlanId) Then
                MessageBox.Show("PLan Ahorro eliminado con exito.")
            Else
                MessageBox.Show("No se pudo eliminar el plan de ahorro.")
            End If
        Else
            MessageBox.Show("Por favor digite el id que desea eliminar.")
        End If
    End Sub
End Class