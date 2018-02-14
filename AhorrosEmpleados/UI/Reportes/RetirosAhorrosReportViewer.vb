Imports CrystalDecisions.CrystalReports.Engine

Public Class RetirosAhorrosReportViewer

    Public datatable As DataTable = New DataTable

    Public Sub New(dt As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        datatable = New DataTable()
        datatable = dt

    End Sub

    Private Sub RetirosAhorroCrystalReportViewer_Load(sender As Object, e As EventArgs) Handles RetirosAhorroCrystalReportViewer.Load
        Dim r As New ReportDocument

        r.Load("C:\Users\Raidy Duran\Desktop\AhorrosEmpleados\AhorrosEmpleados\UI\Reportes\RetirosAhorro.rpt")
        r.SetDataSource(datatable)


        RetirosAhorroCrystalReportViewer.ReportSource = r
        RetirosAhorroCrystalReportViewer.Refresh()
    End Sub
End Class