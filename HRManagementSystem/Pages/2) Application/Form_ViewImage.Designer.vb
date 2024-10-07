<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ViewImage
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_ViewImage))
        TableLayoutPanel1 = New TableLayoutPanel()
        btnDownload = New ReaLTaiizor.Controls.MaterialButton()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        pbImage = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        MaterialCard1.SuspendLayout()
        CType(pbImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnDownload, 0, 1)
        TableLayoutPanel1.Controls.Add(MaterialCard1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 24)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 66F))
        TableLayoutPanel1.Size = New Size(745, 740)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnDownload
        ' 
        btnDownload.AutoSize = False
        btnDownload.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDownload.BackColor = Color.FromArgb(CByte(27), CByte(28), CByte(56))
        btnDownload.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title
        btnDownload.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default
        btnDownload.Depth = 0
        btnDownload.Dock = DockStyle.Fill
        btnDownload.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDownload.HighEmphasis = True
        btnDownload.Icon = My.Resources.Resources.icons8_file_download_24
        btnDownload.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase
        btnDownload.Location = New Point(14, 680)
        btnDownload.Margin = New Padding(14, 6, 14, 14)
        btnDownload.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnDownload.Name = "btnDownload"
        btnDownload.NoAccentTextColor = Color.Empty
        btnDownload.Size = New Size(717, 46)
        btnDownload.TabIndex = 4
        btnDownload.TabStop = False
        btnDownload.Text = "Download Photo"
        btnDownload.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        btnDownload.UseAccentColor = False
        btnDownload.UseVisualStyleBackColor = False
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(pbImage)
        MaterialCard1.Depth = 0
        MaterialCard1.Dock = DockStyle.Fill
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(14, 14)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(717, 646)
        MaterialCard1.TabIndex = 0
        ' 
        ' pbImage
        ' 
        pbImage.Dock = DockStyle.Fill
        pbImage.Location = New Point(14, 14)
        pbImage.Name = "pbImage"
        pbImage.Size = New Size(689, 618)
        pbImage.TabIndex = 0
        pbImage.TabStop = False
        ' 
        ' FormViewImage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(751, 767)
        Controls.Add(TableLayoutPanel1)
        FormStyle = FormStyles.ActionBar_None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "FormViewImage"
        Padding = New Padding(3, 24, 3, 3)
        TableLayoutPanel1.ResumeLayout(False)
        MaterialCard1.ResumeLayout(False)
        CType(pbImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btnDownload As ReaLTaiizor.Controls.MaterialButton
End Class
