Imports System.Runtime.InteropServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNotifList
    Inherits System.Windows.Forms.Form

    ' <summary>
    '   The CreateRoundRectRgn function creates a rectangular region with rounded corners.
    ' </summary>
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgNotif = New DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnLoadMore = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        btnMarkAllasRead = New Button()
        CType(dgNotif, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        MaterialCard1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgNotif
        ' 
        dgNotif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgNotif.BackgroundColor = SystemColors.Window
        dgNotif.BorderStyle = BorderStyle.None
        dgNotif.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgNotif.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgNotif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgNotif.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgNotif.DefaultCellStyle = DataGridViewCellStyle2
        dgNotif.Dock = DockStyle.Fill
        dgNotif.GridColor = SystemColors.InactiveBorder
        dgNotif.Location = New Point(3, 33)
        dgNotif.Name = "dgNotif"
        dgNotif.ReadOnly = True
        dgNotif.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgNotif.RowHeadersVisible = False
        dgNotif.RowTemplate.Height = 25
        dgNotif.ScrollBars = ScrollBars.Vertical
        dgNotif.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgNotif.ShowCellErrors = False
        dgNotif.ShowCellToolTips = False
        dgNotif.ShowEditingIcon = False
        dgNotif.ShowRowErrors = False
        dgNotif.Size = New Size(408, 422)
        dgNotif.TabIndex = 6
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(MaterialCard1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(470, 543)
        TableLayoutPanel1.TabIndex = 7
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
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(442, 515)
        MaterialCard1.TabIndex = 8
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(dgNotif, 0, 1)
        TableLayoutPanel2.Controls.Add(btnLoadMore, 0, 2)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(14, 14)
        TableLayoutPanel2.Margin = New Padding(14, 3, 14, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.Size = New Size(414, 487)
        TableLayoutPanel2.TabIndex = 10
        ' 
        ' btnLoadMore
        ' 
        btnLoadMore.Anchor = AnchorStyles.None
        btnLoadMore.FlatAppearance.BorderSize = 0
        btnLoadMore.FlatStyle = FlatStyle.Flat
        btnLoadMore.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLoadMore.ForeColor = SystemColors.ControlDarkDark
        btnLoadMore.Location = New Point(169, 461)
        btnLoadMore.Name = "btnLoadMore"
        btnLoadMore.Size = New Size(75, 23)
        btnLoadMore.TabIndex = 9
        btnLoadMore.Text = "View more"
        btnLoadMore.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(btnMarkAllasRead, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(414, 30)
        TableLayoutPanel3.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 17)
        Label1.TabIndex = 1
        Label1.Text = "Notifications"
        ' 
        ' btnMarkAllasRead
        ' 
        btnMarkAllasRead.Anchor = AnchorStyles.Right
        btnMarkAllasRead.FlatAppearance.BorderSize = 0
        btnMarkAllasRead.FlatStyle = FlatStyle.Flat
        btnMarkAllasRead.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnMarkAllasRead.ForeColor = SystemColors.ControlDarkDark
        btnMarkAllasRead.ImageAlign = ContentAlignment.MiddleRight
        btnMarkAllasRead.Location = New Point(304, 3)
        btnMarkAllasRead.Name = "btnMarkAllasRead"
        btnMarkAllasRead.Size = New Size(107, 23)
        btnMarkAllasRead.TabIndex = 2
        btnMarkAllasRead.Text = "Mark All as Read"
        btnMarkAllasRead.TextAlign = ContentAlignment.MiddleLeft
        btnMarkAllasRead.UseVisualStyleBackColor = True
        ' 
        ' FormNotifList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(470, 543)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormNotifList"
        ShowInTaskbar = False
        Text = "FormNotifList"
        TransparencyKey = Color.Fuchsia
        CType(dgNotif, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        MaterialCard1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgNotif As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents btnLoadMore As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnMarkAllasRead As Button
End Class
