Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports System.Windows.Forms.DataVisualization.Charting
Imports HRIS2024.Utility
Imports Dapper
Imports HRIS2024.DataAccess
Imports HRIS2024.Models

Public Class FormNotifList

    Dim initialCount As Integer = 5
    Dim counter As Integer
    Public Sub New()


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadNotification(initialCount)
    End Sub

    Public Sub LoadNotification(Count As Integer)

        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)

            Dim CountString = Count.ToString()

            ' Query for Comments
            'Dim selectNotif = $"SELECT TOP {CountString} * FROM [LeaveComments] WHERE Status = '{ConstantVariables.HR_Pending}' ORDER BY AddedDate DESC"
            Dim selectNotif = $"SELECT TOP {CountString} * FROM [Application] WHERE Status IN ('{ConstantVariables.HR_Pending}', '{ConstantVariables.HR_Reject}', '{ConstantVariables.HR_Approve}') ORDER BY UpdateTime DESC"
            Dim entitiesNotif = db.Query(Of Application)(selectNotif)

            dgNotif.DataSource = entitiesNotif
            dgNotif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgNotif.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgNotif.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgNotif.RowsDefaultCellStyle.Padding = New Padding(0, 20, 0, 20)
            dgNotif.DefaultCellStyle.Font = New Font("Roboto", 7, FontStyle.Regular)
            dgNotif.DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
            dgNotif.ReadOnly = True

            dgNotif.Columns(0).HeaderText = "ID"
            dgNotif.Columns(0).ReadOnly = True
            dgNotif.Columns(0).Visible = False

            dgNotif.Columns(1).HeaderText = "Application ID"
            dgNotif.Columns(1).ReadOnly = True
            dgNotif.Columns(1).Visible = False

            dgNotif.Columns(2).HeaderText = "Name"
            dgNotif.Columns(2).ReadOnly = True
            dgNotif.Columns(2).Visible = True

            dgNotif.Columns(3).HeaderText = "Department"
            dgNotif.Columns(3).ReadOnly = True
            dgNotif.Columns(3).Visible = False

            dgNotif.Columns(4).HeaderText = "Position"
            dgNotif.Columns(4).ReadOnly = True
            dgNotif.Columns(4).Visible = False

            dgNotif.Columns(5).HeaderText = "Type of Application"
            dgNotif.Columns(5).ReadOnly = True
            dgNotif.Columns(5).Visible = False

            dgNotif.Columns(6).HeaderText = "Date of Application"
            dgNotif.Columns(6).ReadOnly = True
            dgNotif.Columns(6).Visible = False

            dgNotif.Columns(7).HeaderText = "Total No. of days"
            dgNotif.Columns(7).ReadOnly = True
            dgNotif.Columns(7).Visible = False

            dgNotif.Columns(8).HeaderText = "Leader Approved By"
            dgNotif.Columns(8).ReadOnly = True
            dgNotif.Columns(8).Visible = False

            dgNotif.Columns(9).HeaderText = "Leader Approved Date"
            dgNotif.Columns(9).ReadOnly = True
            dgNotif.Columns(9).Visible = False

            dgNotif.Columns(10).HeaderText = "Manager Approved by"
            dgNotif.Columns(10).ReadOnly = True
            dgNotif.Columns(10).Visible = False

            dgNotif.Columns(11).HeaderText = "Manager Approved date"
            dgNotif.Columns(11).ReadOnly = True
            dgNotif.Columns(11).Visible = False

            dgNotif.Columns(12).HeaderText = "Status"
            dgNotif.Columns(12).ReadOnly = True
            dgNotif.Columns(12).Visible = True

            dgNotif.Columns(13).HeaderText = "HR Approved by"
            dgNotif.Columns(13).ReadOnly = True
            dgNotif.Columns(13).Visible = False

            dgNotif.Columns(14).HeaderText = "HR Approved date"
            dgNotif.Columns(14).ReadOnly = True
            dgNotif.Columns(14).Visible = False

            dgNotif.Columns(15).HeaderText = "isDirectToHR"
            dgNotif.Columns(15).ReadOnly = True
            dgNotif.Columns(15).Visible = False

            dgNotif.Columns(16).HeaderText = "isLeader"
            dgNotif.Columns(16).ReadOnly = True
            dgNotif.Columns(16).Visible = False

            dgNotif.Columns(17).HeaderText = "isManager"
            dgNotif.Columns(17).ReadOnly = True
            dgNotif.Columns(17).Visible = False

            dgNotif.Columns(18).HeaderText = "isCancelled"
            dgNotif.Columns(18).ReadOnly = True
            dgNotif.Columns(18).Visible = False

            dgNotif.Columns(19).HeaderText = "UpdateTime"
            dgNotif.Columns(19).ReadOnly = True
            dgNotif.Columns(19).Visible = True

            dgNotif.Columns(20).HeaderText = "isRead"
            dgNotif.Columns(20).ReadOnly = True
            dgNotif.Columns(20).Visible = False

        End Using

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

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCACTIVATE As Integer = &H86

        If m.Msg = WM_NCACTIVATE AndAlso m.WParam = IntPtr.Zero Then
            ' Form is being deactivated
            Me.Hide()
            Me.DialogResult = DialogResult.OK
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub dgNotif_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgNotif.CellFormatting
        For Each row As DataGridViewRow In dgNotif.Rows

            'change value of middle row
            Select Case row.Cells("ApplicationType").Value.ToString
                Case ConstantVariables.LeaveApplication
                    row.Cells("Status").Value = $"You receive new Leave request from '{row.Cells("Applicant").Value.ToString()}'"
                    Exit Select
                Case ConstantVariables.ChangeShiftApplication
                    row.Cells("Status").Value = $"You receive new Change Shift request from '{row.Cells("Applicant").Value.ToString()}'"
                    Exit Select
                Case ConstantVariables.OverTimeApplication
                    row.Cells("Status").Value = $"You receive new Over Time request from '{row.Cells("Applicant").Value.ToString()}'"
                    Exit Select
                Case ConstantVariables.LateApplication
                    row.Cells("Status").Value = $"You receive new Late request from '{row.Cells("Applicant").Value.ToString()}'"
                    Exit Select
                Case ConstantVariables.Infraction
                    row.Cells("Status").Value = $"You receive new Timekeeping infraction request from '{row.Cells("Applicant").Value.ToString()}'"
                    Exit Select
            End Select

            'bold the row if unread
            If row.Cells("isRead").Value = "True" Then

                row.DefaultCellStyle.Font = New Font("Roboto", 8, FontStyle.Regular)

            Else
                row.DefaultCellStyle.Font = New Font("Roboto", 8, FontStyle.Bold)

            End If

        Next
    End Sub

    Private Async Sub dgNotif_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgNotif.CellMouseClick

        'early return if user click header
        If e.RowIndex < 0 Then
            Return
        End If

        'Early return if not manager
        If String.Equals(FormLogin.UserDetail.Type, ConstantVariables.Manager, StringComparison.OrdinalIgnoreCase) Then


            ' Get the value of the cell
            Dim ApplicationId = sender.Rows(e.RowIndex).Cells("ApplicationID").Value.ToString()
            Dim ApplicationType = sender.Rows(e.RowIndex).Cells("ApplicationType").Value.ToString()

            Dim fullInformationRepo As IFullInformation_Repository = Nothing
            Dim fullInformationEntities As viewFullInformation = Nothing
            Dim informationForm As Form = Nothing

            'marked the selected data as read. Di ko na hiniwalay ng data access
            Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
                Dim updateSelection = $"UPDATE [Application] SET isRead = 'True' WHERE ApplicationID = '{ApplicationId}'"
                Dim update = db.Execute(updateSelection)
            End Using

            LoadNotification(initialCount)

            Select Case ApplicationType

                Case ConstantVariables.LeaveApplication
                    fullInformationRepo = New Leave_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationId)
                    informationForm = New Form_ViewLeave(fullInformationEntities, dgNotif.Name)
                    Exit Select

                Case ConstantVariables.ChangeShiftApplication
                    fullInformationRepo = New ChangeShift_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationId)
                    informationForm = New Form_ViewChangeShift(fullInformationEntities, dgNotif.Name)
                    Exit Select

                Case ConstantVariables.OverTimeApplication
                    fullInformationRepo = New Overtime_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationId)
                    informationForm = New Form_ViewOverTime(fullInformationEntities, dgNotif.Name)
                    Exit Select

                Case ConstantVariables.LateApplication
                    fullInformationRepo = New Late_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationId)
                    informationForm = New Form_ViewLate(fullInformationEntities, dgNotif.Name)
                    Exit Select

                Case ConstantVariables.Infraction
                    fullInformationRepo = New Infraction_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationId)
                    informationForm = New Form_ViewInfraction(fullInformationEntities, dgNotif.Name)
                    Exit Select

            End Select

            If informationForm IsNot Nothing Then

                With informationForm
                    .StartPosition = FormStartPosition.CenterScreen
                    .FormBorderStyle = FormBorderStyle.FixedDialog
                    .ShowDialog()
                End With

            End If

        End If

    End Sub


    Private Sub dgnotif_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgNotif.CellMouseEnter
        If e.RowIndex >= 0 Then
            dgNotif.Rows(e.RowIndex).DefaultCellStyle.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub dgnotif_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgNotif.CellMouseLeave
        If e.RowIndex >= 0 Then
            dgNotif.Rows(e.RowIndex).DefaultCellStyle.BackColor = dgNotif.DefaultCellStyle.BackColor
        End If
    End Sub


    Private Sub FormNotifList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set all font to roboto
        Dim font As New Font("Roboto", 9, FontStyle.Regular)
        SetFontForLabels(Me, font)

        dgNotif.ClearSelection()

        dgNotif.DoubleBuffered(True)

        MaterialCard1.Margin = New Padding(3, 3, 3, 3)
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 11, 11))

    End Sub

    Private Sub btnLoadMore_Click(sender As Object, e As EventArgs) Handles btnLoadMore.Click
        counter += 5
        LoadNotification(initialCount + counter)
    End Sub

    Private Async Sub btnMarkAllasRead_Click(sender As Object, e As EventArgs) Handles btnMarkAllasRead.Click
        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
            Dim update = "UPDATE [Application] SET isRead = 'True'"
            Dim execute = Await db.ExecuteAsync(update)
            LoadNotification(initialCount)
        End Using
    End Sub
End Class