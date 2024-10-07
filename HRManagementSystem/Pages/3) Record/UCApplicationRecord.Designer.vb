<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRecord
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MaterialCard1 = New ReaLTaiizor.Controls.MaterialCard()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        Panel1 = New Panel()
        TableLayoutPanel4 = New TableLayoutPanel()
        dtpTo = New ReaLTaiizor.Controls.PoisonDateTime()
        dtpFrom = New ReaLTaiizor.Controls.PoisonDateTime()
        Label5 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        cmbFilter = New ReaLTaiizor.Controls.PoisonComboBox()
        txtSearchbar = New ReaLTaiizor.Controls.PoisonTextBox()
        btnExport = New MaterialSkin.Controls.MaterialButton()
        btnRefresh = New MaterialSkin.Controls.MaterialButton()
        btnSearch = New MaterialSkin.Controls.MaterialButton()
        cmbcategory = New ReaLTaiizor.Controls.PoisonComboBox()
        cmbSubCategory = New ReaLTaiizor.Controls.PoisonComboBox()
        Panel2 = New Panel()
        pbLoader_Record = New PictureBox()
        dgvRecord = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        MaterialCard1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        Panel2.SuspendLayout()
        CType(pbLoader_Record, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvRecord, ComponentModel.ISupportInitialize).BeginInit()
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
        MaterialCard1.Size = New Size(1472, 781)
        MaterialCard1.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(Panel1, 0, 3)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel3.Controls.Add(Panel2, 0, 2)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(14, 14)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 5
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 7F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel3.Size = New Size(1444, 753)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 14)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 22)
        Label1.TabIndex = 2
        Label1.Text = "All Application Records"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.InactiveBorder
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 706)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1444, 7)
        Panel1.TabIndex = 4
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 12
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 80F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel4.Controls.Add(dtpTo, 3, 0)
        TableLayoutPanel4.Controls.Add(dtpFrom, 1, 0)
        TableLayoutPanel4.Controls.Add(Label5, 4, 0)
        TableLayoutPanel4.Controls.Add(Label2, 2, 0)
        TableLayoutPanel4.Controls.Add(Label4, 0, 0)
        TableLayoutPanel4.Controls.Add(cmbFilter, 5, 0)
        TableLayoutPanel4.Controls.Add(txtSearchbar, 6, 0)
        TableLayoutPanel4.Controls.Add(btnExport, 11, 0)
        TableLayoutPanel4.Controls.Add(btnRefresh, 10, 0)
        TableLayoutPanel4.Controls.Add(btnSearch, 9, 0)
        TableLayoutPanel4.Controls.Add(cmbcategory, 7, 0)
        TableLayoutPanel4.Controls.Add(cmbSubCategory, 8, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 50)
        TableLayoutPanel4.Margin = New Padding(0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(1444, 50)
        TableLayoutPanel4.TabIndex = 10
        ' 
        ' dtpTo
        ' 
        dtpTo.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpTo.Format = DateTimePickerFormat.Short
        dtpTo.Location = New Point(239, 10)
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
        dtpFrom.Location = New Point(49, 10)
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
        Label5.Location = New Point(406, 17)
        Label5.Margin = New Padding(3)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 2
        Label5.Text = "Filtery by:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(199, 17)
        Label2.Margin = New Padding(3)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
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
        Label4.Location = New Point(4, 17)
        Label4.Margin = New Padding(3)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 2
        Label4.Text = "From:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbFilter
        ' 
        cmbFilter.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmbFilter.FormattingEnabled = True
        cmbFilter.ItemHeight = 23
        cmbFilter.Items.AddRange(New Object() {"Application ID", "Application Type", "Department", "Name", "Status"})
        cmbFilter.Location = New Point(469, 10)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(144, 29)
        cmbFilter.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        cmbFilter.TabIndex = 18
        cmbFilter.UseSelectable = True
        ' 
        ' txtSearchbar
        ' 
        txtSearchbar.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ' 
        ' 
        ' 
        txtSearchbar.CustomButton.Image = Nothing
        txtSearchbar.CustomButton.Location = New Point(142, 1)
        txtSearchbar.CustomButton.Name = ""
        txtSearchbar.CustomButton.Size = New Size(27, 27)
        txtSearchbar.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        txtSearchbar.CustomButton.TabIndex = 1
        txtSearchbar.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        txtSearchbar.CustomButton.UseSelectable = True
        txtSearchbar.CustomButton.Visible = False
        txtSearchbar.DisplayIcon = True
        txtSearchbar.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearchbar.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium
        txtSearchbar.IconRight = True
        txtSearchbar.Location = New Point(619, 10)
        txtSearchbar.MaxLength = 32767
        txtSearchbar.Name = "txtSearchbar"
        txtSearchbar.PasswordChar = ChrW(0)
        txtSearchbar.PromptText = "Search ID"
        txtSearchbar.ScrollBars = ScrollBars.None
        txtSearchbar.SelectedText = ""
        txtSearchbar.SelectionLength = 0
        txtSearchbar.SelectionStart = 0
        txtSearchbar.ShortcutsEnabled = True
        txtSearchbar.Size = New Size(170, 29)
        txtSearchbar.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        txtSearchbar.TabIndex = 19
        txtSearchbar.UseSelectable = True
        txtSearchbar.WaterMark = "Search ID"
        txtSearchbar.WaterMarkColor = Color.FromArgb(CByte(109), CByte(109), CByte(109))
        txtSearchbar.WaterMarkFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
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
        btnExport.Location = New Point(1348, 10)
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
        btnRefresh.Location = New Point(1248, 10)
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
        btnSearch.Location = New Point(1148, 10)
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
        ' cmbcategory
        ' 
        cmbcategory.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmbcategory.FormattingEnabled = True
        cmbcategory.ItemHeight = 23
        cmbcategory.Location = New Point(795, 10)
        cmbcategory.Name = "cmbcategory"
        cmbcategory.Size = New Size(170, 29)
        cmbcategory.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        cmbcategory.TabIndex = 18
        cmbcategory.UseSelectable = True
        cmbcategory.Visible = False
        ' 
        ' cmbSubCategory
        ' 
        cmbSubCategory.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmbSubCategory.FormattingEnabled = True
        cmbSubCategory.ItemHeight = 23
        cmbSubCategory.Location = New Point(971, 10)
        cmbSubCategory.Name = "cmbSubCategory"
        cmbSubCategory.Size = New Size(170, 29)
        cmbSubCategory.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        cmbSubCategory.TabIndex = 18
        cmbSubCategory.UseSelectable = True
        cmbSubCategory.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(pbLoader_Record)
        Panel2.Controls.Add(dgvRecord)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 100)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1444, 606)
        Panel2.TabIndex = 11
        ' 
        ' pbLoader_Record
        ' 
        pbLoader_Record.BackColor = Color.Transparent
        pbLoader_Record.Dock = DockStyle.Fill
        pbLoader_Record.Image = My.Resources.Resources.preloader2
        pbLoader_Record.Location = New Point(0, 0)
        pbLoader_Record.Name = "pbLoader_Record"
        pbLoader_Record.Size = New Size(1444, 606)
        pbLoader_Record.SizeMode = PictureBoxSizeMode.CenterImage
        pbLoader_Record.TabIndex = 14
        pbLoader_Record.TabStop = False
        pbLoader_Record.Visible = False
        ' 
        ' dgvRecord
        ' 
        dgvRecord.AllowUserToAddRows = False
        dgvRecord.AllowUserToDeleteRows = False
        dgvRecord.AllowUserToResizeColumns = False
        dgvRecord.AllowUserToResizeRows = False
        dgvRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecord.BackgroundColor = SystemColors.Window
        dgvRecord.BorderStyle = BorderStyle.None
        dgvRecord.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRecord.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Padding = New Padding(0, 28, 0, 14)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRecord.DefaultCellStyle = DataGridViewCellStyle2
        dgvRecord.Dock = DockStyle.Fill
        dgvRecord.EnableHeadersVisualStyles = False
        dgvRecord.GridColor = SystemColors.InactiveBorder
        dgvRecord.Location = New Point(0, 0)
        dgvRecord.Name = "dgvRecord"
        dgvRecord.ReadOnly = True
        dgvRecord.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvRecord.RowHeadersVisible = False
        dgvRecord.RowTemplate.Height = 50
        dgvRecord.ScrollBars = ScrollBars.Vertical
        dgvRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecord.ShowCellErrors = False
        dgvRecord.ShowCellToolTips = False
        dgvRecord.ShowEditingIcon = False
        dgvRecord.ShowRowErrors = False
        dgvRecord.Size = New Size(1444, 606)
        dgvRecord.TabIndex = 12
        ' 
        ' UCRecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MaterialCard1)
        DoubleBuffered = True
        Name = "UCRecord"
        Padding = New Padding(14, 14, 14, 5)
        Size = New Size(1500, 800)
        MaterialCard1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(pbLoader_Record, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvRecord, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MaterialCard1 As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dgvRecord As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dtpTo As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents dtpFrom As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbFilter As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents txtSearchbar As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnRefresh As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmbcategory As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbLoader_Record As PictureBox
    Friend WithEvents cmbSubCategory As ReaLTaiizor.Controls.PoisonComboBox
End Class
