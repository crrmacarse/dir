Public Class frmMain

    Private WithEvents ftab As frmTab

    Private Sub LoadTab(tabtype As String)
        Dim oTabPage As New TabPage

        Select Case tabtype
            Case "NewInventory"
                oTabPage.Text = "New Inventory"
                oTabPage.ImageIndex = 1
                Dim oTabContent As New ucInventory
                oTabContent.Dock = DockStyle.Fill
                oTabPage.Controls.Add(oTabContent)
            Case "NewDelivery"
                oTabPage.Text = "New Delivery"
                oTabPage.ImageIndex = 2
                Dim oTabContent As New ucDelivery
                oTabContent.Dock = DockStyle.Fill
                oTabPage.Controls.Add(oTabContent)

            'Case "AccountUser"
            '    oTabPage.Text = "Account User"
            '    oTabPage.ImageIndex = 2
            '    Dim oTabContent As New ucAccountUser
            '    oTabContent.Dock = DockStyle.Fill
            '    oTabPage.Controls.Add(oTabContent)
            Case "Repository"
                oTabPage.Text = "Repository"
                oTabPage.ImageIndex = 2
                Dim oTabContent As New ucRepositories
                oTabContent.Dock = DockStyle.Fill
                oTabContent.Refresh()
                oTabPage.Controls.Add(oTabContent)

        End Select

        tcMain.Controls.Add(oTabPage)
        tcMain.SelectedTab = oTabPage
    End Sub

    Public Sub addTabPage(page As String)

        For Each tp As TabPage In tcMain.TabPages
            If tp.Text = page Then
                tcMain.SelectedTab = tp
                Exit Sub
            End If
        Next

        Dim uc As UserControl = Nothing
        Select Case page
            Case "Inventory"
                uc = New ucInventory
            Case "Delivery"
                uc = New ucDelivery
            'Case "Account User"
            '    uc = New ucAccountUser
            Case "Repository"
                uc = New ucRepositories
        End Select

        If uc Is Nothing Then Exit Sub

        modGeneral.setApplicationState(ApplicationState.Busy)
        Dim tpNew As New TabPage(page)
        tpNew.Name = page
        tcMain.SuspendLayout()
        tcMain.TabPages.Add(tpNew)
        uc.Dock = DockStyle.Fill
        tpNew.SuspendLayout()
        tpNew.Controls.Add(uc)
        tpNew.ResumeLayout()
        tcMain.SelectedTab = tpNew
        modGeneral.setApplicationState(ApplicationState.Ready)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub btnAccountUser_Click(sender As Object, e As EventArgs) Handles tsmiManageAccount.Click
        LoadTab("AccountUser")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Dim oTab As New frmTab
        oTab.Width = tcMain.Width * 0.2
        oTab.Location = New Point(tcMain.Width * 0.8, 0)
        oTab.Height = Screen.PrimaryScreen.Bounds.Height
        oTab.Show()
    End Sub

    Private Sub btnNewDelivery_Clicked(sender As Object, e As EventArgs) Handles btnNewDelivery.Clicked
        LoadTab("NewDelivery")
    End Sub

    Private Sub btnNewInventory_Clicked(sender As Object, e As EventArgs) Handles btnNewInventory.Clicked
        LoadTab("NewInventory")
    End Sub

    Private Sub btnNewInventory_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub UcButton4_Load(sender As Object, e As EventArgs) Handles UcButton4.Click

    End Sub

    Private Sub UcButton4_Clicked(sender As Object, e As EventArgs) Handles UcButton4.Clicked
        LoadTab("Repository")
    End Sub

    Private Sub UcButton4_Load_1(sender As Object, e As EventArgs) Handles UcButton4.Load

    End Sub
End Class