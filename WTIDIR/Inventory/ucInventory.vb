Public Class ucInventory

    Private Sub tsbtnClose_Click(sender As Object, e As EventArgs) Handles tsbtnClose.Click
        Dim oParentTabPage As TabPage = DirectCast(Me.Parent, TabPage)
        oParentTabPage.Dispose()
    End Sub
End Class
