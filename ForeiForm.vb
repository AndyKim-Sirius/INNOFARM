Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
    Public Forei_11 As String '비번

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

        StrSQL = "select * from SI_FOREI where Fori_Code='" & Forei_1 & "'"
        Re_Count = DB_Select(DBT)
        If Re_Count = 0 Then
            StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
            StrSQL = StrSQL & "Insert INTO SI_FOREI  Values ('" & Forei_1 & "',
                                                             '" & Forei_2 & "',
                                                             '" & Forei_3 & "',
                                                             '" & Forei_4 & "',
                                                             '" & Forei_5 & "',
                                                             '" & Forei_6 & "',
                                                             '" & Forei_7 & "',
                                                             '" & Forei_8 & "',
                                                             '" & Forei_9 & "',
                                                             '" & Forei_10 & "',
                                                             '" & Forei_11 & "',
                                                             ' Null ',
                                                              'Null')"
            Re_Count = DB_Execute()
        Else
            StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
            StrSQL = StrSQL & "update SI_FOREI set Fori_Han='" & Forei_2 & "',
                                                   Fori_Eng='" & Forei_3 & "',
                                                   Fori_Sex='" & Forei_4 & "',
                                                   Fori_Passport='" & Forei_5 & "',
                                                   Fori_in_date='" & Forei_6 & "',
                                                   Fori_Kisuk='" & Forei_7 & "',
                                                   Fori_Kisuk_Pass='" & Forei_8 & "',
                                                   Fori_Nation='" & Forei_9 & "',
                                                   Fori_Dgin='" & Forei_10 & "',
                                                   Fori_Bigo='" & Forei_11 & "'
                                                   where Fori_Code='" & Forei_1 & "'"
            Re_Count = DB_Execute()
        End If

        MsgBox("저장되었습니다")

        Info_Tx0.Text = ""
        Info_Tx1.Text = ""
        Info_Tx2.Text = ""
        Info_Tx3.Text = ""
        Info_Tx4.Text = ""
        Info_Tx5.Text = ""
        Info_Tx6.Text = ""
        Info_Tx7.Text = ""

        IN_Date.Text = ""

        ComboBox1.Text = ""
        ComboBox2.Text = ""

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()

        Me.Close()
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("남")
        ComboBox1.Items.Add("여")
    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        Dim DBT As New DataTable
        StrSQL = "Select Base_Name  FROM SI_BASE_CODE with(NOLOCK) Where Base_Sel = '국적' Order By Base_Name Desc"
        Re_Count = DB_Select(DBT)
        ComboBox2.Items.Clear()
        If Re_Count <> 0 Then
            For i = 0 To Re_Count - 1
                ComboBox2.Items.Add(DBT.Rows(i).Item(0))
            Next i
        End If
    End Sub

    Private Sub Info_Tx2_TextChanged(sender As Object, e As EventArgs) Handles Info_Tx2.TextChanged

    End Sub
End Class