Public Class Serial

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Serial As String = "PAD-1500-1938-LUMA-2021-2019"

        If TextBox1.Text = Serial Then
            MsgBox("Sucesso! o programa foi ativado com sucesso.", MsgBoxStyle.Exclamation)

            My.Settings.ativado = True
            My.Settings.Save()
            My.Settings.Reload()
        Else
            MsgBox("Erro! Serial inválido.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://scripttutoriais.blogspot.com/2021/01/studiopad.html")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class