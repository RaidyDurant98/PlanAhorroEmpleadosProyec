﻿Imports BLL

Public Class SociosAfiliadosConsulta

    Dim dt As DataTable = Nothing

    Private Sub SociosAfiliadosConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaDataGridView.AutoGenerateColumns = False
        FiltrarComboBox.SelectedIndex = 0
    End Sub

    Private Sub FiltrarButton_Click(sender As Object, e As EventArgs) Handles FiltrarButton.Click
        Filtro()
    End Sub

    Private Sub LimpiarGrid()
        dt.Rows.Clear()
    End Sub

    Private Function ValidarFechaDesdeHasta() As Boolean
        Dim interruptor = True

        If HastaDateTimePicker.Value.Date < DesdeDateTimePicker.Value.Date Then
            interruptor = False
        End If

        Return interruptor
    End Function

    Private Sub Filtro()

        If FiltrarComboBox.SelectedIndex = 0 Then
            dt = EmpleadosBLL.GetSociosAfiliados()
        ElseIf FiltrarComboBox.SelectedIndex = 4 Then
            If ValidarFechaDesdeHasta() Then
                dt = EmpleadosBLL.GetSociosAfiliados(" where afil.FechaAfiliacion >= '" & DesdeDateTimePicker.Value.Date & "' and afil.FechaAfiliacion <= '" & HastaDateTimePicker.Value.Date & "'")
            Else
                LimpiarGrid()
                MessageBox.Show("La desde debe ser menor que la fecha hasta")
            End If
        Else
            If String.IsNullOrEmpty(FiltrarTextBox.Text) Then
                MessageBox.Show("Por favor digite el dato a filtrar.")
            Else
                If FiltrarComboBox.SelectedIndex = 1 Then
                    dt = EmpleadosBLL.GetSociosAfiliados("where EmpleadoId =" & FiltrarTextBox.Text & "")
                ElseIf FiltrarComboBox.SelectedIndex = 2 Then
                    dt = EmpleadosBLL.GetSociosAfiliados("where Nombres like '%" & FiltrarTextBox.Text & "%'")
                ElseIf FiltrarComboBox.SelectedIndex = 3 Then
                    dt = EmpleadosBLL.GetSociosAfiliados("where Pl.Descripcion like '%" & FiltrarTextBox.Text & "%'")
                End If
            End If
        End If

        If dt.Rows.Count > 0 Then
            ConsultaDataGridView.DataSource = dt
        Else
            LimpiarGrid()
        End If
    End Sub

    Private Sub FiltrarTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FiltrarTextBox.KeyPress
        If FiltrarComboBox.SelectedIndex = 1 Then
            If (Char.IsDigit(e.KeyChar)) Then
                e.Handled = False
            Else
                If (Char.IsControl(e.KeyChar)) Then
                    e.Handled = False
                Else
                    e.Handled = True

                End If
            End If
        End If
    End Sub

    Private Sub FiltrarComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FiltrarComboBox.SelectedIndexChanged
        If FiltrarComboBox.SelectedIndex = 0 Then
            Filtro()
        Else
            LimpiarGrid()
        End If
    End Sub

    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs) Handles ImprimirButton.Click

        If dt.Rows.Count > 0 Then
            Dim report As SociosAfiliadosReportViewer = New SociosAfiliadosReportViewer(dt)
            report.Show()
            report.Activate()
        End If

    End Sub
End Class