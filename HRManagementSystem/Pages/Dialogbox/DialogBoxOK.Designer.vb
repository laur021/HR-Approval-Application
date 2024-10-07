<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogBoxOK
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
        TableLayoutPanel1 = New TableLayoutPanel()
        title = New Label()
        message = New Label()
        picturebox = New PictureBox()
        btnOk = New MaterialSkin.Controls.MaterialButton()
        TableLayoutPanel1.SuspendLayout()
        CType(picturebox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(title, 0, 2)
        TableLayoutPanel1.Controls.Add(message, 0, 3)
        TableLayoutPanel1.Controls.Add(picturebox, 0, 1)
        TableLayoutPanel1.Controls.Add(btnOk, 0, 4)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.623109F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 44.50025F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.9802828F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 34.89636F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.Size = New Size(473, 275)
        TableLayoutPanel1.TabIndex = 7
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Dock = DockStyle.Fill
        title.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        title.ForeColor = Color.FromArgb(CByte(20), CByte(98), CByte(189))
        title.Location = New Point(3, 107)
        title.Name = "title"
        title.Size = New Size(467, 32)
        title.TabIndex = 0
        title.Text = "INFORMATION"
        title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' message
        ' 
        message.AutoSize = True
        message.Dock = DockStyle.Fill
        message.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        message.ForeColor = SystemColors.ControlDarkDark
        message.Location = New Point(3, 139)
        message.Name = "message"
        message.Size = New Size(467, 75)
        message.TabIndex = 1
        message.Text = "Please input a number."
        message.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picturebox
        ' 
        picturebox.Dock = DockStyle.Fill
        picturebox.Image = My.Resources.Resources.icons8_question_mark_96
        picturebox.Location = New Point(3, 15)
        picturebox.Name = "picturebox"
        picturebox.Size = New Size(467, 89)
        picturebox.SizeMode = PictureBoxSizeMode.CenterImage
        picturebox.TabIndex = 2
        picturebox.TabStop = False
        ' 
        ' btnOk
        ' 
        btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnOk.Depth = 0
        btnOk.Dock = DockStyle.Fill
        btnOk.HighEmphasis = True
        btnOk.Icon = Nothing
        btnOk.Location = New Point(4, 220)
        btnOk.Margin = New Padding(4, 6, 4, 6)
        btnOk.MouseState = MaterialSkin.MouseState.HOVER
        btnOk.Name = "btnOk"
        btnOk.NoAccentTextColor = Color.Empty
        btnOk.Size = New Size(465, 49)
        btnOk.TabIndex = 3
        btnOk.Text = "Ok"
        btnOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnOk.UseAccentColor = False
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' DialogBoxOK
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(479, 281)
        Controls.Add(TableLayoutPanel1)
        FormStyle = FormStyles.StatusAndActionBar_None
        MaximizeBox = False
        MinimizeBox = False
        Name = "DialogBoxOK"
        Padding = New Padding(3)
        ShowInTaskbar = False
        Sizable = False
        Text = "DialogBoxOK"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(picturebox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents title As Label
    Friend WithEvents message As Label
    Friend WithEvents picturebox As PictureBox
    Friend WithEvents btnOk As MaterialSkin.Controls.MaterialButton
End Class
