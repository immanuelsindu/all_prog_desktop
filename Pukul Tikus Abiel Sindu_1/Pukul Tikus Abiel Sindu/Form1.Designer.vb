<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTikus = New System.Windows.Forms.Button()
        Me.lblSkor = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.timerTikus = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnTikus)
        Me.Panel1.Location = New System.Drawing.Point(23, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 250)
        Me.Panel1.TabIndex = 0
        '
        'btnTikus
        '
        Me.btnTikus.Location = New System.Drawing.Point(0, 3)
        Me.btnTikus.Name = "btnTikus"
        Me.btnTikus.Size = New System.Drawing.Size(75, 23)
        Me.btnTikus.TabIndex = 4
        Me.btnTikus.Text = "Tikus"
        Me.btnTikus.UseVisualStyleBackColor = True
        Me.btnTikus.Visible = False
        '
        'lblSkor
        '
        Me.lblSkor.AutoSize = True
        Me.lblSkor.Location = New System.Drawing.Point(28, 292)
        Me.lblSkor.Name = "lblSkor"
        Me.lblSkor.Size = New System.Drawing.Size(50, 15)
        Me.lblSkor.TabIndex = 1
        Me.lblSkor.Text = "SKOR : 0"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(339, 288)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(84, 15)
        Me.lblPosition.TabIndex = 2
        Me.lblPosition.Text = "Random : (x,y)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'timerTikus
        '
        Me.timerTikus.Interval = 800
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 322)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblSkor)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Pukul Tikus"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSkor As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents timerTikus As Timer
    Friend WithEvents btnTikus As Button
End Class
