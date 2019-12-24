Public Class Form3
    Dim nowkindlist As kindlist = kindlist.Instance
    Dim nowkind As kind
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nowkind = nowkindlist.Getkind(ComboBox1.Text)
        If TextBox2.Text = "" Then
            MsgBox("请输入有效的名字！")
        Else
            nowkind.Name = TextBox2.Text
        End If
        Form1.ComboBox1.Items.Clear()
        Form1.ComboBox1.Items.Add(nowkindlist.jutilist(0).Name)
        Form1.ComboBox1.Items.Add(nowkindlist.jutilist(1).Name)
        Form1.ComboBox1.Items.Add(nowkindlist.jutilist(2).Name)
        Form1.ComboBox1.Items.Add(nowkindlist.jutilist(3).Name)
        Form1.ComboBox1.Items.Add(nowkindlist.jutilist(4).Name)
        MsgBox("修改成功！")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add(nowkindlist.jutilist(0).Name)
        ComboBox1.Items.Add(nowkindlist.jutilist(1).Name)
        ComboBox1.Items.Add(nowkindlist.jutilist(2).Name)
        ComboBox1.Items.Add(nowkindlist.jutilist(3).Name)
        ComboBox1.Items.Add(nowkindlist.jutilist(4).Name)
    End Sub
End Class