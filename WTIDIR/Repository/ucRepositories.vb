Public Class ucRepositories

#Region "SQL Queries"

    Public Sub loadRawmats()
        modGeneral.setApplicationState(ApplicationState.Busy)
        Dim list = modRepositories.getRawmatsList(tstxtRawmatSearch.Text.Trim.Replace(" ", "%"))
        lvRawmats.BeginUpdate()
        lvRawmats.Items.Clear()
        lvRawmats.Groups.Clear()
        Dim group As ListViewGroup = Nothing
        For Each cItem In list
            Dim oItem As ListViewItem = New ListViewItem(cItem.sku)

            group = Nothing
            For Each oGroup As ListViewGroup In lvRawmats.Groups
                If oGroup.Header = cItem.group Then
                    group = oGroup
                    Exit For
                End If
            Next

            If group Is Nothing Then
                group = New ListViewGroup(cItem.group)
                lvRawmats.Groups.Add(group)
            End If

            Dim item = lvRawmats.Items.Add(cItem.sku)
            With item
                .Group = group
                .SubItems.Add(cItem.sapcode)
                .SubItems.Add(cItem.name)
                .SubItems.Add(cItem.isperishable)
                .SubItems.Add(cItem.status)
                .Tag = cItem
            End With

        Next
        lvRawmats.EndUpdate()
        tsslRawmats.Text = "Row Count: " & list.Count()
        modGeneral.setApplicationState(ApplicationState.Ready)
    End Sub

    Public Sub loadProductItem()
        modGeneral.setApplicationState(ApplicationState.Busy)
        Dim list = modRepositories.getProductItemList(tstxtProductItem.Text.Trim.Replace(" ", "%"))
        lvProductItem.BeginUpdate()
        lvProductItem.Items.Clear()
        For Each cItem In list
            Dim oItem As ListViewItem = New ListViewItem(cItem.sku)
            oItem.SubItems.Add(cItem.name)
            '            oItem.SubItems.Add(cItem)
            lvProductItem.Items.Add(oItem)
        Next
        lvProductItem.EndUpdate()
        tsslProductItemCount.Text = "Row Count " & list.Count()
        modGeneral.setApplicationState(ApplicationState.Ready)
    End Sub

    Public Sub loadItemGroup()
        modGeneral.setApplicationState(ApplicationState.Busy)
        Dim list = modRepositories.getItemGroupList(tstxtItemGroupSearch.Text.Trim.Replace(" ", "%"))
        lvItemGroup.BeginUpdate()
        lvItemGroup.Items.Clear()
        For Each cItem In list
            Dim oItem As ListViewItem = New ListViewItem(cItem.sku)

            oItem.SubItems.Add(cItem.name)
            oItem.SubItems.Add(cItem.type)
            oItem.SubItems.Add(cItem.shortagetype)
            oItem.SubItems.Add(cItem.status)
            oItem.Tag = cItem

            lvItemGroup.Items.Add(oItem)
        Next
        lvItemGroup.EndUpdate()
        tsslItemGroupCount.Text = "Row Count: " & list.Count()
        modGeneral.setApplicationState(ApplicationState.Ready)
    End Sub

#End Region

    Private Sub ucRepositories_Load(sender As Object, e As EventArgs) Handles Me.Load

        loadProductItem()
        loadRawmats()
        loadItemGroup()

    End Sub

    ' Unfinished

    Public Sub addRawmats(clsRawmats As clsRepositoryRawmats)
        modGeneral.setApplicationState(ApplicationState.Busy)
        lvRawmats.BeginUpdate()
        Dim oItem As ListViewItem = New ListViewItem
        MsgBox(clsRawmats.name)

        lvRawmats.EndUpdate()
        modGeneral.setApplicationState(ApplicationState.Ready)
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim oParentTabPage As TabPage = DirectCast(Me.Parent, TabPage)
        oParentTabPage.Dispose()
    End Sub

    Private Sub lvRawmats_DoubleClick(sender As Object, e As EventArgs) Handles lvRawmats.DoubleClick
        If lvRawmats.SelectedItems.Count > 0 Then
            Dim clsRawmats As clsRepositoryRawmats = DirectCast(lvRawmats.SelectedItems(0).Tag, clsRepositoryRawmats)
            Dim frmRI As New frmRawmatsInfo()
            frmRI.Rawmats = clsRawmats
            If frmRI.ShowDialog() = DialogResult.OK Then
                loadRawmats()
            End If
        End If
    End Sub

    Private Sub lvRawmats_KeyDown(sender As Object, e As KeyEventArgs) Handles lvRawmats.KeyDown
        If e.KeyCode = Keys.Enter Then
            lvRawmats_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub tsmiRawmatUpdate_Click(sender As Object, e As EventArgs) Handles tsmiRawmatUpdate.Click
        lvRawmats_DoubleClick(sender, e)
    End Sub

    Private Sub tsmiItemGroup_Click(sender As Object, e As EventArgs)
        Dim dialog As New frmItemGroupInfo
        If dialog.ShowDialog() = DialogResult.OK Then
            loadRawmats()
        End If
    End Sub

    Private Sub tsmiNew_Click(sender As Object, e As EventArgs) Handles tsmiNew.Click
        Dim dialog As New frmRawmatsInfo
        If dialog.ShowDialog() = DialogResult.OK Then
            loadRawmats()
        End If
    End Sub

    Private Sub tstxtRawmatSearch_TextChanged(sender As Object, e As EventArgs) Handles tstxtRawmatSearch.TextChanged
        loadRawmats()
    End Sub

    Private Sub tsmiItemGroupNew_Click(sender As Object, e As EventArgs) Handles tsmiItemGroupNew.Click
        frmItemGroupInfo.ShowDialog()
    End Sub

End Class
