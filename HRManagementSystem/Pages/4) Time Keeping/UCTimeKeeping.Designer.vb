<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCTimeKeeping
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MaterialCard1 = New ReaLTaiizor.Controls.MaterialCard()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        dtpTo = New ReaLTaiizor.Controls.PoisonDateTime()
        dtpFrom = New ReaLTaiizor.Controls.PoisonDateTime()
        Label5 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        cmbDepartment = New ReaLTaiizor.Controls.PoisonComboBox()
        btnExport = New MaterialSkin.Controls.MaterialButton()
        btnRefresh = New MaterialSkin.Controls.MaterialButton()
        btnSearch = New MaterialSkin.Controls.MaterialButton()
        Label9 = New Label()
        cmbName = New ReaLTaiizor.Controls.PoisonComboBox()
        Label1 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        tblLeaveCount = New TableLayoutPanel()
        Label6 = New Label()
        Panel3 = New Panel()
        pbLoader_LeaveCounts = New PictureBox()
        dgvLeaveCounts = New DataGridView()
        tblLeaveSummary = New TableLayoutPanel()
        Panel2 = New Panel()
        pbLoader_LeaveSummary = New PictureBox()
        dgvLeaveSummary = New DataGridView()
        Label7 = New Label()
        tblOverBreak = New TableLayoutPanel()
        tblOverBreakCounts = New TableLayoutPanel()
        Label11 = New Label()
        Panel4 = New Panel()
        pbLoader_OverBreakCounts = New PictureBox()
        dgvOverbreakCounts = New DataGridView()
        tblOverBreakSummary = New TableLayoutPanel()
        Label8 = New Label()
        Panel1 = New Panel()
        pbLoader_OverBreakSummary = New PictureBox()
        dgvOverbreakSummary = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        MaterialCard1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        tblLeaveCount.SuspendLayout()
        Panel3.SuspendLayout()
        CType(pbLoader_LeaveCounts, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvLeaveCounts, ComponentModel.ISupportInitialize).BeginInit()
        tblLeaveSummary.SuspendLayout()
        Panel2.SuspendLayout()
        CType(pbLoader_LeaveSummary, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvLeaveSummary, ComponentModel.ISupportInitialize).BeginInit()
        tblOverBreak.SuspendLayout()
        tblOverBreakCounts.SuspendLayout()
        Panel4.SuspendLayout()
        CType(pbLoader_OverBreakCounts, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOverbreakCounts, ComponentModel.ISupportInitialize).BeginInit()
        tblOverBreakSummary.SuspendLayout()
        Panel1.SuspendLayout()
        CType(pbLoader_OverBreakSummary, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOverbreakSummary, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(TableLayoutPanel3)
        MaterialCard1.Depth = 0
        MaterialCard1.Dock = DockStyle.Fill
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(14, 14)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(1359, 781)
        MaterialCard1.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel2, 0, 2)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(14, 14)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(1331, 753)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 11
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel4.Controls.Add(dtpTo, 3, 0)
        TableLayoutPanel4.Controls.Add(dtpFrom, 1, 0)
        TableLayoutPanel4.Controls.Add(Label5, 4, 0)
        TableLayoutPanel4.Controls.Add(Label2, 2, 0)
        TableLayoutPanel4.Controls.Add(Label4, 0, 0)
        TableLayoutPanel4.Controls.Add(cmbDepartment, 5, 0)
        TableLayoutPanel4.Controls.Add(btnExport, 10, 0)
        TableLayoutPanel4.Controls.Add(btnRefresh, 9, 0)
        TableLayoutPanel4.Controls.Add(btnSearch, 8, 0)
        TableLayoutPanel4.Controls.Add(Label9, 6, 0)
        TableLayoutPanel4.Controls.Add(cmbName, 7, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 53)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(1325, 44)
        TableLayoutPanel4.TabIndex = 10
        ' 
        ' dtpTo
        ' 
        dtpTo.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpTo.Format = DateTimePickerFormat.Short
        dtpTo.Location = New Point(347, 7)
        dtpTo.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        dtpTo.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        dtpTo.MinimumSize = New Size(0, 29)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(144, 29)
        dtpTo.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        dtpTo.TabIndex = 17
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpFrom.CalendarFont = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dtpFrom.Format = DateTimePickerFormat.Short
        dtpFrom.Location = New Point(168, 7)
        dtpFrom.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        dtpFrom.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        dtpFrom.MinimumSize = New Size(0, 29)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(144, 29)
        dtpFrom.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(497, 14)
        Label5.Margin = New Padding(3)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 15)
        Label5.TabIndex = 2
        Label5.Text = "Department:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(318, 14)
        Label2.Margin = New Padding(3)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 15)
        Label2.TabIndex = 2
        Label2.Text = "To:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(123, 14)
        Label4.Margin = New Padding(3)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 2
        Label4.Text = "From:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.ItemHeight = 23
        cmbDepartment.Items.AddRange(New Object() {"Request ID", "Name", "Department", "Leave Type", "Status"})
        cmbDepartment.Location = New Point(578, 7)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.PromptText = "Department"
        cmbDepartment.Size = New Size(194, 29)
        cmbDepartment.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        cmbDepartment.TabIndex = 18
        cmbDepartment.UseSelectable = True
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnExport.AutoSize = False
        btnExport.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnExport.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title
        btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnExport.Depth = 0
        btnExport.HighEmphasis = True
        btnExport.Icon = Nothing
        btnExport.Location = New Point(1229, 7)
        btnExport.Margin = New Padding(4, 6, 4, 6)
        btnExport.MouseState = MaterialSkin.MouseState.HOVER
        btnExport.Name = "btnExport"
        btnExport.NoAccentTextColor = Color.Empty
        btnExport.Size = New Size(92, 30)
        btnExport.TabIndex = 10
        btnExport.Text = "Export"
        btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnExport.UseAccentColor = False
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnRefresh.AutoSize = False
        btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnRefresh.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title
        btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnRefresh.Depth = 0
        btnRefresh.HighEmphasis = True
        btnRefresh.Icon = Nothing
        btnRefresh.Location = New Point(1129, 7)
        btnRefresh.Margin = New Padding(4, 6, 4, 6)
        btnRefresh.MouseState = MaterialSkin.MouseState.HOVER
        btnRefresh.Name = "btnRefresh"
        btnRefresh.NoAccentTextColor = Color.Empty
        btnRefresh.Size = New Size(92, 30)
        btnRefresh.TabIndex = 10
        btnRefresh.Text = "Refresh"
        btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnRefresh.UseAccentColor = False
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnSearch.AutoSize = False
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearch.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title
        btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSearch.Depth = 0
        btnSearch.HighEmphasis = True
        btnSearch.Icon = Nothing
        btnSearch.Location = New Point(1029, 7)
        btnSearch.Margin = New Padding(4, 6, 4, 6)
        btnSearch.MouseState = MaterialSkin.MouseState.HOVER
        btnSearch.Name = "btnSearch"
        btnSearch.NoAccentTextColor = Color.Empty
        btnSearch.Size = New Size(92, 30)
        btnSearch.TabIndex = 10
        btnSearch.Text = "Search"
        btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSearch.UseAccentColor = False
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ControlDarkDark
        Label9.Location = New Point(778, 14)
        Label9.Margin = New Padding(3)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 15)
        Label9.TabIndex = 2
        Label9.Text = "Name:"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbName
        ' 
        cmbName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmbName.FormattingEnabled = True
        cmbName.ItemHeight = 23
        cmbName.Items.AddRange(New Object() {"Request ID", "Name", "Department", "Leave Type", "Status"})
        cmbName.Location = New Point(828, 7)
        cmbName.Name = "cmbName"
        cmbName.PromptText = "Name"
        cmbName.Size = New Size(194, 29)
        cmbName.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        cmbName.TabIndex = 18
        cmbName.UseSelectable = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 22)
        Label1.TabIndex = 2
        Label1.Text = "Time Keeping"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(tblLeaveCount, 0, 0)
        TableLayoutPanel2.Controls.Add(tblLeaveSummary, 0, 1)
        TableLayoutPanel2.Controls.Add(tblOverBreak, 0, 2)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 100)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel2.Size = New Size(1331, 653)
        TableLayoutPanel2.TabIndex = 11
        ' 
        ' tblLeaveCount
        ' 
        tblLeaveCount.ColumnCount = 1
        tblLeaveCount.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tblLeaveCount.Controls.Add(Label6, 0, 0)
        tblLeaveCount.Controls.Add(Panel3, 0, 1)
        tblLeaveCount.Dock = DockStyle.Fill
        tblLeaveCount.Location = New Point(0, 0)
        tblLeaveCount.Margin = New Padding(0)
        tblLeaveCount.Name = "tblLeaveCount"
        tblLeaveCount.RowCount = 3
        tblLeaveCount.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        tblLeaveCount.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblLeaveCount.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        tblLeaveCount.Size = New Size(1331, 217)
        tblLeaveCount.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.InactiveBorder
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlDarkDark
        Label6.Location = New Point(0, 0)
        Label6.Margin = New Padding(0)
        Label6.Name = "Label6"
        Label6.Size = New Size(1331, 40)
        Label6.TabIndex = 2
        Label6.Text = "Leave Counts"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(pbLoader_LeaveCounts)
        Panel3.Controls.Add(dgvLeaveCounts)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 40)
        Panel3.Margin = New Padding(0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1331, 137)
        Panel3.TabIndex = 15
        ' 
        ' pbLoader_LeaveCounts
        ' 
        pbLoader_LeaveCounts.BackColor = Color.Transparent
        pbLoader_LeaveCounts.Dock = DockStyle.Fill
        pbLoader_LeaveCounts.Image = My.Resources.Resources.preloader2
        pbLoader_LeaveCounts.Location = New Point(0, 0)
        pbLoader_LeaveCounts.Margin = New Padding(0)
        pbLoader_LeaveCounts.Name = "pbLoader_LeaveCounts"
        pbLoader_LeaveCounts.Size = New Size(1331, 137)
        pbLoader_LeaveCounts.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_LeaveCounts.TabIndex = 13
        pbLoader_LeaveCounts.TabStop = False
        pbLoader_LeaveCounts.Visible = False
        ' 
        ' dgvLeaveCounts
        ' 
        dgvLeaveCounts.AllowUserToAddRows = False
        dgvLeaveCounts.AllowUserToDeleteRows = False
        dgvLeaveCounts.AllowUserToResizeColumns = False
        dgvLeaveCounts.AllowUserToResizeRows = False
        dgvLeaveCounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLeaveCounts.BackgroundColor = SystemColors.Window
        dgvLeaveCounts.BorderStyle = BorderStyle.None
        dgvLeaveCounts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvLeaveCounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Padding = New Padding(0, 3, 0, 3)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvLeaveCounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvLeaveCounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvLeaveCounts.DefaultCellStyle = DataGridViewCellStyle2
        dgvLeaveCounts.Dock = DockStyle.Fill
        dgvLeaveCounts.EnableHeadersVisualStyles = False
        dgvLeaveCounts.GridColor = SystemColors.InactiveBorder
        dgvLeaveCounts.Location = New Point(0, 0)
        dgvLeaveCounts.Name = "dgvLeaveCounts"
        dgvLeaveCounts.ReadOnly = True
        dgvLeaveCounts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvLeaveCounts.RowHeadersVisible = False
        dgvLeaveCounts.RowTemplate.Height = 25
        dgvLeaveCounts.ScrollBars = ScrollBars.Vertical
        dgvLeaveCounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLeaveCounts.ShowCellErrors = False
        dgvLeaveCounts.ShowCellToolTips = False
        dgvLeaveCounts.ShowEditingIcon = False
        dgvLeaveCounts.ShowRowErrors = False
        dgvLeaveCounts.Size = New Size(1331, 137)
        dgvLeaveCounts.TabIndex = 12
        ' 
        ' tblLeaveSummary
        ' 
        tblLeaveSummary.ColumnCount = 1
        tblLeaveSummary.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tblLeaveSummary.Controls.Add(Panel2, 0, 1)
        tblLeaveSummary.Controls.Add(Label7, 0, 0)
        tblLeaveSummary.Dock = DockStyle.Fill
        tblLeaveSummary.Location = New Point(0, 217)
        tblLeaveSummary.Margin = New Padding(0)
        tblLeaveSummary.Name = "tblLeaveSummary"
        tblLeaveSummary.RowCount = 3
        tblLeaveSummary.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        tblLeaveSummary.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblLeaveSummary.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        tblLeaveSummary.Size = New Size(1331, 217)
        tblLeaveSummary.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(pbLoader_LeaveSummary)
        Panel2.Controls.Add(dgvLeaveSummary)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 40)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1331, 137)
        Panel2.TabIndex = 14
        ' 
        ' pbLoader_LeaveSummary
        ' 
        pbLoader_LeaveSummary.BackColor = Color.Transparent
        pbLoader_LeaveSummary.Dock = DockStyle.Fill
        pbLoader_LeaveSummary.Image = My.Resources.Resources.preloader2
        pbLoader_LeaveSummary.Location = New Point(0, 0)
        pbLoader_LeaveSummary.Name = "pbLoader_LeaveSummary"
        pbLoader_LeaveSummary.Size = New Size(1331, 137)
        pbLoader_LeaveSummary.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_LeaveSummary.TabIndex = 13
        pbLoader_LeaveSummary.TabStop = False
        pbLoader_LeaveSummary.Visible = False
        ' 
        ' dgvLeaveSummary
        ' 
        dgvLeaveSummary.AllowUserToAddRows = False
        dgvLeaveSummary.AllowUserToDeleteRows = False
        dgvLeaveSummary.AllowUserToResizeColumns = False
        dgvLeaveSummary.AllowUserToResizeRows = False
        dgvLeaveSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLeaveSummary.BackgroundColor = SystemColors.Window
        dgvLeaveSummary.BorderStyle = BorderStyle.None
        dgvLeaveSummary.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvLeaveSummary.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Padding = New Padding(0, 3, 0, 3)
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvLeaveSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvLeaveSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvLeaveSummary.DefaultCellStyle = DataGridViewCellStyle4
        dgvLeaveSummary.Dock = DockStyle.Fill
        dgvLeaveSummary.EnableHeadersVisualStyles = False
        dgvLeaveSummary.GridColor = SystemColors.InactiveBorder
        dgvLeaveSummary.Location = New Point(0, 0)
        dgvLeaveSummary.Name = "dgvLeaveSummary"
        dgvLeaveSummary.ReadOnly = True
        dgvLeaveSummary.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvLeaveSummary.RowHeadersVisible = False
        dgvLeaveSummary.RowTemplate.Height = 25
        dgvLeaveSummary.ScrollBars = ScrollBars.Vertical
        dgvLeaveSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLeaveSummary.ShowCellErrors = False
        dgvLeaveSummary.ShowCellToolTips = False
        dgvLeaveSummary.ShowEditingIcon = False
        dgvLeaveSummary.ShowRowErrors = False
        dgvLeaveSummary.Size = New Size(1331, 137)
        dgvLeaveSummary.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.InactiveBorder
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlDarkDark
        Label7.Location = New Point(0, 0)
        Label7.Margin = New Padding(0)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(3)
        Label7.Size = New Size(1331, 40)
        Label7.TabIndex = 2
        Label7.Text = "Leave Summary"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tblOverBreak
        ' 
        tblOverBreak.ColumnCount = 3
        tblOverBreak.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        tblOverBreak.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 5F))
        tblOverBreak.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        tblOverBreak.Controls.Add(tblOverBreakCounts, 0, 0)
        tblOverBreak.Controls.Add(tblOverBreakSummary, 2, 0)
        tblOverBreak.Dock = DockStyle.Fill
        tblOverBreak.Location = New Point(0, 434)
        tblOverBreak.Margin = New Padding(0)
        tblOverBreak.Name = "tblOverBreak"
        tblOverBreak.RowCount = 1
        tblOverBreak.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblOverBreak.Size = New Size(1331, 219)
        tblOverBreak.TabIndex = 2
        ' 
        ' tblOverBreakCounts
        ' 
        tblOverBreakCounts.ColumnCount = 1
        tblOverBreakCounts.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tblOverBreakCounts.Controls.Add(Label11, 0, 0)
        tblOverBreakCounts.Controls.Add(Panel4, 0, 1)
        tblOverBreakCounts.Dock = DockStyle.Fill
        tblOverBreakCounts.Location = New Point(0, 0)
        tblOverBreakCounts.Margin = New Padding(0)
        tblOverBreakCounts.Name = "tblOverBreakCounts"
        tblOverBreakCounts.RowCount = 3
        tblOverBreakCounts.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        tblOverBreakCounts.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblOverBreakCounts.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        tblOverBreakCounts.Size = New Size(397, 219)
        tblOverBreakCounts.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.InactiveBorder
        Label11.Dock = DockStyle.Fill
        Label11.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = SystemColors.ControlDarkDark
        Label11.Location = New Point(0, 0)
        Label11.Margin = New Padding(0)
        Label11.Name = "Label11"
        Label11.Padding = New Padding(3)
        Label11.Size = New Size(397, 40)
        Label11.TabIndex = 2
        Label11.Text = "Over Break Counts"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(pbLoader_OverBreakCounts)
        Panel4.Controls.Add(dgvOverbreakCounts)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 40)
        Panel4.Margin = New Padding(0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(397, 139)
        Panel4.TabIndex = 13
        ' 
        ' pbLoader_OverBreakCounts
        ' 
        pbLoader_OverBreakCounts.BackColor = Color.Transparent
        pbLoader_OverBreakCounts.Dock = DockStyle.Fill
        pbLoader_OverBreakCounts.Image = My.Resources.Resources.preloader2
        pbLoader_OverBreakCounts.Location = New Point(0, 0)
        pbLoader_OverBreakCounts.Name = "pbLoader_OverBreakCounts"
        pbLoader_OverBreakCounts.Size = New Size(397, 139)
        pbLoader_OverBreakCounts.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_OverBreakCounts.TabIndex = 13
        pbLoader_OverBreakCounts.TabStop = False
        pbLoader_OverBreakCounts.Visible = False
        ' 
        ' dgvOverbreakCounts
        ' 
        dgvOverbreakCounts.AllowUserToAddRows = False
        dgvOverbreakCounts.AllowUserToDeleteRows = False
        dgvOverbreakCounts.AllowUserToResizeColumns = False
        dgvOverbreakCounts.AllowUserToResizeRows = False
        dgvOverbreakCounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOverbreakCounts.BackgroundColor = SystemColors.Window
        dgvOverbreakCounts.BorderStyle = BorderStyle.None
        dgvOverbreakCounts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOverbreakCounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle5.Padding = New Padding(0, 3, 0, 3)
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvOverbreakCounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvOverbreakCounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvOverbreakCounts.DefaultCellStyle = DataGridViewCellStyle6
        dgvOverbreakCounts.Dock = DockStyle.Fill
        dgvOverbreakCounts.EnableHeadersVisualStyles = False
        dgvOverbreakCounts.GridColor = SystemColors.InactiveBorder
        dgvOverbreakCounts.Location = New Point(0, 0)
        dgvOverbreakCounts.Name = "dgvOverbreakCounts"
        dgvOverbreakCounts.ReadOnly = True
        dgvOverbreakCounts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOverbreakCounts.RowHeadersVisible = False
        dgvOverbreakCounts.RowTemplate.Height = 25
        dgvOverbreakCounts.ScrollBars = ScrollBars.Vertical
        dgvOverbreakCounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOverbreakCounts.ShowCellErrors = False
        dgvOverbreakCounts.ShowCellToolTips = False
        dgvOverbreakCounts.ShowEditingIcon = False
        dgvOverbreakCounts.ShowRowErrors = False
        dgvOverbreakCounts.Size = New Size(397, 139)
        dgvOverbreakCounts.TabIndex = 12
        ' 
        ' tblOverBreakSummary
        ' 
        tblOverBreakSummary.ColumnCount = 1
        tblOverBreakSummary.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tblOverBreakSummary.Controls.Add(Label8, 0, 0)
        tblOverBreakSummary.Controls.Add(Panel1, 0, 1)
        tblOverBreakSummary.Dock = DockStyle.Fill
        tblOverBreakSummary.Location = New Point(402, 0)
        tblOverBreakSummary.Margin = New Padding(0)
        tblOverBreakSummary.Name = "tblOverBreakSummary"
        tblOverBreakSummary.RowCount = 3
        tblOverBreakSummary.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        tblOverBreakSummary.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblOverBreakSummary.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        tblOverBreakSummary.Size = New Size(929, 219)
        tblOverBreakSummary.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.InactiveBorder
        Label8.Dock = DockStyle.Fill
        Label8.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlDarkDark
        Label8.Location = New Point(0, 0)
        Label8.Margin = New Padding(0)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(3)
        Label8.Size = New Size(929, 40)
        Label8.TabIndex = 2
        Label8.Text = "Over Break Summary"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(pbLoader_OverBreakSummary)
        Panel1.Controls.Add(dgvOverbreakSummary)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 40)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(929, 139)
        Panel1.TabIndex = 13
        ' 
        ' pbLoader_OverBreakSummary
        ' 
        pbLoader_OverBreakSummary.BackColor = Color.Transparent
        pbLoader_OverBreakSummary.Dock = DockStyle.Fill
        pbLoader_OverBreakSummary.Image = My.Resources.Resources.preloader2
        pbLoader_OverBreakSummary.Location = New Point(0, 0)
        pbLoader_OverBreakSummary.Name = "pbLoader_OverBreakSummary"
        pbLoader_OverBreakSummary.Size = New Size(929, 139)
        pbLoader_OverBreakSummary.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_OverBreakSummary.TabIndex = 13
        pbLoader_OverBreakSummary.TabStop = False
        pbLoader_OverBreakSummary.Visible = False
        ' 
        ' dgvOverbreakSummary
        ' 
        dgvOverbreakSummary.AllowUserToAddRows = False
        dgvOverbreakSummary.AllowUserToDeleteRows = False
        dgvOverbreakSummary.AllowUserToResizeColumns = False
        dgvOverbreakSummary.AllowUserToResizeRows = False
        dgvOverbreakSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOverbreakSummary.BackgroundColor = SystemColors.Window
        dgvOverbreakSummary.BorderStyle = BorderStyle.None
        dgvOverbreakSummary.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOverbreakSummary.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle7.Padding = New Padding(0, 3, 0, 3)
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvOverbreakSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvOverbreakSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvOverbreakSummary.DefaultCellStyle = DataGridViewCellStyle8
        dgvOverbreakSummary.Dock = DockStyle.Fill
        dgvOverbreakSummary.EnableHeadersVisualStyles = False
        dgvOverbreakSummary.GridColor = SystemColors.InactiveBorder
        dgvOverbreakSummary.Location = New Point(0, 0)
        dgvOverbreakSummary.Name = "dgvOverbreakSummary"
        dgvOverbreakSummary.ReadOnly = True
        dgvOverbreakSummary.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOverbreakSummary.RowHeadersVisible = False
        dgvOverbreakSummary.RowTemplate.Height = 25
        dgvOverbreakSummary.ScrollBars = ScrollBars.Vertical
        dgvOverbreakSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOverbreakSummary.ShowCellErrors = False
        dgvOverbreakSummary.ShowEditingIcon = False
        dgvOverbreakSummary.ShowRowErrors = False
        dgvOverbreakSummary.Size = New Size(929, 139)
        dgvOverbreakSummary.TabIndex = 12
        ' 
        ' UCTimeKeeping
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MaterialCard1)
        Name = "UCTimeKeeping"
        Padding = New Padding(14, 14, 14, 5)
        Size = New Size(1387, 800)
        MaterialCard1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        tblLeaveCount.ResumeLayout(False)
        tblLeaveCount.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(pbLoader_LeaveCounts, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvLeaveCounts, ComponentModel.ISupportInitialize).EndInit()
        tblLeaveSummary.ResumeLayout(False)
        tblLeaveSummary.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(pbLoader_LeaveSummary, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvLeaveSummary, ComponentModel.ISupportInitialize).EndInit()
        tblOverBreak.ResumeLayout(False)
        tblOverBreakCounts.ResumeLayout(False)
        tblOverBreakCounts.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(pbLoader_OverBreakCounts, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOverbreakCounts, ComponentModel.ISupportInitialize).EndInit()
        tblOverBreakSummary.ResumeLayout(False)
        tblOverBreakSummary.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(pbLoader_OverBreakSummary, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOverbreakSummary, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MaterialCard1 As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dgvLeaveSummary As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dtpTo As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents dtpFrom As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnRefresh As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvLeaveCounts As DataGridView
    Friend WithEvents dgvOverbreakSummary As DataGridView
    Friend WithEvents cmbDepartment As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbLoader_OverBreakSummary As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbLoader_LeaveSummary As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbLoader_LeaveCounts As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbName As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents tblLeaveCount As TableLayoutPanel
    Friend WithEvents tblLeaveSummary As TableLayoutPanel
    Friend WithEvents tblOverBreak As TableLayoutPanel
    Friend WithEvents tblOverBreakSummary As TableLayoutPanel
    Friend WithEvents tblOverBreakCounts As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pbLoader_OverBreakCounts As PictureBox
    Friend WithEvents dgvOverbreakCounts As DataGridView
    Friend WithEvents Label1 As Label
End Class
