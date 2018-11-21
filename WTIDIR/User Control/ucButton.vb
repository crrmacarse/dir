Public Class ucButton
    Private _UseThemeColor As Boolean = True
    Private _BackColor As Color
    Private _ForeColor As Color
    Private _BackColorHighlight As Color

    Public Property Caption As String
        Get
            Return lblButton.Text
        End Get
        Set(value As String)
            lblButton.Text = value
        End Set
    End Property

    Public Property Image As Image
        Get
            Return pbButton.Image
        End Get
        Set(value As Image)
            pbButton.Image = value
        End Set
    End Property

    Property UseThemeColor As Boolean
        Get
            Return _UseThemeColor
        End Get
        Set(value As Boolean)
            _UseThemeColor = value
        End Set
    End Property

    Public Property BackColorHighlight As Color
        Get
            Return _BackColorHighlight
        End Get
        Set(value As Color)
            _BackColorHighlight = value
        End Set
    End Property


    Public Event Clicked(sender As Object, e As System.EventArgs)

    Public Sub PerformClick()
        RaiseEvent Clicked(Me, Nothing)
    End Sub

    Private Sub lblButton_Click(sender As Object, e As EventArgs) Handles lblButton.Click
        RaiseEvent Clicked(sender, e)
    End Sub

    Private Sub pbButton_Click(sender As Object, e As EventArgs) Handles pbButton.Click
        RaiseEvent Clicked(sender, e)
    End Sub

    Private Sub ucButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        RaiseEvent Clicked(sender, e)
    End Sub

    Private Sub ucButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, lblButton.MouseEnter, pbButton.MouseEnter
        _BackColor = Me.BackColor
        _ForeColor = lblButton.ForeColor

        If UseThemeColor Then
            lblButton.ForeColor = modVariables.CurrentTheme.PrimaryFont
            Me.BackColor = modVariables.CurrentTheme.PrimaryBackground
        Else
            lblButton.ForeColor = _ForeColor
            lblButton.BackColor = _BackColorHighlight
        End If
    End Sub

    Private Sub ucButton_MouseLeave(sendera As Object, e As EventArgs) Handles Me.MouseLeave, lblButton.MouseLeave, pbButton.MouseLeave
        If UseThemeColor = True Then
            lblButton.ForeColor = CurrentTheme.SecondaryFont
            Me.BackColor = CurrentTheme.SecondaryBackground
        Else
            lblButton.ForeColor = _ForeColor
            lblButton.BackColor = _BackColor
        End If
    End Sub

    Private Sub ucButton_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        If UseThemeColor = True Then
            lblButton.ForeColor = CurrentTheme.SecondaryFont
            Me.BackColor = CurrentTheme.SecondaryBackground
        Else
        End If

    End Sub



End Class
