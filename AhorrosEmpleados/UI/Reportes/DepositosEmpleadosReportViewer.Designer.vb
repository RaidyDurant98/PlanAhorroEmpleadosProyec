<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepositosEmpleadosReportViewer
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
        Me.DepositosEmpleadosCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'DepositosEmpleadosCrystalReportViewer
        '
        Me.DepositosEmpleadosCrystalReportViewer.ActiveViewIndex = -1
        Me.DepositosEmpleadosCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DepositosEmpleadosCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.DepositosEmpleadosCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DepositosEmpleadosCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.DepositosEmpleadosCrystalReportViewer.Name = "DepositosEmpleadosCrystalReportViewer"
        Me.DepositosEmpleadosCrystalReportViewer.Size = New System.Drawing.Size(698, 545)
        Me.DepositosEmpleadosCrystalReportViewer.TabIndex = 0
        '
        'DepositosEmpleadosReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 545)
        Me.Controls.Add(Me.DepositosEmpleadosCrystalReportViewer)
        Me.Name = "DepositosEmpleadosReportViewer"
        Me.Text = "Reporte de depositos de los empleados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DepositosEmpleadosCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
