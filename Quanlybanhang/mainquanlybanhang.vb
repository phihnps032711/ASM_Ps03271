Public Class mainquanlybanhang

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Khachhang.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Sanpham.Show()
    End Sub

    Private Sub btndangxuat_Click(sender As Object, e As EventArgs) Handles btndangxuat.Click
        Dangnhap.Show()
        Me.Close()
    End Sub
End Class