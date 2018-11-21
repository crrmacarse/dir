Public Class ucShortcut
    Private _Icon As Image = Nothing
    Private _Title As String = String.Empty

    Public Property Icon
        Get
            Return _Icon
        End Get
        Set(value)
            _Icon = value
            pbIcon.Image = value
        End Set
    End Property

    Public Property Caption As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
            lblTitle.Text = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal title As String, ByVal icon As Image)
        _Title = title
        _Icon = icon

        InitializeComponent()
    End Sub

    Public Event Clicked(sender As Object, e As System.EventArgs)

    Public Sub PerformClick()
        RaiseEvent Clicked(Me, Nothing)
    End Sub

    Private Sub Clicked_All(sender As Object, e As System.EventArgs) Handles lblTitle.Click, Me.Click, pbIcon.Click
        RaiseEvent Clicked(sender, e)
    End Sub

    Private Sub ucShortcut_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, lblTitle.MouseEnter, pbIcon.MouseEnter
        Me.BackColor = Color.Silver
    End Sub

    Private Sub ucShortcut_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, lblTitle.MouseLeave, pbIcon.MouseLeave
        Me.BackColor = ColorTranslator.FromHtml("#7D8286")
    End Sub

End Class
