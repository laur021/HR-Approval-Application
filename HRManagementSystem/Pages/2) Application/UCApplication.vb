Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports System.Text
Imports System.Text.RegularExpressions
Imports Dapper
Imports HRIS2024.DataAccess
Imports HRIS2024.Models
Imports HRIS2024.Utility
Imports ReaLTaiizor.Drawing.Poison.PoisonPaint.BorderColor

Public Class UCApplication

    Private ApplicationID As String
    Private ApplicationType As String

    Private currentPage As Integer = 1
    Private recordsPerPage As Integer = 15
    Private totalRecords As Integer = 0
    Private totalPages As Integer = 0
    Private offset As Integer = 0

    Private ReadOnly ApplicationRepository As IApplication_Repository

    Public Sub New()

        InitializeComponent()

        ApplicationRepository = New Application_Repository

        InitializedAllDataAsync()

    End Sub

#Region "Encaspsulate all function into 1 method"
    Public Async Sub InitializedAllDataAsync()

        Await Task.WhenAll(RunLeaveAsync,
                     RunChangeShiftAsync,
                     RunOverTimeAsync,
                     RunLateAsync,
                     RunInfractionsAsync)
    End Sub
#End Region
#Region "All Function to retrieve data asynchronously"
    Public Async Function RunLeaveAsync() As Task

        Await InitializedData(pbLoader_Leave, ConstantVariables.LeaveApplication, dgv_Leave)
        InitializedDatagridProperties(dgv_Leave)
        CountOfPendingInTabPage.CountofPending(TabLeave)

    End Function

    Public Async Function RunChangeShiftAsync() As Task

        Await InitializedData(pbLoader_ChangeShift, ConstantVariables.ChangeShiftApplication, dgv_ChangeShift)
        InitializedDatagridProperties(dgv_ChangeShift)
        CountOfPendingInTabPage.CountofPending(TabChangeShift)

    End Function

    Public Async Function RunOverTimeAsync() As Task

        Await InitializedData(pbLoader_OverTime, ConstantVariables.OverTimeApplication, dgv_OverTime)
        InitializedDatagridProperties(dgv_OverTime)
        CountOfPendingInTabPage.CountofPending(TabOverTime)

    End Function

    Public Async Function RunLateAsync() As Task

        Await InitializedData(pbLoader_Late, ConstantVariables.LateApplication, dgv_Late)
        InitializedDatagridProperties(dgv_Late)
        CountOfPendingInTabPage.CountofPending(TabLate)

    End Function

    Public Async Function RunInfractionsAsync() As Task

        Await InitializedData(pbLoader_Infractions, ConstantVariables.Infraction, dgv_Infractions)
        InitializedDatagridProperties(dgv_Infractions)
        CountOfPendingInTabPage.CountofPending(TabInfractions)
    End Function
