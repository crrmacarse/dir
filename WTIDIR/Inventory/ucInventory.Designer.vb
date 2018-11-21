<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucInventory
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucInventory))
        Me.ilInventory = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDocumentName = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtSheetNumber = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblSheetNumber = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.tsInventory = New System.Windows.Forms.ToolStrip()
        Me.tsbtnLock = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnClose = New System.Windows.Forms.ToolStripButton()
        Me.tcInventory = New System.Windows.Forms.TabControl()
        Me.tpInventorySheet = New System.Windows.Forms.TabPage()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.colRawMaterials = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStartTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStartWhole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStartFraction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTransfer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReturn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndWhole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndFraction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProcessOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpDelivery = New System.Windows.Forms.TabPage()
        Me.scDelivery = New System.Windows.Forms.SplitContainer()
        Me.lvDeliveryControl = New System.Windows.Forms.ListView()
        Me.colDeliveryDocNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDeliveryDocDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tsDelivery = New System.Windows.Forms.ToolStrip()
        Me.tsbtnDeliveryMap = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDeliveryPin = New System.Windows.Forms.ToolStripButton()
        Me.lvDeliveryData = New System.Windows.Forms.ListView()
        Me.colDeliveryItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDeliveryQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDeliveryUnit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tpTransfer = New System.Windows.Forms.TabPage()
        Me.scTransfer = New System.Windows.Forms.SplitContainer()
        Me.lvTransferControl = New System.Windows.Forms.ListView()
        Me.colTransferDocNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTransferDocDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tsTransfer = New System.Windows.Forms.ToolStrip()
        Me.tsbtnTransferMap = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnTransferPin = New System.Windows.Forms.ToolStripButton()
        Me.lvTransferData = New System.Windows.Forms.ListView()
        Me.colTransferItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTransferQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTransferUnit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tpReturn = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tpPettyCash = New System.Windows.Forms.TabPage()
        Me.Panel1.SuspendLayout()
        Me.tsInventory.SuspendLayout()
        Me.tcInventory.SuspendLayout()
        Me.tpInventorySheet.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDelivery.SuspendLayout()
        CType(Me.scDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDelivery.Panel1.SuspendLayout()
        Me.scDelivery.Panel2.SuspendLayout()
        Me.scDelivery.SuspendLayout()
        Me.tsDelivery.SuspendLayout()
        Me.tpTransfer.SuspendLayout()
        CType(Me.scTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scTransfer.Panel1.SuspendLayout()
        Me.scTransfer.Panel2.SuspendLayout()
        Me.scTransfer.SuspendLayout()
        Me.tsTransfer.SuspendLayout()
        Me.tpReturn.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ilInventory
        '
        Me.ilInventory.ImageStream = CType(resources.GetObject("ilInventory.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilInventory.TransparentColor = System.Drawing.Color.Transparent
        Me.ilInventory.Images.SetKeyName(0, "inventory")
        Me.ilInventory.Images.SetKeyName(1, "delivery")
        Me.ilInventory.Images.SetKeyName(2, "transfer")
        Me.ilInventory.Images.SetKeyName(3, "return")
        Me.ilInventory.Images.SetKeyName(4, "pettycash")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblDocumentName)
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.txtSheetNumber)
        Me.Panel1.Controls.Add(Me.dtpDate)
        Me.Panel1.Controls.Add(Me.txtBranch)
        Me.Panel1.Controls.Add(Me.lblRemarks)
        Me.Panel1.Controls.Add(Me.lblSheetNumber)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblBranch)
        Me.Panel1.Controls.Add(Me.tsInventory)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1175, 120)
        Me.Panel1.TabIndex = 0
        '
        'lblDocumentName
        '
        Me.lblDocumentName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDocumentName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDocumentName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDocumentName.Location = New System.Drawing.Point(246, 0)
        Me.lblDocumentName.Name = "lblDocumentName"
        Me.lblDocumentName.Size = New System.Drawing.Size(667, 30)
        Me.lblDocumentName.TabIndex = 4
        Me.lblDocumentName.Text = "TAGBAK - 000028 [April 30, 2017 - 14047]"
        Me.lblDocumentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Location = New System.Drawing.Point(410, 35)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(286, 44)
        Me.txtRemarks.TabIndex = 13
        '
        'txtSheetNumber
        '
        Me.txtSheetNumber.Location = New System.Drawing.Point(109, 89)
        Me.txtSheetNumber.Name = "txtSheetNumber"
        Me.txtSheetNumber.Size = New System.Drawing.Size(195, 21)
        Me.txtSheetNumber.TabIndex = 12
        '
        'dtpDate
        '
        Me.dtpDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtpDate.CustomFormat = "yyyy-MMMM-dd"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(109, 62)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(195, 21)
        Me.dtpDate.TabIndex = 11
        '
        'txtBranch
        '
        Me.txtBranch.Location = New System.Drawing.Point(109, 35)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(195, 21)
        Me.txtBranch.TabIndex = 10
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.ForeColor = System.Drawing.Color.White
        Me.lblRemarks.Location = New System.Drawing.Point(314, 35)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(71, 16)
        Me.lblRemarks.TabIndex = 3
        Me.lblRemarks.Text = "Remarks"
        '
        'lblSheetNumber
        '
        Me.lblSheetNumber.AutoSize = True
        Me.lblSheetNumber.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSheetNumber.ForeColor = System.Drawing.Color.White
        Me.lblSheetNumber.Location = New System.Drawing.Point(4, 90)
        Me.lblSheetNumber.Name = "lblSheetNumber"
        Me.lblSheetNumber.Size = New System.Drawing.Size(78, 16)
        Me.lblSheetNumber.TabIndex = 2
        Me.lblSheetNumber.Text = "Sheet No."
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(4, 63)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 16)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBranch.ForeColor = System.Drawing.Color.White
        Me.lblBranch.Location = New System.Drawing.Point(4, 36)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(59, 16)
        Me.lblBranch.TabIndex = 0
        Me.lblBranch.Text = "Branch"
        '
        'tsInventory
        '
        Me.tsInventory.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsInventory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsInventory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnLock, Me.tsbtnSave, Me.tsbtnClose})
        Me.tsInventory.Location = New System.Drawing.Point(0, 0)
        Me.tsInventory.Name = "tsInventory"
        Me.tsInventory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsInventory.Size = New System.Drawing.Size(1175, 31)
        Me.tsInventory.TabIndex = 16
        Me.tsInventory.Text = "ToolStrip1"
        '
        'tsbtnLock
        '
        Me.tsbtnLock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnLock.Image = CType(resources.GetObject("tsbtnLock.Image"), System.Drawing.Image)
        Me.tsbtnLock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnLock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnLock.Name = "tsbtnLock"
        Me.tsbtnLock.Size = New System.Drawing.Size(28, 28)
        Me.tsbtnLock.Text = "Lock"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"), System.Drawing.Image)
        Me.tsbtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(28, 28)
        Me.tsbtnSave.Text = "Save"
        '
        'tsbtnClose
        '
        Me.tsbtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnClose.Image = CType(resources.GetObject("tsbtnClose.Image"), System.Drawing.Image)
        Me.tsbtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnClose.Name = "tsbtnClose"
        Me.tsbtnClose.Size = New System.Drawing.Size(23, 28)
        Me.tsbtnClose.Text = "Close"
        '
        'tcInventory
        '
        Me.tcInventory.Controls.Add(Me.tpInventorySheet)
        Me.tcInventory.Controls.Add(Me.tpDelivery)
        Me.tcInventory.Controls.Add(Me.tpTransfer)
        Me.tcInventory.Controls.Add(Me.tpReturn)
        Me.tcInventory.Controls.Add(Me.tpPettyCash)
        Me.tcInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcInventory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcInventory.ImageList = Me.ilInventory
        Me.tcInventory.Location = New System.Drawing.Point(0, 120)
        Me.tcInventory.Name = "tcInventory"
        Me.tcInventory.SelectedIndex = 0
        Me.tcInventory.Size = New System.Drawing.Size(1175, 625)
        Me.tcInventory.TabIndex = 4
        '
        'tpInventorySheet
        '
        Me.tpInventorySheet.BackColor = System.Drawing.Color.White
        Me.tpInventorySheet.Controls.Add(Me.dgvInventory)
        Me.tpInventorySheet.ImageIndex = 0
        Me.tpInventorySheet.Location = New System.Drawing.Point(4, 31)
        Me.tpInventorySheet.Name = "tpInventorySheet"
        Me.tpInventorySheet.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInventorySheet.Size = New System.Drawing.Size(1167, 590)
        Me.tpInventorySheet.TabIndex = 0
        Me.tpInventorySheet.Text = "Inventory Sheet"
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AllowUserToResizeRows = False
        Me.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRawMaterials, Me.colStartTotal, Me.colStartWhole, Me.colStartFraction, Me.colDelivery, Me.colTransfer, Me.colReturn, Me.colEndTotal, Me.colEndWhole, Me.colEndFraction, Me.ColProcessOut})
        Me.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInventory.Location = New System.Drawing.Point(3, 3)
        Me.dgvInventory.MultiSelect = False
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInventory.Size = New System.Drawing.Size(1161, 584)
        Me.dgvInventory.TabIndex = 0
        '
        'colRawMaterials
        '
        Me.colRawMaterials.HeaderText = "RAW MATERIALS"
        Me.colRawMaterials.Name = "colRawMaterials"
        '
        'colStartTotal
        '
        Me.colStartTotal.HeaderText = "START"
        Me.colStartTotal.Name = "colStartTotal"
        Me.colStartTotal.ReadOnly = True
        '
        'colStartWhole
        '
        Me.colStartWhole.HeaderText = "START (W)"
        Me.colStartWhole.Name = "colStartWhole"
        Me.colStartWhole.ReadOnly = True
        '
        'colStartFraction
        '
        Me.colStartFraction.HeaderText = "START (F)"
        Me.colStartFraction.Name = "colStartFraction"
        Me.colStartFraction.ReadOnly = True
        '
        'colDelivery
        '
        Me.colDelivery.HeaderText = "DELIVERY"
        Me.colDelivery.Name = "colDelivery"
        Me.colDelivery.ReadOnly = True
        '
        'colTransfer
        '
        Me.colTransfer.HeaderText = "TRANSFER"
        Me.colTransfer.Name = "colTransfer"
        Me.colTransfer.ReadOnly = True
        '
        'colReturn
        '
        Me.colReturn.HeaderText = "RETURN"
        Me.colReturn.Name = "colReturn"
        Me.colReturn.ReadOnly = True
        '
        'colEndTotal
        '
        Me.colEndTotal.HeaderText = "END"
        Me.colEndTotal.Name = "colEndTotal"
        Me.colEndTotal.ReadOnly = True
        '
        'colEndWhole
        '
        Me.colEndWhole.HeaderText = "END (W)"
        Me.colEndWhole.Name = "colEndWhole"
        '
        'colEndFraction
        '
        Me.colEndFraction.HeaderText = "END (F)"
        Me.colEndFraction.Name = "colEndFraction"
        '
        'ColProcessOut
        '
        Me.ColProcessOut.HeaderText = "PROCESS OUT"
        Me.ColProcessOut.Name = "ColProcessOut"
        Me.ColProcessOut.ReadOnly = True
        '
        'tpDelivery
        '
        Me.tpDelivery.BackColor = System.Drawing.Color.White
        Me.tpDelivery.Controls.Add(Me.scDelivery)
        Me.tpDelivery.ImageIndex = 1
        Me.tpDelivery.Location = New System.Drawing.Point(4, 31)
        Me.tpDelivery.Name = "tpDelivery"
        Me.tpDelivery.Size = New System.Drawing.Size(1167, 590)
        Me.tpDelivery.TabIndex = 1
        Me.tpDelivery.Text = "Delivery"
        '
        'scDelivery
        '
        Me.scDelivery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scDelivery.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scDelivery.IsSplitterFixed = True
        Me.scDelivery.Location = New System.Drawing.Point(0, 0)
        Me.scDelivery.Name = "scDelivery"
        '
        'scDelivery.Panel1
        '
        Me.scDelivery.Panel1.Controls.Add(Me.lvDeliveryControl)
        Me.scDelivery.Panel1.Controls.Add(Me.tsDelivery)
        '
        'scDelivery.Panel2
        '
        Me.scDelivery.Panel2.Controls.Add(Me.lvDeliveryData)
        Me.scDelivery.Size = New System.Drawing.Size(1167, 590)
        Me.scDelivery.SplitterDistance = 300
        Me.scDelivery.TabIndex = 2
        '
        'lvDeliveryControl
        '
        Me.lvDeliveryControl.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDeliveryDocNo, Me.colDeliveryDocDate})
        Me.lvDeliveryControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDeliveryControl.GridLines = True
        Me.lvDeliveryControl.Location = New System.Drawing.Point(0, 31)
        Me.lvDeliveryControl.Name = "lvDeliveryControl"
        Me.lvDeliveryControl.Size = New System.Drawing.Size(300, 559)
        Me.lvDeliveryControl.TabIndex = 18
        Me.lvDeliveryControl.UseCompatibleStateImageBehavior = False
        Me.lvDeliveryControl.View = System.Windows.Forms.View.Details
        '
        'colDeliveryDocNo
        '
        Me.colDeliveryDocNo.Text = "Doc No."
        Me.colDeliveryDocNo.Width = 100
        '
        'colDeliveryDocDate
        '
        Me.colDeliveryDocDate.Text = "Doc Date"
        Me.colDeliveryDocDate.Width = 180
        '
        'tsDelivery
        '
        Me.tsDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsDelivery.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsDelivery.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnDeliveryMap, Me.tsbtnDeliveryPin})
        Me.tsDelivery.Location = New System.Drawing.Point(0, 0)
        Me.tsDelivery.Name = "tsDelivery"
        Me.tsDelivery.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsDelivery.Size = New System.Drawing.Size(300, 31)
        Me.tsDelivery.TabIndex = 17
        Me.tsDelivery.Text = "ToolStrip2"
        '
        'tsbtnDeliveryMap
        '
        Me.tsbtnDeliveryMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnDeliveryMap.Image = CType(resources.GetObject("tsbtnDeliveryMap.Image"), System.Drawing.Image)
        Me.tsbtnDeliveryMap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnDeliveryMap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDeliveryMap.Name = "tsbtnDeliveryMap"
        Me.tsbtnDeliveryMap.Size = New System.Drawing.Size(28, 28)
        Me.tsbtnDeliveryMap.Text = "Map"
        '
        'tsbtnDeliveryPin
        '
        Me.tsbtnDeliveryPin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnDeliveryPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnDeliveryPin.Image = CType(resources.GetObject("tsbtnDeliveryPin.Image"), System.Drawing.Image)
        Me.tsbtnDeliveryPin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnDeliveryPin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDeliveryPin.Name = "tsbtnDeliveryPin"
        Me.tsbtnDeliveryPin.Size = New System.Drawing.Size(28, 28)
        Me.tsbtnDeliveryPin.Text = "Close"
        '
        'lvDeliveryData
        '
        Me.lvDeliveryData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDeliveryItem, Me.colDeliveryQuantity, Me.colDeliveryUnit})
        Me.lvDeliveryData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDeliveryData.GridLines = True
        Me.lvDeliveryData.Location = New System.Drawing.Point(0, 0)
        Me.lvDeliveryData.Name = "lvDeliveryData"
        Me.lvDeliveryData.Size = New System.Drawing.Size(863, 590)
        Me.lvDeliveryData.TabIndex = 19
        Me.lvDeliveryData.UseCompatibleStateImageBehavior = False
        Me.lvDeliveryData.View = System.Windows.Forms.View.Details
        '
        'colDeliveryItem
        '
        Me.colDeliveryItem.Text = "Item"
        Me.colDeliveryItem.Width = 300
        '
        'colDeliveryQuantity
        '
        Me.colDeliveryQuantity.Text = "Quantity"
        Me.colDeliveryQuantity.Width = 100
        '
        'colDeliveryUnit
        '
        Me.colDeliveryUnit.Text = "Unit"
        Me.colDeliveryUnit.Width = 100
        '
        'tpTransfer
        '
        Me.tpTransfer.BackColor = System.Drawing.Color.White
        Me.tpTransfer.Controls.Add(Me.scTransfer)
        Me.tpTransfer.ImageIndex = 2
        Me.tpTransfer.Location = New System.Drawing.Point(4, 31)
        Me.tpTransfer.Name = "tpTransfer"
        Me.tpTransfer.Size = New System.Drawing.Size(1167, 590)
        Me.tpTransfer.TabIndex = 2
        Me.tpTransfer.Text = "Transfer"
        '
        'scTransfer
        '
        Me.scTransfer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scTransfer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scTransfer.IsSplitterFixed = True
        Me.scTransfer.Location = New System.Drawing.Point(0, 0)
        Me.scTransfer.Name = "scTransfer"
        '
        'scTransfer.Panel1
        '
        Me.scTransfer.Panel1.Controls.Add(Me.lvTransferControl)
        Me.scTransfer.Panel1.Controls.Add(Me.tsTransfer)
        '
        'scTransfer.Panel2
        '
        Me.scTransfer.Panel2.Controls.Add(Me.lvTransferData)
        Me.scTransfer.Size = New System.Drawing.Size(1167, 590)
        Me.scTransfer.SplitterDistance = 300
        Me.scTransfer.TabIndex = 2
        '
        'lvTransferControl
        '
        Me.lvTransferControl.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTransferDocNo, Me.colTransferDocDate})
        Me.lvTransferControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTransferControl.GridLines = True
        Me.lvTransferControl.Location = New System.Drawing.Point(0, 31)
        Me.lvTransferControl.Name = "lvTransferControl"
        Me.lvTransferControl.Size = New System.Drawing.Size(300, 559)
        Me.lvTransferControl.TabIndex = 18
        Me.lvTransferControl.UseCompatibleStateImageBehavior = False
        Me.lvTransferControl.View = System.Windows.Forms.View.Details
        '
        'colTransferDocNo
        '
        Me.colTransferDocNo.Text = "Doc No."
        Me.colTransferDocNo.Width = 100
        '
        'colTransferDocDate
        '
        Me.colTransferDocDate.Text = "Doc Date"
        Me.colTransferDocDate.Width = 180
        '
        'tsTransfer
        '
        Me.tsTransfer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsTransfer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsTransfer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnTransferMap, Me.tsbtnTransferPin})
        Me.tsTransfer.Location = New System.Drawing.Point(0, 0)
        Me.tsTransfer.Name = "tsTransfer"
        Me.tsTransfer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsTransfer.Size = New System.Drawing.Size(300, 31)
        Me.tsTransfer.TabIndex = 17
        Me.tsTransfer.Text = "ToolStrip2"
        '
        'tsbtnTransferMap
        '
        Me.tsbtnTransferMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnTransferMap.Image = CType(resources.GetObject("tsbtnTransferMap.Image"), System.Drawing.Image)
        Me.tsbtnTransferMap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnTransferMap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnTransferMap.Name = "tsbtnTransferMap"
        Me.tsbtnTransferMap.Size = New System.Drawing.Size(28, 28)
        Me.tsbtnTransferMap.Text = "Map"
        '
        'tsbtnTransferPin
        '
        Me.tsbtnTransferPin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnTransferPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnTransferPin.Image = CType(resources.GetObject("tsbtnTransferPin.Image"), System.Drawing.Image)
        Me.tsbtnTransferPin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnTransferPin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnTransferPin.Name = "tsbtnTransferPin"
        Me.tsbtnTransferPin.Size = New System.Drawing.Size(28, 28)
        Me.tsbtnTransferPin.Text = "Close"
        '
        'lvTransferData
        '
        Me.lvTransferData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTransferItem, Me.colTransferQuantity, Me.colTransferUnit})
        Me.lvTransferData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTransferData.GridLines = True
        Me.lvTransferData.Location = New System.Drawing.Point(0, 0)
        Me.lvTransferData.Name = "lvTransferData"
        Me.lvTransferData.Size = New System.Drawing.Size(863, 590)
        Me.lvTransferData.TabIndex = 19
        Me.lvTransferData.UseCompatibleStateImageBehavior = False
        Me.lvTransferData.View = System.Windows.Forms.View.Details
        '
        'colTransferItem
        '
        Me.colTransferItem.Text = "Item"
        Me.colTransferItem.Width = 300
        '
        'colTransferQuantity
        '
        Me.colTransferQuantity.Text = "Quantity"
        Me.colTransferQuantity.Width = 100
        '
        'colTransferUnit
        '
        Me.colTransferUnit.Text = "Unit"
        Me.colTransferUnit.Width = 100
        '
        'tpReturn
        '
        Me.tpReturn.BackColor = System.Drawing.Color.White
        Me.tpReturn.Controls.Add(Me.SplitContainer2)
        Me.tpReturn.ImageIndex = 3
        Me.tpReturn.Location = New System.Drawing.Point(4, 31)
        Me.tpReturn.Name = "tpReturn"
        Me.tpReturn.Size = New System.Drawing.Size(1167, 590)
        Me.tpReturn.TabIndex = 3
        Me.tpReturn.Text = "Return"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListView3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ListView4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1167, 590)
        Me.SplitContainer2.SplitterDistance = 300
        Me.SplitContainer2.TabIndex = 1
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(0, 31)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(300, 559)
        Me.ListView3.TabIndex = 18
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Doc No."
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Doc Date"
        Me.ColumnHeader7.Width = 180
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(300, 31)
        Me.ToolStrip3.TabIndex = 17
        Me.ToolStrip3.Text = "ToolStrip2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton3.Text = "Map"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton4.Text = "Close"
        '
        'ListView4
        '
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView4.GridLines = True
        Me.ListView4.Location = New System.Drawing.Point(0, 0)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(863, 590)
        Me.ListView4.TabIndex = 19
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Item"
        Me.ColumnHeader8.Width = 300
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Quantity"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Unit"
        Me.ColumnHeader10.Width = 100
        '
        'tpPettyCash
        '
        Me.tpPettyCash.BackColor = System.Drawing.Color.White
        Me.tpPettyCash.ImageIndex = 4
        Me.tpPettyCash.Location = New System.Drawing.Point(4, 31)
        Me.tpPettyCash.Name = "tpPettyCash"
        Me.tpPettyCash.Size = New System.Drawing.Size(1167, 590)
        Me.tpPettyCash.TabIndex = 4
        Me.tpPettyCash.Text = "Petty Cash"
        '
        'ucInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.tcInventory)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucInventory"
        Me.Size = New System.Drawing.Size(1175, 745)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tsInventory.ResumeLayout(False)
        Me.tsInventory.PerformLayout()
        Me.tcInventory.ResumeLayout(False)
        Me.tpInventorySheet.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDelivery.ResumeLayout(False)
        Me.scDelivery.Panel1.ResumeLayout(False)
        Me.scDelivery.Panel1.PerformLayout()
        Me.scDelivery.Panel2.ResumeLayout(False)
        CType(Me.scDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scDelivery.ResumeLayout(False)
        Me.tsDelivery.ResumeLayout(False)
        Me.tsDelivery.PerformLayout()
        Me.tpTransfer.ResumeLayout(False)
        Me.scTransfer.Panel1.ResumeLayout(False)
        Me.scTransfer.Panel1.PerformLayout()
        Me.scTransfer.Panel2.ResumeLayout(False)
        CType(Me.scTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scTransfer.ResumeLayout(False)
        Me.tsTransfer.ResumeLayout(False)
        Me.tsTransfer.PerformLayout()
        Me.tpReturn.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ilInventory As ImageList
    Friend WithEvents tcInventory As TabControl
    Friend WithEvents tpInventorySheet As TabPage
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents colRawMaterials As DataGridViewTextBoxColumn
    Friend WithEvents colStartTotal As DataGridViewTextBoxColumn
    Friend WithEvents colStartWhole As DataGridViewTextBoxColumn
    Friend WithEvents colStartFraction As DataGridViewTextBoxColumn
    Friend WithEvents colDelivery As DataGridViewTextBoxColumn
    Friend WithEvents colTransfer As DataGridViewTextBoxColumn
    Friend WithEvents colReturn As DataGridViewTextBoxColumn
    Friend WithEvents colEndTotal As DataGridViewTextBoxColumn
    Friend WithEvents colEndWhole As DataGridViewTextBoxColumn
    Friend WithEvents colEndFraction As DataGridViewTextBoxColumn
    Friend WithEvents ColProcessOut As DataGridViewTextBoxColumn
    Friend WithEvents tpDelivery As TabPage
    Friend WithEvents tpTransfer As TabPage
    Friend WithEvents tpReturn As TabPage
    Friend WithEvents tpPettyCash As TabPage
    Friend WithEvents lblDate As Label
    Friend WithEvents lblBranch As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents lblSheetNumber As Label
    Friend WithEvents lblDocumentName As Label
    Friend WithEvents txtSheetNumber As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtBranch As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents tsInventory As ToolStrip
    Friend WithEvents tsbtnLock As ToolStripButton
    Friend WithEvents tsbtnSave As ToolStripButton
    Friend WithEvents tsbtnClose As ToolStripButton
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents scDelivery As SplitContainer
    Friend WithEvents lvDeliveryControl As ListView
    Friend WithEvents colDeliveryDocNo As ColumnHeader
    Friend WithEvents colDeliveryDocDate As ColumnHeader
    Friend WithEvents tsDelivery As ToolStrip
    Friend WithEvents tsbtnDeliveryMap As ToolStripButton
    Friend WithEvents tsbtnDeliveryPin As ToolStripButton
    Friend WithEvents lvDeliveryData As ListView
    Friend WithEvents colDeliveryItem As ColumnHeader
    Friend WithEvents colDeliveryQuantity As ColumnHeader
    Friend WithEvents colDeliveryUnit As ColumnHeader
    Friend WithEvents scTransfer As SplitContainer
    Friend WithEvents lvTransferControl As ListView
    Friend WithEvents colTransferDocNo As ColumnHeader
    Friend WithEvents colTransferDocDate As ColumnHeader
    Friend WithEvents tsTransfer As ToolStrip
    Friend WithEvents tsbtnTransferMap As ToolStripButton
    Friend WithEvents tsbtnTransferPin As ToolStripButton
    Friend WithEvents lvTransferData As ListView
    Friend WithEvents colTransferItem As ColumnHeader
    Friend WithEvents colTransferQuantity As ColumnHeader
    Friend WithEvents colTransferUnit As ColumnHeader
End Class
