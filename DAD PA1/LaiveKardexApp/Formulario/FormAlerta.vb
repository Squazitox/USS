Public Class FormAlerta
    Private Sub BAlertaSi_Click(sender As Object, e As EventArgs) Handles BAlertaSi.Click
        FormAdvertencia.Show()
        Me.Hide()
    End Sub

    Private Sub BAlertaOmitir_Click(sender As Object, e As EventArgs) Handles BAlertaOmitir.Click
        FormPrincipal.Show()
        Me.Hide()
    End Sub
End Class