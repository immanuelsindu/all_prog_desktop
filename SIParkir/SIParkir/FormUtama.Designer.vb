<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AturProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanggananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.lblInfoUser = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJmlKendaraan = New System.Windows.Forms.Label()
        Me.lblKendaraanSedangParkir = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colkeluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblInfoJenis = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlPlat = New System.Windows.Forms.Panel()
        Me.lblPlat = New System.Windows.Forms.Label()
        Me.pnlHarga = New System.Windows.Forms.Panel()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblInfoJenis2 = New System.Windows.Forms.Label()
        Me.lblTekan = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.lblInputPlat = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlPlat.SuspendLayout()
        Me.pnlHarga.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemToolStripMenuItem, Me.AdminToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(622, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemToolStripMenuItem
        '
        Me.SistemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AturProfilToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        Me.SistemToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SistemToolStripMenuItem.Text = "Sistem"
        '
        'AturProfilToolStripMenuItem
        '
        Me.AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        Me.AturProfilToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.AturProfilToolStripMenuItem.Text = "Atur Profil"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LanggananToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'LanggananToolStripMenuItem
        '
        Me.LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        Me.LanggananToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.LanggananToolStripMenuItem.Text = "Kendaraan Langganan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan Pendapatan"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem1, Me.TentangToolStripMenuItem})
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'BantuanToolStripMenuItem1
        '
        Me.BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        Me.BantuanToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.BantuanToolStripMenuItem1.Text = "Bantuan"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'txtPlat
        '
        Me.txtPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlat.Location = New System.Drawing.Point(64, 12)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.Size = New System.Drawing.Size(132, 26)
        Me.txtPlat.TabIndex = 3
        '
        'lblInfoUser
        '
        Me.lblInfoUser.AutoSize = True
        Me.lblInfoUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoUser.Location = New System.Drawing.Point(17, 328)
        Me.lblInfoUser.Name = "lblInfoUser"
        Me.lblInfoUser.Size = New System.Drawing.Size(66, 13)
        Me.lblInfoUser.TabIndex = 2
        Me.lblInfoUser.Text = "Informasi -"
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(15, 350)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(109, 13)
        Me.lblTgl.TabIndex = 2
        Me.lblTgl.Text = "Tanggal : 18-03-2022"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Jam: 00:00:00"
        '
        'lblJmlKendaraan
        '
        Me.lblJmlKendaraan.AutoSize = True
        Me.lblJmlKendaraan.Location = New System.Drawing.Point(17, 373)
        Me.lblJmlKendaraan.Name = "lblJmlKendaraan"
        Me.lblJmlKendaraan.Size = New System.Drawing.Size(210, 13)
        Me.lblJmlKendaraan.TabIndex = 2
        Me.lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Spd, 0 Bis/truk"
        '
        'lblKendaraanSedangParkir
        '
        Me.lblKendaraanSedangParkir.AutoSize = True
        Me.lblKendaraanSedangParkir.Location = New System.Drawing.Point(336, 126)
        Me.lblKendaraanSedangParkir.Name = "lblKendaraanSedangParkir"
        Me.lblKendaraanSedangParkir.Size = New System.Drawing.Size(132, 13)
        Me.lblKendaraanSedangParkir.TabIndex = 2
        Me.lblKendaraanSedangParkir.Text = "Kendaraan sedang parkir :"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColPlat, Me.ColMasuk, Me.Colkeluar, Me.ColHarga, Me.ColJenis, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(231, 199)
        Me.DataGridView1.TabIndex = 4
        '
        'ColPlat
        '
        Me.ColPlat.HeaderText = "No. Plat"
        Me.ColPlat.Name = "ColPlat"
        '
        'ColMasuk
        '
        Me.ColMasuk.HeaderText = "Masuk"
        Me.ColMasuk.Name = "ColMasuk"
        '
        'Colkeluar
        '
        Me.Colkeluar.HeaderText = "Keluar"
        Me.Colkeluar.Name = "Colkeluar"
        '
        'ColHarga
        '
        Me.ColHarga.HeaderText = "Harga"
        Me.ColHarga.Name = "ColHarga"
        '
        'ColJenis
        '
        Me.ColJenis.HeaderText = "Jenis"
        Me.ColJenis.Name = "ColJenis"
        '
        'Column6
        '
        Me.Column6.HeaderText = "id"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'lblInfoJenis
        '
        Me.lblInfoJenis.AutoSize = True
        Me.lblInfoJenis.Location = New System.Drawing.Point(147, 7)
        Me.lblInfoJenis.Name = "lblInfoJenis"
        Me.lblInfoJenis.Size = New System.Drawing.Size(0, 13)
        Me.lblInfoJenis.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'pnlPlat
        '
        Me.pnlPlat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPlat.Controls.Add(Me.lblPlat)
        Me.pnlPlat.Location = New System.Drawing.Point(12, 23)
        Me.pnlPlat.Name = "pnlPlat"
        Me.pnlPlat.Size = New System.Drawing.Size(535, 100)
        Me.pnlPlat.TabIndex = 7
        '
        'lblPlat
        '
        Me.lblPlat.AutoSize = True
        Me.lblPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlat.Location = New System.Drawing.Point(117, 14)
        Me.lblPlat.Name = "lblPlat"
        Me.lblPlat.Size = New System.Drawing.Size(295, 63)
        Me.lblPlat.TabIndex = 1
        Me.lblPlat.Text = "R 6872 ZH"
        '
        'pnlHarga
        '
        Me.pnlHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHarga.Controls.Add(Me.lblHarga)
        Me.pnlHarga.Location = New System.Drawing.Point(12, 126)
        Me.pnlHarga.Name = "pnlHarga"
        Me.pnlHarga.Size = New System.Drawing.Size(318, 67)
        Me.pnlHarga.TabIndex = 8
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(3, 13)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(74, 36)
        Me.lblHarga.TabIndex = 0
        Me.lblHarga.Text = "Rp. "
        '
        'pnlInput
        '
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInput.Controls.Add(Me.lblInfoJenis2)
        Me.pnlInput.Controls.Add(Me.lblTekan)
        Me.pnlInput.Controls.Add(Me.lblJenis)
        Me.pnlInput.Controls.Add(Me.lblInputPlat)
        Me.pnlInput.Controls.Add(Me.lblInfoJenis)
        Me.pnlInput.Controls.Add(Me.txtPlat)
        Me.pnlInput.Location = New System.Drawing.Point(12, 203)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(318, 116)
        Me.pnlInput.TabIndex = 9
        '
        'lblInfoJenis2
        '
        Me.lblInfoJenis2.AutoSize = True
        Me.lblInfoJenis2.Location = New System.Drawing.Point(202, 20)
        Me.lblInfoJenis2.Name = "lblInfoJenis2"
        Me.lblInfoJenis2.Size = New System.Drawing.Size(10, 13)
        Me.lblInfoJenis2.TabIndex = 11
        Me.lblInfoJenis2.Text = "."
        '
        'lblTekan
        '
        Me.lblTekan.AutoSize = True
        Me.lblTekan.Location = New System.Drawing.Point(9, 60)
        Me.lblTekan.Name = "lblTekan"
        Me.lblTekan.Size = New System.Drawing.Size(172, 13)
        Me.lblTekan.TabIndex = 13
        Me.lblTekan.Text = "Tekan Enter untuk Masuk / Keluar"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(9, 44)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(292, 13)
        Me.lblJenis.TabIndex = 12
        Me.lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 - Taksi, F4 - Sepeda, F5 - Bis/Truk"
        '
        'lblInputPlat
        '
        Me.lblInputPlat.AutoSize = True
        Me.lblInputPlat.Location = New System.Drawing.Point(9, 17)
        Me.lblInputPlat.Name = "lblInputPlat"
        Me.lblInputPlat.Size = New System.Drawing.Size(51, 13)
        Me.lblInputPlat.TabIndex = 11
        Me.lblInputPlat.Text = "input Plat"
        '
        'pnlGrid
        '
        Me.pnlGrid.AutoScroll = True
        Me.pnlGrid.Controls.Add(Me.DataGridView1)
        Me.pnlGrid.Location = New System.Drawing.Point(339, 142)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(249, 210)
        Me.pnlGrid.TabIndex = 10
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 452)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblKendaraanSedangParkir)
        Me.Controls.Add(Me.lblJmlKendaraan)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.lblInfoUser)
        Me.Controls.Add(Me.pnlPlat)
        Me.Controls.Add(Me.pnlHarga)
        Me.Controls.Add(Me.pnlInput)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parkir System v.1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlPlat.ResumeLayout(False)
        Me.pnlPlat.PerformLayout()
        Me.pnlHarga.ResumeLayout(False)
        Me.pnlHarga.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents lblKendaraanSedangParkir As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlPlat As Panel
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents pnlInput As Panel
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblTekan As Label
    Friend WithEvents lblInfoJenis2 As Label
    Friend WithEvents ColPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents Colkeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
