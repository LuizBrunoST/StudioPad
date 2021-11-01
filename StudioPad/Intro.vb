Public Class Intro

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.FastColoredTextBox1.Text = My.Settings.HTML5
        Main.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.FastColoredTextBox1.Text = My.Settings.TempMasOuMenos
        Main.Show()
    End Sub
End Class