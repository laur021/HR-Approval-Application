<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddLeave
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
        Label1 = New Label()
        txtDescription = New ReaLTaiizor.Controls.PoisonTextBox()
        txtLeaveType = New ReaLTaiizor.Controls.PoisonTextBox()
        btnCancel = New MaterialSkin.Controls.MaterialButton()
        btnSave = New MaterialSkin.Controls.MaterialButton()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label2 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        MaterialCard1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 3)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 16)
        Label1.TabIndex = 2
        Label1.Text = "Type of Leave:"
        ' 
        ' txtDescription
        ' 
        ' 
        ' 
        ' 
        txtDescription.CustomButton.Image = Nothing
        txtDescription.CustomButton.Location = New Point(221, 2)
        txtDescription.CustomButton.Name = ""
        txtDescription.CustomButton.Size = New Size(105, 105)
        txtDescription.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        txtDescription.CustomButton.TabIndex = 1
        txtDescription.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        txtDescription.CustomButton.UseSelectable = True
        txtDescription.CustomButton.Visible = False
        txtDescription.DisplayIcon = True
        txtDescription.Dock = DockStyle.Fill
        txtDescription.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtDescription.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium
        txtDescription.IconRight = True
        txtDescription.Location = New Point(111, 48)
        txtDescription.Margin = New Padding(4, 6, 4, 6)
        txtDescription.MaxLength = 32767
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.PasswordChar = ChrW(0)
        txtDescription.ScrollBars = ScrollBars.None
        txtDescription.SelectedText = ""
        txtDescription.SelectionLength = 0
        txtDescription.SelectionStart = 0
        txtDescription.ShortcutsEnabled = True
        txtDescription.Size = New Size(329, 110)
        txtDescription.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        txtDescription.TabIndex = 2
        txtDescription.UseSelectable = True
        txtDescription.WaterMarkColor = Color.FromArgb(CByte(109), CByte(109), CByte(109))
        txtDescription.WaterMarkFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ' 
        ' txtLeaveType
        ' 
        ' 
        ' 
        ' 
        txtLeaveType.CustomButton.Image = Nothing
        txtLeaveType.CustomButton.Location = New Point(301, 2)
        txtLeaveType.CustomButton.Name = ""
        txtLeaveType.CustomButton.Size = New Size(25, 25)
        txtLeaveType.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        txtLeaveType.CustomButton.TabIndex = 1
        txtLeaveType.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        txtLeaveType.CustomButton.UseSelectable = True
        txtLeaveType.CustomButton.Visible = False
        txtLeaveType.DisplayIcon = True
        txtLeaveType.Dock = DockStyle.Fill
        txtLeaveType.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtLeaveType.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium
        txtLeaveType.IconRight = True
        txtLeaveType.Location = New Point(111, 6)
        txtLeaveType.Margin = New Padding(4, 6, 4, 6)
        txtLeaveType.MaxLength = 32767
        txtLeaveType.Name = "txtLeaveType"
        txtLeaveType.PasswordChar = ChrW(0)
        txtLeaveType.ScrollBars = ScrollBars.None
        txtLeaveType.SelectedText = ""
        txtLeaveType.SelectionLength = 0
        txtLeaveType.SelectionStart = 0
        txtLeaveType.ShortcutsEnabled = True
        txtLeaveType.Size = New Size(329, 30)
        txtLeaveType.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        txtLeaveType.TabIndex = 1
        txtLeaveType.UseSelectable = True
        txtLeaveType.WaterMarkColor = Color.FromArgb(CByte(109), CByte(109), CByte(109))
        txtLeaveType.WaterMarkFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ' 
        ' btnCancel
        ' 
        btnCancel.AutoSize = False
        btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnCancel.Depth = 0
        btnCancel.Dock = DockStyle.Fill
        btnCancel.HighEmphasis = True
        btnCancel.Icon = Nothing
        btnCancel.Location = New Point(169, 6)
        btnCancel.Margin = New Padding(4, 6, 4, 6)
        btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        btnCancel.Name = "btnCancel"
        btnCancel.NoAccentTextColor = Color.Empty
        btnCancel.Size = New Size(158, 30)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        btnCancel.UseAccentColor = False
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = False
        btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSave.Depth = 0
        btnSave.Dock = DockStyle.Fill
        btnSave.HighEmphasis = True
        btnSave.Icon = Nothing
        btnSave.Location = New Point(4, 6)
        btnSave.Margin = New Padding(4, 6, 4, 6)
        btnSave.MouseState = MaterialSkin.MouseState.HOVER
        btnSave.Name = "btnSave"
        btnSave.NoAccentTextColor = Color.Empty
        btnSave.Size = New Size(157, 30)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSave.UseAccentColor = False
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnCancel, 1, 0)
        TableLayoutPanel1.Controls.Add(btnSave, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(110, 167)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(331, 42)
        TableLayoutPanel1.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(3, 45)
        Label2.Margin = New Padding(3)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 16)
        Label2.TabIndex = 2
        Label2.Text = "Description:"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(MaterialCard1, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 24)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(500, 268)
        TableLayoutPanel3.TabIndex = 7
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(TableLayoutPanel4)
        MaterialCard1.Depth = 0
        MaterialCard1.Dock = DockStyle.Fill
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(14, 14)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(472, 240)
        MaterialCard1.TabIndex = 0
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.Controls.Add(Label2, 0, 1)
        TableLayoutPanel4.Controls.Add(Label1, 0, 0)
        TableLayoutPanel4.Controls.Add(txtLeaveType, 1, 0)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel1, 1, 2)
        TableLayoutPanel4.Controls.Add(txtDescription, 1, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(14, 14)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 3
        TableLayoutPanel4.RowStyles.Add(New RowStyle())
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle())
        TableLayoutPanel4.Size = New Size(444, 212)
        TableLayoutPanel4.TabIndex = 7
        ' 
        ' FormAddLeave
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(506, 295)
        Controls.Add(TableLayoutPanel3)
        FormStyle = FormStyles.ActionBar_None
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormAddLeave"
        Padding = New Padding(3, 24, 3, 3)
        Text = "FormAddLeave"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        MaterialCard1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescription As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtLeaveType As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
End Class
