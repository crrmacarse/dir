<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.imgFBBQ = New System.Windows.Forms.Label()
        Me.imgCB = New System.Windows.Forms.Label()
        Me.imgRNM = New System.Windows.Forms.Label()
        Me.imgWTI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnOptionsBack = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSQLDatabase = New System.Windows.Forms.TextBox()
        Me.txtSQLPassword = New System.Windows.Forms.TextBox()
        Me.txtSQLUsername = New System.Windows.Forms.TextBox()
        Me.txtSQLPort = New System.Windows.Forms.TextBox()
        Me.txtSQLServer = New System.Windows.Forms.TextBox()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.cmbUsername = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.btnSQLTestConnection = New WTIDIR.ucButton()
        Me.btnSQLSave = New WTIDIR.ucButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlSettings.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pnlLogin)
        Me.Panel1.Controls.Add(Me.pnlSettings)
        Me.Panel1.Location = New System.Drawing.Point(173, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 551)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(71, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DAILY INVENTORY REPORT"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(461, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "© Waffle Time Inc. 2018. All Rights Reserved."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(464, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "WELCOME TO MIS-WTIDIR, SELECT YOUR BUSINESS UNIT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(461, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "SIGN IN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.imgFBBQ)
        Me.Panel2.Controls.Add(Me.imgCB)
        Me.Panel2.Controls.Add(Me.imgRNM)
        Me.Panel2.Controls.Add(Me.imgWTI)
        Me.Panel2.Location = New System.Drawing.Point(0, 237)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(467, 69)
        Me.Panel2.TabIndex = 2
        '
        'imgFBBQ
        '
        Me.imgFBBQ.Image = CType(resources.GetObject("imgFBBQ.Image"), System.Drawing.Image)
        Me.imgFBBQ.Location = New System.Drawing.Point(199, 10)
        Me.imgFBBQ.Name = "imgFBBQ"
        Me.imgFBBQ.Size = New System.Drawing.Size(48, 48)
        Me.imgFBBQ.TabIndex = 7
        '
        'imgCB
        '
        Me.imgCB.Image = CType(resources.GetObject("imgCB.Image"), System.Drawing.Image)
        Me.imgCB.Location = New System.Drawing.Point(136, 10)
        Me.imgCB.Name = "imgCB"
        Me.imgCB.Size = New System.Drawing.Size(48, 48)
        Me.imgCB.TabIndex = 6
        '
        'imgRNM
        '
        Me.imgRNM.Image = CType(resources.GetObject("imgRNM.Image"), System.Drawing.Image)
        Me.imgRNM.Location = New System.Drawing.Point(73, 10)
        Me.imgRNM.Name = "imgRNM"
        Me.imgRNM.Size = New System.Drawing.Size(48, 48)
        Me.imgRNM.TabIndex = 5
        '
        'imgWTI
        '
        Me.imgWTI.Image = CType(resources.GetObject("imgWTI.Image"), System.Drawing.Image)
        Me.imgWTI.Location = New System.Drawing.Point(10, 10)
        Me.imgWTI.Name = "imgWTI"
        Me.imgWTI.Size = New System.Drawing.Size(48, 48)
        Me.imgWTI.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 180)
        Me.Label1.TabIndex = 1
        '
        'pnlSettings
        '
        Me.pnlSettings.BackColor = System.Drawing.Color.White
        Me.pnlSettings.Controls.Add(Me.btnSQLTestConnection)
        Me.pnlSettings.Controls.Add(Me.btnSQLSave)
        Me.pnlSettings.Controls.Add(Me.Label15)
        Me.pnlSettings.Controls.Add(Me.Label10)
        Me.pnlSettings.Controls.Add(Me.Label9)
        Me.pnlSettings.Controls.Add(Me.Label7)
        Me.pnlSettings.Controls.Add(Me.btnOptionsBack)
        Me.pnlSettings.Controls.Add(Me.Label8)
        Me.pnlSettings.Controls.Add(Me.txtSQLDatabase)
        Me.pnlSettings.Controls.Add(Me.txtSQLPassword)
        Me.pnlSettings.Controls.Add(Me.txtSQLUsername)
        Me.pnlSettings.Controls.Add(Me.txtSQLPort)
        Me.pnlSettings.Controls.Add(Me.txtSQLServer)
        Me.pnlSettings.Location = New System.Drawing.Point(0, 345)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(467, 178)
        Me.pnlSettings.TabIndex = 11
        Me.pnlSettings.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Database"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Server"
        '
        'btnOptionsBack
        '
        Me.btnOptionsBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOptionsBack.FlatAppearance.BorderSize = 0
        Me.btnOptionsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptionsBack.Location = New System.Drawing.Point(13, 124)
        Me.btnOptionsBack.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOptionsBack.Name = "btnOptionsBack"
        Me.btnOptionsBack.Size = New System.Drawing.Size(35, 35)
        Me.btnOptionsBack.TabIndex = 11
        Me.btnOptionsBack.Text = "..."
        Me.btnOptionsBack.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(316, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Port"
        '
        'txtSQLDatabase
        '
        Me.txtSQLDatabase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLDatabase.Location = New System.Drawing.Point(93, 94)
        Me.txtSQLDatabase.MaxLength = 15
        Me.txtSQLDatabase.Name = "txtSQLDatabase"
        Me.txtSQLDatabase.Size = New System.Drawing.Size(359, 23)
        Me.txtSQLDatabase.TabIndex = 4
        '
        'txtSQLPassword
        '
        Me.txtSQLPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLPassword.Location = New System.Drawing.Point(93, 65)
        Me.txtSQLPassword.MaxLength = 15
        Me.txtSQLPassword.Name = "txtSQLPassword"
        Me.txtSQLPassword.Size = New System.Drawing.Size(359, 23)
        Me.txtSQLPassword.TabIndex = 3
        Me.txtSQLPassword.UseSystemPasswordChar = True
        '
        'txtSQLUsername
        '
        Me.txtSQLUsername.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLUsername.Location = New System.Drawing.Point(93, 36)
        Me.txtSQLUsername.MaxLength = 15
        Me.txtSQLUsername.Name = "txtSQLUsername"
        Me.txtSQLUsername.Size = New System.Drawing.Size(359, 23)
        Me.txtSQLUsername.TabIndex = 2
        '
        'txtSQLPort
        '
        Me.txtSQLPort.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLPort.Location = New System.Drawing.Point(352, 7)
        Me.txtSQLPort.Name = "txtSQLPort"
        Me.txtSQLPort.Size = New System.Drawing.Size(100, 23)
        Me.txtSQLPort.TabIndex = 1
        '
        'txtSQLServer
        '
        Me.txtSQLServer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLServer.Location = New System.Drawing.Point(93, 7)
        Me.txtSQLServer.MaxLength = 15
        Me.txtSQLServer.Name = "txtSQLServer"
        Me.txtSQLServer.Size = New System.Drawing.Size(199, 23)
        Me.txtSQLServer.TabIndex = 0
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.Controls.Add(Me.pbPhoto)
        Me.pnlLogin.Controls.Add(Me.btnOptions)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.cmbUsername)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.Label11)
        Me.pnlLogin.Location = New System.Drawing.Point(0, 345)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(467, 178)
        Me.pnlLogin.TabIndex = 9
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOptions.FlatAppearance.BorderSize = 0
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Location = New System.Drawing.Point(15, 120)
        Me.btnOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(35, 35)
        Me.btnOptions.TabIndex = 9
        Me.btnOptions.Text = "..."
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(302, 120)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 35)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'cmbUsername
        '
        Me.cmbUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsername.FormattingEnabled = True
        Me.cmbUsername.Location = New System.Drawing.Point(112, 14)
        Me.cmbUsername.Name = "cmbUsername"
        Me.cmbUsername.Size = New System.Drawing.Size(340, 33)
        Me.cmbUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(112, 62)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(340, 33)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(3, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(461, 20)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Forgot your password? Contact the MIS Department"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 150)
        Me.Label4.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(152, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(395, 30)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "WAFFLE TIME INC."
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(152, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(407, 25)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Management Information Systems Department"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(152, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(380, 31)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "ARSENAL ILOILO"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(776, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.TabIndex = 8
        '
        'pbPhoto
        '
        Me.pbPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbPhoto.Location = New System.Drawing.Point(6, 7)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(100, 100)
        Me.pbPhoto.TabIndex = 10
        Me.pbPhoto.TabStop = False
        '
        'btnSQLTestConnection
        '
        Me.btnSQLTestConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSQLTestConnection.BackColorHighlight = System.Drawing.Color.Empty
        Me.btnSQLTestConnection.Caption = "Test Connection"
        Me.btnSQLTestConnection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSQLTestConnection.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSQLTestConnection.Image = CType(resources.GetObject("btnSQLTestConnection.Image"), System.Drawing.Image)
        Me.btnSQLTestConnection.Location = New System.Drawing.Point(92, 124)
        Me.btnSQLTestConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSQLTestConnection.Name = "btnSQLTestConnection"
        Me.btnSQLTestConnection.Size = New System.Drawing.Size(200, 35)
        Me.btnSQLTestConnection.TabIndex = 17
        Me.btnSQLTestConnection.UseThemeColor = True
        '
        'btnSQLSave
        '
        Me.btnSQLSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSQLSave.BackColorHighlight = System.Drawing.Color.Empty
        Me.btnSQLSave.Caption = "Save"
        Me.btnSQLSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSQLSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSQLSave.Image = CType(resources.GetObject("btnSQLSave.Image"), System.Drawing.Image)
        Me.btnSQLSave.Location = New System.Drawing.Point(302, 124)
        Me.btnSQLSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSQLSave.Name = "btnSQLSave"
        Me.btnSQLSave.Size = New System.Drawing.Size(150, 35)
        Me.btnSQLSave.TabIndex = 16
        Me.btnSQLSave.UseThemeColor = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 727)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents imgFBBQ As Label
    Friend WithEvents imgCB As Label
    Friend WithEvents imgRNM As Label
    Friend WithEvents imgWTI As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPassword As TextBox
    Private WithEvents btnClose As Label
    Friend WithEvents cmbUsername As ComboBox
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSQLDatabase As TextBox
    Friend WithEvents txtSQLPassword As TextBox
    Friend WithEvents txtSQLUsername As TextBox
    Friend WithEvents txtSQLPort As TextBox
    Friend WithEvents txtSQLServer As TextBox
    Friend WithEvents btnOptionsBack As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSQLSave As ucButton
    Friend WithEvents btnSQLTestConnection As ucButton
    Friend WithEvents pbPhoto As PictureBox
End Class
