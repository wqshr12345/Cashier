Public Class Form2
    Dim nowcommodity As commodity
    Dim nowkindlist As kindlist = kindlist.Instance
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nowcommodity = nowkindlist.Getcommodity(TextBox1.Text)
        If nowcommodity IsNot Nothing Then
            TextBox2.Text = nowcommodity.Count
            TextBox3.Text = Convert.ToString(nowcommodity.Price)
            TextBox4.Text = nowcommodity.Name
        Else
            MsgBox("查无此商品，请输入正确的名字！")
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nowcommodity.Name = TextBox4.Text
        nowcommodity.Price = Convert.ToDouble(TextBox3.Text)
        nowcommodity.Count = TextBox2.Text
        MsgBox("修改成功！")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class