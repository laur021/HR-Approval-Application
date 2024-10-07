Imports System.Runtime.InteropServices
Imports ReaLTaiizor.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notification
    Inherits System.Windows.Forms.Form
    'Inherits MaterialSkin.Controls.MaterialForm

    ' <summary>
    '   The CreateRoundRectRgn function creates a rectangular region with rounded corners.
    ' </summary>
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Notification))
        title = New Label()
        PictureBox1 = New PictureBox()
        NotifyIcon1 = New NotifyIcon(components)
        FadeInTimer = New Timer(components)
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        CloseTimer = New Timer(components)
        txtMessage = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        title.ForeColor = Color.FromArgb(CByte(20), CByte(98), CByte(189))
        title.Location = New Point(88, 15)
        title.Name = "title"
        title.Size = New Size(105, 19)
        title.TabIndex = 1
        title.Text = "NOTIFICATION"
        title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_topic_push_notification_941
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Visible = True
        ' 
        ' FadeInTimer
        ' 
        FadeInTimer.Enabled = True
        FadeInTimer.Interval = 50
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSize = False
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(321, 3)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(25, 25)
        MaterialButton1.TabIndex = 3
        MaterialButton1.TabStop = False
        MaterialButton1.Text = "x"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' CloseTimer
        ' 
        CloseTimer.Enabled = True
        CloseTimer.Interval = 5000
        ' 
        ' txtMessage
        ' 
        txtMessage.BackColor = Color.FromArgb(CByte(220), CByte(232), CByte(246))
        txtMessage.BorderStyle = BorderStyle.None
        txtMessage.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtMessage.ForeColor = SystemColors.ControlDarkDark
        txtMessage.Location = New Point(88, 46)
        txtMessage.Multiline = True
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Size(251, 56)
        txtMessage.TabIndex = 4
        txtMessage.TabStop = False
        ' 
        ' Notification
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(232), CByte(246))
        ClientSize = New Size(348, 114)
        ControlBox = False
        Controls.Add(txtMessage)
        Controls.Add(MaterialButton1)
        Controls.Add(title)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1050)
        MinimumSize = New Size(126, 50)
        Name = "Notification"
        Opacity = 0R
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents title As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents FadeInTimer As Timer
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CloseTimer As Timer
    Friend WithEvents txtMessage As TextBox
End Class
