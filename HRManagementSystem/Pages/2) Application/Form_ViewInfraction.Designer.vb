<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ViewInfraction
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ViewInfraction))
        TableLayoutPanel1 = New TableLayoutPanel()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblApplicationID = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblName = New Label()
        lblDepartment = New Label()
        lblDate = New Label()
        lblPosition = New Label()
        lblLeaveDetails = New Label()
        dgvInformation = New DataGridView()
        tblAttachment = New TableLayoutPanel()
        btnDownload = New ReaLTaiizor.Controls.MaterialButton()
        PanelFiles = New FlowLayoutPanel()
        PanelDivider = New Panel()
        tblPanelComment = New TableLayoutPanel()
        txtRemark = New ReaLTaiizor.Controls.PoisonTextBox()
        tblbutton = New TableLayoutPanel()
        btnApprove = New ReaLTaiizor.Controls.MaterialButton()
        btnReject = New ReaLTaiizor.Controls.MaterialButton()
        dgComments = New DataGridView()
        TableLayoutPanel9 = New TableLayoutPanel()
        PanelDividercomment = New Panel()
        pbExpand = New PictureBox()
        pbCollapse = New PictureBox()
        Panel2 = New Panel()
        Panel1 = New Panel()
        cardComment = New MaterialSkin.Controls.MaterialCard()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        BackgroundWorker3 = New ComponentModel.BackgroundWorker()
        BackgroundWorker4 = New ComponentModel.BackgroundWorker()
        TableLayoutPanel1.SuspendLayout()
        MaterialCard1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgvInformation, ComponentModel.ISupportInitialize).BeginInit()
        tblAttachment.SuspendLayout()
        tblPanelComment.SuspendLayout()
        tblbutton.SuspendLayout()
        CType(dgComments, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel9.SuspendLayout()
        PanelDividercomment.SuspendLayout()
        CType(pbExpand, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbCollapse, ComponentModel.ISupportInitialize).BeginInit()
        cardComment.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(MaterialCard1, 0, 0)
        TableLayoutPanel1.Controls.Add(tblbutton, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(657, 867)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(TableLayoutPanel2)
        MaterialCard1.Depth = 0
        MaterialCard1.Dock = DockStyle.Fill
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(14, 14)
        MaterialCard1.Margin = New Padding(14, 14, 2, 14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(641, 784)
        MaterialCard1.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(lblApplicationID, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 2)
        TableLayoutPanel2.Controls.Add(lblLeaveDetails, 0, 4)
        TableLayoutPanel2.Controls.Add(dgvInformation, 0, 6)
        TableLayoutPanel2.Controls.Add(tblAttachment, 0, 8)
        TableLayoutPanel2.Controls.Add(PanelDivider, 0, 7)
        TableLayoutPanel2.Controls.Add(tblPanelComment, 0, 9)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(14, 14)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 10
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 5F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 80F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 5F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 5F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(613, 756)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' lblApplicationID
        ' 
        lblApplicationID.AutoSize = True
        lblApplicationID.BackColor = SystemColors.InactiveBorder
        lblApplicationID.Dock = DockStyle.Fill
        lblApplicationID.Font = New Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblApplicationID.ForeColor = SystemColors.ControlDarkDark
        lblApplicationID.Location = New Point(3, 3)
        lblApplicationID.Margin = New Padding(3)
        lblApplicationID.Name = "lblApplicationID"
        lblApplicationID.Size = New Size(607, 44)
        lblApplicationID.TabIndex = 1
        lblApplicationID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 105F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 158F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(Label2, 0, 1)
        TableLayoutPanel3.Controls.Add(Label3, 2, 0)
        TableLayoutPanel3.Controls.Add(Label4, 2, 1)
        TableLayoutPanel3.Controls.Add(lblName, 1, 0)
        TableLayoutPanel3.Controls.Add(lblDepartment, 1, 1)
        TableLayoutPanel3.Controls.Add(lblDate, 3, 0)
        TableLayoutPanel3.Controls.Add(lblPosition, 3, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 58)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 49.03846F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.96154F))
        TableLayoutPanel3.Size = New Size(607, 74)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 11)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 14)
        Label1.TabIndex = 1
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(3, 48)
        Label2.Margin = New Padding(3)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 14)
        Label2.TabIndex = 1
        Label2.Text = "Department:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(280, 11)
        Label3.Margin = New Padding(3)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 14)
        Label3.TabIndex = 1
        Label3.Text = "Date of Application:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(280, 48)
        Label4.Margin = New Padding(3)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 14)
        Label4.TabIndex = 1
        Label4.Text = "Position:"
        ' 
        ' lblName
        ' 
        lblName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblName.AutoSize = True
        lblName.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.ForeColor = SystemColors.ControlDarkDark
        lblName.Location = New Point(108, 11)
        lblName.Margin = New Padding(3)
        lblName.Name = "lblName"
        lblName.Size = New Size(166, 14)
        lblName.TabIndex = 1
        ' 
        ' lblDepartment
        ' 
        lblDepartment.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDepartment.ForeColor = SystemColors.ControlDarkDark
        lblDepartment.Location = New Point(108, 48)
        lblDepartment.Margin = New Padding(3)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(166, 14)
        lblDepartment.TabIndex = 1
        ' 
        ' lblDate
        ' 
        lblDate.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDate.AutoSize = True
        lblDate.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDate.ForeColor = SystemColors.ControlDarkDark
        lblDate.Location = New Point(438, 11)
        lblDate.Margin = New Padding(3)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(166, 14)
        lblDate.TabIndex = 1
        ' 
        ' lblPosition
        ' 
        lblPosition.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblPosition.AutoSize = True
        lblPosition.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPosition.ForeColor = SystemColors.ControlDarkDark
        lblPosition.Location = New Point(438, 48)
        lblPosition.Margin = New Padding(3)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(166, 14)
        lblPosition.TabIndex = 1
        ' 
        ' lblLeaveDetails
        ' 
        lblLeaveDetails.AutoSize = True
        lblLeaveDetails.BackColor = SystemColors.InactiveBorder
        lblLeaveDetails.Dock = DockStyle.Fill
        lblLeaveDetails.Font = New Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblLeaveDetails.ForeColor = SystemColors.ControlDarkDark
        lblLeaveDetails.Location = New Point(3, 143)
        lblLeaveDetails.Margin = New Padding(3)
        lblLeaveDetails.Name = "lblLeaveDetails"
        lblLeaveDetails.Size = New Size(607, 44)
        lblLeaveDetails.TabIndex = 1
        lblLeaveDetails.Text = "Timekeeping Infraction Detail"
        lblLeaveDetails.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvInformation
        ' 
        dgvInformation.AllowUserToAddRows = False
        dgvInformation.AllowUserToDeleteRows = False
        dgvInformation.AllowUserToResizeColumns = False
        dgvInformation.AllowUserToResizeRows = False
        dgvInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInformation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvInformation.BackgroundColor = SystemColors.Window
        dgvInformation.BorderStyle = BorderStyle.None
        dgvInformation.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvInformation.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvInformation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvInformation.DefaultCellStyle = DataGridViewCellStyle2
        dgvInformation.Dock = DockStyle.Fill
        dgvInformation.EnableHeadersVisualStyles = False
        dgvInformation.GridColor = SystemColors.InactiveBorder
        dgvInformation.Location = New Point(3, 198)
        dgvInformation.Name = "dgvInformation"
        dgvInformation.ReadOnly = True
        dgvInformation.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvInformation.RowHeadersVisible = False
        dgvInformation.RowTemplate.Height = 25
        dgvInformation.ScrollBars = ScrollBars.Vertical
        dgvInformation.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvInformation.ShowCellErrors = False
        dgvInformation.ShowCellToolTips = False
        dgvInformation.ShowEditingIcon = False
        dgvInformation.ShowRowErrors = False
        dgvInformation.Size = New Size(607, 363)
        dgvInformation.TabIndex = 8
        ' 
        ' tblAttachment
        ' 
        tblAttachment.ColumnCount = 2
        tblAttachment.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 173F))
        tblAttachment.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.000008F))
        tblAttachment.Controls.Add(btnDownload, 0, 0)
        tblAttachment.Controls.Add(PanelFiles, 1, 0)
        tblAttachment.Dock = DockStyle.Fill
        tblAttachment.Location = New Point(3, 577)
        tblAttachment.Name = "tblAttachment"
        tblAttachment.RowCount = 1
        tblAttachment.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblAttachment.Size = New Size(607, 70)
        tblAttachment.TabIndex = 9
        ' 
        ' btnDownload
        ' 
        btnDownload.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnDownload.AutoSize = False
        btnDownload.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDownload.BackColor = Color.FromArgb(CByte(27), CByte(28), CByte(56))
        btnDownload.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title
        btnDownload.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default
        btnDownload.Depth = 0
        btnDownload.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDownload.HighEmphasis = True
        btnDownload.Icon = My.Resources.Resources.icons8_file_download_24
        btnDownload.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase
        btnDownload.Location = New Point(4, 6)
        btnDownload.Margin = New Padding(4, 6, 4, 6)
        btnDownload.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnDownload.Name = "btnDownload"
        btnDownload.NoAccentTextColor = Color.Empty
        btnDownload.Size = New Size(165, 36)
        btnDownload.TabIndex = 3
        btnDownload.Text = "Download Files"
        btnDownload.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        btnDownload.UseAccentColor = False
        btnDownload.UseVisualStyleBackColor = False
        ' 
        ' PanelFiles
        ' 
        PanelFiles.AutoScroll = True
        PanelFiles.Dock = DockStyle.Fill
        PanelFiles.Location = New Point(176, 3)
        PanelFiles.Name = "PanelFiles"
        PanelFiles.Size = New Size(428, 64)
        PanelFiles.TabIndex = 4
        ' 
        ' PanelDivider
        ' 
        PanelDivider.BackColor = SystemColors.InactiveBorder
        PanelDivider.Dock = DockStyle.Fill
        PanelDivider.Location = New Point(3, 564)
        PanelDivider.Margin = New Padding(3, 0, 3, 0)
        PanelDivider.Name = "PanelDivider"
        PanelDivider.Size = New Size(607, 10)
        PanelDivider.TabIndex = 11
        ' 
        ' tblPanelComment
        ' 
        tblPanelComment.ColumnCount = 1
        tblPanelComment.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tblPanelComment.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        tblPanelComment.Controls.Add(txtRemark, 0, 0)
        tblPanelComment.Dock = DockStyle.Fill
        tblPanelComment.Location = New Point(3, 653)
        tblPanelComment.Name = "tblPanelComment"
        tblPanelComment.RowCount = 1
        tblPanelComment.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblPanelComment.Size = New Size(607, 100)
        tblPanelComment.TabIndex = 10
        ' 
        ' txtRemark
        ' 
        ' 
        ' 
        ' 
        txtRemark.CustomButton.Image = Nothing
        txtRemark.CustomButton.Location = New Point(509, 2)
        txtRemark.CustomButton.Name = ""
        txtRemark.CustomButton.Size = New Size(89, 89)
        txtRemark.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        txtRemark.CustomButton.TabIndex = 1
        txtRemark.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        txtRemark.CustomButton.UseSelectable = True
        txtRemark.CustomButton.Visible = False
        txtRemark.Dock = DockStyle.Fill
        txtRemark.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtRemark.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium
        txtRemark.Location = New Point(3, 3)
        txtRemark.MaxLength = 32767
        txtRemark.Multiline = True
        txtRemark.Name = "txtRemark"
        txtRemark.PasswordChar = ChrW(0)
        txtRemark.ScrollBars = ScrollBars.None
        txtRemark.SelectedText = ""
        txtRemark.SelectionLength = 0
        txtRemark.SelectionStart = 0
        txtRemark.ShortcutsEnabled = True
        txtRemark.Size = New Size(601, 94)
        txtRemark.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        txtRemark.TabIndex = 2
        txtRemark.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        txtRemark.UseSelectable = True
        txtRemark.WaterMarkColor = Color.FromArgb(CByte(109), CByte(109), CByte(109))
        txtRemark.WaterMarkFont = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        ' 
        ' tblbutton
        ' 
        tblbutton.ColumnCount = 3
        tblbutton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tblbutton.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        tblbutton.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        tblbutton.Controls.Add(btnApprove, 1, 0)
        tblbutton.Controls.Add(btnReject, 2, 0)
        tblbutton.Dock = DockStyle.Fill
        tblbutton.Location = New Point(3, 815)
        tblbutton.Margin = New Padding(3, 3, 0, 3)
        tblbutton.Name = "tblbutton"
        tblbutton.RowCount = 1
        tblbutton.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblbutton.Size = New Size(654, 49)
        tblbutton.TabIndex = 2
        ' 
        ' btnApprove
        ' 
        btnApprove.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnApprove.AutoSize = False
        btnApprove.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnApprove.BackColor = Color.FromArgb(CByte(27), CByte(28), CByte(56))
        btnApprove.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title
        btnApprove.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default
        btnApprove.Depth = 0
        btnApprove.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnApprove.HighEmphasis = True
        btnApprove.Icon = My.Resources.Resources.icons8_thumbs_up_241
        btnApprove.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase
        btnApprove.Location = New Point(358, 6)
        btnApprove.Margin = New Padding(4, 6, 0, 6)
        btnApprove.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnApprove.Name = "btnApprove"
        btnApprove.NoAccentTextColor = Color.Empty
        btnApprove.Size = New Size(146, 33)
        btnApprove.TabIndex = 3
        btnApprove.Text = "Approve"
        btnApprove.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        btnApprove.UseAccentColor = False
        btnApprove.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnReject.AutoSize = False
        btnReject.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReject.BackColor = Color.FromArgb(CByte(27), CByte(28), CByte(56))
        btnReject.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title
        btnReject.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default
        btnReject.Depth = 0
        btnReject.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnReject.HighEmphasis = True
        btnReject.Icon = My.Resources.Resources.icons8_thumbs_down_241
        btnReject.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase
        btnReject.Location = New Point(508, 6)
        btnReject.Margin = New Padding(4, 6, 0, 6)
        btnReject.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnReject.Name = "btnReject"
        btnReject.NoAccentTextColor = Color.Empty
        btnReject.Size = New Size(146, 33)
        btnReject.TabIndex = 3
        btnReject.Text = "Reject"
        btnReject.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined
        btnReject.UseAccentColor = False
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' dgComments
        ' 
        dgComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgComments.BackgroundColor = SystemColors.Window
        dgComments.BorderStyle = BorderStyle.None
        dgComments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgComments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgComments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgComments.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgComments.DefaultCellStyle = DataGridViewCellStyle3
        dgComments.Dock = DockStyle.Fill
        dgComments.GridColor = SystemColors.InactiveBorder
        dgComments.Location = New Point(14, 14)
        dgComments.Name = "dgComments"
        dgComments.ReadOnly = True
        dgComments.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgComments.RowHeadersVisible = False
        dgComments.RowTemplate.Height = 25
        dgComments.ScrollBars = ScrollBars.Vertical
        dgComments.ShowCellErrors = False
        dgComments.ShowCellToolTips = False
        dgComments.ShowEditingIcon = False
        dgComments.ShowRowErrors = False
        dgComments.Size = New Size(552, 811)
        dgComments.TabIndex = 5
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 3
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel9.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel9.Controls.Add(PanelDividercomment, 1, 0)
        TableLayoutPanel9.Controls.Add(cardComment, 2, 0)
        TableLayoutPanel9.Dock = DockStyle.Fill
        TableLayoutPanel9.Location = New Point(3, 24)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 1
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel9.Size = New Size(1294, 873)
        TableLayoutPanel9.TabIndex = 4
        ' 
        ' PanelDividercomment
        ' 
        PanelDividercomment.Controls.Add(pbCollapse)
        PanelDividercomment.Controls.Add(pbExpand)
        PanelDividercomment.Controls.Add(Panel1)
        PanelDividercomment.Controls.Add(Panel2)
        PanelDividercomment.Dock = DockStyle.Fill
        PanelDividercomment.Location = New Point(663, 0)
        PanelDividercomment.Margin = New Padding(0)
        PanelDividercomment.Name = "PanelDividercomment"
        PanelDividercomment.Size = New Size(30, 873)
        PanelDividercomment.TabIndex = 4
        ' 
        ' pbExpand
        ' 
        pbExpand.Image = My.Resources.Resources.icons8_collapse_arrow_64
        pbExpand.Location = New Point(0, 423)
        pbExpand.Name = "pbExpand"
        pbExpand.Size = New Size(30, 30)
        pbExpand.SizeMode = PictureBoxSizeMode.Zoom
        pbExpand.TabIndex = 2
        pbExpand.TabStop = False
        ' 
        ' pbCollapse
        ' 
        pbCollapse.Image = My.Resources.Resources.icons8_expand_arrow_64
        pbCollapse.Location = New Point(0, 423)
        pbCollapse.Name = "pbCollapse"
        pbCollapse.Size = New Size(30, 30)
        pbCollapse.SizeMode = PictureBoxSizeMode.Zoom
        pbCollapse.TabIndex = 3
        pbCollapse.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Location = New Point(13, 454)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(5, 400)
        Panel2.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Location = New Point(13, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(5, 400)
        Panel1.TabIndex = 0
        ' 
        ' cardComment
        ' 
        cardComment.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cardComment.Controls.Add(dgComments)
        cardComment.Depth = 0
        cardComment.Dock = DockStyle.Fill
        cardComment.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cardComment.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cardComment.Location = New Point(700, 17)
        cardComment.Margin = New Padding(7, 17, 14, 17)
        cardComment.MouseState = MaterialSkin.MouseState.HOVER
        cardComment.Name = "cardComment"
        cardComment.Padding = New Padding(14)
        cardComment.Size = New Size(580, 839)
        cardComment.TabIndex = 5
        ' 
        ' BackgroundWorker1
        ' 
        ' 
        ' BackgroundWorker2
        ' 
        ' 
        ' BackgroundWorker3
        ' 
        ' 
        ' BackgroundWorker4
        ' 
        ' 
        ' Form_ViewInfraction
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1300, 900)
        Controls.Add(TableLayoutPanel9)
        FormStyle = FormStyles.ActionBar_None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form_ViewInfraction"
        Padding = New Padding(3, 24, 3, 3)
        Sizable = False
        TableLayoutPanel1.ResumeLayout(False)
        MaterialCard1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(dgvInformation, ComponentModel.ISupportInitialize).EndInit()
        tblAttachment.ResumeLayout(False)
        tblPanelComment.ResumeLayout(False)
        tblbutton.ResumeLayout(False)
        CType(dgComments, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel9.ResumeLayout(False)
        PanelDividercomment.ResumeLayout(False)
        CType(pbExpand, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCollapse, ComponentModel.ISupportInitialize).EndInit()
        cardComment.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblApplicationID As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblLeaveDetails As Label
    Friend WithEvents dgvInformation As DataGridView
    Friend WithEvents tblAttachment As TableLayoutPanel
    Friend WithEvents btnDownload As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents PanelFiles As FlowLayoutPanel
    Friend WithEvents tblPanelComment As TableLayoutPanel
    Friend WithEvents tblbutton As TableLayoutPanel
    Friend WithEvents btnApprove As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents btnReject As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents PanelDividercomment As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbCollapse As PictureBox
    Friend WithEvents pbExpand As PictureBox
    Friend WithEvents dgComments As DataGridView
    Friend WithEvents cardComment As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtRemark As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelDivider As Panel
End Class
