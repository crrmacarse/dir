Public Class frmTab

    Dim ucMenuSResult As New Dictionary(Of String, ucMenu)


    Private Sub frmTab_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblApplicationVersion.Text = "Application Version: " & My.Application.Info.Version.ToString()
        Me.BackColor = modVariables.CurrentTheme.PrimaryBackground
        loadPage()
    End Sub

    Private Sub frmTab_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Close()
    End Sub

    Public Sub loadTab()
        pnlTab.SuspendLayout()



        pnlTab.ResumeLayout()
    End Sub

    Private Sub ucMenuSearch_txtChange() Handles ucMenuSearch.txtChange

        'If ucMenuSearch.Text = "SEARCH MENU" Or ucMenuSearch.Text = String.Empty Then
        '    loadPage()
        '    Exit Sub
        'End If

        'Dim ucMenuSResult As New Dictionary(Of String, Control)
        'Dim c As ucMenu

        'For Each c In pnlManage.Controls
        '    If c.Title = ucMenuSearch.Text Then
        '        Debug.Print(c.Title)
        '        ucMenuSResult.Add(c.Title, c)
        '    End If
        'Next

        'For Each result In ucMenuSResult
        '    Dim uc As New ucMenu()
        '    uc.Title = result.Key
        '    uc.Dock = DockStyle.Top
        '    pnlManage.Controls.Clear()
        '    Me.pnlManage.Controls.Add(uc)
        'Next

        If ucMenuSearch.Text = "SEARCH MENU" Then
            Exit Sub
        End If

        searchPage("account", ucMenuSearch.Text)

    End Sub

    ' No deletion in Dictionary. I plan to load all files first in dictionary then use the search to remove unmatched file then display all remaining
    ' also i need to consider joining group search too. can be found on left(the icons)

    Public Sub loadPage()

        ucMenuSResult.Add("repositories", New ucMenu("Repositories", "manage", ilIcon.Images("test01")))
        ucMenuSResult.Add("inventory", New ucMenu("Inventory", "manage", ilIcon.Images("test02")))
        ucMenuSResult.Add("delivery", New ucMenu("Delivery", "manage", ilIcon.Images("test03")))
        ucMenuSResult.Add("test only", New ucMenu("Test Only", "account", ilIcon.Images("test05")))

        'ucMenuSResult.Add("repositories", New ucMenu("Repositories", "manage"))
        'ucMenuSResult.Add("inventory", New ucMenu("Inventory", "manage"))
        'ucMenuSResult.Add("delivery", New ucMenu("Delivery", "manage"))
        'ucMenuSResult.Add("test only", New ucMenu("Test Only", "account"))


        'For i As Integer = 0 To ucMenuSResult.Count - 1
        '    If ucMenuSResult.ElementAt(i).Key <> search Then

        '    End If
        'Next

        'Debug.Print(pnlManage.Controls.Count() & "Count prior to clear")

        For Each result In ucMenuSResult.Values.ToList()
            Dim uc As New ucMenu()
            uc.Icon = result.Icon
            uc.Title = result.Title
            uc.Group = result.Group
            uc.Dock = DockStyle.Top
            'If result.Group <> group Then uc.Visible = False
            pnlManage.Controls.Add(uc)

        Next

        'Debug.Print(pnlManage.Controls.Count() & "<< Count after")

        'For Each c In pnlManage.Controls
        '    If c.Title = ucMenuSearch.Text Then
        '        Debug.Print(c.Title)
        '        ucMenuSResult.Add(c.Title, c)
        '    End If
        'Next

    End Sub

    ' I cant see group in ucMenu

    Public Sub searchPage(group As String, Optional search As String = Nothing)
        Debug.Print(group)
        For Each c As ucMenu In pnlManage.Controls
            Debug.Print(c.Group)
            If c.Group <> group Then
                c.Visible = False
            End If
        Next
    End Sub

End Class