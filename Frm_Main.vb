﻿Public Class Frm_Main
    Dim Main_Menu_Array(9) As Main_Menu
    Dim Sub_Menu(9) As Button
    Dim Tab_Menu_Title_Count As Integer
    Dim Tab_Menu_Title_Array As New Dictionary(Of Integer, Button)
    Dim Tab_Menu_Title_End_Array As New Dictionary(Of Integer, Button)

    Dim Form_Array As New Dictionary(Of Integer, UserControl)


    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Show()
        Me.Bounds = Screen.FromHandle(Me.Handle).WorkingArea

        '여기부터 시작
        Dim dualMonitor() As Screen = Screen.AllScreens
        If dualMonitor.Length = 2 Then
            If Me.Bounds = dualMonitor(1).Bounds Then
                Me.Bounds = dualMonitor(0).WorkingArea
            Else
                Me.Bounds = dualMonitor(1).WorkingArea
            End If
        End If
        ' /* ---------------------------------------------------------
        '  
        ' ----------------------------------------------------------*/
        OBJ_Back_Color(Di_Panel1)
        OBJ_Back_Color(Di_Panel3)
        OBJ_Back_Color(Di_Panel5)
        Panel_Sub_Menu.Width = 0
        Menu_Set()
        Sub_Menu_Set()
        Tab_Menu_Title_Count = 0
        ''Image
        ' PIc_Pic(Picture_Logo, Application.StartupPath & "\Picture\Logo_" & Setup_Data(9) & ".png")
        ' PIc_Pic(Picture_Man, Application.StartupPath & "\Picture\User.png")

        Main_load()

    End Sub


    Private Function Main_load() As Boolean

        For Each tt In Panel_Tab_Menu.Controls
            '
        Next

        Dim Btn As New Button

        Tab_Menu_Title_Array.Add(Tab_Menu_Title_Count, Btn)
        Panel_Tab_Menu.Controls.Add(Btn)
        Btn.Anchor = AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Right
        Btn.AutoEllipsis = True
        Btn.FlatAppearance.BorderSize = 0
        OBJ_MouseOver_Color(Btn)

        Btn.FlatStyle = FlatStyle.Flat
        Btn.Width = 100
        Btn.Height = 30
        Btn.Text = "메 인"

        OBJ_Back_Color(Btn)
        Btn.Tag = Tab_Menu_Title_Count
        Btn.Visible = True
        AddHandler Btn.Click, AddressOf Tab_Menu_Title_Click

        Dim i As Integer
        Dim j As Integer
        Dim D As Object = Nothing

        D = GetForm("INNOFARM", Menu_String(i + 9, j))
        'D = GetForm("INNOFARM", "Frm_Begin")

        Form_Array.Add(Tab_Menu_Title_Count, D)

        If D IsNot Nothing Then
            Panel_Main.Controls.Add(D)
            D.BringToFront()
        End If

        Tab_Menu_Title_Count = Tab_Menu_Title_Count + 1
        'Size 계산
        Sub_Menu_Size()
        '      Main_load = True
    End Function

    Private Sub Sub_Menu_Set()
        Dim i As Long
        Sub_Menu(0) = Sub_Menu1
        Sub_Menu(1) = Sub_Menu2
        Sub_Menu(2) = Sub_Menu3
        Sub_Menu(3) = Sub_Menu4
        Sub_Menu(4) = Sub_Menu5
        Sub_Menu(5) = Sub_Menu6
        Sub_Menu(6) = Sub_Menu7
        Sub_Menu(7) = Sub_Menu8
        Sub_Menu(8) = Sub_Menu9
        Sub_Menu(9) = Sub_Menu10


        For i = 0 To 9
            AddHandler Sub_Menu(i).Click, AddressOf Sub_Menu1_Click
        Next i


    End Sub

    Private Sub Menu_Set()
        '메뉴를 DB에서 가지고 온다.

        Dim DBT As New DataTable
        Dim i As Integer
        Dim j As Integer
        StrSQL = "Select * From Menu_Setup With(NOLOCK) Order By Sun"

        Re_Count = DB_Select(DBT)
        If Re_Count <> 0 Then
            For i = 0 To Re_Count - 1
                Menu_String(i, 0) = DBT.Rows(i)("Main_Menu").ToString

                For j = 2 To 11 '메인모듈 스트링 개수도 같이 조절할것
                    Menu_String(i, j - 1) = Trim(DBT.Rows(i).Item(j).ToString)
                Next j
            Next i
        End If

        If Re_Count <> 0 Then
            If Len(Menu_String(i, j)) > 0 Then
                For i = 0 To Re_Count - 1
                    For j = 0 To 9 '클릭했을때 화면 +1
                        If Mid(Menu_String(i, j), Len(Menu_String(i, j)) - 1, 1) = vbCr Then
                            j = j
                            Menu_String(i, j) = Mid(Menu_String(i, j), 1, Len(Menu_String(i, j)) - 2)
                        End If
                    Next j
                Next i
            End If
        End If


        'If Len(Menu_String(7, 0)) < 1 Then
        '    Main_Menu8.Visible = False
        'End If

        Main_Menu_Array(0) = Main_Menu1
        Main_Menu_Array(1) = Main_Menu2
        Main_Menu_Array(2) = Main_Menu3
        Main_Menu_Array(3) = Main_Menu4
        Main_Menu_Array(4) = Main_Menu5
        Main_Menu_Array(5) = Main_Menu6
        Main_Menu_Array(6) = Main_Menu7
        Main_Menu_Array(7) = Main_Menu8
        Main_Menu_Array(8) = Main_Menu9
        Main_Menu_Array(9) = Main_Menu10

        Dim Menu_Title As String = ""

        For i = 0 To Main_Menu_Array.Length - 1
            For j = 0 To Menu_String(i, 0).Length - 1
                If j <> Menu_String(i, 0).Length - 1 Then
                    Menu_Title += Menu_String(i, 0)(j) & vbCrLf
                Else
                    Menu_Title += Menu_String(i, 0)(j)
                End If
            Next
            Main_Menu_Array(i).Set_Button_Text(Menu_Title)
            Menu_Title = ""
        Next

    End Sub
    Private Sub Sub_Menu1_Click(sender As Object, e As EventArgs)

        Dim Pro_LE(9) As String
        Dim DBT As New DataTable
        Dim DD As Object = Nothing


        StrSQL = "Select * From SI_MAN With(NOLOCK), SI_MAN_Level With(NOLOCK) Where Man_Code = '" & Text_Man_Code.Text & "' And Man_Level =  Le_Code"
        Re_Count = DB_Select(DBT)
        If Re_Count <> 0 Then
            Pro_LE(1) = DBT.Rows(0)("Le_Level1").ToString
            Pro_LE(2) = DBT.Rows(0)("Le_Level2").ToString
            Pro_LE(3) = DBT.Rows(0)("Le_Level3").ToString
            Pro_LE(4) = DBT.Rows(0)("Le_Level4").ToString
            Pro_LE(5) = DBT.Rows(0)("Le_Level5").ToString
            Pro_LE(6) = DBT.Rows(0)("Le_Level6").ToString
            Pro_LE(7) = DBT.Rows(0)("Le_Level7").ToString
            Pro_LE(8) = DBT.Rows(0)("Le_Level8").ToString
            Pro_LE(9) = DBT.Rows(0)("Le_Level9").ToString
        End If

        Dim i As Integer
        Dim j As Integer
        '요기부터 사용권한
        For i = 0 To 9
            For j = 0 To 9
                If Menu_String(i, j) = sender.text Then
                    If Pro_LE(i + 1) = 1 Then
                    Else
                        MsgBox("사용권한이 없습니다.")
                        Exit Sub
                    End If
                End If
            Next j
        Next i
        '요기까지


        If sender.text = "거래처정보" Then
            DD = GetForm("INNOFARM", "Frm_Customer")
            Panel_Main.Controls.Add(DD)
            DD.BringToFront()
            Exit Sub
        End If

        If sender.text = "외국인정보" Then
            DD = GetForm("INNOFARM", "Frm_Forei")
            Panel_Main.Controls.Add(DD)
            DD.BringToFront()
            Exit Sub
        End If

        If sender.text = "발주현황" Then
            DD = GetForm("INNOFARM", "Frm_Balju")
            Panel_Main.Controls.Add(DD)
            DD.BringToFront()
            Exit Sub
        End If

        If sender.text = "재배사현황" Then
            DD = GetForm("INNOFARM", "Frm_Cultivation")
            Panel_Main.Controls.Add(DD)
            DD.BringToFront()
            Exit Sub
        End If

        Dim Form_Check As String
        Form_Check = ""
        For Each tt In Panel_Tab_Menu.Controls
            If tt.text = sender.text Then
                Form_Array(tt.tag).BringToFront()
                tt.BackColor = Color.DarkOrange
                Form_Check = "Ok"
            Else
                '띠우고
                tt.BackColor = Color.White
            End If
        Next
        If Form_Check = "Ok" Then
            Exit Sub
        End If

        Dim Btn As New Button
        Tab_Menu_Title_Array.Add(Tab_Menu_Title_Count, Btn)
        Panel_Tab_Menu.Controls.Add(Btn)
        Btn.Anchor = AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Right
        Btn.AutoEllipsis = True
        Btn.FlatAppearance.BorderSize = 0
        OBJ_MouseOver_Color(Btn)

        Btn.FlatStyle = FlatStyle.Flat
        Btn.Width = 165
        Btn.Height = 20
        Btn.Text = sender.text

        OBJ_Back_Color(Btn)
        Btn.Tag = Tab_Menu_Title_Count
        Btn.Visible = True
        AddHandler Btn.Click, AddressOf Tab_Menu_Title_Click

        Dim Btn_End As New Button
        Tab_Menu_Title_End_Array.Add(Tab_Menu_Title_Count, Btn_End)
        Panel_Tab_Menu.Controls.Add(Btn_End)
        Btn_End.Anchor = AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Right
        Btn_End.AutoEllipsis = True
        Btn_End.FlatAppearance.BorderSize = 0
        OBJ_MouseOver_Color(Btn_End)
        Btn_End.FlatStyle = FlatStyle.Flat
        Btn_End.Width = 20
        Btn_End.Height = 20
        Btn_End.Text = "X"
        Btn_End.Tag = Tab_Menu_Title_Count
        Btn_End.Visible = True
        AddHandler Btn_End.Click, AddressOf Tab_Menu_Title_End_Click

        Dim D As Object
        For i = 0 To 10
            For j = 1 To 19
                If sender.text = Menu_String(i, j) Then
                    D = GetForm("INNOFARM", Menu_String(i + 10, j)) '기준점
                End If
            Next j
        Next i

        Form_Array.Add(Tab_Menu_Title_Count, D)
        If D IsNot Nothing Then
            Panel_Main.Controls.Add(D)
            D.BringToFront()
        End If

        Tab_Menu_Title_Count = Tab_Menu_Title_Count + 1
        'Size 계산
        Sub_Menu_Size()

        Dim k As Integer
        For k = 0 To Sub_Menu.Count - 1
            If Sub_Menu(i).Text = sender.text Then
                Sub_Menu(i).BackColor = Color.AliceBlue
            End If

        Next

    End Sub
    ' 메뉴를 추가하면 아래 Handle 값을 추가 하여야 함
    ' 
    Private Sub Main_Menu1_Click(sender As Object, e As EventArgs) Handles Main_Menu1.Button_Menu_Click_Data, Main_Menu2.Button_Menu_Click_Data, Main_Menu3.Button_Menu_Click_Data, Main_Menu4.Button_Menu_Click_Data,
                                                                           Main_Menu5.Button_Menu_Click_Data, Main_Menu6.Button_Menu_Click_Data, Main_Menu7.Button_Menu_Click_Data, Main_Menu8.Button_Menu_Click_Data,
                                                                           Main_Menu9.Button_Menu_Click_Data, Main_Menu10.Button_Menu_Click_Data
        Dim i As Integer

        For i = 0 To Main_Menu_Array.Length - 1
            If Main_Menu_Array(i).Label_Get_Text.Equals(sender.text) Then
                Main_Menu_Array(i).Set_Label_Color(Color.DeepPink)
                sender.backcolor = Color.CornflowerBlue
                sender.forecolor = Color.White

                Sub_Menu_Title.Text = Replace(sender.text, vbCrLf, "")
                Load_Sub_Menu(i)
                Main_Menu_Array(i).Update()
            Else
                Main_Menu_Array(i).Set_Label_Color_Won(Color.DarkOrange)
                Main_Menu_Array(i).Button_Color(Color.Transparent)
                Main_Menu_Array(i).Fore_Color(Color.Black)
                Main_Menu_Array(i).Update()
            End If
        Next

        Panel_Sub_Menu.Width = 200

    End Sub
    Private Sub Load_Sub_Menu(index As Integer)
        Dim i As Integer
        For i = 0 To Sub_Menu.Length - 1
            If Menu_String(index, i + 1) <> "" Then
                Sub_Menu(i).Text = Menu_String(index, i + 1)
                Sub_Menu(i).Visible = True
            Else
                Sub_Menu(i).Visible = False
            End If

        Next
    End Sub
    Private Sub Tab_Menu_Title_Click(sender As Object, e As EventArgs)
        'Sub 클릭시
        '      For Each tt In Panel_Tab_Menu.Controls
        '     If tt.text = sender.text Then
        '    Form_Array(tt.tag).BringToFront()
        '   tt.BackColor = Color.DarkOrange
        '  Else
        ' '띠우고
        'tt.BackColor = Color.White
        'End If
        '  Next

    End Sub
    Private Sub Tab_Menu_Title_End_Click(sender As Object, e As EventArgs)
        '종료버튼
        Panel_Tab_Menu.Controls.Remove(Tab_Menu_Title_Array(sender.tag))
        Tab_Menu_Title_Array.Remove(sender.TAG)
        Panel_Tab_Menu.Controls.Remove(Tab_Menu_Title_End_Array(sender.tag))
        Tab_Menu_Title_End_Array.Remove(sender.TAG)
        '생성된 폼을 죽인다.
        Sub_Menu_Size()
        Panel_Main.Controls.Remove(Form_Array(sender.tag))
        Form_Array.Remove(sender.TAG)
    End Sub
    Public Sub Sub_Menu_Size()
        If (Panel_Tab_Menu.Controls.Count / 2) * 185 >= Panel_Tab_Menu.Width And Me.WindowState <> FormWindowState.Minimized Then
            Dim imsi As Integer = (Panel_Tab_Menu.Width * 0.97) / (Panel_Tab_Menu.Controls.Count / 2)
            For Each tt In Panel_Tab_Menu.Controls
                If tt.text = "X" Then
                Else
                    tt.Width = imsi
                End If
            Next
        Else
            For Each tt In Panel_Tab_Menu.Controls
                If tt.text = "X" Then
                Else
                    tt.Width = 165
                End If
            Next

        End If
    End Sub
    Private Sub Com_HideMenu_Click(sender As Object, e As EventArgs) Handles Com_HideMenu.Click
        Panel_Sub_Menu.Width = 1

    End Sub
    Private Sub Com_DualMonitor_Click(sender As Object, e As EventArgs) Handles Com_DualMonitor.Click

        Dim dualMonitor() As Screen = Screen.AllScreens
        If dualMonitor.Length = 2 Then
            If Me.Bounds = dualMonitor(1).Bounds Then
                Me.Bounds = dualMonitor(0).WorkingArea
            Else
                Me.Bounds = dualMonitor(1).WorkingArea
            End If

        End If

    End Sub

    Private Sub Com_Minimize_Click(sender As Object, e As EventArgs) Handles Com_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Com_Maximize_Click(sender As Object, e As EventArgs) Handles Com_Maximize.Click
        Me.Bounds = Screen.FromHandle(Me.Handle).WorkingArea
    End Sub

    Private Function GetForm(ByVal NamespaceName As String, ByVal FormName As String) As Object  ' 변수명으로 해당폼을 반환한다.

        Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly

        Dim mdls As System.Reflection.Module() = asm.GetModules()

        Dim t As Type = mdls(0).GetType(NamespaceName & "." & FormName)

        If Not t Is Nothing Then

            Return Activator.CreateInstance(t)

        End If

        Return Nothing

    End Function


End Class