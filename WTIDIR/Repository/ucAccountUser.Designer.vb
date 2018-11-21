<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucAccountUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAccountUser))
        Me.tAccounUser = New System.Windows.Forms.Timer(Me.components)
        Me.cmslvAccountUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttAccountUser = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmslvAccountGroup = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvAccountGroup = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.tsslAGCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAGActiveGroup = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAGInactiveGroup = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstxtAGSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbtnAGAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvAccountUser = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslAUCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAUActiveCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAUInactiveCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tstxtAUSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbtnAUAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tcAccountUser = New System.Windows.Forms.TabControl()
        Me.ilAccountUser = New System.Windows.Forms.ImageList(Me.components)
        Me.ofdAccountUser = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmslvAccountUser.SuspendLayout()
        Me.cmslvAccountGroup.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.tcAccountUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'tAccounUser
        '
        Me.tAccounUser.Interval = 120
        '
        'cmslvAccountUser
        '
        Me.cmslvAccountUser.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmslvAccountUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ActivateToolStripMenuItem})
        Me.cmslvAccountUser.Name = "ContextMenuStrip1"
        Me.cmslvAccountUser.Size = New System.Drawing.Size(177, 70)
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.UpdateToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateToolStripMenuItem.Image = CType(resources.GetObject("UpdateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UpdateToolStripMenuItem.Text = "Update User"
        Me.UpdateToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ChangePasswordToolStripMenuItem.Image = CType(resources.GetObject("ChangePasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        Me.ChangePasswordToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActivateToolStripMenuItem
        '
        Me.ActivateToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ActivateToolStripMenuItem.Image = CType(resources.GetObject("ActivateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActivateToolStripMenuItem.Name = "ActivateToolStripMenuItem"
        Me.ActivateToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ActivateToolStripMenuItem.Text = "Activate"
        '
        'ttAccountUser
        '
        Me.ttAccountUser.AutoPopDelay = 50000
        Me.ttAccountUser.BackColor = System.Drawing.Color.White
        Me.ttAccountUser.InitialDelay = 500
        Me.ttAccountUser.ReshowDelay = 1000
        '
        'cmslvAccountGroup
        '
        Me.cmslvAccountGroup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITToolStripMenuItem, Me.RToolStripMenuItem})
        Me.cmslvAccountGroup.Name = "ContextMenuStrip2"
        Me.cmslvAccountGroup.Size = New System.Drawing.Size(154, 48)
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EDITToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDITToolStripMenuItem.Image = CType(resources.GetObject("EDITToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EDITToolStripMenuItem.Text = "Update Group"
        '
        'RToolStripMenuItem
        '
        Me.RToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.RToolStripMenuItem.Image = CType(resources.GetObject("RToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RToolStripMenuItem.Name = "RToolStripMenuItem"
        Me.RToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RToolStripMenuItem.Text = "REMOVE"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.lvAccountGroup)
        Me.TabPage2.Controls.Add(Me.StatusStrip2)
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(599, 629)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Group"
        '
        'lvAccountGroup
        '
        Me.lvAccountGroup.AutoArrange = False
        Me.lvAccountGroup.BackColor = System.Drawing.Color.White
        Me.lvAccountGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvAccountGroup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvAccountGroup.ContextMenuStrip = Me.cmslvAccountGroup
        Me.lvAccountGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvAccountGroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAccountGroup.FullRowSelect = True
        Me.lvAccountGroup.GridLines = True
        Me.lvAccountGroup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvAccountGroup.Location = New System.Drawing.Point(0, 25)
        Me.lvAccountGroup.Name = "lvAccountGroup"
        Me.lvAccountGroup.Size = New System.Drawing.Size(599, 582)
        Me.lvAccountGroup.TabIndex = 47
        Me.lvAccountGroup.UseCompatibleStateImageBehavior = False
        Me.lvAccountGroup.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Name"
        Me.ColumnHeader8.Width = 350
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Status"
        Me.ColumnHeader9.Width = 250
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslAGCount, Me.ToolStripStatusLabel4, Me.tsslAGActiveGroup, Me.ToolStripStatusLabel6, Me.tsslAGInactiveGroup})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 607)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(599, 22)
        Me.StatusStrip2.TabIndex = 49
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'tsslAGCount
        '
        Me.tsslAGCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslAGCount.ForeColor = System.Drawing.Color.White
        Me.tsslAGCount.Name = "tsslAGCount"
        Me.tsslAGCount.Size = New System.Drawing.Size(95, 17)
        Me.tsslAGCount.Text = "Total Count: 15"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel4.Text = "    "
        '
        'tsslAGActiveGroup
        '
        Me.tsslAGActiveGroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslAGActiveGroup.ForeColor = System.Drawing.Color.White
        Me.tsslAGActiveGroup.Name = "tsslAGActiveGroup"
        Me.tsslAGActiveGroup.Size = New System.Drawing.Size(104, 17)
        Me.tsslAGActiveGroup.Text = "Active Group: 15"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel6.Text = "    "
        '
        'tsslAGInactiveGroup
        '
        Me.tsslAGInactiveGroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslAGInactiveGroup.ForeColor = System.Drawing.Color.White
        Me.tsslAGInactiveGroup.Name = "tsslAGInactiveGroup"
        Me.tsslAGInactiveGroup.Size = New System.Drawing.Size(115, 17)
        Me.tsslAGInactiveGroup.Text = "Inactive Group: 15"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstxtAGSearch, Me.ToolStripLabel2, Me.tsbtnAGAdd, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(599, 25)
        Me.ToolStrip1.TabIndex = 50
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstxtAGSearch
        '
        Me.tstxtAGSearch.BackColor = System.Drawing.Color.White
        Me.tstxtAGSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtAGSearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstxtAGSearch.Name = "tstxtAGSearch"
        Me.tstxtAGSearch.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Image = CType(resources.GetObject("ToolStripLabel2.Image"), System.Drawing.Image)
        Me.ToolStripLabel2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel2.Text = "Help"
        Me.ToolStripLabel2.ToolTipText = "Help"
        '
        'tsbtnAGAdd
        '
        Me.tsbtnAGAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnAGAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAGAdd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnAGAdd.ForeColor = System.Drawing.Color.White
        Me.tsbtnAGAdd.Image = CType(resources.GetObject("tsbtnAGAdd.Image"), System.Drawing.Image)
        Me.tsbtnAGAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAGAdd.Name = "tsbtnAGAdd"
        Me.tsbtnAGAdd.Size = New System.Drawing.Size(33, 22)
        Me.tsbtnAGAdd.Text = "Add"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(20, 19)
        Me.ToolStripButton1.Text = "ToolStripButton2"
        Me.ToolStripButton1.ToolTipText = "Search"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.lvAccountUser)
        Me.TabPage1.Controls.Add(Me.StatusStrip1)
        Me.TabPage1.Controls.Add(Me.ToolStrip2)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(599, 629)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User"
        '
        'lvAccountUser
        '
        Me.lvAccountUser.AutoArrange = False
        Me.lvAccountUser.BackColor = System.Drawing.Color.White
        Me.lvAccountUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvAccountUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvAccountUser.ContextMenuStrip = Me.cmslvAccountUser
        Me.lvAccountUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvAccountUser.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAccountUser.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lvAccountUser.FullRowSelect = True
        Me.lvAccountUser.GridLines = True
        Me.lvAccountUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvAccountUser.Location = New System.Drawing.Point(0, 25)
        Me.lvAccountUser.Name = "lvAccountUser"
        Me.lvAccountUser.Size = New System.Drawing.Size(599, 582)
        Me.lvAccountUser.TabIndex = 22
        Me.lvAccountUser.UseCompatibleStateImageBehavior = False
        Me.lvAccountUser.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Last Name"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Middle Name"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Username"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Group"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 150
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslAUCount, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.tsslAUActiveCount, Me.ToolStripStatusLabel3, Me.tsslAUInactiveCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 607)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(599, 22)
        Me.StatusStrip1.TabIndex = 67
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslAUCount
        '
        Me.tsslAUCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslAUCount.ForeColor = System.Drawing.Color.White
        Me.tsslAUCount.Name = "tsslAUCount"
        Me.tsslAUCount.Size = New System.Drawing.Size(95, 17)
        Me.tsslAUCount.Text = "Total Count: 15"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel2.Text = "    "
        '
        'tsslAUActiveCount
        '
        Me.tsslAUActiveCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslAUActiveCount.ForeColor = System.Drawing.Color.White
        Me.tsslAUActiveCount.Name = "tsslAUActiveCount"
        Me.tsslAUActiveCount.Size = New System.Drawing.Size(95, 17)
        Me.tsslAUActiveCount.Text = "Active User: 15"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel3.Text = "    "
        '
        'tsslAUInactiveCount
        '
        Me.tsslAUInactiveCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslAUInactiveCount.ForeColor = System.Drawing.Color.White
        Me.tsslAUInactiveCount.Name = "tsslAUInactiveCount"
        Me.tsslAUInactiveCount.Size = New System.Drawing.Size(106, 17)
        Me.tsslAUInactiveCount.Text = "Inactive User: 15"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstxtAUSearch, Me.ToolStripLabel1, Me.tsbtnAUAdd, Me.ToolStripButton2})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(599, 25)
        Me.ToolStrip2.TabIndex = 68
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tstxtAUSearch
        '
        Me.tstxtAUSearch.BackColor = System.Drawing.Color.White
        Me.tstxtAUSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtAUSearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstxtAUSearch.Name = "tstxtAUSearch"
        Me.tstxtAUSearch.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel1.Text = "Help"
        Me.ToolStripLabel1.ToolTipText = "Help"
        '
        'tsbtnAUAdd
        '
        Me.tsbtnAUAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnAUAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAUAdd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnAUAdd.ForeColor = System.Drawing.Color.White
        Me.tsbtnAUAdd.Image = CType(resources.GetObject("tsbtnAUAdd.Image"), System.Drawing.Image)
        Me.tsbtnAUAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAUAdd.Name = "tsbtnAUAdd"
        Me.tsbtnAUAdd.Size = New System.Drawing.Size(33, 22)
        Me.tsbtnAUAdd.Text = "Add"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(20, 19)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Search"
        '
        'tcAccountUser
        '
        Me.tcAccountUser.Controls.Add(Me.TabPage1)
        Me.tcAccountUser.Controls.Add(Me.TabPage2)
        Me.tcAccountUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcAccountUser.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcAccountUser.ImageList = Me.ilAccountUser
        Me.tcAccountUser.Location = New System.Drawing.Point(0, 30)
        Me.tcAccountUser.Name = "tcAccountUser"
        Me.tcAccountUser.SelectedIndex = 0
        Me.tcAccountUser.Size = New System.Drawing.Size(607, 664)
        Me.tcAccountUser.TabIndex = 4
        '
        'ilAccountUser
        '
        Me.ilAccountUser.ImageStream = CType(resources.GetObject("ilAccountUser.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilAccountUser.TransparentColor = System.Drawing.Color.Transparent
        Me.ilAccountUser.Images.SetKeyName(0, "manager.fw.png")
        Me.ilAccountUser.Images.SetKeyName(1, "group (3).fw.png")
        Me.ilAccountUser.Images.SetKeyName(2, "1.fw.png")
        Me.ilAccountUser.Images.SetKeyName(3, "2.fw.png")
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 30)
        Me.Panel1.TabIndex = 5
        '
        'ucAccountUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.tcAccountUser)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "ucAccountUser"
        Me.Size = New System.Drawing.Size(607, 694)
        Me.cmslvAccountUser.ResumeLayout(False)
        Me.cmslvAccountGroup.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.tcAccountUser.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tAccounUser As Timer
    Friend WithEvents cmslvAccountUser As ContextMenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ttAccountUser As ToolTip
    Friend WithEvents cmslvAccountGroup As ContextMenuStrip
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lvAccountGroup As ListView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tcAccountUser As TabControl
    Friend WithEvents btnCUSave As ucButton
    Friend WithEvents btnCUCancel As ucButton
    Friend WithEvents btnCNPOk As ucButton
    Friend WithEvents UcButton1 As ucButton
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnCGCancel As ucButton
    Friend WithEvents btnCGCreate As ucButton
    Friend WithEvents lvAccountUser As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ilAccountUser As ImageList
    Friend WithEvents ActivateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCUClearPhoto As ucButton
    Friend WithEvents btnCUUploadPhoto As ucButton
    Friend WithEvents btnCUTakePhoto As ucButton
    Friend WithEvents btnCancel As ucButton
    Friend WithEvents btnAccept As ucButton
    Friend WithEvents btnCapture As ucButton
    Friend WithEvents btnNew As ucButton
    Friend WithEvents ofdAccountUser As OpenFileDialog
    Friend WithEvents RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslAUCount As ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents tsslAGCount As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tstxtAGSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tsbtnAGAdd As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tstxtAUSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tsbtnAUAdd As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents tsslAUActiveCount As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents tsslAUInactiveCount As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents tsslAGActiveGroup As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents tsslAGInactiveGroup As ToolStripStatusLabel
End Class
