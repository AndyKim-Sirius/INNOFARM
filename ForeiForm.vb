﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ForeiForm
    Public Forei_1 As String '코드
    Public Forei_2 As String '한글이름
    Public Forei_3 As String '영어이름
    Public Forei_4 As String '성별
    Public Forei_5 As String '여권이름
    Public Forei_6 As String '입사일자
    Public Forei_7 As String '기숙사 번호
    Public Forei_8 As String '기숙사 비번
    Public Forei_9 As String '국적
    Public Forei_10 As String '동거인
    Public Forei_11 As String '비고
    Public Forei_12 As String '부서
    Public Forei_13 As String '재직여부
    Public Forei_14 As String '퇴사일자

    Private Sub Foreiform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '      IN_Date.Text = Format(Now, "yyyy-MM-dd")

        Forei_1 = Info_Tx0.Text
        Forei_2 = Info_Tx1.Text
        Forei_3 = Info_Tx2.Text
        Forei_4 = ComboBox1.Text
        Forei_5 = Info_Tx3.Text
        Forei_6 = IN_Date.Text
        Forei_7 = Info_Tx4.Text
        Forei_8 = Info_Tx5.Text
        Forei_9 = ComboBox2.Text
        Forei_10 = Info_Tx6.Text
        Forei_11 = Info_Tx7.Text
        Forei_12 = ComboBox3.Text
        Forei_13 = ComboBox4.Text
        Forei_14 = Info_Tx8.Text

    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim DBT As New DataTable
        Forei_1 = Info_Tx0.Text
        Forei_2 = Info_Tx1.Text
        Forei_3 = Info_Tx2.Text
        Forei_4 = ComboBox1.Text
        Forei_5 = Info_Tx3.Text
        Forei_6 = IN_Date.Text
        Forei_7 = Info_Tx4.Text
        Forei_8 = Info_Tx5.Text
        Forei_9 = ComboBox2.Text
        Forei_10 = Info_Tx6.Text
        Forei_11 = Info_Tx7.Text
        Forei_12 = ComboBox3.Text
        Forei_13 = ComboBox4.Text
        Forei_14 = Info_Tx8.Text

        StrSQL = "select * from SI_FOREI where Fori_Code='" & Forei_1 & "'"
        Re_Count = DB_Select(DBT)
        If Re_Count = 0 Then
            StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
            StrSQL = StrSQL & "Insert INTO SI_FOREI  Values ('" & Forei_1 & "',
                                                             N'" & Forei_2 & "',
                                                             '" & Forei_3 & "',
                                                             N'" & Forei_12 & "',
                                                             N'" & Forei_4 & "',
                                                             '" & Forei_5 & "',
                                                             '" & Forei_6 & "',
                                                             '" & Forei_7 & "',
                                                             N'" & Forei_8 & "',
                                                             N'" & Forei_9 & "',
                                                             N'" & Forei_10 & "',
                                                             '" & Forei_11 & "',
                                                             N'" & Forei_13 & "',
                                                             '" & Forei_14 & "')"
            '" & Forei_11 & "')"
            Re_Count = DB_Execute()
            MsgBox("저장 되었습니다")
        Else
            StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
            StrSQL = StrSQL & "update SI_FOREI set Fori_Han=N'" & Forei_2 & "',
                                                   Fori_Eng='" & Forei_3 & "',
                                                   Fori_Buse=N'" & Forei_12 & "',
                                                   Fori_Sex=N'" & Forei_4 & "',
                                                   Fori_Passport='" & Forei_5 & "',
                                                   Fori_in_date='" & Forei_6 & "',
                                                   Fori_Kisuk='" & Forei_7 & "',
                                                   Fori_Kisuk_Pass=N'" & Forei_8 & "',
                                                   Fori_Nation=N'" & Forei_9 & "',
                                                   Fori_Dgin=N'" & Forei_10 & "',
                                                   Fori_Bigo='" & Forei_11 & "',
                                                   Fori_Jaejik=N'" & Forei_13 & "',
                                                   Fori_Out_Date='" & Forei_14 & "'
                                                   where Fori_Code='" & Forei_1 & "'"
            Re_Count = DB_Execute()
            MsgBox("수정 저장 되었습니다")
        End If


        Info_Tx0.Text = ""
        Info_Tx1.Text = ""
        Info_Tx2.Text = ""
        Info_Tx3.Text = ""
        Info_Tx4.Text = ""
        Info_Tx5.Text = ""
        Info_Tx6.Text = ""
        Info_Tx7.Text = ""
        Info_Tx8.Text = ""

        IN_Date.Text = ""

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        Me.Close()
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("남")
        ComboBox1.Items.Add("여")
    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("태국")
        ComboBox2.Items.Add("캄보디아")
        ComboBox2.Items.Add("네팔")

    End Sub
    Private Sub ComboBox3_Click(sender As Object, e As EventArgs) Handles ComboBox3.Click
        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("포장실")
        ComboBox3.Items.Add("입병실")
        ComboBox3.Items.Add("접종실")
        ComboBox3.Items.Add("균긁기")
        ComboBox3.Items.Add("배양실")
        ComboBox3.Items.Add("재배사")

    End Sub

    Private Sub ComboBox4_Click(sender As Object, e As EventArgs) Handles ComboBox4.Click
        ComboBox4.Items.Clear()
        ComboBox4.Items.Add("재직")
        ComboBox4.Items.Add("퇴사")

    End Sub

End Class