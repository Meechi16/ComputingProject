Imports System.Drawing
Public Class Table
    Public student1 As String
    Public coordinate As Point
    Public width As Integer
    Public height As Integer

    Public Sub New(ByVal s1 As String, ByRef xCoord As Integer, ByVal yCoord As Integer)
        Me.width = 80
        Me.height = 40
        Me.coordinate = New Point(xCoord, yCoord)
        Me.student1 = s1

    End Sub

    Public Sub New()
        Me.width = 80
        Me.height = 40
        Me.coordinate = New Point(0, 0)
        Me.student1 = ""
    End Sub

    Public Function getCoord() As Point
        Return Me.coordinate
    End Function

    Public Sub setCoord(ByVal newPoint As Point)
        Me.coordinate = newPoint
    End Sub

    Public Function getWidth() As Integer
        Return Me.width
    End Function

    Public Function getHeight() As Integer
        Return Me.height
    End Function

    Public Function getName() As String
        Return Me.student1
    End Function
    Public Function addtables()
        Me.width = 80
        Me.height = 40
        Me.coordinate = New Point(0, 0)
        Me.student1 = ""
        Return width & height & student1
    End Function

End Class