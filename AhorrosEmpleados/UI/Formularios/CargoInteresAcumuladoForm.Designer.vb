﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IntAcumuladoIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CargarInteresButton = New System.Windows.Forms.Button()
        Me.CargodeInteresDataGridView = New System.Windows.Forms.DataGridView()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanAhorro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcientoDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInteres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Interes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresAcumulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanAhorroId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntAcumuladoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.CargarInteresButton.Location = New System.Drawing.Point(478, 73)
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
        Me.CargodeInteresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.PlanAhorro, Me.Sueldo, Me.PorcientoDesc, Me.FechaInteres, Me.Interes, Me.Aporte, Me.InteresAcumulado, Me.EmpleadoId, Me.PlanAhorroId, Me.IntAcumuladoId})
        Me.CargodeInteresDataGridView.Location = New System.Drawing.Point(12, 105)
        Me.CargodeInteresDataGridView.Name = "CargodeInteresDataGridView"
        Me.CargodeInteresDataGridView.ReadOnly = True
        Me.CargodeInteresDataGridView.Size = New System.Drawing.Size(539, 209)
        Me.CargodeInteresDataGridView.TabIndex = 19
        '
        'GuardarButton
        '
        Me.GuardarButton.Location = New System.Drawing.Point(243, 352)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(73, 26)
        Me.GuardarButton.TabIndex = 20
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(474, 317)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(34, 20)
        Me.TotalLabel.TabIndex = 21
        Me.TotalLabel.Text = "0.0"
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
        'Sueldo
        '
        Me.Sueldo.DataPropertyName = "Sueldo"
        Me.Sueldo.HeaderText = "Sueldo"
        Me.Sueldo.Name = "Sueldo"
        Me.Sueldo.ReadOnly = True
        '
        'PorcientoDesc
        '
        Me.PorcientoDesc.DataPropertyName = "PorcientoDesc"
        Me.PorcientoDesc.HeaderText = "% Descuento"
        Me.PorcientoDesc.Name = "PorcientoDesc"
        Me.PorcientoDesc.ReadOnly = True
        '
        'FechaInteres
        '
        Me.FechaInteres.DataPropertyName = "diferenciameses"
        Me.FechaInteres.HeaderText = "Tiempo del Interes"
        Me.FechaInteres.Name = "FechaInteres"
        Me.FechaInteres.ReadOnly = True
        '
        'Interes
        '
        Me.Interes.DataPropertyName = "Interes"
        Me.Interes.HeaderText = "% Interes Banco"
        Me.Interes.Name = "Interes"
        Me.Interes.ReadOnly = True
        '
        'Aporte
        '
        Me.Aporte.DataPropertyName = "Aporte"
        Me.Aporte.HeaderText = "Aporte"
        Me.Aporte.Name = "Aporte"
        Me.Aporte.ReadOnly = True
        '
        'InteresAcumulado
        '
        Me.InteresAcumulado.DataPropertyName = "Total"
        DataGridViewCellStyle2.Format = "n2"
        Me.InteresAcumulado.DefaultCellStyle = DataGridViewCellStyle2
        Me.InteresAcumulado.HeaderText = "InteresAcumulado"
        Me.InteresAcumulado.Name = "InteresAcumulado"
        Me.InteresAcumulado.ReadOnly = True
        '
        'EmpleadoId
        '
        Me.EmpleadoId.DataPropertyName = "EmpleadoId"
        Me.EmpleadoId.HeaderText = "EmpleadoId"
        Me.EmpleadoId.Name = "EmpleadoId"
        Me.EmpleadoId.ReadOnly = True
        '
        'PlanAhorroId
        '
        Me.PlanAhorroId.DataPropertyName = "PlanId"
        Me.PlanAhorroId.HeaderText = "PlanAhorroId"
        Me.PlanAhorroId.Name = "PlanAhorroId"
        Me.PlanAhorroId.ReadOnly = True
        '
        'IntAcumuladoId
        '
        Me.IntAcumuladoId.DataPropertyName = "IntAcumuladoId"
        Me.IntAcumuladoId.HeaderText = "IntAcumuladoId"
        Me.IntAcumuladoId.Name = "IntAcumuladoId"
        Me.IntAcumuladoId.ReadOnly = True
        '
        'CargoInteresAcumuladoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 390)
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
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents PlanAhorro As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As DataGridViewTextBoxColumn
    Friend WithEvents PorcientoDesc As DataGridViewTextBoxColumn
    Friend WithEvents FechaInteres As DataGridViewTextBoxColumn
    Friend WithEvents Interes As DataGridViewTextBoxColumn
    Friend WithEvents Aporte As DataGridViewTextBoxColumn
    Friend WithEvents InteresAcumulado As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoId As DataGridViewTextBoxColumn
    Friend WithEvents PlanAhorroId As DataGridViewTextBoxColumn
    Friend WithEvents IntAcumuladoId As DataGridViewTextBoxColumn
End Class
