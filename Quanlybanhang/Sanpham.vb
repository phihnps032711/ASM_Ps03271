Imports System.Data.SqlClient
Imports System.Data

Public Class Sanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=ASMINF205PS03271.mssql.somee.com;packet size=4096;user id=phihnps032711_SQLLogin_1;pwd=5rs932krxz;data source=ASMINF205PS03271.mssql.somee.com;persist security info=False;initial catalog=ASMINF205PS03271"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click

        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SANPHAM_PS03271 values(@MaSP,@TenSP,@MaLoai,@Gia) insert into LOAISP_PS03271 values(@MaLoai,@TenLoai)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        'Try
        txtmasp.Focus()
        If txtmasp.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txttensp.Text = "" Then
            MessageBox.Show("Bạn chưa nhập sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtmaloai.Text = "" Then
            MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txttensp.Text = "" Then
            MessageBox.Show("Bạn chưa nhập tên loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtgia.Text = "" Then
            MessageBox.Show("Bạn chưa nhập giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtgia.Focus()
        Else
            save.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            save.Parameters.AddWithValue("@TenSP", txttensp.Text)
            save.Parameters.AddWithValue("@MaLoai", txtmaloai.Text)
            save.Parameters.AddWithValue("@TenLoai", txttenloai.Text)
            save.Parameters.AddWithValue("@Gia", txtgia.Text)
            save.ExecuteNonQuery()
            MessageBox.Show("Lưu thành công")
            LoadData()
            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
            txtmasp.Text = Nothing
            txttensp.Text = Nothing
            txtmaloai.Text = Nothing
            txttenloai.Text = Nothing
            txtgia.Text = Nothing

        End If


        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select * from SANPHAM_PS03271 inner join LOAISP_PS03271 on  LOAISP_PS03271.MaLoai = SANPHAM_PS03271.MaLoai", conn)
        db.Clear()
        refesh.Fill(db)
        dgvcapnhatsanpham.DataSource = db.DefaultView
        conn.Close()
    End Sub

    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim loadSP As SqlDataAdapter = New SqlDataAdapter("select * from SANPHAM_PS03271 inner join LOAISP_PS03271 on  LOAISP_PS03271.MaLoai = SANPHAM_PS03271.MaLoai", conn)
        conn.Open()
        loadSP.Fill(db)
        dgvcapnhatsanpham.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub dgvtnkh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcapnhatsanpham.CellContentClick
        Try
            Dim click As Integer = dgvcapnhatsanpham.CurrentCell.RowIndex
            txtmasp.Text = dgvcapnhatsanpham.Item(0, click).Value
            txttensp.Text = dgvcapnhatsanpham.Item(1, click).Value
            txtmaloai.Text = dgvcapnhatsanpham.Item(2, click).Value
            txttenloai.Text = dgvcapnhatsanpham.Item(5, click).Value
            txtgia.Text = dgvcapnhatsanpham.Item(3, click).Value

        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SANPHAM_PS03271 set MaSP=@MaSP, TenSP=@TenSP, MaLoai=@MaLoai, Gia=@Gia where MaLoai=@MaLoai update LOAISP_PS03271 set MaLoai=@MaLoai, TenLoai=@TenLoai where MaLoai=@MaLoai"

        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        'Try
        txtmasp.Focus()
        If txtmasp.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txttensp.Text = "" Then
            MessageBox.Show("Bạn chưa nhập sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtmaloai.Text = "" Then
            MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txttensp.Text = "" Then
            MessageBox.Show("Bạn chưa nhập tên loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf txtgia.Text = "" Then
            MessageBox.Show("Bạn chưa nhập giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtgia.Focus()
        Else

            addupdate.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            addupdate.Parameters.AddWithValue("@TenSP", txttensp.Text)
            addupdate.Parameters.AddWithValue("@MaLoai", txtmaloai.Text)
            addupdate.Parameters.AddWithValue("@TenLoai", txttenloai.Text)
            addupdate.Parameters.AddWithValue("@Gia", txtgia.Text)
            addupdate.ExecuteNonQuery()
            MessageBox.Show("Cập nhật thành công")
            txtmasp.Text = Nothing
            txttensp.Text = Nothing
            txtmaloai.Text = Nothing
            txttenloai.Text = Nothing
            txtgia.Text = Nothing
        End If
        'Catch ex As Exception
        ' MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        'End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvcapnhatsanpham.DataSource = db
        dgvcapnhatsanpham.DataSource = Nothing
        LoadData()
        conn.Close() 'đóng kết nối
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim delquery As String = "delete from SANPHAM_PS03271 where MaSP=@MaSP delete from LOAISP_PS03271 where MaLoai=@MaLoai"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        'Try
        If txtmasp.Text = "" Then
            MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtmasp.Focus()
        ElseIf resulft = Windows.Forms.DialogResult.Yes Then
            delete.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            delete.Parameters.AddWithValue("@MaLoai", txtmaloai.Text)
                delete.ExecuteNonQuery()
                MessageBox.Show("Xóa thành công")
                'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                txtmasp.Text = Nothing
                txttensp.Text = Nothing
                txtmaloai.Text = Nothing
                txttenloai.Text = Nothing
                txtgia.Text = Nothing
                txtmasp.Focus()
            End If

        'Catch ex As Exception
        'MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        'End Try

        'làm mới bảng
        db.Clear()
        dgvcapnhatsanpham.DataSource = db
        dgvcapnhatsanpham.DataSource = Nothing
        conn.Close()
        LoadData()
    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        txtmasp.Text = Nothing
        txttensp.Text = Nothing
        txtmaloai.Text = Nothing
        txttenloai.Text = Nothing
        txtgia.Text = Nothing
    End Sub


    Private Sub Sanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hienthi As New Class1
        dgvcapnhatsanpham.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub

    Private Sub btntimmasp_Click(sender As Object, e As EventArgs) Handles btntimmasp.Click

        Dim timkiemmasp As SqlDataAdapter = New SqlDataAdapter("select * from SANPHAM_PS03271 inner join LOAISP_PS03271 on  LOAISP_PS03271.MaLoai = SANPHAM_PS03271.MaLoai where SANPHAM_PS03271.MaSP like '%" & txtmatimsp.Text & "%' ", conn)
        conn.Open()
        Try
            If txtmatimsp.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvcapnhatsanpham.DataSource = Nothing
                timkiemmasp.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvcapnhatsanpham.DataSource = db.DefaultView
                    txtmatimsp.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtmatimsp.Text = Nothing
                End If
            End If
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub


End Class