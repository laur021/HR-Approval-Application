Imports System.Runtime.InteropServices
Imports ReaLTaiizor.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Copy
    Inherits System.Windows.Forms.Form
    'Inherits MaterialSkin.Controls.MaterialForm

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Copy))
        pbImage = New PictureBox()
        NotifyIcon1 = New NotifyIcon(components)
        FadeInTimer = New Timer(components)
        CloseTimer = New Timer(components)
        title = New Label()
        CType(pbImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbImage
        ' 
        pbImage.InitialImage = Nothing
        pbImage.Location = New Point(77, 11)
        pbImage.Name = "pbImage"
        pbImage.Size = New Size(28, 27)
        pbImage.SizeMode = PictureBoxSizeMode.Zoom
        pbImage.TabIndex = 0
        pbImage.TabStop = False
        pbImage.UseWaitCursor = True
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
        ' CloseTimer
        ' 
        CloseTimer.Enabled = True
        CloseTimer.Interval = 1000
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        title.ForeColor = SystemColors.ControlDarkDark
        title.Location = New Point(20, 17)
        title.Name = "title"
        title.Size = New Size(53, 15)
        title.TabIndex = 1
        title.Text = "Copied !"
        title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Copy
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(254), CByte(254))
        ClientSize = New Size(126, 50)
        ControlBox = False
        Controls.Add(pbImage)
        Controls.Add(title)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1050)
        MinimumSize = New Size(126, 50)
        Name = "Copy"
        Opacity = 0.5R
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        CType(pbImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents FadeInTimer As Timer
    Friend WithEvents CloseTimer As Timer
    Friend WithEvents title As Label
End Class
