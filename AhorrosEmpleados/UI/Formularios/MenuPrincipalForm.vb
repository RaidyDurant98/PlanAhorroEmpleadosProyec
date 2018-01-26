Public Class MenuPrincipalForm

    Private RegistroPlanAhorros As AhorrosEmpleados.PlanAhorrosForm
    Private RegistroEmpleados As AhorrosEmpleados.EmpleadosForm
    Private ConsultaPlanAhorros As AhorrosEmpleados.PlanAhorrosConsulta
    Private AfiliacionEmpleados As AhorrosEmpleados.AfiliacionEmpleadosForm
    Private RegistroAporteVoluntarios As AhorrosEmpleados.AportesVoluntariosForm
    Private ConsultaSociosAfiliados As AhorrosEmpleados.SociosAfiliadosConsulta
    Private CargoInteresesAcumulado As AhorrosEmpleados.CargoInteresAcumuladoForm
    Private DepositoConsulta As AhorrosEmpleados.DepositosConsulta

    Private Sub PlanAhorrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanAhorrosToolStripMenuItem.Click

        If RegistroPlanAhorros IsNot Nothing Then
            RegistroPlanAhorros.Close()
        End If


        RegistroPlanAhorros = New AhorrosEmpleados.PlanAhorrosForm
        RegistroPLanAhorros.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click

        If RegistroEmpleados IsNot Nothing Then
            RegistroEmpleados.Close()
        End If


        RegistroEmpleados = New AhorrosEmpleados.EmpleadosForm
        RegistroEmpleados.Show()
    End Sub

    Private Sub PlanAhorrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlanAhorrosToolStripMenuItem1.Click

        If ConsultaPlanAhorros IsNot Nothing Then
            ConsultaPlanAhorros.Close()
        End If


        ConsultaPlanAhorros = New AhorrosEmpleados.PlanAhorrosConsulta
        ConsultaPlanAhorros.Show()
    End Sub

    Private Sub AfiliacionEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfiliacionEmpleadosToolStripMenuItem.Click

        If AfiliacionEmpleados IsNot Nothing Then
            AfiliacionEmpleados.Close()
        End If


        AfiliacionEmpleados = New AhorrosEmpleados.AfiliacionEmpleadosForm
        AfiliacionEmpleados.Show()
    End Sub

    Private Sub AportesVoluntariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AportesVoluntariosToolStripMenuItem.Click
        If RegistroAporteVoluntarios IsNot Nothing Then
            RegistroAporteVoluntarios.Close()
        End If

        RegistroAporteVoluntarios = New AhorrosEmpleados.AportesVoluntariosForm
        RegistroAporteVoluntarios.Show()
    End Sub

    Private Sub SociosAfiliadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SociosAfiliadosToolStripMenuItem.Click
        If ConsultaSociosAfiliados IsNot Nothing Then
            ConsultaSociosAfiliados.Close()
        End If

        ConsultaSociosAfiliados = New AhorrosEmpleados.SociosAfiliadosConsulta
        ConsultaSociosAfiliados.Show()
    End Sub

    Private Sub CargoDeInteresesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoDeInteresesToolStripMenuItem.Click
        If CargoInteresesAcumulado IsNot Nothing Then
            CargoInteresesAcumulado.Close()
        End If


        CargoInteresesAcumulado = New AhorrosEmpleados.CargoInteresAcumuladoForm
        CargoInteresesAcumulado.Show()
    End Sub

    Private Sub DepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositosToolStripMenuItem.Click
        If DepositoConsulta IsNot Nothing Then
            DepositoConsulta.Close()
        End If


        DepositoConsulta = New AhorrosEmpleados.DepositosConsulta
        DepositoConsulta.Show()
    End Sub
End Class