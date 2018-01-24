<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanAhorrosConsulta
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
        Me.ConsultaDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcientoDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcientoInteres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltrarComboBox = New System.Windows.Forms.ComboBox()
        Me.FiltrarButton = New System.Windows.Forms.Button()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.FiltrarTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultaDataGridView
        '
        Me.ConsultaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConsultaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Descripcion, Me.PorcientoDescuento, Me.PorcientoInteres})
        Me.ConsultaDataGridView.Location = New System.Drawing.Point(12, 99)
        Me.ConsultaDataGridView.Name = "ConsultaDataGridView"
        Me.ConsultaDataGridView.Size = New System.Drawing.Size(445, 150)
        Me.ConsultaDataGridView.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "PlanId"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'PorcientoDescuento
        '
        Me.PorcientoDescuento.DataPropertyName = "PorcientoDesc"
        Me.PorcientoDescuento.HeaderText = "% Descuento"
        Me.PorcientoDescuento.Name = "PorcientoDescuento"
        '
        'PorcientoInteres
        '
        Me.PorcientoInteres.DataPropertyName = "Interes"
        Me.PorcientoInteres.HeaderText = "% Interes"
        Me.PorcientoInteres.Name = "PorcientoInteres"
        '
        'FiltrarComboBox
        '
        Me.FiltrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FiltrarComboBox.FormattingEnabled = True
        Me.FiltrarComboBox.Items.AddRange(New Object() {"Todos", "ID", "Decripcion"})
        Me.FiltrarComboBox.Location = New System.Drawing.Point(12, 58)
        Me.FiltrarComboBox.Name = "FiltrarComboBox"
        Me.FiltrarComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FiltrarComboBox.TabIndex = 1
        '
        'FiltrarButton
        '
        Me.FiltrarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltrarButton.Location = New System.Drawing.Point(344, 56)
        Me.FiltrarButton.Name = "FiltrarButton"
        Me.FiltrarButton.Size = New System.Drawing.Size(75, 23)
        Me.FiltrarButton.TabIndex = 2
        Me.FiltrarButton.Text = "Filtrar"
        Me.FiltrarButton.UseVisualStyleBackColor = True
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImprimirButton.Location = New System.Drawing.Point(13, 266)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.ImprimirButton.TabIndex = 3
        Me.ImprimirButton.Text = "Imprimir"
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'FiltrarTextBox
        '
        Me.FiltrarTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltrarTextBox.Location = New System.Drawing.Point(139, 58)
        Me.FiltrarTextBox.Name = "FiltrarTextBox"
        Me.FiltrarTextBox.Size = New System.Drawing.Size(199, 20)
        Me.FiltrarTextBox.TabIndex = 4
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PlanAhorrosConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 328)
        Me.Controls.Add(Me.FiltrarTextBox)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.FiltrarButton)
        Me.Controls.Add(Me.FiltrarComboBox)
        Me.Controls.Add(Me.ConsultaDataGridView)
        Me.Name = "PlanAhorrosConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta plan ahorros"
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConsultaDataGridView As DataGridView
    Friend WithEvents FiltrarComboBox As ComboBox
    Friend WithEvents FiltrarButton As Button
    Friend WithEvents ImprimirButton As Button
    Friend WithEvents FiltrarTextBox As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PorcientoDescuento As DataGridViewTextBoxColumn
    Friend WithEvents PorcientoInteres As DataGridViewTextBoxColumn
End Class
