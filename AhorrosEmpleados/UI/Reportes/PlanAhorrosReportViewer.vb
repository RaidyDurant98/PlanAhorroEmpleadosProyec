Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Entidades

Public Class PlanAhorrosReportViewer

    Public datatable As DataTable = New DataTable

    Public Sub New(dt As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        datatable = New DataTable()
        datatable = dt

    End Sub

    Private Sub PlanAhorroCrystalReportViewer_Load(sender As Object, e As EventArgs) Handles PlanAhorroCrystalReportViewer.Load
        Dim r As New ReportDocument
        r.Load("C:\Users\Raidy Duran\Desktop\AhorrosEmpleados\AhorrosEmpleados\UI\Reportes\PlanAhorrosEmpleados.rpt")
        r.SetDataSource(datatable)

        PlanAhorroCrystalReportViewer.ReportSource = r
        PlanAhorroCrystalReportViewer.Refresh()
    End Sub

    Private Sub PlanAhorrosReporteViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class