<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipalForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanAhorrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfiliacionEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AportesVoluntariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanAhorrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosAfiliadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoDeInteresesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(531, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.PlanAhorrosToolStripMenuItem, Me.AfiliacionEmpleadosToolStripMenuItem, Me.AportesVoluntariosToolStripMenuItem, Me.CargoDeInteresesToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.RegistrosToolStripMenuItem.Text = "Formularios"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'PlanAhorrosToolStripMenuItem
        '
        Me.PlanAhorrosToolStripMenuItem.Name = "PlanAhorrosToolStripMenuItem"
        Me.PlanAhorrosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PlanAhorrosToolStripMenuItem.Text = "Plan Ahorros"
        '
        'AfiliacionEmpleadosToolStripMenuItem
        '
        Me.AfiliacionEmpleadosToolStripMenuItem.Name = "AfiliacionEmpleadosToolStripMenuItem"
        Me.AfiliacionEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AfiliacionEmpleadosToolStripMenuItem.Text = "Afiliacion Empleados"
        '
        'AportesVoluntariosToolStripMenuItem
        '
        Me.AportesVoluntariosToolStripMenuItem.Name = "AportesVoluntariosToolStripMenuItem"
        Me.AportesVoluntariosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AportesVoluntariosToolStripMenuItem.Text = "Aportes Voluntarios"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanAhorrosToolStripMenuItem1, Me.SociosAfiliadosToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'PlanAhorrosToolStripMenuItem1
        '
        Me.PlanAhorrosToolStripMenuItem1.Name = "PlanAhorrosToolStripMenuItem1"
        Me.PlanAhorrosToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.PlanAhorrosToolStripMenuItem1.Text = "Plan Ahorros"
        '
        'SociosAfiliadosToolStripMenuItem
        '
        Me.SociosAfiliadosToolStripMenuItem.Name = "SociosAfiliadosToolStripMenuItem"
        Me.SociosAfiliadosToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SociosAfiliadosToolStripMenuItem.Text = "Socios Afiliados"
        '
        'CargoDeInteresesToolStripMenuItem
        '
        Me.CargoDeInteresesToolStripMenuItem.Name = "CargoDeInteresesToolStripMenuItem"
        Me.CargoDeInteresesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CargoDeInteresesToolStripMenuItem.Text = "Cargo de intereses"
        '
        'MenuPrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 402)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipalForm"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanAhorrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanAhorrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AfiliacionEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AportesVoluntariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SociosAfiliadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargoDeInteresesToolStripMenuItem As ToolStripMenuItem
End Class
