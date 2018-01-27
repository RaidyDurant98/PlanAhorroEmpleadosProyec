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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CargarInteresButton = New System.Windows.Forms.Button()
        Me.CargodeInteresDataGridView = New System.Windows.Forms.DataGridView()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanAhorro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresAcumulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CargodeInteresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Interes Acumulado Id:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(128, 32)
        Me.MaskedTextBox1.Mask = "00000000000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(69, 20)
        Me.MaskedTextBox1.TabIndex = 1
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(203, 30)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarButton.TabIndex = 2
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(57, 67)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'CargarInteresButton
        '
        Me.CargarInteresButton.Location = New System.Drawing.Point(203, 330)
        Me.CargarInteresButton.Name = "CargarInteresButton"
        Me.CargarInteresButton.Size = New System.Drawing.Size(87, 37)
        Me.CargarInteresButton.TabIndex = 18
        Me.CargarInteresButton.Text = "Cargar interes"
        Me.CargarInteresButton.UseVisualStyleBackColor = True
        '
        'CargodeInteresDataGridView
        '
        Me.CargodeInteresDataGridView.AllowUserToAddRows = False
        Me.CargodeInteresDataGridView.AllowUserToDeleteRows = False
        Me.CargodeInteresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CargodeInteresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CargodeInteresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CargodeInteresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.PlanAhorro, Me.InteresAcumulado})
        Me.CargodeInteresDataGridView.Location = New System.Drawing.Point(12, 105)
        Me.CargodeInteresDataGridView.Name = "CargodeInteresDataGridView"
        Me.CargodeInteresDataGridView.ReadOnly = True
        Me.CargodeInteresDataGridView.Size = New System.Drawing.Size(471, 209)
        Me.CargodeInteresDataGridView.TabIndex = 19
        '
        'Empleado
        '
        Me.Empleado.DataPropertyName = "Nombres"
        Me.Empleado.HeaderText = "Nombres"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        '
        'PlanAhorro
        '
        Me.PlanAhorro.DataPropertyName = "Descripcion"
        Me.PlanAhorro.HeaderText = "Plan de Ahorro"
        Me.PlanAhorro.Name = "PlanAhorro"
        Me.PlanAhorro.ReadOnly = True
        '
        'InteresAcumulado
        '
        Me.InteresAcumulado.DataPropertyName = "InteresAcumulado"
        Me.InteresAcumulado.HeaderText = "InteresAcumulado"
        Me.InteresAcumulado.Name = "InteresAcumulado"
        Me.InteresAcumulado.ReadOnly = True
        '
        'CargoInteresAcumuladoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 389)
        Me.Controls.Add(Me.CargodeInteresDataGridView)
        Me.Controls.Add(Me.CargarInteresButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CargoInteresAcumuladoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargo de intereses acumulados"
        CType(Me.CargodeInteresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CargarInteresButton As Button
    Friend WithEvents CargodeInteresDataGridView As DataGridView
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents PlanAhorro As DataGridViewTextBoxColumn
    Friend WithEvents InteresAcumulado As DataGridViewTextBoxColumn
End Class
