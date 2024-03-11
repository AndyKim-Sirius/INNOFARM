<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Com_Ok = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text_Man_Pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_Man_Code = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Com_Can = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Com_Ok
        '
        Me.Com_Ok.BackColor = System.Drawing.Color.YellowGreen
        Me.Com_Ok.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Com_Ok.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Com_Ok.Location = New System.Drawing.Point(152, 198)
        Me.Com_Ok.Name = "Com_Ok"
        Me.Com_Ok.Size = New System.Drawing.Size(102, 33)
        Me.Com_Ok.TabIndex = 33
        Me.Com_Ok.Text = "LOGIN"
        Me.Com_Ok.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(50, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "PW"
        '
        'Text_Man_Pass
        '
        Me.Text_Man_Pass.Location = New System.Drawing.Point(54, 158)
        Me.Text_Man_Pass.Name = "Text_Man_Pass"
        Me.Text_Man_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text_Man_Pass.Size = New System.Drawing.Size(310, 21)
        Me.Text_Man_Pass.TabIndex = 31
        Me.Text_Man_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(50, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ID"
        '
        'Text_Man_Code
        '
        Me.Text_Man_Code.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Man_Code.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Text_Man_Code.Location = New System.Drawing.Point(54, 73)
        Me.Text_Man_Code.Name = "Text_Man_Code"
        Me.Text_Man_Code.Size = New System.Drawing.Size(310, 26)
        Me.Text_Man_Code.TabIndex = 29
        Me.Text_Man_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.Location = New System.Drawing.Point(314, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 18)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Com_Can
        '
        Me.Com_Can.Location = New System.Drawing.Point(322, 251)
        Me.Com_Can.Name = "Com_Can"
        Me.Com_Can.Size = New System.Drawing.Size(81, 33)
        Me.Com_Can.TabIndex = 34
        Me.Com_Can.Text = "취소"
        Me.Com_Can.UseVisualStyleBackColor = True
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 293)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Com_Can)
        Me.Controls.Add(Me.Com_Ok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Text_Man_Pass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text_Man_Code)
        Me.Name = "Frm_Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Com_Ok As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_Man_Pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Text_Man_Code As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Com_Can As Button
End Class
