<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        sidePanelLogin = New Panel()
        LinkLabel1 = New LinkLabel()
        loginBtn = New Button()
        passwordTxtBxLogin = New TextBox()
        usernameTxtBxLogin = New TextBox()
        ic_account = New PictureBox()
        ic_logo = New PictureBox()
        system_title = New Label()
        sidePanelLogin.SuspendLayout()
        CType(ic_account, ComponentModel.ISupportInitialize).BeginInit()
        CType(ic_logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' sidePanelLogin
        ' 
        sidePanelLogin.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        sidePanelLogin.Controls.Add(LinkLabel1)
        sidePanelLogin.Controls.Add(loginBtn)
        sidePanelLogin.Controls.Add(passwordTxtBxLogin)
        sidePanelLogin.Controls.Add(usernameTxtBxLogin)
        sidePanelLogin.Controls.Add(ic_account)
        sidePanelLogin.Dock = DockStyle.Left
        sidePanelLogin.Location = New Point(0, 0)
        sidePanelLogin.Name = "sidePanelLogin"
        sidePanelLogin.Size = New Size(441, 1105)
        sidePanelLogin.TabIndex = 0
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(172, 990)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(84, 24)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "About us"
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        loginBtn.FlatStyle = FlatStyle.Popup
        loginBtn.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = Color.White
        loginBtn.Location = New Point(157, 680)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(125, 49)
        loginBtn.TabIndex = 3
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' passwordTxtBxLogin
        ' 
        passwordTxtBxLogin.Font = New Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordTxtBxLogin.Location = New Point(46, 597)
        passwordTxtBxLogin.Name = "passwordTxtBxLogin"
        passwordTxtBxLogin.PlaceholderText = "Enter your password"
        passwordTxtBxLogin.Size = New Size(339, 31)
        passwordTxtBxLogin.TabIndex = 2
        ' 
        ' usernameTxtBxLogin
        ' 
        usernameTxtBxLogin.Font = New Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTxtBxLogin.Location = New Point(46, 528)
        usernameTxtBxLogin.Name = "usernameTxtBxLogin"
        usernameTxtBxLogin.PlaceholderText = "Enter your username"
        usernameTxtBxLogin.Size = New Size(339, 31)
        usernameTxtBxLogin.TabIndex = 1
        ' 
        ' ic_account
        ' 
        ic_account.Image = My.Resources.Resources.account_2040484
        ic_account.Location = New Point(157, 253)
        ic_account.Name = "ic_account"
        ic_account.Size = New Size(125, 117)
        ic_account.SizeMode = PictureBoxSizeMode.Zoom
        ic_account.TabIndex = 0
        ic_account.TabStop = False
        ' 
        ' ic_logo
        ' 
        ic_logo.Image = My.Resources.Resources.school_bus_12404453
        ic_logo.Location = New Point(919, 253)
        ic_logo.Name = "ic_logo"
        ic_logo.Size = New Size(652, 597)
        ic_logo.SizeMode = PictureBoxSizeMode.Zoom
        ic_logo.TabIndex = 1
        ic_logo.TabStop = False
        ' 
        ' system_title
        ' 
        system_title.AutoSize = True
        system_title.Font = New Font("HarmonyOS Sans SC", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        system_title.Location = New Point(980, 123)
        system_title.Name = "system_title"
        system_title.Size = New Size(535, 53)
        system_title.TabIndex = 2
        system_title.Text = "Land Transportation System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1105)
        Controls.Add(system_title)
        Controls.Add(ic_logo)
        Controls.Add(sidePanelLogin)
        Name = "Form1"
        Text = "Form1"
        sidePanelLogin.ResumeLayout(False)
        sidePanelLogin.PerformLayout()
        CType(ic_account, ComponentModel.ISupportInitialize).EndInit()
        CType(ic_logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents sidePanelLogin As Panel
    Friend WithEvents ic_account As PictureBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents passwordTxtBxLogin As TextBox
    Friend WithEvents usernameTxtBxLogin As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ic_logo As PictureBox
    Friend WithEvents system_title As Label

End Class
