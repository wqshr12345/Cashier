Public Class kindlist
    Shared m_instance As kindlist = Nothing
    Private Sub New()
    End Sub
    Public Shared ReadOnly Property Instance() As kindlist
        Get
            If m_instance Is Nothing Then
                m_instance = New kindlist()
            End If
            Return m_instance
        End Get
    End Property
    Private a1 As commodity = New commodity("幸福羊毛衫", 400, "30%")
    Private a2 As commodity = New commodity("幸福男裤", 350, "30%")
    Private a3 As commodity = New commodity("米奇T恤", 200, "30%")
    Private a4 As commodity = New commodity("真维斯衬衫", 180, "30%")
    Private b1 As commodity = New commodity("红蜻蜓女鞋", 500, "30%")
    Private b2 As commodity = New commodity("星期六女鞋", 600, "30%")
    Private b3 As commodity = New commodity("苹果男鞋", 550, "30%")
    Private b4 As commodity = New commodity("袋鼠男鞋", 400, "30%")
    Private b5 As commodity = New commodity("幸福童鞋", 260, "30%")
    Private c1 As commodity = New commodity("鳄鱼皮包", 400, "30%")
    Private c2 As commodity = New commodity("POLO女包", 500, "30%")
    Private c3 As commodity = New commodity("米奇休闲包", 300, "30%")
    Private d1 As commodity = New commodity("小护士大礼包", 100, "30%")
    Private d2 As commodity = New commodity("欧莱雅保湿霜", 300, "30%")
    Private d3 As commodity = New commodity("兰蔻眼霜", 350, "30%")
    Private e1 As commodity = New commodity("睡得香双人被", 400, "30%")
    Private e2 As commodity = New commodity("幸福4件套", 300, "30%")
    Private e3 As commodity = New commodity("舒服服按摩枕", 200, "30%")
    Private a() As commodity = {a1, a2, a3, a4}
    Private b() As commodity = {b1, b2, b3, b4, b5}
    Private c() As commodity = {c1, c2, c3}
    Private d() As commodity = {d1, d2, d3}
    Private e() As commodity = {e1, e2, e3}
    Private clothing As kind = New kind("服装", a)
    Private shoe As kind = New kind("鞋子", b)
    Private bag As kind = New kind("箱包", c)
    Private cosmetics As kind = New kind("化妆品", d)
    Private bedding As kind = New kind("床上用品", e)
    Private mjutilist() As kind = {clothing, shoe, bag, cosmetics, bedding}
    Function Getkind(name As String) As kind
        For Each kindd In jutilist
            If kindd.Name.Equals(name) Then
                Return kindd
            End If
        Next
        Return Nothing
    End Function
    Function Getcommodity(name As String) As commodity
        For Each kindd In jutilist
            If kindd.GetCommodity(name) IsNot Nothing Then
                Return kindd.GetCommodity(name)
            End If
        Next
        Return Nothing
    End Function
    Sub AllFirstTrue()
        For Each kindd In jutilist
            For Each commodity In kindd.CommodityList
                commodity.First = True
            Next
        Next
    End Sub
    Property jutilist() As kind()
        Get
            Return mjutilist
        End Get
        Set(value As kind())

        End Set
    End Property
End Class
