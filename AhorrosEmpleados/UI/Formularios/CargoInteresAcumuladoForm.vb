Imports Entidades

Public Class CargoInteresAcumuladoForm

    Dim CargoInteres As InteresesAcumulados = Nothing
    Dim dt As DataTable = Nothing

    Private Sub CargoInteresAcumuladoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargoInteres = New InteresesAcumulados()
        dt = New DataTable()

        CargodeInteresDataGridView.AutoGenerateColumns = False
        CargarDetalle()

        HacerColumnasInvisibles()
    End Sub

    Private Sub HacerColumnasInvisibles()
        CargodeInteresDataGridView.Columns("Sueldo").Visible = False
        CargodeInteresDataGridView.Columns("PorcientoDesc").Visible = False
        CargodeInteresDataGridView.Columns("FechaInteres").Visible = False
        CargodeInteresDataGridView.Columns("Interes").Visible = False
        CargodeInteresDataGridView.Columns("Aporte").Visible = False
        CargodeInteresDataGridView.Columns("EmpleadoId").Visible = False
        CargodeInteresDataGridView.Columns("PlanAhorroId").Visible = False
        CargodeInteresDataGridView.Columns("IntAcumuladoId").Visible = False
    End Sub

    Public Function MonthDifference(lValue As DateTime, rValue As DateTime) As Integer
        Return Math.Abs((lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year))
    End Function

    Private Sub CargarDetalle()
        CargodeInteresDataGridView.DataSource = BLL.InteresAcumuladoBLL.GetAllSociosAfiliados()
    End Sub

    Private Sub CargarInteresAcumulado()
        For Each row As DataGridViewRow In CargodeInteresDataGridView.Rows
            Dim desc = (row.Cells(4).Value * ("0.0" & row.Cells(3).Value)) / 12
            Dim aporte = "0" & row.Cells(6).Value
            Dim cargoInteres = ((row.Cells(2).Value * row.Cells(4).Value) + ("0" & row.Cells(6).Value)) * (desc)
            row.Cells(7).Value = cargoInteres + (("0.0" & row.Cells(5).Value) * cargoInteres)
            row.Cells(10).Value = 1
            'preguntar a Enel si el interes del banco se calcula por el interes acumulado o por el descuento total
        Next
    End Sub

    Private Sub CargarInteresButton_Click(sender As Object, e As EventArgs) Handles CargarInteresButton.Click
        CargarInteresAcumulado()
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
                    Convert.ToInt32(row.Cells(10).Value),
                    Convert.ToString(row.Cells(8).Value),
                    Convert.ToDouble(row.Cells(9).Value),
                    Convert.ToInt32(row.Cells(7).Value)
                ))
            End If
        Next

        Return CargoInteres.Detalle
    End Function

    Private Function LlenarInstancia() As InteresesAcumulados

        CargoInteres = New InteresesAcumulados(CargoInteres.IntAcumuladoId, FechaDateTimePicker.Value, TotalLabel.Text, LlenarDetalle())

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
        TotalLabel.Text = CargoInteres.Total
        CargarDatosDetalle(CargoInteres.Detalle)
    End Sub

    Private Sub CargarDatosDetalle(detalle As List(Of InteresesAcumuladoDetalle))

        For Each lista As InteresesAcumuladoDetalle In detalle

            dt.Rows.Add(lista.Empleado, lista.PlanAhorro, lista.IntAcumulado)
            CargodeInteresDataGridView.DataSource = dt
        Next
    End Sub

    Private Sub LimpiarGrid()
        dt = New DataTable
        CargodeInteresDataGridView.DataSource = dt
    End Sub
End Class