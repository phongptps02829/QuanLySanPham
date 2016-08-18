Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class KH
    Private Sub KH_Load() Handles MyBase.Load
        Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSoure As New BindingSource
        Try
            MySQLConnection.Open()
            Dim Query As String
            Query = "select MaKH,TenKH,MST,DiaChi,SDT   from sql6131349.khach_hang"
            Dim command As New MySqlCommand(Query, MySQLConnection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSoure.DataSource = dbDataSet
            DataKH.DataSource = bSoure
            SDA.Update(dbDataSet)
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Insert_KH_Click(sender As Object, e As EventArgs) Handles aKH.Click
        Try
            If TextMaKH.Text = "" Then
                MessageBox.Show("Chua nhap ma khach hang")
                TextMaKH.Focus()
            ElseIf TextTKH.Text = "" Then
                MessageBox.Show("Chua nhap ten khach hang")
                TextTKH.Focus()
            ElseIf TextMST.Text = "" Then
                MessageBox.Show("Chua nhap MST")
                TextMST.Focus()
            ElseIf TextBoxDC.Text = "Chọn" Then
                MessageBox.Show("Chua chọn ma loai Dia Chi")
                TextBoxDC.Focus()
            ElseIf TextBoxSDT.Text = "" Then
                MessageBox.Show("Chua nhap SDT")
                TextBoxSDT.Focus()
            Else

                If IsNumeric(TextMaKH.Text).Equals(False) Then
                    MessageBox.Show("Chua nhap so luong bang so")
                    TextMaKH.Focus()
                ElseIf IsNumber(TextMST.Text).Equals(False) Then
                    MessageBox.Show("MST co 9 so! mong nhap lai")
                    TextMST.Focus()
                ElseIf IsNumber(TextMST.Text).Equals(False) Then
                    MessageBox.Show("SDT co 9 so! mong nhap lai")
                    TextBoxSDT.Focus()
                Else
                    Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
                    Dim reader As MySqlDataReader
                    Try
                        MySQLConnection.Open()
                        Dim Query As String
                        Query = "insert into sql6131349.khach_hang (MaKH,TenKH,MST,DiaChi,SDT) values ('" & Convert.ToInt32(TextMaKH.Text) & "',
                                                                                                      '" & TextTKH.Text & "',
                                                                                                      '" & TextMST.Text & "',
                                                                                                      '" & TextBoxDC.Text & "',
                                                                                                      '" & TextBoxSDT.Text & "')"
                        Dim command As New MySqlCommand(Query, MySQLConnection)
                        reader = command.ExecuteReader
                        MessageBox.Show("Thêm thành công")
                        TextMaKH.Clear()
                        TextTKH.Clear()
                        TextMST.Clear()
                        TextBoxDC.Clear()
                        TextBoxSDT.Clear()
                        MySQLConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    KH_Load()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Delete_KH_Click(sender As Object, e As EventArgs) Handles dKH.Click
        Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
        Dim reader As MySqlDataReader
        Try
            MySQLConnection.Open()
            Dim QueryHD As String
            QueryHD = "delete from sql6131349.hoa_don where MaKH = '" & Convert.ToInt32(TextMaKH.Text) & "' "
            Dim commandHD As New MySqlCommand(QueryHD, MySQLConnection)
            reader = commandHD.ExecuteReader
            MySQLConnection.Close()
            MySQLConnection.Open()
            Dim QueryCTHD As String
            QueryCTHD = "delete from sql6131349.chi_tiet_hd where MaKH = '" & Convert.ToInt32(TextMaKH.Text) & "' "
            Dim commandCTHD As New MySqlCommand(QueryCTHD, MySQLConnection)
            reader = commandCTHD.ExecuteReader
            MySQLConnection.Close()
            MySQLConnection.Open()
            Dim Query As String
            Query = "delete from sql6131349.khach_hang where MaKH = '" & Convert.ToInt32(TextMaKH.Text) & "' "
            Dim command As New MySqlCommand(Query, MySQLConnection)
            reader = command.ExecuteReader
            MessageBox.Show("Delete Success or MaKH not exist")
            TextMaKH.Clear()
            TextTKH.Clear()
            TextMST.Clear()
            TextBoxDC.Clear()
            TextBoxSDT.Clear()
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        KH_Load()
    End Sub
    Private Sub Update_KH_Click(sender As Object, e As EventArgs) Handles uKH.Click
        If TextMaKH.Text = "" Then
            MessageBox.Show("Chua nhap ma khach hang")
            TextMaKH.Focus()
        ElseIf TextTKH.Text = "" Then
            MessageBox.Show("Chua nhap ten khach hang")
            TextTKH.Focus()
        ElseIf TextMST.Text = "" Then
            MessageBox.Show("Chua nhap MST")
            TextMST.Focus()
        ElseIf TextBoxDC.Text = "Chọn" Then
            MessageBox.Show("Chua chọn ma loai Dia Chi")
            TextBoxDC.Focus()
        ElseIf TextBoxSDT.Text = "" Then
            MessageBox.Show("Chua nhap SDT")
            TextBoxSDT.Focus()
        Else
            Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
            Dim reader As MySqlDataReader
            Try
                If IsNumeric(TextMaKH.Text).Equals("False") Then
                    MessageBox.Show("Chua nhap so luong bang so")
                    TextMaKH.Focus()
                ElseIf TextMST.Text.Length.Equals(8) And IsNumber(TextMST.Text) = False Then
                    MessageBox.Show("MST co 9 so! mong nhap lai")
                    TextMST.Focus()
                ElseIf TextMST.Text.Length.Equals(9) And IsNumber(TextMST.Text) = False Then
                    MessageBox.Show("MST co 9 so! mong nhap lai")
                    TextBoxSDT.Focus()
                Else
                    MySQLConnection.Open()
                    Dim Query As String
                    Query = "update sql6131349.khach_hang set TenKH ='" & TextTKH.Text & "', MST = '" & TextMST.Text & "', DiaChi = '" & TextBoxDC.Text & "',SDT = '" & TextBoxSDT.Text & "'  where MaKH = '" & Convert.ToInt32(TextMaKH.Text) & "' "
                    Dim command As New MySqlCommand(Query, MySQLConnection)
                    reader = command.ExecuteReader
                    MessageBox.Show("Update thành công! Hoac du lieu cua ban khong co trong csdl")
                    TextMaKH.Clear()
                    TextTKH.Clear()
                    TextMST.Clear()
                    TextBoxDC.Clear()
                    TextBoxSDT.Clear()
                    MySQLConnection.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            KH_Load()
        End If
    End Sub
    Private Sub Reset_KH_Click(sender As Object, e As EventArgs) Handles rKH.Click
        TextMaKH.Clear()
        TextTKH.Clear()
        TextMST.Clear()
        TextBoxDC.Clear()
        TextBoxSDT.Clear()
    End Sub
    Function IsNumber(ByVal num As String) As Boolean
        Static numExpression As New Regex("^[0-9]")
        Return numExpression.IsMatch(num)
    End Function
    Private Sub BACK_Click(sender As Object, e As EventArgs) Handles BACK.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataKH.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataKH.Rows(e.RowIndex)

            TextMaKH.Text = row.Cells("MaKH").Value.ToString
            TextTKH.Text = row.Cells("TenKH").Value.ToString
            TextMST.Text = row.Cells("MST").Value.ToString
            TextBoxDC.Text = row.Cells("DiaChi").Value.ToString
            TextBoxSDT.Text = row.Cells("SDT").Value.ToString

        End If
    End Sub
End Class