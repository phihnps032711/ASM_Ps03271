<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sanpham))
        Me.dgvcapnhatsanpham = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btntimtensp = New System.Windows.Forms.Button()
        Me.txttimtensp = New System.Windows.Forms.TextBox()
        Me.lbltimtensp = New System.Windows.Forms.Label()
        Me.btntimmasp = New System.Windows.Forms.Button()
        Me.lbltimmasp = New System.Windows.Forms.Label()
        Me.txtmatimsp = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.txttenloai = New System.Windows.Forms.TextBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.lblgia = New System.Windows.Forms.Label()
        Me.lbltenloai = New System.Windows.Forms.Label()
        Me.lblmaloai = New System.Windows.Forms.Label()
        Me.lbltensanpham = New System.Windows.Forms.Label()
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.MaSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvcapnhatsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvcapnhatsanpham
        '
        Me.dgvcapnhatsanpham.AllowUserToDeleteRows = False
        Me.dgvcapnhatsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcapnhatsanpham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSP, Me.TenSP, Me.MaLoai, Me.TenLoai, Me.Gia})
        Me.dgvcapnhatsanpham.Location = New System.Drawing.Point(12, 242)
        Me.dgvcapnhatsanpham.Name = "dgvcapnhatsanpham"
        Me.dgvcapnhatsanpham.ReadOnly = True
        Me.dgvcapnhatsanpham.Size = New System.Drawing.Size(710, 257)
        Me.dgvcapnhatsanpham.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btntimtensp)
        Me.GroupBox1.Controls.Add(Me.txttimtensp)
        Me.GroupBox1.Controls.Add(Me.lbltimtensp)
        Me.GroupBox1.Controls.Add(Me.btntimmasp)
        Me.GroupBox1.Controls.Add(Me.lbltimmasp)
        Me.GroupBox1.Controls.Add(Me.txtmatimsp)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 224)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm sản phẩm"
        '
        'btntimtensp
        '
        Me.btntimtensp.BackgroundImage = CType(resources.GetObject("btntimtensp.BackgroundImage"), System.Drawing.Image)
        Me.btntimtensp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntimtensp.Location = New System.Drawing.Point(199, 151)
        Me.btntimtensp.Name = "btntimtensp"
        Me.btntimtensp.Size = New System.Drawing.Size(52, 45)
        Me.btntimtensp.TabIndex = 20
        Me.btntimtensp.UseVisualStyleBackColor = True
        '
        'txttimtensp
        '
        Me.txttimtensp.Location = New System.Drawing.Point(6, 161)
        Me.txttimtensp.Name = "txttimtensp"
        Me.txttimtensp.Size = New System.Drawing.Size(187, 26)
        Me.txttimtensp.TabIndex = 19
        Me.txttimtensp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltimtensp
        '
        Me.lbltimtensp.AutoSize = True
        Me.lbltimtensp.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimtensp.Location = New System.Drawing.Point(29, 129)
        Me.lbltimtensp.Name = "lbltimtensp"
        Me.lbltimtensp.Size = New System.Drawing.Size(134, 24)
        Me.lbltimtensp.TabIndex = 18
        Me.lbltimtensp.Text = "Tên sản phẩm"
        '
        'btntimmasp
        '
        Me.btntimmasp.BackgroundImage = CType(resources.GetObject("btntimmasp.BackgroundImage"), System.Drawing.Image)
        Me.btntimmasp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntimmasp.Location = New System.Drawing.Point(199, 64)
        Me.btntimmasp.Name = "btntimmasp"
        Me.btntimmasp.Size = New System.Drawing.Size(52, 45)
        Me.btntimmasp.TabIndex = 17
        Me.btntimmasp.UseVisualStyleBackColor = True
        '
        'lbltimmasp
        '
        Me.lbltimmasp.AutoSize = True
        Me.lbltimmasp.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimmasp.Location = New System.Drawing.Point(29, 41)
        Me.lbltimmasp.Name = "lbltimmasp"
        Me.lbltimmasp.Size = New System.Drawing.Size(130, 24)
        Me.lbltimmasp.TabIndex = 16
        Me.lbltimmasp.Text = "Mã sản phẩm"
        '
        'txtmatimsp
        '
        Me.txtmatimsp.Location = New System.Drawing.Point(6, 74)
        Me.txtmatimsp.Name = "txtmatimsp"
        Me.txtmatimsp.Size = New System.Drawing.Size(187, 26)
        Me.txtmatimsp.TabIndex = 15
        Me.txtmatimsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnhuy)
        Me.GroupBox2.Controls.Add(Me.btnxoa)
        Me.GroupBox2.Controls.Add(Me.btnsua)
        Me.GroupBox2.Controls.Add(Me.btnthem)
        Me.GroupBox2.Controls.Add(Me.txtgia)
        Me.GroupBox2.Controls.Add(Me.txttenloai)
        Me.GroupBox2.Controls.Add(Me.txtmaloai)
        Me.GroupBox2.Controls.Add(Me.txttensp)
        Me.GroupBox2.Controls.Add(Me.txtmasp)
        Me.GroupBox2.Controls.Add(Me.lblgia)
        Me.GroupBox2.Controls.Add(Me.lbltenloai)
        Me.GroupBox2.Controls.Add(Me.lblmaloai)
        Me.GroupBox2.Controls.Add(Me.lbltensanpham)
        Me.GroupBox2.Controls.Add(Me.lblmasp)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(275, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 224)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thêm thông tin sản phẩm"
        '
        'btnhuy
        '
        Me.btnhuy.BackgroundImage = CType(resources.GetObject("btnhuy.BackgroundImage"), System.Drawing.Image)
        Me.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnhuy.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnhuy.Location = New System.Drawing.Point(306, 174)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(125, 37)
        Me.btnhuy.TabIndex = 39
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.BackgroundImage = CType(resources.GetObject("btnxoa.BackgroundImage"), System.Drawing.Image)
        Me.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnxoa.Location = New System.Drawing.Point(373, 116)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(58, 52)
        Me.btnxoa.TabIndex = 38
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.BackgroundImage = CType(resources.GetObject("btnsua.BackgroundImage"), System.Drawing.Image)
        Me.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsua.Location = New System.Drawing.Point(306, 116)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(59, 52)
        Me.btnsua.TabIndex = 37
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.BackgroundImage = CType(resources.GetObject("btnthem.BackgroundImage"), System.Drawing.Image)
        Me.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnthem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnthem.Location = New System.Drawing.Point(306, 25)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(125, 85)
        Me.btnthem.TabIndex = 36
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(129, 183)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(164, 26)
        Me.txtgia.TabIndex = 35
        '
        'txttenloai
        '
        Me.txttenloai.Location = New System.Drawing.Point(129, 142)
        Me.txttenloai.Name = "txttenloai"
        Me.txttenloai.Size = New System.Drawing.Size(164, 26)
        Me.txttenloai.TabIndex = 34
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(129, 102)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(164, 26)
        Me.txtmaloai.TabIndex = 33
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(129, 65)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(164, 26)
        Me.txttensp.TabIndex = 32
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(129, 25)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(164, 26)
        Me.txtmasp.TabIndex = 31
        '
        'lblgia
        '
        Me.lblgia.AutoSize = True
        Me.lblgia.BackColor = System.Drawing.Color.Transparent
        Me.lblgia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgia.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblgia.Location = New System.Drawing.Point(20, 190)
        Me.lblgia.Name = "lblgia"
        Me.lblgia.Size = New System.Drawing.Size(33, 19)
        Me.lblgia.TabIndex = 30
        Me.lblgia.Text = "Giá"
        '
        'lbltenloai
        '
        Me.lbltenloai.AutoSize = True
        Me.lbltenloai.BackColor = System.Drawing.Color.Transparent
        Me.lbltenloai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltenloai.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltenloai.Location = New System.Drawing.Point(20, 149)
        Me.lbltenloai.Name = "lbltenloai"
        Me.lbltenloai.Size = New System.Drawing.Size(63, 19)
        Me.lbltenloai.TabIndex = 29
        Me.lbltenloai.Text = "Tên loại"
        '
        'lblmaloai
        '
        Me.lblmaloai.AutoSize = True
        Me.lblmaloai.BackColor = System.Drawing.Color.Transparent
        Me.lblmaloai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaloai.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblmaloai.Location = New System.Drawing.Point(20, 109)
        Me.lblmaloai.Name = "lblmaloai"
        Me.lblmaloai.Size = New System.Drawing.Size(61, 19)
        Me.lblmaloai.TabIndex = 28
        Me.lblmaloai.Text = "Mã loại"
        '
        'lbltensanpham
        '
        Me.lbltensanpham.AutoSize = True
        Me.lbltensanpham.BackColor = System.Drawing.Color.Transparent
        Me.lbltensanpham.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltensanpham.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltensanpham.Location = New System.Drawing.Point(20, 72)
        Me.lbltensanpham.Name = "lbltensanpham"
        Me.lbltensanpham.Size = New System.Drawing.Size(102, 19)
        Me.lbltensanpham.TabIndex = 27
        Me.lbltensanpham.Text = "Tên sản phẩm"
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.BackColor = System.Drawing.Color.Transparent
        Me.lblmasp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmasp.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblmasp.Location = New System.Drawing.Point(20, 32)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(100, 19)
        Me.lblmasp.TabIndex = 26
        Me.lblmasp.Text = "Mã sản phẩm"
        '
        'MaSP
        '
        Me.MaSP.DataPropertyName = "MaSP"
        Me.MaSP.HeaderText = "Mã sản phẩm"
        Me.MaSP.Name = "MaSP"
        Me.MaSP.ReadOnly = True
        Me.MaSP.Width = 145
        '
        'TenSP
        '
        Me.TenSP.DataPropertyName = "TenSP"
        Me.TenSP.HeaderText = "Tên sản phẩm"
        Me.TenSP.Name = "TenSP"
        Me.TenSP.ReadOnly = True
        Me.TenSP.Width = 155
        '
        'MaLoai
        '
        Me.MaLoai.DataPropertyName = "MaLoai"
        Me.MaLoai.HeaderText = "Mã loại"
        Me.MaLoai.Name = "MaLoai"
        Me.MaLoai.ReadOnly = True
        Me.MaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MaLoai.Width = 120
        '
        'TenLoai
        '
        Me.TenLoai.DataPropertyName = "TenLoai"
        Me.TenLoai.HeaderText = "Tên loại"
        Me.TenLoai.Name = "TenLoai"
        Me.TenLoai.ReadOnly = True
        Me.TenLoai.Width = 150
        '
        'Gia
        '
        Me.Gia.DataPropertyName = "Gia"
        Me.Gia.HeaderText = "Giá"
        Me.Gia.Name = "Gia"
        Me.Gia.ReadOnly = True
        '
        'Sanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Quanlybanhang.My.Resources.Resources.colorful_curves
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvcapnhatsanpham)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Sanpham"
        Me.Text = "Sanpham"
        CType(Me.dgvcapnhatsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvcapnhatsanpham As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents txttenloai As System.Windows.Forms.TextBox
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents lblgia As System.Windows.Forms.Label
    Friend WithEvents lbltenloai As System.Windows.Forms.Label
    Friend WithEvents lblmaloai As System.Windows.Forms.Label
    Friend WithEvents lbltensanpham As System.Windows.Forms.Label
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btntimmasp As System.Windows.Forms.Button
    Friend WithEvents lbltimmasp As System.Windows.Forms.Label
    Friend WithEvents txtmatimsp As System.Windows.Forms.TextBox
    Friend WithEvents btntimtensp As System.Windows.Forms.Button
    Friend WithEvents txttimtensp As System.Windows.Forms.TextBox
    Friend WithEvents lbltimtensp As System.Windows.Forms.Label
    Friend WithEvents MaSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaLoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
