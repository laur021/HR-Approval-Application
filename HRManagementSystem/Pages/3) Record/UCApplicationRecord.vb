Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports ClosedXML.Excel
Imports Dapper
Imports System.Data
Imports System.Text
Imports System.ComponentModel
Imports HRIS2024.Models
Imports HRIS2024.DataAccess
Imports System.Runtime
Imports System.Security.AccessControl
Imports DocumentFormat.OpenXml.VariantTypes

Public Class UCRecord

    Private ApplicationID As String
    Private ApplicationType As String

    'Datatable for export
    Private DataTable_ApplicationRecord As DataTable

    'Object for service
    Private ReadOnly _ApplicationRecordRepo As IApplicationRecord_Repository

    'Object for pagination model
    Private Pagination As Pagination

    'pagination component
    Private UCPagination As UCPagination

    'Variable for holding complete list of records
    Private completeAppRecordList As IEnumerable(Of HRIS2024.Models.ApplicationRecord)

    'Variable for holding filtered list of records
    Private filteredAppRecordList As IEnumerable(Of HRIS2024.Models.ApplicationRecord)

    Public Sub New()

        InitializeComponent()

        Pagination = New Pagination
        _ApplicationRecordRepo = New ApplicationRecord_Repository
        UCPagination = New UCPagination(Pagination, 15)

        completeAppRecordList = New List(Of HRIS2024.Models.ApplicationRecord)

        InitializedPagination()

        RunTask()

        '
        'Set the font style
        Dim font As New Font("Roboto", 12, FontStyle.Regular)
        SetFontForLabels(Me, font)

        'Set the initial content of cmbfilter and txtsearchbar
        cmbFilter.SelectedIndex = 0
        txtSearchbar.WaterMark = "Search ID..."
        txtSearchbar.WaterMarkFont = New Font("Segoe UI", 10)

    End Sub

    Private Async Sub RunTask()
        Try
            Await InitializedRecordsAsync()
            InitializedRecordProperties()
        Catch ex As Exception

        End Try
    End Sub

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

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub InitializedPagination()

        With TableLayoutPanel3

            .Controls.Add(UCPagination)
            .SetRow(UCPagination, 5)
            UCPagination.Dock = DockStyle.Fill
            AddHandler UCPagination.PageChanged, AddressOf HandlePageChanged

        End With

    End Sub
    Private Sub HandlePageChanged(sender As Object, e As EventArgs)
        FilterRecordAsync()
    End Sub


    'This function initialized all data all at once, all data from database were fetched once
    'to avoid the repeated connection with database server.
    Public Async Function InitializedRecordsAsync() As Task

        pbLoader_Record.Visible = True

        With Pagination

            'Get all data from database
            completeAppRecordList = Await _ApplicationRecordRepo.GetAllDataAsync()

            'Get the count of all data from database
            .totalRecords = Await _ApplicationRecordRepo.GetAllDataCountAsync()

            'reset the offset, current page, labels
            UCPagination.ResetPageForAllRecords(.totalRecords)

            'filter the list of data into variable with pagination
            Dim paginatedAppRecordList = completeAppRecordList.OrderByDescending(Function(x) x.UpdateTime) _
                                                        .Skip(.offset) _
                                                        .Take(.recordsPerPage) _
                                                        .ToList()

            dgvRecord.DataSource = paginatedAppRecordList

            Await Task.Delay(1000)

            pbLoader_Record.Visible = False

            dgvRecord.ClearSelection()

        End With

    End Function

    Private Sub FilterRecordAsync()

        With Pagination

            pbLoader_Record.Visible = True

            'Assigned the apprecordlist data into new variable, please note that apprecordlist contains the list of all data during the lifetime of this class
            'It always fetch first all data before proceed to filter, important code to refresh the data that will be set in datagrid
            filteredAppRecordList = New List(Of HRIS2024.Models.ApplicationRecord)
            filteredAppRecordList = completeAppRecordList

            'Filter by date
            'Regardless of your filter in  combobox and text and what page you are, once you change the date, it will filter all the data(reset)
            'the reset is required to still show filtered data even if you are in the other page of datagridview.
            If dtpFrom.Checked = True And dtpTo.Checked = True Then

                Dim fromDate As DateTime = dtpFrom.Value.Date
                Dim toDate As DateTime = dtpTo.Value.Date.AddDays(1).AddTicks(-1)

                'sa date filter need na laging si complete data ang ifilter para mareset
                filteredAppRecordList = From x In completeAppRecordList
                                        Where x.ApplicationDate.Date >= fromDate _
                                        And x.ApplicationDate.Date <= toDate

            End If

            'Filter by combobox filter
            Select Case cmbFilter.SelectedItem.ToString()

                Case "Application ID"

                    filteredAppRecordList = If(Not String.IsNullOrEmpty(txtSearchbar.Text),
                                             From x In filteredAppRecordList
                                             Where x.ApplicationID.Contains(txtSearchbar.Text, StringComparison.OrdinalIgnoreCase),
                                             filteredAppRecordList)

                    Exit Select

                Case "Application Type"

                    filteredAppRecordList = If(Not String.IsNullOrEmpty(cmbcategory.Text),
                                             From x In filteredAppRecordList
                                             Where x.ApplicationType.Contains(cmbcategory.Text, StringComparison.OrdinalIgnoreCase),
                                             filteredAppRecordList)
                    Exit Select

                Case "Department"
                    If cmbcategory.Text = "IT" Or cmbcategory.Text = "PAYMENT" Then

                        filteredAppRecordList = If(Not String.IsNullOrEmpty(cmbcategory.Text),
                                                 From x In filteredAppRecordList
                                                 Where x.Department = cmbcategory.Text,
                                                 filteredAppRecordList)

                    ElseIf cmbcategory.Text = "FM" Then

                        filteredAppRecordList = If(Not String.IsNullOrEmpty(cmbcategory.Text),
                                                 From x In filteredAppRecordList
                                                 Where x.Department = cmbcategory.Text _
                                                 OrElse x.Department = "PaymentReports",
                                                 filteredAppRecordList)
                    Else

                        filteredAppRecordList = If(Not String.IsNullOrEmpty(cmbcategory.Text),
                                                 From x In filteredAppRecordList
                                                 Where x.Department.Contains(cmbcategory.Text, StringComparison.OrdinalIgnoreCase),
                                                 filteredAppRecordList)
                    End If

                    Exit Select

                Case "Name"
                    filteredAppRecordList = From x In filteredAppRecordList
                                            Where x.Applicant.Contains(txtSearchbar.Text, StringComparison.OrdinalIgnoreCase)
                    Exit Select

                Case "Status"
                    filteredAppRecordList = From x In filteredAppRecordList
                                            Where x.Status.Contains(txtSearchbar.Text, StringComparison.OrdinalIgnoreCase)
                    Exit Select

            End Select

            'filter by subcategory
            If Not String.IsNullOrEmpty(cmbSubCategory.Text) Then

                filteredAppRecordList = From x In filteredAppRecordList
                                        Where x.RequestType.Contains(cmbSubCategory.Text, StringComparison.OrdinalIgnoreCase)

            End If

            ''Get the total records for pagination
            .totalRecords = filteredAppRecordList.Count()

            'set the pagination for filtered data
            UCPagination.FilterPage(.totalRecords)

            'set the data in datagridview with pagination filter
            dgvRecord.DataSource = filteredAppRecordList.OrderByDescending(Function(x) x.UpdateTime) _
                                                     .Skip(.offset) _
                                                     .Take(.recordsPerPage) _
                                                     .ToList()

            'currently not showing because all data were fetched during first load in initialization of data
            pbLoader_Record.Visible = False

            dgvRecord.ClearSelection()

        End With

    End Sub



    Private Sub InitializedRecordProperties()

        PageDatagridProperties.InitializedTheme(dgvRecord)

        With dgvRecord

            'Set column headers
            Dim btnCopy As New DataGridViewButtonColumn()
            btnCopy.Name = "Copy"
            btnCopy.HeaderText = ""
            btnCopy.FlatStyle = FlatStyle.Flat
            btnCopy.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            btnCopy.Width = 30
            .Columns.Insert(0, btnCopy)

            .Columns(1).HeaderText = "Application ID"
            .Columns(1).ReadOnly = True
            .Columns(1).Visible = True
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            .Columns(2).HeaderText = "Name"
            .Columns(2).ReadOnly = True
            .Columns(2).Visible = True

            .Columns(3).HeaderText = "Date of Application"
            .Columns(3).ReadOnly = True
            .Columns(3).Visible = True

            .Columns(4).HeaderText = "Department"
            .Columns(4).ReadOnly = True
            .Columns(4).Visible = True

            .Columns(5).HeaderText = "Position"
            .Columns(5).ReadOnly = True
            .Columns(5).Visible = True

            .Columns(6).HeaderText = "Application Type"
            .Columns(6).ReadOnly = True
            .Columns(6).Visible = True

            .Columns(7).HeaderText = "Request Type"
            .Columns(7).ReadOnly = True
            .Columns(7).Visible = True

            .Columns(8).HeaderText = "xx"
            .Columns(8).ReadOnly = True
            .Columns(8).Visible = False

            .Columns(9).HeaderText = "xx"
            .Columns(9).ReadOnly = True
            .Columns(9).Visible = False

            .Columns(10).HeaderText = "xx"
            .Columns(10).ReadOnly = True
            .Columns(10).Visible = False

            .Columns(11).HeaderText = "xx"
            .Columns(11).ReadOnly = True
            .Columns(11).Visible = False

            .Columns(12).HeaderText = "xx"
            .Columns(12).ReadOnly = True
            .Columns(12).Visible = False

            .Columns(13).HeaderText = "xx"
            .Columns(13).ReadOnly = True
            .Columns(13).Visible = False

            .Columns(14).HeaderText = "xx"
            .Columns(14).ReadOnly = True
            .Columns(14).Visible = False

            .Columns(15).HeaderText = "xx"
            .Columns(15).ReadOnly = True
            .Columns(15).Visible = False

            .Columns(16).HeaderText = "xx"
            .Columns(16).ReadOnly = True
            .Columns(16).Visible = False

            .Columns(17).HeaderText = "xx"
            .Columns(17).ReadOnly = True
            .Columns(17).Visible = False

            .Columns(18).HeaderText = "xx"
            .Columns(18).ReadOnly = True
            .Columns(18).Visible = False

            .Columns(19).HeaderText = "xx"
            .Columns(19).ReadOnly = True
            .Columns(19).Visible = False

            .Columns(20).HeaderText = "xx"
            .Columns(20).ReadOnly = True
            .Columns(20).Visible = False

            .Columns(21).HeaderText = "xx"
            .Columns(21).ReadOnly = True
            .Columns(21).Visible = False

            .Columns(22).HeaderText = "xx"
            .Columns(22).ReadOnly = True
            .Columns(22).Visible = False

            .Columns(23).HeaderText = "xx"
            .Columns(23).ReadOnly = True
            .Columns(23).Visible = False

            .Columns(24).HeaderText = "xx"
            .Columns(24).ReadOnly = True
            .Columns(24).Visible = False

            .Columns(25).HeaderText = "xx"
            .Columns(25).ReadOnly = True
            .Columns(25).Visible = False

            .Columns(26).HeaderText = "xx"
            .Columns(26).ReadOnly = True
            .Columns(26).Visible = False

            .Columns(27).HeaderText = "xx"
            .Columns(27).ReadOnly = True
            .Columns(27).Visible = False

            .Columns(28).HeaderText = "Description"
            .Columns(28).ReadOnly = True
            .Columns(28).Visible = True

            .Columns(29).HeaderText = "LeaderApprovedBy"
            .Columns(29).ReadOnly = True
            .Columns(29).Visible = False

            .Columns(30).HeaderText = "LeaderApprovedDate"
            .Columns(30).ReadOnly = True
            .Columns(30).Visible = False

            .Columns(31).HeaderText = "HeadApprovedBy"
            .Columns(31).ReadOnly = True
            .Columns(31).Visible = False

            .Columns(32).HeaderText = "HeadApprovedDate"
            .Columns(32).ReadOnly = True
            .Columns(32).Visible = False

            .Columns(33).HeaderText = "HRApprovedBy"
            .Columns(33).ReadOnly = True
            .Columns(33).Visible = False

            .Columns(34).HeaderText = "HRApprovedDate"
            .Columns(34).ReadOnly = True
            .Columns(34).Visible = False

            .Columns(35).HeaderText = "Last Update"
            .Columns(35).ReadOnly = True
            .Columns(35).Visible = True

            .Columns(36).HeaderText = "Status"
            .Columns(36).ReadOnly = True
            .Columns(36).Visible = True

        End With

    End Sub

    'remove the initial selection of row in datagrid
    Private Sub dgvLeave_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)

        dgvRecord.ClearSelection()

    End Sub

    Private Sub dgvLeave_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)

        If dgvRecord.Columns(e.ColumnIndex).Name = "Status" Then

            Dim cellvalue As String = e.Value.ToString()

            Select Case cellvalue

                Case ConstantVariables.HR_Reject
                    e.CellStyle.ForeColor = Color.Red

                Case ConstantVariables.HR_Approve
                    e.CellStyle.ForeColor = Color.Green

            End Select

        End If

    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click


        txtSearchbar.Text = ""
        cmbFilter.SelectedIndex = 0
        cmbcategory.SelectedIndex = -1
        dtpFrom.Checked = False
        dtpFrom.Value = Now
        dtpFrom.CustomFormat = " "
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpTo.Checked = False
        dtpTo.Value = Now
        dtpTo.CustomFormat = " "
        dtpTo.Format = DateTimePickerFormat.Custom

        Await InitializedRecordsAsync()

    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If dtpFrom.Value <= dtpTo.Value Then

            'reset the offset, current page, labels
            Pagination.totalRecords = completeAppRecordList.Count()
            UCPagination.ResetPageForAllRecords(Pagination.totalRecords)
            'Filter
            FilterRecordAsync()

        Else

            Dim Eventcode = 6
            Dim OK As New DialogBoxOK(Eventcode) With {.StartPosition = FormStartPosition.CenterParent,
                                                       .FormBorderStyle = FormBorderStyle.FixedDialog}
            OK.ShowDialog()
            Return

        End If

    End Sub

    Private Sub ExcelExport_ApplicationReport()

        DataTable_ApplicationRecord = New DataTable

        With DataTable_ApplicationRecord

            ' Add columns to the DataTable
            .Columns.Add("ApplicationID", GetType(String))
            .Columns.Add("Applicant", GetType(String))
            .Columns.Add("ApplicationDate", GetType(String))
            .Columns.Add("Department", GetType(String))
            .Columns.Add("Position", GetType(String))
            .Columns.Add("ApplicationType", GetType(String))
            .Columns.Add("RequestType", GetType(String))

            Select Case cmbcategory.Text
                Case ConstantVariables.LeaveApplication
                    .Columns.Add("StartDate", GetType(String))
                    .Columns.Add("EndDate", GetType(String))
                    .Columns.Add("NoOfDays", GetType(String))
                Case ConstantVariables.ChangeShiftApplication
                    .Columns.Add("ShiftDate", GetType(String))
                    .Columns.Add("OriginalSchedule", GetType(String))
                    .Columns.Add("NewSchedule", GetType(String))
                Case ConstantVariables.OverTimeApplication
                    .Columns.Add("ShiftDate", GetType(String))
                    .Columns.Add("StartTime", GetType(String))
                    .Columns.Add("EndTime", GetType(String))
                    .Columns.Add("TotalHours", GetType(String))
                Case ConstantVariables.LateApplication
                    .Columns.Add("OriginalSchedule", GetType(String))
                    .Columns.Add("ActualTimeIn", GetType(String))
                    .Columns.Add("TotalLateTime", GetType(String))
                    .Columns.Add("ExcusedByLeader", GetType(String))
                    .Columns.Add("ExcusedByManager", GetType(String))
                    .Columns.Add("ExcusedByHR", GetType(String))
                Case ConstantVariables.Infraction
                    .Columns.Add("Infraction_ShifDate", GetType(String))
                    .Columns.Add("Infraction_ScheduledInOut", GetType(String))
                    .Columns.Add("Infraction_SystemInOut", GetType(String))
                    .Columns.Add("Infraction_ActualInOut", GetType(String))
                Case String.Empty
                    .Columns.Add("Leave_StartDate", GetType(String))
                    .Columns.Add("Leave_EndDate", GetType(String))
                    .Columns.Add("Leave_NoOfDays", GetType(String))
                    .Columns.Add("ChangeShift_ShiftDate", GetType(String))
                    .Columns.Add("ChangeShift_OriginalSchedule", GetType(String))
                    .Columns.Add("ChangeShift_NewSchedule", GetType(String))
                    .Columns.Add("OverTime_ShiftDate", GetType(String))
                    .Columns.Add("OverTime_StartTime", GetType(String))
                    .Columns.Add("OverTime_EndTime", GetType(String))
                    .Columns.Add("OverTime_TotalHours", GetType(String))
                    .Columns.Add("Late_OriginalSchedule", GetType(String))
                    .Columns.Add("Late_ActualTimeIn", GetType(String))
                    .Columns.Add("Late_TotalLateTime", GetType(String))
                    .Columns.Add("Late_ExcusedByLeader", GetType(String))
                    .Columns.Add("Late_ExcusedByManager", GetType(String))
                    .Columns.Add("Late_ExcusedByHR", GetType(String))
                    .Columns.Add("Infraction_ShifDate", GetType(String))
                    .Columns.Add("Infraction_ScheduledInOut", GetType(String))
                    .Columns.Add("Infraction_SystemInOut", GetType(String))
                    .Columns.Add("Infraction_ActualInOut", GetType(String))
            End Select

            .Columns.Add("Description", GetType(String))
            .Columns.Add("LeaderApprovedBy", GetType(String))
            .Columns.Add("LeaderApprovedDate", GetType(String))
            .Columns.Add("HeadApprovedBy", GetType(String))
            .Columns.Add("HeadApprovedDate", GetType(String))
            .Columns.Add("HRApprovedBy", GetType(String))
            .Columns.Add("HRApprovedDate", GetType(String))
            .Columns.Add("UpdateTime", GetType(String))
            .Columns.Add("Status", GetType(String))

        End With

        For Each applicationrecord In filteredAppRecordList

            Dim rowData As New List(Of String)()

            With rowData

                rowData.Add(applicationrecord.ApplicationID?.ToString())
                rowData.Add(applicationrecord.Applicant?.ToString())
                rowData.Add(If(applicationrecord.ApplicationDate.Year >= Now.Year, applicationrecord.ApplicationDate.ToString(), String.Empty))
                rowData.Add(applicationrecord.Department?.ToString())
                rowData.Add(applicationrecord.Position?.ToString())
                rowData.Add(applicationrecord.ApplicationType?.ToString())
                rowData.Add(applicationrecord.RequestType?.ToString())

                Select Case cmbcategory.Text
                    Case ConstantVariables.LeaveApplication
                        rowData.Add(If(applicationrecord.Leave_StartDate.Year >= Now.Year, applicationrecord.Leave_StartDate.ToString(), String.Empty))
                        rowData.Add(If(applicationrecord.Leave_EndDate.Year >= Now.Year, applicationrecord.Leave_EndDate.ToString(), String.Empty))
                        rowData.Add(If(applicationrecord.Leave_NoOfDays > 0, applicationrecord.Leave_NoOfDays.ToString(), String.Empty))
                    Case ConstantVariables.ChangeShiftApplication
                        .Add(If(applicationrecord.ChangeShift_ShiftDate.Year >= Now.Year, applicationrecord.ChangeShift_ShiftDate.ToString(), String.Empty))
                        .Add(applicationrecord.ChangeShift_OriginalSchedule?.ToString())
                        .Add(applicationrecord.ChangeShift_NewSchedule?.ToString())
                    Case ConstantVariables.OverTimeApplication
                        .Add(If(applicationrecord.OverTime_ShiftDate.Year >= Now.Year, applicationrecord.OverTime_ShiftDate.ToString(), String.Empty))
                        .Add(If(applicationrecord.OverTime_StartTime.Year >= Now.Year, applicationrecord.OverTime_StartTime.ToString(), String.Empty))
                        .Add(If(applicationrecord.OverTime_EndTime.Year >= Now.Year, applicationrecord.OverTime_EndTime.ToString(), String.Empty))
                        .Add(If(applicationrecord.OverTime_TotalHours > 0, applicationrecord.OverTime_TotalHours.ToString(), String.Empty))
                    Case ConstantVariables.LateApplication
                        .Add(If(applicationrecord.Late_OriginalSchedule.Year >= Now.Year, applicationrecord.Late_OriginalSchedule.ToString(), String.Empty))
                        .Add(If(applicationrecord.Late_ActualTimeIn.Year >= Now.Year, applicationrecord.Late_ActualTimeIn.ToString(), String.Empty))
                        .Add(applicationrecord.Late_TotalLateTime.ToString())
                        .Add(applicationrecord.Late_isExcusedLeader?.ToString())
                        .Add(applicationrecord.Late_isExcusedManager?.ToString())
                        .Add(applicationrecord.Late_isExcusedHR?.ToString())
                    Case ConstantVariables.Infraction
                        .Add(If(applicationrecord.Infraction_ShiftDate.Year >= Now.Year, applicationrecord.Infraction_ShiftDate.ToString(), String.Empty))
                        .Add(If(applicationrecord.Infraction_ScheduledInOut.Year >= Now.Year, applicationrecord.Infraction_ScheduledInOut.ToString(), String.Empty))
                        .Add(If(applicationrecord.Infraction_SystemInOut.Year >= Now.Year, applicationrecord.Infraction_SystemInOut.ToString(), String.Empty))
                        .Add(If(applicationrecord.Infraction_ActualInOut.Year >= Now.Year, applicationrecord.Infraction_ActualInOut.ToString(), String.Empty))
                    Case String.Empty
                        .Add(If(applicationrecord.Leave_StartDate.Year >= Now.Year, applicationrecord.Leave_StartDate.ToString(), String.Empty))
                        .Add(If(applicationrecord.Leave_EndDate.Year >= Now.Year, applicationrecord.Leave_EndDate.ToString(), String.Empty))
                        .Add(If(applicationrecord.Leave_NoOfDays > 0, applicationrecord.Leave_NoOfDays.ToString(), String.Empty))
                        .Add(If(applicationrecord.ChangeShift_ShiftDate.Year >= Now.Year, applicationrecord.ChangeShift_ShiftDate.ToString(), String.Empty))
                        .Add(applicationrecord.ChangeShift_OriginalSchedule?.ToString())
                        .Add(applicationrecord.ChangeShift_NewSchedule?.ToString())
                        .Add(If(applicationrecord.OverTime_ShiftDate.Year >= Now.Year, applicationrecord.OverTime_ShiftDate.ToString(), String.Empty))
                        .Add(If(applicationrecord.OverTime_StartTime.Year >= Now.Year, applicationrecord.OverTime_StartTime.ToString(), String.Empty))
                        .Add(If(applicationrecord.OverTime_EndTime.Year >= Now.Year, applicationrecord.OverTime_EndTime.ToString(), String.Empty))
                        .Add(If(applicationrecord.OverTime_TotalHours > 0, applicationrecord.OverTime_TotalHours.ToString(), String.Empty))
                        .Add(If(applicationrecord.Late_OriginalSchedule.Year >= Now.Year, applicationrecord.Late_OriginalSchedule.ToString(), String.Empty))
                        .Add(If(applicationrecord.Late_ActualTimeIn.Year >= Now.Year, applicationrecord.Late_ActualTimeIn.ToString(), String.Empty))
                        .Add(applicationrecord.Late_TotalLateTime.ToString())
                        .Add(applicationrecord.Late_isExcusedLeader?.ToString())
                        .Add(applicationrecord.Late_isExcusedManager?.ToString())
                        .Add(applicationrecord.Late_isExcusedHR?.ToString())
                        .Add(If(applicationrecord.Infraction_ShiftDate.Year >= Now.Year, applicationrecord.Infraction_ShiftDate.ToString(), String.Empty))
                        .Add(If(applicationrecord.Infraction_SystemInOut.Year >= Now.Year, applicationrecord.Infraction_SystemInOut.ToString(), String.Empty))
                        .Add(If(applicationrecord.Infraction_ActualInOut.Year >= Now.Year, applicationrecord.Infraction_ActualInOut.ToString(), String.Empty))
                End Select

                .Add(applicationrecord.Description?.ToString())
                .Add(applicationrecord.LeaderApprovedBy?.ToString())
                .Add(If(applicationrecord.LeaderApprovedDate.Year >= Now.Year, applicationrecord.LeaderApprovedDate.ToString(), String.Empty))
                .Add(applicationrecord.HeadApprovedBy?.ToString())
                .Add(If(applicationrecord.HeadApprovedDate.Year >= Now.Year, applicationrecord.HeadApprovedDate.ToString(), String.Empty))
                .Add(applicationrecord.HRApprovedBy?.ToString())
                .Add(If(applicationrecord.HRApprovedDate.Year >= Now.Year, applicationrecord.HRApprovedDate.ToString(), String.Empty))
                .Add(If(applicationrecord.UpdateTime.Year >= Now.Year, applicationrecord.UpdateTime.ToString(), String.Empty))
                .Add(applicationrecord.Status?.ToString())

                'Add each data to datatable
                DataTable_ApplicationRecord.Rows.Add(.ToArray())

            End With

        Next
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Try
            FilterRecordAsync()
            ExcelExport_ApplicationReport()

            Using sfd As SaveFileDialog = New SaveFileDialog With {.Filter = "Excel Workbook|*.xlsx", .FileName = $"Application Record {DateTime.Now().ToString("yyyyMMdd")}"}
                If sfd.ShowDialog() = DialogResult.OK Then
                    Using workbook As XLWorkbook = New XLWorkbook()
                        workbook.Worksheets.Add(DataTable_ApplicationRecord, "Application Record")
                        workbook.SaveAs(sfd.FileName)
                    End Using
                    Dim Eventcode = 8
                    Dim OK As New DialogBoxOK(Eventcode) With {
                                    .StartPosition = FormStartPosition.CenterParent,
                                    .FormBorderStyle = FormBorderStyle.FixedDialog}
                    OK.ShowDialog()
                End If
            End Using
        Catch ex As Exception
            Dim Eventcode = 9
            Dim OK As New DialogBoxOK(Eventcode, ex.Message) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}
            OK.ShowDialog()
        End Try

    End Sub

    Private Sub UCLeaveRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.dgvLeaveRecord.DoubleBuffered(True) '-nagccause ng pagblack ng column button
        dtpFrom.Checked = False
        dtpFrom.Value = Now
        dtpFrom.CustomFormat = " "
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpTo.Checked = False
        dtpTo.Value = Now
        dtpTo.CustomFormat = " "
        dtpTo.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub dtpTo_CloseUp(sender As Object, e As EventArgs) Handles dtpTo.CloseUp
        dtpTo.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub dtpFrom_CloseUp(sender As Object, e As EventArgs) Handles dtpFrom.CloseUp
        dtpFrom.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged

        If cmbFilter.SelectedItem = Nothing Then

            'do nothing

        ElseIf cmbFilter.SelectedItem.ToString() = "Application ID" Then

            cmbcategory.Visible = False
            cmbcategory.SelectedIndex = -1

            cmbSubCategory.Visible = False
            cmbSubCategory.DataSource = Nothing

            txtSearchbar.Visible = True
            txtSearchbar.Text = ""

            txtSearchbar.WaterMark = "Search ID..."
            txtSearchbar.WaterMarkFont = New Font("Segoe UI", 10)

        ElseIf cmbFilter.SelectedItem.ToString() = "Application Type" Then

            cmbcategory.DataSource = Nothing
            cmbcategory.Items.Clear()
            cmbcategory.Visible = True
            cmbcategory.Text = ""
            cmbcategory.Items.Add(ConstantVariables.LeaveApplication)
            cmbcategory.Items.Add(ConstantVariables.ChangeShiftApplication)
            cmbcategory.Items.Add(ConstantVariables.OverTimeApplication)
            cmbcategory.Items.Add(ConstantVariables.LateApplication)
            cmbcategory.Items.Add(ConstantVariables.Infraction)

            txtSearchbar.Visible = False
            txtSearchbar.Text = ""

            cmbSubCategory.Visible = True

        ElseIf cmbFilter.SelectedItem.ToString() = "Department" Then

            cmbcategory.DataSource = Nothing
            cmbcategory.Items.Clear()
            cmbcategory.Visible = True
            cmbcategory.Text = ""
            txtSearchbar.Visible = False
            txtSearchbar.Text = ""

            cmbSubCategory.Visible = False
            cmbSubCategory.DataSource = Nothing

            getDepartment()

        ElseIf cmbFilter.SelectedItem.ToString() = "Name" Then

            cmbcategory.Visible = False
            cmbcategory.SelectedIndex = -1

            txtSearchbar.Visible = True
            txtSearchbar.Text = ""

            txtSearchbar.WaterMark = "Search Name..."
            txtSearchbar.WaterMarkFont = New Font("Segoe UI", 10)

            cmbSubCategory.Visible = False
            cmbSubCategory.DataSource = Nothing

        ElseIf cmbFilter.SelectedItem.ToString() = "Status" Then

            cmbcategory.DataSource = Nothing
            cmbcategory.Items.Clear()
            cmbcategory.Visible = True
            cmbcategory.Text = ""
            cmbcategory.Items.Add(ConstantVariables.Leader_Pending)
            cmbcategory.Items.Add(ConstantVariables.Leader_Reject)
            cmbcategory.Items.Add(ConstantVariables.Manager_Pending)
            cmbcategory.Items.Add(ConstantVariables.Manager_Reject)
            cmbcategory.Items.Add(ConstantVariables.HR_Pending)
            cmbcategory.Items.Add(ConstantVariables.HR_Reject)
            cmbcategory.Items.Add(ConstantVariables.HR_Approve)
            cmbcategory.Items.Add(ConstantVariables.Cancelled)
            cmbcategory.Items.Add(ConstantVariables.Withdrawn)

            txtSearchbar.Visible = False
            txtSearchbar.Text = ""

            cmbSubCategory.Visible = False
            cmbSubCategory.DataSource = Nothing

        End If

    End Sub

    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        If cmbcategory.SelectedIndex = -1 Then

            'do nothing

        ElseIf cmbcategory.SelectedItem.ToString() = ConstantVariables.LeaveApplication Then

            cmbSubCategory.Visible = True
            getLeaveType()

        ElseIf cmbcategory.SelectedItem.ToString() = ConstantVariables.ChangeShiftApplication Then

            cmbSubCategory.Visible = True
            getChangeShiftType()

        ElseIf cmbcategory.SelectedItem.ToString() = ConstantVariables.OverTimeApplication Then

            cmbSubCategory.Visible = True
            getOverTimeType()

        ElseIf cmbcategory.SelectedItem.ToString() = ConstantVariables.LateApplication Then

            cmbSubCategory.Visible = False
            cmbSubCategory.DataSource = Nothing

        ElseIf cmbcategory.SelectedItem.ToString() = ConstantVariables.Infraction Then

            cmbSubCategory.Visible = True
            getInfractionsType()

        End If
    End Sub

