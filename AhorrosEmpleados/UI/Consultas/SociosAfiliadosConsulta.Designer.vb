<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SociosAfiliadosConsulta
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
        Me.FiltrarButton = New System.Windows.Forms.Button()
        Me.FiltrarComboBox = New System.Windows.Forms.ComboBox()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.ConsultaDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmpleadoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltrarTextBox = New System.Windows.Forms.TextBox()
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FiltrarButton
        '
        Me.FiltrarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltrarButton.Location = New System.Drawing.Point(256, 47)
        Me.FiltrarButton.Name = "FiltrarButton"
        Me.FiltrarButton.Size = New System.Drawing.Size(75, 23)
        Me.FiltrarButton.TabIndex = 6
        Me.FiltrarButton.Text = "Filtrar"
        Me.FiltrarButton.UseVisualStyleBackColor = True
        '
        'FiltrarComboBox
        '
        Me.FiltrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FiltrarComboBox.FormattingEnabled = True
        Me.FiltrarComboBox.Items.AddRange(New Object() {"Todos", "Empleado Id", "Nombres", "Plan Ahorro"})
        Me.FiltrarComboBox.Location = New System.Drawing.Point(25, 49)
        Me.FiltrarComboBox.Name = "FiltrarComboBox"
        Me.FiltrarComboBox.Size = New System.Drawing.Size(90, 21)
        Me.FiltrarComboBox.TabIndex = 5
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImprimirButton.Location = New System.Drawing.Point(13, 316)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.ImprimirButton.TabIndex = 9
        Me.ImprimirButton.Text = "Imprimir"
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'ConsultaDataGridView
        '
        Me.ConsultaDataGridView.AllowUserToAddRows = False
        Me.ConsultaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConsultaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ConsultaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpleadoId, Me.Nombres, Me.Descripcion})
        Me.ConsultaDataGridView.Location = New System.Drawing.Point(12, 98)
        Me.ConsultaDataGridView.Name = "ConsultaDataGridView"
        Me.ConsultaDataGridView.Size = New System.Drawing.Size(524, 201)
        Me.ConsultaDataGridView.TabIndex = 8
        '
        'EmpleadoId
        '
        Me.EmpleadoId.DataPropertyName = "EmpleadoId"
        Me.EmpleadoId.HeaderText = "Empleado Id"
        Me.EmpleadoId.Name = "EmpleadoId"
        '
        'Nombres
        '
        Me.Nombres.DataPropertyName = "Nombres"
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Plan Ahorro"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'FiltrarTextBox
        '
        Me.FiltrarTextBox.Location = New System.Drawing.Point(121, 50)
        Me.FiltrarTextBox.Name = "FiltrarTextBox"
        Me.FiltrarTextBox.Size = New System.Drawing.Size(129, 20)
        Me.FiltrarTextBox.TabIndex = 11
        '
        'SociosAfiliadosConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 379)
        Me.Controls.Add(Me.FiltrarTextBox)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.ConsultaDataGridView)
        Me.Controls.Add(Me.FiltrarButton)
        Me.Controls.Add(Me.FiltrarComboBox)
        Me.Name = "SociosAfiliadosConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de socios afiliados "
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FiltrarButton As Button
    Friend WithEvents FiltrarComboBox As ComboBox
    Friend WithEvents ImprimirButton As Button
    Friend WithEvents ConsultaDataGridView As DataGridView
    Friend WithEvents EmpleadoId As DataGridViewTextBoxColumn
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents FiltrarTextBox As TextBox
End Class
