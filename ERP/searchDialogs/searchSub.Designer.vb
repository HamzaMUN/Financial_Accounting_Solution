<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchSub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchSub))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.codeSub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nameSub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subCat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codeSub, Me.nameSub, Me.subCat})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(584, 461)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'codeSub
        '
        Me.codeSub.Text = "Code"
        Me.codeSub.Width = 94
        '
        'nameSub
        '
        Me.nameSub.Text = "Account Name"
        Me.nameSub.Width = 372
        '
        'subCat
        '
        Me.subCat.Text = "Type"
        Me.subCat.Width = 100
        '
        'searchSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 500)
        Me.Name = "searchSub"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Subsidiary Accounts"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents codeSub As System.Windows.Forms.ColumnHeader
    Friend WithEvents nameSub As System.Windows.Forms.ColumnHeader
    Friend WithEvents subCat As System.Windows.Forms.ColumnHeader
End Class
