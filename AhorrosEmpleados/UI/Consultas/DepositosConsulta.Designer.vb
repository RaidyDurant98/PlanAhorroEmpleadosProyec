﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepositosConsulta
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
        Me.FiltrarTextBox = New System.Windows.Forms.TextBox()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.FiltrarButton = New System.Windows.Forms.Button()
        Me.FiltrarComboBox = New System.Windows.Forms.ComboBox()
        Me.ConsultaDataGridView = New System.Windows.Forms.DataGridView()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanAhorro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HastaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DesdeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FiltrarTextBox
        '
        Me.FiltrarTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltrarTextBox.Location = New System.Drawing.Point(142, 21)
        Me.FiltrarTextBox.Name = "FiltrarTextBox"
        Me.FiltrarTextBox.Size = New System.Drawing.Size(325, 20)
        Me.FiltrarTextBox.TabIndex = 9
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImprimirButton.Location = New System.Drawing.Point(10, 319)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.ImprimirButton.TabIndex = 8
        Me.ImprimirButton.Text = "Imprimir"
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'FiltrarButton
        '
        Me.FiltrarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltrarButton.Location = New System.Drawing.Point(473, 19)
        Me.FiltrarButton.Name = "FiltrarButton"
        Me.FiltrarButton.Size = New System.Drawing.Size(75, 23)
        Me.FiltrarButton.TabIndex = 7
        Me.FiltrarButton.Text = "Filtrar"
        Me.FiltrarButton.UseVisualStyleBackColor = True
        '
        'FiltrarComboBox
        '
        Me.FiltrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FiltrarComboBox.FormattingEnabled = True
        Me.FiltrarComboBox.Items.AddRange(New Object() {"Todos", "Empleado", "Plan de Ahorro", "Fecha"})
        Me.FiltrarComboBox.Location = New System.Drawing.Point(15, 20)
        Me.FiltrarComboBox.Name = "FiltrarComboBox"
        Me.FiltrarComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FiltrarComboBox.TabIndex = 6
        '
        'ConsultaDataGridView
        '
        Me.ConsultaDataGridView.AllowUserToAddRows = False
        Me.ConsultaDataGridView.AllowUserToDeleteRows = False
        Me.ConsultaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConsultaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ConsultaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.PlanAhorro, Me.Aporte})
        Me.ConsultaDataGridView.Location = New System.Drawing.Point(10, 102)
        Me.ConsultaDataGridView.Name = "ConsultaDataGridView"
        Me.ConsultaDataGridView.ReadOnly = True
        Me.ConsultaDataGridView.Size = New System.Drawing.Size(553, 202)
        Me.ConsultaDataGridView.TabIndex = 5
        '
        'Empleado
        '
        Me.Empleado.DataPropertyName = "Nombres"
        Me.Empleado.HeaderText = "Empleado"
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
        'Aporte
        '
        Me.Aporte.DataPropertyName = "Aporte"
        Me.Aporte.HeaderText = "Aporte $"
        Me.Aporte.Name = "Aporte"
        Me.Aporte.ReadOnly = True
        '
        'HastaDateTimePicker
        '
        Me.HastaDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HastaDateTimePicker.CustomFormat = "yyyy/MM/dd"
        Me.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HastaDateTimePicker.Location = New System.Drawing.Point(348, 66)
        Me.HastaDateTimePicker.Name = "HastaDateTimePicker"
        Me.HastaDateTimePicker.Size = New System.Drawing.Size(102, 20)
        Me.HastaDateTimePicker.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Hasta:"
        '
        'DesdeDateTimePicker
        '
        Me.DesdeDateTimePicker.CustomFormat = "yyyy/MM/dd"
        Me.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DesdeDateTimePicker.Location = New System.Drawing.Point(163, 66)
        Me.DesdeDateTimePicker.Name = "DesdeDateTimePicker"
        Me.DesdeDateTimePicker.Size = New System.Drawing.Size(102, 20)
        Me.DesdeDateTimePicker.TabIndex = 24
        '
        'DepositosConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 359)
        Me.Controls.Add(Me.HastaDateTimePicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DesdeDateTimePicker)
        Me.Controls.Add(Me.FiltrarTextBox)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.FiltrarButton)
        Me.Controls.Add(Me.FiltrarComboBox)
        Me.Controls.Add(Me.ConsultaDataGridView)
        Me.Name = "DepositosConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de depositos"
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FiltrarTextBox As TextBox
    Friend WithEvents ImprimirButton As Button
    Friend WithEvents FiltrarButton As Button
    Friend WithEvents FiltrarComboBox As ComboBox
    Friend WithEvents ConsultaDataGridView As DataGridView
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents PlanAhorro As DataGridViewTextBoxColumn
    Friend WithEvents Aporte As DataGridViewTextBoxColumn
    Friend WithEvents HastaDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DesdeDateTimePicker As DateTimePicker
End Class
