<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioBebas = New System.Windows.Forms.RadioButton()
        Me.RadioGaris = New System.Windows.Forms.RadioButton()
        Me.RadioKotak = New System.Windows.Forms.RadioButton()
        Me.RadioElips = New System.Windows.Forms.RadioButton()
        Me.RadioKotakIsi = New System.Windows.Forms.RadioButton()
        Me.RadioRadioElipsIsi = New System.Windows.Forms.RadioButton()
        Me.lblUkuran = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.PanelShapeTepi = New System.Windows.Forms.Panel()
        Me.PanelShapeIsian = New System.Windows.Forms.Panel()
        Me.PanelWarna1 = New System.Windows.Forms.Panel()
        Me.PanelWarna2 = New System.Windows.Forms.Panel()
        Me.PanelWarna3 = New System.Windows.Forms.Panel()
        Me.PanelWarna4 = New System.Windows.Forms.Panel()
        Me.PanelWarna5 = New System.Windows.Forms.Panel()
        Me.PanelWarna6 = New System.Windows.Forms.Panel()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnGambarUlang = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 381)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
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
        Me.GroupBox2.Location = New System.Drawing.Point(113, 339)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 66)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warna"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(564, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(159, 315)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Objek"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(113, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(451, 315)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'RadioBebas
        '
        Me.RadioBebas.AutoSize = True
        Me.RadioBebas.Location = New System.Drawing.Point(12, 19)
        Me.RadioBebas.Name = "RadioBebas"
        Me.RadioBebas.Size = New System.Drawing.Size(55, 17)
        Me.RadioBebas.TabIndex = 0
        Me.RadioBebas.TabStop = True
        Me.RadioBebas.Text = "Bebas"
        Me.RadioBebas.UseVisualStyleBackColor = True
        '
        'RadioGaris
        '
        Me.RadioGaris.AutoSize = True
        Me.RadioGaris.Location = New System.Drawing.Point(12, 42)
        Me.RadioGaris.Name = "RadioGaris"
        Me.RadioGaris.Size = New System.Drawing.Size(49, 17)
        Me.RadioGaris.TabIndex = 1
        Me.RadioGaris.TabStop = True
        Me.RadioGaris.Text = "Garis"
        Me.RadioGaris.UseVisualStyleBackColor = True
        '
        'RadioKotak
        '
        Me.RadioKotak.AutoSize = True
        Me.RadioKotak.Location = New System.Drawing.Point(12, 65)
        Me.RadioKotak.Name = "RadioKotak"
        Me.RadioKotak.Size = New System.Drawing.Size(53, 17)
        Me.RadioKotak.TabIndex = 2
        Me.RadioKotak.TabStop = True
        Me.RadioKotak.Text = "Kotak"
        Me.RadioKotak.UseVisualStyleBackColor = True
        '
        'RadioElips
        '
        Me.RadioElips.AutoSize = True
        Me.RadioElips.Location = New System.Drawing.Point(12, 88)
        Me.RadioElips.Name = "RadioElips"
        Me.RadioElips.Size = New System.Drawing.Size(47, 17)
        Me.RadioElips.TabIndex = 3
        Me.RadioElips.TabStop = True
        Me.RadioElips.Text = "Elips"
        Me.RadioElips.UseVisualStyleBackColor = True
        '
        'RadioKotakIsi
        '
        Me.RadioKotakIsi.AutoSize = True
        Me.RadioKotakIsi.Location = New System.Drawing.Point(12, 111)
        Me.RadioKotakIsi.Name = "RadioKotakIsi"
        Me.RadioKotakIsi.Size = New System.Drawing.Size(66, 17)
        Me.RadioKotakIsi.TabIndex = 4
        Me.RadioKotakIsi.TabStop = True
        Me.RadioKotakIsi.Text = "Kotak Isi"
        Me.RadioKotakIsi.UseVisualStyleBackColor = True
        '
        'RadioRadioElipsIsi
        '
        Me.RadioRadioElipsIsi.AutoSize = True
        Me.RadioRadioElipsIsi.Location = New System.Drawing.Point(12, 134)
        Me.RadioRadioElipsIsi.Name = "RadioRadioElipsIsi"
        Me.RadioRadioElipsIsi.Size = New System.Drawing.Size(60, 17)
        Me.RadioRadioElipsIsi.TabIndex = 5
        Me.RadioRadioElipsIsi.TabStop = True
        Me.RadioRadioElipsIsi.Text = "Elips Isi"
        Me.RadioRadioElipsIsi.UseVisualStyleBackColor = True
        '
        'lblUkuran
        '
        Me.lblUkuran.AutoSize = True
        Me.lblUkuran.Location = New System.Drawing.Point(9, 168)
        Me.lblUkuran.Name = "lblUkuran"
        Me.lblUkuran.Size = New System.Drawing.Size(93, 13)
        Me.lblUkuran.TabIndex = 6
        Me.lblUkuran.Text = "Ukuran Garis Tepi"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(12, 185)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(85, 20)
        Me.NumericUpDown1.TabIndex = 7
        '
        'PanelShapeTepi
        '
        Me.PanelShapeTepi.BackColor = System.Drawing.Color.Black
        Me.PanelShapeTepi.Location = New System.Drawing.Point(17, 326)
        Me.PanelShapeTepi.Name = "PanelShapeTepi"
        Me.PanelShapeTepi.Size = New System.Drawing.Size(32, 31)
        Me.PanelShapeTepi.TabIndex = 8
        '
        'PanelShapeIsian
        '
        Me.PanelShapeIsian.BackColor = System.Drawing.Color.White
        Me.PanelShapeIsian.Location = New System.Drawing.Point(60, 326)
        Me.PanelShapeIsian.Name = "PanelShapeIsian"
        Me.PanelShapeIsian.Size = New System.Drawing.Size(32, 31)
        Me.PanelShapeIsian.TabIndex = 9
        '
        'PanelWarna1
        '
        Me.PanelWarna1.BackColor = System.Drawing.Color.Red
        Me.PanelWarna1.Location = New System.Drawing.Point(12, 20)
        Me.PanelWarna1.Name = "PanelWarna1"
        Me.PanelWarna1.Size = New System.Drawing.Size(25, 25)
        Me.PanelWarna1.TabIndex = 0
        '
        'PanelWarna2
        '
        Me.PanelWarna2.BackColor = System.Drawing.Color.Yellow
        Me.PanelWarna2.Location = New System.Drawing.Point(43, 20)
        Me.PanelWarna2.Name = "PanelWarna2"
        Me.PanelWarna2.Size = New System.Drawing.Size(25, 25)
        Me.PanelWarna2.TabIndex = 1
        '
        'PanelWarna3
        '
        Me.PanelWarna3.BackColor = System.Drawing.Color.Lime
        Me.PanelWarna3.Location = New System.Drawing.Point(74, 20)
        Me.PanelWarna3.Name = "PanelWarna3"
        Me.PanelWarna3.Size = New System.Drawing.Size(25, 25)
        Me.PanelWarna3.TabIndex = 1
        '
        'PanelWarna4
        '
        Me.PanelWarna4.BackColor = System.Drawing.Color.Blue
        Me.PanelWarna4.Location = New System.Drawing.Point(105, 20)
        Me.PanelWarna4.Name = "PanelWarna4"
        Me.PanelWarna4.Size = New System.Drawing.Size(25, 25)
        Me.PanelWarna4.TabIndex = 1
        '
        'PanelWarna5
        '
        Me.PanelWarna5.BackColor = System.Drawing.Color.Black
        Me.PanelWarna5.Location = New System.Drawing.Point(136, 20)
        Me.PanelWarna5.Name = "PanelWarna5"
        Me.PanelWarna5.Size = New System.Drawing.Size(25, 25)
        Me.PanelWarna5.TabIndex = 1
        '
        'PanelWarna6
        '
        Me.PanelWarna6.BackColor = System.Drawing.Color.White
        Me.PanelWarna6.Location = New System.Drawing.Point(167, 20)
        Me.PanelWarna6.Name = "PanelWarna6"
        Me.PanelWarna6.Size = New System.Drawing.Size(25, 25)
        Me.PanelWarna6.TabIndex = 1
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(228, 22)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 5
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(309, 22)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Bersihkan Kanvas"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnGambarUlang
        '
        Me.btnGambarUlang.Location = New System.Drawing.Point(451, 22)
        Me.btnGambarUlang.Name = "btnGambarUlang"
        Me.btnGambarUlang.Size = New System.Drawing.Size(111, 23)
        Me.btnGambarUlang.TabIndex = 7
        Me.btnGambarUlang.Text = "Gambar Ulang"
        Me.btnGambarUlang.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(153, 296)
        Me.TextBox1.TabIndex = 0
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 405)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corat-Coret Vektor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
