<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cultivation
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.Room_1 = New System.Windows.Forms.Button()
        Me.Cul_Tx_1 = New System.Windows.Forms.TextBox()
        Me.Cul_Tx_10 = New System.Windows.Forms.TextBox()
        Me.Room_10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Room_1
        '
        Me.Room_1.BackColor = System.Drawing.Color.Transparent
        Me.Room_1.Font = New System.Drawing.Font("한컴 고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Room_1.Location = New System.Drawing.Point(41, 37)
        Me.Room_1.Name = "Room_1"
        Me.Room_1.Size = New System.Drawing.Size(89, 61)
        Me.Room_1.TabIndex = 0
        Me.Room_1.UseVisualStyleBackColor = False
        '
        'Cul_Tx_1
        '
        Me.Cul_Tx_1.BackColor = System.Drawing.Color.GreenYellow
        Me.Cul_Tx_1.Location = New System.Drawing.Point(41, 13)
        Me.Cul_Tx_1.Name = "Cul_Tx_1"
        Me.Cul_Tx_1.Size = New System.Drawing.Size(89, 21)
        Me.Cul_Tx_1.TabIndex = 1
        Me.Cul_Tx_1.Text = "1번방"
        Me.Cul_Tx_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cul_Tx_10
        '
        Me.Cul_Tx_10.BackColor = System.Drawing.Color.Yellow
        Me.Cul_Tx_10.Location = New System.Drawing.Point(1159, 13)
        Me.Cul_Tx_10.Name = "Cul_Tx_10"
        Me.Cul_Tx_10.Size = New System.Drawing.Size(89, 21)
        Me.Cul_Tx_10.TabIndex = 3
        Me.Cul_Tx_10.Text = "10 번방"
        Me.Cul_Tx_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Room_10
        '
        Me.Room_10.BackColor = System.Drawing.Color.Transparent
        Me.Room_10.Font = New System.Drawing.Font("한컴 고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Room_10.Location = New System.Drawing.Point(1159, 37)
        Me.Room_10.Name = "Room_10"
        Me.Room_10.Size = New System.Drawing.Size(89, 61)
        Me.Room_10.TabIndex = 2
        Me.Room_10.UseVisualStyleBackColor = False
        '
        'Frm_Cultivation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Cul_Tx_10)
        Me.Controls.Add(Me.Room_10)
        Me.Controls.Add(Me.Cul_Tx_1)
        Me.Controls.Add(Me.Room_1)
        Me.Location = New System.Drawing.Point(5, 5)
        Me.Name = "Frm_Cultivation"
        Me.Size = New System.Drawing.Size(1498, 798)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Room_1 As Button
    Friend WithEvents Cul_Tx_1 As TextBox
    Friend WithEvents Cul_Tx_10 As TextBox
    Friend WithEvents Room_10 As Button
End Class
