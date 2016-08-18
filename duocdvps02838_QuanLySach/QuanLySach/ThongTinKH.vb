Imports System.Data
Imports MySql.Data.MySqlClient


Public Class ThongTinKH
    'QUAY LAI TRANG QUAN LY

    Private Sub btnQuaylaiKH_Click(sender As Object, e As EventArgs) Handles btnQuaylaiKH.Click
        frmQLSach.Show()
        Me.Hide()
    End Sub

    'THEM KHACH HANG

    Private Sub btnThemKH_Click(sender As Object, e As EventArgs) Handles btnThemKH.Click
        If txtMaKH.Text = "" Then
            MessageBox.Show("Mã khách hàng không được để trống")
        ElseIf txtTenKH.Text = "" Then
            MessageBox.Show("Tên khách hàng không được để trống")
        ElseIf txtDiaChi.Text = "" Then
            MessageBox.Show("Địa chỉ không được để trống")
        ElseIf txtDT.Text = "" Then
            MessageBox.Show("Số điện thoại không được để trống")
        Else
            Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
            Dim reader As MySqlDataReader
            Try
                connec.Open()
                Dim Query As String
                Query = "insert into sql6131346.khachhang (MAKH,TENKH,DIACHI,DIENTHOAI) values ('" & txtMaKH.Text & "','" & txtTenKH.Text & "','" & txtDiaChi.Text & "','" & txtDT.Text & "')"
                Dim command As New MySqlCommand(Query, connec)
                reader = command.ExecuteReader
                MessageBox.Show("Thêm thành công")
                txtMaKH.Clear()
                txtTenKH.Clear()
                txtDT.Clear()
                txtDiaChi.Clear()

                connec.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            load_Table()
        End If
    End Sub

    'ham laod du lieu lên de co the xoa

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvKH.Rows(e.RowIndex)

            txtMaKH.Text = row.Cells("MAKH").Value.ToString
            txtTenKH.Text = row.Cells("TENKH").Value.ToString
            txtDiaChi.Text = row.Cells("DIACHI").Value.ToString
            txtDT.Text = row.Cells("DIENTHOAI").Value.ToString

        End If
    End Sub


    'HAM LOAD DATABASE LEN 

    Private Sub load_Table()
        Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSoure As New BindingSource
        Try
            connec.Open()
            Dim Query As String
            Query = "select * from sql6131346.khachhang"
            Dim command As New MySqlCommand(Query, connec)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSoure.DataSource = dbDataSet
            dgvKH.DataSource = bSoure
            SDA.Update(dbDataSet)
            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'XOA KHACH HANG

    Private Sub btnXoaKH_Click(sender As Object, e As EventArgs) Handles btnXoaKH.Click
        Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
        Dim reader As MySqlDataReader
        Try
            connec.Open()
            Dim Query As String
            Query = "delete from sql6131346.khachhang where MAKH ='" & txtMaKH.Text & "'"
            Dim command As New MySqlCommand(Query, connec)
            reader = command.ExecuteReader
            MessageBox.Show("Delete thành công")
            txtMaKH.Clear()
            txtTenKH.Clear()
            txtDT.Clear()
            txtDiaChi.Clear()

            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        load_Table()
    End Sub


    'SUA KHACH HANG

    Private Sub btnSuaKH_Click(sender As Object, e As EventArgs) Handles btnSuaKH.Click
        If txtMaKH.Text = "" Then
            MessageBox.Show("Mã khách hàng không được để trống")
        ElseIf txtTenKH.Text = "" Then
            MessageBox.Show("Tên khách hàng không được để trống")
        ElseIf txtDiaChi.Text = "" Then
            MessageBox.Show("Địa chỉ không được để trống")
        ElseIf txtDT.Text = "" Then
            MessageBox.Show("Số điện thoại không được để trống")
        Else
            Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
            Dim reader As MySqlDataReader
            Try
                connec.Open()
                Dim Query As String
                Query = "update sql6131346.khachhang set TENKH='" & txtTenKH.Text & "',DIACHI='" & txtDiaChi.Text & "',DIENTHOAI='" & txtDT.Text & "' where MAKH='" & txtMaKH.Text & "'"
                Dim command As New MySqlCommand(Query, connec)
                reader = command.ExecuteReader
                MessageBox.Show("Update thành công")
                txtMaKH.Clear()
                txtTenKH.Clear()
                txtDT.Clear()
                txtDiaChi.Clear()


                connec.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            load_Table()
        End If
    End Sub

    Private Sub ThongTinKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Table()
    End Sub

   

    
End Class