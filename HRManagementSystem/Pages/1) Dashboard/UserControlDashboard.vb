Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports Dapper
Imports HRIS2024.DataAccess
Imports HRIS2024.Models
Imports HRIS2024.Utility
Imports MaterialSkin.Controls

Public Class UserControlDashboard

    Private ReadOnly ApplicationRepo As IApplication_Repository
    Private ReadOnly ApplicationRecordRepo As IApplicationRecord_Repository
    Private ReadOnly LeaveReportRepo As ILeaveReport_Repository

    Public Sub New()

        InitializeComponent()
        ApplicationRepo = New Application_Repository
        ApplicationRecordRepo = New ApplicationRecord_Repository
        LeaveReportRepo = New LeaveReport_Repository


        ' Set the injected services
        Me.ApplicationRepo = ApplicationRepo
        Me.ApplicationRecordRepo = ApplicationRecordRepo
        Me.LeaveReportRepo = LeaveReportRepo

        'Initialized All Data
        InitializedDataAsync()

        Dim font As New Font("Roboto", 12, FontStyle.Regular)
        SetFontForLabels(Me, font)

    End Sub

#Region "Encaspsulate all function into 1 method"

    Public Async Sub InitializedDataAsync()

        Await Task.WhenAll(LoadPendingApplicationCountAsync(),
                           LoadLeaveReportsCountAsync(),
                           LoadApplicationRecordsCountAsync(),
                           LoadOverBreakCountAsync())

    End Sub

#End Region

