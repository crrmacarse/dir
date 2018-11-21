<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItemGroupInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemGroupInfo))
        Me.lblMessageTitle = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblUpdatedBy = New System.Windows.Forms.Label()
        Me.lblBusinessUnit = New System.Windows.Forms.Label()
        Me.lblDateUpdated = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtName = New WTIDIR.ucTextbox()
        Me.cmbShortageType = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblItemGroupShortageType = New System.Windows.Forms.Label()
        Me.lblItemGroupType = New System.Windows.Forms.Label()
        Me.lblItemGroupName = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPriority = New System.Windows.Forms.ComboBox()
        Me.lblItemGroupPriority = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessageTitle
        '
        Me.lblMessageTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessageTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMessageTitle.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblMessageTitle.Location = New System.Drawing.Point(116, 10)
        Me.lblMessageTitle.Name = "lblMessageTitle"
        Me.lblMessageTitle.Size = New System.Drawing.Size(226, 30)
        Me.lblMessageTitle.TabIndex = 45
        Me.lblMessageTitle.Text = "Item Group Information"
        Me.lblMessageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(245, 435)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(42, 35)
        Me.btnEdit.TabIndex = 29
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblUpdatedBy
        '
        Me.lblUpdatedBy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUpdatedBy.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdatedBy.ForeColor = System.Drawing.Color.DimGray
        Me.lblUpdatedBy.Location = New System.Drawing.Point(3, 43)
        Me.lblUpdatedBy.Name = "lblUpdatedBy"
        Me.lblUpdatedBy.Size = New System.Drawing.Size(199, 10)
        Me.lblUpdatedBy.TabIndex = 27
        Me.lblUpdatedBy.Text = "Last Updated By: Christian Ryan Macarse"
        '
        'lblBusinessUnit
        '
        Me.lblBusinessUnit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBusinessUnit.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessUnit.ForeColor = System.Drawing.Color.DimGray
        Me.lblBusinessUnit.Location = New System.Drawing.Point(3, 21)
        Me.lblBusinessUnit.Name = "lblBusinessUnit"
        Me.lblBusinessUnit.Size = New System.Drawing.Size(199, 10)
        Me.lblBusinessUnit.TabIndex = 26
        Me.lblBusinessUnit.Text = "Business Unit: Waffle Time"
        '
        'lblDateUpdated
        '
        Me.lblDateUpdated.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDateUpdated.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateUpdated.ForeColor = System.Drawing.Color.DimGray
        Me.lblDateUpdated.Location = New System.Drawing.Point(3, 32)
        Me.lblDateUpdated.Name = "lblDateUpdated"
        Me.lblDateUpdated.Size = New System.Drawing.Size(199, 13)
        Me.lblDateUpdated.TabIndex = 25
        Me.lblDateUpdated.Text = "Last Updated: September 03, 2018"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(296, 435)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 35)
        Me.btnClose.TabIndex = 30
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(245, 435)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(42, 35)
        Me.btnSave.TabIndex = 36
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lblUpdatedBy)
        Me.Panel2.Controls.Add(Me.lblBusinessUnit)
        Me.Panel2.Controls.Add(Me.lblDateUpdated)
        Me.Panel2.Location = New System.Drawing.Point(12, 409)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 61)
        Me.Panel2.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(352, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 481)
        Me.Panel1.TabIndex = 48
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 479)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 2)
        Me.Panel3.TabIndex = 50
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(16, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = False
        Me.txtName.Size = New System.Drawing.Size(326, 23)
        Me.txtName.TabIndex = 60
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbShortageType
        '
        Me.cmbShortageType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbShortageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShortageType.Enabled = False
        Me.cmbShortageType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShortageType.FormattingEnabled = True
        Me.cmbShortageType.Items.AddRange(New Object() {"True", "False"})
        Me.cmbShortageType.Location = New System.Drawing.Point(16, 209)
        Me.cmbShortageType.Name = "cmbShortageType"
        Me.cmbShortageType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbShortageType.Size = New System.Drawing.Size(326, 26)
        Me.cmbShortageType.TabIndex = 58
        '
        'cmbType
        '
        Me.cmbType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Enabled = False
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(16, 145)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbType.Size = New System.Drawing.Size(326, 26)
        Me.cmbType.TabIndex = 51
        '
        'lblItemGroupShortageType
        '
        Me.lblItemGroupShortageType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemGroupShortageType.AutoSize = True
        Me.lblItemGroupShortageType.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemGroupShortageType.ForeColor = System.Drawing.Color.Gray
        Me.lblItemGroupShortageType.Location = New System.Drawing.Point(265, 182)
        Me.lblItemGroupShortageType.Name = "lblItemGroupShortageType"
        Me.lblItemGroupShortageType.Size = New System.Drawing.Size(77, 12)
        Me.lblItemGroupShortageType.TabIndex = 56
        Me.lblItemGroupShortageType.Text = "Shortage Type"
        Me.lblItemGroupShortageType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemGroupType
        '
        Me.lblItemGroupType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemGroupType.AutoSize = True
        Me.lblItemGroupType.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemGroupType.ForeColor = System.Drawing.Color.Gray
        Me.lblItemGroupType.Location = New System.Drawing.Point(253, 121)
        Me.lblItemGroupType.Name = "lblItemGroupType"
        Me.lblItemGroupType.Size = New System.Drawing.Size(89, 12)
        Me.lblItemGroupType.TabIndex = 54
        Me.lblItemGroupType.Text = "Item Group Type"
        Me.lblItemGroupType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemGroupName
        '
        Me.lblItemGroupName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemGroupName.AutoSize = True
        Me.lblItemGroupName.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemGroupName.ForeColor = System.Drawing.Color.Gray
        Me.lblItemGroupName.Location = New System.Drawing.Point(248, 69)
        Me.lblItemGroupName.Name = "lblItemGroupName"
        Me.lblItemGroupName.Size = New System.Drawing.Size(94, 12)
        Me.lblItemGroupName.TabIndex = 53
        Me.lblItemGroupName.Text = "Item Group Name"
        Me.lblItemGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"True", "False"})
        Me.cmbStatus.Location = New System.Drawing.Point(16, 274)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbStatus.Size = New System.Drawing.Size(326, 26)
        Me.cmbStatus.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(304, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 12)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Status"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPriority
        '
        Me.cmbPriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriority.Enabled = False
        Me.cmbPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPriority.FormattingEnabled = True
        Me.cmbPriority.Items.AddRange(New Object() {"True", "False"})
        Me.cmbPriority.Location = New System.Drawing.Point(242, 343)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPriority.Size = New System.Drawing.Size(100, 23)
        Me.cmbPriority.TabIndex = 64
        '
        'lblItemGroupPriority
        '
        Me.lblItemGroupPriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemGroupPriority.AutoSize = True
        Me.lblItemGroupPriority.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemGroupPriority.ForeColor = System.Drawing.Color.Gray
        Me.lblItemGroupPriority.Location = New System.Drawing.Point(300, 316)
        Me.lblItemGroupPriority.Name = "lblItemGroupPriority"
        Me.lblItemGroupPriority.Size = New System.Drawing.Size(42, 12)
        Me.lblItemGroupPriority.TabIndex = 63
        Me.lblItemGroupPriority.Text = "Priority"
        Me.lblItemGroupPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmItemGroupInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(354, 481)
        Me.Controls.Add(Me.cmbPriority)
        Me.Controls.Add(Me.lblItemGroupPriority)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmbShortageType)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.lblItemGroupShortageType)
        Me.Controls.Add(Me.lblItemGroupType)
        Me.Controls.Add(Me.lblItemGroupName)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMessageTitle)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmItemGroupInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmItemGroupInfo"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessageTitle As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblUpdatedBy As Label
    Friend WithEvents lblBusinessUnit As Label
    Friend WithEvents lblDateUpdated As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtName As ucTextbox
    Friend WithEvents cmbShortageType As ComboBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblItemGroupShortageType As Label
    Friend WithEvents lblItemGroupType As Label
    Friend WithEvents lblItemGroupName As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents lblItemGroupPriority As Label
End Class