#Region "This list of database query were only use as data in combobox. I did not separate the dataaccess of this"
    ''' <summary>
    ''' This list of database query were only use as data in combobox. I did not separate the dataaccess of this
    ''' </summary>
    ''' 
    Private Sub getLeaveType()

        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)

            Dim sqlSelect = "Select LeaveType from [Type_Leave] WHERE isDeleted IS NULL Group by LeaveType"
            Dim entities = db.Query(Of LeaveType)(sqlSelect)

            cmbSubCategory.DataSource = entities
            cmbSubCategory.DisplayMember = "LeaveType"
            cmbSubCategory.SelectedIndex = -1

        End Using

    End Sub

    Private Sub getInfractionsType()

        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)

            Dim sqlSelect = "Select InfractionType from [Type_Infraction] WHERE isDeleted IS NULL Group by InfractionType"
            Dim entities = db.Query(Of InfractionType)(sqlSelect)

            cmbSubCategory.DataSource = entities
            cmbSubCategory.DisplayMember = "InfractionType"
            cmbSubCategory.SelectedIndex = -1

        End Using

    End Sub

    Private Sub getChangeShiftType()

        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)

            Dim sqlSelect = "Select ChangeShiftType from [Type_ChangeShift] WHERE isDeleted IS NULL Group by ChangeShiftType"
            Dim entities = db.Query(Of ChangeShiftType)(sqlSelect)

            cmbSubCategory.DataSource = entities
            cmbSubCategory.DisplayMember = "ChangeShiftType"
            cmbSubCategory.SelectedIndex = -1

        End Using

    End Sub

    Private Sub getOverTimeType()

        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)

            Dim sqlSelect = "Select OverTimeType from [Type_OverTime] WHERE isDeleted IS NULL Group by OverTimeType"
            Dim entities = db.Query(Of OverTimeType)(sqlSelect)

            cmbSubCategory.DataSource = entities
            cmbSubCategory.DisplayMember = "OverTimeType"
            cmbSubCategory.SelectedIndex = -1

        End Using

    End Sub

    Private Sub getDepartment()
        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
            Dim sqlSelect = "Select Distinct Department from [Employee]"
            Dim entities = db.Query(Of DistinctEmployeeName)(sqlSelect)
            cmbcategory.DataSource = entities
            cmbcategory.DisplayMember = "Department"
            cmbcategory.SelectedIndex = -1
        End Using
    End Sub
