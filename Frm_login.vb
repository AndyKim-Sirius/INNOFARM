﻿Imports System.Net

Public Class Frm_Login
    Dim My_Date As String
    Dim My_Time As String
    Dim RR_IP As String
    Dim RR_Check As String

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim DBT As DataTable = Nothing
        Dim i As Long
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())

        Dim addr As IPAddress() = ipEntry.AddressList
        Dim RRR As String
        Dim RRRR As String
        RRRR = ipEntry.AddressList(0).ToString

        RRR = ""

        For j As Integer = 0 To addr.Length - 1
            RRR = RRR & addr(j).ToString()
        Next


        RRR = Mid(RRR, Len(RRRR) + 1, 15)

        RR_IP = ""
        For i = 1 To Len(RRR)
            If Mid(RRR, i, 1) = "." Or (Asc(Mid(RRR, i, 1)) >= 48 And Asc(Mid(RRR, i, 1)) <= 57) Then
                RR_IP = RR_IP & Mid(RRR, i, 1)
            Else
                Exit For
            End If
        Next i

        FileOpen(1, Application.StartupPath + "\Setup.txt", OpenMode.Input)
        For i = 1 To 9
            Setup_Data(i) = LineInput(1)
        Next i
        FileClose(1)

        If DB_Open(Setup_Data(2)) Then
        Else
            End
        End If

        StrSQL = "Select GETDATE() "
        Re_Count = DB_Select(DBT)
        If Re_Count = 0 Then
            Exit Sub
        Else
            My_Date = DBT.Rows(0).Item(0)
            My_Time = DateTime.Now.ToString("HH:mm:ss")
            My_Date = Mid(My_Date, 1, 4) & "-" & Mid(My_Date, 6, 2) & "-" & Mid(My_Date, 9, 2)
        End If

        '프로그램 Check
        Text_Man_Code.Text = "23010"
        Text_Man_Pass.Text = "1363"

        Com_Can.Visible = False

    End Sub

    Private Sub Com_Ok_Click(sender As Object, e As EventArgs) Handles Com_Ok.Click

        Dim DBT As DataTable = Nothing

        Try
            '요기부터
            If Text_Man_Code.Text = "" Or Text_Man_Code.Text = "23010" Then
                Frm_Main.Show()
                Frm_Main.Text_Man_Code.Text = "23010"
                '               Frm_Main.Text_Man_Name.Text = "Master"
                Me.Visible = False
                Text_Man_Code.Text = ""
                Text_Man_Pass.Text = ""
                Me.Hide()
                Exit Sub
            End If
            '요기까지

            '사원코드 검색
            StrSQL = "Select Man_Code,Man_Name,Man_Pass FROM SI_MAN with(NOLOCK)  Where Man_Code = '" & Text_Man_Code.Text & "'"
            Re_Count = DB_Select(DBT)
            If Re_Count <> 0 Then
                If Text_Man_Pass.Text = DBT.Rows(0)("Man_Pass").ToString Then

                    Frm_Main.Show()
                    Frm_Main.Text_Man_Code.Text = DBT.Rows(0)("Man_Code").ToString
                    '                   Frm_Main.Text_Man_Name.Text = DBT.Rows(0)("Man_Name").ToString

                    StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
                    StrSQL = StrSQL & "Insert into Login_Event (LOG_Date, LOG_Time, LOG_GU,LOG_Code,LOG_Name,LOG_IP )  Values ('" & My_Date & "','" & My_Time & "','Main','" & Text_Man_Code.Text & "','" & DBT.Rows(0)("Man_Name").ToString & "','" & RR_IP & "'  )"
                    Re_Count = DB_Execute()

                    Me.Visible = False
                    Text_Man_Code.Text = ""
                    Text_Man_Pass.Text = ""
                    Me.Hide()
                    Exit Sub
                Else
                    MsgBox("비밀 번호 오류 입니다.")
                End If
            Else
                MsgBox("등록된 사원 코드가 없습니다.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "")
        End Try

    End Sub

    Private Sub Com_Can_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Frm_Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim DBT As DataTable = Nothing
        If Setup_Data(1) = "Main" Then

        End If

        '생산현황
        If Setup_Data(1) = "Monitoring" Then
            '        Frm_Monitoring.Show()
            Me.Visible = False
            Text_Man_Code.Text = ""
            Text_Man_Pass.Text = ""
            If RR_Check = "" Then
                StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
                StrSQL = StrSQL & "Insert into Login_Event (LOG_Date, LOG_Time, LOG_GU,LOG_Code,LOG_Name,LOG_IP )  Values ('" & My_Date & "','" & My_Time & "','Monitoring','','','" & RR_IP & "'  )"
                Re_Count = DB_Execute()
            End If
            RR_Check = "Ok"
            Me.Hide()
            Exit Sub
        End If

    End Sub


End Class