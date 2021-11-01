Imports FastColoredTextBoxNS
Imports System.Net

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Intro.Close() 'Fecha o BEM VINDO
        'BemVindo.show() 'Abrir a janela de bem vindo
        AtivarViewToolStripMenuItem.Visible = False 'BOTÃO ATIVAR VISUALIZADOR OFF


        Dim Cliente As New WebClient
        Try
            Dim Retorna As String = Cliente.DownloadString("https://pastebin.com/raw/3mRGyrgv")
            If Retorna = Application.ProductVersion = False Then
                MsgBox("Info: Uma nova atualização foi enviada por favor atualize o seu programa.")
                Process.Start("https://scripttutoriais.blogspot.com/2021/01/studiopad.html") 'Site do download
            End If

        Catch ex As Exception

        End Try

        'Programa ativado ou nao
        If My.Settings.ativado = True Then
            Me.Text = Me.Text + " - PRO"
            ExportarAPKToolStripMenuItem.Enabled = True
            RegistrarToolStripMenuItem.Visible = False
        Else
            Me.Text = Me.Text + " - FREE"
            ExportarAPKToolStripMenuItem.Enabled = False
            MsgBox("Compre agora!", MsgBoxStyle.Information)
            Process.Start("https://scripttutoriais.blogspot.com/2021/01/studiopad.html")
        End If
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        MsgBox("Erro! Algo de errado não está certo!", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub SalvarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarComoToolStripMenuItem.Click

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Arquivo pad (*.pad)|*.pad|Arquivo javascript (*.js)|*.js"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.FileName = "index"
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, FastColoredTextBox3.Text, True)
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Arquivo pad (*.pad)|*.pad|Arquivo html (*.html)|*.html"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True
        
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                If (OpenFileDialog1.OpenFile() IsNot Nothing) Then
                    FastColoredTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                End If
            Catch Ex As Exception
                MsgBox("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                If (OpenFileDialog1.OpenFile() IsNot Nothing) Then
                    OpenFileDialog1.OpenFile().Close()
                End If
            End Try
        End If
    End Sub

    Private Sub ExportarAPKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAPKToolStripMenuItem.Click
        MsgBox("Info: É prescizo o java estar instalado, caso não esteja baixe é GRÁTIS!", MsgBoxStyle.Information)
        Process.Start("WebSite\Website 2 APK Builder Pro v3.4") 'Abre o WEBSITE2 APK BUILDER PRO
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Arquivo pad (*.pad)|*.pad|Arquivo folha de estilo (*css)|*.css"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.FileName = "estilo"
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, FastColoredTextBox2.Text, True)
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Arquivo pad (*.pad)|*.pad|Arquivo html (*.html)|*.html"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.FileName = "index"
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, FastColoredTextBox1.Text, True)
        End If
    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.TextChanged
        FastColoredTextBox1.DescriptionFile = "htmlDesc.xml" 'Colorir o HTML
        WebBrowser1.DocumentText = FastColoredTextBox1.Text
    End Sub

    Private Sub FastColoredTextBox2_Load_1(sender As Object, e As EventArgs) Handles FastColoredTextBox2.TextChanged
        'FastColoredTextBox1.DescriptionFile = "cssDesc.xml" 'Colorir o HTML
    End Sub

    Private Sub FastColoredTextBox2_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox2.TextChanged
        WebBrowser1.DocumentText = "<style>" + FastColoredTextBox2.Text + "</style>"
    End Sub

    Private Sub FastColoredTextBox3_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox3.TextChanged
        WebBrowser1.DocumentText = "<script>" + FastColoredTextBox3.Text + "</script>"
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AtivarViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtivarViewToolStripMenuItem.Click
        WebBrowser1.Visible = True
        DesativarViewToolStripMenuItem1.Visible = True
        AtivarViewToolStripMenuItem.Visible = False
    End Sub

    Private Sub DesativarViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DesativarViewToolStripMenuItem1.Click
        WebBrowser1.Visible = False
        DesativarViewToolStripMenuItem1.Visible = False
        AtivarViewToolStripMenuItem.Visible = True
    End Sub

    Private Sub DarFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarFeedbackToolStripMenuItem.Click
        Process.Start("https://scripttutoriais.blogspot.com/2021/01/studiopad.html") 'BlogScript tutoriais onde ele vai ficar
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Sobre.Show()
    End Sub

    Private Sub CorEmHEXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorEmHEXToolStripMenuItem.Click
        Process.Start("SeletorDeCor\HTML_Seletor_De_Cores.html")
    End Sub

    Private Sub AndroidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AndroidToolStripMenuItem.Click
        Mobile.WebBrowser1.DocumentText = FastColoredTextBox1.Text
        Mobile.Show()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        If My.Settings.ativado = False Then
            Serial.Show()
        End If
    End Sub

    Private Sub ReferenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferenciasToolStripMenuItem.Click
        Referencia.ShowDialog()
    End Sub

    Private Sub DesfazerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesfazerToolStripMenuItem.Click
        FastColoredTextBox1.Undo()
        FastColoredTextBox2.Undo()
        FastColoredTextBox3.Undo()
    End Sub

    Private Sub RefazerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefazerToolStripMenuItem.Click
        FastColoredTextBox1.Redo()
        FastColoredTextBox2.Redo()
        FastColoredTextBox3.Redo()
    End Sub

    Private Sub ColarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColarToolStripMenuItem.Click
        FastColoredTextBox1.Paste()
        FastColoredTextBox2.Paste()
        FastColoredTextBox3.Paste()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        FastColoredTextBox1.Copy()
        FastColoredTextBox2.Copy()
        FastColoredTextBox3.Copy()
    End Sub

    Private Sub SelecinarTudoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecinarTudoToolStripMenuItem.Click
        FastColoredTextBox1.SelectAll()
        FastColoredTextBox2.SelectAll()
        FastColoredTextBox3.SelectAll()
    End Sub

    Private Sub DivToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivToolStripMenuItem.Click
        FastColoredTextBox1.Text = "<div>Sua div</div>"
    End Sub

    Private Sub ParagrafoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParagrafoToolStripMenuItem.Click
        FastColoredTextBox1.Text = "<p>Seu paragráfo</p>"
    End Sub

    Private Sub NegritoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegritoToolStripMenuItem.Click
        FastColoredTextBox1.Text = "<b>Seu texto em negrito</b>"
    End Sub

    Private Sub ItalícoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalícoToolStripMenuItem.Click
        FastColoredTextBox1.Text = "<i>Seu texto em intalico</i>"
    End Sub

    Private Sub CodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodeToolStripMenuItem.Click
        FastColoredTextBox1.Text = "<code>Seu texto em code</code>"
    End Sub

    Private Sub MarqueeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarqueeToolStripMenuItem.Click
        FastColoredTextBox1.Text = "<marquee>Seu texto em marquee<marquee>"
    End Sub

    Private Sub SpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpanToolStripMenuItem.Click
        FastColoredTextBox1.Text = "<span></span>"
    End Sub

    Private Sub ComentariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComentariosToolStripMenuItem.Click
        FastColoredTextBox1.Text = "<!-- Comente aqui -->"
    End Sub

    Private Sub LinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinksToolStripMenuItem.Click
        Link.ShowDialog()
    End Sub

    Private Sub AudioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AudioToolStripMenuItem1.Click
        Audio.ShowDialog()
    End Sub

    Private Sub VideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoToolStripMenuItem.Click
        Video.ShowDialog()
    End Sub

    Private Sub EmbedYouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbedYouTubeToolStripMenuItem.Click
        YouTubeEmbed.ShowDialog()
    End Sub

    Private Sub FunctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunctionToolStripMenuItem.Click
        FastColoredTextBox3.Text += "function studioPad(){" & vbCrLf & vbTab
        FastColoredTextBox3.Text += "" & vbCrLf
        FastColoredTextBox3.Text += "}"
    End Sub

    Private Sub JanelasDeAlertasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelasDeAlertasToolStripMenuItem.Click
        FastColoredTextBox3.Text += "window.alert('Seu alerta!')"
    End Sub

    Private Sub SwitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitToolStripMenuItem.Click
        FastColoredTextBox3.Text += My.Settings.SwitchJS
    End Sub

    Private Sub LoopToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoopToolStripMenuItem1.Click
        FastColoredTextBox3.Text += "for(statement 1; statement 2; statement 3){" & vbCrLf & vbTab
        FastColoredTextBox3.Text += "// Bloco onde será executado." & vbCrLf
        FastColoredTextBox3.Text += "}"
    End Sub

    Private Sub DoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoToolStripMenuItem.Click
        FastColoredTextBox3.Text += "do{" & vbCrLf & vbTab
        FastColoredTextBox3.Text += "// Bloco onde será executado." & vbCrLf
        FastColoredTextBox3.Text += "} while(condicao)"
    End Sub

    Private Sub WhileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WhileToolStripMenuItem1.Click
        FastColoredTextBox3.Text += "while(condicao){" & vbCrLf & vbTab
        FastColoredTextBox3.Text += "// Bloco onde será executado." & vbCrLf
        FastColoredTextBox3.Text += "}"
    End Sub

    Private Sub IfElseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IfElseToolStripMenuItem.Click
        FastColoredTextBox3.Text += "if(condicao){" & vbCrLf & vbTab
        FastColoredTextBox3.Text += "// Bloco onde será executado." & vbCrLf
        FastColoredTextBox3.Text += "}else{" & vbCrLf & vbTab
        FastColoredTextBox3.Text += "// Bloco onde será executado." & vbCrLf
        FastColoredTextBox3.Text += "}"
    End Sub

    Private Sub CentralizadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentralizadoToolStripMenuItem.Click
        FastColoredTextBox2.Text += "maring: 0;"
    End Sub

    Private Sub RefrenciaBootstrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefrenciaBootstrapToolStripMenuItem.Click
        Process.Start("https://getbootstrap.com.br/docs/3.3/getting-started/") 'Referencia bootstrap
    End Sub
End Class
