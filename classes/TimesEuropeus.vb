Public Class TimesEuropeus
    Inherits Baralho

    Public Sub New()
        nome = "Times Europeus"
        imagemTraseira = My.Resources.UEFA
        corFundoTraseira = Color.Black
        cartas = New List(Of Carta) From {
            New Carta("Ajax (Holanda)", My.Resources.Ajax),
            New Carta("Arsenal (Inglaterra)", My.Resources.Arsenal),
            New Carta("Atlético de Bilbao (Espanha)", My.Resources.Atlético_de_Bilbao),
            New Carta("Atlético de Madri (Espanha)", My.Resources.Atlético_de_Madri),
            New Carta("Barcelona (Espanha)", My.Resources.Barcelona),
            New Carta("Bayern de Munique (Alemanha)", My.Resources.Bayern),
            New Carta("Benfica (Portugal)", My.Resources.Benfica),
            New Carta("Borussia Dortmund (Alemanha)", My.Resources.Borussia),
            New Carta("Chelsea (Inglaterra)", My.Resources.Chelsea),
            New Carta("CSKA Moscou (Rússia)", My.Resources.CSKA),
            New Carta("Estrela Vermelha (Sérvia)", My.Resources.Estrela_Vermelha),
            New Carta("Inter de Milão (Itália)", My.Resources.Inter_de_Milão),
            New Carta("Juventus (Itália)", My.Resources.Juventus),
            New Carta("Lazio (Itália)", My.Resources.Lazio),
            New Carta("Liverpool (Inglaterra)", My.Resources.Liverpool),
            New Carta("Lokomotiv Moscou (Rússia)", My.Resources.Lokomotiv_Moscow),
            New Carta("Olympique Lyonnais (França)", My.Resources.Lyon),
            New Carta("Manchester City (Inglaterra)", My.Resources.Manchester_City),
            New Carta("Manchester United (Inglaterra)", My.Resources.Manchester_United),
            New Carta("Milan (Itália)", My.Resources.Milan),
            New Carta("Napoli (Itália)", My.Resources.Napoli),
            New Carta("Porto (Portugal)", My.Resources.Porto),
            New Carta("Paris Saint German (França)", My.Resources.PSG),
            New Carta("PSV Eindhoven (Holanda)", My.Resources.PSV),
            New Carta("Real Madri (Espanha)", My.Resources.Real_Madrid),
            New Carta("Real Sociedad (Espanha)", My.Resources.Real_Sociedad),
            New Carta("Roma (Itália)", My.Resources.Roma),
            New Carta("Shakhtar Donetsk (Ucrânia)", My.Resources.Shakhtar_Donetsk),
            New Carta("Sporting (Portugal)", My.Resources.Sporting),
            New Carta("Tottenham (Inglaterra)", My.Resources.Tottenham),
            New Carta("Valência (Espanha)", My.Resources.Valencia),
            New Carta("Viktoria Plzen (República Tcheca)", My.Resources.Viktoria_Plzen)
        }
    End Sub

End Class