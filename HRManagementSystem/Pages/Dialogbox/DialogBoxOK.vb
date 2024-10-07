Public Class DialogBoxOK

    Dim Detail As Integer
    Dim TransactionId As String
    Dim startDate As String
    Dim endDate As String
    Public Sub New(EventCode, Optional TransactionID = "", Optional startDate = "", Optional endDate = "")

        ' This call is required by the designer.
        InitializeComponent()

        Detail = EventCode
        Me.TransactionId = TransactionID

        Dim font As New Font("Roboto", 12, FontStyle.Regular)
        SetFontForLabels(Me, font)

        Me.startDate = startDate
        Me.endDate = endDate

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

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Me.Close()

    End Sub

    Private Sub DialogBoxOK_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Detail = 1 Then

            title.Text = "Error"
            picturebox.Image = My.Resources.icons8_error_96
            message.Text = "Please input correct username and password!"

        ElseIf Detail = 2 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Application ID: {TransactionId} is now rejected."

        ElseIf Detail = 3 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Application ID: {TransactionId} is now approved."

        ElseIf Detail = 4 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Download completed. Please check {TransactionId}."

        ElseIf Detail = 5 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"No available attachment file."

        ElseIf Detail = 6 Then

            title.Text = "Error"
            picturebox.Image = My.Resources.icons8_error_96
            message.Text = $"Invalid selection of date."

        ElseIf Detail = 7 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"No record."

        ElseIf Detail = 8 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Data Exported Successfully."

        ElseIf Detail = 9 Then

            title.Text = "Error"
            picturebox.Image = My.Resources.icons8_error_96
            message.Text = $"{TransactionId}"

        ElseIf Detail = 10 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Application ID: {TransactionId} is now cancelled."

        ElseIf Detail = 11 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Download success."

        ElseIf Detail = 12 Then

            title.Text = "Error"
            picturebox.Image = My.Resources.icons8_error_96
            message.Text = $"{TransactionId}"

        ElseIf Detail = 13 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Preview for file type .ZIP or .RAR is not available."

        ElseIf Detail = 14 Then

            title.Text = "Error"
            picturebox.Image = My.Resources.icons8_error_96
            message.Text = $"Another user is currently processing this request. Please refresh."

        ElseIf Detail = 15 Then

            title.Text = "Error"
            picturebox.Image = My.Resources.icons8_error_96
            message.Text = $"LeaveType already exists"

        ElseIf Detail = 16 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Leave successfully added"

        ElseIf Detail = 17 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Leave successfully updated"

        ElseIf Detail = 18 Then

            title.Text = "Error"
            picturebox.Image = My.Resources.icons8_error_96
            message.Text = $"LeaveType is required"

        ElseIf Detail = 19 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Leave successfully deleted"

        ElseIf Detail = 20 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"File uploaded successfully"

        ElseIf Detail = 21 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Please select if this request should be marked as excused."

        ElseIf Detail = 22 Then

            title.Text = "Information"
            picturebox.Image = My.Resources.icons8_information_96
            message.Text = $"Cancellation request is now rejected."

        End If

    End Sub

End Class