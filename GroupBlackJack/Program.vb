Imports System

Module Program
    Sub Main(args As String())

        ' Create And shuffle a deck of cards
        Dim Deck As New CardDeck()
        Deck.Shuffle()

        ' Create Player And dealer
        Console.WriteLine("Please enter your name.")
        Dim PlayerName As String = Console.ReadLine()
        Dim Player1 As New Player(PlayerName)
        Dim Dealer As New Player("Dealer")

        ' Create two BlackjackHands, PlayerHand And DealerHand
        Dim PlayerHand As New Hand()
        Dim DealerHand As New Hand()

        ' Keep playing until the player quits Or a player reaches 20 points
        Deck.Shuffle()
        '   Deal two cards into each hand
        PlayerHand.AddCard(Deck.DealCard())
        DealerHand.AddCard(Deck.DealCard())
        PlayerHand.AddCard(Deck.DealCard())
        DealerHand.AddCard(Deck.DealCard())

        '   Check If dealer has blackjack (if so, game ends)
        '   Check If user has blackjack (if so, game ends)
        '   User draws cards (If user goes over 21, game ends)
        '   Dealer draws cards
        '   Check for winner
        ' Loop

        ' End Game
    End Sub
End Module
