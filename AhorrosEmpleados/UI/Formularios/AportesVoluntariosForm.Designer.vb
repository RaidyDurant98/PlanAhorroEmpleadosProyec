<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AportesVoluntariosForm
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
        Me.components = New System.ComponentModel.Container()
        Me.EmpleadoIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BuscarEmpleadoButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombresEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.PlanAhorroComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AporteMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AporteIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpleadoIdMaskedTextBox
        '
        Me.EmpleadoIdMaskedTextBox.Location = New System.Drawing.Point(102, 82)
        Me.EmpleadoIdMaskedTextBox.Mask = "000000000"
        Me.EmpleadoIdMaskedTextBox.Name = "EmpleadoIdMaskedTextBox"
        Me.EmpleadoIdMaskedTextBox.Size = New System.Drawing.Size(60, 20)
        Me.EmpleadoIdMaskedTextBox.TabIndex = 0
        Me.EmpleadoIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'BuscarEmpleadoButton
        '
        Me.BuscarEmpleadoButton.Location = New System.Drawing.Point(168, 77)
        Me.BuscarEmpleadoButton.Name = "BuscarEmpleadoButton"
        Me.BuscarEmpleadoButton.Size = New System.Drawing.Size(49, 29)
        Me.BuscarEmpleadoButton.TabIndex = 1
        Me.BuscarEmpleadoButton.Text = "Buscar"
        Me.BuscarEmpleadoButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Empleado Id:"
        '
        'NombresEmpleadoTextBox
        '
        Me.NombresEmpleadoTextBox.Location = New System.Drawing.Point(223, 81)
        Me.NombresEmpleadoTextBox.Name = "NombresEmpleadoTextBox"
        Me.NombresEmpleadoTextBox.ReadOnly = True
        Me.NombresEmpleadoTextBox.Size = New System.Drawing.Size(156, 20)
        Me.NombresEmpleadoTextBox.TabIndex = 8
        '
        'PlanAhorroComboBox
        '
        Me.PlanAhorroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlanAhorroComboBox.FormattingEnabled = True
        Me.PlanAhorroComboBox.Location = New System.Drawing.Point(102, 114)
        Me.PlanAhorroComboBox.Name = "PlanAhorroComboBox"
        Me.PlanAhorroComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PlanAhorroComboBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Plan Ahorro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad a abonar:"
        '
        'AporteMaskedTextBox
        '
        Me.AporteMaskedTextBox.Location = New System.Drawing.Point(130, 144)
        Me.AporteMaskedTextBox.Mask = "000000000000000"
        Me.AporteMaskedTextBox.Name = "AporteMaskedTextBox"
        Me.AporteMaskedTextBox.Size = New System.Drawing.Size(93, 20)
        Me.AporteMaskedTextBox.TabIndex = 3
        Me.AporteMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'NuevoButton
        '
        Me.NuevoButton.Location = New System.Drawing.Point(70, 240)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoButton.TabIndex = 5
        Me.NuevoButton.Text = "Nuevo"
        Me.NuevoButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Aporte Id:"
        '
        'AporteIdMaskedTextBox
        '
        Me.AporteIdMaskedTextBox.Location = New System.Drawing.Point(102, 52)
        Me.AporteIdMaskedTextBox.Mask = "000000000"
        Me.AporteIdMaskedTextBox.Name = "AporteIdMaskedTextBox"
        Me.AporteIdMaskedTextBox.Size = New System.Drawing.Size(60, 20)
        Me.AporteIdMaskedTextBox.TabIndex = 6
        Me.AporteIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(168, 50)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarButton.TabIndex = 7
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Location = New System.Drawing.Point(163, 240)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarButton.TabIndex = 4
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Location = New System.Drawing.Point(255, 240)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarButton.TabIndex = 8
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'AportesVoluntariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 309)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AporteIdMaskedTextBox)
        Me.Controls.Add(Me.NuevoButton)
        Me.Controls.Add(Me.AporteMaskedTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PlanAhorroComboBox)
        Me.Controls.Add(Me.NombresEmpleadoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BuscarEmpleadoButton)
        Me.Controls.Add(Me.EmpleadoIdMaskedTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AportesVoluntariosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de aportes voluntarios"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmpleadoIdMaskedTextBox As MaskedTextBox
    Friend WithEvents BuscarEmpleadoButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NombresEmpleadoTextBox As TextBox
    Friend WithEvents PlanAhorroComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AporteMaskedTextBox As MaskedTextBox
    Friend WithEvents NuevoButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents AporteIdMaskedTextBox As MaskedTextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents GuardarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
