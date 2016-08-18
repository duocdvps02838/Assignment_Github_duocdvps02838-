<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sach
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
        Me.lblMaSach = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.btnThemSach = New System.Windows.Forms.Button()
        Me.lblTenSach = New System.Windows.Forms.Label()
        Me.lblTacGIa = New System.Windows.Forms.Label()
        Me.lblGiaBan = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtGiaBan = New System.Windows.Forms.TextBox()
        Me.btnSuaSach = New System.Windows.Forms.Button()
        Me.btnXoaSach = New System.Windows.Forms.Button()
        Me.btnQuayLaiSach = New System.Windows.Forms.Button()
        Me.dgvSach = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaSach
        '
        Me.lblMaSach.AutoSize = True
        Me.lblMaSach.Location = New System.Drawing.Point(29, 32)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(55, 13)
        Me.lblMaSach.TabIndex = 0
        Me.lblMaSach.Text = "MÃ SÁCH"
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(90, 29)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(260, 20)
        Me.txtMaSach.TabIndex = 1
        '
        'btnThemSach
        '
        Me.btnThemSach.Location = New System.Drawing.Point(32, 208)
        Me.btnThemSach.Name = "btnThemSach"
        Me.btnThemSach.Size = New System.Drawing.Size(75, 23)
        Me.btnThemSach.TabIndex = 2
        Me.btnThemSach.Text = "Thêm"
        Me.btnThemSach.UseVisualStyleBackColor = True
        '
        'lblTenSach
        '
        Me.lblTenSach.AutoSize = True
        Me.lblTenSach.Location = New System.Drawing.Point(29, 68)
        Me.lblTenSach.Name = "lblTenSach"
        Me.lblTenSach.Size = New System.Drawing.Size(61, 13)
        Me.lblTenSach.TabIndex = 0
        Me.lblTenSach.Text = "TÊN SÁCH"
        '
        'lblTacGIa
        '
        Me.lblTacGIa.AutoSize = True
        Me.lblTacGIa.Location = New System.Drawing.Point(29, 100)
        Me.lblTacGIa.Name = "lblTacGIa"
        Me.lblTacGIa.Size = New System.Drawing.Size(49, 13)
        Me.lblTacGIa.TabIndex = 0
        Me.lblTacGIa.Text = "TÁC GIẢ"
        '
        'lblGiaBan
        '
        Me.lblGiaBan.AutoSize = True
        Me.lblGiaBan.Location = New System.Drawing.Point(29, 134)
        Me.lblGiaBan.Name = "lblGiaBan"
        Me.lblGiaBan.Size = New System.Drawing.Size(50, 13)
        Me.lblGiaBan.TabIndex = 0
        Me.lblGiaBan.Text = "GIÁ BÁN"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(90, 65)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(260, 20)
        Me.txtTenSach.TabIndex = 1
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(90, 97)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(260, 20)
        Me.txtTacGia.TabIndex = 1
        '
        'txtGiaBan
        '
        Me.txtGiaBan.Location = New System.Drawing.Point(90, 123)
        Me.txtGiaBan.Name = "txtGiaBan"
        Me.txtGiaBan.Size = New System.Drawing.Size(260, 20)
        Me.txtGiaBan.TabIndex = 1
        '
        'btnSuaSach
        '
        Me.btnSuaSach.Location = New System.Drawing.Point(113, 208)
        Me.btnSuaSach.Name = "btnSuaSach"
        Me.btnSuaSach.Size = New System.Drawing.Size(75, 23)
        Me.btnSuaSach.TabIndex = 2
        Me.btnSuaSach.Text = "Sửa"
        Me.btnSuaSach.UseVisualStyleBackColor = True
        '
        'btnXoaSach
        '
        Me.btnXoaSach.Location = New System.Drawing.Point(194, 208)
        Me.btnXoaSach.Name = "btnXoaSach"
        Me.btnXoaSach.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaSach.TabIndex = 2
        Me.btnXoaSach.Text = "Xóa"
        Me.btnXoaSach.UseVisualStyleBackColor = True
        '
        'btnQuayLaiSach
        '
        Me.btnQuayLaiSach.Location = New System.Drawing.Point(275, 208)
        Me.btnQuayLaiSach.Name = "btnQuayLaiSach"
        Me.btnQuayLaiSach.Size = New System.Drawing.Size(75, 23)
        Me.btnQuayLaiSach.TabIndex = 2
        Me.btnQuayLaiSach.Text = "Quay Lại"
        Me.btnQuayLaiSach.UseVisualStyleBackColor = True
        '
        'dgvSach
        '
        Me.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSach.Location = New System.Drawing.Point(404, 29)
        Me.dgvSach.Name = "dgvSach"
        Me.dgvSach.Size = New System.Drawing.Size(439, 263)
        Me.dgvSach.TabIndex = 3
        '
        'Sach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 402)
        Me.Controls.Add(Me.dgvSach)
        Me.Controls.Add(Me.btnQuayLaiSach)
        Me.Controls.Add(Me.btnXoaSach)
        Me.Controls.Add(Me.btnSuaSach)
        Me.Controls.Add(Me.btnThemSach)
        Me.Controls.Add(Me.txtGiaBan)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.lblGiaBan)
        Me.Controls.Add(Me.lblTacGIa)
        Me.Controls.Add(Me.lblTenSach)
        Me.Controls.Add(Me.lblMaSach)
        Me.Name = "Sach"
        Me.Text = "THÔNG TIN SÁCH"
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaSach As System.Windows.Forms.Label
    Friend WithEvents txtMaSach As System.Windows.Forms.TextBox
    Friend WithEvents btnThemSach As System.Windows.Forms.Button
    Friend WithEvents lblTenSach As System.Windows.Forms.Label
    Friend WithEvents lblTacGIa As System.Windows.Forms.Label
    Friend WithEvents lblGiaBan As System.Windows.Forms.Label
    Friend WithEvents txtTenSach As System.Windows.Forms.TextBox
    Friend WithEvents txtTacGia As System.Windows.Forms.TextBox
    Friend WithEvents txtGiaBan As System.Windows.Forms.TextBox
    Friend WithEvents btnSuaSach As System.Windows.Forms.Button
    Friend WithEvents btnXoaSach As System.Windows.Forms.Button
    Friend WithEvents btnQuayLaiSach As System.Windows.Forms.Button
    Friend WithEvents dgvSach As System.Windows.Forms.DataGridView
End Class
