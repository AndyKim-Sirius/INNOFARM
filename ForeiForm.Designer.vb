<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForeiForm
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Info_La3 = New System.Windows.Forms.Button()
        Me.Info_Tx1 = New System.Windows.Forms.TextBox()
        Me.Info_La1 = New System.Windows.Forms.Button()
        Me.Info_Tx0 = New System.Windows.Forms.TextBox()
        Me.Info_La0 = New System.Windows.Forms.Button()
        Me.Info_Tx2 = New System.Windows.Forms.TextBox()
        Me.Info_La2 = New System.Windows.Forms.Button()
        Me.Info_La4 = New System.Windows.Forms.Button()
        Me.Info_Tx3 = New System.Windows.Forms.TextBox()
        Me.Info_La5 = New System.Windows.Forms.Button()
        Me.Info_La6 = New System.Windows.Forms.Button()
        Me.Info_La7 = New System.Windows.Forms.Button()
        Me.Info_La8 = New System.Windows.Forms.Button()
        Me.Info_La9 = New System.Windows.Forms.Button()
        Me.Info_La10 = New System.Windows.Forms.Button()
        Me.Info_Tx4 = New System.Windows.Forms.TextBox()
        Me.Info_Tx5 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Info_Tx6 = New System.Windows.Forms.TextBox()
        Me.Info_Tx7 = New System.Windows.Forms.TextBox()
        Me.IN_Date = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownHeight = 50
        Me.ComboBox1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Location = New System.Drawing.Point(203, 115)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 28)
        Me.ComboBox1.TabIndex = 253
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Save.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.Color.Black
        Me.Btn_Save.Location = New System.Drawing.Point(27, 519)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(707, 49)
        Me.Btn_Save.TabIndex = 252
        Me.Btn_Save.Text = "저  장"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'Info_La3
        '
        Me.Info_La3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La3.Enabled = False
        Me.Info_La3.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La3.ForeColor = System.Drawing.Color.Black
        Me.Info_La3.Location = New System.Drawing.Point(27, 113)
        Me.Info_La3.Name = "Info_La3"
        Me.Info_La3.Size = New System.Drawing.Size(153, 29)
        Me.Info_La3.TabIndex = 245
        Me.Info_La3.Text = "성  별"
        Me.Info_La3.UseVisualStyleBackColor = False
        '
        'Info_Tx1
        '
        Me.Info_Tx1.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_Tx1.Location = New System.Drawing.Point(203, 66)
        Me.Info_Tx1.Name = "Info_Tx1"
        Me.Info_Tx1.Size = New System.Drawing.Size(137, 25)
        Me.Info_Tx1.TabIndex = 244
        Me.Info_Tx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Info_La1
        '
        Me.Info_La1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La1.Enabled = False
        Me.Info_La1.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La1.ForeColor = System.Drawing.Color.Black
        Me.Info_La1.Location = New System.Drawing.Point(27, 63)
        Me.Info_La1.Name = "Info_La1"
        Me.Info_La1.Size = New System.Drawing.Size(153, 29)
        Me.Info_La1.TabIndex = 243
        Me.Info_La1.Text = "한글 이름"
        Me.Info_La1.UseVisualStyleBackColor = False
        '
        'Info_Tx0
        '
        Me.Info_Tx0.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Info_Tx0.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_Tx0.Location = New System.Drawing.Point(203, 24)
        Me.Info_Tx0.Name = "Info_Tx0"
        Me.Info_Tx0.Size = New System.Drawing.Size(137, 25)
        Me.Info_Tx0.TabIndex = 242
        Me.Info_Tx0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Info_La0
        '
        Me.Info_La0.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La0.Enabled = False
        Me.Info_La0.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Info_La0.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La0.ForeColor = System.Drawing.Color.Black
        Me.Info_La0.Location = New System.Drawing.Point(27, 20)
        Me.Info_La0.Name = "Info_La0"
        Me.Info_La0.Size = New System.Drawing.Size(153, 29)
        Me.Info_La0.TabIndex = 241
        Me.Info_La0.Text = "코  드"
        Me.Info_La0.UseVisualStyleBackColor = False
        '
        'Info_Tx2
        '
        Me.Info_Tx2.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_Tx2.Location = New System.Drawing.Point(544, 65)
        Me.Info_Tx2.Name = "Info_Tx2"
        Me.Info_Tx2.Size = New System.Drawing.Size(200, 25)
        Me.Info_Tx2.TabIndex = 255
        Me.Info_Tx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Info_La2
        '
        Me.Info_La2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La2.Enabled = False
        Me.Info_La2.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La2.ForeColor = System.Drawing.Color.Black
        Me.Info_La2.Location = New System.Drawing.Point(374, 62)
        Me.Info_La2.Name = "Info_La2"
        Me.Info_La2.Size = New System.Drawing.Size(153, 29)
        Me.Info_La2.TabIndex = 254
        Me.Info_La2.Text = "영어 이름"
        Me.Info_La2.UseVisualStyleBackColor = False
        '
        'Info_La4
        '
        Me.Info_La4.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La4.Enabled = False
        Me.Info_La4.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La4.ForeColor = System.Drawing.Color.Black
        Me.Info_La4.Location = New System.Drawing.Point(27, 168)
        Me.Info_La4.Name = "Info_La4"
        Me.Info_La4.Size = New System.Drawing.Size(153, 29)
        Me.Info_La4.TabIndex = 256
        Me.Info_La4.Text = "여권 이름"
        Me.Info_La4.UseVisualStyleBackColor = False
        '
        'Info_Tx3
        '
        Me.Info_Tx3.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_Tx3.Location = New System.Drawing.Point(203, 168)
        Me.Info_Tx3.Name = "Info_Tx3"
        Me.Info_Tx3.Size = New System.Drawing.Size(430, 25)
        Me.Info_Tx3.TabIndex = 257
        Me.Info_Tx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Info_La5
        '
        Me.Info_La5.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La5.Enabled = False
        Me.Info_La5.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La5.ForeColor = System.Drawing.Color.Black
        Me.Info_La5.Location = New System.Drawing.Point(27, 222)
        Me.Info_La5.Name = "Info_La5"
        Me.Info_La5.Size = New System.Drawing.Size(153, 29)
        Me.Info_La5.TabIndex = 258
        Me.Info_La5.Text = "입사 일자"
        Me.Info_La5.UseVisualStyleBackColor = False
        '
        'Info_La6
        '
        Me.Info_La6.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La6.Enabled = False
        Me.Info_La6.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La6.ForeColor = System.Drawing.Color.Black
        Me.Info_La6.Location = New System.Drawing.Point(27, 282)
        Me.Info_La6.Name = "Info_La6"
        Me.Info_La6.Size = New System.Drawing.Size(153, 29)
        Me.Info_La6.TabIndex = 260
        Me.Info_La6.Text = "기숙사 방 번호"
        Me.Info_La6.UseVisualStyleBackColor = False
        '
        'Info_La7
        '
        Me.Info_La7.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La7.Enabled = False
        Me.Info_La7.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La7.ForeColor = System.Drawing.Color.Black
        Me.Info_La7.Location = New System.Drawing.Point(374, 282)
        Me.Info_La7.Name = "Info_La7"
        Me.Info_La7.Size = New System.Drawing.Size(153, 29)
        Me.Info_La7.TabIndex = 261
        Me.Info_La7.Text = "기숙사 비밀번호"
        Me.Info_La7.UseVisualStyleBackColor = False
        '
        'Info_La8
        '
        Me.Info_La8.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La8.Enabled = False
        Me.Info_La8.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La8.ForeColor = System.Drawing.Color.Black
        Me.Info_La8.Location = New System.Drawing.Point(27, 340)
        Me.Info_La8.Name = "Info_La8"
        Me.Info_La8.Size = New System.Drawing.Size(153, 29)
        Me.Info_La8.TabIndex = 262
        Me.Info_La8.Text = "국  적"
        Me.Info_La8.UseVisualStyleBackColor = False
        '
        'Info_La9
        '
        Me.Info_La9.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La9.Enabled = False
        Me.Info_La9.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La9.ForeColor = System.Drawing.Color.Black
        Me.Info_La9.Location = New System.Drawing.Point(27, 396)
        Me.Info_La9.Name = "Info_La9"
        Me.Info_La9.Size = New System.Drawing.Size(153, 29)
        Me.Info_La9.TabIndex = 263
        Me.Info_La9.Text = "동 거 인"
        Me.Info_La9.UseVisualStyleBackColor = False
        '
        'Info_La10
        '
        Me.Info_La10.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Info_La10.Enabled = False
        Me.Info_La10.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_La10.ForeColor = System.Drawing.Color.Black
        Me.Info_La10.Location = New System.Drawing.Point(27, 454)
        Me.Info_La10.Name = "Info_La10"
        Me.Info_La10.Size = New System.Drawing.Size(153, 29)
        Me.Info_La10.TabIndex = 264
        Me.Info_La10.Text = "비   고"
        Me.Info_La10.UseVisualStyleBackColor = False
        '
        'Info_Tx4
        '
        Me.Info_Tx4.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_Tx4.Location = New System.Drawing.Point(203, 282)
        Me.Info_Tx4.Name = "Info_Tx4"
        Me.Info_Tx4.Size = New System.Drawing.Size(137, 25)
        Me.Info_Tx4.TabIndex = 265
        Me.Info_Tx4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Info_Tx5
        '
        Me.Info_Tx5.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_Tx5.Location = New System.Drawing.Point(544, 282)
        Me.Info_Tx5.Name = "Info_Tx5"
        Me.Info_Tx5.Size = New System.Drawing.Size(137, 25)
        Me.Info_Tx5.TabIndex = 266
        Me.Info_Tx5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownHeight = 70
        Me.ComboBox2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.IntegralHeight = False
        Me.ComboBox2.Location = New System.Drawing.Point(203, 340)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(137, 28)
        Me.ComboBox2.TabIndex = 267
        '
        'Info_Tx6
        '
        Me.Info_Tx6.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_Tx6.Location = New System.Drawing.Point(203, 396)
        Me.Info_Tx6.Name = "Info_Tx6"
        Me.Info_Tx6.Size = New System.Drawing.Size(137, 25)
        Me.Info_Tx6.TabIndex = 268
        Me.Info_Tx6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Info_Tx7
        '
        Me.Info_Tx7.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Info_Tx7.Location = New System.Drawing.Point(203, 454)
        Me.Info_Tx7.Name = "Info_Tx7"
        Me.Info_Tx7.Size = New System.Drawing.Size(478, 25)
        Me.Info_Tx7.TabIndex = 269
        '
        'IN_Date
        '
        Me.IN_Date.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.IN_Date.Location = New System.Drawing.Point(203, 226)
        Me.IN_Date.Name = "IN_Date"
        Me.IN_Date.Size = New System.Drawing.Size(137, 25)
        Me.IN_Date.TabIndex = 270
        Me.IN_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ForeiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 587)
        Me.Controls.Add(Me.IN_Date)
        Me.Controls.Add(Me.Info_Tx7)
        Me.Controls.Add(Me.Info_Tx6)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Info_Tx5)
        Me.Controls.Add(Me.Info_Tx4)
        Me.Controls.Add(Me.Info_La10)
        Me.Controls.Add(Me.Info_La9)
        Me.Controls.Add(Me.Info_La8)
        Me.Controls.Add(Me.Info_La7)
        Me.Controls.Add(Me.Info_La6)
        Me.Controls.Add(Me.Info_La5)
        Me.Controls.Add(Me.Info_Tx3)
        Me.Controls.Add(Me.Info_La4)
        Me.Controls.Add(Me.Info_Tx2)
        Me.Controls.Add(Me.Info_La2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Info_La3)
        Me.Controls.Add(Me.Info_Tx1)
        Me.Controls.Add(Me.Info_La1)
        Me.Controls.Add(Me.Info_Tx0)
        Me.Controls.Add(Me.Info_La0)
        Me.Name = "ForeiForm"
        Me.Text = "외국인 정보"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Info_La3 As Button
    Friend WithEvents Info_Tx1 As TextBox
    Friend WithEvents Info_La1 As Button
    Friend WithEvents Info_Tx0 As TextBox
    Friend WithEvents Info_La0 As Button
    Friend WithEvents Info_Tx2 As TextBox
    Friend WithEvents Info_La2 As Button
    Friend WithEvents Info_La4 As Button
    Friend WithEvents Info_Tx3 As TextBox
    Friend WithEvents Info_La5 As Button
    Friend WithEvents Info_La6 As Button
    Friend WithEvents Info_La7 As Button
    Friend WithEvents Info_La8 As Button
    Friend WithEvents Info_La9 As Button
    Friend WithEvents Info_La10 As Button
    Friend WithEvents Info_Tx4 As TextBox
    Friend WithEvents Info_Tx5 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Info_Tx6 As TextBox
    Friend WithEvents Info_Tx7 As TextBox
    Friend WithEvents IN_Date As TextBox
End Class
