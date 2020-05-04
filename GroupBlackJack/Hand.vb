Imports System.Text
''' <summary>
'''    This class represents a blackjack hand. This will hold a
'''    maximum of 6 PlayingCard objects and keeps track of how
'''    many cards the hand has, and its value.
''' </summary>
''' <author>Mr M</author>
''' <Date>17/04/20</Date>
Public Class Hand
    Private Cards(5) As PlayingCard
    Private NumberOfCards As Integer = 0
    Private HandValue As Integer = 0

    Public Sub New()


    End Sub

    ''' <summary>
    '''  Adds a card to the hand.
    ''' </summary>
    ''' <param name="Card">The PlayingCard to be added to the hand.</param>
    ''' <returns>Nothing</returns>
    Public Function AddCard(Card As PlayingCard)
        Me.Cards(NumberOfCards) = Card
        NumberOfCards += 1
        SetHandValue()
        Return Nothing
    End Function

    ''' <summary>
    '''   Returns the card from the hand object at index Index.
    ''' </summary>
    ''' <param name="Index">The Playing card index to return.</param>
    ''' <returns>The PlayingCard at index Index.</returns>
    ''' <see cref="PlayingCard">PlayingCard</see>
    Public Function GetCard(Index As Integer) As PlayingCard
        Return Me.Cards(Index)

    End Function

    ''' <summary>
    '''   
    ''' </summary>
    ''' <returns>The value of the cards in the hand.</returns>
    Public Function GetHandValue() As Integer
        Return Me.HandValue
    End Function

    ''' <summary>
    '''   Calculates the value of the hand.
    ''' </summary>
    Private Function SetHandValue()
        Dim HasAce As Boolean = False
        Dim Total As Integer = 0

        ' Add values from each card assuming an ace is 1
        For i As Integer = 0 To Me.NumberOfCards - 1
            Dim c As PlayingCard
            c = Me.GetCard(i)

            ' If an ace is in the hand, raise a flag
            If c.GetValue() = 1 Then
                HasAce = True
            End If

            ' Add to hand total
            Total += c.GetValue
        Next

        ' Check to see if we can add the extra 10 for the ace.
        If HasAce = True And Total + 10 <= 21 Then
            Total += 10
        End If

        Me.HandValue = Total
        Return Nothing
    End Function


    ''' <summary>
    '''     Returns the Hand object as a string. This is so we can display
    '''     the card as "Ace of Spades" or "7 of Hearts"
    ''' </summary>
    ''' <returns>The hand object represented as a string.</returns>
    Public Function GetHand() As String
        If Cards(0) Is Nothing Then
            Return "Hand is empty."

        End If

        ' Need to Import System.Text
        Dim StringHand As StringBuilder = New StringBuilder()

        ' Add card to string and a vbcrlf
        For i As Integer = 0 To NumberOfCards - 1
            StringHand.Append(Cards(i).ToString())
            StringHand.Append(vbCrLf)

        Next

        Return StringHand.ToString()

    End Function

    ''' <summary>
    '''     When the hand is finished, it will need to bel cleared.
    ''' </summary>
    ''' <returns>Deletes all the cards from the hand.</returns>
    Public Function ClearHand()
        Array.Clear(Cards, 0, Cards.Length)
        HandValue = 0
        Me.NumberOfCards = 0
        Return Nothing

    End Function

    ''' <summary>
    '''     Checks if a hand has a blackjack.
    ''' </summary>
    ''' <returns>True iff the hand value is 21 and the number of cards is 2. False otherwise.</returns>
    Public Function CheckBlackJack() As Boolean
        If Me.GetHandValue = 21 And Me.NumberOfCards = 2 Then
            Return True
        End If

        Return False
    End Function
End Class
