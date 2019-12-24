Public Class kind
    Private mName As String
    Private mCommodityList() As commodity

    Public Sub New(ByVal Name As String, ByVal commoditylist As commodity())
        Me.mName = Name
        Me.mCommodityList = commoditylist
    End Sub
    Property Name() As String
        Get
            Return Me.mName
        End Get
        Set(value As String)
            Me.mName = value
        End Set
    End Property
    Property CommodityList() As commodity()
        Get
            Return Me.mCommodityList
        End Get
        Set(value As commodity())
            Me.mCommodityList = value
        End Set
    End Property
    Function GetNames() As String()
        Dim n(mCommodityList.Length - 1) As String
        Dim i As Integer = 0
        For Each Commodity In mCommodityList
            n(i) = Commodity.Name
            i += 1
        Next
        Return n
    End Function
    Function GetCommodity(ByVal name As String) As commodity
        For Each Commodity In mCommodityList
            If Commodity.Name.Equals(name) Then
                Return Commodity
            End If
        Next
        Return Nothing
    End Function
End Class
