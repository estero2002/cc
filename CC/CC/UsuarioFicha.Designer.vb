<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioFicha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuarioFicha))
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmbIdioma = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDNI = New System.Windows.Forms.TextBox
        Me.txtLegajo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblMsjValidNombre = New System.Windows.Forms.Label
        Me.telefonosGrid = New System.Windows.Forms.DataGridView
        Me.btnEditTelefono = New System.Windows.Forms.Button
        Me.btnNewTelefono = New System.Windows.Forms.Button
        Me.btnDeleteTelefono = New System.Windows.Forms.Button
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblMsjEnvioPassword = New System.Windows.Forms.Label
        CType(Me.telefonosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.AccessibleDescription = Nothing
        Me.cmdSalir.AccessibleName = Nothing
        resources.ApplyResources(Me.cmdSalir, "cmdSalir")
        Me.cmdSalir.BackgroundImage = Nothing
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Font = Nothing
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.AccessibleDescription = Nothing
        Me.cmdAceptar.AccessibleName = Nothing
        resources.ApplyResources(Me.cmdAceptar, "cmdAceptar")
        Me.cmdAceptar.BackgroundImage = Nothing
        Me.cmdAceptar.Font = Nothing
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmbIdioma
        '
        Me.cmbIdioma.AccessibleDescription = Nothing
        Me.cmbIdioma.AccessibleName = Nothing
        resources.ApplyResources(Me.cmbIdioma, "cmbIdioma")
        Me.cmbIdioma.BackgroundImage = Nothing
        Me.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdioma.Font = Nothing
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.Name = "cmbIdioma"
        '
        'Label11
        '
        Me.Label11.AccessibleDescription = Nothing
        Me.Label11.AccessibleName = Nothing
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Font = Nothing
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = Nothing
        Me.Label10.AccessibleName = Nothing
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Font = Nothing
        Me.Label10.Name = "Label10"
        '
        'txtPassword
        '
        Me.txtPassword.AccessibleDescription = Nothing
        Me.txtPassword.AccessibleName = Nothing
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.BackgroundImage = Nothing
        Me.txtPassword.Font = Nothing
        Me.txtPassword.Name = "txtPassword"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Font = Nothing
        Me.Label9.Name = "Label9"
        '
        'txtUsuario
        '
        Me.txtUsuario.AccessibleDescription = Nothing
        Me.txtUsuario.AccessibleName = Nothing
        resources.ApplyResources(Me.txtUsuario, "txtUsuario")
        Me.txtUsuario.BackgroundImage = Nothing
        Me.txtUsuario.Font = Nothing
        Me.txtUsuario.Name = "txtUsuario"
        '
        'txtDireccion
        '
        Me.txtDireccion.AccessibleDescription = Nothing
        Me.txtDireccion.AccessibleName = Nothing
        resources.ApplyResources(Me.txtDireccion, "txtDireccion")
        Me.txtDireccion.BackgroundImage = Nothing
        Me.txtDireccion.Font = Nothing
        Me.txtDireccion.Name = "txtDireccion"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Font = Nothing
        Me.Label5.Name = "Label5"
        '
        'txtNombre
        '
        Me.txtNombre.AccessibleDescription = Nothing
        Me.txtNombre.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNombre, "txtNombre")
        Me.txtNombre.BackgroundImage = Nothing
        Me.txtNombre.Font = Nothing
        Me.txtNombre.Name = "txtNombre"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'txtApellido
        '
        Me.txtApellido.AccessibleDescription = Nothing
        Me.txtApellido.AccessibleName = Nothing
        resources.ApplyResources(Me.txtApellido, "txtApellido")
        Me.txtApellido.BackgroundImage = Nothing
        Me.txtApellido.Font = Nothing
        Me.txtApellido.Name = "txtApellido"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'txtDNI
        '
        Me.txtDNI.AccessibleDescription = Nothing
        Me.txtDNI.AccessibleName = Nothing
        resources.ApplyResources(Me.txtDNI, "txtDNI")
        Me.txtDNI.BackgroundImage = Nothing
        Me.txtDNI.Font = Nothing
        Me.txtDNI.Name = "txtDNI"
        '
        'txtLegajo
        '
        Me.txtLegajo.AccessibleDescription = Nothing
        Me.txtLegajo.AccessibleName = Nothing
        resources.ApplyResources(Me.txtLegajo, "txtLegajo")
        Me.txtLegajo.BackgroundImage = Nothing
        Me.txtLegajo.Font = Nothing
        Me.txtLegajo.Name = "txtLegajo"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'lblMsjValidNombre
        '
        Me.lblMsjValidNombre.AccessibleDescription = Nothing
        Me.lblMsjValidNombre.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjValidNombre, "lblMsjValidNombre")
        Me.lblMsjValidNombre.Font = Nothing
        Me.lblMsjValidNombre.Name = "lblMsjValidNombre"
        '
        'telefonosGrid
        '
        Me.telefonosGrid.AccessibleDescription = Nothing
        Me.telefonosGrid.AccessibleName = Nothing
        Me.telefonosGrid.AllowUserToAddRows = False
        Me.telefonosGrid.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.telefonosGrid, "telefonosGrid")
        Me.telefonosGrid.BackgroundImage = Nothing
        Me.telefonosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.telefonosGrid.Font = Nothing
        Me.telefonosGrid.Name = "telefonosGrid"
        Me.telefonosGrid.ReadOnly = True
        '
        'btnEditTelefono
        '
        Me.btnEditTelefono.AccessibleDescription = Nothing
        Me.btnEditTelefono.AccessibleName = Nothing
        resources.ApplyResources(Me.btnEditTelefono, "btnEditTelefono")
        Me.btnEditTelefono.BackgroundImage = Nothing
        Me.btnEditTelefono.Font = Nothing
        Me.btnEditTelefono.Name = "btnEditTelefono"
        Me.btnEditTelefono.UseVisualStyleBackColor = True
        '
        'btnNewTelefono
        '
        Me.btnNewTelefono.AccessibleDescription = Nothing
        Me.btnNewTelefono.AccessibleName = Nothing
        resources.ApplyResources(Me.btnNewTelefono, "btnNewTelefono")
        Me.btnNewTelefono.BackgroundImage = Nothing
        Me.btnNewTelefono.Font = Nothing
        Me.btnNewTelefono.Name = "btnNewTelefono"
        Me.btnNewTelefono.UseVisualStyleBackColor = True
        '
        'btnDeleteTelefono
        '
        Me.btnDeleteTelefono.AccessibleDescription = Nothing
        Me.btnDeleteTelefono.AccessibleName = Nothing
        resources.ApplyResources(Me.btnDeleteTelefono, "btnDeleteTelefono")
        Me.btnDeleteTelefono.BackgroundImage = Nothing
        Me.btnDeleteTelefono.Font = Nothing
        Me.btnDeleteTelefono.Name = "btnDeleteTelefono"
        Me.btnDeleteTelefono.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AccessibleDescription = Nothing
        Me.lblEmail.AccessibleName = Nothing
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.Font = Nothing
        Me.lblEmail.Name = "lblEmail"
        '
        'txtEmail
        '
        Me.txtEmail.AccessibleDescription = Nothing
        Me.txtEmail.AccessibleName = Nothing
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.BackgroundImage = Nothing
        Me.txtEmail.Font = Nothing
        Me.txtEmail.Name = "txtEmail"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Font = Nothing
        Me.Label7.Name = "Label7"
        '
        'lblMsjEnvioPassword
        '
        Me.lblMsjEnvioPassword.AccessibleDescription = Nothing
        Me.lblMsjEnvioPassword.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjEnvioPassword, "lblMsjEnvioPassword")
        Me.lblMsjEnvioPassword.Font = Nothing
        Me.lblMsjEnvioPassword.Name = "lblMsjEnvioPassword"
        '
        'UsuarioFicha
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.CancelButton = Me.cmdSalir
        Me.Controls.Add(Me.lblMsjEnvioPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnDeleteTelefono)
        Me.Controls.Add(Me.btnNewTelefono)
        Me.Controls.Add(Me.btnEditTelefono)
        Me.Controls.Add(Me.telefonosGrid)
        Me.Controls.Add(Me.lblMsjValidNombre)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmbIdioma)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtLegajo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "UsuarioFicha"
        CType(Me.telefonosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmbIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtLegajo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMsjValidNombre As System.Windows.Forms.Label
    Friend WithEvents telefonosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditTelefono As System.Windows.Forms.Button
    Friend WithEvents btnNewTelefono As System.Windows.Forms.Button
    Friend WithEvents btnDeleteTelefono As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMsjEnvioPassword As System.Windows.Forms.Label
End Class
