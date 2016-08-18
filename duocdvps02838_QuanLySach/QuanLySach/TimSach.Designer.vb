<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimSach
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
        Me.btnQuaySach = New System.Windows.Forms.Button()
        Me.lblTimSach = New System.Windows.Forms.Label()
        Me.txtTimSach = New System.Windows.Forms.TextBox()
        Me.dgvTimSach = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTimSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuaySach
        '
        Me.btnQuaySach.Location = New System.Drawing.Point(26, 12)
        Me.btnQuaySach.Name = "btnQuaySach"
        Me.btnQuaySach.Size = New System.Drawing.Size(75, 23)
        Me.btnQuaySach.TabIndex = 0
        Me.btnQuaySach.Text = "Quay Lại"
        Me.btnQuaySach.UseVisualStyleBackColor = True
        '
        'lblTimSach
        '
        Me.lblTimSach.AutoSize = True
        Me.lblTimSach.Location = New System.Drawing.Point(23, 70)
        Me.lblTimSach.Name = "lblTimSach"
        Me.lblTimSach.Size = New System.Drawing.Size(116, 13)
        Me.lblTimSach.TabIndex = 1
        Me.lblTimSach.Text = "TÌM SÁCH THEO TÊN"
        '
        'txtTimSach
        '
        Me.txtTimSach.Location = New System.Drawing.Point(154, 67)
        Me.txtTimSach.Name = "txtTimSach"
        Me.txtTimSach.Size = New System.Drawing.Size(290, 20)
        Me.txtTimSach.TabIndex = 2
        '
        'dgvTimSach
        '
        Me.dgvTimSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimSach.Location = New System.Drawing.Point(26, 115)
        Me.dgvTimSach.Name = "dgvTimSach"
        Me.dgvTimSach.Size = New System.Drawing.Size(418, 204)
        Me.dgvTimSach.TabIndex = 3
        '
        'TimSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 331)
        Me.Controls.Add(Me.dgvTimSach)
        Me.Controls.Add(Me.txtTimSach)
        Me.Controls.Add(Me.lblTimSach)
        Me.Controls.Add(Me.btnQuaySach)
        Me.Name = "TimSach"
        Me.Text = "TimSach"
        CType(Me.dgvTimSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuaySach As System.Windows.Forms.Button
    Friend WithEvents lblTimSach As System.Windows.Forms.Label
    Friend WithEvents txtTimSach As System.Windows.Forms.TextBox
    Friend WithEvents dgvTimSach As System.Windows.Forms.DataGridView
End Class
