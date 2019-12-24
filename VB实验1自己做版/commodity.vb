Imports VB实验1自己做版

Public Class commodity
    Private mName As String    Private mNumber As Integer    Private mPrice As Integer
    Private mCount As String
    Private mCountNumber As Integer = 5
    Private mFirst As Boolean = True
    Public Sub New(ByVal Name As String, ByVal Price As Integer, ByVal Count As String)        Me.mName = Name        Me.mPrice = Price        Me.mCount = Count    End Sub    Property Name() As String
        Get
            Return Me.mName
        End Get
        Set(value As String)
            Me.mName = value
        End Set
    End Property
    Property Price() As Integer
        Get
            Return Me.mPrice
        End Get
        Set(value As Integer)
            Me.mPrice = value
        End Set
    End Property
    Property CountNumber() As Integer
        Get
            Return Me.mCountNumber
        End Get
        Set(value As Integer)
            Me.mCountNumber = value
        End Set
    End Property
    Property First() As Boolean
        Get
            Return Me.mFirst
        End Get
        Set(value As Boolean)
            Me.mFirst = value
        End Set
    End Property
    Property Count() As String
        Get
            Return Me.mCount
        End Get
        Set(value As String)
            Me.mCount = value
        End Set
    End Property
    Sub SoldCount()
        Me.mCountNumber -= 1
    End Sub
End Class
