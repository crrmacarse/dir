Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Win32
Imports System.Data.SqlClient

Module modGeneral
    Dim MainKey As RegistryKey = Registry.CurrentUser
    Dim sKey As String = "Software\WTIDIR"

    Public Function CreateHashPassword(password As String, salt As String) As String
        Using Hasher As MD5 = MD5.Create()
            Dim dbytes As Byte() = Hasher.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return salt & ":" & Convert.ToBase64String(dbytes)
        End Using
    End Function

    Public Function CreateSalt(saltsize As Integer) As String
        Using rngSalt As New RNGCryptoServiceProvider
            Dim data(If(saltsize < 7, 7, saltsize)) As Byte
            rngSalt.GetBytes(data)
            Return Convert.ToBase64String(data)
        End Using
    End Function

    Public Function CreateRegistrySubKey() As Boolean
        Dim KeyPermissions As RegistryKeyPermissionCheck
        KeyPermissions = RegistryKeyPermissionCheck.Default

        Try
            MainKey.CreateSubKey(sKey, KeyPermissions)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: Creating SubKey", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ReadRegistryValue(ByVal sKeyName As String) As String
        Dim rkKey As RegistryKey
        Dim Value As New String("")

        Try
            rkKey = MainKey.OpenSubKey(sKey, True)
            If rkKey Is Nothing Then
                CreateRegistrySubKey()
            End If

            Value = rkKey.GetValue(sKeyName)
            If Value = String.Empty Then
                Throw New Exception("Value is empty.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: Reading Registry Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CreateRegistrySubKey()
        End Try
        Return Value
    End Function

    Public Function WriteSubKeyValue(ByVal sKeyName As String, ByVal oNameValue As Object) As Boolean
        Dim RegType As RegistryValueKind
        RegType = RegistryValueKind.String

        Dim rkKey As RegistryKey
        Try
            rkKey = MainKey.OpenSubKey(sKey, True)
            If rkKey Is Nothing Then
                rkKey = MainKey.CreateSubKey(sKey, RegistryKeyPermissionCheck.Default)
            End If
            rkKey.SetValue(sKeyName, oNameValue, RegType)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: Writing Registry Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub byteToImage(ByRef ImgTarget As Image, ByVal ByteArr() As Byte)
        Dim ImageStream As MemoryStream

        Try
            If ByteArr.GetUpperBound(0) > 0 Then
                ImageStream = New MemoryStream(ByteArr)
                ImgTarget = Image.FromStream(ImageStream)
            Else
                ImgTarget = Nothing
            End If
        Catch ex As Exception
            ImgTarget = Nothing
        End Try
    End Sub

    Public Sub imageToByte(ByRef ImgTarget As Image, ByRef ByteArr() As Byte)
        Dim ImageStream As MemoryStream

        Try
            ReDim ByteArr(0)
            If ImgTarget IsNot Nothing Then
                ImageStream = New MemoryStream
                ImgTarget.Save(ImageStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                ReDim ByteArr(CInt(ImageStream.Length - 1))
                ImageStream.Position = 0
                ImageStream.Read(ByteArr, 0, CInt(ImageStream.Length))
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    ' MessageBox Dialog For the Whole System
    ' Interaction error in frmTab => can't display this function in a control's click event under the frmTab(probably a clash in deactivate event inside frmTab)

    Public Function showMessageBox(
                                  message As String,
                                  Optional icon As MessageBoxIcon = MessageBoxIcon.Information,
                                  Optional caption As String = Nothing) As DialogResult
        If caption = Nothing Then caption = My.Application.Info.Title

        Using fMessage As New frmMessagebox(caption, icon, message)
            Return fMessage.ShowDialog()
        End Using
    End Function

    ' Initialization of Directory (expand further)

    Public Sub initializeDirectory()

        If cleanDateTime(dbGETDATE) = "Invalid DateTime" Then
            Return
        End If

        sFileLog = sDirectoryLog & cleanDateTime(dbGETDATE) & ".csv"

        Try
            If Not Directory.Exists(sDirectoryLog) Then Directory.CreateDirectory(sDirectoryLog)

            If Not File.Exists(sFileLog) Then createFile(sFileLog, True)

        Catch ex As Exception
            modGeneral.showMessageBox(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message)
        End Try
    End Sub

    ' Create a Hidden OR Non-Hidden File

    Public Sub createFile(sFilePath As String, Optional hide As Boolean = False)
        System.IO.File.Create(sFilePath)

        If hide Then
            File.SetAttributes(sFilePath, FileAttribute.Hidden)
        End If

    End Sub

    ' System Log

    Public Enum LogState
        msg
        important
        notice
        [error]
    End Enum

    Public Sub writeLog(method As String, message As String, Optional logstate As LogState = LogState.msg, Optional show As Boolean = True)
        If show Then modGeneral.showMessageBox(message, MessageBoxIcon.Error, method)

        If Directory.Exists(sDirectoryLog) = False OrElse File.Exists(sFileLog) = False Then
            Exit Sub
        End If

        Try
            Using oWriter As New StreamWriter(sFileLog, True)
                Select Case logstate
                    Case LogState.msg
                        oWriter.WriteLine("msg," & Date.Now.ToString("yyyy-MMM-dd hh:mm tt") & ", " & method & ", " & CurrentAccount.AUUsername & " [" &
                                          CurrentAccount.idAccountUser & "] " & message)
                    Case LogState.important
                        oWriter.WriteLine("important," & Date.Now.ToString("yyyy-MMM-dd hh:mm tt") & ", " & method & ", " & message)
                    Case LogState.notice
                        oWriter.WriteLine("notice," & Date.Now.ToString("yyyy-MMM-dd hh:mm tt") & ", " & method & ", " & message)
                    Case LogState.error
                        oWriter.WriteLine("error," & Date.Now.ToString("yyyy-MMM-dd hh:mm tt") & ", " & method & ", " & message)
                End Select
                oWriter.Close()
            End Using
        Catch ex As Exception
            modGeneral.showMessageBox(System.Reflection.MethodBase.GetCurrentMethod.Name, MessageBoxIcon.Warning, ex.Message)
        End Try

    End Sub

    ' Application State for the Whole System(status bar toggle)

    Public Enum ApplicationState
        Busy
        Ready
        Refresh
        [Error]
    End Enum

    Public Sub setApplicationState(state As ApplicationState, Optional msg As String = Nothing)
        If state <> ApplicationState.Refresh Then
            If state = ApplicationState.Busy Then
                frmMain.tsMain.BackColor = modGUI.ColorWarning
                If msg = Nothing Then frmMain.tslMainStatus.Text = "Busy. Please wait..." Else frmMain.tslMainStatus.Text = msg
            ElseIf state = ApplicationState.Ready Then
                frmMain.tsMain.BackColor = modVariables.CurrentTheme.PrimaryBackground
                frmMain.tslMainStatus.Text = "Ready"
            ElseIf state = ApplicationState.Error Then
                frmMain.tcMain.BackColor = modGUI.ColorError
                frmMain.tslMainStatus.Text = "Fatal Error: " + msg
            End If
        End If
        frmMain.tcMain.Refresh()
    End Sub

    ' SQL General-Hybrid ExecuteScalar. Adds additional infinite parameters(by using ParamArray) for queries

    Public Function executeScalar(ByVal connectionString As String, ByVal query As String, ByVal ParamArray args() As clsKeyValuePair)
        Using oConnect As New SqlConnection(connectionString)
            Try
                oConnect.Open()
                Using oCommand As New SqlCommand(query, oConnect)
                    For Each arg In args
                        oCommand.Parameters.AddWithValue(arg._key, arg._value)
                    Next
                    Return oCommand.ExecuteScalar
                End Using
            Catch ex As Exception
                modGeneral.writeLog(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message, LogState.error)
            End Try
        End Using
        Return 0
    End Function

    ' Experimental Hash(SHA256). Generates a Hashed String for comparison purpose(track changes in the system)

    Public Function getHash(ParamArray args() As String) As String
        Dim initText As String = String.Empty

        For Each arg In args
            initText &= Trim(arg)
        Next

        Dim sha256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(initText)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function

    ' Get Date and Time of the Database(Converted to String due to incomplete return of result)

    Public Sub initializeDBDateTime()

        Using oConnection As New SqlConnection(sConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("SELECT SYSDATETIME() AS [SYSDATETIME], SYSDATETIMEOFFSET() AS [SYSDATETIMEOFFSET], SYSUTCDATETIME() 
                    AS [SYSUTCDATETIME], CURRENT_TIMESTAMP AS [CURRENT_TIMESTAMP], GETDATE() AS [GETDATE], GETUTCDATE() AS [GETUTCDATE]", oConnection)
                    Using oReader = oCommand.ExecuteReader()
                        While oReader.Read
                            dbSYSDATETIME = oReader("SYSDATETIME").ToString()
                            dbSYSDATETIMEOFFSET = oReader("SYSDATETIMEOFFSET").ToString()
                            dbSYSUTCDATETIME = oReader("SYSUTCDATETIME").ToString()
                            dbCURRENT_TIMESTAMP = oReader("CURRENT_TIMESTAMP").ToString()
                            dbGETDATE = oReader("GETDATE").ToString()
                            dbGETUTCDATE = oReader("GETUTCDATE").ToString()
                        End While
                    End Using
                End Using
            Catch ex As Exception
                modGeneral.showMessageBox(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message, LogState.error)
            End Try
        End Using
    End Sub

    ' This will return a cleaned yyyyMMdd date format

    Public Function cleanDateTime(datevalue As String)

        If Not DateTime.TryParse(datevalue, "12/16/1996") Then Return "Invalid DateTime"

        Return DateTime.Parse(datevalue).ToString("yyyyMMdd")

    End Function

    ' Generate a Stock Keeping Unit

    Public Function generateSKU(id As Integer, businessunit As String, itemgroup As String)

        Debug.Print(id & " " & businessunit & " " & itemgroup)
        'Using oConnect As New SqlConnection(sConnectionString)
        '    Try
        '        oConnect.Open()

        '    Catch ex As Exception

        '    End Try
        'End Using

        '        Return id & " " & businessunit & " " & itemgroup

    End Function

    ' Change Tracker. Reads Text property of Children Control From A Parent(Me)

    Public Function trackChange(prntctrl As Control)
        Dim initText As String = Nothing

        For Each chldrnctrl As Control In prntctrl.Controls
            initText &= chldrnctrl.Text
            Debug.Print(chldrnctrl.Text)
        Next

        Return getHash(initText.Replace(" ", "").Trim())

    End Function

End Module
