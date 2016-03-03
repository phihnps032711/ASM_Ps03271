Imports System.Data.SqlClient
Imports System.Data

Public Class Khachhang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=ASMINF205PS03271.mssql.somee.com;packet size=4096;user id=phihnps032711_SQLLogin_1;pwd=5rs932krxz;data source=ASMINF205PS03271.mssql.somee.com;persist security info=False;initial catalog=ASMINF205PS03271"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub themthongtinkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hienthi As New Class1
        dgvtnkh.DataSource = hienthi.Loadkhachhang.Tables(0)
    End Sub




    Private Sub dgvtnkh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtnkh.CellContentClick
        Try
            Dim click As Integer = dgvtnkh.CurrentCell.RowIndex
            txtmakh.Text = dgvtnkh.Item(0, click).Value
            txttenkh.Text = dgvtnkh.Item(1, click).Value
            txtgtkh.Text = dgvtnkh.Item(2, click).Value
            txtdiachi.Text = dgvtnkh.Item(3, click).Value
            txtemail.Text = dgvtnkh.Item(4, click).Value
            txtsdt.Text = dgvtnkh.Item(5, click).Value

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnthem2_Click(sender As Object, e As EventArgs) Handles btnthem2.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG_PS03271 values(@MaKH,@TenKH,@GioiTinh,@DiaChi,@Email,@Sdt)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        'Try
        txtmakh.Focus()
        If txtmakh.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txttenkh.Text = "" Then
            MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtgtkh.Text = "" Then
            MessageBox.Show("Bạn chưa nhập giới tính", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtdiachi.Text = "" Then
            MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtemail.Text = "" Then
            MessageBox.Show("Bạn chưa nhập số email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtsdt.Focus()
        Else
            save.Parameters.AddWithValue("@MaKH", txtmakh.Text)
            save.Parameters.AddWithValue("@TenKH", txttenkh.Text)
            save.Parameters.AddWithValue("@GioiTinh", txtemail.Text)
            save.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
            save.Parameters.AddWithValue("@Email", txtemail.Text)
            save.Parameters.AddWithValue("@Sdt", txtsdt.Text)
            save.ExecuteNonQuery()
            MessageBox.Show("Lưu thành công")
            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
            txtmakh.Text = Nothing
            txttenkh.Text = Nothing
            txtgtkh.Text = Nothing
            txtdiachi.Text = Nothing
            txtemail.Text = Nothing
            txtsdt.Text = Nothing
        End If


        'Catch ex As Exception  'Ngược lại báo lỗi
        'MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        'End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select * from KHACHHANG_PS03271", conn)
        db.Clear()
        refesh.Fill(db)
        dgvtnkh.DataSource = db.DefaultView
    End Sub


    Private Sub btnsua2_Click(sender As Object, e As EventArgs) Handles btnsua2.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACHHANG_PS03271 set MaKH=@MaKH, TenKH=@TenKH, GioiTinh=@GioiTinh, DiaChi=@DiaChi,Email=@Email, Sdt=@Sdt where MaKH=@MaKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        'Try
        txtmakh.Focus()
        If txtmakh.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txttenkh.Text = "" Then
            MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtgtkh.Text = "" Then
            MessageBox.Show("Bạn chưa nhập giới tính", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtdiachi.Text = "" Then
            MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtemail.Text = "" Then
            MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        txtsdt.Focus()
        Else

            addupdate.Parameters.AddWithValue("@MaKH", txtmakh.Text)
            addupdate.Parameters.AddWithValue("@TenKH", txttenkh.Text)
            addupdate.Parameters.AddWithValue("@GioiTinh", txtgtkh.Text)
            addupdate.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
            addupdate.Parameters.AddWithValue("@Email", txtemail.Text)
            addupdate.Parameters.AddWithValue("@Sdt", txtsdt.Text)
            addupdate.ExecuteNonQuery()
            conn.Close() 'đóng kết nối
            MessageBox.Show("Cập nhật thành công")
            txtmakh.Text = Nothing
            txttenkh.Text = Nothing
            txtgtkh.Text = Nothing
            txtdiachi.Text = Nothing
            txtemail.Text = Nothing
            txtsdt.Text = Nothing
        End If
        'Catch ex As Exception
        ' MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        'End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvtnkh.DataSource = db
        dgvtnkh.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnxoa2_Click(sender As Object, e As EventArgs) Handles btnxoa2.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim delquery As String = "delete from KHACHHANG_PS03271 where MaKH=@MaKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmakh.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmakh.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MaKH", txtmakh.Text)
                    delete.ExecuteNonQuery()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmakh.Text = Nothing
                    txttenkh.Text = Nothing
                    txtgtkh.Text = Nothing
                    txtdiachi.Text = Nothing
                    txtemail.Text = Nothing
                    txtsdt.Text = Nothing
                    txtemail.Text = Nothing
                    txtmakh.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvtnkh.DataSource = db
        dgvtnkh.DataSource = Nothing
        conn.Close()
        LoadData()
    End Sub

    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim loadKH As SqlDataAdapter = New SqlDataAdapter("select * from KHACHHANG_PS03271", conn)
        conn.Open()
        loadKH.Fill(db)
        dgvtnkh.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub btnhuy2_Click(sender As Object, e As EventArgs) Handles btnhuy2.Click

        Dim hienthi As New Class1
        dgvtnkh.DataSource = hienthi.Loadkhachhang.Tables(0)

        txtmakh.Text = Nothing
        txttenkh.Text = Nothing
        txtgtkh.Text = Nothing
        txtdiachi.Text = Nothing
        txtemail.Text = Nothing
        txtsdt.Text = Nothing
        txtemail.Text = Nothing


    End Sub

    Private Sub btntimmakh_Click(sender As Object, e As EventArgs) Handles btntimmakh.Click
        conn.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select * from KHACHHANG_PS03271 where KHACHHANG_PS03271.MaKH like '%" & txttimmakh.Text & "%'", conn)
        Try
            If txttimmakh.Text = "" Then
                MessageBox.Show("Bạn cần nhập Mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvtnkh.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvtnkh.DataSource = db.DefaultView
                    txttimmakh.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txttimmakh.Text = Nothing
                End If
            End If
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btntimtenkh_Click(sender As Object, e As EventArgs) Handles btntimtenkh.Click
        conn.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select * from KHACHHANG_PS03271 where TenKH like '%" & txttimtenkh.Text & "%'", conn)
        Try
            If txttimtenkh.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvtnkh.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvtnkh.DataSource = db.DefaultView
                    txttimtenkh.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txttimtenkh.Text = Nothing
                End If
            End If
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class