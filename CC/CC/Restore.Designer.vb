<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restore))
        Me.txtSourceFile = New System.Windows.Forms.TextBox
        Me.cmdFolder = New System.Windows.Forms.Button
        Me.cmdExecute = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.lblRestaurar = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtSourceFile
        '
        Me.txtSourceFile.AcceptsReturn = True
        resources.ApplyResources(Me.txtSourceFile, "txtSourceFile")
        Me.txtSourceFile.Name = "txtSourceFile"
        '
        'cmdFolder
        '
        resources.ApplyResources(Me.cmdFolder, "cmdFolder")
        Me.cmdFolder.Name = "cmdFolder"
        Me.cmdFolder.UseVisualStyleBackColor = True
        '
        'cmdExecute
        '
        resources.ApplyResources(Me.cmdExecute, "cmdExecute")
        Me.cmdExecute.Name = "cmdExecute"
        Me.cmdExecute.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.cmdExit, "cmdExit")
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblRestaurar
        '
        resources.ApplyResources(Me.lblRestaurar, "lblRestaurar")
        Me.lblRestaurar.Name = "lblRestaurar"
        '
        'Restore
        '
        Me.AcceptButton = Me.cmdExecute
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.Controls.Add(Me.lblRestaurar)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdExecute)
        Me.Controls.Add(Me.cmdFolder)
        Me.Controls.Add(Me.txtSourceFile)
        Me.Name = "Restore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSourceFile As System.Windows.Forms.TextBox
    Friend WithEvents cmdFolder As System.Windows.Forms.Button
    Friend WithEvents cmdExecute As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblRestaurar As System.Windows.Forms.Label
End Class
