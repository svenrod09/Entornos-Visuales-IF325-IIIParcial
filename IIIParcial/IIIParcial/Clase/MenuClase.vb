Public Class MenuClase
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub
    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        frmUsuario.Show()
    End Sub
End Class