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
        Me.lblPathTo = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lblPathTo
        '
        Me.lblPathTo.AutoSize = True
        Me.lblPathTo.Location = New System.Drawing.Point(12, 23)
        Me.lblPathTo.Name = "lblPathTo"
        Me.lblPathTo.Size = New System.Drawing.Size(54, 13)
        Me.lblPathTo.TabIndex = 0
        Me.lblPathTo.Text = "Path File :"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(12, 55)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(44, 13)
        Me.lblServer.TabIndex = 1
        Me.lblServer.Text = "Server :"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(12, 88)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(32, 13)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "Port :"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(81, 20)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(202, 20)
        Me.txtPath.TabIndex = 3
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(81, 52)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(202, 20)
        Me.txtServer.TabIndex = 4
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(81, 85)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(202, 20)
        Me.txtPort.TabIndex = 5
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(316, 18)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(316, 88)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "All Files | *.*"
        Me.OpenFileDialog1.ReadOnlyChecked = True
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 133)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.lblPathTo)
        Me.Name = "Form1"
        Me.Text = "TCPClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPathTo As Label
    Friend WithEvents lblServer As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
