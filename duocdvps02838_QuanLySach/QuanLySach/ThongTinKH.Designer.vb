<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThongTinKH
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
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblDT = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.btnThemKH = New System.Windows.Forms.Button()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtDT = New System.Windows.Forms.TextBox()
        Me.btnXoaKH = New System.Windows.Forms.Button()
        Me.btnSuaKH = New System.Windows.Forms.Button()
        Me.btnQuaylaiKH = New System.Windows.Forms.Button()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(32, 22)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(97, 13)
        Me.lblMaKH.TabIndex = 0
        Me.lblMaKH.Text = "MÃ KHÁCH HÀNG"
        '
        'lblTenKH
        '
        Me.lblTenKH.AutoSize = True
        Me.lblTenKH.Location = New System.Drawing.Point(32, 45)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.Size = New System.Drawing.Size(103, 13)
        Me.lblTenKH.TabIndex = 0
        Me.lblTenKH.Text = "TÊN KHÁCH HÀNG"
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Location = New System.Drawing.Point(32, 71)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(46, 13)
        Me.lblDiaChi.TabIndex = 0
        Me.lblDiaChi.Text = "ĐỊA CHỈ"
        '
        'lblDT
        '
        Me.lblDT.AutoSize = True
        Me.lblDT.Location = New System.Drawing.Point(32, 98)
        Me.lblDT.Name = "lblDT"
        Me.lblDT.Size = New System.Drawing.Size(69, 13)
        Me.lblDT.TabIndex = 0
        Me.lblDT.Text = "ĐIỆN THOẠI"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(145, 15)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(302, 20)
        Me.txtMaKH.TabIndex = 1
        '
        'dgvKH
        '
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(26, 132)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(421, 246)
        Me.dgvKH.TabIndex = 2
        '
        'btnThemKH
        '
        Me.btnThemKH.Location = New System.Drawing.Point(472, 17)
        Me.btnThemKH.Name = "btnThemKH"
        Me.btnThemKH.Size = New System.Drawing.Size(75, 23)
        Me.btnThemKH.TabIndex = 3
        Me.btnThemKH.Text = "Thêm"
        Me.btnThemKH.UseVisualStyleBackColor = True
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(145, 38)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(302, 20)
        Me.txtTenKH.TabIndex = 1
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(145, 64)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(302, 20)
        Me.txtDiaChi.TabIndex = 1
        '
        'txtDT
        '
        Me.txtDT.Location = New System.Drawing.Point(145, 90)
        Me.txtDT.Name = "txtDT"
        Me.txtDT.Size = New System.Drawing.Size(302, 20)
        Me.txtDT.TabIndex = 1
        '
        'btnXoaKH
        '
        Me.btnXoaKH.Location = New System.Drawing.Point(472, 46)
        Me.btnXoaKH.Name = "btnXoaKH"
        Me.btnXoaKH.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaKH.TabIndex = 3
        Me.btnXoaKH.Text = "Xóa"
        Me.btnXoaKH.UseVisualStyleBackColor = True
        '
        'btnSuaKH
        '
        Me.btnSuaKH.Location = New System.Drawing.Point(472, 75)
        Me.btnSuaKH.Name = "btnSuaKH"
        Me.btnSuaKH.Size = New System.Drawing.Size(75, 23)
        Me.btnSuaKH.TabIndex = 3
        Me.btnSuaKH.Text = "Sửa"
        Me.btnSuaKH.UseVisualStyleBackColor = True
        '
        'btnQuaylaiKH
        '
        Me.btnQuaylaiKH.Location = New System.Drawing.Point(472, 104)
        Me.btnQuaylaiKH.Name = "btnQuaylaiKH"
        Me.btnQuaylaiKH.Size = New System.Drawing.Size(75, 23)
        Me.btnQuaylaiKH.TabIndex = 3
        Me.btnQuaylaiKH.Text = "Quay lại"
        Me.btnQuaylaiKH.UseVisualStyleBackColor = True
        '
        'ThongTinKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 390)
        Me.Controls.Add(Me.btnQuaylaiKH)
        Me.Controls.Add(Me.btnSuaKH)
        Me.Controls.Add(Me.btnXoaKH)
        Me.Controls.Add(Me.btnThemKH)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.txtDT)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblDT)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.lblTenKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.Name = "ThongTinKH"
        Me.Text = "THÔNG TIN KHÁCH HÀNG"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents lblTenKH As System.Windows.Forms.Label
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblDT As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents dgvKH As System.Windows.Forms.DataGridView
    Friend WithEvents btnThemKH As System.Windows.Forms.Button
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtDT As System.Windows.Forms.TextBox
    Friend WithEvents btnXoaKH As System.Windows.Forms.Button
    Friend WithEvents btnSuaKH As System.Windows.Forms.Button
    Friend WithEvents btnQuaylaiKH As System.Windows.Forms.Button
End Class
