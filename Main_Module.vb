﻿Imports System.Data.SqlClient
Imports System.Text
Imports System.Drawing.Text

Imports Excel = Microsoft.Office.Interop.Excel


Module Main_Module
    Public Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Public Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    ' Public Declare Auto Function AddFontResource Lib "gdi32" Alias "digf" (ByVal lpFileName As String) As Integer
    Public Const WM_SYSCOMMAND As Integer = 274
    Public Const SC_MAXIMIZE As Integer = 61488


    Public Co(3) As Integer

    Public DBcon As New SqlConnection
    Public StrSQL As String
    Public Re_Count As Long
    Public Re_Count2 As Long

    Public Re_Str As Boolean
    Public Setup_Data(0 To 17) As String
    Public Menu_String(20, 20) As String              ' 메뉴 이름 Define


    Public Function DB_Open(DB_Srt As String) As Boolean
        DBcon.ConnectionString = DB_Srt
        Try
            DBcon.Open()
            DB_Open = True
        Catch ex As Exception
            MsgBox(ex.Message)
            DB_Open = False
        End Try
    End Function
    Public Function DB_Select(ByRef DBT As DataTable) As Long
        Dim DBtable As New DataTable
        Dim DBAdapter As New SqlDataAdapter(StrSQL, DBcon)
        DBAdapter.Fill(DBtable)
        DBT = DBtable
        DB_Select = DBtable.Rows.Count

    End Function
    Public Function OBJ_Back_Color(Obj As Object) As Boolean
        Col_Str(Setup_Data(3))
        Obj.BackColor = Color.FromArgb(Co(1), Co(2), Co(3))
        OBJ_Back_Color = True
    End Function
    Public Function Col_Str(Color_Data As String) As Boolean
        Co(1) = Val("&H" & Mid(Color_Data, 1, 2))
        Co(2) = Val("&H" & Mid(Color_Data, 3, 2))
        Co(3) = Val("&H" & Mid(Color_Data, 5, 2))
        Col_Str = True
    End Function
    Public Function OBJ_MouseOver_Color(Obj As Object) As Boolean
        Col_Str(Setup_Data(3))
        Obj.FlatAppearance.MouseOverBackColor = Color.FromArgb(Co(1), Co(2), Co(3))
        OBJ_MouseOver_Color = True
    End Function
    Public Function DB_Execute() As Long
        Dim DBcmd As New SqlCommand(StrSQL, DBcon)
        DB_Execute = 0


        DB_Execute = DBcmd.ExecuteNonQuery()

    End Function
    Public Function Label_Color(Com_Box As Object, Color_Label As Object, Di_Panel2 As Object) As Boolean


        Col_Str(Setup_Data(3))
        Color_Label.BackColor = Color.FromArgb(Co(1), Co(2), Co(3))

        'Color_Label.BackColor = Color.DarkOrange


        Color_Label.Width = Com_Box.width
        Color_Label.Left = Com_Box.left - Di_Panel2.Left
        Color_Label.Top = 0
        Label_Color = True



    End Function
    Public Function HexStr2Array(ByVal msg As String) As Byte()
        msg = msg.Replace(" ", "")

        Dim combuffer As Byte() = New Byte(msg.Length \ 2 - 1) {}
        For i As Integer = 0 To msg.Length - 1 Step 2
            combuffer(i \ 2) = CByte(Convert.ToByte(msg.Substring(i, 2), 16))
        Next

        Return combuffer
    End Function
    Public Function Array2HexStr(ByVal comByte As Byte()) As String
        Dim builder As New StringBuilder(comByte.Length * 3)
        For Each data As Byte In comByte
            builder.Append((Convert.ToString(data, 16).PadLeft(2, "0")))
        Next
        Return builder.ToString().ToUpper()
    End Function
    Public Function Grid_Color(Obj As DataGridView) As Boolean

        Obj.EnableHeadersVisualStyles = False
        Obj.AllowUserToAddRows = False
        Obj.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Col_Str(Setup_Data(4))
        Obj.GridColor = Color.FromArgb(Co(1), Co(2), Co(3))
        Obj.BackgroundColor = Color.FromArgb(Co(1), Co(2), Co(3))

        Col_Str(Setup_Data(5))
        Obj.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(Co(1), Co(2), Co(3))
        Col_Str(Setup_Data(6))
        Obj.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(Co(1), Co(2), Co(3))

        Col_Str(Setup_Data(7))
        Obj.RowsDefaultCellStyle.BackColor = Color.FromArgb(Co(1), Co(2), Co(3))
        Col_Str(Setup_Data(8))
        Obj.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(Co(1), Co(2), Co(3))
        Grid_Color = True
    End Function
    Public Function PIc_Pic(Pic As Object, File_Name As String) As Boolean
        Pic.Refresh()
        Pic.Image = Image.FromFile(File_Name)
        PIc_Pic = True
    End Function

    Public Function releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
        releaseObject = True
    End Function

    Public Function Grid_Info_Display(Grid As DataGridView, SQL_String As String) As Boolean
        Dim DBT As New DataTable
        Dim i As Integer
        StrSQL = SQL_String
        Re_Count = DB_Select(DBT)
        If Re_Count > 0 Then
            For i = 0 To DBT.Columns.Count - 1
                Grid.Item(1, i).Value = DBT.Rows(0).Item(i).ToString
            Next i
        Else
            For i = 0 To DBT.Columns.Count - 1
                Grid.Item(1, i).Value = ""
            Next i
        End If


        Grid_Info_Display = True




    End Function
    Public Function Grid_Info_Display2(Grid As DataGridView, SQL_String As String, Info_Text() As TextBox, Info_Combo() As ComboBox) As Boolean
        Dim DBT As New DataTable
        Dim i As Integer
        StrSQL = SQL_String
        Re_Count = DB_Select(DBT)
        If Re_Count > 0 Then
            For i = 0 To DBT.Columns.Count - 1
                Grid.Item(1, i).Value = DBT.Rows(0).Item(i).ToString
            Next i
        Else
            For i = 0 To DBT.Columns.Count - 1
                Grid.Item(1, i).Value = ""
            Next i
        End If

        For i = 0 To Grid.Rows.Count - 1
            Info_Text(i).Text = Grid.Item(1, i).Value
            Info_Combo(i).Text = Grid.Item(1, i).Value
        Next i

        Grid_Info_Display2 = True

    End Function

    Public Function Grid_Info_Save(Grid As DataGridView, Table_Name As String) As Boolean
        Dim j As Long
        Dim DBT As DataTable = Nothing
        Dim Field_Name(500) As String
        Dim i As Integer
        j = 0
        For i = 1 To Grid.RowCount - 1
            If Grid.Rows(i).HeaderCell.Value = "*" Then
                j = 1
            End If
        Next i
        If j = 0 Then
            Grid_Info_Save = False
            Exit Function
        End If
        j = 0
        StrSQL = "Select sys.Columns.Name From sys.Tables with(NOLOCK) , sys.Columns with(NOLOCK) Where sys.Tables.name = '" & Table_Name & "' And sys.Tables.Object_id = sys.Columns.Object_id Order By sys.Columns.column_id"
        Re_Count = DB_Select(DBT)
        If Re_Count <> 0 Then
            For i = 0 To DBT.Rows.Count - 1
                Field_Name(j) = DBT.Rows(i)("Name").ToString
                j = j + 1
            Next i
        End If
        j = j - 1
        StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        StrSQL = StrSQL & "UPDATE " & Table_Name & " SET "
        Field_Name(500) = "Ok"
        For i = 1 To j
            If Grid.Rows(i).HeaderCell.Value = "*" Then
                If Field_Name(500) = "" Then
                    StrSQL = StrSQL & ","
                End If
                StrSQL = StrSQL & " " & Table_Name & "." & Field_Name(i) & " = '" & Replace(Grid.Item(1, i).Value, "'", "''") & "'"
                If Field_Name(500) = "Ok" Then
                    Field_Name(500) = ""
                End If
            End If
        Next i
        StrSQL = StrSQL & " WHERE " & Table_Name & "." & Field_Name(0) & " = '" & Grid.Item(1, 0).Value & "'"
        Re_Count = DB_Execute()
        Grid_Info_Save = True

    End Function
    Public Function Data_Col_Count(Data_Str As String, ByVal Data_Dim() As String) As Long
        Dim i As Long
        Dim j As Long
        Dim UU As String
        Data_Col_Count = 0
        j = 0
        UU = ""
        For i = 1 To Len(Data_Str)
            If Mid(Data_Str, i, 1) = "|" Then
                Data_Col_Count = Data_Col_Count + 1
                j = j + 1
                Data_Dim(j) = UU
                UU = ""
            Else
                UU = UU & Mid(Data_Str, i, 1)
            End If
        Next i

        If Data_Col_Count = 0 Then
        Else
            Data_Col_Count = Data_Col_Count + 1
            Data_Dim(Data_Col_Count) = UU
        End If
        Data_Col_Count = Data_Col_Count
    End Function
    Public Function Data_Col_Count_Str(Data_Str As String, ByVal Data_Dim() As String) As Long
        Dim i As Long
        Dim j As Long
        Dim UU As String
        Data_Col_Count_Str = 0
        j = 0
        UU = ""
        For i = 1 To Len(Data_Str)
            If Mid(Data_Str, i, 1) = "," Then
                Data_Col_Count_Str = Data_Col_Count_Str + 1
                j = j + 1
                Data_Dim(j) = UU
                UU = ""
            Else
                UU = UU & Mid(Data_Str, i, 1)
            End If
        Next i

        If Data_Col_Count_Str = 0 Then
        Else
            Data_Col_Count_Str = Data_Col_Count_Str + 1
            Data_Dim(Data_Col_Count_Str) = UU
        End If
        Data_Col_Count_Str = Data_Col_Count_Str
    End Function
    Public Function Count_Pro(Pro_Code As String, Go_Code As String, Go_C As String, To_C As String, Er_C As String) As Boolean
        Dim PP_G_Sun As String
        Dim PP_G_Amount As String
        Dim DBT As DataTable = Nothing
        Dim DBT2 As DataTable = Nothing


        PP_G_Sun = "0"
        PP_G_Amount = "0"
        StrSQL = "Select PP_Sun, PP_Amount FROM SI_Balju_List with(NOLOCK) Where PP_Code = '" & Pro_Code & "' And PP_PC_Code = '" & Go_Code & "' "
        Re_Count = DB_Select(DBT)
        If Re_Count > 0 Then
            PP_G_Sun = DBT.Rows(0)("PP_Sun")
            PP_G_Amount = DBT.Rows(0)("PP_Amount")
        End If
        If PP_G_Sun = "0" Then
        Else
            '변경
            StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
            StrSQL = StrSQL & "UPDATE SI_Balju_List Set PP_Amount = '" & Val(PP_G_Amount) + Val(To_C) & "' Where PP_Code = '" & Pro_Code & "' And PP_Sun = '" & PP_G_Sun & "'"
            Re_Count = DB_Execute()
            If PP_G_Sun = "1" Then
                '조합리스트의 마지막을 가지고 온다.
                StrSQL = "Select  PL_Sub_Code, PL_Qty FROM SI_PRODUCT_RECIPE With(NOLOCK) Where PL_Code = '" & Pro_Code & "'"
                Re_Count = DB_Select(DBT)
                If Re_Count > 0 Then
                    For i = 0 To Re_Count - 1
                        StrSQL = "Select  PP_Sun FROM SI_Balju_List with(NOLOCK) Where PP_Code = '" & DBT.Rows(i)("PL_Sub_Code") & "' Order By Convert(Decimal,PP_Sun) Desc"
                        Re_Count2 = DB_Select(DBT2)
                        If Re_Count2 > 0 Then
                            StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
                            StrSQL = StrSQL & "UPDATE SI_Balju_List Set PP_Amount =  Convert(Decimal,PP_Amount)  - " & Val(Go_C) * Val(DBT.Rows(i)("PL_Qty")) & "  Where PP_Code = '" & DBT.Rows(i)("PL_Sub_Code") & "' And PP_Sun = '" & DBT2.Rows(0)("PP_Sun") & "'"
                            Re_Count = DB_Execute()
                        End If
                    Next i
                End If
            Else
                StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
                StrSQL = StrSQL & "UPDATE SI_Balju_List Set PP_Amount = Convert(Decimal,PP_Amount)  - " & Val(Go_C) & " Where PP_Code = '" & Pro_Code & "' And PP_Sun = '" & Val(PP_G_Sun) - 1 & "'"
                Re_Count = DB_Execute()
            End If
        End If

        Count_Pro = True

    End Function
    Public Function Count_Pro_M(Pro_Code As String, Go_Code As String, Go_C As String, To_C As String, Er_C As String) As Boolean
        Dim PP_G_Sun As String
        Dim PP_G_Amount As String
        Dim DBT As DataTable = Nothing
        Dim DBT2 As DataTable = Nothing


        PP_G_Sun = "0"
        PP_G_Amount = "0"
        StrSQL = "Select PP_Sun, PP_Amount FROM SI_Balju_List with(NOLOCK) Where PP_Code = '" & Pro_Code & "' And PP_PC_Code = '" & Go_Code & "' "
        Re_Count = DB_Select(DBT)
        If Re_Count > 0 Then
            PP_G_Sun = DBT.Rows(0)("PP_Sun")
            PP_G_Amount = DBT.Rows(0)("PP_Amount")
        End If
        If PP_G_Sun = "0" Then
        Else
            '변경
            StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
            StrSQL = StrSQL & "UPDATE SI_Balju_List Set PP_Amount = '" & Val(PP_G_Amount) - Val(To_C) & "' Where PP_Code = '" & Pro_Code & "' And PP_Sun = '" & PP_G_Sun & "'"
            Re_Count = DB_Execute()
            If PP_G_Sun = "1" Then
                '조합리스트의 마지막을 가지고 온다.
                StrSQL = "Select  PL_Sub_Code, PL_Qty FROM SI_PRODUCT_RECIPE With(NOLOCK) Where PL_Code = '" & Pro_Code & "'"
                Re_Count = DB_Select(DBT)
                If Re_Count > 0 Then
                    For i = 0 To Re_Count - 1
                        StrSQL = "Select  PP_Sun FROM SI_Balju_List with(NOLOCK) Where PP_Code = '" & DBT.Rows(i)("PL_Sub_Code") & "' Order By Convert(Decimal,PP_Sun) Desc"
                        Re_Count2 = DB_Select(DBT2)
                        If Re_Count2 > 0 Then
                            StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
                            StrSQL = StrSQL & "UPDATE SI_Balju_List Set PP_Amount =  Convert(Decimal,PP_Amount)  + " & Val(Go_C) * Val(DBT.Rows(i)("PL_Qty")) & "  Where PP_Code = '" & DBT.Rows(i)("PL_Sub_Code") & "' And PP_Sun = '" & DBT2.Rows(0)("PP_Sun") & "'"
                            Re_Count = DB_Execute()
                        End If
                    Next i
                End If
            Else
                StrSQL = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
                StrSQL = StrSQL & "UPDATE SI_Balju_List Set PP_Amount = Convert(Decimal,PP_Amount)  + " & Val(Go_C) & " Where PP_Code = '" & Pro_Code & "' And PP_Sun = '" & Val(PP_G_Sun) - 1 & "'"
                Re_Count = DB_Execute()
            End If
        End If

        Count_Pro_M = True

    End Function

End Module
