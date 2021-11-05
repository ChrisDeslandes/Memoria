Public Class Baralho

    Protected nome As String
    Protected cartas As List(Of Carta)
    Protected imagemTraseira As Image
    Protected corFundoTraseira As Color

    Public Shared Function CriarBaralho(tema As String, nTotalPares As Integer) As Baralho
        Dim novoBaralho As Baralho = Nothing
        If tema = "Aleatório" Then tema = GetBaralhoAleatorio()
        Select Case tema
            Case "Bandeiras de Países"
                novoBaralho = New BandeirasPaises
            Case "Comidas e Bebidas"
                novoBaralho = New ComidasBebidas
            Case "Objetos"
                novoBaralho = New Objetos
            Case "Times Brasileiros"
                novoBaralho = New TimesBrasileiros
            Case "Times da NFL"
                novoBaralho = New TimesNFL
            Case "Times Europeus"
                novoBaralho = New TimesEuropeus
        End Select
        novoBaralho = TratarBaralho(novoBaralho, nTotalPares)
        Return Embaralhar(novoBaralho)
    End Function

    Private Shared Function GetBaralhoAleatorio() As String
        Dim baralhosDisponiveis() As String
        baralhosDisponiveis = {"Bandeiras de Países", "Comidas e Bebidas", "Objetos", "Times Brasileiros", "Times da NFL", "Times Europeus"}
        Dim rnd As New Random
        Dim escolhaAleatoria As Integer
        escolhaAleatoria = rnd.Next(baralhosDisponiveis.Count)
        Return baralhosDisponiveis(escolhaAleatoria)
    End Function

    Private Shared Function TratarBaralho(baralho As Baralho, nTotalPares As Integer) As Baralho
        Dim auxCartas As New List(Of Carta)
        baralho.cartas = baralho.GetCartas()
        For i = 0 To nTotalPares - 1
            Dim escolha As Integer = New Random().Next(baralho.cartas.Count)
            auxCartas.Add(baralho.cartas(escolha))
            auxCartas.Add(baralho.cartas(escolha))
            baralho.cartas.RemoveAt(escolha)
        Next
        baralho.cartas = auxCartas
        Return baralho
    End Function

    Private Shared Function Embaralhar(baralho As Baralho) As Baralho
        Dim cartasEmbaralhadas As New List(Of Carta)
        Dim rnd As New Random
        For i = 0 To baralho.cartas.Count - 1
            Dim escolha As Integer = rnd.Next(baralho.cartas.Count)
            cartasEmbaralhadas.Add(baralho.cartas(escolha))
            baralho.cartas.RemoveAt(escolha)
        Next
        baralho.cartas = cartasEmbaralhadas
        Return baralho
    End Function

    Public Function GetImagemTraseira() As Image
        Return imagemTraseira
    End Function

    Public Function GetCorFundoTraseira() As Color
        Return corFundoTraseira
    End Function

    Public Function GetNome() As String
        Return nome
    End Function

    Public Function GetImagemCarta(index As Integer) As Image
        Return cartas(index).GetImagem()
    End Function

    Public Function GetNomeCarta(index As Integer) As String
        Return cartas(index).GetNome()
    End Function

End Class