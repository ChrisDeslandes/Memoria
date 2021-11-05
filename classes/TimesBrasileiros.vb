Public Class TimesBrasileiros
    Inherits Baralho

    Public Sub New()
        nome = "Times Brasileiros"
        imagemTraseira = My.Resources.CBF
        corFundoTraseira = Color.PaleGreen
        cartas = New List(Of Carta) From {
            New Carta("ABC Futebol Clube", My.Resources.ABC),
            New Carta("América Futebol Clube", My.Resources.América),
            New Carta("Atlético Clube Goianiense", My.Resources.Atlético_GO),
            New Carta("Clube Patético Mineiro", My.Resources.Atlético_MG),
            New Carta("Club Athletico Paranaense", My.Resources.Atlético_PR),
            New Carta("Avaí Futebol Clube", My.Resources.Avaí),
            New Carta("Esporte Clube Bahia", My.Resources.Bahia),
            New Carta("Botafogo de Futebol e Regatas", My.Resources.Botafogo),
            New Carta("Red Bull Bragantino", My.Resources.Bragantino),
            New Carta("Ceará Sporting Club", My.Resources.Ceará),
            New Carta("Associação Chapecoense de Futebol", My.Resources.Chapecoense),
            New Carta("Sport Club Corinthians Paulista", My.Resources.Corinthians),
            New Carta("Coritiba Foot Ball Club", My.Resources.Coritiba),
            New Carta("Cruzeiro Esporte Clube", My.Resources.Cruzeiro),
            New Carta("Clube de Regatas do Flamengo", My.Resources.Flamengo),
            New Carta("Fluminense Football Club", My.Resources.Fluminense),
            New Carta("Fortaleza Esporte Clube", My.Resources.Fortaleza),
            New Carta("Grêmio Foot-Ball Porto Alegrense", My.Resources.Grêmio),
            New Carta("Sport Club Internacional", My.Resources.Internacional),
            New Carta("Clube Náutico Capibaribe", My.Resources.Náutico),
            New Carta("Sociedade Esportiva Palmeiras", My.Resources.Palmeiras),
            New Carta("Paraná Clube", My.Resources.Paraná),
            New Carta("Paysandu Sport Club", My.Resources.Paysandu),
            New Carta("Santa Cruz Futebol Clube", My.Resources.Santa_Cruz),
            New Carta("Santos Futebol Clube", My.Resources.Santos),
            New Carta("Sport Club do Recife", My.Resources.Sport),
            New Carta("São Paulo Futebol Clube", My.Resources.São_Paulo),
            New Carta("Tupi Football Club", My.Resources.Tupi),
            New Carta("União Recreativa dos Trabalhadores", My.Resources.URT),
            New Carta("Clube de Regatas Vasco da Gama", My.Resources.Vasco),
            New Carta("Villa Nova Atlético Clube", My.Resources.Villa_Nova),
            New Carta("Esporte Clube Vitória", My.Resources.Vitória)
        }
    End Sub

End Class