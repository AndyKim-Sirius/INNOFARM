Public Class Frm_Cultivation
    Private Sub Frm_Cultivation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Room_10.Text = " 테스트"
        Room_10.BackColor = Color.FromArgb(255, 255, 72)

    End Sub

    Private Sub Room_1_Click(sender As Object, e As EventArgs) Handles Room_1.Click
        Dim form As New Culti_History
        form.ShowDialog()
    End Sub

End Class
