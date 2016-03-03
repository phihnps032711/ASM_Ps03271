<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Khachhang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Khachhang))
        Me.dgvtnkh = New System.Windows.Forms.DataGridView()
        Me.MaKH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btntimtenkh = New System.Windows.Forms.Button()
        Me.txttimtenkh = New System.Windows.Forms.TextBox()
        Me.lbltimtenkh = New System.Windows.Forms.Label()
        Me.btntimmakh = New System.Windows.Forms.Button()
        Me.txttimmakh = New System.Windows.Forms.TextBox()
        Me.lblmakhtn = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnthem2 = New System.Windows.Forms.Button()
        Me.btnhuy2 = New System.Windows.Forms.Button()
        Me.btnxoa2 = New System.Windows.Forms.Button()
        Me.btnsua2 = New System.Windows.Forms.Button()
        Me.txtgtkh = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lblgioitinh = New System.Windows.Forms.Label()
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.lblmakh = New System.Windows.Forms.Label()
        CType(Me.dgvtnkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvtnkh
        '
        Me.dgvtnkh.AllowUserToDeleteRows = False
        Me.dgvtnkh.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKH, Me.TenKH, Me.GioiTinh, Me.DiaChi, Me.Email, Me.Sdt})
        Me.dgvtnkh.Location = New System.Drawing.Point(13, 243)
        Me.dgvtnkh.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvtnkh.Name = "dgvtnkh"
        Me.dgvtnkh.ReadOnly = True
        Me.dgvtnkh.Size = New System.Drawing.Size(714, 255)
        Me.dgvtnkh.TabIndex = 49
        '
        'MaKH
        '
        Me.MaKH.DataPropertyName = "MaKH"
        Me.MaKH.HeaderText = "Mã khách hàng"
        Me.MaKH.Name = "MaKH"
        Me.MaKH.ReadOnly = True
        Me.MaKH.Width = 130
        '
        'TenKH
        '
        Me.TenKH.DataPropertyName = "TenKH"
        Me.TenKH.HeaderText = "Tên khách hàng"
        Me.TenKH.Name = "TenKH"
        Me.TenKH.ReadOnly = True
        Me.TenKH.Width = 150
        '
        'GioiTinh
        '
        Me.GioiTinh.DataPropertyName = "GioiTinh"
        Me.GioiTinh.HeaderText = "Giới tính"
        Me.GioiTinh.Name = "GioiTinh"
        Me.GioiTinh.ReadOnly = True
        Me.GioiTinh.Width = 90
        '
        'DiaChi
        '
        Me.DiaChi.DataPropertyName = "DiaChi"
        Me.DiaChi.HeaderText = "Địa chỉ"
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.ReadOnly = True
        Me.DiaChi.Width = 150
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 130
        '
        'Sdt
        '
        Me.Sdt.DataPropertyName = "Sdt"
        Me.Sdt.HeaderText = "Số điện thoại"
        Me.Sdt.Name = "Sdt"
        Me.Sdt.ReadOnly = True
        Me.Sdt.Width = 130
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btntimtenkh)
        Me.GroupBox1.Controls.Add(Me.txttimtenkh)
        Me.GroupBox1.Controls.Add(Me.lbltimtenkh)
        Me.GroupBox1.Controls.Add(Me.btntimmakh)
        Me.GroupBox1.Controls.Add(Me.txttimmakh)
        Me.GroupBox1.Controls.Add(Me.lblmakhtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 224)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm khách hàng"
        '
        'btntimtenkh
        '
        Me.btntimtenkh.BackColor = System.Drawing.Color.Transparent
        Me.btntimtenkh.BackgroundImage = CType(resources.GetObject("btntimtenkh.BackgroundImage"), System.Drawing.Image)
        Me.btntimtenkh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btntimtenkh.Location = New System.Drawing.Point(76, 185)
        Me.btntimtenkh.Name = "btntimtenkh"
        Me.btntimtenkh.Size = New System.Drawing.Size(99, 26)
        Me.btntimtenkh.TabIndex = 14
        Me.btntimtenkh.UseVisualStyleBackColor = False
        '
        'txttimtenkh
        '
        Me.txttimtenkh.Location = New System.Drawing.Point(6, 150)
        Me.txttimtenkh.Name = "txttimtenkh"
        Me.txttimtenkh.Size = New System.Drawing.Size(245, 26)
        Me.txttimtenkh.TabIndex = 13
        Me.txttimtenkh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltimtenkh
        '
        Me.lbltimtenkh.AutoSize = True
        Me.lbltimtenkh.BackColor = System.Drawing.Color.Transparent
        Me.lbltimtenkh.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimtenkh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltimtenkh.Location = New System.Drawing.Point(22, 125)
        Me.lbltimtenkh.Name = "lbltimtenkh"
        Me.lbltimtenkh.Size = New System.Drawing.Size(147, 22)
        Me.lbltimtenkh.TabIndex = 12
        Me.lbltimtenkh.Text = "Tên khách hàng:"
        '
        'btntimmakh
        '
        Me.btntimmakh.BackColor = System.Drawing.Color.Transparent
        Me.btntimmakh.BackgroundImage = CType(resources.GetObject("btntimmakh.BackgroundImage"), System.Drawing.Image)
        Me.btntimmakh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btntimmakh.Location = New System.Drawing.Point(76, 82)
        Me.btntimmakh.Name = "btntimmakh"
        Me.btntimmakh.Size = New System.Drawing.Size(99, 26)
        Me.btntimmakh.TabIndex = 11
        Me.btntimmakh.UseVisualStyleBackColor = False
        '
        'txttimmakh
        '
        Me.txttimmakh.Location = New System.Drawing.Point(6, 50)
        Me.txttimmakh.Name = "txttimmakh"
        Me.txttimmakh.Size = New System.Drawing.Size(245, 26)
        Me.txttimmakh.TabIndex = 10
        Me.txttimmakh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblmakhtn
        '
        Me.lblmakhtn.AutoSize = True
        Me.lblmakhtn.BackColor = System.Drawing.Color.Transparent
        Me.lblmakhtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmakhtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblmakhtn.Location = New System.Drawing.Point(22, 25)
        Me.lblmakhtn.Name = "lblmakhtn"
        Me.lblmakhtn.Size = New System.Drawing.Size(143, 22)
        Me.lblmakhtn.TabIndex = 9
        Me.lblmakhtn.Text = "Mã khách hàng:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnthem2)
        Me.GroupBox2.Controls.Add(Me.btnhuy2)
        Me.GroupBox2.Controls.Add(Me.btnxoa2)
        Me.GroupBox2.Controls.Add(Me.btnsua2)
        Me.GroupBox2.Controls.Add(Me.txtgtkh)
        Me.GroupBox2.Controls.Add(Me.txtsdt)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.txtdiachi)
        Me.GroupBox2.Controls.Add(Me.txttenkh)
        Me.GroupBox2.Controls.Add(Me.txtmakh)
        Me.GroupBox2.Controls.Add(Me.lblsdt)
        Me.GroupBox2.Controls.Add(Me.lblemail)
        Me.GroupBox2.Controls.Add(Me.lbldiachi)
        Me.GroupBox2.Controls.Add(Me.lblgioitinh)
        Me.GroupBox2.Controls.Add(Me.lbltenkh)
        Me.GroupBox2.Controls.Add(Me.lblmakh)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(280, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 224)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thêm thông tin khách hàng"
        '
        'btnthem2
        '
        Me.btnthem2.BackgroundImage = CType(resources.GetObject("btnthem2.BackgroundImage"), System.Drawing.Image)
        Me.btnthem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnthem2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem2.Location = New System.Drawing.Point(306, 25)
        Me.btnthem2.Name = "btnthem2"
        Me.btnthem2.Size = New System.Drawing.Size(125, 89)
        Me.btnthem2.TabIndex = 63
        Me.btnthem2.UseVisualStyleBackColor = True
        '
        'btnhuy2
        '
        Me.btnhuy2.BackgroundImage = CType(resources.GetObject("btnhuy2.BackgroundImage"), System.Drawing.Image)
        Me.btnhuy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnhuy2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnhuy2.Location = New System.Drawing.Point(306, 179)
        Me.btnhuy2.Name = "btnhuy2"
        Me.btnhuy2.Size = New System.Drawing.Size(125, 37)
        Me.btnhuy2.TabIndex = 62
        Me.btnhuy2.UseVisualStyleBackColor = True
        '
        'btnxoa2
        '
        Me.btnxoa2.BackgroundImage = CType(resources.GetObject("btnxoa2.BackgroundImage"), System.Drawing.Image)
        Me.btnxoa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnxoa2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnxoa2.Location = New System.Drawing.Point(373, 121)
        Me.btnxoa2.Name = "btnxoa2"
        Me.btnxoa2.Size = New System.Drawing.Size(58, 52)
        Me.btnxoa2.TabIndex = 61
        Me.btnxoa2.UseVisualStyleBackColor = True
        '
        'btnsua2
        '
        Me.btnsua2.BackgroundImage = CType(resources.GetObject("btnsua2.BackgroundImage"), System.Drawing.Image)
        Me.btnsua2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsua2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsua2.Location = New System.Drawing.Point(306, 121)
        Me.btnsua2.Name = "btnsua2"
        Me.btnsua2.Size = New System.Drawing.Size(59, 52)
        Me.btnsua2.TabIndex = 60
        Me.btnsua2.UseVisualStyleBackColor = True
        '
        'txtgtkh
        '
        Me.txtgtkh.Location = New System.Drawing.Point(131, 89)
        Me.txtgtkh.Name = "txtgtkh"
        Me.txtgtkh.Size = New System.Drawing.Size(161, 26)
        Me.txtgtkh.TabIndex = 59
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(131, 185)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(160, 26)
        Me.txtsdt.TabIndex = 58
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(74, 153)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(217, 26)
        Me.txtemail.TabIndex = 57
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(74, 121)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(217, 26)
        Me.txtdiachi.TabIndex = 56
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(131, 57)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(160, 26)
        Me.txttenkh.TabIndex = 55
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(130, 25)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(161, 26)
        Me.txtmakh.TabIndex = 54
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.BackColor = System.Drawing.Color.Transparent
        Me.lblsdt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblsdt.Location = New System.Drawing.Point(30, 185)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(95, 19)
        Me.lblsdt.TabIndex = 53
        Me.lblsdt.Text = "Số điện thoại"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblemail.Location = New System.Drawing.Point(12, 156)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(47, 19)
        Me.lblemail.TabIndex = 52
        Me.lblemail.Text = "Email"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.BackColor = System.Drawing.Color.Transparent
        Me.lbldiachi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiachi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbldiachi.Location = New System.Drawing.Point(12, 124)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(56, 19)
        Me.lbldiachi.TabIndex = 51
        Me.lbldiachi.Text = "Địa chỉ"
        '
        'lblgioitinh
        '
        Me.lblgioitinh.AutoSize = True
        Me.lblgioitinh.BackColor = System.Drawing.Color.Transparent
        Me.lblgioitinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgioitinh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblgioitinh.Location = New System.Drawing.Point(58, 92)
        Me.lblgioitinh.Name = "lblgioitinh"
        Me.lblgioitinh.Size = New System.Drawing.Size(67, 19)
        Me.lblgioitinh.TabIndex = 50
        Me.lblgioitinh.Text = "Giới tính"
        '
        'lbltenkh
        '
        Me.lbltenkh.AutoSize = True
        Me.lbltenkh.BackColor = System.Drawing.Color.Transparent
        Me.lbltenkh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltenkh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltenkh.Location = New System.Drawing.Point(10, 60)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(115, 19)
        Me.lbltenkh.TabIndex = 49
        Me.lbltenkh.Text = "Tên khách hàng"
        '
        'lblmakh
        '
        Me.lblmakh.AutoSize = True
        Me.lblmakh.BackColor = System.Drawing.Color.Transparent
        Me.lblmakh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmakh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblmakh.Location = New System.Drawing.Point(12, 32)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(113, 19)
        Me.lblmakh.TabIndex = 48
        Me.lblmakh.Text = "Mã khách hàng"
        '
        'Khachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Quanlybanhang.My.Resources.Resources.colorful_curves
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvtnkh)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Khachhang"
        Me.Text = "Khachhang"
        CType(Me.dgvtnkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvtnkh As System.Windows.Forms.DataGridView
    Friend WithEvents MaKH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenKH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioiTinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lblgioitinh As System.Windows.Forms.Label
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents txtgtkh As System.Windows.Forms.TextBox
    Friend WithEvents btnthem2 As System.Windows.Forms.Button
    Friend WithEvents btnhuy2 As System.Windows.Forms.Button
    Friend WithEvents btnxoa2 As System.Windows.Forms.Button
    Friend WithEvents btnsua2 As System.Windows.Forms.Button
    Friend WithEvents btntimmakh As System.Windows.Forms.Button
    Friend WithEvents txttimmakh As System.Windows.Forms.TextBox
    Friend WithEvents lblmakhtn As System.Windows.Forms.Label
    Friend WithEvents btntimtenkh As System.Windows.Forms.Button
    Friend WithEvents txttimtenkh As System.Windows.Forms.TextBox
    Friend WithEvents lbltimtenkh As System.Windows.Forms.Label
End Class
