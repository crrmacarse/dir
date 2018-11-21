Public Class ucIcon

    Public _icon As Image
    Public _title As String
    Public _description As String

    Public Property Icon As Image
        Get
            Return _icon
        End Get
        Set(value As Image)
            _icon = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Overloads Property [Visible] As Boolean
        Get
            Return MyBase.Visible
        End Get
        Set(value As Boolean)
            MyBase.Visible = value
        End Set
    End Property


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(title As String, description As String, icon As Image)
        InitializeComponent()

        _title = title
        _description = description
        _icon = icon

    End Sub

    Private Sub ucIcon_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Me.BackColor = modVariables.CurrentTheme.PrimaryBackground

        pbIcon.Image = _icon
    End Sub

    Private Sub ucIcon_Click(sender As Object, e As EventArgs) Handles Me.Click, pbIcon.Click
        frmTab.searchPage(Title)
    End Sub

End Class
