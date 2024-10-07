Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading

Public Class Copy

    'Fields
    Private borderRadius As Integer = 30
    Private borderSize As Integer = 3
    Private borderColor As Color = Color.Blue

    Dim RequestID As String
    Dim Status As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim font As New Font("Roboto", 12, FontStyle.Regular)
        SetFontForLabels(Me, font)

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

        Opacity += 0.5

        If Opacity = 1 Then

            FadeInTimer.Stop()

        End If

    End Sub

    Private Sub CloseTimer_Tick(sender As Object, e As EventArgs) Handles CloseTimer.Tick
        Close()
    End Sub

    Private Sub Copy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 11, 11))
        pbImage.Image = My.Resources.icons8_check
        pbImage.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class