#End Region
    Private Async Function InitializedData(loader As PictureBox, AppType As String, dgv As DataGridView) As Task

        Dim entities As IEnumerable(Of HRIS2024.Models.Application) = Await ApplicationRepository.GetAllDataAsync
        loader.Visible = True
        Dim filteredEntities = entities.Where(Function(x) _
                                            x.Status = ConstantVariables.HR_Pending And
                                            x.ApplicationType = AppType).OrderBy(Function(x) x.ApplicationDate)

        dgv.DataSource = filteredEntities.ToList()
        Await Task.Delay(1000)
        loader.Visible = False

    End Function

    Private Sub InitializedDatagridProperties(dgv As DataGridView)

        PageDatagridProperties.InitializedTheme(dgv)

        With dgv

            .Columns(0).HeaderText = "ID"
            .Columns(0).ReadOnly = True
            .Columns(0).Visible = False

            .Columns(1).HeaderText = "Application ID"
            .Columns(1).ReadOnly = True
            .Columns(1).Visible = True

            .Columns(2).HeaderText = "Name"
            .Columns(2).ReadOnly = True
            .Columns(2).Visible = True

            .Columns(3).HeaderText = "Department"
            .Columns(3).ReadOnly = True
            .Columns(3).Visible = True

            .Columns(4).HeaderText = "Position"
            .Columns(4).ReadOnly = True
            .Columns(4).Visible = False

            .Columns(5).HeaderText = "Type of Application"
            .Columns(5).ReadOnly = True
            .Columns(5).Visible = True

            .Columns(6).HeaderText = "Date of Application"
            .Columns(6).ReadOnly = True
            .Columns(6).Visible = True

            .Columns(7).HeaderText = "Total No. of days"
            .Columns(7).ReadOnly = True
            .Columns(7).Visible = False

            .Columns(8).HeaderText = "Leader Approved By"
            .Columns(8).ReadOnly = True
            .Columns(8).Visible = True

            .Columns(9).HeaderText = "Leader Approved Date"
            .Columns(9).ReadOnly = True
            .Columns(9).Visible = True

            .Columns(10).HeaderText = "Manager Approved by"
            .Columns(10).ReadOnly = True
            .Columns(10).Visible = True

            .Columns(11).HeaderText = "Manager Approved date"
            .Columns(11).ReadOnly = True
            .Columns(11).Visible = True

            .Columns(12).HeaderText = "Status"
            .Columns(12).ReadOnly = True
            .Columns(12).Visible = True

            .Columns(13).HeaderText = "HR Approved by"
            .Columns(13).ReadOnly = True
            .Columns(13).Visible = True

            .Columns(14).HeaderText = "HR Approved date"
            .Columns(14).ReadOnly = True
            .Columns(14).Visible = True

            .Columns(15).HeaderText = "isDirectToHR"
            .Columns(15).ReadOnly = True
            .Columns(15).Visible = False

            .Columns(16).HeaderText = "isLeader"
            .Columns(16).ReadOnly = True
            .Columns(16).Visible = False

            .Columns(17).HeaderText = "isManager"
            .Columns(17).ReadOnly = True
            .Columns(17).Visible = False

            .Columns(18).HeaderText = "isCancelled"
            .Columns(18).ReadOnly = True
            .Columns(18).Visible = False

            .Columns(19).HeaderText = "UpdateTime"
            .Columns(19).ReadOnly = True
            .Columns(19).Visible = False

            .Columns(20).HeaderText = "isRead"
            .Columns(20).ReadOnly = True
            .Columns(20).Visible = False

        End With

    End Sub

    'remove the initial selection of row in datagrid
    Private Sub dgvLeave_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgv_Leave.DataBindingComplete,
                                                                                                             dgv_ChangeShift.DataBindingComplete,
                                                                                                             dgv_OverTime.DataBindingComplete,
                                                                                                             dgv_Late.DataBindingComplete,
                                                                                                             dgv_Infractions.DataBindingComplete


        sender.ClearSelection()

    End Sub

    Private Sub dgvLeave_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_Leave.CellFormatting,
                                                                                                             dgv_ChangeShift.CellFormatting,
                                                                                                             dgv_OverTime.CellFormatting,
                                                                                                             dgv_Late.CellFormatting,
                                                                                                             dgv_Infractions.CellFormatting

        For Each row As DataGridViewRow In sender.Rows
            If row.Cells("isCancelled").Value = "True" Then
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#dacbcb")
            End If
        Next

    End Sub

    Private Sub dgvLeaveApplication_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Leave.CellMouseEnter,
                                                                                                             dgv_ChangeShift.CellMouseEnter,
                                                                                                             dgv_OverTime.CellMouseEnter,
                                                                                                             dgv_Late.CellMouseEnter,
                                                                                                             dgv_Infractions.CellMouseEnter
        If e.RowIndex >= 0 Then
            sender.Rows(e.RowIndex).DefaultCellStyle.BackColor = SystemColors.Control
        End If

    End Sub
    Private Sub dgvLeaveApplication_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Leave.CellMouseLeave,
                                                                                                             dgv_ChangeShift.CellMouseLeave,
                                                                                                             dgv_OverTime.CellMouseLeave,
                                                                                                             dgv_Late.CellMouseLeave,
                                                                                                             dgv_Infractions.CellMouseLeave
        If e.RowIndex >= 0 Then
            sender.Rows(e.RowIndex).DefaultCellStyle.BackColor = sender.DefaultCellStyle.BackColor
        End If

    End Sub
    Private Sub dgvLeaveApplication_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles dgv_Leave.ColumnAdded,
                                                                                                             dgv_ChangeShift.ColumnAdded,
                                                                                                             dgv_OverTime.ColumnAdded,
                                                                                                             dgv_Late.ColumnAdded,
                                                                                                             dgv_Infractions.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Async Sub dgvLeave_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_Leave.CellMouseClick,
                                                                                                             dgv_ChangeShift.CellMouseClick,
                                                                                                             dgv_OverTime.CellMouseClick,
                                                                                                             dgv_Late.CellMouseClick,
                                                                                                             dgv_Infractions.CellMouseClick

        'Early return if not manager
        If Not String.Equals(FormLogin.UserDetail.Type, ConstantVariables.Manager, StringComparison.OrdinalIgnoreCase) Then
            Return
        End If

        'early return if user click header
        If e.RowIndex < 0 Then
            Return
        End If

        ' Get the value of the cell
        ApplicationID = sender.Rows(e.RowIndex).Cells("ApplicationID").Value.ToString()
        ApplicationType = sender.Rows(e.RowIndex).Cells("ApplicationType").Value.ToString()

        Dim fullInformationRepo As IFullInformation_Repository = Nothing
        Dim fullInformationEntities As viewFullInformation = Nothing
        Dim informationForm As Form = Nothing
        Dim pbloader As PictureBox = Nothing
        Dim appType As String = String.Empty
        Dim tab As TabPage = Nothing

        Select Case sender.name

            Case dgv_Leave.Name
                fullInformationRepo = New Leave_Service
                fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                informationForm = New Form_ViewLeave(fullInformationEntities, dgv_Leave.Name)
                pbloader = pbLoader_Leave
                appType = ConstantVariables.LeaveApplication
                tab = TabLeave
                Exit Select

            Case dgv_ChangeShift.Name
                fullInformationRepo = New ChangeShift_Service
                fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                informationForm = New Form_ViewChangeShift(fullInformationEntities, dgv_ChangeShift.Name)
                pbloader = pbLoader_ChangeShift
                appType = ConstantVariables.ChangeShiftApplication
                tab = TabChangeShift
                Exit Select

            Case dgv_OverTime.Name
                fullInformationRepo = New Overtime_Service
                fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                informationForm = New Form_ViewOverTime(fullInformationEntities, dgv_OverTime.Name)
                pbloader = pbLoader_OverTime
                appType = ConstantVariables.OverTimeApplication
                tab = TabOverTime
                Exit Select

            Case dgv_Late.Name
                fullInformationRepo = New Late_Service
                fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                informationForm = New Form_ViewLate(fullInformationEntities, dgv_Late.Name)
                pbloader = pbLoader_Late
                appType = ConstantVariables.LateApplication
                tab = TabLate
                Exit Select

            Case dgv_Infractions.Name
                fullInformationRepo = New Infraction_Service
                fullInformationEntities = Await fullInformationRepo.GetFullInformationAsync(ApplicationID)
                informationForm = New Form_ViewInfraction(fullInformationEntities, dgv_Infractions.Name)
                pbloader = pbLoader_Infractions
                appType = ConstantVariables.Infraction
                tab = TabInfractions
                Exit Select

        End Select

        If informationForm IsNot Nothing Then

            With informationForm
                .StartPosition = FormStartPosition.CenterParent
                .FormBorderStyle = FormBorderStyle.FixedDialog
                .ShowDialog()

                If .DialogResult = DialogResult.OK Or .DialogResult = DialogResult.Yes Then
                    Await InitializedData(pbloader, appType, sender)
                    CountOfPendingInTabPage.CountofPending(tab)
                End If

            End With
        End If

    End Sub

    Private Sub UCApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl_Type.Font = New Font("Roboto", 9.5, FontStyle.Regular)
        dgv_Leave.DoubleBuffered(True)
        dgv_ChangeShift.DoubleBuffered(True)
        dgv_OverTime.DoubleBuffered(True)
        dgv_Late.DoubleBuffered(True)
        dgv_Infractions.DoubleBuffered(True)
    End Sub

End Class
