Imports MySql.Data.MySqlClient

Public Class Sach

    'HAM LOAD DU LIEU

    Private Sub load_Table()
        Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSoure As New BindingSource
        Try
            connec.Open()
            Dim Query As String
            Query = "select * from sql6131346.sach"
            Dim command As New MySqlCommand(Query, connec)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSoure.DataSource = dbDataSet
            dgvSach.DataSource = bSoure
            SDA.Update(dbDataSet)
            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnQuayLaiSach_Click(sender As Object, e As EventArgs) Handles btnQuayLaiSach.Click
        frmQLSach.Show()
        Me.Hide()

    End Sub


    'XOA SACH

    Private Sub btnXoaSach_Click(sender As Object, e As EventArgs) Handles btnXoaSach.Click
             Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
        Dim reader As MySqlDataReader
        Try
            connec.Open()
            Dim Query As String
            Query = "delete from sql6131346.sach where MASACH ='" & txtMaSach.Text & "'"
            Dim command As New MySqlCommand(Query, connec)
            reader = command.ExecuteReader
            MessageBox.Show("Delete thành công")
            txtMaSach.Clear()
            txtTenSach.Clear()
            txtTacGia.Clear()
            txtGiaBan.Clear()

            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        load_Table()
    End Sub

    'SUA SACH

    Private Sub btnSuaSach_Click(sender As Object, e As EventArgs) Handles btnSuaSach.Click
        If txtMaSach.Text = "" Then
            MessageBox.Show("Mã sách không được để trống")
        ElseIf txtTenSach.Text = "" Then
            MessageBox.Show("Tên sách không được để trống")
        ElseIf txtTacGia.Text = "" Then
            MessageBox.Show("Tác giả không được để trống")
        ElseIf txtGiaBan.Text = "" Then
            MessageBox.Show("Giá không được để trống")
        Else
            Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
            Dim reader As MySqlDataReader
            Try
                connec.Open()
                Dim Query As String
                Query = "update sql6131346.sach set TENSACH='" & txtTenSach.Text & "',TACGIA='" & txtTacGia.Text & "',GIABAN='" & txtGiaBan.Text & "' where MASACH='" & txtMaSach.Text & "'"
                Dim command As New MySqlCommand(Query, connec)
                reader = command.ExecuteReader
                MessageBox.Show("Update thành công")
                txtMaSach.Clear()
                txtTenSach.Clear()
                txtTacGia.Clear()
                txtGiaBan.Clear()


                connec.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            load_Table()
        End If
    End Sub

    'THEM SACH

    Private Sub btnThemSach_Click(sender As Object, e As EventArgs) Handles btnThemSach.Click
        If txtMaSach.Text = "" Then
            MessageBox.Show("Mã sách không được để trống")
        ElseIf txtTenSach.Text = "" Then
            MessageBox.Show("Tên sách không được để trống")
        ElseIf txtTacGia.Text = "" Then
            MessageBox.Show("Tác giả không được để trống")
        ElseIf txtGiaBan.Text = "" Then
            MessageBox.Show("Gía bán không được để trống")
       
        Else
            Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
            Dim reader As MySqlDataReader
            Try
                connec.Open()
                Dim Query As String
                Query = "insert into sql6131346.sach (MASACH,TENSACH,TACGIA,GIABAN) values ('" & txtMaSach.Text & "','" & txtTenSach.Text & "','" & txtTacGia.Text & "','" & txtGiaBan.Text & "')"
                Dim command As New MySqlCommand(Query, connec)
                reader = command.ExecuteReader
                MessageBox.Show("Thêm thành công")
                txtMaSach.Clear()
                txtTenSach.Clear()
                txtTacGia.Clear()
                txtGiaBan.Clear()

                connec.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            load_Table()
        End If
    End Sub

    Private Sub dgvSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSach.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvSach.Rows(e.RowIndex)

            txtMaSach.Text = row.Cells("MASACH").Value.ToString
            txtTenSach.Text = row.Cells("TENSACH").Value.ToString
            txtTacGia.Text = row.Cells("TACGIA").Value.ToString
            txtGiaBan.Text = row.Cells("GIABAN").Value.ToString



        End If
    End Sub

    'LOAD DU LIEU

    Private Sub Sach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Table()
        Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
        Dim reader As MySqlDataReader
        Try
            connec.Open()
            Dim Query As String
            Query = "SELECT MASACH FROM sql6131346.sach"
            Dim command As New MySqlCommand(Query, connec)
            reader = command.ExecuteReader
            While reader.Read
                
            End While

            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class