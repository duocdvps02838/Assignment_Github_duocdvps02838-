<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HoaDon
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
        Me.lblMaHD = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.lblMaKH_HD = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNgayLap = New System.Windows.Forms.Label()
        Me.txtMaKH_HD = New System.Windows.Forms.TextBox()
        Me.txtNgayLap = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnQuayLaiHD = New System.Windows.Forms.Button()
        Me.dgvHoaDon = New System.Windows.Forms.DataGridView()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaHD
        '
        Me.lblMaHD.AutoSize = True
        Me.lblMaHD.Location = New System.Drawing.Point(23, 23)
        Me.lblMaHD.Name = "lblMaHD"
        Me.lblMaHD.Size = New System.Drawing.Size(76, 13)
        Me.lblMaHD.TabIndex = 0
        Me.lblMaHD.Text = "MÃ HÓA ĐƠN"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(122, 23)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(276, 20)
        Me.txtMaHD.TabIndex = 1
        '
        'lblMaKH_HD
        '
        Me.lblMaKH_HD.AutoSize = True
        Me.lblMaKH_HD.Location = New System.Drawing.Point(23, 56)
        Me.lblMaKH_HD.Name = "lblMaKH_HD"
        Me.lblMaKH_HD.Size = New System.Drawing.Size(97, 13)
        Me.lblMaKH_HD.TabIndex = 0
        Me.lblMaKH_HD.Text = "MÃ KHÁCH HÀNG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label1"
        '
        'lblNgayLap
        '
        Me.lblNgayLap.AutoSize = True
        Me.lblNgayLap.Location = New System.Drawing.Point(23, 89)
        Me.lblNgayLap.Name = "lblNgayLap"
        Me.lblNgayLap.Size = New System.Drawing.Size(60, 13)
        Me.lblNgayLap.TabIndex = 0
        Me.lblNgayLap.Text = "NGÀY LẬP"
        '
        'txtMaKH_HD
        '
        Me.txtMaKH_HD.Location = New System.Drawing.Point(122, 53)
        Me.txtMaKH_HD.Name = "txtMaKH_HD"
        Me.txtMaKH_HD.Size = New System.Drawing.Size(276, 20)
        Me.txtMaKH_HD.TabIndex = 1
        '
        'txtNgayLap
        '
        Me.txtNgayLap.Location = New System.Drawing.Point(122, 82)
        Me.txtNgayLap.Name = "txtNgayLap"
        Me.txtNgayLap.Size = New System.Drawing.Size(276, 20)
        Me.txtNgayLap.TabIndex = 1
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(26, 128)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(107, 128)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 2
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(188, 128)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnQuayLaiHD
        '
        Me.btnQuayLaiHD.Location = New System.Drawing.Point(269, 128)
        Me.btnQuayLaiHD.Name = "btnQuayLaiHD"
        Me.btnQuayLaiHD.Size = New System.Drawing.Size(75, 23)
        Me.btnQuayLaiHD.TabIndex = 2
        Me.btnQuayLaiHD.Text = "Quay Lại"
        Me.btnQuayLaiHD.UseVisualStyleBackColor = True
        '
        'dgvHoaDon
        '
        Me.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoaDon.Location = New System.Drawing.Point(404, 23)
        Me.dgvHoaDon.Name = "dgvHoaDon"
        Me.dgvHoaDon.Size = New System.Drawing.Size(324, 148)
        Me.dgvHoaDon.TabIndex = 3
        '
        'HoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 234)
        Me.Controls.Add(Me.dgvHoaDon)
        Me.Controls.Add(Me.btnQuayLaiHD)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtNgayLap)
        Me.Controls.Add(Me.txtMaKH_HD)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.lblNgayLap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMaKH_HD)
        Me.Controls.Add(Me.lblMaHD)
        Me.Name = "HoaDon"
        Me.Text = "THÔNG TIN HÓA ĐƠN"
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaHD As System.Windows.Forms.Label
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents lblMaKH_HD As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNgayLap As System.Windows.Forms.Label
    Friend WithEvents txtMaKH_HD As System.Windows.Forms.TextBox
    Friend WithEvents txtNgayLap As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnQuayLaiHD As System.Windows.Forms.Button
    Friend WithEvents dgvHoaDon As System.Windows.Forms.DataGridView
End Class
