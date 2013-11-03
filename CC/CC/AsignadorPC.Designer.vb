<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignadorPC
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsignadorPC))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PC3 = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HabilitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FinalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FueraDeUsoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RehabilitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PC2 = New System.Windows.Forms.PictureBox
        Me.PC1 = New System.Windows.Forms.PictureBox
        Me.PC0 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAsignar = New System.Windows.Forms.Button
        Me.cmbCliente = New CC.CustomComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnsalir = New System.Windows.Forms.Button
        Me.LblMsgSalida = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMsgHabilitada = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.PC3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PC0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PC3)
        Me.GroupBox1.Controls.Add(Me.PC2)
        Me.GroupBox1.Controls.Add(Me.PC1)
        Me.GroupBox1.Controls.Add(Me.PC0)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'PC3
        '
        Me.PC3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PC3.Image = Global.CC.My.Resources.Resources.cyoffline
        resources.ApplyResources(Me.PC3, "PC3")
        Me.PC3.Name = "PC3"
        Me.PC3.TabStop = False
        Me.PC3.Tag = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HabilitarToolStripMenuItem, Me.FinalizarToolStripMenuItem, Me.FueraDeUsoToolStripMenuItem, Me.RehabilitarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'HabilitarToolStripMenuItem
        '
        Me.HabilitarToolStripMenuItem.Name = "HabilitarToolStripMenuItem"
        resources.ApplyResources(Me.HabilitarToolStripMenuItem, "HabilitarToolStripMenuItem")
        '
        'FinalizarToolStripMenuItem
        '
        Me.FinalizarToolStripMenuItem.Name = "FinalizarToolStripMenuItem"
        resources.ApplyResources(Me.FinalizarToolStripMenuItem, "FinalizarToolStripMenuItem")
        '
        'FueraDeUsoToolStripMenuItem
        '
        Me.FueraDeUsoToolStripMenuItem.Name = "FueraDeUsoToolStripMenuItem"
        resources.ApplyResources(Me.FueraDeUsoToolStripMenuItem, "FueraDeUsoToolStripMenuItem")
        '
        'RehabilitarToolStripMenuItem
        '
        Me.RehabilitarToolStripMenuItem.Name = "RehabilitarToolStripMenuItem"
        resources.ApplyResources(Me.RehabilitarToolStripMenuItem, "RehabilitarToolStripMenuItem")
        '
        'PC2
        '
        Me.PC2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PC2.Image = Global.CC.My.Resources.Resources.cyoffline
        resources.ApplyResources(Me.PC2, "PC2")
        Me.PC2.Name = "PC2"
        Me.PC2.TabStop = False
        Me.PC2.Tag = ""
        '
        'PC1
        '
        Me.PC1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PC1.Image = Global.CC.My.Resources.Resources.cyoffline
        resources.ApplyResources(Me.PC1, "PC1")
        Me.PC1.Name = "PC1"
        Me.PC1.TabStop = False
        Me.PC1.Tag = ""
        '
        'PC0
        '
        Me.PC0.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PC0.Image = Global.CC.My.Resources.Resources.cyoffline
        resources.ApplyResources(Me.PC0, "PC0")
        Me.PC0.Name = "PC0"
        Me.PC0.TabStop = False
        Me.PC0.Tag = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnAsignar)
        Me.GroupBox2.Controls.Add(Me.cmbCliente)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'btnCancelar
        '
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        resources.ApplyResources(Me.btnAsignar, "btnAsignar")
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.DisplayMember = Nothing
        resources.ApplyResources(Me.cmbCliente, "cmbCliente")
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.TableAdapter = Nothing
        Me.cmbCliente.ValueMember = Nothing
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'btnsalir
        '
        Me.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnsalir, "btnsalir")
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'LblMsgSalida
        '
        resources.ApplyResources(Me.LblMsgSalida, "LblMsgSalida")
        Me.LblMsgSalida.Name = "LblMsgSalida"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'lblMsgHabilitada
        '
        resources.ApplyResources(Me.lblMsgHabilitada, "lblMsgHabilitada")
        Me.lblMsgHabilitada.Name = "lblMsgHabilitada"
        '
        'AsignadorPC
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnsalir
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lblMsgHabilitada)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblMsgSalida)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AsignadorPC"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PC3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PC0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PC0 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As CC.CustomComboBox
    Friend WithEvents LblMsgSalida As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HabilitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FueraDeUsoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehabilitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents PC3 As System.Windows.Forms.PictureBox
    Friend WithEvents PC2 As System.Windows.Forms.PictureBox
    Friend WithEvents PC1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMsgHabilitada As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
