Public Class Dangnhap


    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        If txtdangnhap.Text = "admin" And txtmatkhau.Text = "admin" Then
            MessageBox.Show("Đăng nhập thành công", "Thông bào đăng nhập", MessageBoxButtons.OK)

            'Mở Main
            mainquanlybanhang.Show()
        Else
            MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK)
        End If
        'K co mk tk
        If txtdangnhap.Text = "" Or txtmatkhau.Text = "" Then
            MessageBox.Show("Vui lòng điền tài khoản hoặc mật khẩu", "Lỗi tài khoản mật khẩu", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()
    End Sub
End Class
