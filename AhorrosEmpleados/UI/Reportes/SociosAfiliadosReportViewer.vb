Imports CrystalDecisions.CrystalReports.Engine

Public Class SociosAfiliadosReportViewer
    Public datatable As DataTable = New DataTable

    Public Sub New(dt As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        datatable = New DataTable()
        datatable = dt

    End Sub

    Private Sub SociosAfiliadosReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New ReportDocument

        r.Load("C:\Users\Raidy Duran\Desktop\AhorrosEmpleados\AhorrosEmpleados\UI\Reportes\SociosAfiliados.rpt")
        r.SetDataSource(datatable)


        SociosAfiliadosCrystalReportViewer.ReportSource = r
        SociosAfiliadosCrystalReportViewer.Refresh()
    End Sub



    Private Sub SociosAfiliadosCrystalReportViewer_Load(sender As Object, e As EventArgs) Handles SociosAfiliadosCrystalReportViewer.Load

    End Sub
End Class