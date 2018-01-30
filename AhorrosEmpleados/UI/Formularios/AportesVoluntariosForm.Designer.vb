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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AporteIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.SalirButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.ModificarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpleadoIdMaskedTextBox
        '
        Me.EmpleadoIdMaskedTextBox.Location = New System.Drawing.Point(87, 82)
        Me.EmpleadoIdMaskedTextBox.Mask = "000000000"
        Me.EmpleadoIdMaskedTextBox.Name = "EmpleadoIdMaskedTextBox"
        Me.EmpleadoIdMaskedTextBox.Size = New System.Drawing.Size(60, 20)
        Me.EmpleadoIdMaskedTextBox.TabIndex = 0
        Me.EmpleadoIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'BuscarEmpleadoButton
        '
        Me.BuscarEmpleadoButton.Location = New System.Drawing.Point(153, 77)
        Me.BuscarEmpleadoButton.Name = "BuscarEmpleadoButton"
        Me.BuscarEmpleadoButton.Size = New System.Drawing.Size(49, 29)
        Me.BuscarEmpleadoButton.TabIndex = 1
        Me.BuscarEmpleadoButton.Text = "Buscar"
        Me.BuscarEmpleadoButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Empleado Id:"
        '
        'NombresEmpleadoTextBox
        '
        Me.NombresEmpleadoTextBox.Location = New System.Drawing.Point(208, 81)
        Me.NombresEmpleadoTextBox.Name = "NombresEmpleadoTextBox"
        Me.NombresEmpleadoTextBox.ReadOnly = True
        Me.NombresEmpleadoTextBox.Size = New System.Drawing.Size(156, 20)
        Me.NombresEmpleadoTextBox.TabIndex = 8
        '
        'PlanAhorroComboBox
        '
        Me.PlanAhorroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlanAhorroComboBox.FormattingEnabled = True
        Me.PlanAhorroComboBox.Location = New System.Drawing.Point(87, 114)
        Me.PlanAhorroComboBox.Name = "PlanAhorroComboBox"
        Me.PlanAhorroComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PlanAhorroComboBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Plan Ahorro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad a abonar:"
        '
        'AporteMaskedTextBox
        '
        Me.AporteMaskedTextBox.Location = New System.Drawing.Point(115, 144)
        Me.AporteMaskedTextBox.Mask = "000000000000000"
        Me.AporteMaskedTextBox.Name = "AporteMaskedTextBox"
        Me.AporteMaskedTextBox.Size = New System.Drawing.Size(93, 20)
        Me.AporteMaskedTextBox.TabIndex = 3
        Me.AporteMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Aporte Id:"
        '
        'AporteIdMaskedTextBox
        '
        Me.AporteIdMaskedTextBox.Location = New System.Drawing.Point(87, 52)
        Me.AporteIdMaskedTextBox.Mask = "000000000"
        Me.AporteIdMaskedTextBox.Name = "AporteIdMaskedTextBox"
        Me.AporteIdMaskedTextBox.Size = New System.Drawing.Size(60, 20)
        Me.AporteIdMaskedTextBox.TabIndex = 6
        Me.AporteIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(153, 50)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarButton.TabIndex = 7
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImprimirButton.Location = New System.Drawing.Point(417, 256)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.ImprimirButton.TabIndex = 29
        Me.ImprimirButton.Text = "Imprimir"
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'SalirButton
        '
        Me.SalirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SalirButton.Location = New System.Drawing.Point(498, 256)
        Me.SalirButton.Name = "SalirButton"
        Me.SalirButton.Size = New System.Drawing.Size(75, 23)
        Me.SalirButton.TabIndex = 28
        Me.SalirButton.Text = "Salir"
        Me.SalirButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.Location = New System.Drawing.Point(174, 256)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 27
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'ModificarButton
        '
        Me.ModificarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ModificarButton.Location = New System.Drawing.Point(93, 256)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarButton.TabIndex = 26
        Me.ModificarButton.Text = "Modificar"
        Me.ModificarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EliminarButton.Location = New System.Drawing.Point(336, 256)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarButton.TabIndex = 25
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GuardarButton.Location = New System.Drawing.Point(255, 256)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarButton.TabIndex = 23
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'NuevoButton
        '
        Me.NuevoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NuevoButton.Location = New System.Drawing.Point(12, 256)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoButton.TabIndex = 24
        Me.NuevoButton.Text = "Nuevo"
        Me.NuevoButton.UseVisualStyleBackColor = True
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CustomFormat = "yyyy/MM/dd"
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(478, 52)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.FechaDateTimePicker.TabIndex = 30
        '
        'AportesVoluntariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 309)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.SalirButton)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.NuevoButton)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AporteIdMaskedTextBox)
        Me.Controls.Add(Me.AporteMaskedTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PlanAhorroComboBox)
        Me.Controls.Add(Me.NombresEmpleadoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BuscarEmpleadoButton)
        Me.Controls.Add(Me.EmpleadoIdMaskedTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
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
    Friend WithEvents Label4 As Label
    Friend WithEvents AporteIdMaskedTextBox As MaskedTextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ImprimirButton As Button
    Friend WithEvents SalirButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents ModificarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents GuardarButton As Button
    Friend WithEvents NuevoButton As Button
    Friend WithEvents FechaDateTimePicker As DateTimePicker
End Class
