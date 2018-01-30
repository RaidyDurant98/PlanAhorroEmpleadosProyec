Imports Entidades

Public Class AportesVoluntariosForm

    Dim Empleado As Empleados = Nothing
    Dim Aporte As Aportes = Nothing

    Private Sub AportesVoluntariosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Empleado = New Empleados
        Aporte = New Aportes

        ModificarButton.Enabled = False
        CancelarButton.Enabled = False
        ImprimirButton.Enabled = False
        EliminarButton.Enabled = False
    End Sub

    Private Sub Limpiar()
        AporteIdMaskedTextBox.Clear()
        EmpleadoIdMaskedTextBox.Clear()
        NombresEmpleadoTextBox.Clear()
        AporteMaskedTextBox.Clear()
        PlanAhorroComboBox.DataSource = Nothing
        GuardarButton.Enabled = True
        ModificarButton.Enabled = False
        CancelarButton.Enabled = False
        EliminarButton.Enabled = False
        FechaDateTimePicker.Value = Date.Now
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

        Aporte = New Aportes(Aporte.AporteId, Empleado.EmpleadoId, PlanAhorroComboBox.SelectedValue, AporteMaskedTextBox.Text.Trim(), FechaDateTimePicker.Value)
        Return Aporte
    End Function

    Private Sub BuscarEmpleadoButton_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoButton.Click
        CargarDatosEmpleado()
    End Sub

    Private Sub CargarDatosAportes()
        Dim planAhorro = BLL.PlanAhorrosBLL.Buscar(" PlanId = " & Aporte.PlanAHorro & "")
        Empleado = BLL.EmpleadosBLL.Buscar(Aporte.Empleado)

        EmpleadoIdMaskedTextBox.Text = Empleado.EmpleadoId
        LlenarCombo(Empleado.EmpleadoId)
        NombresEmpleadoTextBox.Text = Empleado.Nombres
        PlanAhorroComboBox.SelectedValue = Aporte.PlanAHorro
        AporteMaskedTextBox.Text = Aporte.Aporte
        FechaDateTimePicker.Value = Aporte.Fecha
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        If String.IsNullOrEmpty(AporteIdMaskedTextBox.Text) = False Then
            Aporte = BLL.AportesBLL.Buscar(AporteIdMaskedTextBox.Text)

            If Aporte.AporteId <> 0 Then
                CargarDatosAportes()
                GuardarButton.Enabled = False
                ModificarButton.Enabled = True
                CancelarButton.Enabled = True
                EliminarButton.Enabled = True
            Else
                MessageBox.Show("No existe aporte con ese id.")
            End If
        Else
            MessageBox.Show("Digite el id que desea buscar.")
        End If

    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click
        If Validar() Then
            If BLL.AportesBLL.Modificar(LlenarInstancia()) Then
                AporteIdMaskedTextBox.Text = Aporte.AporteId
                MessageBox.Show("Aporte modificado con exito.")
            Else
                MessageBox.Show("No se pudo modificar el aporte.")
            End If
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Validar() Then
            If BLL.AportesBLL.Guardar(LlenarInstancia()) Then
                AporteIdMaskedTextBox.Text = Aporte.AporteId
                MessageBox.Show("Aporte guardado con exito.")
                GuardarButton.Enabled = False
                ModificarButton.Enabled = True
            Else
                MessageBox.Show("No se pudo guardar el aporte.")
            End If
        End If
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        If (String.IsNullOrEmpty(AporteIdMaskedTextBox.Text) = False) Then

            Aporte = BLL.AportesBLL.Buscar(AporteIdMaskedTextBox.Text)

            Dim eliminar As DialogResult = MessageBox.Show("¿Esta seguro de eliminar el aporte?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If eliminar = DialogResult.Yes Then
                If BLL.AportesBLL.Eliminar(Aporte.AporteId) Then
                    Limpiar()
                    MessageBox.Show("Aporte eliminado con exito.")
                Else
                    MessageBox.Show("No se pudo eliminar el Aporte.")
                End If
            End If
        Else
            MessageBox.Show("Por favor digite el id que desea eliminar.")
        End If
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        CargarDatosAportes()
    End Sub

    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles SalirButton.Click
        Me.Hide()
    End Sub
End Class