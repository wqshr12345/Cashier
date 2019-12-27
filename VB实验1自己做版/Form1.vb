Public Class Form1
    Dim counter As Integer = 0
    Dim nowkind As kind
    Dim nowcommodity As commodity
    Public mkindlist As kindlist = kindlist.Instance
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add(mkindlist.jutilist(0).Name)
        ComboBox1.Items.Add(mkindlist.jutilist(1).Name)
        ComboBox1.Items.Add(mkindlist.jutilist(2).Name)
        ComboBox1.Items.Add(mkindlist.jutilist(3).Name)
        ComboBox1.Items.Add(mkindlist.jutilist(4).Name)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        Dim name As String = ComboBox1.Text
        Dim names() As String = {""}
        If name.Equals(mkindlist.jutilist(0).Name) Then
            nowkind = mkindlist.jutilist(0)
            names = mkindlist.jutilist(0).GetNames
        ElseIf name.Equals(mkindlist.jutilist(1).Name) Then
            nowkind = mkindlist.jutilist(1)
        ElseIf name.Equals(mkindlist.jutilist(2).Name) Then
            nowkind = mkindlist.jutilist(2)
        ElseIf name.Equals(mkindlist.jutilist(3).Name) Then
            nowkind = mkindlist.jutilist(3)
        ElseIf name.Equals(mkindlist.jutilist(4).Name) Then
            nowkind = mkindlist.jutilist(4)
        End If
        If nowkind Is Nothing Then

        Else names = nowkind.GetNames
        End If
        ListBox1.Items.AddRange(names)
    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick
        '得到当前所选择的商品
        nowcommodity = nowkind.GetCommodity(ListBox1.SelectedItem.ToString())
        If nowcommodity.First = True Then
            nowcommodity.SoldCount()
        End If
        '在上面的框里面把当前商品的各个属性写入(如名字价格等)
        NameTextBox.Text = nowcommodity.Name
        NumberTextBox.Text = "1"
        PriceTextBox.Text = nowcommodity.Price
        If nowcommodity.First = True And (nowcommodity.CountNumber >= 0) Then
            CountTextBox.Text = nowcommodity.Count
        Else
            CountTextBox.Text = "0%"
        End If
        Dim mCountDouble As Double = Convert.ToDouble(CountTextBox.Text.Replace("%", "")) / 100
        nowcommodity.First = False
        '将这一系列属性添加到表格里面
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Rows.Add({nowcommodity.Name, "1", nowcommodity.Price, CountTextBox.Text, nowcommodity.Price * (1 - mCountDouble)})
        '计算总额的和并将其写入“应付款”里面
        Dim count As Integer = Me.DataGridView1.Rows.Count
        Dim sum As Double = 0
        For i = 0 To count - 1
            sum += Val(Me.DataGridView1.Item("总额", i).Value)
        Next
        TextBox7.Text = Convert.ToString(sum)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox9.Text = "付款不足" Then
            MsgBox("钱不够，不能结账！")
        ElseIf Convert.ToInt32(TextBox9.Text) > 100 Then
            MsgBox("不合理的收款，不能结账！")
        ElseIf TextBox9.Text = "" Then
            MsgBox("请先计算找零，再结账！")
        Else
            MsgBox("结账成功！")
            NameTextBox.Text = ""
            NumberTextBox.Text = ""
            PriceTextBox.Text = ""
            CountTextBox.Text = ""
            DataGridView1.Rows.Clear()
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            mkindlist.AllFirstTrue()
        End If
    End Sub

    Private Sub 请输入商品名字ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 请输入商品名字ToolStripMenuItem.Click
        Dim frm2 As New Form2()
        frm2.Show()
    End Sub

    Private Sub 修改商品种类名字ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改商品种类名字ToolStripMenuItem.Click
        Dim frm3 As New Form3()
        frm3.Show()
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "" Then
            MsgBox("请输入实付款后再进行计算！")
        ElseIf Convert.ToInt32(TextBox7.Text) > Convert.ToInt32(TextBox8.Text) Then
            TextBox9.Text = "付款不足"
        Else
            TextBox9.Text = Convert.ToString(Convert.ToInt32(TextBox8.Text) - Convert.ToInt32(TextBox7.Text))
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
