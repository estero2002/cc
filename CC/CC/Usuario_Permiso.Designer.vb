<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario_Permiso
    Inherits CC.FormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario_Permiso))
        Me.cmbUsuario = New CC.CustomComboBox
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lstDisponibles = New System.Windows.Forms.ListBox
        Me.lstAsignados = New System.Windows.Forms.ListBox
        Me.lstDenegados = New System.Windows.Forms.ListBox
        Me.lblDisponibles = New System.Windows.Forms.Label
        Me.lblAsignados = New System.Windows.Forms.Label
        Me.lblDenegados = New System.Windows.Forms.Label
        Me.btnAsignarDisponible = New System.Windows.Forms.Button
        Me.btnDenegarDisponible = New System.Windows.Forms.Button
        Me.btnDenegarAsignado = New System.Windows.Forms.Button
        Me.btnQuitarAsignado = New System.Windows.Forms.Button
        Me.btnAsignarDenegado = New System.Windows.Forms.Button
        Me.btnQuitarDenegado = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
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
        'lblUsuario
        '
        Me.lblUsuario.AccessibleDescription = Nothing
        Me.lblUsuario.AccessibleName = Nothing
        resources.ApplyResources(Me.lblUsuario, "lblUsuario")
        Me.lblUsuario.Font = Nothing
        Me.lblUsuario.Name = "lblUsuario"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleDescription = Nothing
        Me.btnBuscar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.BackgroundImage = Nothing
        Me.btnBuscar.Font = Nothing
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lstDisponibles
        '
        Me.lstDisponibles.AccessibleDescription = Nothing
        Me.lstDisponibles.AccessibleName = Nothing
        resources.ApplyResources(Me.lstDisponibles, "lstDisponibles")
        Me.lstDisponibles.BackgroundImage = Nothing
        Me.lstDisponibles.Font = Nothing
        Me.lstDisponibles.FormattingEnabled = True
        Me.lstDisponibles.Name = "lstDisponibles"
        '
        'lstAsignados
        '
        Me.lstAsignados.AccessibleDescription = Nothing
        Me.lstAsignados.AccessibleName = Nothing
        resources.ApplyResources(Me.lstAsignados, "lstAsignados")
        Me.lstAsignados.BackgroundImage = Nothing
        Me.lstAsignados.Font = Nothing
        Me.lstAsignados.FormattingEnabled = True
        Me.lstAsignados.Name = "lstAsignados"
        '
        'lstDenegados
        '
        Me.lstDenegados.AccessibleDescription = Nothing
        Me.lstDenegados.AccessibleName = Nothing
        resources.ApplyResources(Me.lstDenegados, "lstDenegados")
        Me.lstDenegados.BackgroundImage = Nothing
        Me.lstDenegados.Font = Nothing
        Me.lstDenegados.FormattingEnabled = True
        Me.lstDenegados.Name = "lstDenegados"
        '
        'lblDisponibles
        '
        Me.lblDisponibles.AccessibleDescription = Nothing
        Me.lblDisponibles.AccessibleName = Nothing
        resources.ApplyResources(Me.lblDisponibles, "lblDisponibles")
        Me.lblDisponibles.Font = Nothing
        Me.lblDisponibles.Name = "lblDisponibles"
        '
        'lblAsignados
        '
        Me.lblAsignados.AccessibleDescription = Nothing
        Me.lblAsignados.AccessibleName = Nothing
        resources.ApplyResources(Me.lblAsignados, "lblAsignados")
        Me.lblAsignados.Font = Nothing
        Me.lblAsignados.Name = "lblAsignados"
        '
        'lblDenegados
        '
        Me.lblDenegados.AccessibleDescription = Nothing
        Me.lblDenegados.AccessibleName = Nothing
        resources.ApplyResources(Me.lblDenegados, "lblDenegados")
        Me.lblDenegados.Font = Nothing
        Me.lblDenegados.Name = "lblDenegados"
        '
        'btnAsignarDisponible
        '
        Me.btnAsignarDisponible.AccessibleDescription = Nothing
        Me.btnAsignarDisponible.AccessibleName = Nothing
        resources.ApplyResources(Me.btnAsignarDisponible, "btnAsignarDisponible")
        Me.btnAsignarDisponible.BackgroundImage = Nothing
        Me.btnAsignarDisponible.Font = Nothing
        Me.btnAsignarDisponible.Name = "btnAsignarDisponible"
        Me.btnAsignarDisponible.UseVisualStyleBackColor = True
        '
        'btnDenegarDisponible
        '
        Me.btnDenegarDisponible.AccessibleDescription = Nothing
        Me.btnDenegarDisponible.AccessibleName = Nothing
        resources.ApplyResources(Me.btnDenegarDisponible, "btnDenegarDisponible")
        Me.btnDenegarDisponible.BackgroundImage = Nothing
        Me.btnDenegarDisponible.Font = Nothing
        Me.btnDenegarDisponible.Name = "btnDenegarDisponible"
        Me.btnDenegarDisponible.UseVisualStyleBackColor = True
        '
        'btnDenegarAsignado
        '
        Me.btnDenegarAsignado.AccessibleDescription = Nothing
        Me.btnDenegarAsignado.AccessibleName = Nothing
        resources.ApplyResources(Me.btnDenegarAsignado, "btnDenegarAsignado")
        Me.btnDenegarAsignado.BackgroundImage = Nothing
        Me.btnDenegarAsignado.Font = Nothing
        Me.btnDenegarAsignado.Name = "btnDenegarAsignado"
        Me.btnDenegarAsignado.UseVisualStyleBackColor = True
        '
        'btnQuitarAsignado
        '
        Me.btnQuitarAsignado.AccessibleDescription = Nothing
        Me.btnQuitarAsignado.AccessibleName = Nothing
        resources.ApplyResources(Me.btnQuitarAsignado, "btnQuitarAsignado")
        Me.btnQuitarAsignado.BackgroundImage = Nothing
        Me.btnQuitarAsignado.Font = Nothing
        Me.btnQuitarAsignado.Name = "btnQuitarAsignado"
        Me.btnQuitarAsignado.UseVisualStyleBackColor = True
        '
        'btnAsignarDenegado
        '
        Me.btnAsignarDenegado.AccessibleDescription = Nothing
        Me.btnAsignarDenegado.AccessibleName = Nothing
        resources.ApplyResources(Me.btnAsignarDenegado, "btnAsignarDenegado")
        Me.btnAsignarDenegado.BackgroundImage = Nothing
        Me.btnAsignarDenegado.Font = Nothing
        Me.btnAsignarDenegado.Name = "btnAsignarDenegado"
        Me.btnAsignarDenegado.UseVisualStyleBackColor = True
        '
        'btnQuitarDenegado
        '
        Me.btnQuitarDenegado.AccessibleDescription = Nothing
        Me.btnQuitarDenegado.AccessibleName = Nothing
        resources.ApplyResources(Me.btnQuitarDenegado, "btnQuitarDenegado")
        Me.btnQuitarDenegado.BackgroundImage = Nothing
        Me.btnQuitarDenegado.Font = Nothing
        Me.btnQuitarDenegado.Name = "btnQuitarDenegado"
        Me.btnQuitarDenegado.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleDescription = Nothing
        Me.btnGuardar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnGuardar, "btnGuardar")
        Me.btnGuardar.BackgroundImage = Nothing
        Me.btnGuardar.Font = Nothing
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleDescription = Nothing
        Me.btnCancelar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.BackgroundImage = Nothing
        Me.btnCancelar.Font = Nothing
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Usuario_Permiso
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnQuitarDenegado)
        Me.Controls.Add(Me.btnAsignarDenegado)
        Me.Controls.Add(Me.btnQuitarAsignado)
        Me.Controls.Add(Me.btnDenegarAsignado)
        Me.Controls.Add(Me.btnDenegarDisponible)
        Me.Controls.Add(Me.btnAsignarDisponible)
        Me.Controls.Add(Me.lblDenegados)
        Me.Controls.Add(Me.lblAsignados)
        Me.Controls.Add(Me.lblDisponibles)
        Me.Controls.Add(Me.lstDenegados)
        Me.Controls.Add(Me.lstAsignados)
        Me.Controls.Add(Me.lstDisponibles)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "Usuario_Permiso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbUsuario As CC.CustomComboBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lstDisponibles As System.Windows.Forms.ListBox
    Friend WithEvents lstAsignados As System.Windows.Forms.ListBox
    Friend WithEvents lstDenegados As System.Windows.Forms.ListBox
    Friend WithEvents lblDisponibles As System.Windows.Forms.Label
    Friend WithEvents lblAsignados As System.Windows.Forms.Label
    Friend WithEvents lblDenegados As System.Windows.Forms.Label
    Friend WithEvents btnAsignarDisponible As System.Windows.Forms.Button
    Friend WithEvents btnDenegarDisponible As System.Windows.Forms.Button
    Friend WithEvents btnDenegarAsignado As System.Windows.Forms.Button
    Friend WithEvents btnQuitarAsignado As System.Windows.Forms.Button
    Friend WithEvents btnAsignarDenegado As System.Windows.Forms.Button
    Friend WithEvents btnQuitarDenegado As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button

End Class
