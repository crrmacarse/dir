Public Class ucSearch

    Public Overrides Property Text As String
        Get
            Return txtSearch.Text
        End Get
        Set(value As String)
            txtSearch.Text = value
        End Set
    End Property

    Public Event txtChange()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ucTextbox_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Me.OnKeyUp(e)
    End Sub

    Protected Overrides Sub OnKeyUp(e As KeyEventArgs)
        MyBase.OnKeyUp(e)
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click, Me.Click
        txtSearch.Clear()
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = String.Empty Then
            txtSearch.Text = "SEARCH MENU"
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            txtSearch.Clear()
            txtSearch.Text = "Search Menu"
            pbSearch.Select()
        End If
    End Sub

    Public Sub ucSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RaiseEvent txtChange()
    End Sub


End Class
