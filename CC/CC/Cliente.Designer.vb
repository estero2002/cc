<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
    Inherits FormBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btnReporte = New System.Windows.Forms.Button
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.ID_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblApellido = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.AccessibleDescription = Nothing
        Me.btnsalir.AccessibleName = Nothing
        resources.ApplyResources(Me.btnsalir, "btnsalir")
        Me.btnsalir.BackgroundImage = Nothing
        Me.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsalir.Font = Nothing
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.AccessibleDescription = Nothing
        Me.btnReporte.AccessibleName = Nothing
        resources.ApplyResources(Me.btnReporte, "btnReporte")
        Me.btnReporte.BackgroundImage = Nothing
        Me.btnReporte.Font = Nothing
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.AccessibleDescription = Nothing
        Me.btnActualizar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnActualizar, "btnActualizar")
        Me.btnActualizar.BackgroundImage = Nothing
        Me.btnActualizar.Font = Nothing
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.AccessibleDescription = Nothing
        Me.BtnEliminar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEliminar, "BtnEliminar")
        Me.BtnEliminar.BackgroundImage = Nothing
        Me.BtnEliminar.Font = Nothing
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.AccessibleDescription = Nothing
        Me.btnEditar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnEditar, "btnEditar")
        Me.btnEditar.BackgroundImage = Nothing
        Me.btnEditar.Font = Nothing
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleDescription = Nothing
        Me.btnNuevo.AccessibleName = Nothing
        resources.ApplyResources(Me.btnNuevo, "btnNuevo")
        Me.btnNuevo.BackgroundImage = Nothing
        Me.btnNuevo.Font = Nothing
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.AccessibleDescription = Nothing
        Me.Grid.AccessibleName = Nothing
        resources.ApplyResources(Me.Grid, "Grid")
        Me.Grid.BackgroundImage = Nothing
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Usuario, Me.Apellido, Me.Nombre})
        Me.Grid.Font = Nothing
        Me.Grid.Name = "Grid"
        '
        'ID_Usuario
        '
        resources.ApplyResources(Me.ID_Usuario, "ID_Usuario")
        Me.ID_Usuario.Name = "ID_Usuario"
        '
        'Apellido
        '
        resources.ApplyResources(Me.Apellido, "Apellido")
        Me.Apellido.Name = "Apellido"
        '
        'Nombre
        '
        resources.ApplyResources(Me.Nombre, "Nombre")
        Me.Nombre.Name = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AccessibleDescription = Nothing
        Me.lblNombre.AccessibleName = Nothing
        resources.ApplyResources(Me.lblNombre, "lblNombre")
        Me.lblNombre.Font = Nothing
        Me.lblNombre.Name = "lblNombre"
        '
        'lblApellido
        '
        Me.lblApellido.AccessibleDescription = Nothing
        Me.lblApellido.AccessibleName = Nothing
        resources.ApplyResources(Me.lblApellido, "lblApellido")
        Me.lblApellido.Font = Nothing
        Me.lblApellido.Name = "lblApellido"
        '
        'lblEmail
        '
        Me.lblEmail.AccessibleDescription = Nothing
        Me.lblEmail.AccessibleName = Nothing
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.Font = Nothing
        Me.lblEmail.Name = "lblEmail"
        '
        'FrmCliente
        '
        Me.AcceptButton = Me.btnEditar
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.CancelButton = Me.btnsalir
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Grid)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "FrmCliente"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents ID_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
End Class
