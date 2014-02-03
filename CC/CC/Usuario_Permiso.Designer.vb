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
        Me.cmbUsuario.DisplayMember = Nothing
        resources.ApplyResources(Me.cmbUsuario, "cmbUsuario")
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.TableAdapter = Nothing
        Me.cmbUsuario.ValueMember = Nothing
        '
        'lblUsuario
        '
        resources.ApplyResources(Me.lblUsuario, "lblUsuario")
        Me.lblUsuario.Name = "lblUsuario"
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lstDisponibles
        '
        Me.lstDisponibles.FormattingEnabled = True
        resources.ApplyResources(Me.lstDisponibles, "lstDisponibles")
        Me.lstDisponibles.Name = "lstDisponibles"
        Me.lstDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        '
        'lstAsignados
        '
        Me.lstAsignados.FormattingEnabled = True
        resources.ApplyResources(Me.lstAsignados, "lstAsignados")
        Me.lstAsignados.Name = "lstAsignados"
        Me.lstAsignados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        '
        'lstDenegados
        '
        Me.lstDenegados.FormattingEnabled = True
        resources.ApplyResources(Me.lstDenegados, "lstDenegados")
        Me.lstDenegados.Name = "lstDenegados"
        Me.lstDenegados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        '
        'lblDisponibles
        '
        resources.ApplyResources(Me.lblDisponibles, "lblDisponibles")
        Me.lblDisponibles.Name = "lblDisponibles"
        '
        'lblAsignados
        '
        resources.ApplyResources(Me.lblAsignados, "lblAsignados")
        Me.lblAsignados.Name = "lblAsignados"
        '
        'lblDenegados
        '
        resources.ApplyResources(Me.lblDenegados, "lblDenegados")
        Me.lblDenegados.Name = "lblDenegados"
        '
        'btnAsignarDisponible
        '
        resources.ApplyResources(Me.btnAsignarDisponible, "btnAsignarDisponible")
        Me.btnAsignarDisponible.Name = "btnAsignarDisponible"
        Me.btnAsignarDisponible.UseVisualStyleBackColor = True
        '
        'btnDenegarDisponible
        '
        resources.ApplyResources(Me.btnDenegarDisponible, "btnDenegarDisponible")
        Me.btnDenegarDisponible.Name = "btnDenegarDisponible"
        Me.btnDenegarDisponible.UseVisualStyleBackColor = True
        '
        'btnDenegarAsignado
        '
        resources.ApplyResources(Me.btnDenegarAsignado, "btnDenegarAsignado")
        Me.btnDenegarAsignado.Name = "btnDenegarAsignado"
        Me.btnDenegarAsignado.UseVisualStyleBackColor = True
        '
        'btnQuitarAsignado
        '
        resources.ApplyResources(Me.btnQuitarAsignado, "btnQuitarAsignado")
        Me.btnQuitarAsignado.Name = "btnQuitarAsignado"
        Me.btnQuitarAsignado.UseVisualStyleBackColor = True
        '
        'btnAsignarDenegado
        '
        resources.ApplyResources(Me.btnAsignarDenegado, "btnAsignarDenegado")
        Me.btnAsignarDenegado.Name = "btnAsignarDenegado"
        Me.btnAsignarDenegado.UseVisualStyleBackColor = True
        '
        'btnQuitarDenegado
        '
        resources.ApplyResources(Me.btnQuitarDenegado, "btnQuitarDenegado")
        Me.btnQuitarDenegado.Name = "btnQuitarDenegado"
        Me.btnQuitarDenegado.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        resources.ApplyResources(Me.btnGuardar, "btnGuardar")
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Usuario_Permiso
        '
        resources.ApplyResources(Me, "$this")
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
