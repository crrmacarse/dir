
Public Class ucTextbox

    Public Overrides Property ForeColor As Color
        Get
            Return txtInput.ForeColor
        End Get
        Set(value As Color)
            txtInput.ForeColor = value
        End Set
    End Property

    Public Overrides Property BackColor As Color
        Get
            Return txtInput.BackColor
        End Get
        Set(value As Color)
            txtInput.BackColor = value
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return txtInput.Text
        End Get
        Set(value As String)
            txtInput.Text = value
        End Set
    End Property

    Public Property [ReadOnly] As Boolean
        Get
            Return txtInput.ReadOnly
        End Get
        Set(value As Boolean)
            txtInput.ReadOnly = value
        End Set
    End Property


    Public Property TextAlign As HorizontalAlignment
        Get
            Return txtInput.TextAlign
        End Get
        Set(value As HorizontalAlignment)
            txtInput.TextAlign = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ucTextbox_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Me.OnKeyUp(e)
    End Sub

    Protected Overrides Sub OnKeyUp(e As KeyEventArgs)
        MyBase.OnKeyUp(e)
    End Sub

    'Private Sub ucTextbox_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    '    txtInput.Font = New Font("Verdana", txtInput.Height)
    'End Sub

End Class
