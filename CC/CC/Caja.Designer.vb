<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(caja))
        Me.lblTicket = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.groupBoxSelProd = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.cmbProducto = New System.Windows.Forms.ComboBox
        Me.cmbTipoProducto = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblColCantidad = New System.Windows.Forms.Label
        Me.lblColImporte = New System.Windows.Forms.Label
        Me.lblColDescrip = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btnFinalizarCompra = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnTopDer = New System.Windows.Forms.Button
        Me.btnGenerarReportes = New System.Windows.Forms.Button
        Me.btnDer = New System.Windows.Forms.Button
        Me.btnIzq = New System.Windows.Forms.Button
        Me.btnLimpiarGrilla = New System.Windows.Forms.Button
        Me.btnTopIzq = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.Grilla = New System.Windows.Forms.DataGridView
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.lblMsjSalida = New System.Windows.Forms.Label
        Me.lblMsjItemDup = New System.Windows.Forms.Label
        Me.lblMsjLimpiarGrilla = New System.Windows.Forms.Label
        Me.lblMsjCant = New System.Windows.Forms.Label
        Me.lblMsjSelTipoProd = New System.Windows.Forms.Label
        Me.lblMsjProd = New System.Windows.Forms.Label
        Me.lblMsjCliente = New System.Windows.Forms.Label
        Me.lblMsjItems = New System.Windows.Forms.Label
        Me.groupBoxSelProd.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTicket
        '
        Me.lblTicket.AccessibleDescription = Nothing
        Me.lblTicket.AccessibleName = Nothing
        resources.ApplyResources(Me.lblTicket, "lblTicket")
        Me.lblTicket.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTicket.Name = "lblTicket"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'groupBoxSelProd
        '
        Me.groupBoxSelProd.AccessibleDescription = Nothing
        Me.groupBoxSelProd.AccessibleName = Nothing
        resources.ApplyResources(Me.groupBoxSelProd, "groupBoxSelProd")
        Me.groupBoxSelProd.BackgroundImage = Nothing
        Me.groupBoxSelProd.Controls.Add(Me.GroupBox2)
        Me.groupBoxSelProd.Controls.Add(Me.txtCantidad)
        Me.groupBoxSelProd.Controls.Add(Me.cmbProducto)
        Me.groupBoxSelProd.Controls.Add(Me.cmbTipoProducto)
        Me.groupBoxSelProd.Controls.Add(Me.Label5)
        Me.groupBoxSelProd.Controls.Add(Me.Label2)
        Me.groupBoxSelProd.Controls.Add(Me.Label4)
        Me.groupBoxSelProd.Font = Nothing
        Me.groupBoxSelProd.Name = "groupBoxSelProd"
        Me.groupBoxSelProd.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.ComboBox5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = Nothing
        Me.TextBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.BackgroundImage = Nothing
        Me.TextBox1.Font = Nothing
        Me.TextBox1.Name = "TextBox1"
        '
        'ComboBox4
        '
        Me.ComboBox4.AccessibleDescription = Nothing
        Me.ComboBox4.AccessibleName = Nothing
        resources.ApplyResources(Me.ComboBox4, "ComboBox4")
        Me.ComboBox4.BackgroundImage = Nothing
        Me.ComboBox4.Font = Nothing
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Name = "ComboBox4"
        '
        'ComboBox5
        '
        Me.ComboBox5.AccessibleDescription = Nothing
        Me.ComboBox5.AccessibleName = Nothing
        resources.ApplyResources(Me.ComboBox5, "ComboBox5")
        Me.ComboBox5.BackgroundImage = Nothing
        Me.ComboBox5.Font = Nothing
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Name = "ComboBox5"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Font = Nothing
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Font = Nothing
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Font = Nothing
        Me.Label8.Name = "Label8"
        '
        'txtCantidad
        '
        Me.txtCantidad.AccessibleDescription = Nothing
        Me.txtCantidad.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCantidad, "txtCantidad")
        Me.txtCantidad.BackgroundImage = Nothing
        Me.txtCantidad.Font = Nothing
        Me.txtCantidad.Name = "txtCantidad"
        '
        'cmbProducto
        '
        Me.cmbProducto.AccessibleDescription = Nothing
        Me.cmbProducto.AccessibleName = Nothing
        resources.ApplyResources(Me.cmbProducto, "cmbProducto")
        Me.cmbProducto.BackgroundImage = Nothing
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.Font = Nothing
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Name = "cmbProducto"
        '
        'cmbTipoProducto
        '
        Me.cmbTipoProducto.AccessibleDescription = Nothing
        Me.cmbTipoProducto.AccessibleName = Nothing
        resources.ApplyResources(Me.cmbTipoProducto, "cmbTipoProducto")
        Me.cmbTipoProducto.BackgroundImage = Nothing
        Me.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoProducto.Font = Nothing
        Me.cmbTipoProducto.FormattingEnabled = True
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Font = Nothing
        Me.Label5.Name = "Label5"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = Nothing
        Me.GroupBox3.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.BackgroundImage = Nothing
        Me.GroupBox3.Controls.Add(Me.lblColCantidad)
        Me.GroupBox3.Controls.Add(Me.lblColImporte)
        Me.GroupBox3.Controls.Add(Me.lblColDescrip)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btnsalir)
        Me.GroupBox3.Controls.Add(Me.btnFinalizarCompra)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.btnTopDer)
        Me.GroupBox3.Controls.Add(Me.btnGenerarReportes)
        Me.GroupBox3.Controls.Add(Me.btnDer)
        Me.GroupBox3.Controls.Add(Me.btnIzq)
        Me.GroupBox3.Controls.Add(Me.btnLimpiarGrilla)
        Me.GroupBox3.Controls.Add(Me.btnTopIzq)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Controls.Add(Me.Grilla)
        Me.GroupBox3.Font = Nothing
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'lblColCantidad
        '
        Me.lblColCantidad.AccessibleDescription = Nothing
        Me.lblColCantidad.AccessibleName = Nothing
        resources.ApplyResources(Me.lblColCantidad, "lblColCantidad")
        Me.lblColCantidad.Font = Nothing
        Me.lblColCantidad.Name = "lblColCantidad"
        '
        'lblColImporte
        '
        Me.lblColImporte.AccessibleDescription = Nothing
        Me.lblColImporte.AccessibleName = Nothing
        resources.ApplyResources(Me.lblColImporte, "lblColImporte")
        Me.lblColImporte.Font = Nothing
        Me.lblColImporte.Name = "lblColImporte"
        '
        'lblColDescrip
        '
        Me.lblColDescrip.AccessibleDescription = Nothing
        Me.lblColDescrip.AccessibleName = Nothing
        resources.ApplyResources(Me.lblColDescrip, "lblColDescrip")
        Me.lblColDescrip.Font = Nothing
        Me.lblColDescrip.Name = "lblColDescrip"
        '
        'lblTotal
        '
        Me.lblTotal.AccessibleDescription = Nothing
        Me.lblTotal.AccessibleName = Nothing
        resources.ApplyResources(Me.lblTotal, "lblTotal")
        Me.lblTotal.Font = Nothing
        Me.lblTotal.Name = "lblTotal"
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = Nothing
        Me.Label10.AccessibleName = Nothing
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Font = Nothing
        Me.Label10.Name = "Label10"
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
        'btnFinalizarCompra
        '
        Me.btnFinalizarCompra.AccessibleDescription = Nothing
        Me.btnFinalizarCompra.AccessibleName = Nothing
        resources.ApplyResources(Me.btnFinalizarCompra, "btnFinalizarCompra")
        Me.btnFinalizarCompra.BackgroundImage = Nothing
        Me.btnFinalizarCompra.Font = Nothing
        Me.btnFinalizarCompra.Name = "btnFinalizarCompra"
        Me.btnFinalizarCompra.UseVisualStyleBackColor = True
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
        'btnTopDer
        '
        Me.btnTopDer.AccessibleDescription = Nothing
        Me.btnTopDer.AccessibleName = Nothing
        resources.ApplyResources(Me.btnTopDer, "btnTopDer")
        Me.btnTopDer.BackgroundImage = Nothing
        Me.btnTopDer.Name = "btnTopDer"
        Me.btnTopDer.UseVisualStyleBackColor = True
        '
        'btnGenerarReportes
        '
        Me.btnGenerarReportes.AccessibleDescription = Nothing
        Me.btnGenerarReportes.AccessibleName = Nothing
        resources.ApplyResources(Me.btnGenerarReportes, "btnGenerarReportes")
        Me.btnGenerarReportes.BackgroundImage = Nothing
        Me.btnGenerarReportes.Font = Nothing
        Me.btnGenerarReportes.Name = "btnGenerarReportes"
        Me.btnGenerarReportes.UseVisualStyleBackColor = True
        '
        'btnDer
        '
        Me.btnDer.AccessibleDescription = Nothing
        Me.btnDer.AccessibleName = Nothing
        resources.ApplyResources(Me.btnDer, "btnDer")
        Me.btnDer.BackgroundImage = Nothing
        Me.btnDer.Name = "btnDer"
        Me.btnDer.UseVisualStyleBackColor = True
        '
        'btnIzq
        '
        Me.btnIzq.AccessibleDescription = Nothing
        Me.btnIzq.AccessibleName = Nothing
        resources.ApplyResources(Me.btnIzq, "btnIzq")
        Me.btnIzq.BackgroundImage = Nothing
        Me.btnIzq.Name = "btnIzq"
        Me.btnIzq.UseVisualStyleBackColor = True
        '
        'btnLimpiarGrilla
        '
        Me.btnLimpiarGrilla.AccessibleDescription = Nothing
        Me.btnLimpiarGrilla.AccessibleName = Nothing
        resources.ApplyResources(Me.btnLimpiarGrilla, "btnLimpiarGrilla")
        Me.btnLimpiarGrilla.BackgroundImage = Nothing
        Me.btnLimpiarGrilla.Font = Nothing
        Me.btnLimpiarGrilla.Name = "btnLimpiarGrilla"
        Me.btnLimpiarGrilla.UseVisualStyleBackColor = True
        '
        'btnTopIzq
        '
        Me.btnTopIzq.AccessibleDescription = Nothing
        Me.btnTopIzq.AccessibleName = Nothing
        resources.ApplyResources(Me.btnTopIzq, "btnTopIzq")
        Me.btnTopIzq.BackgroundImage = Nothing
        Me.btnTopIzq.Name = "btnTopIzq"
        Me.btnTopIzq.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.AccessibleDescription = Nothing
        Me.btnAgregar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.BackgroundImage = Nothing
        Me.btnAgregar.Font = Nothing
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.AccessibleDescription = Nothing
        Me.Grilla.AccessibleName = Nothing
        resources.ApplyResources(Me.Grilla, "Grilla")
        Me.Grilla.BackgroundImage = Nothing
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Font = Nothing
        Me.Grilla.Name = "Grilla"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Font = Nothing
        Me.Label9.Name = "Label9"
        '
        'lblFecha
        '
        Me.lblFecha.AccessibleDescription = Nothing
        Me.lblFecha.AccessibleName = Nothing
        resources.ApplyResources(Me.lblFecha, "lblFecha")
        Me.lblFecha.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.Font = Nothing
        Me.lblFecha.Name = "lblFecha"
        '
        'cmbCliente
        '
        Me.cmbCliente.AccessibleDescription = Nothing
        Me.cmbCliente.AccessibleName = Nothing
        resources.ApplyResources(Me.cmbCliente, "cmbCliente")
        Me.cmbCliente.BackgroundImage = Nothing
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.Font = Nothing
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Name = "cmbCliente"
        '
        'lblMsjSalida
        '
        Me.lblMsjSalida.AccessibleDescription = Nothing
        Me.lblMsjSalida.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjSalida, "lblMsjSalida")
        Me.lblMsjSalida.Font = Nothing
        Me.lblMsjSalida.Name = "lblMsjSalida"
        '
        'lblMsjItemDup
        '
        Me.lblMsjItemDup.AccessibleDescription = Nothing
        Me.lblMsjItemDup.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjItemDup, "lblMsjItemDup")
        Me.lblMsjItemDup.Font = Nothing
        Me.lblMsjItemDup.Name = "lblMsjItemDup"
        '
        'lblMsjLimpiarGrilla
        '
        Me.lblMsjLimpiarGrilla.AccessibleDescription = Nothing
        Me.lblMsjLimpiarGrilla.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjLimpiarGrilla, "lblMsjLimpiarGrilla")
        Me.lblMsjLimpiarGrilla.Font = Nothing
        Me.lblMsjLimpiarGrilla.Name = "lblMsjLimpiarGrilla"
        '
        'lblMsjCant
        '
        Me.lblMsjCant.AccessibleDescription = Nothing
        Me.lblMsjCant.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjCant, "lblMsjCant")
        Me.lblMsjCant.Font = Nothing
        Me.lblMsjCant.Name = "lblMsjCant"
        '
        'lblMsjSelTipoProd
        '
        Me.lblMsjSelTipoProd.AccessibleDescription = Nothing
        Me.lblMsjSelTipoProd.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjSelTipoProd, "lblMsjSelTipoProd")
        Me.lblMsjSelTipoProd.Font = Nothing
        Me.lblMsjSelTipoProd.Name = "lblMsjSelTipoProd"
        '
        'lblMsjProd
        '
        Me.lblMsjProd.AccessibleDescription = Nothing
        Me.lblMsjProd.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjProd, "lblMsjProd")
        Me.lblMsjProd.Font = Nothing
        Me.lblMsjProd.Name = "lblMsjProd"
        '
        'lblMsjCliente
        '
        Me.lblMsjCliente.AccessibleDescription = Nothing
        Me.lblMsjCliente.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjCliente, "lblMsjCliente")
        Me.lblMsjCliente.Font = Nothing
        Me.lblMsjCliente.Name = "lblMsjCliente"
        '
        'lblMsjItems
        '
        Me.lblMsjItems.AccessibleDescription = Nothing
        Me.lblMsjItems.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMsjItems, "lblMsjItems")
        Me.lblMsjItems.Font = Nothing
        Me.lblMsjItems.Name = "lblMsjItems"
        '
        'caja
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.CancelButton = Me.btnsalir
        Me.Controls.Add(Me.lblMsjItems)
        Me.Controls.Add(Me.lblMsjCliente)
        Me.Controls.Add(Me.lblMsjProd)
        Me.Controls.Add(Me.lblMsjSelTipoProd)
        Me.Controls.Add(Me.lblMsjCant)
        Me.Controls.Add(Me.lblMsjLimpiarGrilla)
        Me.Controls.Add(Me.lblMsjItemDup)
        Me.Controls.Add(Me.lblMsjSalida)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.groupBoxSelProd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTicket)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "caja"
        Me.groupBoxSelProd.ResumeLayout(False)
        Me.groupBoxSelProd.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTicket As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents groupBoxSelProd As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents btnLimpiarGrilla As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnTopDer As System.Windows.Forms.Button
    Friend WithEvents btnDer As System.Windows.Forms.Button
    Friend WithEvents btnIzq As System.Windows.Forms.Button
    Friend WithEvents btnTopIzq As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnFinalizarCompra As System.Windows.Forms.Button
    Friend WithEvents btnGenerarReportes As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMsjSalida As System.Windows.Forms.Label
    Friend WithEvents lblMsjItemDup As System.Windows.Forms.Label
    Friend WithEvents lblMsjLimpiarGrilla As System.Windows.Forms.Label
    Friend WithEvents lblMsjCant As System.Windows.Forms.Label
    Friend WithEvents lblMsjSelTipoProd As System.Windows.Forms.Label
    Friend WithEvents lblMsjProd As System.Windows.Forms.Label
    Friend WithEvents lblColImporte As System.Windows.Forms.Label
    Friend WithEvents lblColDescrip As System.Windows.Forms.Label
    Friend WithEvents lblColCantidad As System.Windows.Forms.Label
    Friend WithEvents lblMsjCliente As System.Windows.Forms.Label
    Friend WithEvents lblMsjItems As System.Windows.Forms.Label
End Class
