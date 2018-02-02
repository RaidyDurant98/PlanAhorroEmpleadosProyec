Imports Entidades

Public Class CargoInteresAcumuladoForm

    Dim CargoInteres As InteresesAcumulados = Nothing
    Dim dt As DataTable = Nothing

    Private Sub CargoInteresAcumuladoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargoInteres = New InteresesAcumulados()
        dt = New DataTable()

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

        dt.Columns.Add("Cargo Interes")
    End Sub

    Private Sub CalcularInteresAcumulado()
        For Each row As DataGridViewRow In CargodeInteresDataGridView.Rows
            Dim desc As Double = (DateDiff(DateInterval.Day, row.Cells("FechaUltimoCargo").Value, FechaDateTimePicker.Value) * (row.Cells("PorcientoDesc").Value) / 100) / 365
            Dim aporte As Double = "0" & row.Cells("Aporte").Value
            Dim cargoInteres As Double = ((row.Cells("Sueldo").Value * Convert.ToInt32(DateDiff(DateInterval.Day, row.Cells("FechaUltimoCargo").Value, FechaDateTimePicker.Value)) / 30) + ("0" & row.Cells("Aporte").Value)) * (desc)
            Dim cargo As Double = cargoInteres + ((row.Cells("Interes").Value / 100) * cargoInteres)
            row.Cells("Cargo Interes").Value = cargo.ToString("N2")
        Next
    End Sub

    Private Sub CargarInteresButton_Click(sender As Object, e As EventArgs) Handles CargarInteresButton.Click
        CalcularInteresAcumulado()
        TotalLabel.Text = AsignarValorTotalLabel()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If BLL.InteresAcumuladoBLL.Guardar(LlenarInstancia()) Then
            MessageBox.Show("Guardado")
        Else
            MessageBox.Show("Eliminado")
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

            If CargoInteres.IntAcumuladoId <> 0 Then
                CargarDatosCargoInteres()
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
                        empleado.Sueldo, Date.Now(), planAhorro.Interes, 0, lista.IntAcumulado.ToString("n2"))
            CargodeInteresDataGridView.DataSource = dt
        Next
    End Sub

    Private Sub LimpiarGrid()
        dt = New DataTable
        CargodeInteresDataGridView.DataSource = dt
    End Sub

    Private Sub FechaDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaDateTimePicker.ValueChanged
        CargarDetalle()
    End Sub
End Class