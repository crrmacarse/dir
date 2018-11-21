Imports System.Data.SqlClient
Imports System.IO
Public Class ucAccountUser
    Dim oAdapter As SqlDataAdapter
    Dim oMemoryStream As New MemoryStream()
    Dim oCount As Integer
    Dim oUsername As String

    '// Account User
    Dim oAUIdentifier As String

    Public Sub loadAccountUser()
        Dim oActiveUser As Integer = 0
        modGeneral.setApplicationState(ApplicationState.Busy)
        Dim list = modFunctions.getAccountUserList(tstxtAUSearch.Text.Trim.Replace(" ", "%"))
        lvAccountUser.Items.Clear()
        For Each cItem In list
            Dim oItem As ListViewItem = New ListViewItem(cItem.AULastName)
            oItem.SubItems.Add(cItem.AUFirstName)
            oItem.SubItems.Add(cItem.AUMiddleName)
            oItem.SubItems.Add(cItem.AUUsername)
            oItem.SubItems.Add(cItem.AGName)
            If cItem.AUStatus = True Then
                oItem.SubItems.Add("Active")
                oActiveUser = oActiveUser + 1
            Else
                oItem.SubItems.Add("Inactive")
            End If
            oItem.Tag = cItem.idAccountUser
            lvAccountUser.Items.Add(oItem)

        Next

        oCount = list.Count
        tsslAUCount.Text = "Total Count: " & oCount
        tsslAUActiveCount.Text = "Active User: " & oActiveUser
        tsslAUInactiveCount.Text = "Inactive User:" & oCount - oActiveUser
        modGeneral.setApplicationState(ApplicationState.Ready)
    End Sub

    '//  Account Group
    Dim oAGIdentifier As String

    Public Sub loadAccountGroup()
        Dim oActiveGroup As Integer = 0
        modGeneral.setApplicationState(ApplicationState.Busy)
        Dim list = modFunctions.getAccountGroupList(tstxtAGSearch.Text.Trim.Replace(" ", "%"))
        lvAccountGroup.BeginUpdate()
        lvAccountGroup.Items.Clear()
        For Each cItem In list
            Dim oItem As ListViewItem = New ListViewItem(cItem.AGName)

            If cItem.AGStatus = True Then
                oItem.SubItems.Add("Active")
                oActiveGroup = oActiveGroup + 1
            Else
                oItem.SubItems.Add("Inactive")
            End If

            oItem.Tag = cItem.idAccountGroup
            lvAccountGroup.Items.Add(oItem)
        Next
        Dim oCount = list.Count
        tsslAGCount.Text = "Total Count: " & oCount
        tsslAGActiveGroup.Text = "Active Group: " & oActiveGroup
        tsslAGActiveGroup.Text = "Inactive Group:" & oCount - oActiveGroup
        lvAccountGroup.EndUpdate()
        modGeneral.setApplicationState(ApplicationState.Ready)
    End Sub


    Private Sub ActivateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateToolStripMenuItem.Click
        Dim oStatus As Boolean
        If cmslvAccountUser.Items(2).Text = "Activate" Then
            oStatus = True
        Else
            oStatus = False
        End If

        Using oForm As New frmAUUpdate(frmAUUpdate.AUFunction.AUMessage, "Delete", lvAccountUser.SelectedItems(0).Tag, oStatus, oUsername, "AccountUser")
            If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                loadAccountUser()
            End If
        End Using
    End Sub

    Private Sub RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RToolStripMenuItem.Click

        Dim oStatus As Boolean
        If cmslvAccountGroup.Items(1).Text = "Activate" Then
            oStatus = True
        Else
            oStatus = False
        End If

        Using oForm As New frmAUUpdate(frmAUUpdate.AUFunction.AUMessage, "Delete", lvAccountGroup.SelectedItems(0).Tag, oStatus, oUsername, "AccountGroup")
            If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                loadAccountGroup()
            End If
        End Using

    End Sub

    Private Sub ucAccountUser_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load
        modGeneral.setApplicationState(ApplicationState.Busy)
        loadAccountGroup()
        loadAccountUser()
        modGeneral.setApplicationState(ApplicationState.Ready)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Using oForm As New frmAUUpdate(frmAUUpdate.AUFunction.AUUpdate, "Update", lvAccountUser.SelectedItems(0).Tag, True, oUsername)
            If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                loadAccountUser()
            End If
        End Using
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Using oForm As New frmAUUpdate(frmAUUpdate.AUFunction.AUChangePass, "ChangePass", lvAccountUser.SelectedItems(0).Tag, True, oUsername)
            If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                loadAccountUser()
            End If
        End Using
    End Sub

    Private Sub lvAccountUser_MouseClick_1(sender As Object, e As MouseEventArgs) Handles lvAccountUser.MouseClick

        If lvAccountUser.SelectedItems.Count > 0 Then
            oUsername = lvAccountUser.SelectedItems(0).SubItems(3).Text
            Dim status As String = lvAccountUser.SelectedItems(0).SubItems(5).Text
            If status = "Active" Then
                cmslvAccountUser.Items(2).Text = "Deactivate"
                cmslvAccountUser.Items(2).Image = ilAccountUser.Images(3)
            Else
                cmslvAccountUser.Items(2).Text = "Activate"
                cmslvAccountUser.Items(2).Image = ilAccountUser.Images(2)
            End If
        End If

    End Sub

    Private Sub lvAccountGroup_MouseClick_1(sender As Object, e As MouseEventArgs) Handles lvAccountGroup.MouseClick
        oUsername = lvAccountGroup.SelectedItems(0).SubItems(0).Text
        Dim status As String = lvAccountGroup.SelectedItems(0).SubItems(1).Text
        If status = "Active" Then
            cmslvAccountGroup.Items(1).Text = "Deactivate"
            cmslvAccountGroup.Items(1).Image = ilAccountUser.Images(3)
        Else
            cmslvAccountGroup.Items(1).Text = "Activate"
            cmslvAccountGroup.Items(1).Image = ilAccountUser.Images(2)
        End If

    End Sub

    Private Sub EDITToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click
        Using oForm As New frmAUUpdate(frmAUUpdate.AUFunction.AGUpdate, "Update", lvAccountGroup.SelectedItems(0).Tag, True, oUsername)
            If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                loadAccountGroup()
            End If
        End Using

    End Sub

    Private Sub tstxtSearch_KeyUp(sender As Object, e As KeyEventArgs)
        loadAccountUser()
    End Sub

    Private Sub tstxtSearchGroup_KeyUp(sender As Object, e As KeyEventArgs)
        loadAccountGroup()
    End Sub

    Private Sub tsbtnAUAdd_Click(sender As Object, e As EventArgs) Handles tsbtnAUAdd.Click
        Using oForm As New frmAUUpdate(frmAUUpdate.AUFunction.AUUpdate, "Insert")
            If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                loadAccountUser()
            End If
        End Using
    End Sub

    Private Sub tsbtnAGAdd_Click(sender As Object, e As EventArgs) Handles tsbtnAGAdd.Click
        Using oForm As New frmAUUpdate(frmAUUpdate.AUFunction.AGUpdate, "Insert")
            If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                loadAccountGroup()
            End If
        End Using
    End Sub

    Private Sub tstxtAUSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tstxtAUSearch.KeyUp
        loadAccountUser()
    End Sub

    Private Sub tstxtAGSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tstxtAGSearch.KeyUp
        loadAccountGroup()
    End Sub
End Class
