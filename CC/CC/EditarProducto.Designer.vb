<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarProducto))
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.precio = New System.Windows.Forms.TextBox
        Me.descrip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
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
        'btnaceptar
        '
        Me.btnaceptar.AccessibleDescription = Nothing
        Me.btnaceptar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnaceptar, "btnaceptar")
        Me.btnaceptar.BackgroundImage = Nothing
        Me.btnaceptar.Font = Nothing
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'precio
        '
        Me.precio.AccessibleDescription = Nothing
        Me.precio.AccessibleName = Nothing
        resources.ApplyResources(Me.precio, "precio")
        Me.precio.BackgroundImage = Nothing
        Me.precio.Font = Nothing
        Me.precio.Name = "precio"
        '
        'descrip
        '
        Me.descrip.AccessibleDescription = Nothing
        Me.descrip.AccessibleName = Nothing
        resources.ApplyResources(Me.descrip, "descrip")
        Me.descrip.BackgroundImage = Nothing
        Me.descrip.Font = Nothing
        Me.descrip.Name = "descrip"
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
        'EditarProducto
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.CancelButton = Me.btnsalir
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.descrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "EditarProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents precio As System.Windows.Forms.TextBox
    Friend WithEvents descrip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
