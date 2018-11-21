Module modVariables
    '----- Constants -----
    Public Const iSaltSize As Integer = 31

    ' ----- Server Connection -----
    Public sServer As String
    Public sPort As String
    Public sUsername As String
    Public sPassword As String
    Public sDatabase As String
    Public sConnectionString As String

    Public oConnection As SqlClient.SqlConnection

    ' ----- SAP Server Connection -----
    Public sSAPServer As String
    Public sSAPPort As String
    Public sSAPUsername As String
    Public sSAPPassword As String
    Public sSAPDatabase As String
    Public sSAPConnectionString As String

    Public oSAPConnection As SqlClient.SqlConnection

    Public CurrentTheme As New clsTheme
    Public CurrentAccount As clsAccountUser
    Public CurrentSession As String


    Public lstAccountUser As New List(Of clsAccountUser)

    '----- Directory -----

    Public sDirectoryLog As String = Application.StartupPath & "\Logs\"

    Public sFileLog As String

    '----- Database System Date and Time -----

    Public dbSYSDATETIME As String
    Public dbSYSDATETIMEOFFSET As String
    Public dbSYSUTCDATETIME As String
    Public dbCURRENT_TIMESTAMP As String
    Public dbGETDATE As String
    Public dbGETUTCDATE As String


End Module
