<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPagination
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
        TableLayoutPanel5 = New TableLayoutPanel()
        lblCurrentPage = New Label()
        btnPrevious = New ReaLTaiizor.Controls.MaterialButton()
        btnNext = New ReaLTaiizor.Controls.MaterialButton()
        Label3 = New Label()
        lblTotalPage = New Label()
        TableLayoutPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 6
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 30F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 50F))
        TableLayoutPanel5.Controls.Add(lblCurrentPage, 2, 0)
        TableLayoutPanel5.Controls.Add(btnPrevious, 1, 0)
        TableLayoutPanel5.Controls.Add(btnNext, 5, 0)
        TableLayoutPanel5.Controls.Add(Label3, 3, 0)
        TableLayoutPanel5.Controls.Add(lblTotalPage, 4, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(1000, 34)
        TableLayoutPanel5.TabIndex = 9
        ' 
        ' lblCurrentPage
        ' 
        lblCurrentPage.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblCurrentPage.AutoSize = True
        lblCurrentPage.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblCurrentPage.ForeColor = SystemColors.ControlDarkDark
        lblCurrentPage.Location = New Point(823, 10)
        lblCurrentPage.Margin = New Padding(3)
        lblCurrentPage.Name = "lblCurrentPage"
        lblCurrentPage.Size = New Size(44, 14)
        lblCurrentPage.TabIndex = 9
        lblCurrentPage.Text = "0"
        lblCurrentPage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Anchor = AnchorStyles.Right
        btnPrevious.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPrevious.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPrevious.Depth = 0
        btnPrevious.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrevious.HighEmphasis = True
        btnPrevious.Icon = My.Resources.Resources.icons8_previous_24
        btnPrevious.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase
        btnPrevious.Location = New Point(774, 6)
        btnPrevious.Margin = New Padding(4, 6, 4, 6)
        btnPrevious.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnPrevious.Name = "btnPrevious"
        btnPrevious.NoAccentTextColor = Color.Empty
        btnPrevious.Size = New Size(42, 22)
        btnPrevious.TabIndex = 5
        btnPrevious.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text
        btnPrevious.UseAccentColor = False
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Right
        btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnNext.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default
        btnNext.Depth = 0
        btnNext.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnNext.HighEmphasis = True
        btnNext.Icon = My.Resources.Resources.icons8_next_24
        btnNext.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase
        btnNext.Location = New Point(954, 6)
        btnNext.Margin = New Padding(4, 6, 4, 6)
        btnNext.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnNext.Name = "btnNext"
        btnNext.NoAccentTextColor = Color.Empty
        btnNext.Size = New Size(42, 22)
        btnNext.TabIndex = 6
        btnNext.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text
        btnNext.UseAccentColor = False
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(873, 10)
        Label3.Margin = New Padding(3)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 14)
        Label3.TabIndex = 10
        Label3.Text = "of"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalPage
        ' 
        lblTotalPage.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblTotalPage.AutoSize = True
        lblTotalPage.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalPage.ForeColor = SystemColors.ControlDarkDark
        lblTotalPage.Location = New Point(903, 10)
        lblTotalPage.Margin = New Padding(3)
        lblTotalPage.Name = "lblTotalPage"
        lblTotalPage.Size = New Size(44, 14)
        lblTotalPage.TabIndex = 11
        lblTotalPage.Text = "0"
        lblTotalPage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UCPagination
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel5)
        Name = "UCPagination"
        Size = New Size(1000, 34)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblCurrentPage As Label
    Friend WithEvents btnPrevious As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents btnNext As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalPage As Label

End Class
