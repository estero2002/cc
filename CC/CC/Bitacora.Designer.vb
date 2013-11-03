<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bitacora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bitacora))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbUsuario = New CC.CustomComboBox
        Me.fechaHasta = New System.Windows.Forms.DateTimePicker
        Me.fechaDesde = New System.Windows.Forms.DateTimePicker
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnMostrar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grillaBitacora = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.grillaBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbUsuario)
        Me.GroupBox1.Controls.Add(Me.fechaHasta)
        Me.GroupBox1.Controls.Add(Me.fechaDesde)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnMostrar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DisplayMember = Nothing
        resources.ApplyResources(Me.cmbUsuario, "cmbUsuario")
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.TableAdapter = Nothing
        Me.cmbUsuario.ValueMember = Nothing
        '
        'fechaHasta
        '
        Me.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.fechaHasta, "fechaHasta")
        Me.fechaHasta.Name = "fechaHasta"
        '
        'fechaDesde
        '
        Me.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.fechaDesde, "fechaDesde")
        Me.fechaDesde.Name = "fechaDesde"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        resources.ApplyResources(Me.btnMostrar, "btnMostrar")
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'grillaBitacora
        '
        Me.grillaBitacora.AllowUserToAddRows = False
        Me.grillaBitacora.AllowUserToDeleteRows = False
        Me.grillaBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        resources.ApplyResources(Me.grillaBitacora, "grillaBitacora")
        Me.grillaBitacora.Name = "grillaBitacora"
        Me.grillaBitacora.ReadOnly = True
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Bitacora
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.Controls.Add(Me.grillaBitacora)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Bitacora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grillaBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents grillaBitacora As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbUsuario As CC.CustomComboBox
End Class
