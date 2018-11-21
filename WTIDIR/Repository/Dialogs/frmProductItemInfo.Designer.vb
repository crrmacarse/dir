<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductItemInfo
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbPriority = New System.Windows.Forms.ComboBox()
        Me.lblItemGroupPriority = New System.Windows.Forms.Label()
        Me.txtName = New WTIDIR.ucTextbox()
        Me.txtSAPCode = New WTIDIR.ucTextbox()
        Me.txtSKU = New WTIDIR.ucTextbox()
        Me.lblMessageTitle = New System.Windows.Forms.Label()
        Me.cmbIsPerishable = New System.Windows.Forms.ComboBox()
        Me.cmbItemGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(3, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(199, 10)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Last Updated By: Christian Ryan Macarse"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(3, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 10)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Business Unit: Waffle Time"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(298, 445)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 35)
        Me.btnClose.TabIndex = 32
        Me.btnClose.UseVisualStyleBackColor = False
        Me.btnClose.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(247, 445)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(42, 35)
        Me.btnSave.TabIndex = 30
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(12, 427)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 61)
        Me.Panel2.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(3, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(199, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Last Updated: September 03, 2018"
        '
        'cmbPriority
        '
        Me.cmbPriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriority.Enabled = False
        Me.cmbPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPriority.FormattingEnabled = True
        Me.cmbPriority.Items.AddRange(New Object() {"True", "False"})
        Me.cmbPriority.Location = New System.Drawing.Point(238, 340)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPriority.Size = New System.Drawing.Size(100, 23)
        Me.cmbPriority.TabIndex = 79
        '
        'lblItemGroupPriority
        '
        Me.lblItemGroupPriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemGroupPriority.AutoSize = True
        Me.lblItemGroupPriority.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemGroupPriority.ForeColor = System.Drawing.Color.Gray
        Me.lblItemGroupPriority.Location = New System.Drawing.Point(296, 315)
        Me.lblItemGroupPriority.Name = "lblItemGroupPriority"
        Me.lblItemGroupPriority.Size = New System.Drawing.Size(42, 12)
        Me.lblItemGroupPriority.TabIndex = 78
        Me.lblItemGroupPriority.Text = "Priority"
        Me.lblItemGroupPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(11, 222)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = False
        Me.txtName.Size = New System.Drawing.Size(326, 23)
        Me.txtName.TabIndex = 77
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSAPCode
        '
        Me.txtSAPCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSAPCode.Location = New System.Drawing.Point(12, 132)
        Me.txtSAPCode.Name = "txtSAPCode"
        Me.txtSAPCode.ReadOnly = False
        Me.txtSAPCode.Size = New System.Drawing.Size(326, 23)
        Me.txtSAPCode.TabIndex = 76
        Me.txtSAPCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSKU
        '
        Me.txtSKU.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSKU.Location = New System.Drawing.Point(12, 87)
        Me.txtSKU.Name = "txtSKU"
        Me.txtSKU.ReadOnly = False
        Me.txtSKU.Size = New System.Drawing.Size(326, 23)
        Me.txtSKU.TabIndex = 75
        Me.txtSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMessageTitle
        '
        Me.lblMessageTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessageTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMessageTitle.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblMessageTitle.Location = New System.Drawing.Point(116, 9)
        Me.lblMessageTitle.Name = "lblMessageTitle"
        Me.lblMessageTitle.Size = New System.Drawing.Size(226, 30)
        Me.lblMessageTitle.TabIndex = 74
        Me.lblMessageTitle.Text = "Rawmats Information"
        Me.lblMessageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbIsPerishable
        '
        Me.cmbIsPerishable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbIsPerishable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIsPerishable.Enabled = False
        Me.cmbIsPerishable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIsPerishable.FormattingEnabled = True
        Me.cmbIsPerishable.Items.AddRange(New Object() {"True", "False"})
        Me.cmbIsPerishable.Location = New System.Drawing.Point(11, 275)
        Me.cmbIsPerishable.Name = "cmbIsPerishable"
        Me.cmbIsPerishable.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbIsPerishable.Size = New System.Drawing.Size(326, 23)
        Me.cmbIsPerishable.TabIndex = 73
        '
        'cmbItemGroup
        '
        Me.cmbItemGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbItemGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemGroup.Enabled = False
        Me.cmbItemGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemGroup.FormattingEnabled = True
        Me.cmbItemGroup.Location = New System.Drawing.Point(12, 177)
        Me.cmbItemGroup.Name = "cmbItemGroup"
        Me.cmbItemGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbItemGroup.Size = New System.Drawing.Size(326, 23)
        Me.cmbItemGroup.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(258, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 12)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "IS Perishable?"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(304, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 12)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(276, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 12)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Item Group"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(282, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 12)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "SAP Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(311, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 12)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "SKU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmProductItemInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(354, 494)
        Me.Controls.Add(Me.cmbPriority)
        Me.Controls.Add(Me.lblItemGroupPriority)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSAPCode)
        Me.Controls.Add(Me.txtSKU)
        Me.Controls.Add(Me.lblMessageTitle)
        Me.Controls.Add(Me.cmbIsPerishable)
        Me.Controls.Add(Me.cmbItemGroup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductItemInfo"
        Me.Text = "frmProductItemInfo"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents lblItemGroupPriority As Label
    Friend WithEvents txtName As ucTextbox
    Friend WithEvents txtSAPCode As ucTextbox
    Friend WithEvents txtSKU As ucTextbox
    Friend WithEvents lblMessageTitle As Label
    Friend WithEvents cmbIsPerishable As ComboBox
    Friend WithEvents cmbItemGroup As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
