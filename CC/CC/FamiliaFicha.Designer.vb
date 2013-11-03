<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FamiliaFicha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FamiliaFicha))
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SelectControl1 = New CC.SelectControl
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
        'txtNombre
        '
        Me.txtNombre.AccessibleDescription = Nothing
        Me.txtNombre.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNombre, "txtNombre")
        Me.txtNombre.BackgroundImage = Nothing
        Me.txtNombre.Font = Nothing
        Me.txtNombre.Name = "txtNombre"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
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
        'FamiliaFicha
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.CancelButton = Me.cmdSalir
        Me.Controls.Add(Me.SelectControl1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "FamiliaFicha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SelectControl1 As CC.SelectControl
End Class
