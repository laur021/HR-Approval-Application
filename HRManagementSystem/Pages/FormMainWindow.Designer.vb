<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainWindow
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainWindow))
        MenuTab = New MaterialSkin.Controls.MaterialTabControl()
        TabDashboard = New TabPage()
        TabApplication = New TabPage()
        TabRecord = New TabPage()
        TabTimeKeeping = New TabPage()
        TabSettings = New TabPage()
        ImageList1 = New ImageList(components)
        btnLogout = New ReaLTaiizor.Controls.Button()
        btnNotif = New ReaLTaiizor.Controls.Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnName = New ReaLTaiizor.Controls.Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblVersion = New Label()
        lblConnected = New Label()
        MenuTab.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuTab
        ' 
        MenuTab.Controls.Add(TabDashboard)
        MenuTab.Controls.Add(TabApplication)
        MenuTab.Controls.Add(TabRecord)
        MenuTab.Controls.Add(TabTimeKeeping)
        MenuTab.Controls.Add(TabSettings)
        MenuTab.Depth = 0
        MenuTab.Dock = DockStyle.Fill
        MenuTab.ImageList = ImageList1
        MenuTab.Location = New Point(0, 0)
        MenuTab.Margin = New Padding(0)
        MenuTab.MouseState = MaterialSkin.MouseState.HOVER
        MenuTab.Multiline = True
        MenuTab.Name = "MenuTab"
        MenuTab.SelectedIndex = 0
        MenuTab.Size = New Size(1294, 718)
        MenuTab.TabIndex = 0
        ' 
        ' TabDashboard
        ' 
        TabDashboard.ImageKey = "icons8-dashboard-24.png"
        TabDashboard.Location = New Point(4, 27)
        TabDashboard.Name = "TabDashboard"
        TabDashboard.Padding = New Padding(3)
        TabDashboard.Size = New Size(1286, 687)
        TabDashboard.TabIndex = 0
        TabDashboard.Text = "Dashboard"
        TabDashboard.UseVisualStyleBackColor = True
        ' 
        ' TabApplication
        ' 
        TabApplication.ImageKey = "icons8-check-document-24.png"
        TabApplication.Location = New Point(4, 27)
        TabApplication.Name = "TabApplication"
        TabApplication.Size = New Size(1286, 687)
        TabApplication.TabIndex = 3
        TabApplication.Text = "Latest Application"
        TabApplication.UseVisualStyleBackColor = True
        ' 
        ' TabRecord
        ' 
        TabRecord.ImageKey = "icons8-documents-24.png"
        TabRecord.Location = New Point(4, 27)
        TabRecord.Name = "TabRecord"
        TabRecord.Size = New Size(1286, 687)
        TabRecord.TabIndex = 5
        TabRecord.Text = "All Applications"
        TabRecord.UseVisualStyleBackColor = True
        ' 
        ' TabTimeKeeping
        ' 
        TabTimeKeeping.ImageKey = "icons8-business-report-24.png"
        TabTimeKeeping.Location = New Point(4, 27)
        TabTimeKeeping.Name = "TabTimeKeeping"
        TabTimeKeeping.Size = New Size(1286, 687)
        TabTimeKeeping.TabIndex = 7
        TabTimeKeeping.Text = "Time Keeping"
        TabTimeKeeping.UseVisualStyleBackColor = True
        ' 
        ' TabSettings
        ' 
        TabSettings.ImageKey = "icons8-settings-24.png"
        TabSettings.Location = New Point(4, 27)
        TabSettings.Name = "TabSettings"
        TabSettings.Padding = New Padding(3)
        TabSettings.Size = New Size(1286, 687)
        TabSettings.TabIndex = 6
        TabSettings.Text = "Settings"
        TabSettings.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "icons8-dashboard-24.png")
        ImageList1.Images.SetKeyName(1, "icons8-check-document-24.png")
        ImageList1.Images.SetKeyName(2, "icons8-documents-24.png")
        ImageList1.Images.SetKeyName(3, "icons8-business-report-24.png")
        ImageList1.Images.SetKeyName(4, "icons8-settings-24.png")
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.None
        btnLogout.BackColor = Color.Transparent
        btnLogout.BorderColor = Color.Transparent
        btnLogout.EnteredBorderColor = Color.Transparent
        btnLogout.EnteredColor = Color.FromArgb(CByte(25), CByte(124), CByte(184))
        btnLogout.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogout.Image = My.Resources.Resources.icons8_logout_24
        btnLogout.ImageAlign = ContentAlignment.MiddleCenter
        btnLogout.InactiveColor = Color.Transparent
        btnLogout.Location = New Point(1263, 39)
        btnLogout.Name = "btnLogout"
        btnLogout.PressedBorderColor = Color.Transparent
        btnLogout.PressedColor = Color.Transparent
        btnLogout.Size = New Size(30, 30)
        btnLogout.TabIndex = 2
        btnLogout.TextAlignment = StringAlignment.Center
        ' 
        ' btnNotif
        ' 
        btnNotif.Anchor = AnchorStyles.None
        btnNotif.BackColor = Color.Transparent
        btnNotif.BorderColor = Color.Transparent
        btnNotif.EnteredBorderColor = Color.Transparent
        btnNotif.EnteredColor = Color.FromArgb(CByte(25), CByte(124), CByte(184))
        btnNotif.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnNotif.Image = My.Resources.Resources.bell_read
        btnNotif.ImageAlign = ContentAlignment.MiddleCenter
        btnNotif.InactiveColor = Color.Transparent
        btnNotif.Location = New Point(1227, 39)
        btnNotif.Name = "btnNotif"
        btnNotif.PressedBorderColor = Color.Transparent
        btnNotif.PressedColor = Color.Transparent
        btnNotif.Size = New Size(30, 30)
        btnNotif.TabIndex = 2
        btnNotif.TextAlignment = StringAlignment.Center
        ' 
        ' BackgroundWorker1
        ' 
        BackgroundWorker1.WorkerSupportsCancellation = True
        ' 
        ' btnName
        ' 
        btnName.Anchor = AnchorStyles.None
        btnName.BackColor = Color.Transparent
        btnName.BorderColor = Color.Transparent
        btnName.EnteredBorderColor = Color.Transparent
        btnName.EnteredColor = Color.FromArgb(CByte(25), CByte(124), CByte(184))
        btnName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnName.Image = My.Resources.Resources.icons8_arrow_down_241
        btnName.ImageAlign = ContentAlignment.MiddleRight
        btnName.InactiveColor = Color.Transparent
        btnName.Location = New Point(1051, 39)
        btnName.Name = "btnName"
        btnName.PressedBorderColor = Color.Transparent
        btnName.PressedColor = Color.Transparent
        btnName.Size = New Size(82, 30)
        btnName.TabIndex = 2
        btnName.Text = "Name"
        btnName.TextAlignment = StringAlignment.Near
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel1.Controls.Add(MenuTab, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 88)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.Size = New Size(1294, 748)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(lblVersion, 1, 0)
        TableLayoutPanel2.Controls.Add(lblConnected, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 718)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1294, 30)
        TableLayoutPanel2.TabIndex = 8
        ' 
        ' lblVersion
        ' 
        lblVersion.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Roboto", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblVersion.ForeColor = SystemColors.ControlDarkDark
        lblVersion.Location = New Point(1232, 3)
        lblVersion.Margin = New Padding(3, 3, 14, 3)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(48, 13)
        lblVersion.TabIndex = 6
        lblVersion.Text = "Version:"
        ' 
        ' lblConnected
        ' 
        lblConnected.AutoSize = True
        lblConnected.Font = New Font("Roboto", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblConnected.ForeColor = SystemColors.ControlDarkDark
        lblConnected.Location = New Point(14, 3)
        lblConnected.Margin = New Padding(14, 3, 3, 3)
        lblConnected.Name = "lblConnected"
        lblConnected.Size = New Size(88, 13)
        lblConnected.TabIndex = 6
        lblConnected.Text = "LIVE: Connected"
        ' 
        ' FormMainWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1300, 839)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnName)
        Controls.Add(btnNotif)
        Controls.Add(btnLogout)
        DrawerTabControl = MenuTab
        ForeColor = SystemColors.Control
        FormStyle = FormStyles.ActionBar_64
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormMainWindow"
        Padding = New Padding(3, 88, 3, 3)
        MenuTab.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MenuTab As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabDashboard As TabPage
    Friend WithEvents TabApplication As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabRecord As TabPage
    Friend WithEvents btnLogout As ReaLTaiizor.Controls.Button
    Friend WithEvents btnNotif As ReaLTaiizor.Controls.Button
    Friend WithEvents TabSettings As TabPage
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabTimeKeeping As TabPage
    Friend WithEvents btnName As ReaLTaiizor.Controls.Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblConnected As Label
End Class
