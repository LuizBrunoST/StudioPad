Public Class YouTubeEmbed

    Private Sub YouTubeEmbed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FastColoredTextBox1.Text = "<iframe width='560' height='315' src='https://www.youtube.com/embed/" + TextBox1.Text + "' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.TextChanged
        FastColoredTextBox1.DescriptionFile = "htmlDesc.xml" 'Colorir o HTML
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.FastColoredTextBox1.Text = "<iframe width='560' height='315' src='https://www.youtube.com/embed/" + TextBox1.Text + "' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class