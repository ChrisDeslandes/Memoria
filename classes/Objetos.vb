Public Class Objetos
    Inherits Baralho

    Public Sub New()
        nome = "Objetos"
        imagemTraseira = My.Resources.Objetos
        corFundoTraseira = Color.LightGray
        cartas = New List(Of Carta) From {
            New Carta("Cadeado", My.Resources.Cadeado),
            New Carta("Caixa de Correio", My.Resources.Caixa_de_Correio),
            New Carta("Câmera de Vídeo", My.Resources.Câmera_de_Vídeo),
            New Carta("Câmera Fotográfica", My.Resources.Câmera_Fotográfica),
            New Carta("Caneta", My.Resources.Caneta),
            New Carta("Chave de Boca", My.Resources.Chave_de_Boca),
            New Carta("Chave", My.Resources.Chave),
            New Carta("Chuveiro", My.Resources.Chuveiro),
            New Carta("Cigarro", My.Resources.Cigarro),
            New Carta("Clipe", My.Resources.Clipe),
            New Carta("Dinheiro", My.Resources.Dinheiro),
            New Carta("Fone de Ouvido", My.Resources.Fone_de_Ouvido),
            New Carta("Guitarra", My.Resources.Guitarra),
            New Carta("Lâmpada", My.Resources.Lâmpada),
            New Carta("Lanterna", My.Resources.Lanterna),
            New Carta("Lápis", My.Resources.Lápis),
            New Carta("Livro", My.Resources.Livro),
            New Carta("Lupa", My.Resources.Lupa),
            New Carta("Martelo", My.Resources.Martelo),
            New Carta("Microfone", My.Resources.Microfone),
            New Carta("Microscópio", My.Resources.Microscópio),
            New Carta("Mouse", My.Resources.Mouse),
            New Carta("Nota Musical", My.Resources.Nota_Musical),
            New Carta("Notebook", My.Resources.Notebook),
            New Carta("Parafuso e Porca", My.Resources.Parafuso_e_Porca),
            New Carta("Rádio", My.Resources.Rádio),
            New Carta("Tachinha", My.Resources.Tachinha),
            New Carta("Telefone", My.Resources.Telefone),
            New Carta("Telescópio", My.Resources.Telescópio),
            New Carta("Televisão", My.Resources.Televisão),
            New Carta("Tesoura", My.Resources.Tesoura),
            New Carta("Vela", My.Resources.Vela)
        }
    End Sub

End Class