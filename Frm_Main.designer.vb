<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Picture_Logo = New System.Windows.Forms.PictureBox()
        Me.Text_Man_Code = New System.Windows.Forms.TextBox()
        Me.Com_DualMonitor = New System.Windows.Forms.Button()
        Me.Com_Minimize = New System.Windows.Forms.Button()
        Me.Com_Maximize = New System.Windows.Forms.Button()
        Me.Com_End = New System.Windows.Forms.Button()
        Me.Di_Panel1 = New System.Windows.Forms.Panel()
        Me.Di_Panel4 = New System.Windows.Forms.Panel()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Di_Panel5 = New System.Windows.Forms.Panel()
        Me.Panel_Tab_Menu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Tab_Menu_Title_End = New System.Windows.Forms.Button()
        Me.Panel_Sub_Menu = New System.Windows.Forms.Panel()
        Me.Sub_Menu10 = New System.Windows.Forms.Button()
        Me.Sub_Menu9 = New System.Windows.Forms.Button()
        Me.Sub_Menu8 = New System.Windows.Forms.Button()
        Me.Sub_Menu7 = New System.Windows.Forms.Button()
        Me.Sub_Menu6 = New System.Windows.Forms.Button()
        Me.Sub_Menu5 = New System.Windows.Forms.Button()
        Me.Sub_Menu4 = New System.Windows.Forms.Button()
        Me.Sub_Menu3 = New System.Windows.Forms.Button()
        Me.Sub_Menu2 = New System.Windows.Forms.Button()
        Me.Sub_Menu1 = New System.Windows.Forms.Button()
        Me.Di_Panel6 = New System.Windows.Forms.Panel()
        Me.Com_HideMenu = New System.Windows.Forms.Button()
        Me.Sub_Menu_Title = New System.Windows.Forms.Label()
        Me.Panel_Main_Menu = New System.Windows.Forms.Panel()
        Me.Main_Menu10 = New INNOFARM.Main_Menu()
        Me.Main_Menu9 = New INNOFARM.Main_Menu()
        Me.Main_Menu8 = New INNOFARM.Main_Menu()
        Me.Main_Menu7 = New INNOFARM.Main_Menu()
        Me.Main_Menu6 = New INNOFARM.Main_Menu()
        Me.Main_Menu5 = New INNOFARM.Main_Menu()
        Me.Main_Menu4 = New INNOFARM.Main_Menu()
        Me.Main_Menu3 = New INNOFARM.Main_Menu()
        Me.Main_Menu2 = New INNOFARM.Main_Menu()
        Me.Main_Menu1 = New INNOFARM.Main_Menu()
        Me.Di_Panel3 = New System.Windows.Forms.Panel()
        Me.Panel_Title.SuspendLayout()
        CType(Me.Picture_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Di_Panel4.SuspendLayout()
        Me.Panel_Tab_Menu.SuspendLayout()
        Me.Panel_Sub_Menu.SuspendLayout()
        Me.Di_Panel6.SuspendLayout()
        Me.Panel_Main_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.Controls.Add(Me.Label_Title)
        Me.Panel_Title.Controls.Add(Me.Picture_Logo)
        Me.Panel_Title.Controls.Add(Me.Text_Man_Code)
        Me.Panel_Title.Controls.Add(Me.Com_DualMonitor)
        Me.Panel_Title.Controls.Add(Me.Com_Minimize)
        Me.Panel_Title.Controls.Add(Me.Com_Maximize)
        Me.Panel_Title.Controls.Add(Me.Com_End)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1273, 48)
        Me.Panel_Title.TabIndex = 13
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("맑은 고딕", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(453, 4)
        Me.Label_Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(260, 37)
        Me.Label_Title.TabIndex = 11
        Me.Label_Title.Text = "이노팜 관리 시스템 "
        '
        'Picture_Logo
        '
        Me.Picture_Logo.BackColor = System.Drawing.Color.Transparent
        Me.Picture_Logo.Image = Global.INNOFARM.My.Resources.Resources.이노팜로고1
        Me.Picture_Logo.Location = New System.Drawing.Point(3, 3)
        Me.Picture_Logo.Name = "Picture_Logo"
        Me.Picture_Logo.Size = New System.Drawing.Size(88, 42)
        Me.Picture_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picture_Logo.TabIndex = 0
        Me.Picture_Logo.TabStop = False
        '
        'Text_Man_Code
        '
        Me.Text_Man_Code.Location = New System.Drawing.Point(998, 12)
        Me.Text_Man_Code.Name = "Text_Man_Code"
        Me.Text_Man_Code.Size = New System.Drawing.Size(121, 21)
        Me.Text_Man_Code.TabIndex = 17
        Me.Text_Man_Code.Visible = False
        '
        'Com_DualMonitor
        '
        Me.Com_DualMonitor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Com_DualMonitor.BackColor = System.Drawing.Color.White
        Me.Com_DualMonitor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Com_DualMonitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.Com_DualMonitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Com_DualMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Com_DualMonitor.Location = New System.Drawing.Point(1135, 4)
        Me.Com_DualMonitor.Margin = New System.Windows.Forms.Padding(2)
        Me.Com_DualMonitor.Name = "Com_DualMonitor"
        Me.Com_DualMonitor.Size = New System.Drawing.Size(31, 27)
        Me.Com_DualMonitor.TabIndex = 10
        Me.Com_DualMonitor.TabStop = False
        Me.Com_DualMonitor.Text = "↔"
        Me.Com_DualMonitor.UseVisualStyleBackColor = False
        '
        'Com_Minimize
        '
        Me.Com_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Com_Minimize.BackColor = System.Drawing.Color.White
        Me.Com_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Com_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.Com_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Com_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Com_Minimize.Location = New System.Drawing.Point(1170, 4)
        Me.Com_Minimize.Margin = New System.Windows.Forms.Padding(2)
        Me.Com_Minimize.Name = "Com_Minimize"
        Me.Com_Minimize.Size = New System.Drawing.Size(31, 27)
        Me.Com_Minimize.TabIndex = 9
        Me.Com_Minimize.TabStop = False
        Me.Com_Minimize.Text = "_"
        Me.Com_Minimize.UseVisualStyleBackColor = False
        '
        'Com_Maximize
        '
        Me.Com_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Com_Maximize.BackColor = System.Drawing.Color.White
        Me.Com_Maximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Com_Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.Com_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Com_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Com_Maximize.Location = New System.Drawing.Point(1205, 4)
        Me.Com_Maximize.Margin = New System.Windows.Forms.Padding(2)
        Me.Com_Maximize.Name = "Com_Maximize"
        Me.Com_Maximize.Size = New System.Drawing.Size(31, 27)
        Me.Com_Maximize.TabIndex = 8
        Me.Com_Maximize.TabStop = False
        Me.Com_Maximize.Text = "□"
        Me.Com_Maximize.UseVisualStyleBackColor = False
        '
        'Com_End
        '
        Me.Com_End.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Com_End.BackColor = System.Drawing.Color.White
        Me.Com_End.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Com_End.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.Com_End.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Com_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Com_End.Location = New System.Drawing.Point(1240, 4)
        Me.Com_End.Margin = New System.Windows.Forms.Padding(2)
        Me.Com_End.Name = "Com_End"
        Me.Com_End.Size = New System.Drawing.Size(31, 27)
        Me.Com_End.TabIndex = 7
        Me.Com_End.TabStop = False
        Me.Com_End.Text = "X"
        Me.Com_End.UseVisualStyleBackColor = False
        '
        'Di_Panel1
        '
        Me.Di_Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Di_Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Di_Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Di_Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Di_Panel1.Name = "Di_Panel1"
        Me.Di_Panel1.Size = New System.Drawing.Size(1273, 880)
        Me.Di_Panel1.TabIndex = 12
        '
        'Di_Panel4
        '
        Me.Di_Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Di_Panel4.Controls.Add(Me.Panel_Main)
        Me.Di_Panel4.Controls.Add(Me.Di_Panel5)
        Me.Di_Panel4.Controls.Add(Me.Panel_Tab_Menu)
        Me.Di_Panel4.Controls.Add(Me.Panel_Sub_Menu)
        Me.Di_Panel4.Controls.Add(Me.Panel_Main_Menu)
        Me.Di_Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Di_Panel4.Location = New System.Drawing.Point(0, 48)
        Me.Di_Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Di_Panel4.Name = "Di_Panel4"
        Me.Di_Panel4.Size = New System.Drawing.Size(1273, 832)
        Me.Di_Panel4.TabIndex = 20
        '
        'Panel_Main
        '
        Me.Panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(460, 135)
        Me.Panel_Main.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(811, 695)
        Me.Panel_Main.TabIndex = 22
        '
        'Di_Panel5
        '
        Me.Di_Panel5.BackColor = System.Drawing.Color.DarkOrange
        Me.Di_Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Di_Panel5.Location = New System.Drawing.Point(460, 135)
        Me.Di_Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Di_Panel5.Name = "Di_Panel5"
        Me.Di_Panel5.Size = New System.Drawing.Size(811, 0)
        Me.Di_Panel5.TabIndex = 21
        '
        'Panel_Tab_Menu
        '
        Me.Panel_Tab_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Tab_Menu.Controls.Add(Me.Tab_Menu_Title_End)
        Me.Panel_Tab_Menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Tab_Menu.Location = New System.Drawing.Point(460, 0)
        Me.Panel_Tab_Menu.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Tab_Menu.Name = "Panel_Tab_Menu"
        Me.Panel_Tab_Menu.Size = New System.Drawing.Size(811, 135)
        Me.Panel_Tab_Menu.TabIndex = 17
        Me.Panel_Tab_Menu.WrapContents = False
        '
        'Tab_Menu_Title_End
        '
        Me.Tab_Menu_Title_End.BackColor = System.Drawing.Color.Transparent
        Me.Tab_Menu_Title_End.Dock = System.Windows.Forms.DockStyle.Right
        Me.Tab_Menu_Title_End.FlatAppearance.BorderSize = 0
        Me.Tab_Menu_Title_End.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Tab_Menu_Title_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab_Menu_Title_End.Location = New System.Drawing.Point(0, 2)
        Me.Tab_Menu_Title_End.Margin = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.Tab_Menu_Title_End.Name = "Tab_Menu_Title_End"
        Me.Tab_Menu_Title_End.Size = New System.Drawing.Size(26, 0)
        Me.Tab_Menu_Title_End.TabIndex = 17
        Me.Tab_Menu_Title_End.TabStop = False
        Me.Tab_Menu_Title_End.Text = "X"
        Me.Tab_Menu_Title_End.UseVisualStyleBackColor = False
        Me.Tab_Menu_Title_End.Visible = False
        '
        'Panel_Sub_Menu
        '
        Me.Panel_Sub_Menu.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu10)
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu9)
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu8)
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu7)
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu6)
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu5)
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu4)
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu3)
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu2)
        Me.Panel_Sub_Menu.Controls.Add(Me.Sub_Menu1)
        Me.Panel_Sub_Menu.Controls.Add(Me.Di_Panel6)
        Me.Panel_Sub_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Sub_Menu.Location = New System.Drawing.Point(46, 0)
        Me.Panel_Sub_Menu.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Sub_Menu.Name = "Panel_Sub_Menu"
        Me.Panel_Sub_Menu.Size = New System.Drawing.Size(414, 830)
        Me.Panel_Sub_Menu.TabIndex = 12
        '
        'Sub_Menu10
        '
        Me.Sub_Menu10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu10.BackColor = System.Drawing.Color.White
        Me.Sub_Menu10.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Sub_Menu10.Location = New System.Drawing.Point(5, 312)
        Me.Sub_Menu10.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu10.Name = "Sub_Menu10"
        Me.Sub_Menu10.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu10.TabIndex = 28
        Me.Sub_Menu10.TabStop = False
        Me.Sub_Menu10.Text = "Sub-10"
        Me.Sub_Menu10.UseVisualStyleBackColor = False
        Me.Sub_Menu10.Visible = False
        '
        'Sub_Menu9
        '
        Me.Sub_Menu9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu9.BackColor = System.Drawing.Color.White
        Me.Sub_Menu9.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Sub_Menu9.Location = New System.Drawing.Point(5, 281)
        Me.Sub_Menu9.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu9.Name = "Sub_Menu9"
        Me.Sub_Menu9.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu9.TabIndex = 27
        Me.Sub_Menu9.TabStop = False
        Me.Sub_Menu9.Text = "Sub-9"
        Me.Sub_Menu9.UseVisualStyleBackColor = False
        Me.Sub_Menu9.Visible = False
        '
        'Sub_Menu8
        '
        Me.Sub_Menu8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu8.BackColor = System.Drawing.Color.White
        Me.Sub_Menu8.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Sub_Menu8.Location = New System.Drawing.Point(5, 250)
        Me.Sub_Menu8.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu8.Name = "Sub_Menu8"
        Me.Sub_Menu8.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu8.TabIndex = 26
        Me.Sub_Menu8.TabStop = False
        Me.Sub_Menu8.Text = "Sub-8"
        Me.Sub_Menu8.UseVisualStyleBackColor = False
        Me.Sub_Menu8.Visible = False
        '
        'Sub_Menu7
        '
        Me.Sub_Menu7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu7.BackColor = System.Drawing.Color.White
        Me.Sub_Menu7.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Sub_Menu7.Location = New System.Drawing.Point(5, 219)
        Me.Sub_Menu7.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu7.Name = "Sub_Menu7"
        Me.Sub_Menu7.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu7.TabIndex = 25
        Me.Sub_Menu7.TabStop = False
        Me.Sub_Menu7.Text = "Sub-7"
        Me.Sub_Menu7.UseVisualStyleBackColor = False
        Me.Sub_Menu7.Visible = False
        '
        'Sub_Menu6
        '
        Me.Sub_Menu6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu6.BackColor = System.Drawing.Color.White
        Me.Sub_Menu6.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Sub_Menu6.Location = New System.Drawing.Point(5, 188)
        Me.Sub_Menu6.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu6.Name = "Sub_Menu6"
        Me.Sub_Menu6.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu6.TabIndex = 24
        Me.Sub_Menu6.TabStop = False
        Me.Sub_Menu6.Text = "Sub-6"
        Me.Sub_Menu6.UseVisualStyleBackColor = False
        Me.Sub_Menu6.Visible = False
        '
        'Sub_Menu5
        '
        Me.Sub_Menu5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu5.BackColor = System.Drawing.Color.Gainsboro
        Me.Sub_Menu5.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu5.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_Menu5.Location = New System.Drawing.Point(5, 157)
        Me.Sub_Menu5.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu5.Name = "Sub_Menu5"
        Me.Sub_Menu5.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu5.TabIndex = 23
        Me.Sub_Menu5.TabStop = False
        Me.Sub_Menu5.Text = "Sub-5"
        Me.Sub_Menu5.UseVisualStyleBackColor = False
        Me.Sub_Menu5.Visible = False
        '
        'Sub_Menu4
        '
        Me.Sub_Menu4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu4.BackColor = System.Drawing.Color.White
        Me.Sub_Menu4.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Sub_Menu4.Location = New System.Drawing.Point(5, 126)
        Me.Sub_Menu4.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu4.Name = "Sub_Menu4"
        Me.Sub_Menu4.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu4.TabIndex = 22
        Me.Sub_Menu4.TabStop = False
        Me.Sub_Menu4.Text = "Sub-4"
        Me.Sub_Menu4.UseVisualStyleBackColor = False
        Me.Sub_Menu4.Visible = False
        '
        'Sub_Menu3
        '
        Me.Sub_Menu3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu3.BackColor = System.Drawing.Color.White
        Me.Sub_Menu3.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Sub_Menu3.Location = New System.Drawing.Point(5, 95)
        Me.Sub_Menu3.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu3.Name = "Sub_Menu3"
        Me.Sub_Menu3.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu3.TabIndex = 21
        Me.Sub_Menu3.TabStop = False
        Me.Sub_Menu3.Text = "Sub-3"
        Me.Sub_Menu3.UseVisualStyleBackColor = False
        Me.Sub_Menu3.Visible = False
        '
        'Sub_Menu2
        '
        Me.Sub_Menu2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu2.BackColor = System.Drawing.Color.White
        Me.Sub_Menu2.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Sub_Menu2.Location = New System.Drawing.Point(5, 64)
        Me.Sub_Menu2.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu2.Name = "Sub_Menu2"
        Me.Sub_Menu2.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu2.TabIndex = 20
        Me.Sub_Menu2.TabStop = False
        Me.Sub_Menu2.Text = "Sub-2"
        Me.Sub_Menu2.UseVisualStyleBackColor = False
        Me.Sub_Menu2.Visible = False
        '
        'Sub_Menu1
        '
        Me.Sub_Menu1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sub_Menu1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Sub_Menu1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Sub_Menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sub_Menu1.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_Menu1.Location = New System.Drawing.Point(5, 33)
        Me.Sub_Menu1.Margin = New System.Windows.Forms.Padding(2)
        Me.Sub_Menu1.Name = "Sub_Menu1"
        Me.Sub_Menu1.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu1.TabIndex = 19
        Me.Sub_Menu1.TabStop = False
        Me.Sub_Menu1.Text = "Sub-1"
        Me.Sub_Menu1.UseVisualStyleBackColor = False
        Me.Sub_Menu1.Visible = False
        '
        'Di_Panel6
        '
        Me.Di_Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Di_Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Di_Panel6.Controls.Add(Me.Com_HideMenu)
        Me.Di_Panel6.Controls.Add(Me.Sub_Menu_Title)
        Me.Di_Panel6.Location = New System.Drawing.Point(5, 2)
        Me.Di_Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Di_Panel6.Name = "Di_Panel6"
        Me.Di_Panel6.Size = New System.Drawing.Size(403, 27)
        Me.Di_Panel6.TabIndex = 18
        '
        'Com_HideMenu
        '
        Me.Com_HideMenu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Com_HideMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.Com_HideMenu.FlatAppearance.BorderSize = 0
        Me.Com_HideMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Com_HideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Com_HideMenu.Location = New System.Drawing.Point(377, 0)
        Me.Com_HideMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.Com_HideMenu.Name = "Com_HideMenu"
        Me.Com_HideMenu.Size = New System.Drawing.Size(26, 27)
        Me.Com_HideMenu.TabIndex = 18
        Me.Com_HideMenu.TabStop = False
        Me.Com_HideMenu.Text = "<"
        Me.Com_HideMenu.UseVisualStyleBackColor = False
        '
        'Sub_Menu_Title
        '
        Me.Sub_Menu_Title.BackColor = System.Drawing.Color.NavajoWhite
        Me.Sub_Menu_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sub_Menu_Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sub_Menu_Title.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Sub_Menu_Title.ForeColor = System.Drawing.Color.Black
        Me.Sub_Menu_Title.Location = New System.Drawing.Point(0, 0)
        Me.Sub_Menu_Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Sub_Menu_Title.Name = "Sub_Menu_Title"
        Me.Sub_Menu_Title.Size = New System.Drawing.Size(403, 27)
        Me.Sub_Menu_Title.TabIndex = 16
        Me.Sub_Menu_Title.Text = "Title"
        Me.Sub_Menu_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Main_Menu
        '
        Me.Panel_Main_Menu.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu10)
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu9)
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu8)
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu7)
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu6)
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu5)
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu4)
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu3)
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu2)
        Me.Panel_Main_Menu.Controls.Add(Me.Main_Menu1)
        Me.Panel_Main_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Main_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main_Menu.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Main_Menu.Name = "Panel_Main_Menu"
        Me.Panel_Main_Menu.Size = New System.Drawing.Size(46, 830)
        Me.Panel_Main_Menu.TabIndex = 0
        '
        'Main_Menu10
        '
        Me.Main_Menu10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu10.BackColor = System.Drawing.Color.White
        Me.Main_Menu10.Location = New System.Drawing.Point(1, 729)
        Me.Main_Menu10.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu10.Name = "Main_Menu10"
        Me.Main_Menu10.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu10.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu10.TabIndex = 9
        '
        'Main_Menu9
        '
        Me.Main_Menu9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu9.BackColor = System.Drawing.Color.White
        Me.Main_Menu9.Location = New System.Drawing.Point(1, 648)
        Me.Main_Menu9.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu9.Name = "Main_Menu9"
        Me.Main_Menu9.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu9.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu9.TabIndex = 8
        '
        'Main_Menu8
        '
        Me.Main_Menu8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu8.BackColor = System.Drawing.Color.White
        Me.Main_Menu8.Location = New System.Drawing.Point(1, 567)
        Me.Main_Menu8.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu8.Name = "Main_Menu8"
        Me.Main_Menu8.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu8.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu8.TabIndex = 7
        '
        'Main_Menu7
        '
        Me.Main_Menu7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu7.BackColor = System.Drawing.Color.White
        Me.Main_Menu7.Location = New System.Drawing.Point(1, 486)
        Me.Main_Menu7.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu7.Name = "Main_Menu7"
        Me.Main_Menu7.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu7.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu7.TabIndex = 6
        '
        'Main_Menu6
        '
        Me.Main_Menu6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu6.BackColor = System.Drawing.Color.White
        Me.Main_Menu6.Location = New System.Drawing.Point(1, 405)
        Me.Main_Menu6.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu6.Name = "Main_Menu6"
        Me.Main_Menu6.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu6.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu6.TabIndex = 5
        '
        'Main_Menu5
        '
        Me.Main_Menu5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu5.BackColor = System.Drawing.Color.White
        Me.Main_Menu5.Location = New System.Drawing.Point(1, 324)
        Me.Main_Menu5.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu5.Name = "Main_Menu5"
        Me.Main_Menu5.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu5.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu5.TabIndex = 4
        '
        'Main_Menu4
        '
        Me.Main_Menu4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu4.BackColor = System.Drawing.Color.White
        Me.Main_Menu4.Location = New System.Drawing.Point(1, 243)
        Me.Main_Menu4.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu4.Name = "Main_Menu4"
        Me.Main_Menu4.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu4.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu4.TabIndex = 3
        '
        'Main_Menu3
        '
        Me.Main_Menu3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu3.BackColor = System.Drawing.Color.White
        Me.Main_Menu3.Location = New System.Drawing.Point(1, 162)
        Me.Main_Menu3.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu3.Name = "Main_Menu3"
        Me.Main_Menu3.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu3.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu3.TabIndex = 2
        '
        'Main_Menu2
        '
        Me.Main_Menu2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu2.BackColor = System.Drawing.Color.White
        Me.Main_Menu2.Location = New System.Drawing.Point(1, 81)
        Me.Main_Menu2.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu2.Name = "Main_Menu2"
        Me.Main_Menu2.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu2.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu2.TabIndex = 1
        '
        'Main_Menu1
        '
        Me.Main_Menu1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Menu1.BackColor = System.Drawing.Color.White
        Me.Main_Menu1.Location = New System.Drawing.Point(1, 0)
        Me.Main_Menu1.Margin = New System.Windows.Forms.Padding(4)
        Me.Main_Menu1.Name = "Main_Menu1"
        Me.Main_Menu1.Padding = New System.Windows.Forms.Padding(5)
        Me.Main_Menu1.Size = New System.Drawing.Size(46, 80)
        Me.Main_Menu1.TabIndex = 0
        '
        'Di_Panel3
        '
        Me.Di_Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Di_Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Di_Panel3.Location = New System.Drawing.Point(0, 48)
        Me.Di_Panel3.Name = "Di_Panel3"
        Me.Di_Panel3.Size = New System.Drawing.Size(1273, 832)
        Me.Di_Panel3.TabIndex = 19
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1273, 880)
        Me.Controls.Add(Me.Di_Panel4)
        Me.Controls.Add(Me.Di_Panel3)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Di_Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Main"
        Me.Text = "MES 프로그램"
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Title.PerformLayout()
        CType(Me.Picture_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Di_Panel4.ResumeLayout(False)
        Me.Panel_Tab_Menu.ResumeLayout(False)
        Me.Panel_Sub_Menu.ResumeLayout(False)
        Me.Di_Panel6.ResumeLayout(False)
        Me.Panel_Main_Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Picture_Logo As PictureBox
    Friend WithEvents Text_Man_Code As TextBox
    Friend WithEvents Label_Title As Label
    Friend WithEvents Com_DualMonitor As Button
    Friend WithEvents Com_Minimize As Button
    Friend WithEvents Com_Maximize As Button
    Friend WithEvents Com_End As Button
    Friend WithEvents Di_Panel1 As Panel
    Friend WithEvents Di_Panel4 As Panel
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_Tab_Menu As FlowLayoutPanel
    Friend WithEvents Tab_Menu_Title_End As Button
    Friend WithEvents Panel_Sub_Menu As Panel
    Friend WithEvents Sub_Menu10 As Button
    Friend WithEvents Sub_Menu9 As Button
    Friend WithEvents Sub_Menu8 As Button
    Friend WithEvents Sub_Menu7 As Button
    Friend WithEvents Sub_Menu6 As Button
    Friend WithEvents Sub_Menu5 As Button
    Friend WithEvents Sub_Menu4 As Button
    Friend WithEvents Sub_Menu3 As Button
    Friend WithEvents Sub_Menu2 As Button
    Friend WithEvents Sub_Menu1 As Button
    Friend WithEvents Di_Panel6 As Panel
    Friend WithEvents Com_HideMenu As Button
    Friend WithEvents Sub_Menu_Title As Label
    Friend WithEvents Panel_Main_Menu As Panel
    Friend WithEvents Di_Panel3 As Panel
    Friend WithEvents Main_Menu3 As Main_Menu
    Friend WithEvents Main_Menu2 As Main_Menu
    Friend WithEvents Main_Menu1 As Main_Menu
    Friend WithEvents Main_Menu4 As Main_Menu
    Friend WithEvents Main_Menu10 As Main_Menu
    Friend WithEvents Main_Menu9 As Main_Menu
    Friend WithEvents Main_Menu8 As Main_Menu
    Friend WithEvents Main_Menu7 As Main_Menu
    Friend WithEvents Main_Menu6 As Main_Menu
    Friend WithEvents Main_Menu5 As Main_Menu
    Friend WithEvents Di_Panel5 As Panel
End Class
