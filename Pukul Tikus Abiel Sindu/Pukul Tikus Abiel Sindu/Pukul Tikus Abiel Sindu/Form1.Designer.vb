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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGridX = New System.Windows.Forms.TextBox()
        Me.txtGridY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnTikus)
        Me.Panel1.Location = New System.Drawing.Point(26, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 306)
        Me.Panel1.TabIndex = 0
        '
        'btnTikus
        '
        Me.btnTikus.Location = New System.Drawing.Point(0, 4)
        Me.btnTikus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTikus.Name = "btnTikus"
        Me.btnTikus.Size = New System.Drawing.Size(86, 31)
        Me.btnTikus.TabIndex = 4
        Me.btnTikus.Text = "Tikus"
        Me.btnTikus.UseVisualStyleBackColor = True
        Me.btnTikus.Visible = False
        '
        'lblSkor
        '
        Me.lblSkor.AutoSize = True
        Me.lblSkor.Location = New System.Drawing.Point(32, 389)
        Me.lblSkor.Name = "lblSkor"
        Me.lblSkor.Size = New System.Drawing.Size(64, 20)
        Me.lblSkor.TabIndex = 1
        Me.lblSkor.Text = "SKOR : 0"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(387, 384)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(103, 20)
        Me.lblPosition.TabIndex = 2
        Me.lblPosition.Text = "Random : (x,y)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 384)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'timerTikus
        '
        Me.timerTikus.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kolom : "
        '
        'txtGridX
        '
        Me.txtGridX.Location = New System.Drawing.Point(96, 18)
        Me.txtGridX.Name = "txtGridX"
        Me.txtGridX.Size = New System.Drawing.Size(125, 27)
        Me.txtGridX.TabIndex = 5
        '
        'txtGridY
        '
        Me.txtGridY.Location = New System.Drawing.Point(285, 18)
        Me.txtGridY.Name = "txtGridY"
        Me.txtGridY.Size = New System.Drawing.Size(125, 27)
        Me.txtGridY.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Baris : "
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(416, 17)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(79, 29)
        Me.btnGenerate.TabIndex = 8
        Me.btnGenerate.Text = "Generate!"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 429)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGridY)
        Me.Controls.Add(Me.txtGridX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblSkor)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGridX As TextBox
    Friend WithEvents txtGridY As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerate As Button
End Class
