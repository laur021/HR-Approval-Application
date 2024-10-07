Imports Dapper
Imports DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming
Imports DocumentFormat.OpenXml.Vml.Office
Imports HRIS2024.DataAccess
Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class FormAddLeave

    Dim LeaveType As HRIS2024.Models.LeaveType
    Dim eventcode As Integer
    Dim LeaveID As Integer

    Private ReadOnly leaveTypeRepo As ILeaveType_Repository
    Public Sub New(LeaveType)

        InitializeComponent()

        leaveTypeRepo = New LeaveType_Repository

        Me.LeaveType = LeaveType

        If Me.LeaveType IsNot Nothing Then

            txtLeaveType.Text = Me.LeaveType.LeaveType
            txtDescription.Text = Me.LeaveType.Description
            LeaveID = Me.LeaveType.Id

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Close()

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

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        'Early return if the txtLeaveType is null or empty
        If String.IsNullOrEmpty(txtLeaveType.Text) Then
            eventcode = 18
            Dim DialogBoxOK As New DialogBoxOK(eventcode) With {.StartPosition = FormStartPosition.CenterParent,
                                                                .FormBorderStyle = FormBorderStyle.FixedDialog}
            DialogBoxOK.ShowDialog()
            txtLeaveType.Focus()
            Return
        End If


        If LeaveType Is Nothing Then

            'Early return if the txtLeaveType.text already exist
            Dim countOfSameName As Integer = Await leaveTypeRepo.GetCountsAsync(txtLeaveType.Text)

            If countOfSameName > 0 Then
                eventcode = 15
                Dim DialogAlreadyExist As New DialogBoxOK(eventcode) With {.StartPosition = FormStartPosition.CenterParent,
                                                                       .FormBorderStyle = FormBorderStyle.FixedDialog}
                DialogAlreadyExist.ShowDialog()
                txtLeaveType.Focus()
                Return
            End If

            Dim newObj As New HRIS2024.Models.LeaveType With {
                .LeaveType = txtLeaveType?.Text?.Trim(),
                .Description = txtDescription?.Text.Trim(),
                .AddedDate = DateTime.Now,
                .AddedBy = UserPrincipal.Current.ToString()
            }

            'Add new leavetype
            Await leaveTypeRepo.AddAsync(newObj)
            eventcode = 16

        Else

            'Update leavetype
            With Me.LeaveType
                .LeaveType = txtLeaveType.Text.Trim()
                .Description = txtDescription.Text
            End With

            Await leaveTypeRepo.UpdateAsync(Me.LeaveType)
            eventcode = 17

        End If

        Me.DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub FormAddLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim font As New Font("Roboto", 12, FontStyle.Regular)
        SetFontForLabels(Me, font)
    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress, txtLeaveType.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Trigger the button click event
            btnSave.PerformClick()
        End If

    End Sub
End Class