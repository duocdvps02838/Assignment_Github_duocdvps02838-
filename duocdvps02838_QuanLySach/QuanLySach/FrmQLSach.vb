Imports MySql.Data.MySqlClient


Public Class frmQLSach

    Private Sub frmQLSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
        Try
            connec.Open()
            MessageBox.Show("Đã kết nối database")
            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub





    Private Sub ThôngTinKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinKháchHàngToolStripMenuItem.Click
        ThongTinKH.Show()

    End Sub

    Private Sub ThôngTinSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinSáchToolStripMenuItem.Click
        Sach.Show()

    End Sub

    Private Sub HÓAĐƠNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HÓAĐƠNToolStripMenuItem.Click
        HoaDon.Show()

    End Sub

    Private Sub THÔNGTINSẢNPHẨMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles THÔNGTINSẢNPHẨMToolStripMenuItem.Click
        GioiThieu.Show()

    End Sub

    Private Sub TÌMKIẾMKHÁCHHÀNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TÌMKIẾMKHÁCHHÀNGToolStripMenuItem.Click
        TimKiemKH.Show()

    End Sub

    Private Sub TÌMKIẾMSÁCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TÌMKIẾMSÁCHToolStripMenuItem.Click
        TimSach.Show()


    End Sub
End Class
