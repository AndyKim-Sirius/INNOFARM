Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Frm_Forei
    Dim Grid_Display_Ch As Boolean
    Dim Forei_Grid_Row As Integer
    Dim Forei_Grid_Col As Integer
    Public hellocode As String
    Private Sub Frm_Forei_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.BringToFront()
        Grid_Display_Ch = False

        Grid_Setup()
        Grid_Display()
        Forei_Grid.ClearSelection()
    End Sub

    Public Function Grid_Setup() As Boolean
        Dim i As Integer
        Grid_Color(Forei_Grid)
        Forei_Grid.EnableHeadersVisualStyles = False

        Forei_Grid.AllowUserToAddRows = False
        Forei_Grid.RowTemplate.Height = 30
        Forei_Grid.ColumnCount = 11
        Forei_Grid.RowCount = 1


        '만약 헤더의 스타일을 조정하려면 아래 코드에 헤더를 추가한다.
        Forei_Grid.RowHeadersWidth = 25
        Forei_Grid.Columns(0).Width = 20
        Forei_Grid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        '       For i = 1 To Forei_Grid.ColumnCount - 1
        '            Forei_Grid.Columns(i).Width = 100
        '            Forei_Grid.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        Next i

        Forei_Grid.Columns(1).Width = 20
        Forei_Grid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Forei_Grid.Columns(2).Width = 30
        Forei_Grid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Forei_Grid.Columns(3).Width = 10
        Forei_Grid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Forei_Grid.Columns(4).Width = 50
        Forei_Grid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Forei_Grid.Columns(5).Width = 20
        Forei_Grid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Forei_Grid.Columns(6).Width = 15
        Forei_Grid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Forei_Grid.Columns(7).Width = 30
        Forei_Grid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Forei_Grid.Columns(8).Width = 30
        Forei_Grid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Forei_Grid.Columns(9).Width = 20
        Forei_Grid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Forei_Grid.Columns(10).Width = 250
        Forei_Grid.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Forei_Grid.Columns(0).HeaderText = "코드"
        Forei_Grid.Columns(1).HeaderText = "한글이름"
        Forei_Grid.Columns(2).HeaderText = "영어이름"
        Forei_Grid.Columns(3).HeaderText = "성별"
        Forei_Grid.Columns(4).HeaderText = "여권이름"
        Forei_Grid.Columns(5).HeaderText = "입사일자"
        Forei_Grid.Columns(6).HeaderText = "기숙사번호"
        Forei_Grid.Columns(7).HeaderText = "기숙사 비밀번호"
        Forei_Grid.Columns(8).HeaderText = "국적"
        Forei_Grid.Columns(9).HeaderText = "동거인"
        Forei_Grid.Columns(10).HeaderText = "비  고"

        For i = 0 To Forei_Grid.ColumnCount - 1
            Forei_Grid.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next i

        Forei_Grid.Columns(0).ReadOnly = True
        Grid_Setup = True
    End Function
    Public Function Grid_Display() As Boolean
        Grid_Display_Ch = False

        Dim DBT As New DataTable
        Dim i As Integer
        Dim j As Integer
        Forei_Grid.RowCount = 1
        StrSQL = "Select * FROM SI_Forei with(NOLOCK) Where Fori_Han Like '%" & Search_Text.Text & "%'  Or Fori_Han is Null Order  By Fori_Han"

        Re_Count = DB_Select(DBT)
        If Re_Count <> 0 Then
            Forei_Grid.RowCount = Re_Count
            For i = 0 To Re_Count - 1
                For j = 0 To Forei_Grid.ColumnCount - 1
                    Forei_Grid.Item(j, i).Value = DBT.Rows(i).Item(j)
                Next j
            Next i
        Else
            Forei_Grid.RowCount = 1
            For j = 0 To Forei_Grid.ColumnCount - 1
                Forei_Grid.Item(j, 0).Value = ""
            Next j
        End If
        Grid_Display = True
        Grid_Display_Ch = True

    End Function

    Private Sub Search_Com_Click(sender As Object, e As EventArgs) Handles Search_Com.Click
        Grid_Display()

    End Sub

    Private Sub Save_Com_Click(sender As Object, e As EventArgs) Handles Save_Com.Click


    End Sub

    Private Sub Insert_Com_Click(sender As Object, e As EventArgs) Handles Insert_Com.Click
        '새로운 코드 추가
        Dim DBT As New DataTable
        Dim JP_Code As Long
        Dim check As Integer

        StrSQL = "Select Fori_Code FROM SI_FOREI with(NOLOCK)  Order By Convert(Decimal,Fori_Code) Desc "
        Re_Count = DB_Select(DBT)
        If Re_Count = 0 Then
            JP_Code = JP_Code & "202101"
        Else
            JP_Code = Val(DBT.Rows(0).Item(0)) + 1
        End If
        ForeiForm.Info_Tx0.Text = JP_Code

        ForeiForm.ShowDialog()
        If Foreiform.DialogResult = DialogResult.OK Then
            Search_Com.PerformClick()
        Else
            Search_Com.PerformClick()
        End If

    End Sub

    Private Sub Forei_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Forei_Grid.CellContentClick

    End Sub

    Private Sub Forei_Grid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Forei_Grid.CellValueChanged
        If Grid_Display_Ch = True Then
            sender.CurrentRow.HeaderCell.Value = "*"
        End If

    End Sub

    Private Sub Delete_Com_Click(sender As Object, e As EventArgs) Handles Delete_Com.Click
        Grid_Display_Ch = False

        If Len(Forei_Grid.Item(0, Forei_Grid.CurrentCell.RowIndex).Value) < 1 Then
            Exit Sub
        End If

        If MsgBox("외국인 코드  '" & Forei_Grid.Item(0, Forei_Grid.CurrentCell.RowIndex).Value & "'를 삭제 하시겠습니까?", vbYesNo + vbQuestion + vbDefaultButton1, "외국인 코드 삭제") = vbNo Then
            Exit Sub
        End If


        '삭제한다
        StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        StrSQL = StrSQL & "DELETE SI_FOREI Where Fori_Code = '" & Forei_Grid.Item(0, Forei_Grid.CurrentCell.RowIndex).Value & "'"
        Re_Count = DB_Execute()

        ' Grid_Display()
        ' Grid_Display_Ch = True

    End Sub

    Private Sub Forei_Grid_MouseClick(sender As Object, e As MouseEventArgs) Handles Forei_Grid.MouseClick
        Forei_Grid_Row = Forei_Grid.CurrentCell.RowIndex
        Forei_Grid_Col = Forei_Grid.CurrentCell.ColumnIndex

        If Forei_Grid_Row < 0 Then
            Exit Sub
        End If
        If Forei_Grid_Col < 0 Then
            Exit Sub
        End If
        Dim DBT As New DataTable

    End Sub


    Private Sub Forei_Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Forei_Grid.CellClick
        Forei_Grid_Row = Forei_Grid.CurrentCell.RowIndex
        Forei_Grid_Col = Forei_Grid.CurrentCell.ColumnIndex

        ForeiForm.Info_Tx0.Text = Forei_Grid.Item(0, Forei_Grid_Row).Value
        ForeiForm.Info_Tx1.Text = Forei_Grid.Item(1, Forei_Grid_Row).Value
        ForeiForm.Info_Tx2.Text = Forei_Grid.Item(2, Forei_Grid_Row).Value
        ForeiForm.ComboBox1.Text = Forei_Grid.Item(3, Forei_Grid_Row).Value
        ForeiForm.Info_Tx3.Text = Forei_Grid.Item(4, Forei_Grid_Row).Value
        ForeiForm.IN_Date.Text = Forei_Grid.Item(5, Forei_Grid_Row).Value
        ForeiForm.Info_Tx4.Text = Forei_Grid.Item(6, Forei_Grid_Row).Value
        ForeiForm.Info_Tx5.Text = Forei_Grid.Item(7, Forei_Grid_Row).Value
        ForeiForm.ComboBox2.Text = Forei_Grid.Item(8, Forei_Grid_Row).Value
        ForeiForm.Info_Tx6.Text = Forei_Grid.Item(9, Forei_Grid_Row).Value
        ForeiForm.Info_Tx7.Text = Forei_Grid.Item(10, Forei_Grid_Row).Value

        ForeiForm.ShowDialog()
        If ForeiForm.DialogResult = DialogResult.OK Then
            Search_Com.PerformClick()
        Else
            Search_Com.PerformClick()
        End If
    End Sub
End Class
