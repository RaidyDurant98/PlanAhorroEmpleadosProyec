Imports CrystalDecisions.CrystalReports.Engine

Public Class EstadoCuentaReportViewer

    Public datatable As DataTable = New DataTable

    Public Sub New(dt As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        datatable = New DataTable()
        datatable = dt

    End Sub

    Private Sub EstadoCuentaCrystalReportViewer_Load(sender As Object, e As EventArgs) Handles EstadoCuentaCrystalReportViewer.Load
        Dim r As New ReportDocument
        r.Load("C:\Users\Raidy Duran\Desktop\AhorrosEmpleados\AhorrosEmpleados\UI\Reportes\EstadoCuenta.rpt")
        r.SetDataSource(datatable)

        EstadoCuentaCrystalReportViewer.ReportSource = r
        EstadoCuentaCrystalReportViewer.Refresh()
    End Sub
End Class