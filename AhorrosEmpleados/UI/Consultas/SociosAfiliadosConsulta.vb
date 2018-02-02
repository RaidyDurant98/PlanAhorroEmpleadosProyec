Imports BLL

Public Class SociosAfiliadosConsulta

    Dim dt As DataTable = Nothing

    Private Sub SociosAfiliadosConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaDataGridView.AutoGenerateColumns = False
        FiltrarComboBox.SelectedIndex = 0
    End Sub

    Private Sub FiltrarButton_Click(sender As Object, e As EventArgs) Handles FiltrarButton.Click
        Filtro()
    End Sub

    Private Sub Filtro()
        'Dim dt As DataTable = Nothing

        If FiltrarComboBox.SelectedIndex = 0 Then
            dt = EmpleadosBLL.GetAllSociosAfiliados()
        Else
            If String.IsNullOrEmpty(FiltrarTextBox.Text) Then
                MessageBox.Show("Por favor digite el dato a filtrar.")
            Else
                If FiltrarComboBox.SelectedIndex = 1 Then
                    dt = EmpleadosBLL.GetSocioAfiliado("EmpleadoId =" & FiltrarTextBox.Text & "")
                ElseIf FiltrarComboBox.SelectedIndex = 2 Then
                    dt = EmpleadosBLL.GetSocioAfiliado("Nombres like '%" & FiltrarTextBox.Text & "%'")
                ElseIf FiltrarComboBox.SelectedIndex = 3 Then
                    dt = EmpleadosBLL.GetSocioAfiliado("Pl.Descripcion like '%" & FiltrarTextBox.Text & "%'")
                End If
            End If
        End If

        If dt.Rows.Count > 0 Then
            ConsultaDataGridView.DataSource = dt
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
            ConsultaDataGridView.DataSource = New DataGridView()
        End If
    End Sub

    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs) Handles ImprimirButton.Click

        Dim report As SociosAfiliadosReportViewer = New SociosAfiliadosReportViewer(dt)
        report.Show()
        report.Activate()
    End Sub
End Class