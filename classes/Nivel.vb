Public Class Nivel

    Protected nome As String
    Protected numeroPares As Integer

    Public Shared Function CriarNivel(nivel As String) As Nivel
        Dim novoNivel As Nivel = Nothing
        Select Case nivel
            Case "Fácil (4x4)"
                novoNivel = New Facil
            Case "Intermediário (6x6)"
                novoNivel = New Intermediario
            Case "Difícil (8x8)"
                novoNivel = New Dificil
        End Select
        Return novoNivel
    End Function

    Public Function GetNome() As String
        Return nome
    End Function

    Public Function GetNumTotalPares() As Integer
        Return numeroPares
    End Function

    Public Function GetNumeroCartas() As Integer
        Return 2 * numeroPares
    End Function

End Class
