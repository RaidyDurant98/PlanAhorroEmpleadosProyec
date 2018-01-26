<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargoInteresAcumuladoForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlanAhorroComboBox = New System.Windows.Forms.ComboBox()
        Me.NombresEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BuscarEmpleadoButton = New System.Windows.Forms.Button()
        Me.EmpleadoIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CargarInteresButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CargoInteresTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Interes Acumulado Id:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(137, 37)
        Me.MaskedTextBox1.Mask = "00000000000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(69, 20)
        Me.MaskedTextBox1.TabIndex = 1
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(212, 35)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarButton.TabIndex = 2
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Plan Ahorro:"
        '
        'PlanAhorroComboBox
        '
        Me.PlanAhorroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlanAhorroComboBox.FormattingEnabled = True
        Me.PlanAhorroComboBox.Location = New System.Drawing.Point(96, 107)
        Me.PlanAhorroComboBox.Name = "PlanAhorroComboBox"
        Me.PlanAhorroComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PlanAhorroComboBox.TabIndex = 11
        '
        'NombresEmpleadoTextBox
        '
        Me.NombresEmpleadoTextBox.Location = New System.Drawing.Point(217, 74)
        Me.NombresEmpleadoTextBox.Name = "NombresEmpleadoTextBox"
        Me.NombresEmpleadoTextBox.ReadOnly = True
        Me.NombresEmpleadoTextBox.Size = New System.Drawing.Size(156, 20)
        Me.NombresEmpleadoTextBox.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Empleado Id:"
        '
        'BuscarEmpleadoButton
        '
        Me.BuscarEmpleadoButton.Location = New System.Drawing.Point(162, 70)
        Me.BuscarEmpleadoButton.Name = "BuscarEmpleadoButton"
        Me.BuscarEmpleadoButton.Size = New System.Drawing.Size(49, 29)
        Me.BuscarEmpleadoButton.TabIndex = 10
        Me.BuscarEmpleadoButton.Text = "Buscar"
        Me.BuscarEmpleadoButton.UseVisualStyleBackColor = True
        '
        'EmpleadoIdMaskedTextBox
        '
        Me.EmpleadoIdMaskedTextBox.Location = New System.Drawing.Point(96, 75)
        Me.EmpleadoIdMaskedTextBox.Mask = "000000000"
        Me.EmpleadoIdMaskedTextBox.Name = "EmpleadoIdMaskedTextBox"
        Me.EmpleadoIdMaskedTextBox.Size = New System.Drawing.Size(60, 20)
        Me.EmpleadoIdMaskedTextBox.TabIndex = 9
        Me.EmpleadoIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(67, 138)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'CargarInteresButton
        '
        Me.CargarInteresButton.Location = New System.Drawing.Point(148, 290)
        Me.CargarInteresButton.Name = "CargarInteresButton"
        Me.CargarInteresButton.Size = New System.Drawing.Size(87, 37)
        Me.CargarInteresButton.TabIndex = 18
        Me.CargarInteresButton.Text = "Cargar interes"
        Me.CargarInteresButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CargoInteresTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 98)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cargo del interes"
        '
        'CargoInteresTextBox
        '
        Me.CargoInteresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CargoInteresTextBox.Location = New System.Drawing.Point(104, 38)
        Me.CargoInteresTextBox.Multiline = True
        Me.CargoInteresTextBox.Name = "CargoInteresTextBox"
        Me.CargoInteresTextBox.ReadOnly = True
        Me.CargoInteresTextBox.Size = New System.Drawing.Size(156, 42)
        Me.CargoInteresTextBox.TabIndex = 15
        '
        'CargoInteresAcumuladoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 339)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CargarInteresButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PlanAhorroComboBox)
        Me.Controls.Add(Me.NombresEmpleadoTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BuscarEmpleadoButton)
        Me.Controls.Add(Me.EmpleadoIdMaskedTextBox)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CargoInteresAcumuladoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargo de intereses acumulados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PlanAhorroComboBox As ComboBox
    Friend WithEvents NombresEmpleadoTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BuscarEmpleadoButton As Button
    Friend WithEvents EmpleadoIdMaskedTextBox As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CargarInteresButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CargoInteresTextBox As TextBox
End Class
