Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
        Try
            MySQLConnection.Open()
            MessageBox.Show("Đã kết nối database")
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Sanpham_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SanPham.Show()
        Me.Hide()
    End Sub

    Private Sub HoaDon_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KH.Show()
        Me.Hide()
    End Sub
End Class