<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LanggananForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.lblTarifLangganan = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblNomorPlat = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.Label()
        Me.lblBerlakuHingga = New System.Windows.Forms.Label()
        Me.lblIDPelanggan = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBiaya
        '
        Me.txtBiaya.Location = New System.Drawing.Point(123, 75)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(126, 20)
        Me.txtBiaya.TabIndex = 9
        '
        'txtNoPlat
        '
        Me.txtNoPlat.Location = New System.Drawing.Point(122, 12)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(126, 20)
        Me.txtNoPlat.TabIndex = 10
        '
        'lblTarifLangganan
        '
        Me.lblTarifLangganan.AutoSize = True
        Me.lblTarifLangganan.Location = New System.Drawing.Point(24, 78)
        Me.lblTarifLangganan.Name = "lblTarifLangganan"
        Me.lblTarifLangganan.Size = New System.Drawing.Size(85, 13)
        Me.lblTarifLangganan.TabIndex = 6
        Me.lblTarifLangganan.Text = "Tarif Langganan"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(123, 43)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(126, 20)
        Me.txtUsername.TabIndex = 11
        '
        'lblNomorPlat
        '
        Me.lblNomorPlat.AutoSize = True
        Me.lblNomorPlat.Location = New System.Drawing.Point(25, 20)
        Me.lblNomorPlat.Name = "lblNomorPlat"
        Me.lblNomorPlat.Size = New System.Drawing.Size(59, 13)
        Me.lblNomorPlat.TabIndex = 7
        Me.lblNomorPlat.Text = "Nomor Plat"
        '
        'txtNama
        '
        Me.txtNama.AutoSize = True
        Me.txtNama.Location = New System.Drawing.Point(24, 46)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(89, 13)
        Me.txtNama.TabIndex = 8
        Me.txtNama.Text = "Nama Pelanggan"
        '
        'lblBerlakuHingga
        '
        Me.lblBerlakuHingga.AutoSize = True
        Me.lblBerlakuHingga.Location = New System.Drawing.Point(25, 107)
        Me.lblBerlakuHingga.Name = "lblBerlakuHingga"
        Me.lblBerlakuHingga.Size = New System.Drawing.Size(80, 13)
        Me.lblBerlakuHingga.TabIndex = 6
        Me.lblBerlakuHingga.Text = "Berlaku Hingga"
        '
        'lblIDPelanggan
        '
        Me.lblIDPelanggan.AutoSize = True
        Me.lblIDPelanggan.Location = New System.Drawing.Point(275, 20)
        Me.lblIDPelanggan.Name = "lblIDPelanggan"
        Me.lblIDPelanggan.Size = New System.Drawing.Size(78, 13)
        Me.lblIDPelanggan.TabIndex = 8
        Me.lblIDPelanggan.Text = "ID Pelanggan :"
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taxi/Umum", "Truk", "Sepeda"})
        Me.cmbJenis.Location = New System.Drawing.Point(317, 46)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(121, 21)
        Me.cmbJenis.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Jenis :"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(342, 99)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(59, 26)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(277, 100)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(59, 26)
        Me.btnTambah.TabIndex = 14
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(407, 98)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(59, 26)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kendaraan terdaftar langganan :"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(28, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(438, 139)
        Me.DataGridView1.TabIndex = 15
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(406, 303)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(59, 26)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(123, 105)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(126, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(255, 24)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(10, 13)
        Me.lblId.TabIndex = 17
        Me.lblId.Text = "."
        Me.lblId.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "No Plat"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nama Pemilik"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Biaya"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jenis"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Expired"
        Me.Column6.Name = "Column6"
        '
        'LanggananForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 338)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.txtBiaya)
        Me.Controls.Add(Me.txtNoPlat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBerlakuHingga)
        Me.Controls.Add(Me.lblTarifLangganan)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblNomorPlat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblIDPelanggan)
        Me.Controls.Add(Me.txtNama)
        Me.KeyPreview = True
        Me.Name = "LanggananForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIParkir -Langganan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents lblTarifLangganan As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblNomorPlat As Label
    Friend WithEvents txtNama As Label
    Friend WithEvents lblBerlakuHingga As Label
    Friend WithEvents lblIDPelanggan As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblId As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
