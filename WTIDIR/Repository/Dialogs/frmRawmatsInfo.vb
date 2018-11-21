Public Class frmRawmatsInfo

    Dim _listGroup As List(Of clsRepositoryItemGroup)
    Public _clsRawmats As clsRepositoryRawmats

    Dim changeTracker As String = String.Empty

    ' Listview table row is passed here 

    Public Property Rawmats As clsRepositoryRawmats
        Get
            Return _clsRawmats
        End Get
        Set(value As clsRepositoryRawmats)
            _clsRawmats = value
        End Set
    End Property

    ' Shadow Effect

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

        Me._clsRawmats = New clsRepositoryRawmats

        Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.3
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.X, Screen.PrimaryScreen.WorkingArea.Height * 0.13)
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height * 0.8

    End Sub

    ' Fills in the cmbItemGroup(uses clsKeyValuePair)

    Public Sub loadItemGroup()
        Dim arrayGroup As New ArrayList()
        _listGroup = modRepositories.getItemGroupList()

        For Each cList In _listGroup
            arrayGroup.Add(New clsKeyValuePair(cList.id, cList.name))
        Next

        cmbItemGroup.DataSource = arrayGroup
        cmbItemGroup.DisplayMember = "value"
        cmbItemGroup.ValueMember = "key"

        cmbItemGroup.SelectedValue = CStr(_clsRawmats.idgroup)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If changeTracker <> modGeneral.trackChange(Me) Then
            If modGeneral.showMessageBox("It seems you have some changes in the System. Do you you want to Save it?", MessageBoxIcon.Question) = DialogResult.Yes Then
                btnSave.PerformClick()
            End If
            Close()
        End If
        Close()
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnSave.Visible = False
        btnEdit.Visible = True
        btnEdit.Select()

        txtSKU.ReadOnly = True
        txtSKU.ForeColor = Color.DimGray
        txtSAPCode.ReadOnly = True
        txtSAPCode.ForeColor = Color.DimGray
        txtName.ReadOnly = True
        txtName.ForeColor = Color.DimGray
        cmbIsPerishable.Enabled = False
        cmbPriority.Enabled = False
        cmbItemGroup.Enabled = False


        If changeTracker = modGeneral.trackChange(Me) Then
            Return
        End If

        If (modGeneral.showMessageBox("Are you sure you want to save changes in " & _clsRawmats.name, MessageBoxIcon.Question, "Save File?") = DialogResult.Yes) Then
            _clsRawmats.sku = txtSKU.Text
            _clsRawmats.sapcode = txtSAPCode.Text
            _clsRawmats.idgroup = cmbItemGroup.SelectedValue
            _clsRawmats.name = txtName.Text
            If cmbIsPerishable.SelectedIndex = 0 Then
                _clsRawmats.isperishable = True
            Else
                _clsRawmats.isperishable = False
            End If
            _clsRawmats.priority = cmbPriority.SelectedValue


            changeTracker = modGeneral.trackChange(Me)

            If (modRepositories.saveRawmats(_clsRawmats)) = True Then
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

            txtSKU.ReadOnly = False
            txtSKU.ForeColor = Color.Black
            txtSAPCode.ReadOnly = False
            txtSAPCode.ForeColor = Color.Black
            txtName.ReadOnly = False
            txtName.ForeColor = Color.Black
            cmbIsPerishable.Enabled = True
            cmbItemGroup.Enabled = True
            cmbPriority.Enabled = True

            Debug.Print(modGeneral.trackChange(Me))

        End If

    End Sub

    Private Sub frmRawamtsInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtSKU.Text = _clsRawmats.sku
        txtSAPCode.Text = _clsRawmats.sapcode
        txtName.Text = _clsRawmats.name
        If _clsRawmats.isperishable Then
            cmbIsPerishable.SelectedIndex = 0
        Else
            cmbIsPerishable.SelectedIndex = 1
        End If
        cmbIsPerishable.Text = _clsRawmats.isperishable
        cmbPriority.Text = _clsRawmats.priority
        loadItemGroup()

        lblBusinessUnit.Text = "Business Unit: " & _clsRawmats.businessunit
        lblDateUpdated.Text = "Last Updated: " & _clsRawmats.dateupdated
        lblUpdatedBy.Text = "Last Updated By: " & _clsRawmats.updatedby

        changeTracker = modGeneral.trackChange(Me)
    End Sub

End Class