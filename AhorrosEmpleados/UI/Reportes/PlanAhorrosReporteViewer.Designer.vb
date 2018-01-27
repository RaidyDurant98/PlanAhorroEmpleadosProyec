<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanAhorrosReporteViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PlanAhorroCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'PlanAhorroCrystalReportViewer
        '
        Me.PlanAhorroCrystalReportViewer.ActiveViewIndex = -1
        Me.PlanAhorroCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlanAhorroCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.PlanAhorroCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlanAhorroCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.PlanAhorroCrystalReportViewer.Name = "PlanAhorroCrystalReportViewer"
        Me.PlanAhorroCrystalReportViewer.Size = New System.Drawing.Size(655, 491)
        Me.PlanAhorroCrystalReportViewer.TabIndex = 0
        '
        'PlanAhorrosReporteViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 491)
        Me.Controls.Add(Me.PlanAhorroCrystalReportViewer)
        Me.Name = "PlanAhorrosReporteViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlanAhorrosReporteViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlanAhorroCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
