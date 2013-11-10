<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario_Familia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario_Familia))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAsignar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.cmbUsuario = New CC.CustomComboBox
        Me.SelectControl1 = New CC.SelectControl
        Me.btnSearch = New System.Windows.Forms.Button
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
        'btnAsignar
        '
        Me.btnAsignar.AccessibleDescription = Nothing
        Me.btnAsignar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnAsignar, "btnAsignar")
        Me.btnAsignar.BackgroundImage = Nothing
        Me.btnAsignar.Font = Nothing
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
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
        'cmbUsuario
        '
        Me.cmbUsuario.AccessibleDescription = Nothing
        Me.cmbUsuario.AccessibleName = Nothing
        resources.ApplyResources(Me.cmbUsuario, "cmbUsuario")
        Me.cmbUsuario.BackgroundImage = Nothing
        Me.cmbUsuario.DisplayMember = Nothing
        Me.cmbUsuario.Font = Nothing
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.TableAdapter = Nothing
        Me.cmbUsuario.ValueMember = Nothing
        '
        'SelectControl1
        '
        Me.SelectControl1.AccessibleDescription = Nothing
        Me.SelectControl1.AccessibleName = Nothing
        resources.ApplyResources(Me.SelectControl1, "SelectControl1")
        Me.SelectControl1.BackgroundImage = Nothing
        Me.SelectControl1.Font = Nothing
        Me.SelectControl1.Name = "SelectControl1"
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleDescription = Nothing
        Me.btnSearch.AccessibleName = Nothing
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.BackgroundImage = Nothing
        Me.btnSearch.Font = Nothing
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Usuario_Familia
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.SelectControl1)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "Usuario_Familia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cmbUsuario As CC.CustomComboBox
    Friend WithEvents SelectControl1 As CC.SelectControl
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
