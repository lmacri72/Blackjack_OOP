''' <summary>
''' An Object of class PlayingCard represents one of the 52 cards in a 
''' standard deck Of playing cards. Each card has a suit, rank, and a value.
''' </summary>
''' <author>Mr M</author>
''' <Date>17/04/20</Date>
Public Class PlayingCard
    Private Suit As String
    Private Value As Integer
    Private Rank As String

    ''' <summary>
    '''     Constructor takes a Rank, Suit and Value such as Queen, Heart, 10
    ''' </summary>
    ''' <param name="Rank">The rank of a card within the suit.</param>
    ''' <param name="Suit">Diamonds, Clubs, Hearts, or Spades</param>
    ''' <param name="Value">The value of the card according to Blackjack rules.</param>
    Public Sub New(Rank As String, Suit As String, Value As Integer)
        Me.Rank = Rank
        Me.Suit = Suit
        Me.Value = Value
    End Sub

    Public Function GetSuit() As String
        Return Me.Suit

    End Function

    Public Function GetValue() As Integer
        Return Me.Value

    End Function

    Public Function GetRank() As String
        Return Me.Rank

    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0} of {1}", Me.Rank, Me.Suit)

    End Function
End Class
