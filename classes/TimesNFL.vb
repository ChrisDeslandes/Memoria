Public Class TimesNFL
    Inherits Baralho

    Public Sub New()
        nome = "Times da NFL"
        imagemTraseira = My.Resources.NFL
        corFundoTraseira = Color.Gold
        cartas = New List(Of Carta) From {
            New Carta("Chicago Bears", My.Resources.Bears),
            New Carta("Cincinnati Bengals", My.Resources.Bengals),
            New Carta("Buffalo Bills", My.Resources.Bills),
            New Carta("Denver Broncos", My.Resources.Broncos),
            New Carta("Cleveland Browns", My.Resources.Browns),
            New Carta("Tampa Bay Buccaneers", My.Resources.Buccaneers),
            New Carta("Arizona Cardinals", My.Resources.Cardinals),
            New Carta("Los Angeles Chargers", My.Resources.Chargers),
            New Carta("Kansas City Chiefs", My.Resources.Chiefs),
            New Carta("Indianapolis Colts", My.Resources.Colts),
            New Carta("Dallas Cowboys", My.Resources.Cowboys),
            New Carta("Miami Dolphins", My.Resources.Dolphins),
            New Carta("Philadelphia Eagles", My.Resources.Eagles),
            New Carta("Atlanta Falcons", My.Resources.Falcons),
            New Carta("New York Giants", My.Resources.Giants),
            New Carta("Jacksonville Jaguars", My.Resources.Jaguars),
            New Carta("New York Jets", My.Resources.Jets),
            New Carta("Detroit Lions", My.Resources.Lions),
            New Carta("Green Bay Packers", My.Resources.Packers),
            New Carta("Carolina Panthers", My.Resources.Panthers),
            New Carta("New England Patriots", My.Resources.Patriots),
            New Carta("Oakland Raiders", My.Resources.Raiders),
            New Carta("Los Angeles Rams", My.Resources.Rams),
            New Carta("Baltimore Ravens", My.Resources.Ravens),
            New Carta("Washington Football Team", My.Resources.Washington),
            New Carta("New Orleans Saints", My.Resources.Saints),
            New Carta("Seattle Seahawks", My.Resources.Seahawks),
            New Carta("Pittsburgh Steelers", My.Resources.Steelers),
            New Carta("Houston Texans", My.Resources.Texans),
            New Carta("Tennessee Titans", My.Resources.Titans),
            New Carta("Minnesota Vikings", My.Resources.Vikings),
            New Carta("San Francisco 49ers", My.Resources._49ers)
        }
    End Sub

End Class