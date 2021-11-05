Public Class JanelaPar

    Private Sub Fechar(sender As Object, e As EventArgs) Handles Tempo.Tick, PBImagem.Click, LNome.Click, MyBase.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tempo.Enabled = True
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Tempo.Enabled = False
        LNome.Text = ""
        PBImagem.BackgroundImage = Nothing
    End Sub

End Class