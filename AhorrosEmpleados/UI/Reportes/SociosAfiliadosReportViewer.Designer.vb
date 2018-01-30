<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SociosAfiliadosReportViewer
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
        Me.SociosAfiliadosCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'SociosAfiliadosCrystalReportViewer
        '
        Me.SociosAfiliadosCrystalReportViewer.ActiveViewIndex = -1
        Me.SociosAfiliadosCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SociosAfiliadosCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.SociosAfiliadosCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SociosAfiliadosCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.SociosAfiliadosCrystalReportViewer.Name = "SociosAfiliadosCrystalReportViewer"
        Me.SociosAfiliadosCrystalReportViewer.Size = New System.Drawing.Size(511, 492)
        Me.SociosAfiliadosCrystalReportViewer.TabIndex = 0
        '
        'SociosAfiliadosReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 492)
        Me.Controls.Add(Me.SociosAfiliadosCrystalReportViewer)
        Me.Name = "SociosAfiliadosReportViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de socios afiliados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SociosAfiliadosCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
