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
        Me.lblRemoteHost = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.txtRemoteHost = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRemoteHost
        '
        Me.lblRemoteHost.AutoSize = True
        Me.lblRemoteHost.Location = New System.Drawing.Point(12, 20)
        Me.lblRemoteHost.Name = "lblRemoteHost"
        Me.lblRemoteHost.Size = New System.Drawing.Size(75, 13)
        Me.lblRemoteHost.TabIndex = 0
        Me.lblRemoteHost.Text = "Remote Host :"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(12, 75)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(56, 13)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Message :"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(12, 49)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(32, 13)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "Port :"
        '
        'txtRemoteHost
        '
        Me.txtRemoteHost.Location = New System.Drawing.Point(103, 20)
        Me.txtRemoteHost.Name = "txtRemoteHost"
        Me.txtRemoteHost.Size = New System.Drawing.Size(141, 20)
        Me.txtRemoteHost.TabIndex = 3
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(103, 46)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(141, 20)
        Me.txtPort.TabIndex = 4
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(103, 72)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(141, 106)
        Me.txtMessage.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(103, 185)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 224)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtRemoteHost)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblRemoteHost)
        Me.Name = "Form1"
        Me.Text = "UDPClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRemoteHost As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents txtRemoteHost As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSend As Button
End Class
