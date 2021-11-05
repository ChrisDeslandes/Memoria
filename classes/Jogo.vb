Public Class Jogo

    Private ReadOnly novoNivel As Nivel
    Private ReadOnly novoBaralho As Baralho
    Private jogoIniciado As Boolean
    Private nTentativas As Integer
    Private nPares As Integer
    Private tempoSeg As Integer

    Public Sub New(temaStr As String, nivelStr As String)
        nTentativas = 0
        nPares = 0
        jogoIniciado = False
        tempoSeg = 0
        novoNivel = Nivel.CriarNivel(nivelStr)
        novoBaralho = Baralho.CriarBaralho(temaStr, novoNivel.GetNumTotalPares())
    End Sub

    Public Sub Soma1Tentativa()
        nTentativas += 1
    End Sub

    Public Function DeuMatch(index1 As Integer, index2 As Integer) As Boolean
        If novoBaralho.GetNomeCarta(index1) = novoBaralho.GetNomeCarta(index2) Then
            nPares += 1
            If nPares = novoNivel.GetNumTotalPares() Then JogoTerminou()
            Return True
        End If
        Return False
    End Function

    Public Function GetNumeroPares() As String
        Return nPares
    End Function

    Public Function GetNumeroTentativas() As Integer
        Return nTentativas
    End Function

    Public Function JogoRolando() As Boolean
        Return jogoIniciado
    End Function

    Public Sub JogoIniciou()
        jogoIniciado = True
    End Sub

    Public Sub JogoTerminou()
        jogoIniciado = False
    End Sub

    Public Function GetNumTotalCartas() As Integer
        Return novoNivel.GetNumeroCartas()
    End Function

    Public Function GetNumTotalPares() As Integer
        Return novoNivel.GetNumTotalPares()
    End Function

    Public Function GetStringNivel() As String
        Return novoNivel.GetNome()
    End Function

    Public Function GetStringBaralho() As String
        Return novoBaralho.GetNome()
    End Function

    Public Function GetCorFundoTraseiraBaralho() As Color
        Return novoBaralho.GetCorFundoTraseira()
    End Function

    Public Function GetImagemTraseiraBaralho() As Image
        Return novoBaralho.GetImagemTraseira()
    End Function

    Public Function GetImagemCarta(index As Integer) As Image
        Return novoBaralho.GetImagemCarta(index)
    End Function

    Public Function GetNomeCarta(index As Integer) As String
        Return novoBaralho.GetNomeCarta(index)
    End Function

    Public Sub Soma1SegundoTempo()
        tempoSeg += 1
    End Sub

    Public Function GetTempo() As Integer
        Return tempoSeg
    End Function

End Class