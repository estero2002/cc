<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesbloquearUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesbloquearUsuario))
        Me.grillaUsuarios = New System.Windows.Forms.DataGridView
        Me.btnDesbloquear = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        CType(Me.grillaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grillaUsuarios
        '
        Me.grillaUsuarios.AllowUserToAddRows = False
        Me.grillaUsuarios.AllowUserToDeleteRows = False
        Me.grillaUsuarios.AllowUserToResizeRows = False
        Me.grillaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.grillaUsuarios, "grillaUsuarios")
        Me.grillaUsuarios.MultiSelect = False
        Me.grillaUsuarios.Name = "grillaUsuarios"
        Me.grillaUsuarios.ReadOnly = True
        '
        'btnDesbloquear
        '
        resources.ApplyResources(Me.btnDesbloquear, "btnDesbloquear")
        Me.btnDesbloquear.Name = "btnDesbloquear"
        Me.btnDesbloquear.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DesbloquearUsuario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDesbloquear)
        Me.Controls.Add(Me.grillaUsuarios)
        Me.Name = "DesbloquearUsuario"
        CType(Me.grillaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grillaUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnDesbloquear As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
