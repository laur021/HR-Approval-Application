Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports ClosedXML.Excel
Imports Dapper
Imports System.Data
Imports System.Text
Imports System.ComponentModel
Imports Irony.Parsing
Imports System.Threading
Imports HRIS2024.Utility
Imports HRIS2024.DataAccess
Imports HRIS2024.Models

Public Class UCTimeKeeping

    Private ReadOnly leaveReportRepo As ILeaveReport_Repository
    Private ReadOnly overbreakRepo As IOverbreak_Repository
    ''' <summary>
    ''' Objects for leave counts
    ''' </summary>
    Private completeLeaveCount As IEnumerable(Of HRIS2024.Models.LeaveCount)
    Private filteredLeaveCount As IEnumerable(Of HRIS2024.Models.LeaveCount)

    ''' <summary>
    ''' objects for leave summary
    ''' </summary>
    Private completeLeaveReport As IEnumerable(Of HRIS2024.Models.LeaveReport)
    Private filteredLeaveReport As IEnumerable(Of HRIS2024.Models.LeaveReport)

    ''' <summary>
    ''' objects for overbreak counts
    ''' </summary>
    Private completeOverbreakCount As IEnumerable(Of HRIS2024.Models.OverBreakCount)
    Private filteredOverbreakCount As IEnumerable(Of HRIS2024.Models.OverBreakCount)

    ''' <summary>
    ''' objects for overbreak summary
    ''' </summary>
    Private completeOverbreakSummary As IEnumerable(Of HRIS2024.Models.OverBreakSummary)
    Private filteredOverbreakSummary As IEnumerable(Of HRIS2024.Models.OverBreakSummary)

    ''' <summary>
    ''' List of objects for pagination component and class model
    ''' index 0: for leave count
    ''' index 1: for leave summary
    ''' index 2: for overbreak count
    ''' index 3: for overbreak summary
    ''' </summary>
    Private collectionOfPagination As List(Of HRIS2024.Models.Pagination)
    Private collectionOfUCPagination As List(Of UCPagination)

    Private ApplicationID As String

    'datatable
    Private DataTable_LeaveCount As DataTable
    Private DataTable_LeaveSummary As DataTable
    Private DataTable_OverbreakCounts As DataTable
    Private DataTable_OverbreakSummary As DataTable


    Public Sub New()

        InitializeComponent()

        leaveReportRepo = New LeaveReport_Repository
        overbreakRepo = New Overbreak_Repository

        'initialized object of list of pagination model
        collectionOfPagination = New List(Of Pagination) From {New Pagination(),
                                                                    New Pagination(),
                                                                    New Pagination(),
                                                                    New Pagination()
                                                                    }

        'initialized the list of ucpagination
        collectionOfUCPagination = New List(Of UCPagination) From {New UCPagination(collectionOfPagination.Item(0), 7),
                                                                   New UCPagination(collectionOfPagination.Item(1), 7),
                                                                   New UCPagination(collectionOfPagination.Item(2), 7),
                                                                   New UCPagination(collectionOfPagination.Item(3), 7)
                                                                   }

        'Asynchronous process of loading 3 tables
        'LeaveCountTask()
        'LeaveSummaryTask()
        'OverBreakCountTask()
        'OverBreakSummaryTask()
        InitializedAllData()


        getDepartment()

    End Sub

#Region "------------------------- Asynchronous process of loading 3 tables --------------------------------"
    Private Async Sub InitializedAllData()
        Await Task.WhenAll(InitializedLeaveCountAsync(),
                           InitializedLeaveSummaryAsync(),
                           InitializedOverBreakCountAsync(),
                            InitializedOverbreakSummaryAsync())
    End Sub
    'Private Async Sub LeaveCountTask()
    '    Try
    '        Await InitializedLeaveCountAsync()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString())
    '    End Try
    'End Sub

    'Private Async Sub LeaveSummaryTask()
    '    Try
    '        Await InitializedLeaveSummaryAsync()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString())
    '    End Try
    'End Sub

    'Private Async Sub OverBreakCountTask()
    '    Try
    '        Await InitializedOverBreakCountAsync()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString())
    '    End Try
    'End Sub

    'Private Async Sub OverBreakSummaryTask()
    '    Try
    '        Await InitializedOverbreakSummaryAsync()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString())
    '    End Try
    'End Sub

#End Region
#Region "------------------------ Events and Methods that applied to all ---------------------------"
    Private Sub UCTimeKeeping_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializedLeaveCountsProperties()
        InitializedLeaveCountPagination()

        InitializedLeaveSummaryProperties()
        InitializedLeaveSummaryPagination()

        InitializedOverbreakCountProperties()
        InitializedOverBreakCountPagination()

        InitializedOverbreakSummaryProperties()
        InitializedOverbreakSummaryPagination()


        Me.dgvLeaveCounts.DoubleBuffered(True)
        Me.dgvLeaveSummary.DoubleBuffered(True)
        Me.dgvOverbreakCounts.DoubleBuffered(True)
        Me.dgvOverbreakSummary.DoubleBuffered(True)

        cmbDepartment.SelectedIndex = -1
        cmbName.SelectedIndex = -1

        dtpFrom.Checked = False
        dtpFrom.CustomFormat = " "
        dtpFrom.Format = DateTimePickerFormat.Custom

        dtpTo.Checked = False
        dtpTo.CustomFormat = " "
        dtpTo.Format = DateTimePickerFormat.Custom

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
    Private Async Sub getDepartment()
        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
            Dim sqlSelect = "Select Distinct Department from [HRIS_2024].[dbo].[Employee]"
            Dim entities = Await db.QueryAsync(Of DistinctEmployeeName)(sqlSelect)
            cmbDepartment.DataSource = entities
            cmbDepartment.DisplayMember = "Department"
            cmbDepartment.SelectedIndex = -1
        End Using
    End Sub

    'get the employeename per department per year, need to inner join the logs and users to get the updated accurate list of employee name
    Private Sub getEmployeeNamePerDept()
        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
            Dim sqlSelect = $"SELECT DISTINCT Name FROM [Employee] WHERE Department = '{cmbDepartment.Text.ToString}'"
            Dim entities = db.Query(Of DistinctEmployeeName)(sqlSelect)
            cmbName.DataSource = entities
            cmbName.DisplayMember = "Name"
            cmbName.SelectedIndex = -1
        End Using
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        getEmployeeNamePerDept()
    End Sub

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Await Task.WhenAll(InitializedLeaveCountAsync(),
                           InitializedLeaveSummaryAsync(),
                           InitializedOverBreakCountAsync(),
                            InitializedOverBreakSummaryAsync())

        cmbDepartment.SelectedIndex = -1
        cmbDepartment.Text = ""
        cmbName.SelectedIndex = -1
        cmbName.Text = ""

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
    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If dtpFrom.Value.Date <= dtpTo.Value.Date Then

            collectionOfPagination(0).totalRecords = completeLeaveCount.Count()
            collectionOfUCPagination(0).ResetPageForAllRecords(collectionOfPagination(0).totalRecords)

            collectionOfPagination(1).totalRecords = completeLeaveReport.Count()
            collectionOfUCPagination(1).ResetPageForAllRecords(collectionOfPagination(1).totalRecords)

            collectionOfPagination(2).totalRecords = completeOverbreakCount.Count()
            collectionOfUCPagination(2).ResetPageForAllRecords(collectionOfPagination(2).totalRecords)

            collectionOfPagination(3).totalRecords = completeOverbreakSummary.Count()
            collectionOfUCPagination(3).ResetPageForAllRecords(collectionOfPagination(3).totalRecords)

            Await Task.WhenAll(FilterLeaveCountAsync(),
                               FilterLeaveSummaryAsync(),
                               FilterOverbreakCountAsync(),
                               FilterOverbreakSummaryAsync())

        Else
            Dim Eventcode = 6
            Dim OK As New DialogBoxOK(Eventcode) With {
            .StartPosition = FormStartPosition.CenterParent,
            .FormBorderStyle = FormBorderStyle.FixedDialog
        }
            OK.ShowDialog()
            Return
        End If

    End Sub

    Private Sub dgv_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvLeaveCounts.DataBindingComplete,
                                                                                                            dgvLeaveSummary.DataBindingComplete,
                                                                                                            dgvOverbreakCounts.DataBindingComplete,
                                                                                                            dgvOverbreakSummary.DataBindingComplete
        sender.ClearSelection()
    End Sub
    Private Sub dgv_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeaveCounts.CellMouseEnter,
                                                                                            dgvLeaveSummary.CellMouseEnter,
                                                                                            dgvOverbreakCounts.CellMouseEnter,
                                                                                            dgvOverbreakSummary.CellMouseEnter
        If e.RowIndex >= 0 Then
            sender.Rows(e.RowIndex).DefaultCellStyle.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub dgv_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeaveCounts.CellMouseLeave,
                                                                                            dgvLeaveSummary.CellMouseLeave,
                                                                                            dgvOverbreakCounts.CellMouseLeave,
                                                                                            dgvOverbreakSummary.CellMouseLeave
        If e.RowIndex >= 0 Then
            sender.Rows(e.RowIndex).DefaultCellStyle.BackColor = sender.DefaultCellStyle.BackColor
        End If
    End Sub
    Private Sub dgv_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles dgvLeaveCounts.ColumnAdded,
                                                                                            dgvLeaveSummary.ColumnAdded,
                                                                                            dgvOverbreakCounts.ColumnAdded,
                                                                                            dgvOverbreakSummary.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

#End Region
#Region "--------------------------------------Leave Counts------------------------------------------"
    Public Async Function InitializedLeaveCountAsync() As Task

        pbLoader_LeaveCounts.Visible = True

        With collectionOfPagination(0)
            completeLeaveCount = Await leaveReportRepo.GetLeaveCountAsync(dtpFrom.MinDate, dtpTo.MaxDate)

            .totalRecords = completeLeaveCount.Count()

            collectionOfUCPagination(0).ResetPageForAllRecords(.totalRecords)

            Dim paginatedcompleteLeaveCount = completeLeaveCount.OrderBy(Function(x) x.Applicant) _
                                                                .Skip(.offset) _
                                                                .Take(.recordsPerPage) _
                                                                .ToList()

            dgvLeaveCounts.DataSource = paginatedcompleteLeaveCount

            pbLoader_LeaveCounts.Visible = False

            dgvLeaveCounts.ClearSelection()
        End With

    End Function
    Private Async Function FilterLeaveCountAsync() As Task

        With collectionOfPagination.Item(0)
            pbLoader_LeaveCounts.Visible = True
            filteredLeaveCount = New List(Of HRIS2024.Models.LeaveCount)

            'Filter by date
            'Regardless of your filter in  combobox and text and what page you are, once you change the date, it will filter all the data(reset)
            'the reset is required to still show filtered data even if you are in the other page of datagridview.
            If dtpFrom.Checked = True And dtpTo.Checked = True Then

                Dim fromDate As Date = dtpFrom.Value.ToShortDateString
                Dim toDate As Date = dtpTo.Value.ToShortDateString

                filteredLeaveCount = Await leaveReportRepo.GetLeaveCountAsync(fromDate, toDate)
            Else

                filteredLeaveCount = Await leaveReportRepo.GetLeaveCountAsync(dtpFrom.MinDate, dtpTo.MaxDate)

            End If

            'Filter by Department
            If cmbDepartment.SelectedIndex <> -1 Then
                filteredLeaveCount = From x In filteredLeaveCount
                                     Where x.Department = cmbDepartment.Text
            End If

            'Filter by Name
            If cmbName.SelectedIndex <> -1 Then
                filteredLeaveCount = If(Not String.IsNullOrEmpty(cmbName.Text),
                                        From x In filteredLeaveCount
                                        Where x.Applicant.Contains(cmbName.Text, StringComparison.OrdinalIgnoreCase),
                                        filteredLeaveCount)
            End If

            .totalRecords = filteredLeaveCount.Count()

            collectionOfUCPagination(0).FilterPage(.totalRecords)

            dgvLeaveCounts.DataSource = filteredLeaveCount.OrderBy(Function(x) x.Applicant) _
                                                          .Skip(.offset) _
                                                          .Take(.recordsPerPage) _
                                                          .ToList()
            pbLoader_LeaveCounts.Visible = False
        End With

    End Function

    Private Sub InitializedLeaveCountsProperties()

        With dgvLeaveCounts
            'Set datagrid to full width
            .Dock = DockStyle.Fill

            'Set the column to full width
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Set the cell border with only horizontal border
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            'Set datagrid grid color
            .GridColor = SystemColors.InactiveBorder

            'Set font for header and body
            .ColumnHeadersDefaultCellStyle.Font = New Font("Roboto", 9)
            .DefaultCellStyle.Font = New Font("Roboto", 9)

            'Set font color  for header and body
            .ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
            .DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark

            'Set alignment for Header and body
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'Set height for body row | In height for header row - I set the height property in columndefaultstyle in control properties
            .RowTemplate.Height = 24

            'Set column headers
            .Columns(0).HeaderText = "Name"
            .Columns(0).ReadOnly = True
            .Columns(0).Visible = True

            .Columns(1).HeaderText = "Department"
            .Columns(1).ReadOnly = True
            .Columns(1).Visible = True

            .Columns(2).HeaderText = "VL"
            .Columns(2).ReadOnly = True
            .Columns(2).Visible = True

            .Columns(3).HeaderText = "SL"
            .Columns(3).ReadOnly = True
            .Columns(3).Visible = True

            .Columns(4).HeaderText = "EL"
            .Columns(4).ReadOnly = True
            .Columns(4).Visible = True

            .Columns(5).HeaderText = "ML"
            .Columns(5).ReadOnly = True
            .Columns(5).Visible = True

            .Columns(6).HeaderText = "PL"
            .Columns(6).ReadOnly = True
            .Columns(6).Visible = True

            .Columns(7).HeaderText = "SPL"
            .Columns(7).ReadOnly = True
            .Columns(7).Visible = True

            .Columns(8).HeaderText = "LWOP"
            .Columns(8).ReadOnly = True
            .Columns(8).Visible = True

            .Columns(9).HeaderText = "IL"
            .Columns(9).ReadOnly = True
            .Columns(9).Visible = True

            .Columns(10).HeaderText = "COVL"
            .Columns(10).ReadOnly = True
            .Columns(10).Visible = True
        End With

    End Sub

    Private Sub InitializedLeaveCountPagination()

        With tblLeaveCount
            .Controls.Add(collectionOfUCPagination.Item(0))
            .SetRow(collectionOfUCPagination.Item(0), 3)
            collectionOfUCPagination.Item(0).Dock = DockStyle.Fill
            AddHandler collectionOfUCPagination.Item(0).PageChanged, AddressOf LeaveCountHandlePageChanged
        End With

    End Sub

    Private Async Sub LeaveCountHandlePageChanged(sender As Object, e As EventArgs)
        Await FilterLeaveCountAsync()
    End Sub
#End Region
#Region "--------------------------------------Leave Summary--------------------------------------"

    Public Async Function InitializedLeaveSummaryAsync() As Task

        pbLoader_LeaveSummary.Visible = True

        With collectionOfPagination(1)

            completeLeaveReport = Await leaveReportRepo.GetAllDataAsync()

            completeLeaveReport = completeLeaveReport.Where(Function(x) x.Status = ConstantVariables.HR_Approve)

            .totalRecords = completeLeaveReport.Count()

            collectionOfUCPagination(1).ResetPageForAllRecords(.totalRecords)

            Dim paginatedcompleteLeaveSummary = completeLeaveReport.OrderBy(Function(x) x.Applicant) _
                                                                   .Skip(.offset) _
                                                                   .Take(.recordsPerPage) _
                                                                   .ToList()

            dgvLeaveSummary.DataSource = paginatedcompleteLeaveSummary

            pbLoader_LeaveSummary.Visible = False

            dgvLeaveSummary.ClearSelection()

        End With

    End Function

    Private Async Function FilterLeaveSummaryAsync() As Task

        With collectionOfPagination.Item(1)

            pbLoader_LeaveSummary.Visible = True

            filteredLeaveReport = New List(Of LeaveReport)
            filteredLeaveReport = completeLeaveReport

            'Filter by date
            'Regardless of your filter in  combobox and text and what page you are, once you change the date, it will filter all the data(reset)
            'the reset is required to still show filtered data even if you are in the other page of datagridview.
            If dtpFrom.Checked = True And dtpTo.Checked = True Then

                Dim fromDate As Date = dtpFrom.Value.ToShortDateString
                Dim toDate As Date = dtpTo.Value.ToShortDateString

                'sa date filter need na laging si complete data ang ifilter para mareset
                filteredLeaveReport = From x In completeLeaveReport
                                      Where x.RequestDate.Date >= fromDate _
                                      And x.RequestDate.Date <= toDate

            End If

            'Filter by Department
            If cmbDepartment.SelectedIndex <> -1 Then
                filteredLeaveReport = From x In filteredLeaveReport
                                      Where x.Department = cmbDepartment.Text
            End If

            'Filter by Name
            If cmbName.SelectedIndex <> -1 Then
                filteredLeaveReport = If(Not String.IsNullOrEmpty(cmbName.Text),
                                     From x In filteredLeaveReport
                                     Where x.Applicant.Contains(cmbName.Text, StringComparison.OrdinalIgnoreCase),
                                     filteredLeaveReport)
            End If

            .totalRecords = filteredLeaveReport.Count()

            collectionOfUCPagination(1).FilterPage(.totalRecords)

            dgvLeaveSummary.DataSource = filteredLeaveReport.OrderBy(Function(x) x.Applicant) _
                                                            .Skip(.offset) _
                                                            .Take(.recordsPerPage) _
                                                            .ToList()

            pbLoader_LeaveSummary.Visible = False

        End With

    End Function
    Private Sub InitializedLeaveSummaryProperties()

        With dgvLeaveSummary

            'Set datagrid to full width
            .Dock = DockStyle.Fill

            'Set the column to full width
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Set the cell border with only horizontal border
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            'Set datagrid grid color
            .GridColor = SystemColors.InactiveBorder

            'Set font for header and body
            .ColumnHeadersDefaultCellStyle.Font = New Font("Roboto", 9)
            .DefaultCellStyle.Font = New Font("Roboto", 9)

            'Set font color  for header and body
            .ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
            .DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark

            'Set alignment for Header and body
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'Set height for body row | In height for header row - I set the height property in columndefaultstyle in control properties
            .RowTemplate.Height = 24

            'Set column headers
            .Columns(0).HeaderText = "Application ID"
            .Columns(0).ReadOnly = True
            .Columns(0).Visible = True

            .Columns(1).HeaderText = "Name"
            .Columns(1).ReadOnly = True
            .Columns(1).Visible = True

            .Columns(2).HeaderText = "Date of Application"
            .Columns(2).ReadOnly = True
            .Columns(2).Visible = True

            .Columns(3).HeaderText = "Department"
            .Columns(3).ReadOnly = True
            .Columns(3).Visible = True

            .Columns(4).HeaderText = "Position"
            .Columns(4).ReadOnly = True
            .Columns(4).Visible = True

            .Columns(5).HeaderText = "Request Type"
            .Columns(5).ReadOnly = True
            .Columns(5).Visible = True

            .Columns(6).HeaderText = "Request Date"
            .Columns(6).ReadOnly = True
            .Columns(6).Visible = True
            .Columns(6).DefaultCellStyle.Format = "MMMM dd, yyyy"

            .Columns(7).HeaderText = "Status"
            .Columns(7).ReadOnly = True
            .Columns(7).Visible = True

        End With

    End Sub

    Private Sub InitializedLeaveSummaryPagination()

        With tblLeaveSummary

            .Controls.Add(collectionOfUCPagination.Item(1))
            .SetRow(collectionOfUCPagination.Item(1), 3)
            collectionOfUCPagination.Item(1).Dock = DockStyle.Fill
            AddHandler collectionOfUCPagination.Item(1).PageChanged, AddressOf LeaveSummaryHandlePageChanged

        End With

    End Sub

    Private Async Sub LeaveSummaryHandlePageChanged(sender As Object, e As EventArgs)
        Await FilterLeaveSummaryAsync()
    End Sub

    Private Async Sub dgvLeaveSummary_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLeaveSummary.CellMouseClick

        'early return if user click header
        If e.RowIndex < 0 Then
            Return
        End If

        If String.Equals(FormLogin.UserDetail.Type, ConstantVariables.Manager, StringComparison.OrdinalIgnoreCase) OrElse
           String.Equals(FormLogin.UserDetail.Type, ConstantVariables.Timekeeper, StringComparison.OrdinalIgnoreCase) Then

            ' Get the value of the cell
            Dim ApplicationID = dgvLeaveSummary.Rows(e.RowIndex).Cells("ApplicationID").Value.ToString()

            Dim fullInformationRepo As IFullInformation_Repository = New Leave_Service
            Dim fullInformationEntities As viewFullInformation = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
            Dim informationForm As Form = New Form_ViewLeave(fullInformationEntities, dgvLeaveSummary.Name)


            If informationForm IsNot Nothing Then

                With informationForm
                    .StartPosition = FormStartPosition.CenterParent
                    .FormBorderStyle = FormBorderStyle.FixedDialog
                    .ShowDialog()
                End With

            End If

        End If

    End Sub

#End Region
#Region "--------------------------------------OverBreak Counts--------------------------------------"
    Public Async Function InitializedOverBreakCountAsync() As Task
        pbLoader_OverBreakCounts.Visible = True

        With collectionOfPagination(2)
            completeOverbreakCount = Await overbreakRepo.GetCounts(dtpFrom.MinDate, dtpTo.MaxDate)

            .totalRecords = completeOverbreakCount.Count()

            collectionOfUCPagination(2).ResetPageForAllRecords(.totalRecords)

            Dim paginatedcompleteOverbreakCount = completeOverbreakCount.OrderBy(Function(x) x.EmployeeName) _
                                                                .Skip(.offset) _
                                                                .Take(.recordsPerPage) _
                                                                .ToList()

            dgvOverbreakCounts.DataSource = paginatedcompleteOverbreakCount

            pbLoader_OverBreakCounts.Visible = False

            dgvOverbreakCounts.ClearSelection()
        End With
    End Function

    Private Async Function FilterOverbreakCountAsync() As Task

        With collectionOfPagination.Item(2)
            pbLoader_OverBreakCounts.Visible = True
            filteredOverbreakCount = New List(Of HRIS2024.Models.OverBreakCount)

            'Filter by date
            'Regardless of your filter in  combobox and text and what page you are, once you change the date, it will filter all the data(reset)
            'the reset is required to still show filtered data even if you are in the other page of datagridview.
            If dtpFrom.Checked = True And dtpTo.Checked = True Then

                Dim fromDate As Date = dtpFrom.Value.ToShortDateString
                Dim toDate As Date = dtpTo.Value.ToShortDateString

                filteredOverbreakCount = Await overbreakRepo.GetCounts(fromDate, toDate)
            Else

                filteredOverbreakCount = Await overbreakRepo.GetCounts(dtpFrom.MinDate, dtpTo.MaxDate)

            End If

            'Filter by Department
            If cmbDepartment.SelectedIndex <> -1 Then
                filteredOverbreakCount = From x In filteredOverbreakCount
                                         Where x.Department = cmbDepartment.Text
            End If

            'Filter by Name
            If cmbName.SelectedIndex <> -1 Then
                filteredOverbreakCount = If(Not String.IsNullOrEmpty(cmbName.Text),
                                     From x In filteredOverbreakCount
                                     Where x.EmployeeName.Contains(cmbName.Text, StringComparison.OrdinalIgnoreCase),
                                     filteredOverbreakCount)
            End If

            .totalRecords = filteredOverbreakCount.Count()

            collectionOfUCPagination(2).FilterPage(.totalRecords)

            dgvOverbreakCounts.DataSource = filteredOverbreakCount.OrderBy(Function(x) x.EmployeeName) _
                                                                  .Skip(.offset) _
                                                                  .Take(.recordsPerPage) _
                                                                  .ToList()
            pbLoader_OverBreakCounts.Visible = False
        End With

    End Function

    Private Sub InitializedOverbreakCountProperties()

        With dgvOverbreakCounts
            'Set datagrid to full width
            .Dock = DockStyle.Fill
            .VirtualMode = True

            'Set the column to full width
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Set the cell border with only horizontal border
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            'Set datagrid grid color
            .GridColor = SystemColors.InactiveBorder

            'Set font for header and body
            .ColumnHeadersDefaultCellStyle.Font = New Font("Roboto", 9)
            .DefaultCellStyle.Font = New Font("Roboto", 9)

            'Set font color  for header and body
            .ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
            .DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark

            'Set alignment for Header and body
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'Set height for body row | In height for header row - I set the height property in columndefaultstyle in control properties
            .RowTemplate.Height = 24

            'Set column headers
            .Columns(0).HeaderText = "Name"
            .Columns(0).ReadOnly = True
            .Columns(0).Visible = True

            .Columns(1).HeaderText = "Department"
            .Columns(1).ReadOnly = True
            .Columns(1).Visible = True

            .Columns(2).HeaderText = "Pending"
            .Columns(2).ReadOnly = True
            .Columns(2).Visible = True
            .Columns(2).FillWeight = 50

            .Columns(3).HeaderText = "Disapproved"
            .Columns(3).ReadOnly = True
            .Columns(3).Visible = True
            .Columns(3).FillWeight = 50

            .Columns(4).HeaderText = "Approved"
            .Columns(4).ReadOnly = True
            .Columns(4).Visible = True
            .Columns(4).FillWeight = 50

            .Columns(5).HeaderText = "Date"
            .Columns(5).ReadOnly = True
            .Columns(5).Visible = False
        End With

    End Sub

    Private Sub InitializedOverBreakCountPagination()

        With tblOverBreakCounts
            .Controls.Add(collectionOfUCPagination.Item(2))
            .SetRow(collectionOfUCPagination.Item(0), 3)
            collectionOfUCPagination.Item(2).Dock = DockStyle.Fill
            AddHandler collectionOfUCPagination.Item(2).PageChanged, AddressOf OverbreakCountHandlePageChanged
        End With

    End Sub

    Private Async Sub OverbreakCountHandlePageChanged(sender As Object, e As EventArgs)
        Await FilterOverbreakCountAsync()
    End Sub

#End Region
#Region "--------------------------------------OverBreak Summary--------------------------------------"
    Public Async Function InitializedOverbreakSummaryAsync() As Task

        pbLoader_OverBreakSummary.Visible = True

        With collectionOfPagination(3)

            completeOverbreakSummary = Await overbreakRepo.GetSummary()

            completeOverbreakSummary = completeOverbreakSummary

            .totalRecords = completeOverbreakSummary.Count()

            collectionOfUCPagination(3).ResetPageForAllRecords(.totalRecords)

            Dim paginatedcompleteOverbreakSummary = completeOverbreakSummary.OrderBy(Function(x) x.EmployeeName) _
                                                                   .Skip(.offset) _
                                                                   .Take(.recordsPerPage) _
                                                                   .ToList()

            dgvOverbreakSummary.DataSource = paginatedcompleteOverbreakSummary

            pbLoader_OverBreakSummary.Visible = False

            dgvOverbreakSummary.ClearSelection()

        End With

    End Function

    Private Async Function FilterOverbreakSummaryAsync() As Task


        With collectionOfPagination.Item(3)

            pbLoader_OverBreakSummary.Visible = True

            filteredOverbreakSummary = New List(Of HRIS2024.Models.OverBreakSummary)
            filteredOverbreakSummary = completeOverbreakSummary

            'Filter by date
            'Regardless of your filter in  combobox and text and what page you are, once you change the date, it will filter all the data(reset)
            'the reset is required to still show filtered data even if you are in the other page of datagridview.
            If dtpFrom.Checked = True And dtpTo.Checked = True Then

                Dim fromDate As Date = dtpFrom.Value.ToShortDateString
                Dim toDate As Date = dtpTo.Value.ToShortDateString

                'sa date filter need na laging si complete data ang ifilter para mareset
                filteredOverbreakSummary = From x In completeOverbreakSummary
                                           Where x.StartTime.Date >= fromDate _
                                      And x.StartTime.Date <= toDate

            End If

            'Filter by Department
            If cmbDepartment.SelectedIndex <> -1 Then
                filteredOverbreakSummary = From x In filteredOverbreakSummary
                                           Where x.Department = cmbDepartment.Text
            End If

            'Filter by Name
            If cmbName.SelectedIndex <> -1 Then
                filteredOverbreakSummary = If(Not String.IsNullOrEmpty(cmbName.Text),
                                     From x In filteredOverbreakSummary
                                     Where x.EmployeeName.Contains(cmbName.Text, StringComparison.OrdinalIgnoreCase),
                                     filteredOverbreakSummary)
            End If

            .totalRecords = filteredOverbreakSummary.Count()

            collectionOfUCPagination(3).FilterPage(.totalRecords)

            dgvOverbreakSummary.DataSource = filteredOverbreakSummary.OrderBy(Function(x) x.EmployeeName) _
                                                            .Skip(.offset) _
                                                            .Take(.recordsPerPage) _
                                                            .ToList()

            pbLoader_OverBreakSummary.Visible = False

        End With

    End Function
    Private Sub InitializedOverbreakSummaryProperties()

        With dgvOverbreakSummary

            'Set datagrid to full width
            .Dock = DockStyle.Fill
            .VirtualMode = True

            'Set the column to full width
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Set the cell border with only horizontal border
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            'Set datagrid grid color
            .GridColor = SystemColors.InactiveBorder

            'Set font for header and body
            .ColumnHeadersDefaultCellStyle.Font = New Font("Roboto", 9)
            .DefaultCellStyle.Font = New Font("Roboto", 9)

            'Set font color  for header and body
            .ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
            .DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark

            'Set alignment for Header and body
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'Set height for body row | In height for header row - I set the height property in columndefaultstyle in control properties
            .RowTemplate.Height = 24

            'Set column headers
            .Columns(0).HeaderText = "Name"
            .Columns(0).ReadOnly = True
            .Columns(0).Visible = True

            .Columns(1).HeaderText = "Department"
            .Columns(1).ReadOnly = True
            .Columns(1).Visible = True
            .Columns(1).FillWeight = 50

            .Columns(2).HeaderText = "Start Time"
            .Columns(2).ReadOnly = True
            .Columns(2).Visible = True

            .Columns(3).HeaderText = "Type of Break"
            .Columns(3).ReadOnly = True
            .Columns(3).Visible = True

            .Columns(4).HeaderText = "End Time"
            .Columns(4).ReadOnly = True
            .Columns(4).Visible = True

            .Columns(5).HeaderText = "Remarks"
            .Columns(5).ReadOnly = True
            .Columns(5).Visible = True
            .Columns(5).FillWeight = 150

            .Columns(6).HeaderText = "Duration"
            .Columns(6).ReadOnly = True
            .Columns(6).Visible = True
            .Columns(6).FillWeight = 50

            .Columns(7).HeaderText = "Over Break"
            .Columns(7).ReadOnly = True
            .Columns(7).Visible = True
            .Columns(7).FillWeight = 50

            .Columns(8).HeaderText = "Status"
            .Columns(8).ReadOnly = True
            .Columns(8).Visible = True
            .Columns(8).FillWeight = 50

        End With

    End Sub

    Private Sub InitializedOverbreakSummaryPagination()

        With tblOverBreakSummary

            .Controls.Add(collectionOfUCPagination.Item(3))
            .SetRow(collectionOfUCPagination.Item(3), 3)
            collectionOfUCPagination.Item(3).Dock = DockStyle.Fill
            AddHandler collectionOfUCPagination.Item(3).PageChanged, AddressOf OverbreakSummaryHandlePageChanged

        End With

    End Sub

    Private Async Sub OverbreakSummaryHandlePageChanged(sender As Object, e As EventArgs)
        Await FilterOverbreakSummaryAsync()
    End Sub


#End Region



#Region "'-------------------------------------------- Export Task ---------------------------------------------------"
    Private Async Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try

            ' Await all tasks to complete
            Await Task.WhenAll(ExcelExport_LeaveCount(),
                                ExcelExport_LeaveSummary(),
                                ExcelExport_OverBreakCounts(),
                                ExcelExport_OverBreakSummary())

            Using sfd As SaveFileDialog = New SaveFileDialog With {.Filter = "Excel Workbook|*.xlsx", .FileName = $"Leave Record {DateTime.Now().ToString("yyyyMMdd")}"}
                If sfd.ShowDialog() = DialogResult.OK Then
                    Using workbook As XLWorkbook = Await Task.Run(Function() New XLWorkbook())
                        workbook.Worksheets.Add(DataTable_LeaveCount, "Leave Count")
                        workbook.Worksheets.Add(DataTable_LeaveSummary, "Leave Summary")
                        workbook.Worksheets.Add(DataTable_OverbreakCounts, "Over Break Counts")
                        workbook.Worksheets.Add(DataTable_OverbreakSummary, "Over Break Summary")
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
    Private Async Function ExcelExport_LeaveCount() As Task
        Try

            Await FilterLeaveCountAsync()

            DataTable_LeaveCount = New DataTable

            ' Add columns to the DataTable
            DataTable_LeaveCount.Columns.Add("Applicant", GetType(String))
            DataTable_LeaveCount.Columns.Add("Department", GetType(String))
            DataTable_LeaveCount.Columns.Add("VL_Count", GetType(String))
            DataTable_LeaveCount.Columns.Add("SL_Count", GetType(String))
            DataTable_LeaveCount.Columns.Add("EL_Count", GetType(String))
            DataTable_LeaveCount.Columns.Add("ML_Count", GetType(String))
            DataTable_LeaveCount.Columns.Add("PL_Count", GetType(String))
            DataTable_LeaveCount.Columns.Add("SPL_Count", GetType(String))
            DataTable_LeaveCount.Columns.Add("LWOP_Count", GetType(String))
            DataTable_LeaveCount.Columns.Add("IL_Count", GetType(String))
            DataTable_LeaveCount.Columns.Add("COVL_Count", GetType(String))
            DataTable_LeaveCount.Columns.Add("MCW_Count", GetType(String))

            For Each LeaveCountData In filteredLeaveCount

                Dim rowData As New List(Of String)()
                rowData.Add(LeaveCountData.Applicant?.ToString())
                rowData.Add(LeaveCountData.Department?.ToString())
                rowData.Add(LeaveCountData.VL_Count.ToString())
                rowData.Add(LeaveCountData.SL_Count.ToString())
                rowData.Add(LeaveCountData.EL_Count.ToString())
                rowData.Add(LeaveCountData.ML_Count.ToString())
                rowData.Add(LeaveCountData.PL_Count.ToString())
                rowData.Add(LeaveCountData.SPL_Count.ToString())
                rowData.Add(LeaveCountData.LWOP_Count.ToString())
                rowData.Add(LeaveCountData.IL_Count.ToString())
                rowData.Add(LeaveCountData.COVL_Count.ToString())
                rowData.Add(LeaveCountData.MCW_Count.ToString())

                'Add each data to datatable
                DataTable_LeaveCount.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
        End Try
    End Function
    Private Async Function ExcelExport_LeaveSummary() As Task
        Try
            Await FilterLeaveSummaryAsync()

            DataTable_LeaveSummary = New DataTable

            ' Add columns to the DataTable
            DataTable_LeaveSummary.Columns.Add("ApplicationID", GetType(String))
            DataTable_LeaveSummary.Columns.Add("Applicant", GetType(String))
            DataTable_LeaveSummary.Columns.Add("ApplicationDate", GetType(String))
            DataTable_LeaveSummary.Columns.Add("Department", GetType(String))
            DataTable_LeaveSummary.Columns.Add("Position", GetType(String))
            DataTable_LeaveSummary.Columns.Add("LeaveType", GetType(String))
            DataTable_LeaveSummary.Columns.Add("LeaveDate", GetType(String))
            DataTable_LeaveSummary.Columns.Add("Status", GetType(String))

            For Each LeaveSummaryData In filteredLeaveReport

                Dim rowData As New List(Of String)()
                rowData.Add(LeaveSummaryData.ApplicationID?.ToString())
                rowData.Add(LeaveSummaryData.Applicant?.ToString())
                rowData.Add(LeaveSummaryData.RequestDate.ToString())
                rowData.Add(LeaveSummaryData.Department?.ToString())
                rowData.Add(LeaveSummaryData.Position?.ToString())
                rowData.Add(LeaveSummaryData.RequestType?.ToString())
                rowData.Add(LeaveSummaryData.RequestDate.ToString())
                rowData.Add(LeaveSummaryData.Status?.ToString())

                'Add each data to datatable
                DataTable_LeaveSummary.Rows.Add(rowData.ToArray())
            Next

        Catch ex As Exception
        End Try
    End Function
    Private Async Function ExcelExport_OverBreakCounts() As Task
        Try

            Await FilterOverbreakCountAsync()

            DataTable_OverbreakCounts = New DataTable

            ' Add columns to the DataTable
            DataTable_OverbreakCounts.Columns.Add("EmployeeName", GetType(String))
            DataTable_OverbreakCounts.Columns.Add("Department", GetType(String))
            DataTable_OverbreakCounts.Columns.Add("Pending", GetType(String))
            DataTable_OverbreakCounts.Columns.Add("DisApproved", GetType(String))
            DataTable_OverbreakCounts.Columns.Add("Approved", GetType(String))

            For Each OverBreakCountsData In filteredOverbreakCount

                Dim rowData As New List(Of String)()
                rowData.Add(OverBreakCountsData.EmployeeName?.ToString())
                rowData.Add(OverBreakCountsData.Department?.ToString())
                rowData.Add(OverBreakCountsData.Pending.ToString())
                rowData.Add(OverBreakCountsData.DisApproved.ToString())
                rowData.Add(OverBreakCountsData.Approved.ToString())

                'Add each data to datatable
                DataTable_OverbreakCounts.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
        End Try
    End Function
    Private Async Function ExcelExport_OverBreakSummary() As Task
        Try

            Await FilterOverbreakSummaryAsync()

            DataTable_OverbreakSummary = New DataTable

            ' Add columns to the DataTable
            DataTable_OverbreakSummary.Columns.Add("EmployeeName", GetType(String))
            DataTable_OverbreakSummary.Columns.Add("Department", GetType(String))
            DataTable_OverbreakSummary.Columns.Add("StartTime", GetType(String))
            DataTable_OverbreakSummary.Columns.Add("BreakType", GetType(String))
            DataTable_OverbreakSummary.Columns.Add("EndTime", GetType(String))
            DataTable_OverbreakSummary.Columns.Add("Remarks", GetType(String))
            DataTable_OverbreakSummary.Columns.Add("Duration", GetType(String))
            DataTable_OverbreakSummary.Columns.Add("Overbreak", GetType(String))
            DataTable_OverbreakSummary.Columns.Add("Status", GetType(String))

            For Each OverBreakSummaryData In filteredOverbreakSummary

                Dim rowData As New List(Of String)()
                rowData.Add(OverBreakSummaryData.EmployeeName?.ToString())
                rowData.Add(OverBreakSummaryData.Department?.ToString())
                rowData.Add(OverBreakSummaryData.StartTime.ToString())
                rowData.Add(OverBreakSummaryData.BreakType.ToString())
                rowData.Add(OverBreakSummaryData.EndTime.ToString())
                rowData.Add(OverBreakSummaryData.Remarks.ToString())
                rowData.Add(OverBreakSummaryData.Duration.ToString())
                rowData.Add(OverBreakSummaryData.Overbreak?.ToString())
                rowData.Add(OverBreakSummaryData.HRApproved?.ToString())

                'Add each data to datatable
                DataTable_OverbreakSummary.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
        End Try
    End Function
#End Region
End Class

