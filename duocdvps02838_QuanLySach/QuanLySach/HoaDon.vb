Imports MySql.Data.MySqlClient

Public Class HoaDon

    Private Sub btnQuayLaiHD_Click(sender As Object, e As EventArgs) Handles btnQuayLaiHD.Click
        frmQLSach.Show()
        Me.Hide()

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
            Query = "select * from sql6131346.hoadon"
            Dim command As New MySqlCommand(Query, connec)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSoure.DataSource = dbDataSet
            dgvHoaDon.DataSource = bSoure
            SDA.Update(dbDataSet)
            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'LOAD HOA DON LEN DATAGRIDVIEW
    Private Sub HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Table()
        Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
        Dim reader As MySqlDataReader

        Try
            connec.Open()
            Dim Query As String
            Query = "SELECT MAHD FROM sql6131346.hoadon"
            Dim command As New MySqlCommand(Query, connec)
            reader = command.ExecuteReader
            While reader.Read
              
            End While

            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'THEM HOA DON MOI

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtMaHD.Text = "" Then
            MessageBox.Show("Mã hóa đơn không được để trống")
        ElseIf txtMaKH_HD.Text = "" Then
            MessageBox.Show("Mã khách hàng không được để trống")
        ElseIf txtNgayLap.Text = "" Then
            MessageBox.Show("Ngày lập không được để trống")
        Else
            Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
            Dim reader As MySqlDataReader
            Try
                connec.Open()
                Dim Query As String
                Query = "insert into sql6131346.hoadon (MAHD,MAKH,NGAYLAP) values ('" & txtMaHD.Text & "','" & txtMaKH_HD.Text & "','" & txtNgayLap.Text & "')"
                Dim command As New MySqlCommand(Query, connec)
                reader = command.ExecuteReader
                MessageBox.Show("Thêm thành công")
                txtMaHD.Clear()

                connec.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            load_Table()
        End If
    End Sub


    'SUA HOA DON

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaHD.Text = "" Then
            MessageBox.Show("Mã hóa đơn không được để trống")
        ElseIf txtMaKH_HD.Text = "" Then
            MessageBox.Show("Mã sách không được để trống")
        ElseIf txtNgayLap.Text = "" Then
            MessageBox.Show("Ngày lập không được để trống")
        Else
            Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
            Dim reader As MySqlDataReader
            Try
                connec.Open()
                Dim Query As String
                Query = "update sql6131346.hoadon set MAKH='" & txtMaKH_HD.Text & "',NGAYLAP='" & txtNgayLap.Text & "' where MAHD = '" & txtMaHD.Text & "'"
                Dim command As New MySqlCommand(Query, connec)
                reader = command.ExecuteReader
                MessageBox.Show("Update thành công")
                txtMaHD.Clear()

                connec.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            load_Table()
        End If
    End Sub


    'XOA HOA DON

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
        Dim reader As MySqlDataReader
        Try
            connec.Open()
            Dim Query As String
            Query = "delete from sql6131346.hoadon where MAHD='" & txtMaHD.Text & "'"
            Dim command As New MySqlCommand(Query, connec)
            reader = command.ExecuteReader
            MessageBox.Show("Delete thành công")
            txtMaHD.Clear()
            txtMaKH_HD.Clear()
            txtNgayLap.Clear()
            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        load_Table()
    End Sub
    ' LOAD DU LIEU LEN DE CO THE XOA
    Private Sub dgvHoaDon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvHoaDon.Rows(e.RowIndex)

            txtMaHD.Text = row.Cells("MAHD").Value.ToString
            txtMaKH_HD.Text = row.Cells("MAKH").Value.ToString
            txtNgayLap.Text = row.Cells("NGAYLAP").Value.ToString


        End If
    End Sub
End Class