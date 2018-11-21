Imports System.Data.SqlClient

Public Class frmLogin

    Private Function TestConnectionString(server As String, port As String, username As String, password As String, database As String) As Boolean
        Using oConnection As New SqlConnection("server=" & server & "," & port & ";uid=" & username & ";pwd=" & password & ";initial catalog=" & database)
            Try
                oConnection.Open()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error")
                Return False
            End Try
        End Using
    End Function

    Private Sub LoadUser()
        Using oConnection As New SqlConnection(sConnectionString)
            Try
                oConnection.Open()
                Dim sQuery = "SELECT idAccountUser,AccountUser.idAccountGroup,AGName,AUUsername,
                AUPassword,AULastName,AUFirstName,AUMiddleName,AUSession,AUDateCreated,ISNULL(AUPhoto, CONVERT(VARBINARY(MAX), 0)) AS AUPhoto 
                FROM AccountUser 
                INNER JOIN AccountGroup On AccountUSer.idAccountGroup = AccountUser.idAccountGroup
                WHERE AUStatus = 1"

                Using oCommand As New SqlCommand(sQuery, oConnection)
                    Dim oReader As SqlDataReader = oCommand.ExecuteReader

                    lstAccountUser.Clear()

                    Dim sAUPassword As String()
                    While oReader.Read
                        Dim oUser As New clsAccountUser
                        sAUPassword = oReader("AUPassword").ToString.Split(":")
                        oUser.idAccountUser = oReader("idAccountUser")
                        oUser.idAccountGroup = oReader("idAccountGroup")
                        oUser.AGName = oReader("AGName")
                        oUser.AUUsername = oReader("AUUsername")
                        oUser.AUSalt = sAUPassword(0)
                        oUser.AUPassword = sAUPassword(1)
                        oUser.AULastName = oReader("AULastName")
                        oUser.AUFirstName = oReader("AUFirstName")
                        oUser.AUMiddleName = oReader("AUMiddleName")
                        oUser.AUSession = oReader("AUSession")
                        oUser.AUDateCreated = oReader("AUDateCreated")

                        Dim imgStream As Image = Nothing
                        byteToImage(imgStream, oReader("AUPhoto"))
                        oUser.AUPhoto = imgStream
                        lstAccountUser.Add(oUser)
                    End While

                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' ----- Check connection settings in the registry
        If ReadRegistryValue("SQLServer") = String.Empty Then
            btnOptions.PerformClick()
            Return
        Else
            txtSQLServer.Text = ReadRegistryValue("SQLServer")
        End If

        If ReadRegistryValue("SQLPort") = String.Empty Then
            btnOptions.PerformClick()
            Return
        Else
            txtSQLPort.Text = ReadRegistryValue("SQLPort")
        End If

        If ReadRegistryValue("SQLUsername") = String.Empty Then
            btnOptions.PerformClick()
            Return
        Else
            txtSQLUsername.Text = ReadRegistryValue("SQLUsername")
        End If

        If ReadRegistryValue("SQLPassword") = String.Empty Then
            btnOptions.PerformClick()
            Return
        Else
            txtSQLPassword.Text = ReadRegistryValue("SQLPassword")
        End If

        If ReadRegistryValue("SQLDatabase") = String.Empty Then
            btnOptions.PerformClick()
            Return
        Else
            txtSQLDatabase.Text = ReadRegistryValue("SQLDatabase")
        End If

        sServer = txtSQLServer.Text
        sPort = txtSQLPort.Text
        sUsername = txtSQLUsername.Text
        sPassword = txtSQLPassword.Text
        sDatabase = txtSQLDatabase.Text

        sConnectionString = "server=" & sServer & "," & sPort & ";uid=" & sUsername & ";pwd=" & sPassword & ";initial catalog=" & sDatabase

        ' ----- Verify Connection String
        If Not TestConnectionString(sServer, sPort, sUsername, sPassword, sDatabase) Then
            btnOptions.PerformClick()
            Return
        End If

        LoadUser()

        cmbUsername.Items.AddRange(lstAccountUser.ToArray)
        cmbUsername.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub cmbUsername_Leave(sender As Object, e As EventArgs) Handles cmbUsername.Leave
        If cmbUsername.SelectedIndex = -1 Then Return
        Dim oAccountUser As clsAccountUser = DirectCast(cmbUsername.SelectedItem, clsAccountUser)

        pbPhoto.Image = oAccountUser.AUPhoto
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cmbUsername.SelectedIndex = -1 Then Return
        Dim oAccountUser As clsAccountUser = DirectCast(cmbUsername.SelectedItem, clsAccountUser)

        modGeneral.initializeDBDateTime()
        modGeneral.initializeDirectory()

        If CreateHashPassword(txtPassword.Text, oAccountUser.AUSalt) = oAccountUser.AUSalt & ":" & oAccountUser.AUPassword Then
            oAccountUser.CreateSession()
            CurrentAccount = oAccountUser
            CurrentSession = oAccountUser.AUSession
            frmMain.Show()
            Me.Hide()
        Else
            txtPassword.Clear()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub frmLogin_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        CurrentTheme.ThemeType = clsTheme.ThemeTypes.WaffleTime
        'Me.ForeColor = CurrentTheme.PrimaryFont
        'Me.BackColor = CurrentTheme.PrimaryBackground
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        pnlSettings.Visible = True
        pnlLogin.Visible = False
    End Sub

    Private Sub btnOptionsBack_Click(sender As Object, e As EventArgs) Handles btnOptionsBack.Click
        pnlLogin.Visible = True
        pnlSettings.Visible = False
    End Sub

    Private Sub btnSQLSave_Clicked(sender As Object, e As EventArgs) Handles btnSQLSave.Clicked
        If TestConnectionString(txtSQLServer.Text, txtSQLPort.Text, txtSQLUsername.Text, txtSQLPassword.Text, txtSQLDatabase.Text) Then
            WriteSubKeyValue("SQLServer", txtSQLServer.Text)
            WriteSubKeyValue("SQLPort", txtSQLPort.Text)
            WriteSubKeyValue("SQLUsername", txtSQLUsername.Text)
            WriteSubKeyValue("SQLPassword", txtSQLPassword.Text)
            WriteSubKeyValue("SQLDatabase", txtSQLDatabase.Text)
            MsgBox("Connection Saved")
        End If
    End Sub

    Private Sub btnSQLTestConnection_Clicked(sender As Object, e As EventArgs) Handles btnSQLTestConnection.Clicked
        If TestConnectionString(txtSQLServer.Text, txtSQLPort.Text, txtSQLUsername.Text, txtSQLPassword.Text, txtSQLDatabase.Text) Then
            MsgBox("Connection Success")
        Else
            MsgBox("Connection Failed")
        End If
    End Sub

End Class
