Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        historyDDPanel.Visible = False
    End Sub


    Private Sub historyBtnAdmin_Click(sender As Object, e As EventArgs) Handles historyBtnAdmin.Click
        historyDDPanel.Visible = Not historyDDPanel.Visible
    End Sub
    Private Sub driverHistoryBtn_Click(sender As Object, e As EventArgs) Handles driverHistoryBtn.Click
        historyDDPanel.Visible = False
    End Sub

    Private Sub medicalHistoryBtn_Click(sender As Object, e As EventArgs) Handles medicalHistoryBtn.Click
        historyDDPanel.Visible = False
    End Sub

    Private Sub vehicleHistoryBtn_Click(sender As Object, e As EventArgs) Handles vehicleHistoryBtn.Click
        historyDDPanel.Visible = False
    End Sub

    Private Sub violationHistoryBtn_Click(sender As Object, e As EventArgs) Handles violationHistoryBtn.Click
        historyDDPanel.Visible = False
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim form1 As New Form1()
        form1.Show()

        Me.Hide()
    End Sub


End Class