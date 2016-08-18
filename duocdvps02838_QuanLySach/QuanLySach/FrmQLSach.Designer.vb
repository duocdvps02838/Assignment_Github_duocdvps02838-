<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLSach))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThôngTinKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TÌMKIẾMKHÁCHHÀNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TÌMKIẾMSÁCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HÓAĐƠNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.THÔNGTINSẢNPHẨMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinKháchHàngToolStripMenuItem, Me.ThôngTinSáchToolStripMenuItem, Me.HÓAĐƠNToolStripMenuItem, Me.THÔNGTINSẢNPHẨMToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(643, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThôngTinKháchHàngToolStripMenuItem
        '
        Me.ThôngTinKháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TÌMKIẾMKHÁCHHÀNGToolStripMenuItem})
        Me.ThôngTinKháchHàngToolStripMenuItem.Name = "ThôngTinKháchHàngToolStripMenuItem"
        Me.ThôngTinKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(164, 20)
        Me.ThôngTinKháchHàngToolStripMenuItem.Text = "THÔNG TIN KHÁCH HÀNG"
        '
        'TÌMKIẾMKHÁCHHÀNGToolStripMenuItem
        '
        Me.TÌMKIẾMKHÁCHHÀNGToolStripMenuItem.Name = "TÌMKIẾMKHÁCHHÀNGToolStripMenuItem"
        Me.TÌMKIẾMKHÁCHHÀNGToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TÌMKIẾMKHÁCHHÀNGToolStripMenuItem.Text = "TÌM KIẾM KHÁCH HÀNG"
        '
        'ThôngTinSáchToolStripMenuItem
        '
        Me.ThôngTinSáchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TÌMKIẾMSÁCHToolStripMenuItem})
        Me.ThôngTinSáchToolStripMenuItem.Name = "ThôngTinSáchToolStripMenuItem"
        Me.ThôngTinSáchToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.ThôngTinSáchToolStripMenuItem.Text = "THÔNG TIN SÁCH"
        '
        'TÌMKIẾMSÁCHToolStripMenuItem
        '
        Me.TÌMKIẾMSÁCHToolStripMenuItem.Name = "TÌMKIẾMSÁCHToolStripMenuItem"
        Me.TÌMKIẾMSÁCHToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TÌMKIẾMSÁCHToolStripMenuItem.Text = "TÌM KIẾM SÁCH"
        '
        'HÓAĐƠNToolStripMenuItem
        '
        Me.HÓAĐƠNToolStripMenuItem.Name = "HÓAĐƠNToolStripMenuItem"
        Me.HÓAĐƠNToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.HÓAĐƠNToolStripMenuItem.Text = "HÓA ĐƠN"
        '
        'THÔNGTINSẢNPHẨMToolStripMenuItem
        '
        Me.THÔNGTINSẢNPHẨMToolStripMenuItem.Name = "THÔNGTINSẢNPHẨMToolStripMenuItem"
        Me.THÔNGTINSẢNPHẨMToolStripMenuItem.Size = New System.Drawing.Size(147, 20)
        Me.THÔNGTINSẢNPHẨMToolStripMenuItem.Text = "THÔNG TIN SẢN PHẨM"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(643, 253)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmQLSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 285)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmQLSach"
        Me.Text = "QUẢN LÝ SÁCH"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ThôngTinKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinSáchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HÓAĐƠNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents THÔNGTINSẢNPHẨMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TÌMKIẾMKHÁCHHÀNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TÌMKIẾMSÁCHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
