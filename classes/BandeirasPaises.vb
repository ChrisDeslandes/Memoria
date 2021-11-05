Public Class BandeirasPaises
    Inherits Baralho

    Public Sub New()
        nome = "Bandeiras de Países"
        imagemTraseira = My.Resources.Terra
        corFundoTraseira = Color.Black
        cartas = New List(Of Carta) From {
            New Carta("Alemanha", My.Resources.Alemanha),
            New Carta("Arábia Saudita", My.Resources.Arábia_Saudita),
            New Carta("Argentina", My.Resources.Argentina),
            New Carta("Austrália", My.Resources.Austrália),
            New Carta("Brasil", My.Resources.Brasil),
            New Carta("Canadá", My.Resources.Canadá),
            New Carta("Colômbia", My.Resources.Colômbia),
            New Carta("Coréia do Sul", My.Resources.Coréia_do_Sul),
            New Carta("Croácia", My.Resources.Croácia),
            New Carta("Espanha", My.Resources.Espanha),
            New Carta("Estados Unidos", My.Resources.Estados_Unidos),
            New Carta("Finlândia", My.Resources.Finlândia),
            New Carta("França", My.Resources.França),
            New Carta("Grécia", My.Resources.Grécia),
            New Carta("Holanda", My.Resources.Holanda),
            New Carta("Irlanda", My.Resources.Irlanda),
            New Carta("Israel", My.Resources.Israel),
            New Carta("Itália", My.Resources.Itália),
            New Carta("Japão", My.Resources.Japão),
            New Carta("Marrocos", My.Resources.Marrocos),
            New Carta("México", My.Resources.México),
            New Carta("Nigéria", My.Resources.Nigéria),
            New Carta("Noruega", My.Resources.Noruega),
            New Carta("Polônia", My.Resources.Polônia),
            New Carta("Portugal", My.Resources.Portugal),
            New Carta("Reino Unido", My.Resources.Reino_Unido),
            New Carta("República Tcheca", My.Resources.República_Tcheca),
            New Carta("Romênia", My.Resources.Romênia),
            New Carta("Rússia", My.Resources.Rússia),
            New Carta("Suécia", My.Resources.Suécia),
            New Carta("Tunísia", My.Resources.Tunísia),
            New Carta("Uruguai", My.Resources.Uruguai)
        }
    End Sub

End Class