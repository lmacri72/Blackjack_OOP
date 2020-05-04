''' <summary>
''' The class represents a standard deck of playing cards - No Jokers.
''' </summary>
''' <author>Mr M</author>
''' <Date>17/04/20</Date>
Public Class CardDeck
    Private Cards(51) As PlayingCard
    Private CurrentCard = 0

    Public Sub New()
        Dim Suits() As String = {"Diamonds", "Clubs", "Hearts", "Spades"}
        Dim Ranks() As String = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"}
        Dim Values() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10}

        ' Create 52 new cards for the deck.
        For i As Integer = 0 To 3
            For j = 0 To 12
                Dim TempCard As New PlayingCard(Ranks(j), Suits(i), Values(j))
                Me.Cards(Me.CurrentCard) = TempCard
                Me.CurrentCard += 1
            Next
        Next

        Me.CurrentCard = 51

    End Sub

    Public Function Shuffle()
        Dim FirstCard, SecondCard As Integer
        Dim TempCard As PlayingCard
        Dim r As New Random()

        ' Swap each card in the deck with another random card.
        For FirstCard = 0 To Me.Cards.Length - 1
            SecondCard = r.Next(0, 51)
            TempCard = Me.Cards(FirstCard)

            Me.Cards(FirstCard) = Me.Cards(SecondCard)
            Me.Cards(SecondCard) = TempCard
        Next

        ' Reset top card
        CurrentCard = 51
        Return Nothing
    End Function

    Public Function DealCard() As PlayingCard
        ' Remove a card from the top of the deck
        Dim TempCard As PlayingCard
        TempCard = Me.Cards(Me.CurrentCard)
        Me.CurrentCard -= 1

        ' And return it.
        Return TempCard
    End Function

End Class
