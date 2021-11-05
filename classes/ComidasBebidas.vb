Public Class ComidasBebidas
    Inherits Baralho

    Public Sub New()
        nome = "Comidas e Bebidas"
        imagemTraseira = My.Resources.Comidas_e_Bebidas
        corFundoTraseira = Color.PaleTurquoise
        cartas = New List(Of Carta) From {
            New Carta("Abacate", My.Resources.Abacate),
            New Carta("Abacaxi", My.Resources.Abacaxi),
            New Carta("Bacon", My.Resources.Bacon),
            New Carta("Banana", My.Resources.Banana),
            New Carta("Batata Frita", My.Resources.Batata_Frita),
            New Carta("Bolo de Aniversário", My.Resources.Bolo_de_Aniversário),
            New Carta("Cachorro Quente", My.Resources.Cachorro_Quente),
            New Carta("Café", My.Resources.Café),
            New Carta("Carne", My.Resources.Carne),
            New Carta("Cenoura", My.Resources.Cenoura),
            New Carta("Cereja", My.Resources.Cereja),
            New Carta("Cerveja", My.Resources.Cerveja),
            New Carta("Chocolate", My.Resources.Chocolate),
            New Carta("Coco", My.Resources.Coco),
            New Carta("Coquetel", My.Resources.Coquetel),
            New Carta("Espaguete", My.Resources.Espaguete),
            New Carta("Frango", My.Resources.Frango),
            New Carta("Kiwi", My.Resources.Kiwi),
            New Carta("Maçã", My.Resources.Maçã),
            New Carta("Melancia", My.Resources.Melancia),
            New Carta("Mexerica", My.Resources.Mexerica),
            New Carta("Morango", My.Resources.Morango),
            New Carta("Ovo", My.Resources.Ovo),
            New Carta("Pão", My.Resources.Pão),
            New Carta("Pipoca", My.Resources.Pipoca),
            New Carta("Pizza", My.Resources.Pizza),
            New Carta("Queijo", My.Resources.Queijo),
            New Carta("Sanduíche", My.Resources.Sanduíche),
            New Carta("Sorvete", My.Resources.Sorvete),
            New Carta("Uísque", My.Resources.Uísque),
            New Carta("Uva", My.Resources.Uva),
            New Carta("Vinho", My.Resources.Vinho)
        }
    End Sub

End Class