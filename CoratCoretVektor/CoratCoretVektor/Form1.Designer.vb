<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelShapeIsian = New System.Windows.Forms.Panel()
        Me.PanelShapeTepi = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblUkuran = New System.Windows.Forms.Label()
        Me.RadioRadioElipsIsi = New System.Windows.Forms.RadioButton()
        Me.RadioKotakIsi = New System.Windows.Forms.RadioButton()
        Me.RadioElips = New System.Windows.Forms.RadioButton()
        Me.RadioKotak = New System.Windows.Forms.RadioButton()
        Me.RadioGaris = New System.Windows.Forms.RadioButton()
        Me.RadioBebas = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGambarUlang = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.PanelWarna6 = New System.Windows.Forms.Panel()
        Me.PanelWarna5 = New System.Windows.Forms.Panel()
        Me.PanelWarna4 = New System.Windows.Forms.Panel()
        Me.PanelWarna3 = New System.Windows.Forms.Panel()
        Me.PanelWarna2 = New System.Windows.Forms.Panel()
        Me.PanelWarna1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanelShapeIsian)
        Me.GroupBox1.Controls.Add(Me.PanelShapeTepi)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.lblUkuran)
        Me.GroupBox1.Controls.Add(Me.RadioRadioElipsIsi)
        Me.GroupBox1.Controls.Add(Me.RadioKotakIsi)
        Me.GroupBox1.Controls.Add(Me.RadioElips)
        Me.GroupBox1.Controls.Add(Me.RadioKotak)
        Me.GroupBox1.Controls.Add(Me.RadioGaris)
        Me.GroupBox1.Controls.Add(Me.RadioBebas)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(151, 470)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'PanelShapeIsian
        '
        Me.PanelShapeIsian.BackColor = System.Drawing.Color.White
        Me.PanelShapeIsian.Location = New System.Drawing.Point(80, 401)
        Me.PanelShapeIsian.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelShapeIsian.Name = "PanelShapeIsian"
        Me.PanelShapeIsian.Size = New System.Drawing.Size(43, 38)
        Me.PanelShapeIsian.TabIndex = 9
        '
        'PanelShapeTepi
        '
        Me.PanelShapeTepi.BackColor = System.Drawing.Color.Black
        Me.PanelShapeTepi.Location = New System.Drawing.Point(23, 401)
        Me.PanelShapeTepi.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelShapeTepi.Name = "PanelShapeTepi"
        Me.PanelShapeTepi.Size = New System.Drawing.Size(43, 38)
        Me.PanelShapeTepi.TabIndex = 8
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(16, 228)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(113, 22)
        Me.NumericUpDown1.TabIndex = 7
        '
        'lblUkuran
        '
        Me.lblUkuran.AutoSize = True
        Me.lblUkuran.Location = New System.Drawing.Point(12, 207)
        Me.lblUkuran.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUkuran.Name = "lblUkuran"
        Me.lblUkuran.Size = New System.Drawing.Size(116, 16)
        Me.lblUkuran.TabIndex = 6
        Me.lblUkuran.Text = "Ukuran Garis Tepi"
        '
        'RadioRadioElipsIsi
        '
        Me.RadioRadioElipsIsi.AutoSize = True
        Me.RadioRadioElipsIsi.Location = New System.Drawing.Point(16, 165)
        Me.RadioRadioElipsIsi.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioRadioElipsIsi.Name = "RadioRadioElipsIsi"
        Me.RadioRadioElipsIsi.Size = New System.Drawing.Size(74, 20)
        Me.RadioRadioElipsIsi.TabIndex = 5
        Me.RadioRadioElipsIsi.TabStop = True
        Me.RadioRadioElipsIsi.Text = "Elips Isi"
        Me.RadioRadioElipsIsi.UseVisualStyleBackColor = True
        '
        'RadioKotakIsi
        '
        Me.RadioKotakIsi.AutoSize = True
        Me.RadioKotakIsi.Location = New System.Drawing.Point(16, 137)
        Me.RadioKotakIsi.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioKotakIsi.Name = "RadioKotakIsi"
        Me.RadioKotakIsi.Size = New System.Drawing.Size(78, 20)
        Me.RadioKotakIsi.TabIndex = 4
        Me.RadioKotakIsi.TabStop = True
        Me.RadioKotakIsi.Text = "Kotak Isi"
        Me.RadioKotakIsi.UseVisualStyleBackColor = True
        '
        'RadioElips
        '
        Me.RadioElips.AutoSize = True
        Me.RadioElips.Location = New System.Drawing.Point(16, 108)
        Me.RadioElips.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioElips.Name = "RadioElips"
        Me.RadioElips.Size = New System.Drawing.Size(58, 20)
        Me.RadioElips.TabIndex = 3
        Me.RadioElips.TabStop = True
        Me.RadioElips.Text = "Elips"
        Me.RadioElips.UseVisualStyleBackColor = True
        '
        'RadioKotak
        '
        Me.RadioKotak.AutoSize = True
        Me.RadioKotak.Location = New System.Drawing.Point(16, 80)
        Me.RadioKotak.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioKotak.Name = "RadioKotak"
        Me.RadioKotak.Size = New System.Drawing.Size(62, 20)
        Me.RadioKotak.TabIndex = 2
        Me.RadioKotak.TabStop = True
        Me.RadioKotak.Text = "Kotak"
        Me.RadioKotak.UseVisualStyleBackColor = True
        '
        'RadioGaris
        '
        Me.RadioGaris.AutoSize = True
        Me.RadioGaris.Location = New System.Drawing.Point(16, 52)
        Me.RadioGaris.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioGaris.Name = "RadioGaris"
        Me.RadioGaris.Size = New System.Drawing.Size(60, 20)
        Me.RadioGaris.TabIndex = 1
        Me.RadioGaris.TabStop = True
        Me.RadioGaris.Text = "Garis"
        Me.RadioGaris.UseVisualStyleBackColor = True
        '
        'RadioBebas
        '
        Me.RadioBebas.AutoSize = True
        Me.RadioBebas.Location = New System.Drawing.Point(16, 23)
        Me.RadioBebas.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioBebas.Name = "RadioBebas"
        Me.RadioBebas.Size = New System.Drawing.Size(68, 20)
        Me.RadioBebas.TabIndex = 0
        Me.RadioBebas.TabStop = True
        Me.RadioBebas.Text = "Bebas"
        Me.RadioBebas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGambarUlang)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnUndo)
        Me.GroupBox2.Controls.Add(Me.PanelWarna6)
        Me.GroupBox2.Controls.Add(Me.PanelWarna5)
        Me.GroupBox2.Controls.Add(Me.PanelWarna4)
        Me.GroupBox2.Controls.Add(Me.PanelWarna3)
        Me.GroupBox2.Controls.Add(Me.PanelWarna2)
        Me.GroupBox2.Controls.Add(Me.PanelWarna1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(151, 417)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(813, 81)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warna"
        '
        'btnGambarUlang
        '
        Me.btnGambarUlang.Location = New System.Drawing.Point(601, 27)
        Me.btnGambarUlang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGambarUlang.Name = "btnGambarUlang"
        Me.btnGambarUlang.Size = New System.Drawing.Size(148, 28)
        Me.btnGambarUlang.TabIndex = 7
        Me.btnGambarUlang.Text = "Gambar Ulang"
        Me.btnGambarUlang.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(412, 27)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Bersihkan Kanvas"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(304, 27)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(100, 28)
        Me.btnUndo.TabIndex = 5
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'PanelWarna6
        '
        Me.PanelWarna6.BackColor = System.Drawing.Color.White
        Me.PanelWarna6.Location = New System.Drawing.Point(223, 25)
        Me.PanelWarna6.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelWarna6.Name = "PanelWarna6"
        Me.PanelWarna6.Size = New System.Drawing.Size(33, 31)
        Me.PanelWarna6.TabIndex = 1
        '
        'PanelWarna5
        '
        Me.PanelWarna5.BackColor = System.Drawing.Color.Black
        Me.PanelWarna5.Location = New System.Drawing.Point(181, 25)
        Me.PanelWarna5.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelWarna5.Name = "PanelWarna5"
        Me.PanelWarna5.Size = New System.Drawing.Size(33, 31)
        Me.PanelWarna5.TabIndex = 1
        '
        'PanelWarna4
        '
        Me.PanelWarna4.BackColor = System.Drawing.Color.Blue
        Me.PanelWarna4.Location = New System.Drawing.Point(140, 25)
        Me.PanelWarna4.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelWarna4.Name = "PanelWarna4"
        Me.PanelWarna4.Size = New System.Drawing.Size(33, 31)
        Me.PanelWarna4.TabIndex = 1
        '
        'PanelWarna3
        '
        Me.PanelWarna3.BackColor = System.Drawing.Color.Lime
        Me.PanelWarna3.Location = New System.Drawing.Point(99, 25)
        Me.PanelWarna3.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelWarna3.Name = "PanelWarna3"
        Me.PanelWarna3.Size = New System.Drawing.Size(33, 31)
        Me.PanelWarna3.TabIndex = 1
        '
        'PanelWarna2
        '
        Me.PanelWarna2.BackColor = System.Drawing.Color.Yellow
        Me.PanelWarna2.Location = New System.Drawing.Point(57, 25)
        Me.PanelWarna2.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelWarna2.Name = "PanelWarna2"
        Me.PanelWarna2.Size = New System.Drawing.Size(33, 31)
        Me.PanelWarna2.TabIndex = 1
        '
        'PanelWarna1
        '
        Me.PanelWarna1.BackColor = System.Drawing.Color.Red
        Me.PanelWarna1.Location = New System.Drawing.Point(16, 25)
        Me.PanelWarna1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelWarna1.Name = "PanelWarna1"
        Me.PanelWarna1.Size = New System.Drawing.Size(33, 31)
        Me.PanelWarna1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(752, 28)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(212, 389)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Objek"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(4, 19)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(204, 366)
        Me.TextBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaruToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.BukaToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BaruToolStripMenuItem
        '
        Me.BaruToolStripMenuItem.Name = "BaruToolStripMenuItem"
        Me.BaruToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.BaruToolStripMenuItem.Text = "Baru"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(151, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(601, 389)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.InitialDirectory = "C:\"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 498)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corat-Coret Vektor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PanelShapeTepi As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblUkuran As Label
    Friend WithEvents RadioRadioElipsIsi As RadioButton
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelShapeIsian As Panel
    Friend WithEvents PanelWarna6 As Panel
    Friend WithEvents PanelWarna5 As Panel
    Friend WithEvents PanelWarna4 As Panel
    Friend WithEvents PanelWarna3 As Panel
    Friend WithEvents PanelWarna2 As Panel
    Friend WithEvents PanelWarna1 As Panel
    Friend WithEvents btnGambarUlang As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
