<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlMainTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.btnOptions = New System.Windows.Forms.Label()
        Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tslMainStatus = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiManageAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tpDashboard = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.UcButton4 = New WTIDIR.ucButton()
        Me.UcButton3 = New WTIDIR.ucButton()
        Me.UcButton2 = New WTIDIR.ucButton()
        Me.UcButton1 = New WTIDIR.ucButton()
        Me.btnNewInventory = New WTIDIR.ucButton()
        Me.btnNewDelivery = New WTIDIR.ucButton()
        Me.pnlMainTop.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.tcMain.SuspendLayout()
        Me.tpDashboard.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMainTop
        '
        Me.pnlMainTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlMainTop.Controls.Add(Me.Label1)
        Me.pnlMainTop.Controls.Add(Me.btnClose)
        Me.pnlMainTop.Controls.Add(Me.btnOptions)
        Me.pnlMainTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMainTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainTop.Name = "pnlMainTop"
        Me.pnlMainTop.Size = New System.Drawing.Size(1011, 30)
        Me.pnlMainTop.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Daily Inventory Report"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(975, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.TabIndex = 10
        '
        'btnOptions
        '
        Me.btnOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOptions.Image = CType(resources.GetObject("btnOptions.Image"), System.Drawing.Image)
        Me.btnOptions.Location = New System.Drawing.Point(943, 3)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(24, 24)
        Me.btnOptions.TabIndex = 9
        '
        'ilMain
        '
        Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
        Me.ilMain.Images.SetKeyName(0, "dashboard")
        Me.ilMain.Images.SetKeyName(1, "inventoryfolder")
        Me.ilMain.Images.SetKeyName(2, "delivery")
        '
        'tsMain
        '
        Me.tsMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslMainStatus, Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton1})
        Me.tsMain.Location = New System.Drawing.Point(0, 743)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1011, 25)
        Me.tsMain.TabIndex = 4
        Me.tsMain.Text = "ToolStrip1"
        '
        'tslMainStatus
        '
        Me.tslMainStatus.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.tslMainStatus.ForeColor = System.Drawing.Color.White
        Me.tslMainStatus.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.tslMainStatus.Name = "tslMainStatus"
        Me.tslMainStatus.Size = New System.Drawing.Size(43, 22)
        Me.tslMainStatus.Text = "Ready"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiManageAccount})
        Me.ToolStripDropDownButton2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripDropDownButton2.Text = "Account"
        '
        'tsmiManageAccount
        '
        Me.tsmiManageAccount.Name = "tsmiManageAccount"
        Me.tsmiManageAccount.Size = New System.Drawing.Size(177, 22)
        Me.tsmiManageAccount.Text = "Manage Account"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripDropDownButton1.Text = "Settings"
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tpDashboard)
        Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMain.ImageList = Me.ilMain
        Me.tcMain.Location = New System.Drawing.Point(0, 30)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.Padding = New System.Drawing.Point(0, 0)
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1011, 713)
        Me.tcMain.TabIndex = 0
        '
        'tpDashboard
        '
        Me.tpDashboard.Controls.Add(Me.Panel1)
        Me.tpDashboard.Controls.Add(Me.ToolStrip1)
        Me.tpDashboard.ImageKey = "dashboard"
        Me.tpDashboard.Location = New System.Drawing.Point(4, 31)
        Me.tpDashboard.Name = "tpDashboard"
        Me.tpDashboard.Size = New System.Drawing.Size(1003, 678)
        Me.tpDashboard.TabIndex = 0
        Me.tpDashboard.Text = "Dashboard"
        Me.tpDashboard.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 653)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel2.Controls.Add(Me.UcButton4)
        Me.Panel2.Controls.Add(Me.UcButton3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.UcButton2)
        Me.Panel2.Controls.Add(Me.UcButton1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnNewInventory)
        Me.Panel2.Controls.Add(Me.btnNewDelivery)
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 647)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(600, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Open a document"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 597)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1000, 50)
        Me.Panel5.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(905, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Last login at"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(927, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "10.1.1.9"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 120)
        Me.Panel4.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(390, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(600, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Create a new document"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Open a recent document"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Location = New System.Drawing.Point(65, 173)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(450, 375)
        Me.Panel3.TabIndex = 9
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1003, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'UcButton4
        '
        Me.UcButton4.BackColorHighlight = System.Drawing.Color.Empty
        Me.UcButton4.Caption = "New Return"
        Me.UcButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcButton4.Image = CType(resources.GetObject("UcButton4.Image"), System.Drawing.Image)
        Me.UcButton4.Location = New System.Drawing.Point(640, 442)
        Me.UcButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.UcButton4.Name = "UcButton4"
        Me.UcButton4.Size = New System.Drawing.Size(300, 35)
        Me.UcButton4.TabIndex = 18
        Me.UcButton4.UseThemeColor = False
        '
        'UcButton3
        '
        Me.UcButton3.BackColorHighlight = System.Drawing.Color.Empty
        Me.UcButton3.Caption = "New Transfer"
        Me.UcButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcButton3.Image = CType(resources.GetObject("UcButton3.Image"), System.Drawing.Image)
        Me.UcButton3.Location = New System.Drawing.Point(640, 392)
        Me.UcButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.UcButton3.Name = "UcButton3"
        Me.UcButton3.Size = New System.Drawing.Size(300, 35)
        Me.UcButton3.TabIndex = 17
        Me.UcButton3.UseThemeColor = False
        '
        'UcButton2
        '
        Me.UcButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButton2.BackColorHighlight = System.Drawing.Color.Empty
        Me.UcButton2.Caption = "Import Sales"
        Me.UcButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcButton2.Image = CType(resources.GetObject("UcButton2.Image"), System.Drawing.Image)
        Me.UcButton2.Location = New System.Drawing.Point(15, 555)
        Me.UcButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.UcButton2.Name = "UcButton2"
        Me.UcButton2.Size = New System.Drawing.Size(500, 35)
        Me.UcButton2.TabIndex = 13
        Me.UcButton2.UseThemeColor = False
        '
        'UcButton1
        '
        Me.UcButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButton1.BackColorHighlight = System.Drawing.Color.Empty
        Me.UcButton1.Caption = "Open a document..."
        Me.UcButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcButton1.Image = CType(resources.GetObject("UcButton1.Image"), System.Drawing.Image)
        Me.UcButton1.Location = New System.Drawing.Point(640, 173)
        Me.UcButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcButton1.Name = "UcButton1"
        Me.UcButton1.Size = New System.Drawing.Size(300, 35)
        Me.UcButton1.TabIndex = 12
        Me.UcButton1.UseThemeColor = False
        '
        'btnNewInventory
        '
        Me.btnNewInventory.BackColorHighlight = System.Drawing.Color.Empty
        Me.btnNewInventory.Caption = "New Inventory"
        Me.btnNewInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewInventory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewInventory.Image = CType(resources.GetObject("btnNewInventory.Image"), System.Drawing.Image)
        Me.btnNewInventory.Location = New System.Drawing.Point(640, 292)
        Me.btnNewInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewInventory.Name = "btnNewInventory"
        Me.btnNewInventory.Size = New System.Drawing.Size(300, 35)
        Me.btnNewInventory.TabIndex = 8
        Me.btnNewInventory.UseThemeColor = False
        '
        'btnNewDelivery
        '
        Me.btnNewDelivery.BackColorHighlight = System.Drawing.Color.Empty
        Me.btnNewDelivery.Caption = "New Delivery"
        Me.btnNewDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewDelivery.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewDelivery.Image = CType(resources.GetObject("btnNewDelivery.Image"), System.Drawing.Image)
        Me.btnNewDelivery.Location = New System.Drawing.Point(640, 342)
        Me.btnNewDelivery.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewDelivery.Name = "btnNewDelivery"
        Me.btnNewDelivery.Size = New System.Drawing.Size(300, 35)
        Me.btnNewDelivery.TabIndex = 7
        Me.btnNewDelivery.UseThemeColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1011, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.tcMain)
        Me.Controls.Add(Me.pnlMainTop)
        Me.Controls.Add(Me.tsMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMainTop.ResumeLayout(False)
        Me.pnlMainTop.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.tcMain.ResumeLayout(False)
        Me.tpDashboard.ResumeLayout(False)
        Me.tpDashboard.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMainTop As Panel
    Private WithEvents btnClose As Label
    Private WithEvents btnOptions As Label
    Friend WithEvents ilMain As ImageList
    Friend WithEvents tsMain As ToolStrip
    Friend WithEvents tslMainStatus As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpDashboard As TabPage
    Friend WithEvents tsmiManageAccount As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UcButton2 As ucButton
    Friend WithEvents UcButton1 As ucButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnNewInventory As ucButton
    Friend WithEvents btnNewDelivery As ucButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents UcButton4 As ucButton
    Friend WithEvents UcButton3 As ucButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
