<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMenu))
        Me.pbMenuImage = New System.Windows.Forms.PictureBox()
        Me.lblMenuTitle = New System.Windows.Forms.Label()
        Me.btnFavorite = New System.Windows.Forms.Button()
        CType(Me.pbMenuImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbMenuImage
        '
        Me.pbMenuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbMenuImage.Location = New System.Drawing.Point(9, 5)
        Me.pbMenuImage.Name = "pbMenuImage"
        Me.pbMenuImage.Size = New System.Drawing.Size(24, 24)
        Me.pbMenuImage.TabIndex = 1
        Me.pbMenuImage.TabStop = False
        '
        'lblMenuTitle
        '
        Me.lblMenuTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMenuTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMenuTitle.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblMenuTitle.Location = New System.Drawing.Point(46, -1)
        Me.lblMenuTitle.Name = "lblMenuTitle"
        Me.lblMenuTitle.Size = New System.Drawing.Size(210, 37)
        Me.lblMenuTitle.TabIndex = 29
        Me.lblMenuTitle.Text = "NOTIFICATIONS"
        Me.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFavorite
        '
        Me.btnFavorite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFavorite.FlatAppearance.BorderSize = 0
        Me.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFavorite.Image = CType(resources.GetObject("btnFavorite.Image"), System.Drawing.Image)
        Me.btnFavorite.Location = New System.Drawing.Point(269, 6)
        Me.btnFavorite.Name = "btnFavorite"
        Me.btnFavorite.Size = New System.Drawing.Size(28, 23)
        Me.btnFavorite.TabIndex = 30
        Me.btnFavorite.UseVisualStyleBackColor = True
        Me.btnFavorite.Visible = False
        '
        'ucMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.btnFavorite)
        Me.Controls.Add(Me.lblMenuTitle)
        Me.Controls.Add(Me.pbMenuImage)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "ucMenu"
        Me.Size = New System.Drawing.Size(300, 37)
        CType(Me.pbMenuImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbMenuImage As PictureBox
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents btnFavorite As Button
End Class
