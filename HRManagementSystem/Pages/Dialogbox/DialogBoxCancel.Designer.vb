<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogBoxCancel
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
        PictureBox2 = New PictureBox()
        btnYes = New MaterialSkin.Controls.MaterialButton()
        btnNo = New MaterialSkin.Controls.MaterialButton()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(title, 0, 2)
        TableLayoutPanel1.Controls.Add(message, 0, 3)
        TableLayoutPanel1.Controls.Add(PictureBox2, 0, 1)
        TableLayoutPanel1.Controls.Add(btnYes, 0, 4)
        TableLayoutPanel1.Controls.Add(btnNo, 0, 5)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.62310934F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 48.0582542F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.650485F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 34.89636F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.Size = New Size(473, 325)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Dock = DockStyle.Fill
        title.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        title.ForeColor = Color.FromArgb(CByte(20), CByte(98), CByte(189))
        title.Location = New Point(3, 109)
        title.Name = "title"
        title.Size = New Size(467, 23)
        title.TabIndex = 0
        title.Text = "CONFIRMATION"
        title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' message
        ' 
        message.AutoSize = True
        message.Dock = DockStyle.Fill
        message.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        message.ForeColor = SystemColors.ControlDarkDark
        message.Location = New Point(3, 132)
        message.Name = "message"
        message.Size = New Size(467, 71)
        message.TabIndex = 1
        message.Text = "Please input a number."
        message.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.icons8_question_mark_96
        PictureBox2.Location = New Point(3, 14)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(467, 92)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' btnYes
        ' 
        btnYes.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnYes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnYes.Depth = 0
        btnYes.Dock = DockStyle.Fill
        btnYes.HighEmphasis = True
        btnYes.Icon = Nothing
        btnYes.Location = New Point(4, 209)
        btnYes.Margin = New Padding(4, 6, 4, 6)
        btnYes.MouseState = MaterialSkin.MouseState.HOVER
        btnYes.Name = "btnYes"
        btnYes.NoAccentTextColor = Color.Empty
        btnYes.Size = New Size(465, 48)
        btnYes.TabIndex = 3
        btnYes.Text = "Yes"
        btnYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnYes.UseAccentColor = False
        btnYes.UseVisualStyleBackColor = True
        ' 
        ' btnNo
        ' 
        btnNo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnNo.Depth = 0
        btnNo.Dock = DockStyle.Fill
        btnNo.HighEmphasis = True
        btnNo.Icon = Nothing
        btnNo.Location = New Point(4, 269)
        btnNo.Margin = New Padding(4, 6, 4, 6)
        btnNo.MouseState = MaterialSkin.MouseState.HOVER
        btnNo.Name = "btnNo"
        btnNo.NoAccentTextColor = Color.Empty
        btnNo.Size = New Size(465, 50)
        btnNo.TabIndex = 3
        btnNo.Text = "No"
        btnNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        btnNo.UseAccentColor = False
        btnNo.UseVisualStyleBackColor = True
        ' 
        ' DialogBoxCancel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 331)
        Controls.Add(TableLayoutPanel1)
        FormStyle = FormStyles.StatusAndActionBar_None
        Name = "DialogBoxCancel"
        Padding = New Padding(3)
        ShowInTaskbar = False
        Sizable = False
        Text = "DialogBoxCancel"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents title As Label
    Friend WithEvents message As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnYes As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNo As MaterialSkin.Controls.MaterialButton
End Class
