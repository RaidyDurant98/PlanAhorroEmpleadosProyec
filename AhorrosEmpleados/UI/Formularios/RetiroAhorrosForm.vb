Imports Entidades

Public Class RetiroAhorrosForm

    Dim Empleado As Empleados = Nothing
    Dim Retiro As RetiroAhorros = Nothing
    Dim dt As DataTable = Nothing

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
        Retiro = New RetiroAhorros
        dt = New DataTable
    End Sub

    Private Sub CalcularTotalRetiro()

        Dim suma As Double = 0

        For Each row As DataGridViewRow In DetalleDataGridView.Rows
            suma += row.Cells("CantidadRetiro").Value
        Next

        TotalRetiroTextBox.Text = suma.ToString("N2")

    End Sub

    Private Sub DetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DetalleDataGridView.CellEndEdit
        CalcularTotalRetiro()
    End Sub

    Private Function LlenarDetalle() As List(Of RetiroAhorrosDetalle)

        Retiro.Detalle.Clear()

        For Each row As DataGridViewRow In DetalleDataGridView.Rows
            If row.IsNewRow = False Then
                Retiro.Detalle.Add(New Entidades.RetiroAhorrosDetalle(
                    IIf(Retiro.RetiroId = 0, 1, Retiro.RetiroId),
                    Convert.ToInt32(row.Cells("PlanId").Value),
                    Convert.ToDouble(row.Cells("CantidadRetiro").Value)
))
            End If
        Next

        Return Retiro.Detalle
    End Function

    Private Function LlenarInstancia() As RetiroAhorros
        Retiro = New RetiroAhorros(Retiro.RetiroId, Empleado.EmpleadoId, FechaDateTimePicker.Value, TotalRetiroTextBox.Text, LlenarDetalle())

        Return Retiro
    End Function

    Private Function ValidarCantidadRetiro(ByRef indice As Integer) As Boolean

        Dim interruptor As Boolean = True
        Dim list As List(Of Double) = New List(Of Double)
        Dim PlanAhorros As PlanAhorros = New PlanAhorros()
        dt = BLL.RetirosBLL.ObtenerInteresAcumulado(Empleado.EmpleadoId)

        For Each row As DataGridViewRow In DetalleDataGridView.Rows
            list.Add(row.Cells("CantidadRetiro").Value)
        Next

        For index = 0 To dt.Rows.Count - 1
            PlanAhorros = BLL.PlanAhorrosBLL.Buscar(" PlanId = " & dt.Rows(index)("PlanId") & "")

            If PlanAhorros.FondoMinimo > (dt.Rows(index)("Total") - list(index)) Then
                interruptor = False
                If interruptor = False Then
                    indice = index
                End If
            End If
        Next

        Return interruptor

    End Function

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        Dim indice As Integer = New Integer

        If ValidarCantidadRetiro(indice) Then
            If BLL.RetirosBLL.Guardar(LlenarInstancia()) Then
                MessageBox.Show("Retiro registrado")
                GuardarButton.Enabled = False
                ModificarButton.Enabled = True
            Else
                MessageBox.Show("No se pudo reaizar el retiro")
            End If
        Else
            MessageBox.Show("La cantidad que desea retirar en el plan de ahorro " & dt.Rows(indice)("descripcion") & " es mayor que el fondo minimo")
        End If

    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub Limpiar()
        DetalleDataGridView.DataSource = New DataGrid
        FechaDateTimePicker.Value = Date.Now
        RetiroIdMaskedTextBox.Clear()
        EmpleadoIdMaskedTextBox.Clear()
        NombreEmpleadoTextBox.Clear()
        TotalRetiroTextBox.Clear()

        ModificarButton.Enabled = False
        EliminarButton.Enabled = False
        CancelarButton.Enabled = False
        ImprimirButton.Enabled = False
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        If (String.IsNullOrEmpty(RetiroIdMaskedTextBox.Text) = False) Then

            Retiro = BLL.RetirosBLL.Buscar(RetiroIdMaskedTextBox.Text)

            If Retiro.RetiroId <> 0 Then
                CargarDatosRetiro()
                ModificarButton.Enabled = True
                CancelarButton.Enabled = True
                GuardarButton.Enabled = False
                EliminarButton.Enabled = True
            Else
                MessageBox.Show("No existe cargo de interes con ese id.")
            End If

        Else
            MessageBox.Show("Por favor digite el id que desea buscar.")
        End If
    End Sub

    Private Sub CargarDatosRetiro()
        FechaDateTimePicker.Value = Retiro.Fecha
        TotalRetiroTextBox.Text = Retiro.RetiroTotal.ToString("n2")
        CargarDatosDetalle(Retiro.Detalle)
    End Sub

    Private Sub CargarDatosDetalle(detalle As List(Of RetiroAhorrosDetalle))
        For Each lista As RetiroAhorrosDetalle In detalle

            Dim planAhorro = BLL.PlanAhorrosBLL.Buscar("PlanId = " & lista.PlanId & "")

            dt.Rows.Add(lista.PlanId, planAhorro.Descripcion, lista.Retiro)

            DetalleDataGridView.DataSource = dt
        Next
    End Sub
End Class