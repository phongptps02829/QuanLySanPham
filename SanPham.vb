Imports MySql.Data.MySqlClient

Public Class SanPham


    Dim RD As MySqlDataReader
    Private Sub Reset_Button() Handles ResetDataInput.Click
        reset()
    End Sub
    Private Sub reset()
        MSP.Text = ""
        TSP.Text = ""
        SL.Text = ""
        GT.Text = ""
    End Sub
    Private Sub MaLSP_Combobox(sender As Object, e As EventArgs) Handles MyBase.Load
        load_DataTable()
        Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
        Dim reader As MySqlDataReader
        Try
            MySQLConnection.Open()
            Dim Query As String
            Query = "SELECT Ma_Loai_SP FROM sql6131349.loai_sp"
            Dim command As New MySqlCommand(Query, MySQLConnection)
            reader = command.ExecuteReader
            While reader.Read
                Dim data = reader.GetString("Ma_Loai_SP")
                MLSP.Items.Add(data)
            End While

            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub load_DataTable() Handles MyBase.Load
        Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSoure As New BindingSource
        Try
            MySQLConnection.Open()
            Dim Query As String
            Query = "select MaSP,TenSP,SL,GiaTien,Ma_Loai_SP from sql6131349.san_pham"
            Dim command As New MySqlCommand(Query, MySQLConnection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSoure.DataSource = dbDataSet
            DataGridView1.DataSource = bSoure
            SDA.Update(dbDataSet)
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        Try
            If MSP.Text = "" Then
                MessageBox.Show("Chua nhap mã sản phẩm")
                MSP.Focus()
            ElseIf TSP.Text = "" Then
                MessageBox.Show("Chua nhap Tên sản phẩm")
                TSP.Focus()
            ElseIf SL.Text = "" Then
                MessageBox.Show("Chua nhap Số lượng")
                SL.Focus()
            ElseIf GT.Text = "" Then
                MessageBox.Show("Chua nhap đơn giá")
                GT.Focus()
            ElseIf MLSP.Text = "Chọn" Then
                MessageBox.Show("Chua chọn ma loai san pham")
                MLSP.Focus()
            Else

                If IsNumeric(SL.Text).Equals("False") Then
                    MessageBox.Show("Chua nhap so luong bang so")
                    GT.Focus()
                ElseIf IsNumeric(GT.Text).Equals("False") Then
                    MessageBox.Show("Chua nhap don gia bang so")
                    SL.Focus()
                Else
                    Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
                    Dim reader As MySqlDataReader
                    Try
                        MySQLConnection.Open()
                        Dim Query As String
                        Query = "insert into sql6131349.san_pham (MaSP,TenSP,SL,GiaTien,Ma_Loai_SP) values ('" & MSP.Text & "','" & TSP.Text & "','" & Convert.ToInt32(SL.Text) & "','" & Convert.ToInt32(GT.Text) & "','" & MLSP.Text & "')"
                        Dim command As New MySqlCommand(Query, MySQLConnection)
                        reader = command.ExecuteReader
                        MessageBox.Show("Thêm thành công")
                        MSP.Clear()
                        TSP.Clear()
                        SL.Clear()
                        GT.Clear()
                        MySQLConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    load_DataTable()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        If MSP.Text = "" Then
            MessageBox.Show("Chua nhap mã sản phẩm")
            MSP.Focus()
        ElseIf TSP.Text = "" Then
            MessageBox.Show("Chua nhap Tên sản phẩm")
            TSP.Focus()
        ElseIf SL.Text = "" Then
            MessageBox.Show("Chua nhap Số lượng")
            SL.Focus()
        ElseIf GT.Text = "" Then
            MessageBox.Show("Chua nhap đơn giá")
            GT.Focus()
        ElseIf MLSP.Text = "Chọn" Then
            MessageBox.Show("Chua chọn ma loai san pham")
            MLSP.Focus()
        Else
            Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
            Dim reader As MySqlDataReader
            Try
                MySQLConnection.Open()
                Dim Query As String
                Query = "update sql6131349.san_pham set  TenSP = '" & TSP.Text & "',SL = '" & Convert.ToInt32(SL.Text) & "',GiaTien = '" & Convert.ToInt32(GT.Text) & "',Ma_Loai_SP = '" & MLSP.Text & "' where MaSP = '" & MSP.Text & "'  "
                Dim command As New MySqlCommand(Query, MySQLConnection)
                reader = command.ExecuteReader
                MessageBox.Show("Update thành công")
                MSP.Clear()
                TSP.Clear()
                SL.Clear()
                GT.Clear()
                MySQLConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            load_DataTable()
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
        Dim reader As MySqlDataReader
        Try
            MySQLConnection.Open()
            Dim Query As String
            Query = "delete from sql6131349.san_pham where MaSP= '" & MSP.Text & "' "
            Dim command As New MySqlCommand(Query, MySQLConnection)
            reader = command.ExecuteReader
            MessageBox.Show("Delete Success or MaSP not exist")
            MSP.Clear()
            TSP.Clear()
            SL.Clear()
            GT.Clear()
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        load_DataTable()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            MSP.Text = row.Cells("MaSP").Value.ToString

            TSP.Text = row.Cells("TenSP").Value.ToString

            SL.Text = row.Cells("SL").Value.ToString

            GT.Text = row.Cells("GiaTien").Value.ToString

            MLSP.Text = row.Cells("Ma_Loai_SP").Value.ToString

        End If
    End Sub

    Private Sub load_DataTable_2() Handles MyBase.Load
        Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSoure As New BindingSource
        Try
            MySQLConnection.Open()
            Dim Query As String
            Query = "select  Ma_Loai_SP,Loai_SP from sql6131349.loai_sp"
            Dim command As New MySqlCommand(Query, MySQLConnection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSoure.DataSource = dbDataSet
            DataGridView2.DataSource = bSoure
            SDA.Update(dbDataSet)
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView2.Rows(e.RowIndex)

            TextBox_Ma_Loai_SP.Text = row.Cells("Ma_Loai_SP").Value.ToString

            TextBox_LoaiSP.Text = row.Cells("Loai_SP").Value.ToString

        End If
    End Sub

    Private Sub Insert_MaSP_Click(sender As Object, e As EventArgs) Handles addLSP.Click
        Try
            If TextBox_Ma_Loai_SP.Text = "" Then
                MessageBox.Show("Chua nhap ma loai san pham")
                TextBox_Ma_Loai_SP.Focus()
            ElseIf TextBox_LoaiSP.Text = "" Then
                MessageBox.Show("Chua nhap Tên sản phẩm")
                TextBox_LoaiSP.Focus()

            Else
                Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
                Dim reader As MySqlDataReader
                Try
                    MySQLConnection.Open()
                    Dim Query As String
                    Query = "insert into  sql6131349.loai_sp (Ma_Loai_SP,Loai_SP) values ('" & TextBox_Ma_Loai_SP.Text & "','" & TextBox_LoaiSP.Text & "')"
                    Dim command As New MySqlCommand(Query, MySQLConnection)
                    reader = command.ExecuteReader
                    MessageBox.Show("Thêm thành công")
                    TextBox_Ma_Loai_SP.Clear()
                    TextBox_LoaiSP.Clear()
                    MySQLConnection.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                load_DataTable_2()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Update_Ma_LSP_Click(sender As Object, e As EventArgs) Handles upLSP.Click
        If TextBox_Ma_Loai_SP.Text = "" Then
            MessageBox.Show("Chua nhap mã sản phẩm")
            TextBox_Ma_Loai_SP.Focus()
        ElseIf TextBox_LoaiSP.Text = "" Then
            MessageBox.Show("Chua nhap Tên sản phẩm")
            TextBox_LoaiSP.Focus()
        Else
            Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
            Dim reader As MySqlDataReader
            Try
                MySQLConnection.Open()
                Dim Query As String
                Query = "update sql6131349.loai_sp set Loai_SP ='" & TextBox_LoaiSP.Text & "' where Ma_Loai_SP = '" & TextBox_Ma_Loai_SP.Text & "' "
                Dim command As New MySqlCommand(Query, MySQLConnection)
                reader = command.ExecuteReader
                MessageBox.Show("Update thành công! Hoac du lieu cua ban khong co trong csdl")
                TextBox_LoaiSP.Clear()
                MySQLConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            load_DataTable_2()
        End If
    End Sub

    Private Sub Delete_2_Click(sender As Object, e As EventArgs) Handles deLSP.Click
        Dim MySQLConnection As New MySqlConnection("server = sql6.freesqldatabase.com;user=sql6131349;password=u6VvdQXKcV;database=sql6131349")
        Dim reader As MySqlDataReader
        Try
            MySQLConnection.Open()
            Dim Query As String
            Query = "delete from sql6131349.loai_sp  where Ma_Loai_SP = '" & TextBox_Ma_Loai_SP.Text & "'"
            Dim command As New MySqlCommand(Query, MySQLConnection)
            reader = command.ExecuteReader
            MessageBox.Show("Delete Success or MaSP not exist")
            TextBox_Ma_Loai_SP.Clear()
            TextBox_LoaiSP.Clear()
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Du lieu dang duoc lien ket vơi chi tiet san pham khong thuc thi viec xoa du lieu truoc khi tat ca thong tin ve hoa don duoc xoa!")
        End Try
        load_DataTable_2()
    End Sub

    Private Sub Reset_Button_LSP(sender As Object, e As EventArgs) Handles resetLSP.Click
        TextBox_Ma_Loai_SP.Clear()
        TextBox_LoaiSP.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
