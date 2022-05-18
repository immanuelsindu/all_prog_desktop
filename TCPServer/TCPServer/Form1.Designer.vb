<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.txtSaveTo = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnListen = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lbHasil = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.*"
        Me.SaveFileDialog1.Filter = "All Files | *.*"
        Me.SaveFileDialog1.Title = "Save File As"
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Location = New System.Drawing.Point(24, 25)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(64, 13)
        Me.lblIPAddress.TabIndex = 0
        Me.lblIPAddress.Text = "IP Address :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Save to :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port :"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(94, 22)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.ReadOnly = True
        Me.txtIPAddress.Size = New System.Drawing.Size(169, 20)
        Me.txtIPAddress.TabIndex = 3
        '
        'txtSaveTo
        '
        Me.txtSaveTo.Location = New System.Drawing.Point(94, 52)
        Me.txtSaveTo.Name = "txtSaveTo"
        Me.txtSaveTo.Size = New System.Drawing.Size(330, 20)
        Me.txtSaveTo.TabIndex = 4
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(337, 22)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(87, 20)
        Me.txtPort.TabIndex = 5
        Me.txtPort.Text = "8080"
        '
        'btnListen
        '
        Me.btnListen.Location = New System.Drawing.Point(448, 20)
        Me.btnListen.Name = "btnListen"
        Me.btnListen.Size = New System.Drawing.Size(75, 23)
        Me.btnListen.TabIndex = 6
        Me.btnListen.Text = "Listen"
        Me.btnListen.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(448, 52)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lbHasil
        '
        Me.lbHasil.FormattingEnabled = True
        Me.lbHasil.Location = New System.Drawing.Point(27, 87)
        Me.lbHasil.Name = "lbHasil"
        Me.lbHasil.Size = New System.Drawing.Size(496, 225)
        Me.lbHasil.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(448, 318)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear Log"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 349)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lbHasil)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnListen)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtSaveTo)
        Me.Controls.Add(Me.txtIPAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIPAddress)
        Me.Name = "Form1"
        Me.Text = "TCPServer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblIPAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents txtSaveTo As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnListen As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lbHasil As ListBox
    Friend WithEvents btnClear As Button
End Class
