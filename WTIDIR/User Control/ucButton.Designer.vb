<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucButton
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
        Me.lblButton = New System.Windows.Forms.Label()
        Me.pbButton = New System.Windows.Forms.PictureBox()
        CType(Me.pbButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblButton
        '
        Me.lblButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblButton.Location = New System.Drawing.Point(34, 0)
        Me.lblButton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblButton.Name = "lblButton"
        Me.lblButton.Size = New System.Drawing.Size(166, 35)
        Me.lblButton.TabIndex = 0
        Me.lblButton.Text = "Button1"
        Me.lblButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbButton
        '
        Me.pbButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbButton.Location = New System.Drawing.Point(3, 5)
        Me.pbButton.Name = "pbButton"
        Me.pbButton.Size = New System.Drawing.Size(24, 24)
        Me.pbButton.TabIndex = 1
        Me.pbButton.TabStop = False
        '
        'ucButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbButton)
        Me.Controls.Add(Me.lblButton)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucButton"
        Me.Size = New System.Drawing.Size(200, 35)
        CType(Me.pbButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblButton As Label
    Friend WithEvents pbButton As PictureBox
End Class
