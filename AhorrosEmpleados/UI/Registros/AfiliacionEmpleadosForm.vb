Imports BLL
Imports Entidades

Public Class AfiliacionEmpleadosForm

    Dim Empleado As Empleados = Nothing
    Dim PlanAhorro As PlanAhorros = Nothing
    Dim dt As DataTable = Nothing
    Dim Afiliacion As AfiliacionEmpleados = New AfiliacionEmpleados()

    Private Sub AfiliacionEmpleadosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Empleado = New Empleados()
        PlanAhorro = New PlanAhorros()
        dt = New DataTable()

        Limpiar()
    End Sub

    Private Sub Limpiar()
        IdMaskedTextBox.Clear()
        EmpleadoIdMaskedTextBox.Clear()
        EmpleadoNombreTextBox.Clear()
        PlanAhorroIdMaskedTextBox.Clear()
        ErrorProvider.Clear()
        LimpiarPLanAhorro()
        LimpiarGrid()
    End Sub

    Private Sub LimpiarPLanAhorro()
        DescripcionPlanAhorroTextBox.Clear()
        PorcientoDescMaskedTextBox.Clear()
        InteresMaskedTextBox.Clear()
    End Sub

    Private Function CargarDatosEmpleado() As Empleados

        If Not String.IsNullOrEmpty(EmpleadoIdMaskedTextBox.Text) Then

            Empleado = BLL.EmpleadosBLL.Buscar(EmpleadoIdMaskedTextBox.Text)

            If Empleado.EmpleadoId <> 0 Then
                EmpleadoNombreTextBox.Text = Empleado.Nombres
            Else
                MessageBox.Show("No existe empleado con ese id")
            End If
        Else
            MessageBox.Show("Por favor digite el id del empleado")
        End If

        Return Empleado
    End Function

    Private Function CargarDatosPLanAhorro() As PlanAhorros

        If Not String.IsNullOrEmpty(PlanAhorroIdMaskedTextBox.Text) Then

            PlanAhorro = BLL.PlanAhorrosBLL.Buscar(PlanAhorroIdMaskedTextBox.Text)

            If PlanAhorro.PlanId <> 0 Then
                DescripcionPlanAhorroTextBox.Text = PlanAhorro.Descripcion
                PorcientoDescMaskedTextBox.Text = PlanAhorro.PorcientoDesc
                InteresMaskedTextBox.Text = PlanAhorro.Interes
            Else
                MessageBox.Show("No existe Plan de ahorro con ese id.")
            End If
        Else
            MessageBox.Show("Por favor digite el id del plan de ahorro.")
        End If

        Return PlanAhorro
    End Function

    Private Sub LimpiarGrid()
        dt = New DataTable
        DetalleDataGridView.DataSource = dt
        CrearColumnasGrid()
    End Sub

    Private Sub CrearColumnasGrid()
        dt.Columns.Add("ID")
        dt.Columns.Add("Descripcion")
        dt.Columns.Add("% Descuento")
        dt.Columns.Add("% Interes")
    End Sub

    Private Function ValidarPlanAhorroAgregado() As Boolean

        For Each row As DataGridViewRow In DetalleDataGridView.Rows
            If row.Cells(0).Value = PlanAhorro.PlanId Then
                Return True
            End If
        Next row

        Return False
    End Function

    Private Sub AgregarPLanAhorro()

        If PlanAhorro.PlanId <> 0 Then

            If ValidarPlanAhorroAgregado() = False Then

                dt.Rows.Add(PlanAhorro.PlanId, DescripcionPlanAhorroTextBox.Text, PorcientoDescMaskedTextBox.Text, InteresMaskedTextBox.Text)
                DetalleDataGridView.DataSource = dt
                PlanAhorro = New PlanAhorros()
                LimpiarPLanAhorro()
                PlanAhorroIdMaskedTextBox.Clear()

            Else
                MessageBox.Show("El plan de ahorro ya esta agregado.")
                PlanAhorro = New PlanAhorros()
            End If

        Else
            MessageBox.Show("Por favor busque el plan de ahorro.")
        End If

    End Sub

    Private Function Validar() As Boolean

        Dim interruptor = True

        If Empleado.EmpleadoId < 1 Then
            interruptor = False
            ErrorProvider.SetError(EmpleadoNombreTextBox, "Por favor busque el empleado.")
        End If
        If DetalleDataGridView.Rows.Count <= 1 Then
            interruptor = False
            ErrorProvider.SetError(DetalleDataGridView, "Por favor agrege el o los plan de ahorro(s)")
        End If

        Return interruptor

    End Function

    Private Function GuardarDetalle() As List(Of AfiliacionEmpleadosDetalle)
        For Each row As DataGridViewRow In DetalleDataGridView.Rows
            If row.Cells(1).Value <> "" Then
                Afiliacion.Detalle.Add(New Entidades.AfiliacionEmpleadosDetalle(
                       Convert.ToInt32(row.Cells(0).Value),
                       Convert.ToString(row.Cells(1).Value),
                       Convert.ToDouble(row.Cells(2).Value),
                       Convert.ToDouble(row.Cells(3).Value)
                       ))
            End If
        Next row

        Return Afiliacion.Detalle
    End Function

    Private Function LlenarInstancia() As AfiliacionEmpleados

        Afiliacion = New AfiliacionEmpleados(Convert.ToInt32(EmpleadoIdMaskedTextBox.Text), FechaDateTimePicker.Value, GuardarDetalle())

        Return Afiliacion
    End Function

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub BuscarEmpleadoButton_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoButton.Click
        CargarDatosEmpleado()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Validar() Then
            If AfiliacionEmpleadosBLL.Guardar(LlenarInstancia()) Then
                MessageBox.Show("Afiliacion guardada con exito.")
            Else
                MessageBox.Show("No se pudo guardar la afiliacion.")
            End If
        End If
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click

    End Sub

    Private Sub PlanAhorroIdMaskedTextBox_TextChanged(sender As Object, e As EventArgs)
        LimpiarPLanAhorro()
    End Sub

    Private Sub BuscarPlanAhorroButton_Click(sender As Object, e As EventArgs) Handles BuscarPlanAhorroButton.Click
        CargarDatosPLanAhorro()
    End Sub

    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click
        AgregarPLanAhorro()
    End Sub
End Class