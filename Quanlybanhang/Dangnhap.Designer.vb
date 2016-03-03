<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dangnhap))
        Me.btndong = New System.Windows.Forms.Button()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.chkghinho = New System.Windows.Forms.CheckBox()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.txtdangnhap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btndong
        '
        Me.btndong.BackColor = System.Drawing.SystemColors.Window
        Me.btndong.BackgroundImage = CType(resources.GetObject("btndong.BackgroundImage"), System.Drawing.Image)
        Me.btndong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btndong.Location = New System.Drawing.Point(328, 206)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(126, 45)
        Me.btndong.TabIndex = 39
        Me.btndong.UseVisualStyleBackColor = False
        '
        'btndangnhap
        '
        Me.btndangnhap.BackColor = System.Drawing.SystemColors.Window
        Me.btndangnhap.BackgroundImage = CType(resources.GetObject("btndangnhap.BackgroundImage"), System.Drawing.Image)
        Me.btndangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndangnhap.Location = New System.Drawing.Point(145, 206)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(128, 45)
        Me.btndangnhap.TabIndex = 38
        Me.btndangnhap.UseVisualStyleBackColor = False
        '
        'chkghinho
        '
        Me.chkghinho.AutoSize = True
        Me.chkghinho.BackColor = System.Drawing.Color.Transparent
        Me.chkghinho.Checked = True
        Me.chkghinho.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkghinho.Location = New System.Drawing.Point(206, 169)
        Me.chkghinho.Name = "chkghinho"
        Me.chkghinho.Size = New System.Drawing.Size(163, 23)
        Me.chkghinho.TabIndex = 37
        Me.chkghinho.Text = "Ghi nhớ tên đăng nhập"
        Me.chkghinho.UseVisualStyleBackColor = False
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(214, 126)
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhau.Size = New System.Drawing.Size(264, 26)
        Me.txtmatkhau.TabIndex = 36
        Me.txtmatkhau.Text = "admin"
        '
        'txtdangnhap
        '
        Me.txtdangnhap.Location = New System.Drawing.Point(214, 79)
        Me.txtdangnhap.Multiline = True
        Me.txtdangnhap.Name = "txtdangnhap"
        Me.txtdangnhap.Size = New System.Drawing.Size(264, 26)
        Me.txtdangnhap.TabIndex = 35
        Me.txtdangnhap.Text = "admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(89, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Mật khẩu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(58, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Tên đăng nhập:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(208, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 36)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Đăng nhập"
        '
        'Dangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(577, 282)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.chkghinho)
        Me.Controls.Add(Me.txtmatkhau)
        Me.Controls.Add(Me.txtdangnhap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Dangnhap"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btndong As System.Windows.Forms.Button
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents chkghinho As System.Windows.Forms.CheckBox
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txtdangnhap As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
