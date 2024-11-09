<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        historyBtnAdmin = New Button()
        fillupBtnAdmin = New Button()
        Label1 = New Label()
        dashboardBtnAdmin = New Button()
        loginBtn = New Button()
        PictureBox1 = New PictureBox()
        historyDDPanel = New Panel()
        violationHistoryBtn = New Button()
        vehicleHistoryBtn = New Button()
        medicalHistoryBtn = New Button()
        driverHistoryBtn = New Button()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        historyDDPanel.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(historyBtnAdmin)
        Panel1.Controls.Add(fillupBtnAdmin)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(dashboardBtnAdmin)
        Panel1.Controls.Add(loginBtn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(historyDDPanel)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(308, 1105)
        Panel1.TabIndex = 0
        ' 
        ' historyBtnAdmin
        ' 
        historyBtnAdmin.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        historyBtnAdmin.FlatStyle = FlatStyle.Popup
        historyBtnAdmin.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        historyBtnAdmin.ForeColor = Color.White
        historyBtnAdmin.Location = New Point(58, 543)
        historyBtnAdmin.Name = "historyBtnAdmin"
        historyBtnAdmin.Size = New Size(183, 49)
        historyBtnAdmin.TabIndex = 8
        historyBtnAdmin.Text = "History"
        historyBtnAdmin.UseVisualStyleBackColor = False
        ' 
        ' fillupBtnAdmin
        ' 
        fillupBtnAdmin.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        fillupBtnAdmin.FlatStyle = FlatStyle.Popup
        fillupBtnAdmin.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fillupBtnAdmin.ForeColor = Color.White
        fillupBtnAdmin.Location = New Point(58, 457)
        fillupBtnAdmin.Name = "fillupBtnAdmin"
        fillupBtnAdmin.Size = New Size(183, 49)
        fillupBtnAdmin.TabIndex = 7
        fillupBtnAdmin.Text = "Fill up form"
        fillupBtnAdmin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("HarmonyOS Sans SC Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(58, 230)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 26)
        Label1.TabIndex = 6
        Label1.Text = "Role placeholder"
        ' 
        ' dashboardBtnAdmin
        ' 
        dashboardBtnAdmin.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        dashboardBtnAdmin.FlatStyle = FlatStyle.Popup
        dashboardBtnAdmin.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dashboardBtnAdmin.ForeColor = Color.White
        dashboardBtnAdmin.Location = New Point(58, 380)
        dashboardBtnAdmin.Name = "dashboardBtnAdmin"
        dashboardBtnAdmin.Size = New Size(183, 49)
        dashboardBtnAdmin.TabIndex = 5
        dashboardBtnAdmin.Text = "Dashboard"
        dashboardBtnAdmin.UseVisualStyleBackColor = False
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        loginBtn.FlatStyle = FlatStyle.Popup
        loginBtn.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = Color.White
        loginBtn.Location = New Point(27, 1016)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(249, 49)
        loginBtn.TabIndex = 4
        loginBtn.Text = "Logout"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.account_2040484
        PictureBox1.Location = New Point(84, 103)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' historyDDPanel
        ' 
        historyDDPanel.BackColor = Color.White
        historyDDPanel.BorderStyle = BorderStyle.FixedSingle
        historyDDPanel.Controls.Add(violationHistoryBtn)
        historyDDPanel.Controls.Add(vehicleHistoryBtn)
        historyDDPanel.Controls.Add(medicalHistoryBtn)
        historyDDPanel.Controls.Add(driverHistoryBtn)
        historyDDPanel.Location = New Point(58, 598)
        historyDDPanel.Name = "historyDDPanel"
        historyDDPanel.Size = New Size(183, 224)
        historyDDPanel.TabIndex = 9
        ' 
        ' violationHistoryBtn
        ' 
        violationHistoryBtn.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        violationHistoryBtn.FlatStyle = FlatStyle.Popup
        violationHistoryBtn.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        violationHistoryBtn.ForeColor = Color.White
        violationHistoryBtn.Location = New Point(-1, 168)
        violationHistoryBtn.Name = "violationHistoryBtn"
        violationHistoryBtn.Size = New Size(183, 49)
        violationHistoryBtn.TabIndex = 9
        violationHistoryBtn.Text = "Violation History"
        violationHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' vehicleHistoryBtn
        ' 
        vehicleHistoryBtn.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        vehicleHistoryBtn.FlatStyle = FlatStyle.Popup
        vehicleHistoryBtn.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        vehicleHistoryBtn.ForeColor = Color.White
        vehicleHistoryBtn.Location = New Point(-1, 113)
        vehicleHistoryBtn.Name = "vehicleHistoryBtn"
        vehicleHistoryBtn.Size = New Size(183, 49)
        vehicleHistoryBtn.TabIndex = 8
        vehicleHistoryBtn.Text = "Vehicle History"
        vehicleHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' medicalHistoryBtn
        ' 
        medicalHistoryBtn.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        medicalHistoryBtn.FlatStyle = FlatStyle.Popup
        medicalHistoryBtn.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        medicalHistoryBtn.ForeColor = Color.White
        medicalHistoryBtn.Location = New Point(-1, 58)
        medicalHistoryBtn.Name = "medicalHistoryBtn"
        medicalHistoryBtn.Size = New Size(183, 49)
        medicalHistoryBtn.TabIndex = 7
        medicalHistoryBtn.Text = "Medical History"
        medicalHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' driverHistoryBtn
        ' 
        driverHistoryBtn.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        driverHistoryBtn.FlatStyle = FlatStyle.Popup
        driverHistoryBtn.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        driverHistoryBtn.ForeColor = Color.White
        driverHistoryBtn.Location = New Point(-1, 3)
        driverHistoryBtn.Name = "driverHistoryBtn"
        driverHistoryBtn.Size = New Size(183, 49)
        driverHistoryBtn.TabIndex = 6
        driverHistoryBtn.Text = "Driver History"
        driverHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(345, 104)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1527, 962)
        DataGridView1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(743, 71)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 27)
        Button1.TabIndex = 2
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(345, 71)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(392, 27)
        TextBox1.TabIndex = 3
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1105)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "AdminDashboard"
        Text = "AdminDashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        historyDDPanel.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dashboardBtnAdmin As Button
    Friend WithEvents loginBtn As Button
    Friend WithEvents historyBtnAdmin As Button
    Friend WithEvents fillupBtnAdmin As Button
    Friend WithEvents historyDDPanel As Panel
    Friend WithEvents violationHistoryBtn As Button
    Friend WithEvents vehicleHistoryBtn As Button
    Friend WithEvents medicalHistoryBtn As Button
    Friend WithEvents driverHistoryBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
