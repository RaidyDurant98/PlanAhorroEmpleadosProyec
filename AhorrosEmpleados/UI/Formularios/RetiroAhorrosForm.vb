Imports Entidades
Imports System.Linq

Public Class RetiroAhorrosForm

    Dim Empleado As Empleados = Nothing
    Dim Retiro As RetiroAhorros = Nothing
    Dim dt As DataTable = Nothing

    Private Function CargarDatosEmpleado() As Empleados

        If Not String.IsNullOrEmpty(EmpleadoIdMaskedTextBox.Text) Then

            Empleado = BLL.EmpleadosBLL.Buscar(EmpleadoIdMaskedTextBox.Text)

            If Empleado.EmpleadoId <> 0 Then
                NombreEmpleadoTextBox.Text = Empleado.Nombres
                CargarDetalle()
            Else
                MessageBox.Show("No existe empleado con ese id")
            End If
        Else
            MessageBox.Show("Por favor digite el id del empleado")
        End If

        Return Empleado
    End Function

    Private Sub CargarDetalle()
        dt = BLL.RetirosBLL.ObtenerInteresAcumulado(Empleado.EmpleadoId)
        dt.Columns.Add("CantidadRetiro")
        DetalleDataGridView.DataSource = dt
        DetalleDataGridView.Columns("Ahorro").Visible = True
        DescontarRetiroDeAhorros()
    End Sub

    Private Sub DescontarRetiroDeAhorros()
        Dim retiro As DataTable = BLL.RetirosBLL.ObtenerRetirosAnteriores(Empleado.EmpleadoId)
        Dim i As Integer = dt.Rows.Count

        If retiro.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DetalleDataGridView.Rows
                row.Cells("Ahorro").Value -= "0" & retiro(dt.Rows.Count - i)("Retiro")
                i -= 1
            Next
        End If
    End Sub

    Private Sub BuscarEmpleadoButton_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoButton.Click
        CargarDatosEmpleado()
    End Sub

    Private Sub RetiroAhorrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Empleado = New Empleados
        Retiro = New RetiroAhorros
        dt = New DataTable
        ImprimirButton.Enabled = False
        EliminarButton.Enabled = False
        ModificarButton.Enabled = False
        CancelarButton.Enabled = False
        CargarDetalle()
    End Sub

    Private Sub CalcularTotalRetiro()
        Dim suma As Double = 0

        For Each row As DataGridViewRow In DetalleDataGridView.Rows
            suma += "0" & row.Cells("CantidadRetiro").Value
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
                    Convert.ToDouble(row.Cells("Ahorro").Value),
                    Convert.ToDouble("0" & row.Cells("CantidadRetiro").Value)
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
            list.Add("0" & row.Cells("CantidadRetiro").Value)
        Next

        For index = 0 To dt.Rows.Count - 1
            PlanAhorros = BLL.PlanAhorrosBLL.Buscar(" PlanId = " & dt.Rows(index)("PlanId") & "")

            If PlanAhorros.FondoMinimo > (DetalleDataGridView.Rows(index).Cells("Ahorro").Value - list(index)) Then
                interruptor = False
                If interruptor = False Then
                    indice = index
                End If
            End If
        Next

        Return interruptor

    End Function

    Private Function Validar() As Boolean

        Dim interruptor As Boolean = True

        If String.IsNullOrEmpty(NombreEmpleadoTextBox.Text) Then
            interruptor = False
        End If

        Return interruptor

    End Function

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        Dim indice As Integer = New Integer

        If ValidarCantidadRetiro(indice) Then
            If BLL.RetirosBLL.Guardar(LlenarInstancia()) Then
                RetiroIdMaskedTextBox.Text = Retiro.RetiroId
                MessageBox.Show("Retiro registrado")
                GuardarButton.Enabled = False
                ModificarButton.Enabled = True
                CancelarButton.Enabled = True
                EliminarButton.Enabled = True
                EmpleadoIdMaskedTextBox.ReadOnly = True
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
        Empleado = New Empleados
        CargarDetalle()
        FechaDateTimePicker.Value = Date.Now
        RetiroIdMaskedTextBox.Clear()
        EmpleadoIdMaskedTextBox.Clear()
        NombreEmpleadoTextBox.Clear()
        TotalRetiroTextBox.Clear()

        EmpleadoIdMaskedTextBox.ReadOnly = False
        BuscarEmpleadoButton.Enabled = True
        ModificarButton.Enabled = False
        EliminarButton.Enabled = False
        CancelarButton.Enabled = False
        ImprimirButton.Enabled = False
        GuardarButton.Enabled = True
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        If (String.IsNullOrEmpty(RetiroIdMaskedTextBox.Text) = False) Then

            Retiro = BLL.RetirosBLL.Buscar(RetiroIdMaskedTextBox.Text)

            If Retiro.RetiroId <> 0 Then
                CargarDatosRetiro()
                EmpleadoIdMaskedTextBox.ReadOnly = True
                BuscarEmpleadoButton.Enabled = False
                ModificarButton.Enabled = True
                CancelarButton.Enabled = True
                GuardarButton.Enabled = False
                EliminarButton.Enabled = True
            Else
                MessageBox.Show("No existe retiro con ese id.")
            End If

        Else
            MessageBox.Show("Por favor digite el id que desea buscar.")
        End If
    End Sub

    Private Sub CargarDatosRetiro()
        Empleado = BLL.EmpleadosBLL.Buscar(Retiro.Empleado)
        FechaDateTimePicker.Value = Retiro.Fecha
        EmpleadoIdMaskedTextBox.Text = Empleado.EmpleadoId
        NombreEmpleadoTextBox.Text = Empleado.Nombres
        TotalRetiroTextBox.Text = Retiro.RetiroTotal.ToString("n2")
        CargarDatosDetalle(Retiro.Detalle)
    End Sub

    Private Sub CargarDatosDetalle(detalle As List(Of RetiroAhorrosDetalle))

        dt.Rows.Clear()

        For Each lista As RetiroAhorrosDetalle In detalle

            Dim planAhorro = BLL.PlanAhorrosBLL.Buscar("PlanId = " & lista.PlanId & "")

            dt.Rows.Add(lista.PlanId, planAhorro.Descripcion, lista.Ahorro, lista.Retiro)
            DetalleDataGridView.DataSource = dt

        Next

        DetalleDataGridView.Columns("Ahorro").Visible = False
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        If (String.IsNullOrEmpty(RetiroIdMaskedTextBox.Text) = False) Then

            Retiro = BLL.RetirosBLL.Buscar(RetiroIdMaskedTextBox.Text)
            Dim eliminar As DialogResult = MessageBox.Show("¿Esta seguro de eliminar el retiro?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If eliminar = DialogResult.Yes Then
                If BLL.RetirosBLL.Eliminar(Retiro.RetiroId) Then
                    Limpiar()
                    Retiro.Detalle = New List(Of RetiroAhorrosDetalle)
                    MessageBox.Show("Retiro eliminado con exito.")
                Else
                    MessageBox.Show("No se pudo eliminar el retiro.")
                End If
            End If
        Else
            MessageBox.Show("Por favor digite el id que desea eliminar.")
        End If
    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click
        If CompararDatosRetiro(Retiro.Detalle) Then
            If Validar() Then
                Dim indice As Integer = New Integer


                If BLL.RetirosBLL.Modificar(LlenarInstancia()) Then
                    Retiro.Detalle = New List(Of RetiroAhorrosDetalle)
                    MessageBox.Show("Retiro modificado con exito.")
                Else
                    MessageBox.Show("No se pudo modificar el retiro.")
                End If

            End If
        Else
            MessageBox.Show("Realize otro retiro si su deseo es aumentar la cantidad.")
        End If
    End Sub

    Private Function CompararDatosRetiro(detalle As List(Of RetiroAhorrosDetalle)) As Boolean
        Dim x As Integer

        For Each lista As RetiroAhorrosDetalle In detalle
            x = lista.Retiro
            If x < DetalleDataGridView.Rows(0).Cells("CantidadRetiro").Value Then
                Return False
            End If
        Next
        Return True
    End Function

End Class