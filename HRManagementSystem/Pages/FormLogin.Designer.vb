<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form
    'Inherits MaterialSkin.Controls.MaterialForm

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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormLogin))
        TableLayoutPanel1 = New TableLayoutPanel()
        btnClose = New Button()
        btnMin = New Button()
        MaterialCard1 = New ReaLTaiizor.Controls.MaterialCard()
        TableLayoutPanel3 = New TableLayoutPanel()
        PictureBox2 = New PictureBox()
        lblUser = New Label()
        ErrorNotif = New ReaLTaiizor.Controls.FoxNotification()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblConnection = New Label()
        pbConnection = New PictureBox()
        lblVersion = New Label()
        txtUsername = New ReaLTaiizor.Controls.SmallTextBox()
        lblPassword = New Label()
        txtPassword = New ReaLTaiizor.Controls.SmallTextBox()
        btn_Login = New MaterialSkin.Controls.MaterialButton()
        tblPanelServer = New TableLayoutPanel()
        rbLiveServer = New RadioButton()
        rbTestServer = New RadioButton()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Timer1 = New Timer(components)
        TableLayoutPanel1.SuspendLayout()
        MaterialCard1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(pbConnection, ComponentModel.ISupportInitialize).BeginInit()
        tblPanelServer.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 47.50481F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 350F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 52.49519F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(btnClose, 4, 0)
        TableLayoutPanel1.Controls.Add(btnMin, 3, 0)
        TableLayoutPanel1.Controls.Add(MaterialCard1, 2, 1)
        TableLayoutPanel1.Controls.Add(tblPanelServer, 2, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.Size = New Size(700, 500)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.FlatAppearance.BorderColor = Color.White
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.Image = My.Resources.Resources.icons8_close_window_802
        btnClose.Location = New Point(682, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(15, 15)
        btnClose.TabIndex = 2
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnMin
        ' 
        btnMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMin.FlatAppearance.BorderColor = Color.White
        btnMin.FlatAppearance.BorderSize = 0
        btnMin.FlatStyle = FlatStyle.Popup
        btnMin.Image = My.Resources.Resources.icons8_minimize_801
        btnMin.Location = New Point(661, 3)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(15, 15)
        btnMin.TabIndex = 2
        btnMin.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(TableLayoutPanel3)
        MaterialCard1.Depth = 0
        MaterialCard1.Dock = DockStyle.Fill
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(172, 45)
        MaterialCard1.Margin = New Padding(5)
        MaterialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(340, 410)
        MaterialCard1.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 300F))
        TableLayoutPanel3.Controls.Add(PictureBox2, 0, 0)
        TableLayoutPanel3.Controls.Add(lblUser, 0, 1)
        TableLayoutPanel3.Controls.Add(ErrorNotif, 0, 6)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel2, 0, 7)
        TableLayoutPanel3.Controls.Add(txtUsername, 0, 2)
        TableLayoutPanel3.Controls.Add(lblPassword, 0, 3)
        TableLayoutPanel3.Controls.Add(txtPassword, 0, 4)
        TableLayoutPanel3.Controls.Add(btn_Login, 0, 5)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(14, 14)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 8
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel3.Size = New Size(312, 382)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.Best_Resource_Logo
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(312, 122)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' lblUser
        ' 
        lblUser.Anchor = AnchorStyles.Left
        lblUser.AutoSize = True
        lblUser.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblUser.ForeColor = SystemColors.ControlDarkDark
        lblUser.Location = New Point(14, 125)
        lblUser.Margin = New Padding(14, 0, 3, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(62, 14)
        lblUser.TabIndex = 6
        lblUser.Text = "Username"
        ' 
        ' ErrorNotif
        ' 
        ErrorNotif.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ErrorNotif.BlueBackColor = Color.FromArgb(CByte(217), CByte(237), CByte(248))
        ErrorNotif.BlueBarColor = Color.FromArgb(CByte(175), CByte(217), CByte(240))
        ErrorNotif.BlueTextColor = Color.FromArgb(CByte(73), CByte(143), CByte(184))
        ErrorNotif.EnabledCalc = True
        ErrorNotif.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ErrorNotif.GreenBackColor = Color.FromArgb(CByte(224), CByte(201), CByte(201))
        ErrorNotif.GreenBarColor = Color.FromArgb(CByte(212), CByte(166), CByte(166))
        ErrorNotif.GreenTextColor = Color.FromArgb(CByte(170), CByte(47), CByte(47))
        ErrorNotif.Location = New Point(14, 302)
        ErrorNotif.Margin = New Padding(14, 3, 14, 3)
        ErrorNotif.Name = "ErrorNotif"
        ErrorNotif.RedBackColor = Color.FromArgb(CByte(242), CByte(222), CByte(222))
        ErrorNotif.RedBarColor = Color.FromArgb(CByte(235), CByte(204), CByte(209))
        ErrorNotif.RedTextColor = Color.FromArgb(CByte(194), CByte(99), CByte(94))
        ErrorNotif.Size = New Size(284, 40)
        ErrorNotif.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red
        ErrorNotif.TabIndex = 3
        ErrorNotif.Text = "Invalid username and password."
        ErrorNotif.Visible = False
        ErrorNotif.YellowBackColor = Color.FromArgb(CByte(252), CByte(248), CByte(225))
        ErrorNotif.YellowBarColor = Color.FromArgb(CByte(250), CByte(235), CByte(200))
        ErrorNotif.YellowTextColor = Color.FromArgb(CByte(144), CByte(131), CByte(88))
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 37F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(lblConnection, 1, 0)
        TableLayoutPanel2.Controls.Add(pbConnection, 0, 0)
        TableLayoutPanel2.Controls.Add(lblVersion, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 355)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(306, 24)
        TableLayoutPanel2.TabIndex = 7
        ' 
        ' lblConnection
        ' 
        lblConnection.AutoSize = True
        lblConnection.Font = New Font("Roboto", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblConnection.ForeColor = SystemColors.ControlDarkDark
        lblConnection.Location = New Point(37, 5)
        lblConnection.Margin = New Padding(0, 5, 3, 3)
        lblConnection.Name = "lblConnection"
        lblConnection.Size = New Size(75, 13)
        lblConnection.TabIndex = 6
        lblConnection.Text = "Disconnected"
        ' 
        ' pbConnection
        ' 
        pbConnection.Image = My.Resources.Resources.icons8_wi_fi_disconnected_32
        pbConnection.Location = New Point(14, 3)
        pbConnection.Margin = New Padding(14, 3, 3, 3)
        pbConnection.Name = "pbConnection"
        pbConnection.Size = New Size(20, 14)
        pbConnection.SizeMode = PictureBoxSizeMode.Zoom
        pbConnection.TabIndex = 7
        pbConnection.TabStop = False
        ' 
        ' lblVersion
        ' 
        lblVersion.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Roboto", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblVersion.ForeColor = SystemColors.ControlDarkDark
        lblVersion.Location = New Point(244, 3)
        lblVersion.Margin = New Padding(14, 3, 14, 3)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(48, 13)
        lblVersion.TabIndex = 6
        lblVersion.Text = "Version:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.BackColor = Color.Transparent
        txtUsername.BorderColor = SystemColors.ActiveBorder
        txtUsername.CustomBGColor = Color.White
        txtUsername.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.ForeColor = Color.DimGray
        txtUsername.Location = New Point(14, 147)
        txtUsername.Margin = New Padding(14, 3, 14, 3)
        txtUsername.MaxLength = 32767
        txtUsername.Multiline = False
        txtUsername.Name = "txtUsername"
        txtUsername.Padding = New Padding(14)
        txtUsername.ReadOnly = False
        txtUsername.Size = New Size(284, 30)
        txtUsername.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        txtUsername.TabIndex = 1
        txtUsername.TextAlignment = HorizontalAlignment.Left
        txtUsername.UseSystemPasswordChar = False
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.Left
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.ForeColor = SystemColors.ControlDarkDark
        lblPassword.Location = New Point(14, 185)
        lblPassword.Margin = New Padding(14, 0, 3, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(61, 14)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.BackColor = Color.Transparent
        txtPassword.BorderColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        txtPassword.CustomBGColor = Color.White
        txtPassword.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.ForeColor = Color.DimGray
        txtPassword.Location = New Point(14, 207)
        txtPassword.Margin = New Padding(14, 3, 14, 3)
        txtPassword.MaxLength = 32767
        txtPassword.Multiline = False
        txtPassword.Name = "txtPassword"
        txtPassword.Padding = New Padding(14)
        txtPassword.ReadOnly = False
        txtPassword.Size = New Size(284, 30)
        txtPassword.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        txtPassword.TabIndex = 2
        txtPassword.TextAlignment = HorizontalAlignment.Left
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btn_Login
        ' 
        btn_Login.AutoSize = False
        btn_Login.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btn_Login.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal
        btn_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btn_Login.Depth = 0
        btn_Login.HighEmphasis = True
        btn_Login.Icon = Nothing
        btn_Login.Location = New Point(14, 254)
        btn_Login.Margin = New Padding(14, 12, 14, 6)
        btn_Login.MouseState = MaterialSkin.MouseState.HOVER
        btn_Login.Name = "btn_Login"
        btn_Login.NoAccentTextColor = Color.Empty
        btn_Login.Size = New Size(284, 32)
        btn_Login.TabIndex = 3
        btn_Login.Text = "Log in"
        btn_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btn_Login.UseAccentColor = False
        btn_Login.UseVisualStyleBackColor = True
        ' 
        ' tblPanelServer
        ' 
        tblPanelServer.ColumnCount = 2
        tblPanelServer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblPanelServer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblPanelServer.Controls.Add(rbLiveServer, 0, 0)
        tblPanelServer.Controls.Add(rbTestServer, 1, 0)
        tblPanelServer.Dock = DockStyle.Fill
        tblPanelServer.Location = New Point(170, 463)
        tblPanelServer.Name = "tblPanelServer"
        tblPanelServer.RowCount = 1
        tblPanelServer.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tblPanelServer.Size = New Size(344, 34)
        tblPanelServer.TabIndex = 3
        tblPanelServer.Visible = False
        ' 
        ' rbLiveServer
        ' 
        rbLiveServer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rbLiveServer.AutoSize = True
        rbLiveServer.Checked = True
        rbLiveServer.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        rbLiveServer.ForeColor = Color.White
        rbLiveServer.Location = New Point(87, 3)
        rbLiveServer.Name = "rbLiveServer"
        rbLiveServer.Size = New Size(82, 18)
        rbLiveServer.TabIndex = 0
        rbLiveServer.TabStop = True
        rbLiveServer.Text = "Live Server"
        rbLiveServer.UseVisualStyleBackColor = True
        ' 
        ' rbTestServer
        ' 
        rbTestServer.AutoSize = True
        rbTestServer.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        rbTestServer.ForeColor = Color.White
        rbTestServer.Location = New Point(175, 3)
        rbTestServer.Name = "rbTestServer"
        rbTestServer.Size = New Size(83, 18)
        rbTestServer.TabIndex = 0
        rbTestServer.Text = "Test Server"
        rbTestServer.UseVisualStyleBackColor = True
        ' 
        ' BackgroundWorker1
        ' 
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 5000
        ' 
        ' FormLogin
        ' 
        AcceptButton = btn_Login
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(151), CByte(182), CByte(217))
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(700, 500)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        TableLayoutPanel1.ResumeLayout(False)
        MaterialCard1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(pbConnection, ComponentModel.ISupportInitialize).EndInit()
        tblPanelServer.ResumeLayout(False)
        tblPanelServer.PerformLayout()
        ResumeLayout(False)
    End Sub

    'to remove the blinking effect
    ' Private WithEvents TableLayoutPanel1 As DoubleBufferedTableLayoutPanel
    Private WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MaterialCard1 As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_Login As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtUsername As ReaLTaiizor.Controls.SmallTextBox
    Friend WithEvents txtPassword As ReaLTaiizor.Controls.SmallTextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbclose As PictureBox
    Friend WithEvents pbminimize As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents ErrorNotif As ReaLTaiizor.Controls.FoxNotification
    Friend WithEvents lblUser As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblConnection As Label
    Friend WithEvents pbConnection As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tblPanelServer As TableLayoutPanel
    Friend WithEvents rbLiveServer As RadioButton
    Friend WithEvents rbTestServer As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
