Public Class ucNotifications
    Private _Title As String = String.Empty
    Private _Description As String = String.Empty

    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
            lblTitle.Text = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _Description
        End Get
        Set(value As String)
            _Description = value
            lblDescription.Text = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnView_Click_1(sender As Object, e As EventArgs) Handles btnView.Click
        If Me.Height = 40 Then
            Dim counter As New Timer
            If Me.Height <> getMessageLength() Then

            End If
            Me.Height = getMessageLength()
            lblDescription.Visible = True
        Else
            Me.Height = 40
            lblDescription.Visible = True
        End If
    End Sub

    Private Sub tNotification_Tick(sender As Object, e As EventArgs) Handles tNotification.Tick
        MsgBox("Hello")
    End Sub

    Private Function getMessageLength() As Integer
        Return 150

        'Soon. add a function here that reads the length of the messages and depend it for its length of Notification form
    End Function
End Class
