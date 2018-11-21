<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRawmat
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
        Me.lvRawmats = New System.Windows.Forms.ListView()
        Me.chRawmatSKU = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRawmatSAPCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRawmatName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRawmatISPerishable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRawmatStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvRawmats
        '
        Me.lvRawmats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvRawmats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRawmatSKU, Me.chRawmatSAPCode, Me.chRawmatName, Me.chRawmatISPerishable, Me.chRawmatStatus})
        Me.lvRawmats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRawmats.FullRowSelect = True
        Me.lvRawmats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRawmats.Location = New System.Drawing.Point(0, 0)
        Me.lvRawmats.MultiSelect = False
        Me.lvRawmats.Name = "lvRawmats"
        Me.lvRawmats.Size = New System.Drawing.Size(881, 336)
        Me.lvRawmats.TabIndex = 14
        Me.lvRawmats.UseCompatibleStateImageBehavior = False
        Me.lvRawmats.View = System.Windows.Forms.View.Details
        '
        'chRawmatSKU
        '
        Me.chRawmatSKU.Text = "SKU Code"
        Me.chRawmatSKU.Width = 120
        '
        'chRawmatSAPCode
        '
        Me.chRawmatSAPCode.Text = "SAP Code"
        Me.chRawmatSAPCode.Width = 130
        '
        'chRawmatName
        '
        Me.chRawmatName.Text = "Rawmat Name"
        Me.chRawmatName.Width = 230
        '
        'chRawmatISPerishable
        '
        Me.chRawmatISPerishable.Text = "Is Perishable"
        Me.chRawmatISPerishable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chRawmatISPerishable.Width = 123
        '
        'chRawmatStatus
        '
        Me.chRawmatStatus.Text = "Status"
        Me.chRawmatStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chRawmatStatus.Width = 100
        '
        'ucRawmat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.lvRawmats)
        Me.Name = "ucRawmat"
        Me.Size = New System.Drawing.Size(881, 336)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvRawmats As ListView
    Friend WithEvents chRawmatSKU As ColumnHeader
    Friend WithEvents chRawmatSAPCode As ColumnHeader
    Friend WithEvents chRawmatName As ColumnHeader
    Friend WithEvents chRawmatISPerishable As ColumnHeader
    Friend WithEvents chRawmatStatus As ColumnHeader
End Class
