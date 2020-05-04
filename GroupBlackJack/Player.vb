''' <summary>
'''   This class represents a single player with a name and score.
''' </summary>
''' <author>Mr M</author>
''' <Date>17/04/20</Date>
Public Class Player
    Private ReadOnly PlayerName As String
    Private Score As Integer

    Public Sub New(Name As String)
        Me.PlayerName = Name
        Me.Score = 0
    End Sub

    Public Function GetScore() As Integer
        Return Me.Score

    End Function

    Public Function GetName() As String
        Return Me.PlayerName

    End Function

    Public Function AddScore(Value As Integer)
        Me.Score += Value
        Return Nothing
    End Function

End Class
