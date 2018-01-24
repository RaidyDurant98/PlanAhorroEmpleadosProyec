Imports Entidades

Public Class AportesVoluntariosForm

    Dim Empleado As Empleados = Nothing
    Dim Aporte As Aportes = Nothing

    Private Sub AportesVoluntariosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Empleado = New Empleados
        Aporte = New Aportes
    End Sub

    Private Sub Limpiar()
        AporteIdMaskedTextBox.Clear()
        EmpleadoIdMaskedTextBox.Clear()
        NombresEmpleadoTextBox.Clear()
        AporteMaskedTextBox.Clear()
        PlanAhorroComboBox.DataSource = Nothing
        Aporte = New Aportes()
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

    Private Sub LlenarCombo(id As Integer)
        PlanAhorroComboBox.DataSource = BLL.AportesBLL.ObtenerPlanAhorro(id)
        PlanAhorroComboBox.DisplayMember = "Descripcion"
        PlanAhorroComboBox.ValueMember = "PlanId"
    End Sub

    Private Function Validar() As Boolean

        Dim interruptor = True

        If String.IsNullOrEmpty(NombresEmpleadoTextBox.Text) Then
            interruptor = False
            ErrorProvider.SetError(NombresEmpleadoTextBox, "Por favor busque el empleado")
        End If
        If String.IsNullOrEmpty(AporteMaskedTextBox.Text) Then
            interruptor = False
            ErrorProvider.SetError(AporteMaskedTextBox, "Por favor digite el aporte")
        End If

        Return interruptor
    End Function

    Private Function LlenarInstancia() As Entidades.Aportes

        Aporte = New Aportes(Aporte.AporteId, Empleado.EmpleadoId, PlanAhorroComboBox.SelectedValue, AporteMaskedTextBox.Text.Trim())
        Return Aporte
    End Function

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub BuscarEmpleadoButton_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoButton.Click
        CargarDatosEmpleado()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        If Validar() Then
            If BLL.AportesBLL.Guardar(LlenarInstancia()) Then
                AporteIdMaskedTextBox.Text = Aporte.AporteId
                MessageBox.Show("Aporte guardado con exito.")
            Else
                MessageBox.Show("No se pudo guardar el aporte.")
            End If
        End If

    End Sub

    Private Sub CargarDatosAportes()
        Dim planAhorro = BLL.PlanAhorrosBLL.Buscar(" PlanId = " & Aporte.PlanAhorro & "")
        Empleado = BLL.EmpleadosBLL.Buscar(Aporte.Empleado)

        EmpleadoIdMaskedTextBox.Text = Empleado.EmpleadoId
        LlenarCombo(Empleado.EmpleadoId)
        NombresEmpleadoTextBox.Text = Empleado.Nombres
        PlanAhorroComboBox.SelectedValue = Aporte.PLanAhorro
        AporteMaskedTextBox.Text = Aporte.Aporte
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        If String.IsNullOrEmpty(AporteIdMaskedTextBox.Text) = False Then
            Aporte = BLL.AportesBLL.Buscar(AporteIdMaskedTextBox.Text)

            If Aporte.AporteId <> 0 Then
                CargarDatosAportes()
            Else
                MessageBox.Show("No existe aporte con ese id.")
            End If
        Else
            MessageBox.Show("Digite el id que desea buscar.")
        End If

    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        If (String.IsNullOrEmpty(AporteIdMaskedTextBox.Text) = False) Then

            Aporte = BLL.AportesBLL.Buscar(AporteIdMaskedTextBox.Text)

            If BLL.AportesBLL.Eliminar(Aporte.AporteId) Then
                Limpiar()
                MessageBox.Show("Aporte eliminado con exito.")
            Else
                MessageBox.Show("No se pudo eliminar el Aporte.")
            End If
        Else
            MessageBox.Show("Por favor digite el id que desea eliminar.")
        End If
    End Sub
End Class