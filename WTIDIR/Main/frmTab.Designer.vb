<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTab))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlTab = New System.Windows.Forms.Panel()
        Me.pnlManage = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblApplicationVersion = New System.Windows.Forms.Label()
        Me.ilIcon = New System.Windows.Forms.ImageList(Me.components)
        Me.UcIcon4 = New WTIDIR.ucIcon()
        Me.UcIcon3 = New WTIDIR.ucIcon()
        Me.UcIcon2 = New WTIDIR.ucIcon()
        Me.UcIcon1 = New WTIDIR.ucIcon()
        Me.ucMenuSearch = New WTIDIR.ucSearch()
        Me.pnlTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(310, 537)
        Me.Panel3.TabIndex = 22
        '
        'pnlTab
        '
        Me.pnlTab.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlTab.Controls.Add(Me.UcIcon4)
        Me.pnlTab.Controls.Add(Me.UcIcon3)
        Me.pnlTab.Controls.Add(Me.UcIcon2)
        Me.pnlTab.Controls.Add(Me.UcIcon1)
        Me.pnlTab.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTab.Location = New System.Drawing.Point(0, 49)
        Me.pnlTab.Name = "pnlTab"
        Me.pnlTab.Size = New System.Drawing.Size(46, 537)
        Me.pnlTab.TabIndex = 37
        '
        'pnlManage
        '
        Me.pnlManage.AutoScroll = True
        Me.pnlManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.pnlManage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlManage.Location = New System.Drawing.Point(46, 49)
        Me.pnlManage.Name = "pnlManage"
        Me.pnlManage.Size = New System.Drawing.Size(264, 537)
        Me.pnlManage.TabIndex = 38
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblApplicationVersion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(46, 556)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 30)
        Me.Panel1.TabIndex = 39
        '
        'lblApplicationVersion
        '
        Me.lblApplicationVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApplicationVersion.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationVersion.Location = New System.Drawing.Point(6, 9)
        Me.lblApplicationVersion.Name = "lblApplicationVersion"
        Me.lblApplicationVersion.Size = New System.Drawing.Size(246, 12)
        Me.lblApplicationVersion.TabIndex = 33
        Me.lblApplicationVersion.Text = "Application Version"
        Me.lblApplicationVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ilIcon
        '
        Me.ilIcon.ImageStream = CType(resources.GetObject("ilIcon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilIcon.TransparentColor = System.Drawing.Color.Transparent
        Me.ilIcon.Images.SetKeyName(0, "test01")
        Me.ilIcon.Images.SetKeyName(1, "test02")
        Me.ilIcon.Images.SetKeyName(2, "test03")
        Me.ilIcon.Images.SetKeyName(3, "test04")
        Me.ilIcon.Images.SetKeyName(4, "test05")
        Me.ilIcon.Images.SetKeyName(5, "test06")
        Me.ilIcon.Images.SetKeyName(6, "test07")
        Me.ilIcon.Images.SetKeyName(7, "test08")
        '
        'UcIcon4
        '
        Me.UcIcon4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UcIcon4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcIcon4.Description = Nothing
        Me.UcIcon4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcIcon4.Icon = CType(resources.GetObject("UcIcon4.Icon"), System.Drawing.Image)
        Me.UcIcon4.Location = New System.Drawing.Point(0, 108)
        Me.UcIcon4.Name = "UcIcon4"
        Me.UcIcon4.Size = New System.Drawing.Size(46, 36)
        Me.UcIcon4.TabIndex = 3
        Me.UcIcon4.Title = Nothing
        '
        'UcIcon3
        '
        Me.UcIcon3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UcIcon3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcIcon3.Description = Nothing
        Me.UcIcon3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcIcon3.Icon = CType(resources.GetObject("UcIcon3.Icon"), System.Drawing.Image)
        Me.UcIcon3.Location = New System.Drawing.Point(0, 72)
        Me.UcIcon3.Name = "UcIcon3"
        Me.UcIcon3.Size = New System.Drawing.Size(46, 36)
        Me.UcIcon3.TabIndex = 2
        Me.UcIcon3.Title = "account"
        '
        'UcIcon2
        '
        Me.UcIcon2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UcIcon2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcIcon2.Description = Nothing
        Me.UcIcon2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcIcon2.Icon = CType(resources.GetObject("UcIcon2.Icon"), System.Drawing.Image)
        Me.UcIcon2.Location = New System.Drawing.Point(0, 36)
        Me.UcIcon2.Name = "UcIcon2"
        Me.UcIcon2.Size = New System.Drawing.Size(46, 36)
        Me.UcIcon2.TabIndex = 1
        Me.UcIcon2.Title = "account"
        '
        'UcIcon1
        '
        Me.UcIcon1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UcIcon1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcIcon1.Description = Nothing
        Me.UcIcon1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcIcon1.Icon = CType(resources.GetObject("UcIcon1.Icon"), System.Drawing.Image)
        Me.UcIcon1.Location = New System.Drawing.Point(0, 0)
        Me.UcIcon1.Name = "UcIcon1"
        Me.UcIcon1.Size = New System.Drawing.Size(46, 36)
        Me.UcIcon1.TabIndex = 0
        Me.UcIcon1.Title = "all"
        '
        'ucMenuSearch
        '
        Me.ucMenuSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ucMenuSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.ucMenuSearch.Location = New System.Drawing.Point(0, 0)
        Me.ucMenuSearch.Name = "ucMenuSearch"
        Me.ucMenuSearch.Size = New System.Drawing.Size(310, 49)
        Me.ucMenuSearch.TabIndex = 36
        Me.ucMenuSearch.TabStop = False
        '
        'frmTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(310, 586)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlManage)
        Me.Controls.Add(Me.pnlTab)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ucMenuSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmTab"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.pnlTab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ucMenuSearch As ucSearch
    Friend WithEvents pnlTab As Panel
    Friend WithEvents UcIcon4 As ucIcon
    Friend WithEvents UcIcon3 As ucIcon
    Friend WithEvents UcIcon2 As ucIcon
    Friend WithEvents UcIcon1 As ucIcon
    Friend WithEvents pnlManage As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblApplicationVersion As Label
    Friend WithEvents ilIcon As ImageList
End Class
