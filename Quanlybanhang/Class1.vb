Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Dim chuoiketnoi As String = "workstation id=ASMINF205PS03271.mssql.somee.com;packet size=4096;user id=phihnps032711_SQLLogin_1;pwd=5rs932krxz;data source=ASMINF205PS03271.mssql.somee.com;persist security info=False;initial catalog=ASMINF205PS03271"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Public Function Loadkhachhang() As DataSet
        Dim LoadKH As New SqlDataAdapter("select * from KHACHHANG_PS03271", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
        'select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', Sdt as 'SĐT', Email
    End Function

    Public Function Loadsanpham() As DataSet
        Dim LoadSP As New SqlDataAdapter("select * from SANPHAM_PS03271 inner join LOAISP_PS03271 on  LOAISP_PS03271.MaLoai = SANPHAM_PS03271.MaLoai", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
