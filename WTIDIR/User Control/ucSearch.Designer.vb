<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSearch))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pbSearch = New System.Windows.Forms.PictureBox()
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Leelawadee UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtSearch.Location = New System.Drawing.Point(62, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(259, 24)
        Me.txtSearch.TabIndex = 14
        Me.txtSearch.Text = "Search Menu"
        '
        'pbSearch
        '
        Me.pbSearch.Image = CType(resources.GetObject("pbSearch.Image"), System.Drawing.Image)
        Me.pbSearch.Location = New System.Drawing.Point(22, 11)
        Me.pbSearch.Name = "pbSearch"
        Me.pbSearch.Size = New System.Drawing.Size(24, 24)
        Me.pbSearch.TabIndex = 16
        Me.pbSearch.TabStop = False
        '
        'ucSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Controls.Add(Me.pbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "ucSearch"
        Me.Size = New System.Drawing.Size(332, 49)
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pbSearch As PictureBox
End Class
