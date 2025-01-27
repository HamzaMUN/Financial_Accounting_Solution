<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchCostCentre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchCostCentre))
        Me.nameL3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codeL3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'nameL3
        '
        Me.nameL3.Text = "Account Name"
        Me.nameL3.Width = 372
        '
        'codeL3
        '
        Me.codeL3.Text = "Code"
        Me.codeL3.Width = 94
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codeL3, Me.nameL3})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(484, 462)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'searchCostCentre
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "searchCostCentre"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Chart of Account"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nameL3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents codeL3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
