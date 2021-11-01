Public Class Link

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.TextChanged
        FastColoredTextBox1.DescriptionFile = "htmlDesc.xml"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FastColoredTextBox1.Text = "<a href='" + TextBox1.Text + "' target='" + ComboBox1.SelectedItem + "' title='" + TextBox2.Text + "'>" + TextBox2.Text + "</a>"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Main.FastColoredTextBox1 = Text = "<a href='" + TextBox1.Text + "' target='" + ComboBox1.SelectedItem + "' title='" + TextBox2.Text + "'>" + TextBox2.Text + "</a>"
    End Sub
End Class