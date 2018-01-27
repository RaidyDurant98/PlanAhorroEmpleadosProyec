<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadosForm
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
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumCelMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SueldoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmpleadoIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ModificarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.SalirButton = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(189, 50)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarButton.TabIndex = 7
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Location = New System.Drawing.Point(99, 80)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(165, 20)
        Me.NombresTextBox.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sueldo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empleado Id:"
        '
        'NuevoButton
        '
        Me.NuevoButton.Location = New System.Drawing.Point(15, 257)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoButton.TabIndex = 5
        Me.NuevoButton.Text = "Nuevo"
        Me.NuevoButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Location = New System.Drawing.Point(261, 257)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarButton.TabIndex = 4
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Location = New System.Drawing.Point(342, 257)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarButton.TabIndex = 8
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(99, 108)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(165, 20)
        Me.DireccionTextBox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Direccion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Numero celular:"
        '
        'NumCelMaskedTextBox
        '
        Me.NumCelMaskedTextBox.Location = New System.Drawing.Point(99, 138)
        Me.NumCelMaskedTextBox.Mask = "(999) 000-0000"
        Me.NumCelMaskedTextBox.Name = "NumCelMaskedTextBox"
        Me.NumCelMaskedTextBox.Size = New System.Drawing.Size(165, 20)
        Me.NumCelMaskedTextBox.TabIndex = 2
        '
        'SueldoMaskedTextBox
        '
        Me.SueldoMaskedTextBox.Location = New System.Drawing.Point(99, 167)
        Me.SueldoMaskedTextBox.Mask = "000000000000000000000000000"
        Me.SueldoMaskedTextBox.Name = "SueldoMaskedTextBox"
        Me.SueldoMaskedTextBox.Size = New System.Drawing.Size(165, 20)
        Me.SueldoMaskedTextBox.TabIndex = 3
        Me.SueldoMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'EmpleadoIdMaskedTextBox
        '
        Me.EmpleadoIdMaskedTextBox.Location = New System.Drawing.Point(99, 52)
        Me.EmpleadoIdMaskedTextBox.Mask = "000000000000"
        Me.EmpleadoIdMaskedTextBox.Name = "EmpleadoIdMaskedTextBox"
        Me.EmpleadoIdMaskedTextBox.Size = New System.Drawing.Size(75, 20)
        Me.EmpleadoIdMaskedTextBox.TabIndex = 6
        Me.EmpleadoIdMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'ModificarButton
        '
        Me.ModificarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ModificarButton.Location = New System.Drawing.Point(99, 257)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarButton.TabIndex = 22
        Me.ModificarButton.Text = "Modificar"
        Me.ModificarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.Location = New System.Drawing.Point(180, 257)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 23
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImprimirButton.Location = New System.Drawing.Point(423, 257)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.ImprimirButton.TabIndex = 31
        Me.ImprimirButton.Text = "Imprimir"
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'SalirButton
        '
        Me.SalirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SalirButton.Location = New System.Drawing.Point(504, 257)
        Me.SalirButton.Name = "SalirButton"
        Me.SalirButton.Size = New System.Drawing.Size(75, 23)
        Me.SalirButton.TabIndex = 30
        Me.SalirButton.Text = "Salir"
        Me.SalirButton.UseVisualStyleBackColor = True
        '
        'EmpleadosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 309)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.SalirButton)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.EmpleadoIdMaskedTextBox)
        Me.Controls.Add(Me.SueldoMaskedTextBox)
        Me.Controls.Add(Me.NumCelMaskedTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.NuevoButton)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "EmpleadosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BuscarButton As Button
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NuevoButton As Button
    Friend WithEvents GuardarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumCelMaskedTextBox As MaskedTextBox
    Friend WithEvents SueldoMaskedTextBox As MaskedTextBox
    Friend WithEvents EmpleadoIdMaskedTextBox As MaskedTextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ModificarButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents ImprimirButton As Button
    Friend WithEvents SalirButton As Button
End Class
