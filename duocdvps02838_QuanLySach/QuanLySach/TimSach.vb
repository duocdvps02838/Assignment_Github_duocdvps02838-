Imports MySql.Data.MySqlClient

Public Class TimSach

    Dim dbDataSet As New DataTable

    Private Sub btnQuaySach_Click(sender As Object, e As EventArgs) Handles btnQuaySach.Click
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
            Query = "select * from sql6131346.sach"
            Dim command As New MySqlCommand(Query, connec)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSoure.DataSource = dbDataSet
            dgvTimSach.DataSource = bSoure
            SDA.Update(dbDataSet)
            connec.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtTimSach_TextChanged(sender As Object, e As EventArgs) Handles txtTimSach.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("TENSACH Like '%{0}%'", txtTimSach.Text)
        dgvTimSach.DataSource = DV
    End Sub

    Private Sub TimSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Table()
    End Sub
End Class