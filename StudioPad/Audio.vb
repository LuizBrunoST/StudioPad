Public Class Audio

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.FastColoredTextBox1.Text += "<audio controls>" & vbCrLf & vbTab
        Main.FastColoredTextBox1.Text += "<source src='" & TextBox1.Text & "' type='audio/mpeg'>" & vbCrLf
        Main.FastColoredTextBox1.Text += "</audio>" & vbCrLf

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FastColoredTextBox1.Text += "<audio controls>" & vbCrLf & vbTab
        FastColoredTextBox1.Text += "<source src='" & TextBox1.Text & "' type='audio/mpeg'>" & vbCrLf
        FastColoredTextBox1.Text += "</audio>" & vbCrLf
    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.TextChanged
        FastColoredTextBox1.DescriptionFile = "htmlDesc.xml" 'Colorir o HTML
    End Sub
End Class