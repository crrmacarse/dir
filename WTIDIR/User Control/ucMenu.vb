Public Class ucMenu
    Private _title As String = String.Empty
    Private _imageicon As Image = Nothing
    Private _group As String = Nothing
    Private _favorite As Boolean = False


    Public Event FavoriteClicked()

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Group As String
        Get
            Return _group
        End Get
        Set(value As String)
            _group = value
        End Set
    End Property

    Public Property Favorite As Boolean
        Get
            Return _favorite
        End Get
        Set(value As Boolean)
            _favorite = value
        End Set
    End Property

    Public Property Icon As Image
        Get
            Return _imageicon
        End Get
        Set(value As Image)
            _imageicon = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(title As String, group As String, icon As Image)
        InitializeComponent()

        _title = title
        _group = group
        _imageicon = icon

    End Sub

    'Public Sub New(title As String, sgroup As String)

    '    _title = title
    '    _group = sgroup

    '    InitializeComponent()

    '    Debug.Print(_group)
    'End Sub

    Private Sub ucMenu_Click(sender As Object, e As EventArgs) Handles Me.Click, pbMenuImage.Click, lblMenuTitle.Click
        frmMain.addTabPage(_title)
    End Sub

    Private Sub ucMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblMenuTitle.Text = _title
        pbMenuImage.Image = _imageicon
        Me.Dock = DockStyle.Top
    End Sub

    Private Sub ucMenu_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, lblMenuTitle.MouseEnter, pbMenuImage.MouseEnter, btnFavorite.MouseEnter
        btnFavorite.Visible = True
        Me.BackColor = Color.Gainsboro
    End Sub

    Private Sub ucMenu_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, lblMenuTitle.MouseLeave, pbMenuImage.MouseLeave, btnFavorite.MouseLeave
        btnFavorite.Visible = False
        Me.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub btnFavorite_Click(sender As Object, e As EventArgs) Handles btnFavorite.Click
        Debug.Print("Dasdas")
    End Sub

End Class
