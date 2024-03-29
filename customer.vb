﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class customer
    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '버튼 수정x
        Info_La0.Enabled = False
        Info_La1.Enabled = False
        Info_La2.Enabled = False
        Info_La3.Enabled = False
        Info_La4.Enabled = False
        Info_La5.Enabled = False
        Info_La6.Enabled = False
        Info_La7.Enabled = False
        Info_La8.Enabled = False
        Info_La9.Enabled = False

        Dim DBT As New DataTable
        Label1.Visible = False
        Dim JP_Code As String
        If Label1.Text = "insert" Then
            '번호자동생성
            StrSQL = "Select CM_CODE FROM SI_CUSTOMER with(NOLOCK)  Order By Convert(Decimal,CM_CODE) Desc "
            Re_Count = DB_Select(DBT)
            If Re_Count = 0 Then
                JP_Code = "0001"
            Else
                JP_Code = Format(DBT.Rows(0).Item(0) + 1, "000#")
            End If

            Info_Tx0.Text = JP_Code

        ElseIf Label1.Text = "update" Then
            Info_Tx0.Enabled = False
            'DB 데이터 불러오기
            StrSQL = "Select * FROM SI_Customer with(NOLOCK) Where CM_CODE = '" & Info_Tx0.Text & "' Order By CM_CODE"
            Re_Count = DB_Select(DBT)

            If Re_Count = 0 Then
                Me.Close()
                Exit Sub
            Else
                Info_Tx1.Text = DBT.Rows(0)("CM_Name")                    ' 거래처 명
                Info_Tx2.Text = DBT.Rows(0)("CM_Op_Number")               ' 사업자 번호
                Info_Tx3.Text = DBT.Rows(0)("CM_JIGUBUN")                 ' 지역 구분
                Info_Tx4.Text = DBT.Rows(0)("CM_Sel")                     ' 매입 / 매출 구분
                Info_Tx5.Text = DBT.Rows(0)("CM_Leader")                  ' 대표자 이름
                Info_Tx6.Text = DBT.Rows(0)("CM_Add")                     ' 주소
                Info_Tx7.Text = DBT.Rows(0)("CM_Man_Name")                ' 담당자 이름
                Info_Tx8.Text = DBT.Rows(0)("CM_Man_Email")               ' 담당자 이메일
                Info_Tx9.Text = DBT.Rows(0)("CM_Bigo")                    ' 비고
            End If
        End If

    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        '유효성 검사
        If Info_Tx0.Text = "" Then
            MsgBox("거래처 코드는 공백일 수 없습니다")
            Exit Sub
        End If

        If Label1.Text = "insert" Then
            '기존 거래처코드가 존재하는지 확인 후 INSERT문 실행
            Dim DBT As New DataTable

            StrSQL = "Select CM_CODE FROM SI_CUSTOMER with(NOLOCK) Where CM_CODE = '" & Info_Tx0.Text & "' Order By CM_CODE"
            Re_Count = DB_Select(DBT)

            If Re_Count = 1 Then
                MsgBox("현재 같은 거래처코드가 존재합니다")
                Exit Sub
            Else
            End If

            Try
                StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
                StrSQL = StrSQL & "Insert INTO SI_customer Values ('" & Info_Tx0.Text & "',
                                                                   '" & Info_Tx1.Text & "', 
                                                                   '" & Info_Tx2.Text & "', 
                                                                   '" & Info_Tx3.Text & "', 
                                                                   '" & Info_Tx4.Text & "',
                                                                   '" & Info_Tx5.Text & "', 
                                                                   '" & Info_Tx6.Text & "',
                                                                   '" & Info_Tx7.Text & "', 
                                                                   '" & Info_Tx8.Text & "', 
                                                                   '" & Info_Tx9.Text & "')"
                Re_Count = DB_Execute()
                MsgBox("저장되었습니다")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.Close()

        ElseIf Label1.Text = "update" Then

            'UPDATE문 실행
            Try
                StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
                StrSQL = StrSQL & "UPDATE SI_CUSTOMER
                                      SET CM_NAME =      '" & Info_Tx1.Text & "',
                                          CM_Op_Number = '" & Info_Tx2.Text & "',
                                          CM_JIGUBUN =   '" & Info_Tx3.Text & "',
                                          CM_SEL =       '" & Info_Tx4.Text & "',
                                          CM_Leader =    '" & Info_Tx5.Text & "',
                                          CM_Add =       '" & Info_Tx6.Text & "',
                                          CM_Man_Name =  '" & Info_Tx7.Text & "',
                                          CM_Man_Email = '" & Info_Tx8.Text & "',
                                          CM_Bigo =      '" & Info_Tx9.Text & "'
                                    WHERE CM_CODE ='" & Info_Tx0.Text & "'"
                Re_Count = DB_Execute()
                MsgBox("수정되었습니다")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.Close()

        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class