Public Class FRPrincipal
    Private Sub hideSubMenu()
        PSubMenuAdmin.Visible = False
        PSubMenuInventario.Visible = False
        PSubMenuReportes.Visible = False

    End Sub

    Private Sub ShowSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False

        End If
    End Sub

    Private Sub IBAdmin_Click(sender As Object, e As EventArgs) Handles IBAdmin.Click
        ShowSubMenu(PSubMenuAdmin)
    End Sub

    Private Sub IBInventario_Click(sender As Object, e As EventArgs) Handles IBInventario.Click
        ShowSubMenu(PSubMenuInventario)
    End Sub

    Private Sub IBReportes_Click(sender As Object, e As EventArgs) Handles IBReportes.Click
        ShowSubMenu(PSubMenuReportes)

    End Sub
End Class