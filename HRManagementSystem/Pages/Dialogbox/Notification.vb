Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports HRIS2024.Models

Public Class Notification

    'Fields
    Private borderRadius As Integer = 30
    Private borderSize As Integer = 3
    Private borderColor As Color = Color.Blue

    Dim RequestID As String
    Dim Status As String
    Private newEntity As New HRIS2024.Models.Application
    Public Sub New(Optional newEntity = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        Me.newEntity = newEntity

        Dim font As New Font("Roboto", 12, FontStyle.Regular)
        SetFontForLabels(Me, font)

        txtMessage.Font = New Font("Roboto", 10, FontStyle.Regular)

    End Sub


    ' Function to set all text font style into Roboto
    Private Sub SetFontForLabels(parentControl As Control, font As Font)

        For Each control As Control In parentControl.Controls
            If TypeOf control Is Label Then
                control.Font = New Font("Roboto", control.Font.Size, control.Font.Style)
            End If

            If control.HasChildren Then
                SetFontForLabels(control, font)
            End If
        Next
    End Sub

    Private Sub FadeInTimer_Tick(sender As Object, e As EventArgs) Handles FadeInTimer.Tick

        Opacity += 0.2

        If Opacity = 1 Then

            FadeInTimer.Stop()

        End If

    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click

        Close()

    End Sub

    Private Sub Notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 11, 11))
        txtMessage.Text = $"You have new {newEntity.ApplicationType} from {vbCrLf}{newEntity.Applicant}"
        NotifyIcon1.ShowBalloonTip(5000, "HRIS Notification", $"New Application: {newEntity.Applicant}{vbCrLf}ApplicationID: {newEntity.ApplicationID}{vbCrLf}Status: {newEntity.Status}", ToolTipIcon.None)
    End Sub

    Private Sub CloseTimer_Tick(sender As Object, e As EventArgs) Handles CloseTimer.Tick
        Hide()
        NotifyIcon1.Dispose()
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        Close()
        Dispose()
    End Sub
End Class
