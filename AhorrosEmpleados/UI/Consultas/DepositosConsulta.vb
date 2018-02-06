Imports BLL

Public Class DepositosConsulta

    Dim dt As DataTable = Nothing

    Private Sub DepositosConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaDataGridView.AutoGenerateColumns = False
        FiltrarComboBox.SelectedIndex = 0
    End Sub

    Private Sub Filtro()
        If FiltrarComboBox.SelectedIndex = 0 Then
            dt = AportesBLL.GetAportes()
        Else
            If String.IsNullOrEmpty(FiltrarTextBox.Text) Then
                MessageBox.Show("Por favor digite el dato a filtrar.")
            Else
                If FiltrarComboBox.SelectedIndex = 1 Then
                    dt = AportesBLL.GetAportes("where Nombres like '%" & FiltrarTextBox.Text & "%'")
                ElseIf FiltrarComboBox.SelectedIndex = 2 Then
                    dt = AportesBLL.GetAportes(" where Descripcion like '%" & FiltrarTextBox.Text & "%'")
                End If
            End If
        End If

        If dt.Rows.Count > 0 Then
            ConsultaDataGridView.DataSource = dt
        End If
    End Sub

    Private Sub FiltrarButton_Click(sender As Object, e As EventArgs) Handles FiltrarButton.Click
        Filtro()
    End Sub

    Private Sub FiltrarTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FiltrarTextBox.KeyPress
        'If FiltrarComboBox.SelectedIndex = 1 Then
        '    If (Char.IsDigit(e.KeyChar)) Then
        '        e.Handled = False
        '    Else
        '        If (Char.IsControl(e.KeyChar)) Then
        '            e.Handled = False
        '        Else
        '            e.Handled = True

        '        End If
        '    End If
        'End If
    End Sub

    Private Sub FiltrarComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FiltrarComboBox.SelectedIndexChanged
        If FiltrarComboBox.SelectedIndex = 0 Then
            Filtro()
        Else
            dt = New DataTable
            ConsultaDataGridView.DataSource = dt
        End If
    End Sub

    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs) Handles ImprimirButton.Click

        If dt.Rows.Count() > 0 Then
            Dim report As DepositosEmpleadosReportViewer = New DepositosEmpleadosReportViewer(dt)
            report.Show()
            report.Activate()
        End If

    End Sub
End Class