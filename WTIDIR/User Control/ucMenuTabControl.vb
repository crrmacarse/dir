Public Class ucMenuTabControl
    Public _title As String

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            lblTitle.Text = value
        End Set
    End Property


    Private Sub ucMenuTabControl_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me.BackColor = modVariables.CurrentTheme.PrimaryBackground
            btnDropdown.BackColor = modVariables.CurrentTheme.PrimaryBackground
        End Sub
    End Class
