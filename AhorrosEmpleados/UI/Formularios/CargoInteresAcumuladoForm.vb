Imports Entidades

Public Class CargoInteresAcumuladoForm

    Dim dt As DataTable = Nothing

    Private Sub CargoInteresAcumuladoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = New DataTable()
        CargodeInteresDataGridView.AutoGenerateColumns = False
        CargarDetalle()
    End Sub

    Private Sub CargarDetalle()
        CargodeInteresDataGridView.DataSource = BLL.EmpleadosBLL.GetAllSociosAfiliados()
    End Sub

End Class