<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.MSP = New System.Windows.Forms.TextBox()
        Me.TSP = New System.Windows.Forms.TextBox()
        Me.SL = New System.Windows.Forms.TextBox()
        Me.GT = New System.Windows.Forms.TextBox()
        Me.MLSP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ResetDataInput = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.resetLSP = New System.Windows.Forms.Button()
        Me.deLSP = New System.Windows.Forms.Button()
        Me.upLSP = New System.Windows.Forms.Button()
        Me.addLSP = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_LoaiSP = New System.Windows.Forms.TextBox()
        Me.TextBox_Ma_Loai_SP = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(585, 149)
        Me.DataGridView1.TabIndex = 0
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(603, 13)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(139, 23)
        Me.Button_Add.TabIndex = 1
        Me.Button_Add.Text = "ADD"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Update
        '
        Me.Button_Update.Location = New System.Drawing.Point(603, 42)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(139, 23)
        Me.Button_Update.TabIndex = 2
        Me.Button_Update.Text = "UPDATE"
        Me.Button_Update.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(603, 71)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(139, 23)
        Me.Button_Delete.TabIndex = 3
        Me.Button_Delete.Text = "DELETE"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'MSP
        '
        Me.MSP.Location = New System.Drawing.Point(924, 12)
        Me.MSP.Name = "MSP"
        Me.MSP.Size = New System.Drawing.Size(223, 20)
        Me.MSP.TabIndex = 5
        '
        'TSP
        '
        Me.TSP.Location = New System.Drawing.Point(924, 42)
        Me.TSP.Name = "TSP"
        Me.TSP.Size = New System.Drawing.Size(223, 20)
        Me.TSP.TabIndex = 6
        '
        'SL
        '
        Me.SL.Location = New System.Drawing.Point(924, 73)
        Me.SL.Name = "SL"
        Me.SL.Size = New System.Drawing.Size(223, 20)
        Me.SL.TabIndex = 7
        '
        'GT
        '
        Me.GT.Location = New System.Drawing.Point(924, 103)
        Me.GT.Name = "GT"
        Me.GT.Size = New System.Drawing.Size(223, 20)
        Me.GT.TabIndex = 8
        '
        'MLSP
        '
        Me.MLSP.FormattingEnabled = True
        Me.MLSP.Location = New System.Drawing.Point(924, 130)
        Me.MLSP.Name = "MLSP"
        Me.MLSP.Size = New System.Drawing.Size(223, 21)
        Me.MLSP.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(857, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "MaSP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(857, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "TenSP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(857, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Số Lượng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(857, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Giá Tiền"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(857, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "MaLoaiSP"
        '
        'ResetDataInput
        '
        Me.ResetDataInput.Location = New System.Drawing.Point(603, 100)
        Me.ResetDataInput.Name = "ResetDataInput"
        Me.ResetDataInput.Size = New System.Drawing.Size(139, 23)
        Me.ResetDataInput.TabIndex = 15
        Me.ResetDataInput.Text = "RESET"
        Me.ResetDataInput.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 168)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(238, 215)
        Me.DataGridView2.TabIndex = 16
        '
        'resetLSP
        '
        Me.resetLSP.Location = New System.Drawing.Point(256, 257)
        Me.resetLSP.Name = "resetLSP"
        Me.resetLSP.Size = New System.Drawing.Size(139, 23)
        Me.resetLSP.TabIndex = 20
        Me.resetLSP.Text = "RESETLSP"
        Me.resetLSP.UseVisualStyleBackColor = True
        '
        'deLSP
        '
        Me.deLSP.Location = New System.Drawing.Point(256, 228)
        Me.deLSP.Name = "deLSP"
        Me.deLSP.Size = New System.Drawing.Size(139, 23)
        Me.deLSP.TabIndex = 19
        Me.deLSP.Text = "DELETELSP"
        Me.deLSP.UseVisualStyleBackColor = True
        '
        'upLSP
        '
        Me.upLSP.Location = New System.Drawing.Point(256, 199)
        Me.upLSP.Name = "upLSP"
        Me.upLSP.Size = New System.Drawing.Size(139, 23)
        Me.upLSP.TabIndex = 18
        Me.upLSP.Text = "UPDATELSP"
        Me.upLSP.UseVisualStyleBackColor = True
        '
        'addLSP
        '
        Me.addLSP.Location = New System.Drawing.Point(256, 170)
        Me.addLSP.Name = "addLSP"
        Me.addLSP.Size = New System.Drawing.Size(139, 23)
        Me.addLSP.TabIndex = 17
        Me.addLSP.Text = "ADDLSP"
        Me.addLSP.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Loai_SP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(258, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "MaLSP"
        '
        'TextBox_LoaiSP
        '
        Me.TextBox_LoaiSP.Location = New System.Drawing.Point(325, 316)
        Me.TextBox_LoaiSP.Name = "TextBox_LoaiSP"
        Me.TextBox_LoaiSP.Size = New System.Drawing.Size(223, 20)
        Me.TextBox_LoaiSP.TabIndex = 25
        '
        'TextBox_Ma_Loai_SP
        '
        Me.TextBox_Ma_Loai_SP.Location = New System.Drawing.Point(325, 286)
        Me.TextBox_Ma_Loai_SP.Name = "TextBox_Ma_Loai_SP"
        Me.TextBox_Ma_Loai_SP.Size = New System.Drawing.Size(223, 20)
        Me.TextBox_Ma_Loai_SP.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1008, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 393)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox_LoaiSP)
        Me.Controls.Add(Me.TextBox_Ma_Loai_SP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.resetLSP)
        Me.Controls.Add(Me.deLSP)
        Me.Controls.Add(Me.upLSP)
        Me.Controls.Add(Me.addLSP)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ResetDataInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MLSP)
        Me.Controls.Add(Me.GT)
        Me.Controls.Add(Me.SL)
        Me.Controls.Add(Me.TSP)
        Me.Controls.Add(Me.MSP)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Update)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SanPham"
        Me.Text = "SanPham"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Add As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents MSP As TextBox
    Friend WithEvents TSP As TextBox
    Friend WithEvents SL As TextBox
    Friend WithEvents GT As TextBox
    Friend WithEvents MLSP As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ResetDataInput As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents resetLSP As Button
    Friend WithEvents deLSP As Button
    Friend WithEvents upLSP As Button
    Friend WithEvents addLSP As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_LoaiSP As TextBox
    Friend WithEvents TextBox_Ma_Loai_SP As TextBox
    Friend WithEvents Button1 As Button
End Class
