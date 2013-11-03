<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.listBox1 = New System.Windows.Forms.ListBox
        Me.panel5 = New System.Windows.Forms.Panel
        Me.LblListbox1 = New System.Windows.Forms.Label
        Me.panel4 = New System.Windows.Forms.Panel
        Me.panel3 = New System.Windows.Forms.Panel
        Me.LblListbox2 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.panel2 = New System.Windows.Forms.Panel
        Me.listBox2 = New System.Windows.Forms.ListBox
        Me.panel5.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'listBox1
        '
        Me.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(0, 20)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.listBox1.Size = New System.Drawing.Size(182, 82)
        Me.listBox1.TabIndex = 15
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.LblListbox1)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel5.Location = New System.Drawing.Point(0, 0)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(182, 23)
        Me.panel5.TabIndex = 14
        '
        'LblListbox1
        '
        Me.LblListbox1.AutoSize = True
        Me.LblListbox1.Location = New System.Drawing.Point(31, 6)
        Me.LblListbox1.Name = "LblListbox1"
        Me.LblListbox1.Size = New System.Drawing.Size(39, 13)
        Me.LblListbox1.TabIndex = 13
        Me.LblListbox1.Text = "Label1"
        Me.LblListbox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.listBox1)
        Me.panel4.Controls.Add(Me.panel5)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel4.Location = New System.Drawing.Point(0, 0)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(182, 102)
        Me.panel4.TabIndex = 13
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.LblListbox2)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(182, 22)
        Me.panel3.TabIndex = 11
        '
        'LblListbox2
        '
        Me.LblListbox2.AutoSize = True
        Me.LblListbox2.Location = New System.Drawing.Point(33, 6)
        Me.LblListbox2.Name = "LblListbox2"
        Me.LblListbox2.Size = New System.Drawing.Size(39, 13)
        Me.LblListbox2.TabIndex = 11
        Me.LblListbox2.Text = "Label1"
        Me.LblListbox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btnRemove)
        Me.panel1.Controls.Add(Me.btnAdd)
        Me.panel1.Location = New System.Drawing.Point(180, 6)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(46, 124)
        Me.panel1.TabIndex = 11
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(8, 50)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(29, 23)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "<"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(8, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(29, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = ">"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.panel3)
        Me.panel2.Controls.Add(Me.listBox2)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel2.Location = New System.Drawing.Point(234, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(182, 102)
        Me.panel2.TabIndex = 12
        '
        'listBox2
        '
        Me.listBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.Location = New System.Drawing.Point(0, 20)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.listBox2.Size = New System.Drawing.Size(182, 82)
        Me.listBox2.TabIndex = 9
        '
        'SelectControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel4)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel2)
        Me.Name = "SelectControl"
        Me.Size = New System.Drawing.Size(416, 102)
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents listBox1 As System.Windows.Forms.ListBox
    Private WithEvents panel5 As System.Windows.Forms.Panel
    Private WithEvents LblListbox1 As System.Windows.Forms.Label
    Private WithEvents panel4 As System.Windows.Forms.Panel
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents LblListbox2 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btnRemove As System.Windows.Forms.Button
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents listBox2 As System.Windows.Forms.ListBox

End Class
