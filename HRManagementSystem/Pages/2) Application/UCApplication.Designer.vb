<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCApplication
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
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        TabControl_Type = New ReaLTaiizor.Controls.HopeTabPage()
        TabLeave = New TabPage()
        Panel_Leave = New Panel()
        pbLoader_Leave = New PictureBox()
        dgv_Leave = New DataGridView()
        TabChangeShift = New TabPage()
        Panel_ChangeShift = New Panel()
        pbLoader_ChangeShift = New PictureBox()
        dgv_ChangeShift = New DataGridView()
        TabOverTime = New TabPage()
        Panel_OverTime = New Panel()
        pbLoader_OverTime = New PictureBox()
        dgv_OverTime = New DataGridView()
        TabLate = New TabPage()
        Panel_Late = New Panel()
        pbLoader_Late = New PictureBox()
        dgv_Late = New DataGridView()
        TabInfractions = New TabPage()
        Panel_Infractions = New Panel()
        pbLoader_Infractions = New PictureBox()
        dgv_Infractions = New DataGridView()
        MaterialCard1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TabControl_Type.SuspendLayout()
        TabLeave.SuspendLayout()
        Panel_Leave.SuspendLayout()
        CType(pbLoader_Leave, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_Leave, ComponentModel.ISupportInitialize).BeginInit()
        TabChangeShift.SuspendLayout()
        Panel_ChangeShift.SuspendLayout()
        CType(pbLoader_ChangeShift, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_ChangeShift, ComponentModel.ISupportInitialize).BeginInit()
        TabOverTime.SuspendLayout()
        Panel_OverTime.SuspendLayout()
        CType(pbLoader_OverTime, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_OverTime, ComponentModel.ISupportInitialize).BeginInit()
        TabLate.SuspendLayout()
        Panel_Late.SuspendLayout()
        CType(pbLoader_Late, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_Late, ComponentModel.ISupportInitialize).BeginInit()
        TabInfractions.SuspendLayout()
        Panel_Infractions.SuspendLayout()
        CType(pbLoader_Infractions, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_Infractions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(TableLayoutPanel1)
        MaterialCard1.Depth = 0
        MaterialCard1.Dock = DockStyle.Fill
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(14, 14)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(1359, 781)
        MaterialCard1.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(TabControl_Type, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(14, 14)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1331, 753)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 22)
        Label1.TabIndex = 2
        Label1.Text = "Latest Application"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TabControl_Type
        ' 
        TabControl_Type.BaseColor = SystemColors.InactiveBorder
        TabControl_Type.Controls.Add(TabLeave)
        TabControl_Type.Controls.Add(TabChangeShift)
        TabControl_Type.Controls.Add(TabOverTime)
        TabControl_Type.Controls.Add(TabLate)
        TabControl_Type.Controls.Add(TabInfractions)
        TabControl_Type.Dock = DockStyle.Fill
        TabControl_Type.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl_Type.ForeColorA = Color.FromArgb(CByte(21), CByte(101), CByte(192))
        TabControl_Type.ForeColorB = Color.Gray
        TabControl_Type.ForeColorC = Color.FromArgb(CByte(65), CByte(177), CByte(225))
        TabControl_Type.ItemSize = New Size(250, 50)
        TabControl_Type.Location = New Point(3, 53)
        TabControl_Type.Name = "TabControl_Type"
        TabControl_Type.Padding = New Point(40, 3)
        TabControl_Type.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        TabControl_Type.SelectedIndex = 0
        TabControl_Type.Size = New Size(1325, 697)
        TabControl_Type.SizeMode = TabSizeMode.Fixed
        TabControl_Type.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        TabControl_Type.TabIndex = 5
        TabControl_Type.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        TabControl_Type.ThemeColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        TabControl_Type.ThemeColorB = Color.FromArgb(CByte(150), CByte(64), CByte(158), CByte(255))
        TabControl_Type.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal
        ' 
        ' TabLeave
        ' 
        TabLeave.Controls.Add(Panel_Leave)
        TabLeave.Location = New Point(0, 50)
        TabLeave.Name = "TabLeave"
        TabLeave.Padding = New Padding(3)
        TabLeave.Size = New Size(1325, 647)
        TabLeave.TabIndex = 0
        TabLeave.Text = "Leave Application  (0)"
        TabLeave.UseVisualStyleBackColor = True
        ' 
        ' Panel_Leave
        ' 
        Panel_Leave.Controls.Add(pbLoader_Leave)
        Panel_Leave.Controls.Add(dgv_Leave)
        Panel_Leave.Dock = DockStyle.Fill
        Panel_Leave.Location = New Point(3, 3)
        Panel_Leave.Margin = New Padding(0)
        Panel_Leave.Name = "Panel_Leave"
        Panel_Leave.Size = New Size(1319, 641)
        Panel_Leave.TabIndex = 13
        ' 
        ' pbLoader_Leave
        ' 
        pbLoader_Leave.BackColor = Color.Transparent
        pbLoader_Leave.Dock = DockStyle.Fill
        pbLoader_Leave.Image = My.Resources.Resources.preloader2
        pbLoader_Leave.Location = New Point(0, 0)
        pbLoader_Leave.Name = "pbLoader_Leave"
        pbLoader_Leave.Size = New Size(1319, 641)
        pbLoader_Leave.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_Leave.TabIndex = 14
        pbLoader_Leave.TabStop = False
        pbLoader_Leave.Visible = False
        ' 
        ' dgv_Leave
        ' 
        dgv_Leave.AllowUserToAddRows = False
        dgv_Leave.AllowUserToDeleteRows = False
        dgv_Leave.AllowUserToResizeColumns = False
        dgv_Leave.AllowUserToResizeRows = False
        dgv_Leave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_Leave.BackgroundColor = SystemColors.Window
        dgv_Leave.BorderStyle = BorderStyle.None
        dgv_Leave.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv_Leave.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Roboto", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Padding = New Padding(0, 28, 0, 14)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgv_Leave.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgv_Leave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Roboto", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgv_Leave.DefaultCellStyle = DataGridViewCellStyle2
        dgv_Leave.Dock = DockStyle.Fill
        dgv_Leave.EnableHeadersVisualStyles = False
        dgv_Leave.GridColor = SystemColors.InactiveBorder
        dgv_Leave.Location = New Point(0, 0)
        dgv_Leave.Name = "dgv_Leave"
        dgv_Leave.ReadOnly = True
        dgv_Leave.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_Leave.RowHeadersVisible = False
        dgv_Leave.RowTemplate.Height = 50
        dgv_Leave.ScrollBars = ScrollBars.Vertical
        dgv_Leave.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_Leave.ShowCellErrors = False
        dgv_Leave.ShowCellToolTips = False
        dgv_Leave.ShowEditingIcon = False
        dgv_Leave.ShowRowErrors = False
        dgv_Leave.Size = New Size(1319, 641)
        dgv_Leave.TabIndex = 4
        ' 
        ' TabChangeShift
        ' 
        TabChangeShift.Controls.Add(Panel_ChangeShift)
        TabChangeShift.Location = New Point(0, 50)
        TabChangeShift.Name = "TabChangeShift"
        TabChangeShift.Padding = New Padding(3)
        TabChangeShift.Size = New Size(1325, 647)
        TabChangeShift.TabIndex = 1
        TabChangeShift.Text = "Change Shift Application  (0)"
        TabChangeShift.UseVisualStyleBackColor = True
        ' 
        ' Panel_ChangeShift
        ' 
        Panel_ChangeShift.Controls.Add(pbLoader_ChangeShift)
        Panel_ChangeShift.Controls.Add(dgv_ChangeShift)
        Panel_ChangeShift.Dock = DockStyle.Fill
        Panel_ChangeShift.Location = New Point(3, 3)
        Panel_ChangeShift.Margin = New Padding(0)
        Panel_ChangeShift.Name = "Panel_ChangeShift"
        Panel_ChangeShift.Size = New Size(1319, 641)
        Panel_ChangeShift.TabIndex = 13
        ' 
        ' pbLoader_ChangeShift
        ' 
        pbLoader_ChangeShift.BackColor = Color.Transparent
        pbLoader_ChangeShift.Dock = DockStyle.Fill
        pbLoader_ChangeShift.Image = My.Resources.Resources.preloader2
        pbLoader_ChangeShift.Location = New Point(0, 0)
        pbLoader_ChangeShift.Name = "pbLoader_ChangeShift"
        pbLoader_ChangeShift.Size = New Size(1319, 641)
        pbLoader_ChangeShift.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_ChangeShift.TabIndex = 14
        pbLoader_ChangeShift.TabStop = False
        pbLoader_ChangeShift.Visible = False
        ' 
        ' dgv_ChangeShift
        ' 
        dgv_ChangeShift.AllowUserToAddRows = False
        dgv_ChangeShift.AllowUserToDeleteRows = False
        dgv_ChangeShift.AllowUserToResizeColumns = False
        dgv_ChangeShift.AllowUserToResizeRows = False
        dgv_ChangeShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_ChangeShift.BackgroundColor = SystemColors.Window
        dgv_ChangeShift.BorderStyle = BorderStyle.None
        dgv_ChangeShift.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv_ChangeShift.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Roboto", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Padding = New Padding(0, 28, 0, 14)
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgv_ChangeShift.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgv_ChangeShift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Roboto", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgv_ChangeShift.DefaultCellStyle = DataGridViewCellStyle4
        dgv_ChangeShift.Dock = DockStyle.Fill
        dgv_ChangeShift.EnableHeadersVisualStyles = False
        dgv_ChangeShift.GridColor = SystemColors.InactiveBorder
        dgv_ChangeShift.Location = New Point(0, 0)
        dgv_ChangeShift.Name = "dgv_ChangeShift"
        dgv_ChangeShift.ReadOnly = True
        dgv_ChangeShift.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_ChangeShift.RowHeadersVisible = False
        dgv_ChangeShift.RowTemplate.Height = 50
        dgv_ChangeShift.ScrollBars = ScrollBars.Vertical
        dgv_ChangeShift.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_ChangeShift.ShowCellErrors = False
        dgv_ChangeShift.ShowCellToolTips = False
        dgv_ChangeShift.ShowEditingIcon = False
        dgv_ChangeShift.ShowRowErrors = False
        dgv_ChangeShift.Size = New Size(1319, 641)
        dgv_ChangeShift.TabIndex = 4
        ' 
        ' TabOverTime
        ' 
        TabOverTime.Controls.Add(Panel_OverTime)
        TabOverTime.Location = New Point(0, 50)
        TabOverTime.Name = "TabOverTime"
        TabOverTime.Padding = New Padding(3)
        TabOverTime.Size = New Size(1325, 647)
        TabOverTime.TabIndex = 2
        TabOverTime.Text = "Over Time Application  (0)"
        TabOverTime.UseVisualStyleBackColor = True
        ' 
        ' Panel_OverTime
        ' 
        Panel_OverTime.Controls.Add(pbLoader_OverTime)
        Panel_OverTime.Controls.Add(dgv_OverTime)
        Panel_OverTime.Dock = DockStyle.Fill
        Panel_OverTime.Location = New Point(3, 3)
        Panel_OverTime.Margin = New Padding(0)
        Panel_OverTime.Name = "Panel_OverTime"
        Panel_OverTime.Size = New Size(1319, 641)
        Panel_OverTime.TabIndex = 13
        ' 
        ' pbLoader_OverTime
        ' 
        pbLoader_OverTime.BackColor = Color.Transparent
        pbLoader_OverTime.Dock = DockStyle.Fill
        pbLoader_OverTime.Image = My.Resources.Resources.preloader2
        pbLoader_OverTime.Location = New Point(0, 0)
        pbLoader_OverTime.Name = "pbLoader_OverTime"
        pbLoader_OverTime.Size = New Size(1319, 641)
        pbLoader_OverTime.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_OverTime.TabIndex = 14
        pbLoader_OverTime.TabStop = False
        pbLoader_OverTime.Visible = False
        ' 
        ' dgv_OverTime
        ' 
        dgv_OverTime.AllowUserToAddRows = False
        dgv_OverTime.AllowUserToDeleteRows = False
        dgv_OverTime.AllowUserToResizeColumns = False
        dgv_OverTime.AllowUserToResizeRows = False
        dgv_OverTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_OverTime.BackgroundColor = SystemColors.Window
        dgv_OverTime.BorderStyle = BorderStyle.None
        dgv_OverTime.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv_OverTime.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Roboto", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle5.Padding = New Padding(0, 28, 0, 14)
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgv_OverTime.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgv_OverTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Roboto", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgv_OverTime.DefaultCellStyle = DataGridViewCellStyle6
        dgv_OverTime.Dock = DockStyle.Fill
        dgv_OverTime.EnableHeadersVisualStyles = False
        dgv_OverTime.GridColor = SystemColors.InactiveBorder
        dgv_OverTime.Location = New Point(0, 0)
        dgv_OverTime.Name = "dgv_OverTime"
        dgv_OverTime.ReadOnly = True
        dgv_OverTime.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_OverTime.RowHeadersVisible = False
        dgv_OverTime.RowTemplate.Height = 50
        dgv_OverTime.ScrollBars = ScrollBars.Vertical
        dgv_OverTime.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_OverTime.ShowCellErrors = False
        dgv_OverTime.ShowCellToolTips = False
        dgv_OverTime.ShowEditingIcon = False
        dgv_OverTime.ShowRowErrors = False
        dgv_OverTime.Size = New Size(1319, 641)
        dgv_OverTime.TabIndex = 4
        ' 
        ' TabLate
        ' 
        TabLate.Controls.Add(Panel_Late)
        TabLate.Location = New Point(0, 50)
        TabLate.Name = "TabLate"
        TabLate.Padding = New Padding(3)
        TabLate.Size = New Size(1325, 647)
        TabLate.TabIndex = 3
        TabLate.Text = "Late Application  (0)"
        TabLate.UseVisualStyleBackColor = True
        ' 
        ' Panel_Late
        ' 
        Panel_Late.Controls.Add(pbLoader_Late)
        Panel_Late.Controls.Add(dgv_Late)
        Panel_Late.Dock = DockStyle.Fill
        Panel_Late.Location = New Point(3, 3)
        Panel_Late.Margin = New Padding(0)
        Panel_Late.Name = "Panel_Late"
        Panel_Late.Size = New Size(1319, 641)
        Panel_Late.TabIndex = 13
        ' 
        ' pbLoader_Late
        ' 
        pbLoader_Late.BackColor = Color.Transparent
        pbLoader_Late.Dock = DockStyle.Fill
        pbLoader_Late.Image = My.Resources.Resources.preloader2
        pbLoader_Late.Location = New Point(0, 0)
        pbLoader_Late.Name = "pbLoader_Late"
        pbLoader_Late.Size = New Size(1319, 641)
        pbLoader_Late.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_Late.TabIndex = 14
        pbLoader_Late.TabStop = False
        pbLoader_Late.Visible = False
        ' 
        ' dgv_Late
        ' 
        dgv_Late.AllowUserToAddRows = False
        dgv_Late.AllowUserToDeleteRows = False
        dgv_Late.AllowUserToResizeColumns = False
        dgv_Late.AllowUserToResizeRows = False
        dgv_Late.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_Late.BackgroundColor = SystemColors.Window
        dgv_Late.BorderStyle = BorderStyle.None
        dgv_Late.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv_Late.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle7.Padding = New Padding(0, 28, 0, 14)
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgv_Late.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgv_Late.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgv_Late.DefaultCellStyle = DataGridViewCellStyle8
        dgv_Late.Dock = DockStyle.Fill
        dgv_Late.EnableHeadersVisualStyles = False
        dgv_Late.GridColor = SystemColors.InactiveBorder
        dgv_Late.Location = New Point(0, 0)
        dgv_Late.Name = "dgv_Late"
        dgv_Late.ReadOnly = True
        dgv_Late.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_Late.RowHeadersVisible = False
        dgv_Late.RowTemplate.Height = 50
        dgv_Late.ScrollBars = ScrollBars.Vertical
        dgv_Late.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_Late.ShowCellErrors = False
        dgv_Late.ShowCellToolTips = False
        dgv_Late.ShowEditingIcon = False
        dgv_Late.ShowRowErrors = False
        dgv_Late.Size = New Size(1319, 641)
        dgv_Late.TabIndex = 4
        ' 
        ' TabInfractions
        ' 
        TabInfractions.Controls.Add(Panel_Infractions)
        TabInfractions.Location = New Point(0, 50)
        TabInfractions.Name = "TabInfractions"
        TabInfractions.Padding = New Padding(3)
        TabInfractions.Size = New Size(1325, 647)
        TabInfractions.TabIndex = 4
        TabInfractions.Text = "Timekeeping Infraction  (0)"
        TabInfractions.UseVisualStyleBackColor = True
        ' 
        ' Panel_Infractions
        ' 
        Panel_Infractions.Controls.Add(pbLoader_Infractions)
        Panel_Infractions.Controls.Add(dgv_Infractions)
        Panel_Infractions.Dock = DockStyle.Fill
        Panel_Infractions.Location = New Point(3, 3)
        Panel_Infractions.Margin = New Padding(0)
        Panel_Infractions.Name = "Panel_Infractions"
        Panel_Infractions.Size = New Size(1319, 641)
        Panel_Infractions.TabIndex = 14
        ' 
        ' pbLoader_Infractions
        ' 
        pbLoader_Infractions.BackColor = Color.Transparent
        pbLoader_Infractions.Dock = DockStyle.Fill
        pbLoader_Infractions.Image = My.Resources.Resources.preloader2
        pbLoader_Infractions.Location = New Point(0, 0)
        pbLoader_Infractions.Name = "pbLoader_Infractions"
        pbLoader_Infractions.Size = New Size(1319, 641)
        pbLoader_Infractions.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_Infractions.TabIndex = 14
        pbLoader_Infractions.TabStop = False
        pbLoader_Infractions.Visible = False
        ' 
        ' dgv_Infractions
        ' 
        dgv_Infractions.AllowUserToAddRows = False
        dgv_Infractions.AllowUserToDeleteRows = False
        dgv_Infractions.AllowUserToResizeColumns = False
        dgv_Infractions.AllowUserToResizeRows = False
        dgv_Infractions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_Infractions.BackgroundColor = SystemColors.Window
        dgv_Infractions.BorderStyle = BorderStyle.None
        dgv_Infractions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv_Infractions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Window
        DataGridViewCellStyle9.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle9.Padding = New Padding(0, 28, 0, 14)
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        dgv_Infractions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgv_Infractions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = SystemColors.Window
        DataGridViewCellStyle10.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False
        dgv_Infractions.DefaultCellStyle = DataGridViewCellStyle10
        dgv_Infractions.Dock = DockStyle.Fill
        dgv_Infractions.EnableHeadersVisualStyles = False
        dgv_Infractions.GridColor = SystemColors.InactiveBorder
        dgv_Infractions.Location = New Point(0, 0)
        dgv_Infractions.Name = "dgv_Infractions"
        dgv_Infractions.ReadOnly = True
        dgv_Infractions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_Infractions.RowHeadersVisible = False
        dgv_Infractions.RowTemplate.Height = 50
        dgv_Infractions.ScrollBars = ScrollBars.Vertical
        dgv_Infractions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_Infractions.ShowCellErrors = False
        dgv_Infractions.ShowCellToolTips = False
        dgv_Infractions.ShowEditingIcon = False
        dgv_Infractions.ShowRowErrors = False
        dgv_Infractions.Size = New Size(1319, 641)
        dgv_Infractions.TabIndex = 4
        ' 
        ' UCApplication
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        Controls.Add(MaterialCard1)
        DoubleBuffered = True
        Name = "UCApplication"
        Padding = New Padding(14, 14, 14, 5)
        Size = New Size(1387, 800)
        MaterialCard1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TabControl_Type.ResumeLayout(False)
        TabLeave.ResumeLayout(False)
        Panel_Leave.ResumeLayout(False)
        CType(pbLoader_Leave, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_Leave, ComponentModel.ISupportInitialize).EndInit()
        TabChangeShift.ResumeLayout(False)
        Panel_ChangeShift.ResumeLayout(False)
        CType(pbLoader_ChangeShift, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_ChangeShift, ComponentModel.ISupportInitialize).EndInit()
        TabOverTime.ResumeLayout(False)
        Panel_OverTime.ResumeLayout(False)
        CType(pbLoader_OverTime, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_OverTime, ComponentModel.ISupportInitialize).EndInit()
        TabLate.ResumeLayout(False)
        Panel_Late.ResumeLayout(False)
        CType(pbLoader_Late, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_Late, ComponentModel.ISupportInitialize).EndInit()
        TabInfractions.ResumeLayout(False)
        Panel_Infractions.ResumeLayout(False)
        CType(pbLoader_Infractions, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_Infractions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents Panel_Leave As Panel
    Friend WithEvents pbLoader_Leave As PictureBox
    Friend WithEvents dgv_Leave As DataGridView
    Friend WithEvents Panel_ChangeShift As Panel
    Friend WithEvents pbLoader_ChangeShift As PictureBox
    Friend WithEvents dgv_ChangeShift As DataGridView
    Friend WithEvents Panel_OverTime As Panel
    Friend WithEvents pbLoader_OverTime As PictureBox
    Friend WithEvents dgv_OverTime As DataGridView
    Friend WithEvents Panel_Late As Panel
    Friend WithEvents pbLoader_Late As PictureBox
    Friend WithEvents dgv_Late As DataGridView
    Friend WithEvents TabControl_Type As ReaLTaiizor.Controls.HopeTabPage
    Friend WithEvents TabLeave As TabPage
    Friend WithEvents TabChangeShift As TabPage
    Friend WithEvents TabOverTime As TabPage
    Friend WithEvents TabLate As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabInfractions As TabPage
    Friend WithEvents Panel_Infractions As Panel
    Friend WithEvents pbLoader_Infractions As PictureBox
    Friend WithEvents dgv_Infractions As DataGridView
End Class
