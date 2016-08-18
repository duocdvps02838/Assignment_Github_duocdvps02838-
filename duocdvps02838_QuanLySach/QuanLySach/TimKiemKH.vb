Imports MySql.Data.MySqlClient
Public Class TimKiemKH

    Dim dbDataSet As New DataTable


    Private Sub btnQuayTimKH_Click(sender As Object, e As EventArgs) Handles btnQuayTimKH.Click
        frmQLSach.Show()
        Me.Hide()

    End Sub

    Private Sub load_Table()
        Dim connec As New MySqlConnection("server=sql6.freesqldatabase.com;user=sql6131346;password=ttkh6WWFjc;database=sql6131346")
        Dim SDA As New MySqlDataAdapter

        Dim bSoure As New BindingSource
        Try
            connec.Open()
            Dim Query As String
            Query = "select * from sql6131346.khachhang"
            Dim command As New MySqlCommand(Query, connec)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSoure.DataSource = dbDataSet
            dgvTimKiemKH.DataSource = bSoure
            SDA.Update(dbDataSet)
            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiemKH.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("TENKH Like '%{0}%'", txtTimKiemKH.Text)
        dgvTimKiemKH.DataSource = DV
    End Sub

   
    Private Sub TimKiemKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Table()
    End Sub
End Class