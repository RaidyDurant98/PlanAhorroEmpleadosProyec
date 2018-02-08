Imports BLL
Imports Entidades

Public Class CargoInteresAcumuladoForm

    Dim CargoInteres As InteresesAcumulados = Nothing
    Dim dt As DataTable = Nothing

    Private Sub CargoInteresAcumuladoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargoInteres = New InteresesAcumulados()
        dt = New DataTable()

        ModificarButton.Enabled = False
        CancelarButton.Enabled = False
        ImprimirButton.Enabled = False
        EliminarButton.Enabled = False

        CargarDetalle()

    End Sub

    Private Sub CargarDetalle()

        dt = BLL.InteresAcumuladoBLL.GetAllSociosAfiliados("'" & FechaDateTimePicker.Value & "' > FechaUltimoCargo")

        CargodeInteresDataGridView.DataSource = dt

        CargodeInteresDataGridView.Columns("EmpleadoId").Visible = False
        CargodeInteresDataGridView.Columns("PlanId").Visible = False
        CargodeInteresDataGridView.Columns("PorcientoDesc").Visible = False
        CargodeInteresDataGridView.Columns("FechaUltimoCargo").Visible = False
        CargodeInteresDataGridView.Columns("Sueldo").Visible = False
        CargodeInteresDataGridView.Columns("Interes").Visible = False
        CargodeInteresDataGridView.Columns("Aporte").Visible = False

        dt.Columns.Add("Ahorro")
        dt.Columns.Add("Cargo Interes")
    End Sub

    Private Sub CalcularInteresAcumulado()

        Dim descuento As Double = 0
        Dim CargoInt As Double = 0
        Dim dt = BLL.InteresAcumuladoBLL.SeleccionarFecha(CargoInteres.IntAcumuladoId)
        Dim Fecha As Date

        If CargoInteres.IntAcumuladoId > 0 Then
            Fecha = dt.Rows(0)("Fecha")
        End If

        'For Each row As DataGridViewRow In CargodeInteresDataGridView.Rows

        '    If CargoInteres.IntAcumuladoId = 0 Then
        '        descuento = (DateDiff(DateInterval.Day, row.Cells("FechaUltimoCargo").Value, FechaDateTimePicker.Value) * (row.Cells("PorcientoDesc").Value) / 100) / 365
        '    Else
        '        descuento = (DateDiff(DateInterval.Day, Fecha, FechaDateTimePicker.Value) * (row.Cells("PorcientoDesc").Value) / 100) / 365
        '    End If

        '    Dim aporte As Double = "0" & row.Cells("Aporte").Value

        '    If CargoInteres.IntAcumuladoId = 0 Then
        '        row.Cells("Ahorro").Value = (row.Cells("Sueldo").Value * Convert.ToInt32(DateDiff(DateInterval.Day, row.Cells("FechaUltimoCargo").Value, FechaDateTimePicker.Value) / 30) + ("0" & row.Cells("Aporte").Value)) * (FormatNumber(descuento, 3))
        '    Else
        '        row.Cells("Ahorro").Value = (row.Cells("Sueldo").Value * Convert.ToInt32(DateDiff(DateInterval.Day, Fecha, FechaDateTimePicker.Value) / 30) + ("0" & row.Cells("Aporte").Value)) * (FormatNumber(descuento, 3))
        '    End If


        '    Dim cargo As Double = row.Cells("Interes").Value / 100 * row.Cells("Ahorro").Value
        '    row.Cells("Cargo Interes").Value = cargo.ToString("N2")
        'Next

        For Each row As DataGridViewRow In CargodeInteresDataGridView.Rows

            Dim ahorro As Double = (((row.Cells("Sueldo").Value * (row.Cells("PorcientoDesc").Value) / 100) / 12) *
            Convert.ToInt32(DateDiff(DateInterval.Day, row.Cells("FechaUltimoCargo").Value, FechaDateTimePicker.Value) / 30) + ("0" & row.Cells("Aporte").Value))
            row.Cells("Ahorro").Value = ahorro.ToString("N2")

            Dim cargo As Double = ((DateDiff(DateInterval.Day, row.Cells("FechaUltimoCargo").Value, FechaDateTimePicker.Value) * (row.Cells("Interes").Value / 100)) / 365) * row.Cells("Ahorro").Value
            row.Cells("Cargo Interes").Value = cargo.ToString("N2")

        Next

    End Sub

    Private Sub CargarInteresButton_Click(sender As Object, e As EventArgs) Handles CargarInteresButton.Click
        CalcularInteresAcumulado()
        TotalLabel.Text = AsignarValorTotalLabel()
    End Sub

    Private Function ValidarGrid() As Boolean

        Dim interruptor As Boolean = False

        If CargodeInteresDataGridView.Rows.Count() < 1 Then
            interruptor = True
        Else
            For Each row As DataGridViewRow In CargodeInteresDataGridView.Rows
                Dim x = "0" & row.Cells("Cargo Interes").Value
                If x = 0 Then
                    interruptor = True
                End If
            Next
        End If

        If interruptor Then
            ErrorProvider.SetError(CargodeInteresDataGridView, "Llene correctamente el cargo")
        End If

        Return interruptor
    End Function

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        If Not ValidarGrid() Then
            If BLL.InteresAcumuladoBLL.Guardar(LlenarInstancia()) Then
                MessageBox.Show("Guardado")
                GuardarButton.Enabled = False
                ModificarButton.Enabled = True
            Else
                MessageBox.Show("Eliminado")
            End If
        End If

    End Sub

    Private Function LlenarDetalle() As List(Of InteresesAcumuladoDetalle)

        CargoInteres.Detalle.Clear()

        For Each row As DataGridViewRow In CargodeInteresDataGridView.Rows
            If row.IsNewRow = False Then
                CargoInteres.Detalle.Add(New Entidades.InteresesAcumuladoDetalle(
                    IIf(CargoInteres.IntAcumuladoId = 0, 1, CargoInteres.IntAcumuladoId),
                    Convert.ToString(row.Cells("EmpleadoId").Value),
                    Convert.ToDouble(row.Cells("PlanId").Value),
                    Convert.ToDouble(row.Cells("Ahorro").Value),
                    Convert.ToDouble(row.Cells("Cargo Interes").Value)
                ))
            End If
        Next

        Return CargoInteres.Detalle
    End Function

    Private Function AsignarValorTotalLabel() As String
        Dim total As Double

        For Each row As DataGridViewRow In CargodeInteresDataGridView.Rows
            total += row.Cells("Cargo Interes").Value
        Next

        Return total
    End Function

    Private Function LlenarInstancia() As InteresesAcumulados
        CargoInteres = New InteresesAcumulados(CargoInteres.IntAcumuladoId, FechaDateTimePicker.Value, AsignarValorTotalLabel(), LlenarDetalle())

        Return CargoInteres
    End Function

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        If (String.IsNullOrEmpty(IntAcumuladoIdMaskedTextBox.Text) = False) Then

            CargoInteres = BLL.InteresAcumuladoBLL.Buscar(IntAcumuladoIdMaskedTextBox.Text)
            LimpiarGrid()

            If CargoInteres.IntAcumuladoId <> 0 Then
                CargarDatosCargoInteres()
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

    Private Sub CargarDatosCargoInteres()
        FechaDateTimePicker.Value = CargoInteres.Fecha
        TotalLabel.Text = CargoInteres.Total.ToString("n2")
        CargarDatosDetalle(CargoInteres.Detalle)
    End Sub

    Private Sub CargarDatosDetalle(detalle As List(Of InteresesAcumuladoDetalle))
        For Each lista As InteresesAcumuladoDetalle In detalle

            Dim empleado = BLL.EmpleadosBLL.Buscar(lista.Empleado)
            Dim planAhorro = BLL.PlanAhorrosBLL.Buscar("PlanId = " & lista.PlanAhorro & "")

            dt.Rows.Add(empleado.EmpleadoId, planAhorro.PlanId, empleado.Nombres, planAhorro.Descripcion, planAhorro.PorcientoDesc,
                        empleado.Sueldo, Date.Now(), planAhorro.Interes, 0, lista.Ahorro, lista.IntAcumulado.ToString("n2"))
            CargodeInteresDataGridView.DataSource = dt
        Next
    End Sub

    Private Sub LimpiarGrid()
        dt = New DataTable
        CargodeInteresDataGridView.DataSource = dt
        CargarDetalle()
    End Sub

    Private Sub FechaDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaDateTimePicker.ValueChanged
        If CargoInteres.IntAcumuladoId = 0 Then
            CargarDetalle()
        End If
    End Sub

    Private Sub Limpiar()
        CargoInteres = New InteresesAcumulados()
        FechaDateTimePicker.Value = Date.Now
        IntAcumuladoIdMaskedTextBox.Clear()
        GuardarButton.Enabled = True
        ModificarButton.Enabled = False
        CancelarButton.Enabled = False
        EliminarButton.Enabled = True
        TotalLabel.Text = "0.00"
        LimpiarGrid()
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        LimpiarGrid()
        CargarDatosCargoInteres()
    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click
        If Not ValidarGrid() Then
            If InteresAcumuladoBLL.Modificar(LlenarInstancia()) Then
                CargoInteres.Detalle = New List(Of InteresesAcumuladoDetalle)
                MessageBox.Show("Cargo de interes modificada con exito.")
            Else
                MessageBox.Show("No se pudo modificar el Cargo de interes.")
            End If
        End If
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        If (String.IsNullOrEmpty(IntAcumuladoIdMaskedTextBox.Text) = False) Then

            CargoInteres = BLL.InteresAcumuladoBLL.Buscar(IntAcumuladoIdMaskedTextBox.Text)
            Dim eliminar As DialogResult = MessageBox.Show("¿Esta seguro de eliminar el cargo?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If eliminar = DialogResult.Yes Then
                If BLL.InteresAcumuladoBLL.Eliminar(CargoInteres.IntAcumuladoId) Then
                    Limpiar()
                    CargoInteres.Detalle = New List(Of InteresesAcumuladoDetalle)
                    MessageBox.Show("cargode interes eliminado con exito.")
                Else
                    MessageBox.Show("No se pudo eliminar el cargo.")
                End If
            End If
        Else
            MessageBox.Show("Por favor digite el id que desea eliminar.")
        End If
    End Sub
End Class