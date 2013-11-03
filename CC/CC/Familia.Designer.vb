<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFamily
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFamily))
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.ID_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AccessibleDescription = Nothing
        Me.Grid.AccessibleName = Nothing
        Me.Grid.AllowUserToOrderColumns = True
        resources.ApplyResources(Me.Grid, "Grid")
        Me.Grid.BackgroundImage = Nothing
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Usuario, Me.Apellido})
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
        'Button2
        '
        Me.Button2.AccessibleDescription = Nothing
        Me.Button2.AccessibleName = Nothing
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.BackgroundImage = Nothing
        Me.Button2.Font = Nothing
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleDescription = Nothing
        Me.btnEliminar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnEliminar, "btnEliminar")
        Me.btnEliminar.BackgroundImage = Nothing
        Me.btnEliminar.Font = Nothing
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
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
        'Button5
        '
        Me.Button5.AccessibleDescription = Nothing
        Me.Button5.AccessibleName = Nothing
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.BackgroundImage = Nothing
        Me.Button5.Font = Nothing
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleDescription = Nothing
        Me.btnSalir.AccessibleName = Nothing
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.BackgroundImage = Nothing
        Me.btnSalir.Font = Nothing
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FrmFamily
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Grid)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "FrmFamily"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ID_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
