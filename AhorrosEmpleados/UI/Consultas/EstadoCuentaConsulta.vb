Public Class EstadoCuentaConsulta

    Dim dt As DataTable = Nothing

    Private Sub EstadoCuentaConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaDataGridView.AutoGenerateColumns = False
        FiltrarComboBox.SelectedIndex = 0
    End Sub

    Private Sub Filtro()
        If FiltrarComboBox.SelectedIndex = 0 Then
            dt = BLL.InteresAcumuladoBLL.GetAllTotalIntereses()
        Else
            If String.IsNullOrEmpty(FiltrarTextBox.Text) Then
                MessageBox.Show("Por favor digite el dato a filtrar.")
            Else
                If FiltrarComboBox.SelectedIndex = 1 Then
                    dt = BLL.InteresAcumuladoBLL.GetTotalIntereses("Nombres like '%" & FiltrarTextBox.Text & "%'")
                ElseIf FiltrarComboBox.SelectedIndex = 2 Then
                    dt = BLL.InteresAcumuladoBLL.GetTotalIntereses("Descripcion like '%" & FiltrarTextBox.Text & "%'")
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

    Private Sub FiltrarComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FiltrarComboBox.SelectedIndexChanged
        If FiltrarComboBox.SelectedIndex = 0 Then
            Filtro()
        Else
            ConsultaDataGridView.DataSource = New DataGridView()
        End If
    End Sub

    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs) Handles ImprimirButton.Click

    End Sub
End Class