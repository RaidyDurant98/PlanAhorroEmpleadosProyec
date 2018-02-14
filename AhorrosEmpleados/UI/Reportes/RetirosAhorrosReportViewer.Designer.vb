<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetirosAhorrosReportViewer
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
        Me.RetirosAhorroCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'RetirosAhorroCrystalReportViewer
        '
        Me.RetirosAhorroCrystalReportViewer.ActiveViewIndex = -1
        Me.RetirosAhorroCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RetirosAhorroCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.RetirosAhorroCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RetirosAhorroCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.RetirosAhorroCrystalReportViewer.Name = "RetirosAhorroCrystalReportViewer"
        Me.RetirosAhorroCrystalReportViewer.Size = New System.Drawing.Size(565, 504)
        Me.RetirosAhorroCrystalReportViewer.TabIndex = 0
        '
        'RetirosAhorrosReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 504)
        Me.Controls.Add(Me.RetirosAhorroCrystalReportViewer)
        Me.Name = "RetirosAhorrosReportViewer"
        Me.Text = "Reporte de retiro de ahorros"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RetirosAhorroCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
