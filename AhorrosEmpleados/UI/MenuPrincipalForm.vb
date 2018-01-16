Public Class MenuPrincipalForm

    Private RegistroPLanAhorros As AhorrosEmpleados.PlanAhorrosForm
    Private RegistroEmpleados As AhorrosEmpleados.EmpleadosForm

    Private Sub PlanAhorrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanAhorrosToolStripMenuItem.Click

        If RegistroPLanAhorros IsNot Nothing Then
            RegistroPLanAhorros.Close()
        End If


        RegistroPLanAhorros = New AhorrosEmpleados.PlanAhorrosForm
        RegistroPLanAhorros.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click

        If RegistroEmpleados IsNot Nothing Then
            RegistroEmpleados.Close()
        End If


        RegistroEmpleados = New AhorrosEmpleados.EmpleadosForm
        RegistroEmpleados.Show()
    End Sub
End Class