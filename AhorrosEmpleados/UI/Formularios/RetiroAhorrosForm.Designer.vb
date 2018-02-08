<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RetiroAhorrosForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.SalirButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.ModificarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.RetiroIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombreEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BuscarEmpleadoButton = New System.Windows.Forms.Button()
        Me.EmpleadoIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TotalRetiroTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PlanId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadRetiro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImprimirButton.Location = New System.Drawing.Point(420, 306)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.ImprimirButton.TabIndex = 38
        Me.ImprimirButton.Text = "Imprimir"
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'SalirButton
        '
        Me.SalirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SalirButton.Location = New System.Drawing.Point(501, 306)
        Me.SalirButton.Name = "SalirButton"
        Me.SalirButton.Size = New System.Drawing.Size(75, 23)
        Me.SalirButton.TabIndex = 37
        Me.SalirButton.Text = "Salir"
        Me.SalirButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.Location = New System.Drawing.Point(177, 306)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 36
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'ModificarButton
        '
        Me.ModificarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ModificarButton.Location = New System.Drawing.Point(96, 306)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarButton.TabIndex = 35
        Me.ModificarButton.Text = "Modificar"
        Me.ModificarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EliminarButton.Location = New System.Drawing.Point(339, 306)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarButton.TabIndex = 34
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GuardarButton.Location = New System.Drawing.Point(258, 306)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarButton.TabIndex = 32
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'NuevoButton
        '
        Me.NuevoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NuevoButton.Location = New System.Drawing.Point(12, 306)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoButton.TabIndex = 33
        Me.NuevoButton.Text = "Nuevo"
        Me.NuevoButton.UseVisualStyleBackColor = True
        '
        'RetiroIdMaskedTextBox
        '
        Me.RetiroIdMaskedTextBox.Location = New System.Drawing.Point(68, 21)
        Me.RetiroIdMaskedTextBox.Mask = "000000000000"
        Me.RetiroIdMaskedTextBox.Name = "RetiroIdMaskedTextBox"
        Me.RetiroIdMaskedTextBox.Size = New System.Drawing.Size(75, 20)
        Me.RetiroIdMaskedTextBox.TabIndex = 39
        Me.RetiroIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(149, 19)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarButton.TabIndex = 40
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Retiro Id:"
        '
        'NombreEmpleadoTextBox
        '
        Me.NombreEmpleadoTextBox.Location = New System.Drawing.Point(208, 54)
        Me.NombreEmpleadoTextBox.Name = "NombreEmpleadoTextBox"
        Me.NombreEmpleadoTextBox.ReadOnly = True
        Me.NombreEmpleadoTextBox.Size = New System.Drawing.Size(156, 20)
        Me.NombreEmpleadoTextBox.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Empleado Id:"
        '
        'BuscarEmpleadoButton
        '
        Me.BuscarEmpleadoButton.Location = New System.Drawing.Point(153, 50)
        Me.BuscarEmpleadoButton.Name = "BuscarEmpleadoButton"
        Me.BuscarEmpleadoButton.Size = New System.Drawing.Size(49, 29)
        Me.BuscarEmpleadoButton.TabIndex = 43
        Me.BuscarEmpleadoButton.Text = "Buscar"
        Me.BuscarEmpleadoButton.UseVisualStyleBackColor = True
        '
        'EmpleadoIdMaskedTextBox
        '
        Me.EmpleadoIdMaskedTextBox.Location = New System.Drawing.Point(87, 55)
        Me.EmpleadoIdMaskedTextBox.Mask = "000000000"
        Me.EmpleadoIdMaskedTextBox.Name = "EmpleadoIdMaskedTextBox"
        Me.EmpleadoIdMaskedTextBox.Size = New System.Drawing.Size(60, 20)
        Me.EmpleadoIdMaskedTextBox.TabIndex = 42
        Me.EmpleadoIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TotalRetiroTextBox)
        Me.GroupBox1.Controls.Add(Me.DetalleDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 206)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plan de Ahorros"
        '
        'TotalRetiroTextBox
        '
        Me.TotalRetiroTextBox.Location = New System.Drawing.Point(417, 180)
        Me.TotalRetiroTextBox.Name = "TotalRetiroTextBox"
        Me.TotalRetiroTextBox.ReadOnly = True
        Me.TotalRetiroTextBox.Size = New System.Drawing.Size(117, 20)
        Me.TotalRetiroTextBox.TabIndex = 46
        '
        'DetalleDataGridView
        '
        Me.DetalleDataGridView.AllowUserToAddRows = False
        Me.DetalleDataGridView.AllowUserToDeleteRows = False
        Me.DetalleDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlanId, Me.Descripcion, Me.Total, Me.CantidadRetiro})
        Me.DetalleDataGridView.Location = New System.Drawing.Point(30, 19)
        Me.DetalleDataGridView.Name = "DetalleDataGridView"
        Me.DetalleDataGridView.Size = New System.Drawing.Size(504, 155)
        Me.DetalleDataGridView.TabIndex = 24
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CustomFormat = "yyyy/MM/dd"
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(481, 19)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.FechaDateTimePicker.TabIndex = 51
        '
        'PlanId
        '
        Me.PlanId.DataPropertyName = "PlanId"
        Me.PlanId.HeaderText = "PlanId"
        Me.PlanId.Name = "PlanId"
        Me.PlanId.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'CantidadRetiro
        '
        Me.CantidadRetiro.HeaderText = "Cantidad a retirar"
        Me.CantidadRetiro.Name = "CantidadRetiro"
        '
        'RetiroAhorrosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 341)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NombreEmpleadoTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BuscarEmpleadoButton)
        Me.Controls.Add(Me.EmpleadoIdMaskedTextBox)
        Me.Controls.Add(Me.RetiroIdMaskedTextBox)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.SalirButton)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.NuevoButton)
        Me.Name = "RetiroAhorrosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro de plan de ahorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImprimirButton As Button
    Friend WithEvents SalirButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents ModificarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents GuardarButton As Button
    Friend WithEvents NuevoButton As Button
    Friend WithEvents RetiroIdMaskedTextBox As MaskedTextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreEmpleadoTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BuscarEmpleadoButton As Button
    Friend WithEvents EmpleadoIdMaskedTextBox As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DetalleDataGridView As DataGridView
    Friend WithEvents TotalRetiroTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents PlanId As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents CantidadRetiro As DataGridViewTextBoxColumn
End Class
