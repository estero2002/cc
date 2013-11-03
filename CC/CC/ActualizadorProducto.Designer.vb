<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizadorProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizadorProducto))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbProd = New System.Windows.Forms.ComboBox
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'cmbProd
        '
        Me.cmbProd.AccessibleDescription = Nothing
        Me.cmbProd.AccessibleName = Nothing
        resources.ApplyResources(Me.cmbProd, "cmbProd")
        Me.cmbProd.BackgroundImage = Nothing
        Me.cmbProd.Font = Nothing
        Me.cmbProd.FormattingEnabled = True
        Me.cmbProd.Name = "cmbProd"
        '
        'Grid
        '
        Me.Grid.AccessibleDescription = Nothing
        Me.Grid.AccessibleName = Nothing
        resources.ApplyResources(Me.Grid, "Grid")
        Me.Grid.BackgroundImage = Nothing
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Grid.Font = Nothing
        Me.Grid.Name = "Grid"
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
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
        'ActualizadorProducto
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.CancelButton = Me.btnsalir
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.cmbProd)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "ActualizadorProducto"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbProd As System.Windows.Forms.ComboBox
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
