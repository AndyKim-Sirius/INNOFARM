﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.Button_Menu = New System.Windows.Forms.Button()
        Me.Label_Menu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Menu
        '
        Me.Button_Menu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Menu.AutoSize = True
        Me.Button_Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_Menu.BackColor = System.Drawing.Color.White
        Me.Button_Menu.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.Button_Menu.FlatAppearance.BorderSize = 0
        Me.Button_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Menu.Font = New System.Drawing.Font("새굴림", 11.0!)
        Me.Button_Menu.ForeColor = System.Drawing.Color.Black
        Me.Button_Menu.Location = New System.Drawing.Point(5, 0)
        Me.Button_Menu.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Menu.Name = "Button_Menu"
        Me.Button_Menu.Size = New System.Drawing.Size(6, 6)
        Me.Button_Menu.TabIndex = 20
        Me.Button_Menu.TabStop = False
        Me.Button_Menu.UseVisualStyleBackColor = False
        '
        'Label_Menu
        '
        Me.Label_Menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_Menu.BackColor = System.Drawing.Color.DarkOrange
        Me.Label_Menu.Location = New System.Drawing.Point(0, 6)
        Me.Label_Menu.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_Menu.Name = "Label_Menu"
        Me.Label_Menu.Size = New System.Drawing.Size(3, 31)
        Me.Label_Menu.TabIndex = 19
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_Menu)
        Me.Controls.Add(Me.Label_Menu)
        Me.Name = "Main_Menu"
        Me.Size = New System.Drawing.Size(112, 42)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Menu As Button
    Friend WithEvents Label_Menu As Label
End Class
