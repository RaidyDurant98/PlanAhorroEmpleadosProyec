Imports Entidades

Public Class AfiliacionEmpleadosForm

    Dim Empleado As Empleados = Nothing
    Dim PlanAhorro As PlanAhorros = Nothing
    Dim dt As DataTable = Nothing

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

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub BuscarEmpleadoButton_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoButton.Click
        CargarDatosEmpleado()
    End Sub

    Private Sub BuscarPlanAhorroButton_Click(sender As Object, e As EventArgs) Handles BuscarPlanAhorroButton.Click
        CargarDatosPLanAhorro()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        For Each row As DataGridViewRow In DetalleDataGridView.Rows

        Next row

    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click

    End Sub

    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click
        AgregarPLanAhorro()
    End Sub

    Private Sub PlanAhorroIdMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlanAhorroIdMaskedTextBox.TextChanged
        LimpiarPLanAhorro()
    End Sub

End Class