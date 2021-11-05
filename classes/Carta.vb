Public Class Carta

    Private ReadOnly nome As String
    Private ReadOnly imagem As Image

    Public Sub New(nome As String, imagem As Image)
        Me.nome = nome
        Me.imagem = imagem
    End Sub

    Public Function GetNome()
        Return nome
    End Function

    Public Function GetImagem()
        Return imagem
    End Function

End Class
