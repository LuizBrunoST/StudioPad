Public Class Video

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FastColoredTextBox1.Text += "<video width='" + TextBox2.Text + "' height='" + TextBox3.Text + "' controls>" & vbCrLf & vbTab
        FastColoredTextBox1.Text += "<source src='" & TextBox1.Text & "' type='video/mp4'>" & vbCrLf
        FastColoredTextBox1.Text += "</video>" & vbCrLf
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.FastColoredTextBox1.Text += "<video width='" + TextBox2.Text + "' height='" + TextBox3.Text + "' controls>" & vbCrLf & vbTab
        Main.FastColoredTextBox1.Text += "<source src='" & TextBox1.Text & "' type='video/mp4'>" & vbCrLf
        Main.FastColoredTextBox1.Text += "</video>" & vbCrLf
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.TextChanged
        FastColoredTextBox1.DescriptionFile = "htmlDesc.xml" 'Colorir o
    End Sub
End Class