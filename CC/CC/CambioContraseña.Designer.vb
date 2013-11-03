<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambioContraseña))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPasswordNueva2 = New System.Windows.Forms.TextBox
        Me.txtPasswordNueva = New System.Windows.Forms.TextBox
        Me.txtPasswordActual = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnok = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPasswordNueva2)
        Me.GroupBox1.Controls.Add(Me.txtPasswordNueva)
        Me.GroupBox1.Controls.Add(Me.txtPasswordActual)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txtPasswordNueva2
        '
        resources.ApplyResources(Me.txtPasswordNueva2, "txtPasswordNueva2")
        Me.txtPasswordNueva2.Name = "txtPasswordNueva2"
        '
        'txtPasswordNueva
        '
        resources.ApplyResources(Me.txtPasswordNueva, "txtPasswordNueva")
        Me.txtPasswordNueva.Name = "txtPasswordNueva"
        '
        'txtPasswordActual
        '
        resources.ApplyResources(Me.txtPasswordActual, "txtPasswordActual")
        Me.txtPasswordActual.Name = "txtPasswordActual"
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
        'btnok
        '
        resources.ApplyResources(Me.btnok, "btnok")
        Me.btnok.Name = "btnok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnsalir, "btnsalir")
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'CambioContraseña
        '
        Me.AcceptButton = Me.btnok
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnsalir
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CambioContraseña"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordNueva2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordNueva As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordActual As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
End Class
