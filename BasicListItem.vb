Public Class BasicListItem
    ' This class is to create a basic "Item" that can be used in combo boxes,
    ' list boxes, etc. The object is made up of the visible text and an ID number
    ' which can later be referenced when determining the selected item.

    Public Property Text As String
    Public Property ID As Integer

    Public Overrides Function ToString() As String
        Return Text
    End Function

End Class
