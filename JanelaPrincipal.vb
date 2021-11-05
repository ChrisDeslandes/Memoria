Public Class JanelaPrincipal

    Private aberturaApp As Boolean
    Private segundaCartaAberta As Boolean
    Private indexCartaAberta1, indexCartaAberta2 As Integer
    Private jogo As Jogo

    Private Sub PreenchePB(pb As PictureBox)
        Dim index As Integer = CInt(pb.Name.Substring(2, 2)) - 1
        pb.BackgroundImage = jogo.GetImagemCarta(index)
        pb.BackColor = Color.White
    End Sub

    Private Sub PB_Click(sender As Object, e As EventArgs)
        If Not jogo.JogoRolando Then
            TempoJogo.Enabled = True
            jogo.JogoIniciou()
        End If
        If segundaCartaAberta = False And TempoCartasAbertas.Enabled = True Then
            FechaCartas()
        End If
        PreenchePB(sender)
        Dim indexPB As Integer = CInt(sender.name.substring(2, 2)) - 1
        If segundaCartaAberta = False Then
            sender.enabled = False
            indexCartaAberta1 = indexPB
            segundaCartaAberta = True
        Else
            jogo.Soma1Tentativa()
            LTentativas.Text = jogo.GetNumeroTentativas.ToString
            indexCartaAberta2 = indexPB
            segundaCartaAberta = False
            If jogo.DeuMatch(indexCartaAberta1, indexCartaAberta2) Then
                sender.enabled = False
                LPares.Text = "Pares: " & jogo.GetNumeroPares.ToString & " / " & jogo.GetNumTotalPares.ToString
                If CBForm2.Checked Then
                    JanelaPar.PBImagem.BackgroundImage = jogo.GetImagemCarta(indexCartaAberta1)
                    JanelaPar.LNome.Text = jogo.GetNomeCarta(indexCartaAberta1)
                    Dim posX As Integer = Me.Location.X + (Me.Width - JanelaPar.Width) / 2
                    Dim posY As Integer = Me.Location.Y + (Me.Height - JanelaPar.Height) / 2
                    JanelaPar.Location = New Point(posX, posY)
                    TempoJogo.Stop()
                    JanelaPar.ShowDialog()
                    TempoJogo.Start()
                Else
                    LPares.BackColor = Color.LightBlue
                    TempoPar.Enabled = True
                End If
                If Not jogo.JogoRolando Then
                    TempoJogo.Enabled = False
                    PBTrofeu.Visible = True
                End If
            Else
                PJogo.Controls.Item(indexCartaAberta1).Enabled = True
                TempoCartasAbertas.Enabled = True
            End If
        End If
    End Sub

    Private Sub FechaCartas()
        PJogo.Controls.Item(indexCartaAberta1).BackgroundImage = jogo.GetImagemTraseiraBaralho
        PJogo.Controls.Item(indexCartaAberta1).BackColor = jogo.GetCorFundoTraseiraBaralho
        PJogo.Controls.Item(indexCartaAberta2).BackgroundImage = jogo.GetImagemTraseiraBaralho
        PJogo.Controls.Item(indexCartaAberta2).BackColor = jogo.GetCorFundoTraseiraBaralho
        TempoCartasAbertas.Enabled = False
    End Sub

    Private Sub Tempo_Tick(sender As Object, e As EventArgs) Handles TempoCartasAbertas.Tick
        FechaCartas()
    End Sub

    Private Sub CriarPBs()
        PJogo.Controls.Clear()
        Dim numeroPBsLinha, tamanhoPB As Integer
        numeroPBsLinha = Math.Sqrt(jogo.GetNumTotalCartas)
        tamanhoPB = (668 - 4 * (numeroPBsLinha - 1)) / numeroPBsLinha
        Dim x As Integer = 3
        Dim y As Integer = 3
        Dim cont As Integer = 1
        For i = 0 To numeroPBsLinha - 1
            For j = 0 To numeroPBsLinha - 1
                Dim pb As New PictureBox With {
                    .Name = "PB" & cont.ToString.PadLeft(2, "0"),
                    .Location = New Point(x, y),
                    .Size = New Size(tamanhoPB, tamanhoPB),
                    .BorderStyle = BorderStyle.FixedSingle,
                    .BackgroundImageLayout = ImageLayout.Zoom,
                    .Cursor = Cursors.Hand
                }
                AddHandler pb.Click, AddressOf PB_Click
                PJogo.Controls.Add(pb)
                x += tamanhoPB + 4
                cont += 1
            Next
            x = 3
            y += tamanhoPB + 4
        Next
    End Sub

    Private Sub NovoJogo()
        jogo = New Jogo(CBEscolha.Text, CBNivel.Text)
        If jogo.GetNumTotalCartas <> PJogo.Controls.Count Then CriarPBs()
        PrepararInicio()
        ColocarTemaDeFundo()
    End Sub

    Private Sub PrepararInicio()
        TempoJogo.Enabled = False
        TempoCartasAbertas.Enabled = False
        segundaCartaAberta = False
        If jogo.JogoRolando Then jogo.JogoTerminou()
        LTempo.Text = "00:00"
        LPares.Text = "Pares: 0 / " & jogo.GetNumTotalPares
        LTentativas.Text = "0"
        PBTrofeu.Visible = False
    End Sub

    Private Sub ColocarTemaDeFundo()
        For i = 0 To PJogo.Controls.Count - 1
            PJogo.Controls.Item(i).BackColor = jogo.GetCorFundoTraseiraBaralho
            PJogo.Controls.Item(i).BackgroundImage = jogo.GetImagemTraseiraBaralho
            PJogo.Controls.Item(i).Enabled = True
        Next
    End Sub

    Private Sub TempoCorrido_Tick(sender As Object, e As EventArgs) Handles TempoJogo.Tick
        jogo.Soma1SegundoTempo()
        Dim min As Integer = jogo.GetTempo() \ 60
        Dim seg As Integer = jogo.GetTempo() Mod 60
        LTempo.Text = min.ToString.PadLeft(2, "0") & ":" & seg.ToString.PadLeft(2, "0")
    End Sub

    Private Sub TempoPar_Tick(sender As Object, e As EventArgs) Handles TempoPar.Tick
        LPares.BackColor = SystemColors.Control
        TempoPar.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Brain
        aberturaApp = True
        CBEscolha.SelectedIndex = 0
        CBNivel.SelectedIndex = 0
        aberturaApp = False
        NovoJogo()
    End Sub

    Private Sub BNovo_Click(sender As Object, e As EventArgs) Handles BNovo.Click
        If jogo.JogoRolando Then
            If MsgBox("Tem certeza de que deseja começar um novo jogo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                NovoJogo()
            End If
        Else
            NovoJogo()
        End If
    End Sub

    Private Sub CBNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNivel.SelectedIndexChanged
        If Not aberturaApp Then
            If CBNivel.Text <> jogo.GetStringNivel Then
                If jogo.JogoRolando Then
                    If MsgBox("Tem certeza de que deseja mudar a dificuldade e começar um novo jogo?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        CBNivel.Text = jogo.GetStringNivel
                        Exit Sub
                    End If
                End If
                NovoJogo()
            End If
        End If
    End Sub

    Private Sub CBEscolha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEscolha.SelectedIndexChanged
        If Not aberturaApp Then
            If CBEscolha.Text <> jogo.GetStringBaralho Then
                If jogo.JogoRolando Then
                    If MsgBox("Tem certeza de que deseja mudar o tema e começar um novo jogo?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        CBEscolha.Text = jogo.GetStringBaralho
                        Exit Sub
                    End If
                End If
                NovoJogo()
            End If
        End If
    End Sub

End Class