#Region "All Function to retrieve counts of data"

    'Count the pending application
    Public Async Function LoadPendingApplicationCountAsync() As Task

        Dim ApplicationEntities = Await ApplicationRepo.GetAllDataAsync()

        With ApplicationEntities

            lblLeave_Count.Text = .Where(Function(x) _
                                                  x.ApplicationType = ConstantVariables.LeaveApplication And
                                                  x.Status = ConstantVariables.HR_Pending).Count.ToString()

            lblCS_Count.Text = .Where(Function(x) _
                                               x.ApplicationType = ConstantVariables.ChangeShiftApplication And
                                               x.Status = ConstantVariables.HR_Pending).Count.ToString()

            lblOverTime_Count.Text = .Where(Function(x) _
                                                     x.ApplicationType = ConstantVariables.OverTimeApplication And
                                                     x.Status = ConstantVariables.HR_Pending).Count.ToString()

            lblLate_count.Text = .Where(Function(x) _
                                                 x.ApplicationType = ConstantVariables.LateApplication And
                                                 x.Status = ConstantVariables.HR_Pending).Count.ToString()

            lblInfractions_Count.Text = .Where(Function(x) _
                                                        x.ApplicationType = ConstantVariables.Infraction And
                                                        x.Status = ConstantVariables.HR_Pending).Count.ToString()

        End With

    End Function

    'Count the leave summary
    Public Async Function LoadLeaveReportsCountAsync() As Task

        Dim leaveReportEntities = Await LeaveReportRepo.GetAllDataAsync()

        With leaveReportEntities

            lblVL.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.VL And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblSL.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.SL And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblEL.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.EL And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblML.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.ML And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblPL.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.PL And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblSPL.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.SPL And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblLWOP.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.LWOP And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblIL.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.IL And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblCOVL.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.COVL And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblMCW.Text = .Where(Function(x) _
                                         x.RequestType = ConstantVariables.MCW And
                                         x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblCancelled.Text = .Where(Function(x) _
                                                 x.Status = ConstantVariables.Cancelled).Count.ToString()

        End With

    End Function

    'Count the approved applicationrecords
    Public Async Function LoadApplicationRecordsCountAsync() As Task

        Dim applicationRecordEntities = Await ApplicationRecordRepo.GetAllDataAsync

        With applicationRecordEntities


            'Change Shift

            lblPersonal.Text = .Where(Function(x) _
                                x.RequestType = ConstantVariables.Personal And
                                x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblWorkRequired.Text = .Where(Function(x) _
                                    x.RequestType = ConstantVariables.WorkRequired And
                                    x.Status = ConstantVariables.HR_Approve).Count.ToString()

            'Over Time

            lblRegular.Text = .Where(Function(x) _
                                x.RequestType = ConstantVariables.Regular And
                                x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblRestDay.Text = .Where(Function(x) _
                                x.RequestType = ConstantVariables.Restday And
                                x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblRegularHoliday.Text = .Where(Function(x) _
                                        x.RequestType = ConstantVariables.Regularholiday And
                                        x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblRegularHolidayRD.Text = .Where(Function(x) _
                                        x.RequestType = ConstantVariables.RegularholidayRD And
                                        x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblSpecialHoliday.Text = .Where(Function(x) _
                                        x.RequestType = ConstantVariables.Specialholiday And
                                        x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblSpecialHolidayRD.Text = .Where(Function(x) _
                                        x.RequestType = ConstantVariables.SpecialholidayRD And
                                        x.Status = ConstantVariables.HR_Approve).Count.ToString()

            'Late

            lblExcused.Text = .Where(Function(x) _
                                x.ApplicationType = ConstantVariables.LateApplication And
                                x.Late_isExcusedHR = ConstantVariables.excused And
                                x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblUnexcused.Text = .Where(Function(x) _
                                x.ApplicationType = ConstantVariables.LateApplication And
                                x.Late_isExcusedHR = ConstantVariables.unexcused And
                                x.Status = ConstantVariables.HR_Approve).Count.ToString()

            'Timekeeping Infraction
            lblClockIssue.Text = .Where(Function(x) _
                                    x.ApplicationType = ConstantVariables.Infraction And
                                    x.RequestType = ConstantVariables.ClockingIssue And
                                    x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblIdIssue.Text = .Where(Function(x) _
                                x.ApplicationType = ConstantVariables.Infraction And
                                x.RequestType = ConstantVariables.IdIssue And
                                x.Status = ConstantVariables.HR_Approve).Count.ToString()

            lblSystemIssue.Text = .Where(Function(x) _
                                    x.ApplicationType = ConstantVariables.Infraction And
                                    x.RequestType = ConstantVariables.SystemIssue And
                                    x.Status = ConstantVariables.HR_Approve).Count.ToString()


        End With


    End Function

    'NOTE: I DID NOT SEPARATE THE DATA ACCESS OF THIS BECAUSE ITS JUST AN ADD-ONS IN HRIS DASHBOARD
    Public Async Function LoadOverBreakCountAsync() As Task

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringBUS)

            Await db.OpenAsync()

            'get the count of pending overbreaks
            Dim sqlOverbreak As Integer = Await db.ExecuteScalarAsync(Of Integer)("SELECT COUNT(*) FROM [BreakApp].[dbo].[UserBreakTime]
                                                                                    where StartTime >= '2024-01-01 00:00:00' AND
                                                                                    (OBStatus = 'Pending' OR
                                                                                    (OBStatus= 'Checked' AND
                                                                                    OBAbsolved= 1 AND
                                                                                    HRApproved= 'Pending')) AND
                                                                                    Overbreak = 1 AND
                                                                                    Breaktype IN ('01. One Hour Break','02. Terminal Break','03. Quick Break 1 - 15 Mins','04. Quick Break 2 - 15 Mins','12. 1 Hour and 30 Minutes Break','13. 30 Minutes Break')")
            lblOverBreak_Count.Text = sqlOverbreak.ToString()


            'get the count of checked overbreaks
            Dim sqlleader As Integer = Await db.ExecuteScalarAsync(Of Integer)("SELECT COUNT(*) FROM [BreakApp].[dbo].[UserBreakTime] WHERE
                                                                                Overbreak = 'True' AND
                                                                                OBStatus = 'Checked' AND
                                                                                StartTime >= '2024-01-01 00:00:00'")
            lblUnexcusedByLeader.Text = sqlleader.ToString()


            'get the count of overbreak which hr approved and reject
            Dim sqlquery = "SELECT HRApproved FROM [BreakApp].[dbo].[View_OverBreakSummary] WHERE HRApproved IS NOT NULL"
            Dim entities = Await db.QueryAsync(Of OverBreakSummary)(sqlquery)

            lblApproved.Text = entities.Where(Function(x) x.HRApproved = "Approved").Count.ToString()

            lbldisapproved.Text = entities.Where(Function(x) x.HRApproved = "Disapproved").Count.ToString()

        End Using

    End Function
#End Region


    ' Function to set all text font style into Roboto
    Private Sub SetFontForLabels(parentControl As Control, font As Font)
        If parentControl.InvokeRequired Then
            parentControl.Invoke(Sub() SetFontForLabels(parentControl, font))
        Else
            For Each control As Control In parentControl.Controls
                If TypeOf control Is Label Then
                    If control.InvokeRequired Then
                        control.Invoke(Sub() control.Font = New Font("Roboto", control.Font.Size, control.Font.Style))
                    Else
                        control.Font = New Font("Roboto", control.Font.Size, control.Font.Style)
                    End If
                End If

                If control.HasChildren Then
                    SetFontForLabels(control, font)
                End If
            Next
        End If
    End Sub

    'function to direct to the tab page in application tab - It finds the inner control of each parent control that matches the condition
    'refactored to have multiple early return than to have nested ifs

    Private Sub tblPendingLeave_Click(sender As Object, e As EventArgs) Handles tblPendingLeave.Click,
                                                                                lblLeave_Header.Click,
                                                                                lblLeave_Count.Click,
                                                                                tblPendingCS.Click,
                                                                                lblCS_Header.Click,
                                                                                lblCS_Count.Click,
                                                                                tblPendingOT.Click,
                                                                                lblOvertime_Header.Click,
                                                                                lblOverTime_Count.Click,
                                                                                tblPendingLate.Click,
                                                                                lblLate_header.Click,
                                                                                lblLate_count.Click,
                                                                                tblPendingInfractions.Click,
                                                                               lblInfractions_header.Click,
                                                                               lblInfractions_Count.Click

        'early return if parent is not formMain
        If TypeOf Me.ParentForm IsNot FormMainWindow Then
            Return
        End If

        Dim mainWindow As FormMainWindow = DirectCast(Me.ParentForm, FormMainWindow)

        mainWindow.ChangeTabPages(1) ' Change the index as needed

        Dim ucform As UserControl = mainWindow.TabApplication.Controls.OfType(Of UserControl)().FirstOrDefault

        'early return if ucform is nothing
        If ucform Is Nothing Then
            Return
        End If

        Dim materialcard As MaterialCard = ucform.Controls.OfType(Of MaterialCard)().FirstOrDefault

        'early return if materialcard is nothing
        If materialcard Is Nothing Then
            Return
        End If

        Dim table As TableLayoutPanel = materialcard.Controls.OfType(Of TableLayoutPanel)().FirstOrDefault

        'early return if table is nothing
        If table Is Nothing Then
            Return
        End If

        Dim tabcontrol As ReaLTaiizor.Controls.HopeTabPage = table.Controls.OfType(Of ReaLTaiizor.Controls.HopeTabPage)().FirstOrDefault

        'early return if tabcontrol is nothing
        If tabcontrol Is Nothing Then
            Return
        End If

        If sender Is tblPendingLeave Or sender Is lblLeave_Header Or sender Is lblLeave_Count Then
            tabcontrol.SelectedIndex = 0
        ElseIf sender Is tblPendingCS Or sender Is lblCS_Header Or sender Is lblCS_Count Then
            tabcontrol.SelectedIndex = 1
        ElseIf sender Is tblPendingOT Or sender Is lblOvertime_Header Or sender Is lblOverTime_Count Then
            tabcontrol.SelectedIndex = 2
        ElseIf sender Is tblPendingLate Or sender Is lblLate_header Or sender Is lblLate_count Then
            tabcontrol.SelectedIndex = 3
        ElseIf sender Is tblPendingInfractions Or sender Is lblInfractions_header Or sender Is lblInfractions_Count Then
            tabcontrol.SelectedIndex = 4
        End If

    End Sub

    Private Sub tbl_MouseLeave(sender As Object, e As EventArgs) Handles tblPendingLeave.MouseLeave,
                                                                            tblPendingCS.MouseLeave,
                                                                            tblPendingOT.MouseLeave,
                                                                            tblPendingLate.MouseLeave,
                                                                            lblLeave_Header.MouseLeave,
                                                                            lblLeave_Count.MouseLeave,
                                                                            lblCS_Header.MouseLeave,
                                                                            lblCS_Count.MouseLeave,
                                                                            lblOvertime_Header.MouseLeave,
                                                                            lblOverTime_Count.MouseLeave,
                                                                            lblLate_header.MouseLeave,
                                                                            lblLate_count.MouseLeave,
                                                                            TableLayoutPanel12.MouseLeave,
                                                                            lblOverBreak_Count.MouseLeave,
                                                                            lblOverBreak_header.MouseLeave,
                                                                            tblPendingInfractions.MouseLeave,
                                                                            lblInfractions_header.MouseLeave,
                                                                            lblInfractions_Count.MouseLeave

        If sender Is lblLeave_Header Or sender Is lblLeave_Count Or sender Is tblPendingLeave Then

            lblLeave_Header.ForeColor = SystemColors.ControlDarkDark
            lblLeave_Count.ForeColor = SystemColors.ControlDarkDark
            cardLeave.Size = New Size(cardLeave.Width + 5, cardLeave.Height + 5)

        ElseIf sender Is lblCS_Header Or sender Is lblCS_Count Or sender Is tblPendingCS Then

            lblCS_Header.ForeColor = SystemColors.ControlDarkDark
            lblCS_Count.ForeColor = SystemColors.ControlDarkDark
            cardCS.Size = New Size(cardCS.Width + 5, cardCS.Height + 5)

        ElseIf sender Is lblOvertime_Header Or sender Is lblOverTime_Count Or sender Is tblPendingOT Then

            lblOvertime_Header.ForeColor = SystemColors.ControlDarkDark
            lblOverTime_Count.ForeColor = SystemColors.ControlDarkDark
            cardOT.Size = New Size(cardOT.Width + 5, cardOT.Height + 5)

        ElseIf sender Is lblLate_header Or sender Is lblLate_count Or sender Is tblPendingLate Then

            lblLate_header.ForeColor = SystemColors.ControlDarkDark
            lblLate_count.ForeColor = SystemColors.ControlDarkDark
            cardLate.Size = New Size(cardLate.Width + 5, cardLate.Height + 5)

        ElseIf sender Is lblInfractions_header Or sender Is lblInfractions_Count Or sender Is tblPendingInfractions Then

            lblInfractions_header.ForeColor = SystemColors.ControlDarkDark
            lblInfractions_Count.ForeColor = SystemColors.ControlDarkDark
            cardInfractions.Size = New Size(cardInfractions.Width + 5, cardInfractions.Height + 5)

        End If

    End Sub

    Private Sub tbl_MouseEnter(sender As Object, e As EventArgs) Handles tblPendingLeave.MouseEnter,
                                                                         tblPendingCS.MouseEnter,
                                                                         tblPendingOT.MouseEnter,
                                                                         tblPendingLate.MouseEnter,
                                                                         lblLeave_Header.MouseEnter,
                                                                         lblLeave_Count.MouseEnter,
                                                                         lblCS_Header.MouseEnter,
                                                                         lblCS_Count.MouseEnter,
                                                                         lblOvertime_Header.MouseEnter,
                                                                         lblOverTime_Count.MouseEnter,
                                                                         lblLate_header.MouseEnter,
                                                                         lblLate_count.MouseEnter,
                                                                         TableLayoutPanel12.MouseEnter,
                                                                         lblOverBreak_Count.MouseEnter,
                                                                         lblOverBreak_header.MouseEnter,
                                                                         tblPendingInfractions.MouseEnter,
                                                                         lblInfractions_header.MouseEnter,
                                                                         lblInfractions_Count.MouseEnter

        If sender Is lblLeave_Header Or sender Is lblLeave_Count Or sender Is tblPendingLeave Then

            lblLeave_Header.ForeColor = ColorTranslator.FromHtml("#1565C0")
            lblLeave_Count.ForeColor = ColorTranslator.FromHtml("#1565C0")
            cardLeave.Size = New Size(cardLeave.Width - 5, cardLeave.Height - 5)

        ElseIf sender Is lblCS_Header Or sender Is lblCS_Count Or sender Is tblPendingCS Then

            lblCS_Header.ForeColor = ColorTranslator.FromHtml("#1565C0")
            lblCS_Count.ForeColor = ColorTranslator.FromHtml("#1565C0")
            cardCS.Size = New Size(cardCS.Width - 5, cardCS.Height - 5)

        ElseIf sender Is lblOvertime_Header Or sender Is lblOverTime_Count Or sender Is tblPendingOT Then

            lblOvertime_Header.ForeColor = ColorTranslator.FromHtml("#1565C0")
            lblOverTime_Count.ForeColor = ColorTranslator.FromHtml("#1565C0")
            cardOT.Size = New Size(cardOT.Width - 5, cardOT.Height - 5)

        ElseIf sender Is lblLate_header Or sender Is lblLate_count Or sender Is tblPendingLate Then

            lblLate_header.ForeColor = ColorTranslator.FromHtml("#1565C0")
            lblLate_count.ForeColor = ColorTranslator.FromHtml("#1565C0")
            cardLate.Size = New Size(cardLate.Width - 5, cardLate.Height - 5)

        ElseIf sender Is lblInfractions_header Or sender Is lblInfractions_Count Or sender Is tblPendingInfractions Then

            lblInfractions_header.ForeColor = ColorTranslator.FromHtml("#1565C0")
            lblInfractions_Count.ForeColor = ColorTranslator.FromHtml("#1565C0")
            cardInfractions.Size = New Size(cardInfractions.Width - 5, cardInfractions.Height - 5)

        End If

    End Sub

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
End Class