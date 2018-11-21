Public Class frmMessagebox

    Private _Title As String = String.Empty
    Private _Description As String = String.Empty
    Private _MessageIcon As MessageBoxIcon = Nothing

    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _Description
        End Get
        Set(value As String)
            _Description = value
        End Set
    End Property

    Property MessageIcon As MessageBoxIcon
        Get
            Return _MessageIcon
        End Get
        Set(value As MessageBoxIcon)
            _MessageIcon = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal title As String, icon As MessageBoxIcon, description As String)
        _Title = title
        _Description = description
        _MessageIcon = icon
        InitializeComponent()
    End Sub

    Private Sub frmMessagebox_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblMessageTitle.Text = _Title
        rtbMessageDescription.Text = _Description
        Select Case _MessageIcon
            Case MessageBoxIcon.Exclamation
                btnOk.Visible = True
                btnOk.ForeColor = modGUI.ColorSuccess
            Case MessageBoxIcon.Information
                btnOk.Visible = True
                btnOk.ForeColor = modGUI.ColorInfo
            Case MessageBoxIcon.Question
                btnYes.Visible = True
                btnNo.Visible = True
                btnYes.ForeColor = modGUI.ColorInfo
                btnNo.ForeColor = modGUI.ColorInfo
            Case MessageBoxIcon.Hand
                btnOk.Visible = True
                btnOk.ForeColor = modGUI.ColorWarning
            Case MessageBoxIcon.Error
                btnOk.Visible = True
                btnOk.ForeColor = modGUI.ColorError
            Case Else
                btnOk.Visible = True
        End Select
    End Sub

    Private Sub frmMessagebox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, btnOk.KeyDown, btnYes.KeyDown, rtbMessageDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnOk.Visible Then
                btnOk.PerformClick()
            ElseIf btnYes.Visible Then
                btnYes.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        DialogResult = Windows.Forms.DialogResult.No
    End Sub


End Class