Public Class frmItemGroupInfo

    Public _clsItemGroup As clsRepositoryItemGroup

    Dim changeTracker As String = String.Empty


    Public Property ItemGroup As clsRepositoryItemGroup
        Get
            Return _clsItemGroup
        End Get
        Set(value As clsRepositoryItemGroup)
            _clsItemGroup = value
        End Set
    End Property

    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        Me._clsItemGroup = New clsRepositoryItemGroup
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.3
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.X, Screen.PrimaryScreen.WorkingArea.Height * 0.13)
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height * 0.8
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnSave.Visible = False
        btnEdit.Visible = True
        btnEdit.Select()
        txtName.Enabled = True
        cmbPriority.Enabled = True
        cmbType.Enabled = True
        cmbShortageType.Enabled = True

        If changeTracker = modGeneral.trackChange(Me) Then
            Return
        End If

        If (modGeneral.showMessageBox("Are you sure you want to save changes in " & _clsItemGroup.name, MessageBoxIcon.Question, "Save File?") = DialogResult.Yes) Then
            _clsItemGroup.name = txtName.Text
            If cmbType.SelectedIndex = 0 Then
                _clsItemGroup.type = True
            Else
                _clsItemGroup.type = False
            End If
            _clsItemGroup.shortagetype = cmbShortageType.Text
            _clsItemGroup.priority = cmbPriority.Text


            changeTracker = modGeneral.getHash(txtName.Text, cmbType.Text, cmbShortageType.Text, cmbPriority.Text)
            If (modRepositories.saveItemGroup(_clsItemGroup)) = True Then
                modGeneral.showMessageBox("Success", MessageBoxIcon.Exclamation)

            Else
                modGeneral.showMessageBox("There seems to be an error in Saving", MessageBoxIcon.Error, "Save File?")
            End If
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnSave.Visible = False Then
            btnSave.Visible = True
            btnEdit.Visible = False
            btnSave.Select()

            txtName.Enabled = False
            cmbType.Enabled = True
            cmbShortageType.Enabled = False
            cmbPriority.Enabled = True
            Debug.Print(modGeneral.trackChange(Me))
        End If

    End Sub


End Class