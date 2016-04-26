Public Class BasicListItem
    Public Property Text As String
    Public Property ID As Integer

    Public Overrides Function ToString() As String
        Return Text
    End Function

End Class
