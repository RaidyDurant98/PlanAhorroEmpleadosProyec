<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanAhorrosForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PorcientoDescMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PlanIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.InteresMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FondoMinimoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plan Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Porciento de Descuento:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Location = New System.Drawing.Point(131, 88)
        Me.DescripcionTextBox.MaxLength = 255
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(167, 64)
        Me.DescripcionTextBox.TabIndex = 0
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(223, 57)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarButton.TabIndex = 6
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Location = New System.Drawing.Point(223, 265)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarButton.TabIndex = 7
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Location = New System.Drawing.Point(142, 265)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarButton.TabIndex = 4
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'NuevoButton
        '
        Me.NuevoButton.Location = New System.Drawing.Point(61, 265)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoButton.TabIndex = 5
        Me.NuevoButton.Text = "Nuevo"
        Me.NuevoButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PorcientoDescMaskedTextBox
        '
        Me.PorcientoDescMaskedTextBox.Location = New System.Drawing.Point(189, 162)
        Me.PorcientoDescMaskedTextBox.Mask = "00000000000000000"
        Me.PorcientoDescMaskedTextBox.Name = "PorcientoDescMaskedTextBox"
        Me.PorcientoDescMaskedTextBox.Size = New System.Drawing.Size(109, 20)
        Me.PorcientoDescMaskedTextBox.TabIndex = 1
        Me.PorcientoDescMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'PlanIdMaskedTextBox
        '
        Me.PlanIdMaskedTextBox.Location = New System.Drawing.Point(108, 59)
        Me.PlanIdMaskedTextBox.Mask = "00000000000000000"
        Me.PlanIdMaskedTextBox.Name = "PlanIdMaskedTextBox"
        Me.PlanIdMaskedTextBox.Size = New System.Drawing.Size(109, 20)
        Me.PlanIdMaskedTextBox.TabIndex = 8
        Me.PlanIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'InteresMaskedTextBox
        '
        Me.InteresMaskedTextBox.Location = New System.Drawing.Point(131, 191)
        Me.InteresMaskedTextBox.Mask = "000000000000000000000000000"
        Me.InteresMaskedTextBox.Name = "InteresMaskedTextBox"
        Me.InteresMaskedTextBox.Size = New System.Drawing.Size(168, 20)
        Me.InteresMaskedTextBox.TabIndex = 2
        Me.InteresMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Interes:"
        '
        'FondoMinimoMaskedTextBox
        '
        Me.FondoMinimoMaskedTextBox.Location = New System.Drawing.Point(141, 221)
        Me.FondoMinimoMaskedTextBox.Mask = "000000000000000000000000000"
        Me.FondoMinimoMaskedTextBox.Name = "FondoMinimoMaskedTextBox"
        Me.FondoMinimoMaskedTextBox.Size = New System.Drawing.Size(158, 20)
        Me.FondoMinimoMaskedTextBox.TabIndex = 3
        Me.FondoMinimoMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Fondo Minimo:"
        '
        'PlanAhorrosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 327)
        Me.Controls.Add(Me.FondoMinimoMaskedTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.InteresMaskedTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PlanIdMaskedTextBox)
        Me.Controls.Add(Me.PorcientoDescMaskedTextBox)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.NuevoButton)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PlanAhorrosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan de Ahorros"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents GuardarButton As Button
    Friend WithEvents NuevoButton As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents PorcientoDescMaskedTextBox As MaskedTextBox
    Friend WithEvents PlanIdMaskedTextBox As MaskedTextBox
    Friend WithEvents InteresMaskedTextBox As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FondoMinimoMaskedTextBox As MaskedTextBox
    Friend WithEvents Label5 As Label
End Class
