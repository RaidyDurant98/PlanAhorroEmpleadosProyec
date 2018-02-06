Imports CrystalDecisions.CrystalReports.Engine

Public Class DepositosEmpleadosReportViewer

    Public datatable As DataTable = New DataTable

    Public Sub New(dt As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        datatable = New DataTable()
        datatable = dt

    End Sub

    Private Sub DepositosEmpleadosReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DepositosEmpleadosCrystalReportViewer_Load(sender As Object, e As EventArgs) Handles DepositosEmpleadosCrystalReportViewer.Load
        Dim r As New ReportDocument
        r.Load("C:\Users\Raidy Duran\Desktop\AhorrosEmpleados\AhorrosEmpleados\UI\Reportes\DepositosEmpleados.rpt")
        r.SetDataSource(datatable)


        DepositosEmpleadosCrystalReportViewer.ReportSource = r
        DepositosEmpleadosCrystalReportViewer.Refresh()
    End Sub
End Class