Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class clsAccountUser
    Private _idAccountUser As Integer
    Private _idAccountGroup As Integer
    Private _AGName As String
    Private _AUUsername As String
    Private _AUSalt As String
    Private _AUPassword As String
    Private _AULastName As String
    Private _AUFirstName As String
    Private _AUMiddleName As String
    Private _AUSession As String
    Private _AUDateCreated As DateTime
    Private _AUPhoto As Image
    Private _AUStatus As Boolean

    Public Property idAccountUser As Integer
        Get
            Return _idAccountUser
        End Get
        Set(value As Integer)
            _idAccountUser = value
        End Set
    End Property

    Public Property idAccountGroup As Integer
        Get
            Return _idAccountGroup
        End Get
        Set(value As Integer)
            _idAccountGroup = value
        End Set
    End Property

    Public Property AGName As String
        Get
            Return _AGName
        End Get
        Set(value As String)
            _AGName = value
        End Set
    End Property

    Public Property AUUsername As String
        Get
            Return _AUUsername
        End Get
        Set(value As String)
            _AUUsername = value
        End Set
    End Property

    Public Property AUSalt As String
        Get
            Return _AUSalt
        End Get
        Set(value As String)
            _AUSalt = value
        End Set
    End Property

    Public Property AUPassword As String
        Get
            Return _AUPassword
        End Get
        Set(value As String)
            _AUPassword = value
        End Set
    End Property

    Public Property AULastName As String
        Get
            Return _AULastName
        End Get
        Set(value As String)
            _AULastName = value
        End Set
    End Property

    Public Property AUFirstName As String
        Get
            Return _AUFirstName
        End Get
        Set(value As String)
            _AUFirstName = value
        End Set
    End Property

    Public Property AUMiddleName As String
        Get
            Return _AUMiddleName
        End Get
        Set(value As String)
            _AUMiddleName = value
        End Set
    End Property

    Public Property AUSession As String
        Get
            Return _AUSession
        End Get
        Set(value As String)
            _AUSession = value
        End Set
    End Property

    Public Property AUDateCreated As DateTime
        Get
            Return _AUDateCreated
        End Get
        Set(value As DateTime)
            _AUDateCreated = value
        End Set
    End Property

    Public Property AUPhoto As Image
        Get
            Return _AUPhoto
        End Get
        Set(value As Image)
            _AUPhoto = value
        End Set
    End Property

    Public Property AUStatus As Boolean
        Get
            Return _AUStatus
        End Get
        Set(value As Boolean)
            _AUStatus = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(idAccountUser As Integer, idAccountGroup As Integer, AGName As String, AUUsername As String, AUPassword As String, AULastName As String, AUFirstName As String, AUMiddleName As String, AUSession As String, AUDateCreated As DateTime, AUPhoto As Image)
        _idAccountUser = idAccountUser
        _idAccountGroup = idAccountGroup
        _AGName = AGName
        _AUUsername = AUUsername
        _AUPassword = AUPassword
        _AULastName = AULastName
        _AUFirstName = AUFirstName
        _AUMiddleName = AUMiddleName
        _AUSession = AUSession
        _AUDateCreated = AUDateCreated
        _AUPhoto = AUPhoto
    End Sub

    Public Overrides Function ToString() As String
        Return _AUUsername
    End Function

    Public Sub CreateSession()
        Using Hasher As MD5 = MD5.Create()
            Dim dbytes As Byte() = Hasher.ComputeHash(Encoding.UTF8.GetBytes(_AUUsername & Now.ToString("yyyy/mm/dd hh:mm:ss")))
            _AUSession = Convert.ToBase64String(dbytes)
        End Using

        Using oConnection As New SqlConnection(sConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("Update AccountUser SET AUSession = @AUSession Where idAccountUser = @idAccountUser", oConnection)
                    oCommand.Parameters.AddWithValue("@AUSession", _AUSession)
                    oCommand.Parameters.AddWithValue("@idAccountUser", idAccountUser)
                    oCommand.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub




End Class
