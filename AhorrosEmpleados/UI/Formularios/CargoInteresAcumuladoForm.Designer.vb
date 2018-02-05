<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CargoInteresAcumuladoForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IntAcumuladoIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CargarInteresButton = New System.Windows.Forms.Button()
        Me.CargodeInteresDataGridView = New System.Windows.Forms.DataGridView()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.SalirButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.ModificarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.CargodeInteresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'IntAcumuladoIdMaskedTextBox
        '
        Me.IntAcumuladoIdMaskedTextBox.Location = New System.Drawing.Point(128, 32)
        Me.IntAcumuladoIdMaskedTextBox.Mask = "00000000000"
        Me.IntAcumuladoIdMaskedTextBox.Name = "IntAcumuladoIdMaskedTextBox"
        Me.IntAcumuladoIdMaskedTextBox.Size = New System.Drawing.Size(69, 20)
        Me.IntAcumuladoIdMaskedTextBox.TabIndex = 1
        Me.IntAcumuladoIdMaskedTextBox.ValidatingType = GetType(Integer)
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
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CustomFormat = "yyyy/MM/dd"
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(57, 67)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.FechaDateTimePicker.TabIndex = 16
        '
        'CargarInteresButton
        '
        Me.CargarInteresButton.Location = New System.Drawing.Point(501, 73)
        Me.CargarInteresButton.Name = "CargarInteresButton"
        Me.CargarInteresButton.Size = New System.Drawing.Size(73, 26)
        Me.CargarInteresButton.TabIndex = 18
        Me.CargarInteresButton.Text = "Calcular"
        Me.CargarInteresButton.UseVisualStyleBackColor = True
        '
        'CargodeInteresDataGridView
        '
        Me.CargodeInteresDataGridView.AllowUserToAddRows = False
        Me.CargodeInteresDataGridView.AllowUserToDeleteRows = False
        Me.CargodeInteresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CargodeInteresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CargodeInteresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CargodeInteresDataGridView.Location = New System.Drawing.Point(12, 105)
        Me.CargodeInteresDataGridView.Name = "CargodeInteresDataGridView"
        Me.CargodeInteresDataGridView.ReadOnly = True
        Me.CargodeInteresDataGridView.Size = New System.Drawing.Size(564, 209)
        Me.CargodeInteresDataGridView.TabIndex = 19
        '
        'GuardarButton
        '
        Me.GuardarButton.Location = New System.Drawing.Point(258, 355)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(73, 24)
        Me.GuardarButton.TabIndex = 20
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(416, 317)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(34, 20)
        Me.TotalLabel.TabIndex = 21
        Me.TotalLabel.Text = "0.0"
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImprimirButton.Location = New System.Drawing.Point(420, 355)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.ImprimirButton.TabIndex = 38
        Me.ImprimirButton.Text = "Imprimir"
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'SalirButton
        '
        Me.SalirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SalirButton.Location = New System.Drawing.Point(501, 355)
        Me.SalirButton.Name = "SalirButton"
        Me.SalirButton.Size = New System.Drawing.Size(75, 23)
        Me.SalirButton.TabIndex = 37
        Me.SalirButton.Text = "Salir"
        Me.SalirButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.Location = New System.Drawing.Point(177, 355)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 36
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'ModificarButton
        '
        Me.ModificarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ModificarButton.Location = New System.Drawing.Point(96, 355)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarButton.TabIndex = 35
        Me.ModificarButton.Text = "Modificar"
        Me.ModificarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Location = New System.Drawing.Point(339, 355)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarButton.TabIndex = 34
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'NuevoButton
        '
        Me.NuevoButton.Location = New System.Drawing.Point(12, 355)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoButton.TabIndex = 33
        Me.NuevoButton.Text = "Nuevo"
        Me.NuevoButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'CargoInteresAcumuladoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 390)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.SalirButton)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.NuevoButton)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.CargodeInteresDataGridView)
        Me.Controls.Add(Me.CargarInteresButton)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.IntAcumuladoIdMaskedTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CargoInteresAcumuladoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargo de intereses acumulados"
        CType(Me.CargodeInteresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IntAcumuladoIdMaskedTextBox As MaskedTextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents CargarInteresButton As Button
    Friend WithEvents CargodeInteresDataGridView As DataGridView
    Friend WithEvents GuardarButton As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents ImprimirButton As Button
    Friend WithEvents SalirButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents ModificarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents NuevoButton As Button
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
