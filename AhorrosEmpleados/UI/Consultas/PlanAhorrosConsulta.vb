Imports BLL

Public Class PlanAhorrosConsulta

    Private Sub PlanAhorrosConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaDataGridView.AutoGenerateColumns = False
    End Sub

    Private Sub Filtro()
        Dim dt As DataTable = Nothing

        If FiltrarComboBox.SelectedIndex = 0 Then
            dt = PlanAhorrosBLL.GetList("select * from PlanAhorros")
        Else
            If String.IsNullOrEmpty(FiltrarTextBox.Text) Then
                MessageBox.Show("Por favor digite el dato a filtrar.")
            Else

                If FiltrarComboBox.SelectedIndex = 1 Then
                    dt = PlanAhorrosBLL.GetList("Select * from PlanAhorros where PlanId =" & FiltrarTextBox.Text & "")
                ElseIf FiltrarComboBox.SelectedIndex = 2 Then
                    dt = PlanAhorrosBLL.GetList("Select * from PlanAhorros where Descripcion ='" & FiltrarTextBox.Text & "'")
                End If

            End If
        End If
        ConsultaDataGridView.DataSource = dt
    End Sub

    Private Sub FiltrarButton_Click(sender As Object, e As EventArgs) Handles FiltrarButton.Click

        Filtro()

    End Sub

End Class