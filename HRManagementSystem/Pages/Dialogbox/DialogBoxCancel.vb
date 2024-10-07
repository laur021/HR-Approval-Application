Public Class DialogBoxCancel

    Dim Detail As Integer
    Dim RequestID As String
    Public Sub New(EventCode, Optional RequestID = "")

        ' This call is required by the designer.
        InitializeComponent()

        Detail = EventCode
        Me.RequestID = RequestID

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

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        Me.DialogResult = DialogResult.Yes

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        Me.DialogResult = DialogResult.No

    End Sub

    Private Sub DialogBoxCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Detail = 1 Then

            title.Text = "Please Confirm"
            message.Text = "Do you want to log-out?"

        ElseIf Detail = 2 Then

            title.Text = "Please Confirm"
            message.Text = $"Are you sure you want to reject this request?"

        ElseIf Detail = 3 Then

            title.Text = "Please Confirm"
            message.Text = $"Cancellation request. {vbCrLf}{vbCrLf}Are you sure you want to approve this request?"

        ElseIf Detail = 4 Then

            title.Text = "Please Confirm"
            message.Text = $"Cancellation request. {vbCrLf}{vbCrLf}Are you sure you want to reject this request?"

        ElseIf Detail = 5 Then

            title.Text = "Please Confirm"
            message.Text = $"Are you sure you want to delete this?"

        ElseIf Detail = 6 Then

            title.Text = "Please Confirm"
            message.Text = $"You already have existing file. Do you want to replace this ?"

        ElseIf Detail = 7 Then

            title.Text = "Please Confirm"
            message.Text = $"Are you sure you want to approve this request?"

        End If

    End Sub

End Class