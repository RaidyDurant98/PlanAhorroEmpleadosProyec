<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AfiliacionEmpleadosForm
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
        Me.components = New System.ComponentModel.Container()
        Me.EmpleadoNombreTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpleadoIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BuscarEmpleadoButton = New System.Windows.Forms.Button()
        Me.IdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AgregarButton = New System.Windows.Forms.Button()
        Me.DetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.InteresMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PorcientoDescMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BuscarPlanAhorroButton = New System.Windows.Forms.Button()
        Me.PlanAhorroIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DescripcionPlanAhorroTextBox = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpleadoNombreTextBox
        '
        Me.EmpleadoNombreTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpleadoNombreTextBox.Enabled = False
        Me.EmpleadoNombreTextBox.Location = New System.Drawing.Point(233, 80)
        Me.EmpleadoNombreTextBox.Name = "EmpleadoNombreTextBox"
        Me.EmpleadoNombreTextBox.Size = New System.Drawing.Size(153, 20)
        Me.EmpleadoNombreTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empleado Id:"
        '
        'EmpleadoIdMaskedTextBox
        '
        Me.EmpleadoIdMaskedTextBox.Location = New System.Drawing.Point(106, 80)
        Me.EmpleadoIdMaskedTextBox.Mask = "0000000000"
        Me.EmpleadoIdMaskedTextBox.Name = "EmpleadoIdMaskedTextBox"
        Me.EmpleadoIdMaskedTextBox.Size = New System.Drawing.Size(67, 20)
        Me.EmpleadoIdMaskedTextBox.TabIndex = 2
        Me.EmpleadoIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'BuscarEmpleadoButton
        '
        Me.BuscarEmpleadoButton.Location = New System.Drawing.Point(179, 74)
        Me.BuscarEmpleadoButton.Name = "BuscarEmpleadoButton"
        Me.BuscarEmpleadoButton.Size = New System.Drawing.Size(48, 30)
        Me.BuscarEmpleadoButton.TabIndex = 3
        Me.BuscarEmpleadoButton.Text = "Buscar"
        Me.BuscarEmpleadoButton.UseVisualStyleBackColor = True
        '
        'IdMaskedTextBox
        '
        Me.IdMaskedTextBox.Location = New System.Drawing.Point(106, 46)
        Me.IdMaskedTextBox.Mask = "0000000000"
        Me.IdMaskedTextBox.Name = "IdMaskedTextBox"
        Me.IdMaskedTextBox.Size = New System.Drawing.Size(67, 20)
        Me.IdMaskedTextBox.TabIndex = 5
        Me.IdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Afiliacion Id:"
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(179, 44)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarButton.TabIndex = 6
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'NuevoButton
        '
        Me.NuevoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NuevoButton.Location = New System.Drawing.Point(189, 374)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoButton.TabIndex = 14
        Me.NuevoButton.Text = "Nuevo"
        Me.NuevoButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GuardarButton.Location = New System.Drawing.Point(271, 374)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarButton.TabIndex = 15
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EliminarButton.Location = New System.Drawing.Point(352, 374)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarButton.TabIndex = 16
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Checked = False
        Me.FechaDateTimePicker.CustomFormat = "yyyy/MM/dd "
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(501, 43)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(84, 20)
        Me.FechaDateTimePicker.TabIndex = 18
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.AgregarButton)
        Me.GroupBox1.Controls.Add(Me.DetalleDataGridView)
        Me.GroupBox1.Controls.Add(Me.InteresMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.PorcientoDescMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.BuscarPlanAhorroButton)
        Me.GroupBox1.Controls.Add(Me.PlanAhorroIdMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DescripcionPlanAhorroTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 240)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plan de Ahorros"
        '
        'AgregarButton
        '
        Me.AgregarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgregarButton.Location = New System.Drawing.Point(515, 13)
        Me.AgregarButton.Name = "AgregarButton"
        Me.AgregarButton.Size = New System.Drawing.Size(55, 30)
        Me.AgregarButton.TabIndex = 25
        Me.AgregarButton.Text = "Agregar"
        Me.AgregarButton.UseVisualStyleBackColor = True
        '
        'DetalleDataGridView
        '
        Me.DetalleDataGridView.AllowUserToAddRows = False
        Me.DetalleDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleDataGridView.Location = New System.Drawing.Point(30, 50)
        Me.DetalleDataGridView.Name = "DetalleDataGridView"
        Me.DetalleDataGridView.ReadOnly = True
        Me.DetalleDataGridView.Size = New System.Drawing.Size(540, 176)
        Me.DetalleDataGridView.TabIndex = 24
        '
        'InteresMaskedTextBox
        '
        Me.InteresMaskedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InteresMaskedTextBox.Enabled = False
        Me.InteresMaskedTextBox.Location = New System.Drawing.Point(450, 19)
        Me.InteresMaskedTextBox.Mask = "0000000000"
        Me.InteresMaskedTextBox.Name = "InteresMaskedTextBox"
        Me.InteresMaskedTextBox.Size = New System.Drawing.Size(59, 20)
        Me.InteresMaskedTextBox.TabIndex = 23
        Me.InteresMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'PorcientoDescMaskedTextBox
        '
        Me.PorcientoDescMaskedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PorcientoDescMaskedTextBox.Enabled = False
        Me.PorcientoDescMaskedTextBox.Location = New System.Drawing.Point(377, 19)
        Me.PorcientoDescMaskedTextBox.Mask = "0000000000"
        Me.PorcientoDescMaskedTextBox.Name = "PorcientoDescMaskedTextBox"
        Me.PorcientoDescMaskedTextBox.Size = New System.Drawing.Size(67, 20)
        Me.PorcientoDescMaskedTextBox.TabIndex = 22
        Me.PorcientoDescMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'BuscarPlanAhorroButton
        '
        Me.BuscarPlanAhorroButton.Location = New System.Drawing.Point(186, 13)
        Me.BuscarPlanAhorroButton.Name = "BuscarPlanAhorroButton"
        Me.BuscarPlanAhorroButton.Size = New System.Drawing.Size(48, 30)
        Me.BuscarPlanAhorroButton.TabIndex = 21
        Me.BuscarPlanAhorroButton.Text = "Buscar"
        Me.BuscarPlanAhorroButton.UseVisualStyleBackColor = True
        '
        'PlanAhorroIdMaskedTextBox
        '
        Me.PlanAhorroIdMaskedTextBox.Location = New System.Drawing.Point(125, 19)
        Me.PlanAhorroIdMaskedTextBox.Mask = "0000000000"
        Me.PlanAhorroIdMaskedTextBox.Name = "PlanAhorroIdMaskedTextBox"
        Me.PlanAhorroIdMaskedTextBox.Size = New System.Drawing.Size(55, 20)
        Me.PlanAhorroIdMaskedTextBox.TabIndex = 20
        Me.PlanAhorroIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Plan de Ahorro Id:"
        '
        'DescripcionPlanAhorroTextBox
        '
        Me.DescripcionPlanAhorroTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionPlanAhorroTextBox.Enabled = False
        Me.DescripcionPlanAhorroTextBox.Location = New System.Drawing.Point(240, 19)
        Me.DescripcionPlanAhorroTextBox.Name = "DescripcionPlanAhorroTextBox"
        Me.DescripcionPlanAhorroTextBox.Size = New System.Drawing.Size(131, 20)
        Me.DescripcionPlanAhorroTextBox.TabIndex = 18
        '
        'AfiliacionEmpleadosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 423)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.NuevoButton)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.IdMaskedTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BuscarEmpleadoButton)
        Me.Controls.Add(Me.EmpleadoIdMaskedTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmpleadoNombreTextBox)
        Me.Name = "AfiliacionEmpleadosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de afiliacion de empleados"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmpleadoNombreTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EmpleadoIdMaskedTextBox As MaskedTextBox
    Friend WithEvents BuscarEmpleadoButton As Button
    Friend WithEvents IdMaskedTextBox As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BuscarButton As Button
    Friend WithEvents NuevoButton As Button
    Friend WithEvents GuardarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AgregarButton As Button
    Friend WithEvents DetalleDataGridView As DataGridView
    Friend WithEvents InteresMaskedTextBox As MaskedTextBox
    Friend WithEvents PorcientoDescMaskedTextBox As MaskedTextBox
    Friend WithEvents BuscarPlanAhorroButton As Button
    Friend WithEvents PlanAhorroIdMaskedTextBox As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DescripcionPlanAhorroTextBox As TextBox
End Class
