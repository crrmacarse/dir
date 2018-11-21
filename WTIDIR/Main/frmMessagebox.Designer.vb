<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMessagebox
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
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.rtbMessageDescription = New System.Windows.Forms.RichTextBox()
        Me.lblMessageTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnYes.FlatAppearance.BorderSize = 0
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnYes.Location = New System.Drawing.Point(368, 175)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(0)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(52, 35)
        Me.btnYes.TabIndex = 2
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        Me.btnYes.Visible = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNo.FlatAppearance.BorderSize = 0
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnNo.Location = New System.Drawing.Point(420, 175)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(52, 35)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        Me.btnNo.Visible = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(420, 175)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(52, 35)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'rtbMessageDescription
        '
        Me.rtbMessageDescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtbMessageDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbMessageDescription.Font = New System.Drawing.Font("Bahnschrift Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.rtbMessageDescription.ForeColor = System.Drawing.Color.DimGray
        Me.rtbMessageDescription.Location = New System.Drawing.Point(16, 68)
        Me.rtbMessageDescription.Name = "rtbMessageDescription"
        Me.rtbMessageDescription.ReadOnly = True
        Me.rtbMessageDescription.Size = New System.Drawing.Size(456, 104)
        Me.rtbMessageDescription.TabIndex = 1
        Me.rtbMessageDescription.TabStop = False
        Me.rtbMessageDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin mas" &
    "sa in orci volutpat vehicula. Donec et nisl odio. Ut faucibus diam blandit, phar" &
    "etra quam a, fermentum lectus."
        '
        'lblMessageTitle
        '
        Me.lblMessageTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMessageTitle.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblMessageTitle.Location = New System.Drawing.Point(12, 27)
        Me.lblMessageTitle.Name = "lblMessageTitle"
        Me.lblMessageTitle.Size = New System.Drawing.Size(467, 30)
        Me.lblMessageTitle.TabIndex = 0
        Me.lblMessageTitle.Text = "Messagebox Title"
        '
        'frmMessagebox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(491, 223)
        Me.Controls.Add(Me.lblMessageTitle)
        Me.Controls.Add(Me.rtbMessageDescription)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessagebox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMessagebox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents rtbMessageDescription As RichTextBox
    Friend WithEvents lblMessageTitle As Label
End Class
