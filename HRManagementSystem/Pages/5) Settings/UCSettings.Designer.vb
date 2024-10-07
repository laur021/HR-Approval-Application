<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSettings
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
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        HopeGroupBox1 = New ReaLTaiizor.Controls.HopeGroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        dgvLeaveSettings = New DataGridView()
        btnAdd = New MaterialSkin.Controls.MaterialButton()
        Label3 = New Label()
        HopeGroupBox3 = New ReaLTaiizor.Controls.HopeGroupBox()
        PanelPolicy = New TableLayoutPanel()
        btnView = New MaterialSkin.Controls.MaterialButton()
        llblFilename = New LinkLabel()
        PanelPDFPreview = New TableLayoutPanel()
        HopeGroupBox2 = New ReaLTaiizor.Controls.HopeGroupBox()
        PanelPDF = New Panel()
        Label1 = New Label()
        MaterialCard1 = New ReaLTaiizor.Controls.MaterialCard()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        HopeGroupBox1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgvLeaveSettings, ComponentModel.ISupportInitialize).BeginInit()
        HopeGroupBox3.SuspendLayout()
        PanelPolicy.SuspendLayout()
        PanelPDFPreview.SuspendLayout()
        HopeGroupBox2.SuspendLayout()
        MaterialCard1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(14, 14)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1331, 753)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 10F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.Controls.Add(TableLayoutPanel7, 0, 0)
        TableLayoutPanel4.Controls.Add(PanelPDFPreview, 2, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 53)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(1325, 697)
        TableLayoutPanel4.TabIndex = 3
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 1
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Controls.Add(HopeGroupBox1, 0, 0)
        TableLayoutPanel7.Controls.Add(Label3, 0, 2)
        TableLayoutPanel7.Controls.Add(HopeGroupBox3, 0, 3)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(3, 3)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 4
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 10F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle())
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel7.Size = New Size(683, 691)
        TableLayoutPanel7.TabIndex = 24
        ' 
        ' HopeGroupBox1
        ' 
        HopeGroupBox1.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox1.Controls.Add(TableLayoutPanel3)
        HopeGroupBox1.Dock = DockStyle.Fill
        HopeGroupBox1.FlatStyle = FlatStyle.Flat
        HopeGroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HopeGroupBox1.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        HopeGroupBox1.LineColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox1.Location = New Point(3, 3)
        HopeGroupBox1.Name = "HopeGroupBox1"
        HopeGroupBox1.Padding = New Padding(20, 0, 20, 20)
        HopeGroupBox1.ShowText = False
        HopeGroupBox1.Size = New Size(677, 545)
        HopeGroupBox1.TabIndex = 22
        HopeGroupBox1.TabStop = False
        HopeGroupBox1.Text = "Manage Leaves"
        HopeGroupBox1.ThemeColor = Color.White
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(dgvLeaveSettings, 0, 1)
        TableLayoutPanel3.Controls.Add(btnAdd, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(20, 22)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle())
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(637, 503)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' dgvLeaveSettings
        ' 
        dgvLeaveSettings.AllowUserToAddRows = False
        dgvLeaveSettings.AllowUserToDeleteRows = False
        dgvLeaveSettings.AllowUserToResizeColumns = False
        dgvLeaveSettings.AllowUserToResizeRows = False
        dgvLeaveSettings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLeaveSettings.BackgroundColor = SystemColors.Window
        dgvLeaveSettings.BorderStyle = BorderStyle.None
        dgvLeaveSettings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvLeaveSettings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Padding = New Padding(0, 14, 0, 14)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvLeaveSettings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvLeaveSettings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.InactiveBorder
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvLeaveSettings.DefaultCellStyle = DataGridViewCellStyle2
        dgvLeaveSettings.Dock = DockStyle.Fill
        dgvLeaveSettings.EnableHeadersVisualStyles = False
        dgvLeaveSettings.GridColor = SystemColors.InactiveBorder
        dgvLeaveSettings.Location = New Point(3, 45)
        dgvLeaveSettings.Name = "dgvLeaveSettings"
        dgvLeaveSettings.ReadOnly = True
        dgvLeaveSettings.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvLeaveSettings.RowHeadersVisible = False
        dgvLeaveSettings.RowTemplate.Height = 50
        dgvLeaveSettings.ScrollBars = ScrollBars.Vertical
        dgvLeaveSettings.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLeaveSettings.ShowCellErrors = False
        dgvLeaveSettings.ShowCellToolTips = False
        dgvLeaveSettings.ShowEditingIcon = False
        dgvLeaveSettings.ShowRowErrors = False
        dgvLeaveSettings.Size = New Size(631, 455)
        dgvLeaveSettings.TabIndex = 5
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Left
        btnAdd.AutoSize = False
        btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAdd.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal
        btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAdd.Depth = 0
        btnAdd.HighEmphasis = True
        btnAdd.Icon = Nothing
        btnAdd.Location = New Point(4, 6)
        btnAdd.Margin = New Padding(4, 6, 4, 6)
        btnAdd.MouseState = MaterialSkin.MouseState.HOVER
        btnAdd.Name = "btnAdd"
        btnAdd.NoAccentTextColor = Color.Empty
        btnAdd.Size = New Size(118, 30)
        btnAdd.TabIndex = 21
        btnAdd.Text = "Add New Leave"
        btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnAdd.UseAccentColor = False
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(3, 568)
        Label3.Margin = New Padding(3)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 16)
        Label3.TabIndex = 2
        Label3.Text = "Manage Leave Policy"
        ' 
        ' HopeGroupBox3
        ' 
        HopeGroupBox3.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox3.Controls.Add(PanelPolicy)
        HopeGroupBox3.Dock = DockStyle.Fill
        HopeGroupBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HopeGroupBox3.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        HopeGroupBox3.LineColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox3.Location = New Point(3, 594)
        HopeGroupBox3.Name = "HopeGroupBox3"
        HopeGroupBox3.Padding = New Padding(20, 0, 20, 20)
        HopeGroupBox3.ShowText = False
        HopeGroupBox3.Size = New Size(677, 94)
        HopeGroupBox3.TabIndex = 23
        HopeGroupBox3.TabStop = False
        HopeGroupBox3.Text = "HopeGroupBox3"
        HopeGroupBox3.ThemeColor = Color.White
        ' 
        ' PanelPolicy
        ' 
        PanelPolicy.ColumnCount = 1
        PanelPolicy.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        PanelPolicy.Controls.Add(btnView, 0, 1)
        PanelPolicy.Controls.Add(llblFilename, 1, 0)
        PanelPolicy.Dock = DockStyle.Fill
        PanelPolicy.Location = New Point(20, 22)
        PanelPolicy.Margin = New Padding(0)
        PanelPolicy.Name = "PanelPolicy"
        PanelPolicy.RowCount = 2
        PanelPolicy.RowStyles.Add(New RowStyle(SizeType.Percent, 38.46154F))
        PanelPolicy.RowStyles.Add(New RowStyle(SizeType.Percent, 61.53846F))
        PanelPolicy.Size = New Size(637, 52)
        PanelPolicy.TabIndex = 22
        ' 
        ' btnView
        ' 
        btnView.Anchor = AnchorStyles.None
        btnView.AutoSize = False
        btnView.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnView.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal
        btnView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnView.Depth = 0
        btnView.HighEmphasis = True
        btnView.Icon = Nothing
        btnView.Location = New Point(268, 23)
        btnView.Margin = New Padding(0)
        btnView.MouseState = MaterialSkin.MouseState.HOVER
        btnView.Name = "btnView"
        btnView.NoAccentTextColor = Color.Empty
        btnView.Size = New Size(100, 26)
        btnView.TabIndex = 21
        btnView.Text = "View File"
        btnView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        btnView.UseAccentColor = False
        btnView.UseVisualStyleBackColor = True
        ' 
        ' llblFilename
        ' 
        llblFilename.Anchor = AnchorStyles.None
        llblFilename.AutoSize = True
        llblFilename.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        llblFilename.LinkColor = Color.FromArgb(CByte(63), CByte(81), CByte(181))
        llblFilename.Location = New Point(272, 2)
        llblFilename.Name = "llblFilename"
        llblFilename.Size = New Size(93, 15)
        llblFilename.TabIndex = 22
        llblFilename.TabStop = True
        llblFilename.Text = "Select PDF File"
        llblFilename.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelPDFPreview
        ' 
        PanelPDFPreview.ColumnCount = 1
        PanelPDFPreview.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        PanelPDFPreview.Controls.Add(HopeGroupBox2, 0, 0)
        PanelPDFPreview.Dock = DockStyle.Fill
        PanelPDFPreview.Location = New Point(702, 3)
        PanelPDFPreview.Name = "PanelPDFPreview"
        PanelPDFPreview.RowCount = 1
        PanelPDFPreview.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        PanelPDFPreview.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        PanelPDFPreview.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        PanelPDFPreview.Size = New Size(620, 691)
        PanelPDFPreview.TabIndex = 25
        PanelPDFPreview.Visible = False
        ' 
        ' HopeGroupBox2
        ' 
        HopeGroupBox2.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox2.Controls.Add(PanelPDF)
        HopeGroupBox2.Dock = DockStyle.Fill
        HopeGroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HopeGroupBox2.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        HopeGroupBox2.LineColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox2.Location = New Point(3, 3)
        HopeGroupBox2.Name = "HopeGroupBox2"
        HopeGroupBox2.Padding = New Padding(20, 0, 20, 20)
        HopeGroupBox2.ShowText = False
        HopeGroupBox2.Size = New Size(614, 685)
        HopeGroupBox2.TabIndex = 23
        HopeGroupBox2.TabStop = False
        HopeGroupBox2.Text = "HopeGroupBox2"
        HopeGroupBox2.ThemeColor = Color.White
        ' 
        ' PanelPDF
        ' 
        PanelPDF.Dock = DockStyle.Fill
        PanelPDF.Location = New Point(20, 22)
        PanelPDF.Name = "PanelPDF"
        PanelPDF.Size = New Size(574, 643)
        PanelPDF.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 22)
        Label1.TabIndex = 2
        Label1.Text = "Settings"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(TableLayoutPanel2)
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
        ' UCSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MaterialCard1)
        DoubleBuffered = True
        Name = "UCSettings"
        Padding = New Padding(14, 14, 14, 5)
        Size = New Size(1387, 800)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        HopeGroupBox1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        CType(dgvLeaveSettings, ComponentModel.ISupportInitialize).EndInit()
        HopeGroupBox3.ResumeLayout(False)
        PanelPolicy.ResumeLayout(False)
        PanelPolicy.PerformLayout()
        PanelPDFPreview.ResumeLayout(False)
        HopeGroupBox2.ResumeLayout(False)
        MaterialCard1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgvLeaveSettings As DataGridView
    Friend WithEvents btnAdd As MaterialSkin.Controls.MaterialButton
    Friend WithEvents HopeGroupBox1 As ReaLTaiizor.Controls.HopeGroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents HopeGroupBox2 As ReaLTaiizor.Controls.HopeGroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents PanelPolicy As TableLayoutPanel
    Friend WithEvents btnView As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PanelPDF As Panel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents HopeGroupBox3 As ReaLTaiizor.Controls.HopeGroupBox
    Friend WithEvents PanelPDFPreview As TableLayoutPanel
    Friend WithEvents llblFilename As LinkLabel
    Friend WithEvents MaterialCard1 As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents Label1 As Label
End Class
