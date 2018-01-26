Imports BLL
Imports Entidades

Public Class PlanAhorrosForm

    Dim PlanAhorro As PlanAhorros = New PlanAhorros

    Private Sub Limpiar()
        PlanAhorro = New PlanAhorros
        PlanIdMaskedTextBox.Clear()
        DescripcionTextBox.Clear()
        PorcientoDescMaskedTextBox.Clear()
        InteresMaskedTextBox.Clear()
        FondoMinimoMaskedTextBox.Clear()
        ErrorProvider.Clear()
    End Sub

    Private Function LlenarInstancia() As PlanAhorros

        PlanAhorro = New PlanAhorros(PlanAhorro.PlanId, DescripcionTextBox.Text, Convert.ToDouble(PorcientoDescMaskedTextBox.Text), Convert.ToDouble(InteresMaskedTextBox.Text), Convert.ToDouble(FondoMinimoMaskedTextBox.Text))
        Return PlanAhorro

    End Function

    Private Function Validar() As Boolean

        Dim interruptor As Boolean = True

        If (String.IsNullOrEmpty(DescripcionTextBox.Text)) Then
            ErrorProvider.SetError(DescripcionTextBox, "Por favor digite la descripcion.")
            interruptor = False
        End If
        If (String.IsNullOrEmpty(PorcientoDescMaskedTextBox.Text)) Then
            ErrorProvider.SetError(PorcientoDescMaskedTextBox, "Por favor digite el porciento de descuento.")
            interruptor = False
        End If
        If (String.IsNullOrEmpty(InteresMaskedTextBox.Text)) Then
            ErrorProvider.SetError(InteresMaskedTextBox, "Por favor digite el interes.")
            interruptor = False
        End If
        If (String.IsNullOrEmpty(FondoMinimoMaskedTextBox.Text)) Then
            ErrorProvider.SetError(FondoMinimoMaskedTextBox, "Por favor digite el el fondo minimo.")
            interruptor = False
        End If

        Return interruptor

    End Function

    Private Sub CargarDatosPlanAhorro()
        DescripcionTextBox.Text = PlanAhorro.Descripcion
        PorcientoDescMaskedTextBox.Text = PlanAhorro.PorcientoDesc
        InteresMaskedTextBox.Text = PlanAhorro.Interes
        FondoMinimoMaskedTextBox.Text = PlanAhorro.FondoMinimo
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        PlanAhorro = BLL.PlanAhorrosBLL.Buscar("Descripcion = '" & DescripcionTextBox.Text & "'")

        If Validar() Then
            If PlanAhorro.PlanId = 0 Or PlanIdMaskedTextBox.Text.Trim() = PlanAhorro.PlanId.ToString Then
                If PlanAhorrosBLL.Guardar(LlenarInstancia()) = True Then
                    PlanIdMaskedTextBox.Text = PlanAhorro.PlanId
                    MessageBox.Show("PLan de ahorro guardado con exito.")
                Else
                    MessageBox.Show("No se pudo guardar el plan de ahorro.")
                End If
            Else
                MessageBox.Show("Existe un plan de ahorro con esa descripcion.")
            End If
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        If (String.IsNullOrEmpty(PlanIdMaskedTextBox.Text) = False) Then

            PlanAhorro = BLL.PlanAhorrosBLL.Buscar("PlanId = " & PlanIdMaskedTextBox.Text)

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

        If (String.IsNullOrEmpty(PlanIdMaskedTextBox.Text) = False) Then

            PlanAhorro = BLL.PlanAhorrosBLL.Buscar("PlanId = " & PlanIdMaskedTextBox.Text)

            If BLL.PlanAhorrosBLL.Eliminar(PlanAhorro.PlanId) Then
                Limpiar()
                MessageBox.Show("PLan Ahorro eliminado con exito.")
            Else
                MessageBox.Show("No se pudo eliminar el plan de ahorro.")
            End If
        Else
            MessageBox.Show("Por favor digite el id que desea eliminar.")
        End If
    End Sub
End Class