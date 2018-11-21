<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucRepositories
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucRepositories))
        Me.cmsRawmats = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiRawmatUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDocumentName = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tpRawmats = New System.Windows.Forms.TabPage()
        Me.lvRawmats = New System.Windows.Forms.ListView()
        Me.chRawmatSKU = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRawmatSAPCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRawmatName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRawmatISPerishable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRawmatStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.msRepository = New System.Windows.Forms.MenuStrip()
        Me.tslRawmatSearch = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtRawmatSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.tsdrpManage = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslRawmats = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tpItemGroup = New System.Windows.Forms.TabPage()
        Me.lvItemGroup = New System.Windows.Forms.ListView()
        Me.chItemGroupSKU = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chItemGroupName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chItemGroupType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chItemGroupShortageType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chItemGroupStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.tsslItemGroupCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.msItemGroup = New System.Windows.Forms.MenuStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtItemGroupSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.tsddbItemGroup = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiItemGroupNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpProductItem = New System.Windows.Forms.TabPage()
        Me.lvProductItem = New System.Windows.Forms.ListView()
        Me.chProductItemSKU = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chProductItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.tsslProductItemCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtProductItem = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcRepository = New System.Windows.Forms.TabControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmsRawmats.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tpRawmats.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.msRepository.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.tpItemGroup.SuspendLayout()
        Me.StatusStrip3.SuspendLayout()
        Me.msItemGroup.SuspendLayout()
        Me.tpProductItem.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.tcRepository.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsRawmats
        '
        Me.cmsRawmats.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiRawmatUpdate})
        Me.cmsRawmats.Name = "cmsRawmats"
        Me.cmsRawmats.Size = New System.Drawing.Size(113, 26)
        '
        'tsmiRawmatUpdate
        '
        Me.tsmiRawmatUpdate.Name = "tsmiRawmatUpdate"
        Me.tsmiRawmatUpdate.Size = New System.Drawing.Size(112, 22)
        Me.tsmiRawmatUpdate.Text = "Update"
        '
        'lblDocumentName
        '
        Me.lblDocumentName.BackColor = System.Drawing.Color.Transparent
        Me.lblDocumentName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDocumentName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentName.ForeColor = System.Drawing.Color.White
        Me.lblDocumentName.Location = New System.Drawing.Point(0, 0)
        Me.lblDocumentName.Name = "lblDocumentName"
        Me.lblDocumentName.Size = New System.Drawing.Size(842, 30)
        Me.lblDocumentName.TabIndex = 4
        Me.lblDocumentName.Text = "Repository Management"
        Me.lblDocumentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(819, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(16, 16)
        Me.btnClose.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblDocumentName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 39)
        Me.Panel1.TabIndex = 3
        '
        'tpRawmats
        '
        Me.tpRawmats.Controls.Add(Me.lvRawmats)
        Me.tpRawmats.Controls.Add(Me.Panel2)
        Me.tpRawmats.Controls.Add(Me.msRepository)
        Me.tpRawmats.Controls.Add(Me.StatusStrip1)
        Me.tpRawmats.Location = New System.Drawing.Point(4, 22)
        Me.tpRawmats.Name = "tpRawmats"
        Me.tpRawmats.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRawmats.Size = New System.Drawing.Size(834, 320)
        Me.tpRawmats.TabIndex = 1
        Me.tpRawmats.Text = "Rawmats"
        Me.tpRawmats.UseVisualStyleBackColor = True
        '
        'lvRawmats
        '
        Me.lvRawmats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvRawmats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRawmatSKU, Me.chRawmatSAPCode, Me.chRawmatName, Me.chRawmatISPerishable, Me.chRawmatStatus})
        Me.lvRawmats.ContextMenuStrip = Me.cmsRawmats
        Me.lvRawmats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRawmats.FullRowSelect = True
        Me.lvRawmats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRawmats.Location = New System.Drawing.Point(3, 28)
        Me.lvRawmats.MultiSelect = False
        Me.lvRawmats.Name = "lvRawmats"
        Me.lvRawmats.Size = New System.Drawing.Size(571, 267)
        Me.lvRawmats.TabIndex = 13
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(574, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 267)
        Me.Panel2.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(246, 14)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "True"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(6, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(225, 12)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Status"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 14)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "True"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(6, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 12)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "IS Perishable"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 14)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "American Hotdog"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(6, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 12)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Rawmat Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 14)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "43553213154"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(6, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(225, 12)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "SAP Code"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(246, 14)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "GEN-IG-01-1000"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "SKU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'msRepository
        '
        Me.msRepository.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.msRepository.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslRawmatSearch, Me.tstxtRawmatSearch, Me.tsdrpManage})
        Me.msRepository.Location = New System.Drawing.Point(3, 3)
        Me.msRepository.Name = "msRepository"
        Me.msRepository.Size = New System.Drawing.Size(828, 25)
        Me.msRepository.TabIndex = 15
        Me.msRepository.Text = "MenuStrip1"
        '
        'tslRawmatSearch
        '
        Me.tslRawmatSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tslRawmatSearch.Image = CType(resources.GetObject("tslRawmatSearch.Image"), System.Drawing.Image)
        Me.tslRawmatSearch.Margin = New System.Windows.Forms.Padding(0, 1, 3, 2)
        Me.tslRawmatSearch.Name = "tslRawmatSearch"
        Me.tslRawmatSearch.Size = New System.Drawing.Size(16, 18)
        Me.tslRawmatSearch.Text = "Search"
        '
        'tstxtRawmatSearch
        '
        Me.tstxtRawmatSearch.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tstxtRawmatSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.tstxtRawmatSearch.Name = "tstxtRawmatSearch"
        Me.tstxtRawmatSearch.Size = New System.Drawing.Size(150, 21)
        '
        'tsdrpManage
        '
        Me.tsdrpManage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsdrpManage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNew, Me.PrintToolStripMenuItem, Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.tsdrpManage.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tsdrpManage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsdrpManage.Image = CType(resources.GetObject("tsdrpManage.Image"), System.Drawing.Image)
        Me.tsdrpManage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdrpManage.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.tsdrpManage.Name = "tsdrpManage"
        Me.tsdrpManage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tsdrpManage.ShowDropDownArrow = False
        Me.tsdrpManage.Size = New System.Drawing.Size(71, 21)
        Me.tsdrpManage.Text = "Manage"
        '
        'tsmiNew
        '
        Me.tsmiNew.Name = "tsmiNew"
        Me.tsmiNew.Size = New System.Drawing.Size(113, 22)
        Me.tsmiNew.Text = "New"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslRawmats})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 295)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(828, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslRawmats
        '
        Me.tsslRawmats.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.tsslRawmats.ForeColor = System.Drawing.Color.White
        Me.tsslRawmats.Name = "tsslRawmats"
        Me.tsslRawmats.Size = New System.Drawing.Size(102, 17)
        Me.tsslRawmats.Text = "Total Count: 150"
        '
        'tpItemGroup
        '
        Me.tpItemGroup.Controls.Add(Me.Panel3)
        Me.tpItemGroup.Controls.Add(Me.lvItemGroup)
        Me.tpItemGroup.Controls.Add(Me.StatusStrip3)
        Me.tpItemGroup.Controls.Add(Me.msItemGroup)
        Me.tpItemGroup.Location = New System.Drawing.Point(4, 22)
        Me.tpItemGroup.Name = "tpItemGroup"
        Me.tpItemGroup.Padding = New System.Windows.Forms.Padding(3)
        Me.tpItemGroup.Size = New System.Drawing.Size(834, 320)
        Me.tpItemGroup.TabIndex = 2
        Me.tpItemGroup.Text = "Item Group"
        Me.tpItemGroup.UseVisualStyleBackColor = True
        '
        'lvItemGroup
        '
        Me.lvItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvItemGroup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chItemGroupSKU, Me.chItemGroupName, Me.chItemGroupType, Me.chItemGroupShortageType, Me.chItemGroupStatus})
        Me.lvItemGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvItemGroup.FullRowSelect = True
        Me.lvItemGroup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvItemGroup.Location = New System.Drawing.Point(3, 28)
        Me.lvItemGroup.Name = "lvItemGroup"
        Me.lvItemGroup.Size = New System.Drawing.Size(828, 267)
        Me.lvItemGroup.TabIndex = 23
        Me.lvItemGroup.UseCompatibleStateImageBehavior = False
        Me.lvItemGroup.View = System.Windows.Forms.View.Details
        '
        'chItemGroupSKU
        '
        Me.chItemGroupSKU.Text = "SKU Code"
        Me.chItemGroupSKU.Width = 120
        '
        'chItemGroupName
        '
        Me.chItemGroupName.Text = "Item Group Name"
        Me.chItemGroupName.Width = 230
        '
        'chItemGroupType
        '
        Me.chItemGroupType.Text = "Item Group Type"
        Me.chItemGroupType.Width = 150
        '
        'chItemGroupShortageType
        '
        Me.chItemGroupShortageType.Text = "Shortage Type"
        Me.chItemGroupShortageType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chItemGroupShortageType.Width = 130
        '
        'chItemGroupStatus
        '
        Me.chItemGroupStatus.Text = "Status"
        Me.chItemGroupStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chItemGroupStatus.Width = 100
        '
        'StatusStrip3
        '
        Me.StatusStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StatusStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslItemGroupCount})
        Me.StatusStrip3.Location = New System.Drawing.Point(3, 295)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Size = New System.Drawing.Size(828, 22)
        Me.StatusStrip3.TabIndex = 24
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'tsslItemGroupCount
        '
        Me.tsslItemGroupCount.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.tsslItemGroupCount.ForeColor = System.Drawing.Color.White
        Me.tsslItemGroupCount.Name = "tsslItemGroupCount"
        Me.tsslItemGroupCount.Size = New System.Drawing.Size(102, 17)
        Me.tsslItemGroupCount.Text = "Total Count: 150"
        '
        'msItemGroup
        '
        Me.msItemGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.msItemGroup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tstxtItemGroupSearch, Me.tsddbItemGroup})
        Me.msItemGroup.Location = New System.Drawing.Point(3, 3)
        Me.msItemGroup.Name = "msItemGroup"
        Me.msItemGroup.Size = New System.Drawing.Size(828, 25)
        Me.msItemGroup.TabIndex = 25
        Me.msItemGroup.Text = "MenuStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(0, 1, 3, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 18)
        Me.ToolStripLabel1.Text = "Search"
        '
        'tstxtItemGroupSearch
        '
        Me.tstxtItemGroupSearch.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tstxtItemGroupSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.tstxtItemGroupSearch.Name = "tstxtItemGroupSearch"
        Me.tstxtItemGroupSearch.Size = New System.Drawing.Size(150, 21)
        '
        'tsddbItemGroup
        '
        Me.tsddbItemGroup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsddbItemGroup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiItemGroupNew, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.tsddbItemGroup.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tsddbItemGroup.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsddbItemGroup.Image = CType(resources.GetObject("tsddbItemGroup.Image"), System.Drawing.Image)
        Me.tsddbItemGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsddbItemGroup.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.tsddbItemGroup.Name = "tsddbItemGroup"
        Me.tsddbItemGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tsddbItemGroup.ShowDropDownArrow = False
        Me.tsddbItemGroup.Size = New System.Drawing.Size(71, 21)
        Me.tsddbItemGroup.Text = "Manage"
        '
        'tsmiItemGroupNew
        '
        Me.tsmiItemGroupNew.Name = "tsmiItemGroupNew"
        Me.tsmiItemGroupNew.Size = New System.Drawing.Size(113, 22)
        Me.tsmiItemGroupNew.Text = "New"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem3.Text = "Print"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem4.Text = "Import"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem5.Text = "Export"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem6.Text = "Report"
        '
        'tpProductItem
        '
        Me.tpProductItem.Controls.Add(Me.Panel4)
        Me.tpProductItem.Controls.Add(Me.lvProductItem)
        Me.tpProductItem.Controls.Add(Me.StatusStrip2)
        Me.tpProductItem.Controls.Add(Me.MenuStrip1)
        Me.tpProductItem.Location = New System.Drawing.Point(4, 22)
        Me.tpProductItem.Name = "tpProductItem"
        Me.tpProductItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProductItem.Size = New System.Drawing.Size(834, 320)
        Me.tpProductItem.TabIndex = 0
        Me.tpProductItem.Text = "Product Item"
        Me.tpProductItem.UseVisualStyleBackColor = True
        '
        'lvProductItem
        '
        Me.lvProductItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chProductItemSKU, Me.chProductItemName})
        Me.lvProductItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvProductItem.Location = New System.Drawing.Point(3, 28)
        Me.lvProductItem.Name = "lvProductItem"
        Me.lvProductItem.Size = New System.Drawing.Size(828, 267)
        Me.lvProductItem.TabIndex = 18
        Me.lvProductItem.UseCompatibleStateImageBehavior = False
        Me.lvProductItem.View = System.Windows.Forms.View.Details
        '
        'chProductItemSKU
        '
        Me.chProductItemSKU.Text = "SKU Code"
        Me.chProductItemSKU.Width = 100
        '
        'chProductItemName
        '
        Me.chProductItemName.Text = "Product Item Name"
        Me.chProductItemName.Width = 180
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslProductItemCount})
        Me.StatusStrip2.Location = New System.Drawing.Point(3, 295)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(828, 22)
        Me.StatusStrip2.TabIndex = 19
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'tsslProductItemCount
        '
        Me.tsslProductItemCount.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.tsslProductItemCount.ForeColor = System.Drawing.Color.White
        Me.tsslProductItemCount.Name = "tsslProductItemCount"
        Me.tsslProductItemCount.Size = New System.Drawing.Size(102, 17)
        Me.tsslProductItemCount.Text = "Total Count: 150"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tstxtProductItem, Me.ToolStripDropDownButton1})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(828, 25)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripLabel2.Image = CType(resources.GetObject("ToolStripLabel2.Image"), System.Drawing.Image)
        Me.ToolStripLabel2.Margin = New System.Windows.Forms.Padding(0, 1, 3, 2)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 18)
        Me.ToolStripLabel2.Text = "Search"
        '
        'tstxtProductItem
        '
        Me.tstxtProductItem.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tstxtProductItem.Margin = New System.Windows.Forms.Padding(0)
        Me.tstxtProductItem.Name = "tstxtProductItem"
        Me.tstxtProductItem.Size = New System.Drawing.Size(150, 21)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripDropDownButton1.ShowDropDownArrow = False
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(71, 21)
        Me.ToolStripDropDownButton1.Text = "Manage"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem1.Text = "New"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem2.Text = "Print"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem7.Text = "Import"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem8.Text = "Export"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem9.Text = "Report"
        '
        'tcRepository
        '
        Me.tcRepository.Controls.Add(Me.tpProductItem)
        Me.tcRepository.Controls.Add(Me.tpItemGroup)
        Me.tcRepository.Controls.Add(Me.tpRawmats)
        Me.tcRepository.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcRepository.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcRepository.Location = New System.Drawing.Point(0, 39)
        Me.tcRepository.Name = "tcRepository"
        Me.tcRepository.SelectedIndex = 0
        Me.tcRepository.Size = New System.Drawing.Size(842, 346)
        Me.tcRepository.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tcRepository.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(574, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 267)
        Me.Panel3.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 14)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "True"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(6, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 12)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Status"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(6, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(246, 14)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "True"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(6, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(225, 12)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "IS Perishable"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(6, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 14)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "American Hotdog"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(6, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(225, 12)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Rawmat Name"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(6, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(246, 14)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "43553213154"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightGray
        Me.Label18.Location = New System.Drawing.Point(6, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(225, 12)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "SAP Code"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(6, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(246, 14)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "GEN-IG-01-1000"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LightGray
        Me.Label20.Location = New System.Drawing.Point(6, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(225, 12)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "SKU"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(574, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(257, 267)
        Me.Panel4.TabIndex = 27
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(6, 213)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(246, 14)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "True"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LightGray
        Me.Label22.Location = New System.Drawing.Point(6, 192)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(225, 12)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Status"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(6, 169)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(246, 14)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "True"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LightGray
        Me.Label24.Location = New System.Drawing.Point(6, 148)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(225, 12)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "IS Perishable"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(6, 125)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(246, 14)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "American Hotdog"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.LightGray
        Me.Label26.Location = New System.Drawing.Point(6, 104)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(225, 12)
        Me.Label26.TabIndex = 26
        Me.Label26.Text = "Rawmat Name"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(6, 81)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(246, 14)
        Me.Label27.TabIndex = 25
        Me.Label27.Text = "43553213154"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.LightGray
        Me.Label28.Location = New System.Drawing.Point(6, 60)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(225, 12)
        Me.Label28.TabIndex = 24
        Me.Label28.Text = "SAP Code"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(6, 37)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(246, 14)
        Me.Label29.TabIndex = 19
        Me.Label29.Text = "GEN-IG-01-1000"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.Font = New System.Drawing.Font("Verdana", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.LightGray
        Me.Label30.Location = New System.Drawing.Point(6, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(225, 12)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "SKU"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ucRepositories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.tcRepository)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "ucRepositories"
        Me.Size = New System.Drawing.Size(842, 385)
        Me.cmsRawmats.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.tpRawmats.ResumeLayout(False)
        Me.tpRawmats.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.msRepository.ResumeLayout(False)
        Me.msRepository.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tpItemGroup.ResumeLayout(False)
        Me.tpItemGroup.PerformLayout()
        Me.StatusStrip3.ResumeLayout(False)
        Me.StatusStrip3.PerformLayout()
        Me.msItemGroup.ResumeLayout(False)
        Me.msItemGroup.PerformLayout()
        Me.tpProductItem.ResumeLayout(False)
        Me.tpProductItem.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tcRepository.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmsRawmats As ContextMenuStrip
    Friend WithEvents tsmiRawmatUpdate As ToolStripMenuItem
    Friend WithEvents lblDocumentName As Label
    Friend WithEvents btnClose As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tpRawmats As TabPage
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslRawmats As ToolStripStatusLabel
    Friend WithEvents tpItemGroup As TabPage
    Friend WithEvents lvItemGroup As ListView
    Friend WithEvents chItemGroupSKU As ColumnHeader
    Friend WithEvents chItemGroupName As ColumnHeader
    Friend WithEvents StatusStrip3 As StatusStrip
    Friend WithEvents tsslItemGroupCount As ToolStripStatusLabel
    Friend WithEvents tpProductItem As TabPage
    Friend WithEvents lvProductItem As ListView
    Friend WithEvents chProductItemSKU As ColumnHeader
    Friend WithEvents chProductItemName As ColumnHeader
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents tsslProductItemCount As ToolStripStatusLabel
    Friend WithEvents tcRepository As TabControl
    Friend WithEvents msRepository As MenuStrip
    Friend WithEvents tslRawmatSearch As ToolStripLabel
    Friend WithEvents tstxtRawmatSearch As ToolStripTextBox
    Friend WithEvents tsdrpManage As ToolStripDropDownButton
    Friend WithEvents tsmiNew As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lvRawmats As ListView
    Friend WithEvents chRawmatSKU As ColumnHeader
    Friend WithEvents chRawmatSAPCode As ColumnHeader
    Friend WithEvents chRawmatName As ColumnHeader
    Friend WithEvents chRawmatISPerishable As ColumnHeader
    Friend WithEvents chRawmatStatus As ColumnHeader
    Friend WithEvents msItemGroup As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tstxtItemGroupSearch As ToolStripTextBox
    Friend WithEvents tsddbItemGroup As ToolStripDropDownButton
    Friend WithEvents tsmiItemGroupNew As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents chItemGroupStatus As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tstxtProductItem As ToolStripTextBox
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents chItemGroupType As ColumnHeader
    Friend WithEvents chItemGroupShortageType As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
End Class
