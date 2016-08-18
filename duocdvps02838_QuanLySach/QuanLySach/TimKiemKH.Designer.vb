<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiemKH
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
        Me.lblTimKiemKH = New System.Windows.Forms.Label()
        Me.txtTimKiemKH = New System.Windows.Forms.TextBox()
        Me.btnQuayTimKH = New System.Windows.Forms.Button()
        Me.dgvTimKiemKH = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTimKiemKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTimKiemKH
        '
        Me.lblTimKiemKH.AutoSize = True
        Me.lblTimKiemKH.Location = New System.Drawing.Point(12, 60)
        Me.lblTimKiemKH.Name = "lblTimKiemKH"
        Me.lblTimKiemKH.Size = New System.Drawing.Size(113, 13)
        Me.lblTimKiemKH.TabIndex = 0
        Me.lblTimKiemKH.Text = "TÌM KIẾM THEO TÊN"
        '
        'txtTimKiemKH
        '
        Me.txtTimKiemKH.Location = New System.Drawing.Point(131, 57)
        Me.txtTimKiemKH.Name = "txtTimKiemKH"
        Me.txtTimKiemKH.Size = New System.Drawing.Size(308, 20)
        Me.txtTimKiemKH.TabIndex = 1
        '
        'btnQuayTimKH
        '
        Me.btnQuayTimKH.Location = New System.Drawing.Point(15, 12)
        Me.btnQuayTimKH.Name = "btnQuayTimKH"
        Me.btnQuayTimKH.Size = New System.Drawing.Size(75, 23)
        Me.btnQuayTimKH.TabIndex = 2
        Me.btnQuayTimKH.Text = "Quay Lại"
        Me.btnQuayTimKH.UseVisualStyleBackColor = True
        '
        'dgvTimKiemKH
        '
        Me.dgvTimKiemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimKiemKH.Location = New System.Drawing.Point(15, 111)
        Me.dgvTimKiemKH.Name = "dgvTimKiemKH"
        Me.dgvTimKiemKH.Size = New System.Drawing.Size(424, 186)
        Me.dgvTimKiemKH.TabIndex = 3
        '
        'TimKiemKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 309)
        Me.Controls.Add(Me.dgvTimKiemKH)
        Me.Controls.Add(Me.btnQuayTimKH)
        Me.Controls.Add(Me.txtTimKiemKH)
        Me.Controls.Add(Me.lblTimKiemKH)
        Me.Name = "TimKiemKH"
        Me.Text = "TÌM KIẾM KHÁCH HÀNG"
        CType(Me.dgvTimKiemKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTimKiemKH As System.Windows.Forms.Label
    Friend WithEvents txtTimKiemKH As System.Windows.Forms.TextBox
    Friend WithEvents btnQuayTimKH As System.Windows.Forms.Button
    Friend WithEvents dgvTimKiemKH As System.Windows.Forms.DataGridView
End Class