#End Region

    Private Async Sub dgvLeaveRecord_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRecord.CellMouseClick

        'early return if user click header
        If e.RowIndex < 0 Then
            Return
        End If

        'Early return if not manager
        If String.Equals(FormLogin.UserDetail.Type, ConstantVariables.Manager, StringComparison.OrdinalIgnoreCase) OrElse
           String.Equals(FormLogin.UserDetail.Type, ConstantVariables.Timekeeper, StringComparison.OrdinalIgnoreCase) Then

            ' Get the value of the cell
            ApplicationID = sender.Rows(e.RowIndex).Cells("ApplicationID").Value.ToString()
            ApplicationType = sender.Rows(e.RowIndex).Cells("ApplicationType").Value.ToString()

            Dim fullInformationRepo As IFullInformation_Repository = Nothing
            Dim fullInformationEntities As viewFullInformation = Nothing
            Dim informationForm As Form = Nothing

            Select Case ApplicationType

                Case ConstantVariables.LeaveApplication
                    fullInformationRepo = New Leave_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                    informationForm = New Form_ViewLeave(fullInformationEntities, dgvRecord.Name)
                    Exit Select

                Case ConstantVariables.ChangeShiftApplication
                    fullInformationRepo = New ChangeShift_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                    informationForm = New Form_ViewChangeShift(fullInformationEntities, dgvRecord.Name)
                    Exit Select

                Case ConstantVariables.OverTimeApplication
                    fullInformationRepo = New Overtime_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                    informationForm = New Form_ViewOverTime(fullInformationEntities, dgvRecord.Name)
                    Exit Select

                Case ConstantVariables.LateApplication
                    fullInformationRepo = New Late_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                    informationForm = New Form_ViewLate(fullInformationEntities, dgvRecord.Name)
                    Exit Select

                Case ConstantVariables.Infraction
                    fullInformationRepo = New Infraction_Service
                    fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                    informationForm = New Form_ViewInfraction(fullInformationEntities, dgvRecord.Name)
                    Exit Select

            End Select

            If informationForm IsNot Nothing Then

                With informationForm
                    .StartPosition = FormStartPosition.CenterParent
                    .FormBorderStyle = FormBorderStyle.FixedDialog
                    .ShowDialog()

                    If .DialogResult = DialogResult.OK Or .DialogResult = DialogResult.Yes Then
                        Await InitializedRecordsAsync()
                    End If

                End With
            End If

        End If


    End Sub

    Private Sub txtSearchbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchbar.KeyPress

        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btnSearch_Click(Me, EventArgs.Empty)
        End If

    End Sub

    Private Sub cmbcategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcategory.KeyDown, cmbSubCategory.KeyDown

        If e.KeyCode = Keys.Enter Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btnSearch_Click(Me, EventArgs.Empty)
        End If

    End Sub

    Private Sub dgvLeaveRecord_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecord.CellMouseEnter
        If e.RowIndex >= 0 Then
            dgvRecord.Rows(e.RowIndex).DefaultCellStyle.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub dgvLeaveRecord_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecord.CellMouseLeave
        If e.RowIndex >= 0 Then
            dgvRecord.Rows(e.RowIndex).DefaultCellStyle.BackColor = dgvRecord.DefaultCellStyle.BackColor
        End If
    End Sub

    Private Sub dgvLeaveRecord_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvRecord.CellPainting
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim w = My.Resources.icons8_copy_201.Width
            Dim h = My.Resources.icons8_copy_201.Height
            Dim x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2
            Dim y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2
            e.Graphics.DrawImage(My.Resources.icons8_copy_20, New Rectangle(x, y, w, h))
            e.Handled = True
        End If
    End Sub

    Private Sub dgvLeaveRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecord.CellContentClick
        If e.ColumnIndex = dgvRecord.Columns("Copy").Index AndAlso e.RowIndex >= 0 Then
            Clipboard.SetText(dgvRecord.Rows(e.RowIndex).Cells("ApplicationID").Value.ToString)
            Dim Copy As New Copy()

            ' Calculate the position relative to the screen the parent form is currently on
            Dim screenBounds As Rectangle = Screen.FromControl(Me).Bounds
            Dim parentLocationOnScreen As Point = Me.PointToScreen(Point.Empty)
            Dim xPosition As Integer = parentLocationOnScreen.X + (Me.Width - Copy.Width) \ 2
            Dim yPosition As Integer = parentLocationOnScreen.Y + 20

            ' Ensure that the calculated position is within the bounds of the screen
            xPosition = Math.Max(screenBounds.Left, Math.Min(screenBounds.Right - Copy.Width, xPosition))
            yPosition = Math.Max(screenBounds.Top, Math.Min(screenBounds.Bottom - Copy.Height, yPosition))

            Copy.StartPosition = FormStartPosition.Manual
            Copy.Location = New Point(xPosition, yPosition)
            Copy.ShowDialog()
        End If
    End Sub


    Private Sub dgvLeaveRecord_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles dgvRecord.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub


End Class
