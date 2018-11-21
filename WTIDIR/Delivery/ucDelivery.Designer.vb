<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDelivery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDelivery))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblSheetNumber = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.tsDelivery = New System.Windows.Forms.ToolStrip()
        Me.tsbtnLock = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnClose = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tsbtnImport = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.tsDelivery.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblRemarks)
        Me.Panel1.Controls.Add(Me.lblSheetNumber)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblBranch)
        Me.Panel1.Controls.Add(Me.tsDelivery)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 120)
        Me.Panel1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(410, 41)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(286, 44)
        Me.TextBox3.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 95)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(195, 20)
        Me.TextBox2.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.White
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DateTimePicker1.CustomFormat = "yyyy-MMMM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(109, 68)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(195, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 21
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.ForeColor = System.Drawing.Color.White
        Me.lblRemarks.Location = New System.Drawing.Point(314, 41)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(71, 16)
        Me.lblRemarks.TabIndex = 20
        Me.lblRemarks.Text = "Remarks"
        '
        'lblSheetNumber
        '
        Me.lblSheetNumber.AutoSize = True
        Me.lblSheetNumber.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSheetNumber.ForeColor = System.Drawing.Color.White
        Me.lblSheetNumber.Location = New System.Drawing.Point(4, 96)
        Me.lblSheetNumber.Name = "lblSheetNumber"
        Me.lblSheetNumber.Size = New System.Drawing.Size(78, 16)
        Me.lblSheetNumber.TabIndex = 19
        Me.lblSheetNumber.Text = "Sheet No."
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(4, 69)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 16)
        Me.lblDate.TabIndex = 18
        Me.lblDate.Text = "Date"
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBranch.ForeColor = System.Drawing.Color.White
        Me.lblBranch.Location = New System.Drawing.Point(4, 42)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(59, 16)
        Me.lblBranch.TabIndex = 17
        Me.lblBranch.Text = "Branch"
        '
        'tsDelivery
        '
        Me.tsDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsDelivery.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsDelivery.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnLock, Me.tsbtnSave, Me.tsbtnClose, Me.tsbtnImport})
        Me.tsDelivery.Location = New System.Drawing.Point(0, 0)
        Me.tsDelivery.Name = "tsDelivery"
        Me.tsDelivery.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsDelivery.Size = New System.Drawing.Size(795, 31)
        Me.tsDelivery.TabIndex = 25
        Me.tsDelivery.Text = "ToolStrip1"
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(795, 350)
        Me.DataGridView1.TabIndex = 1
        '
        'tsbtnImport
        '
        Me.tsbtnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnImport.Image = CType(resources.GetObject("tsbtnImport.Image"), System.Drawing.Image)
        Me.tsbtnImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnImport.Name = "tsbtnImport"
        Me.tsbtnImport.Size = New System.Drawing.Size(28, 28)
        Me.tsbtnImport.ToolTipText = "Import From SAP"
        '
        'ucDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucDelivery"
        Me.Size = New System.Drawing.Size(795, 470)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tsDelivery.ResumeLayout(False)
        Me.tsDelivery.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents lblSheetNumber As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblBranch As Label
    Friend WithEvents tsDelivery As ToolStrip
    Friend WithEvents tsbtnLock As ToolStripButton
    Friend WithEvents tsbtnSave As ToolStripButton
    Friend WithEvents tsbtnClose As ToolStripButton
    Friend WithEvents tsbtnImport As ToolStripButton
End Class
