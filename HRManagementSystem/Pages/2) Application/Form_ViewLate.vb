Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Dapper
Imports HRIS2024.DataAccess
Imports HRIS2024.Models

Public Class Form_ViewLate

    Private ReadOnly _fullInformation As viewFullInformation
    Private ReadOnly ApplicationRepository As IApplication_Repository
    Private ReadOnly CommentRepository As IComment_Repository
    Private ReadOnly LateRepository As ILate_Repository

    Private ApplicationID As String
    Dim EventCode As Integer = 0

    Public Sub New(fullInformation As viewFullInformation, Optional dgvName As String = "")

        InitializeComponent()

        _fullInformation = fullInformation
        ApplicationRepository = New Application_Repository
        LateRepository = New Late_Repository
        CommentRepository = New Comment_Repository

        With _fullInformation

            'Get the RequestID
            ApplicationID = .Application.ApplicationID

            'Assign the Application Data to labels and textboxes
            lblApplicationID.Text = .Application.ApplicationID
            lblName.Text = .Application.Applicant
            lblDepartment.Text = .Application.Department
            lblDate.Text = .Application.ApplicationDate.ToString("MMMM dd, yyyy")
            lblPosition.Text = .Application.Position

            If .Application.isCancelled = "True" Then

                lblApplicationID.BackColor = ColorTranslator.FromHtml("#dacbcb")
                lblLeaveDetails.BackColor = ColorTranslator.FromHtml("#dacbcb")

            End If

            If .Comment IsNot Nothing AndAlso .Comment.Any() Then
                With dgComments
                    dgComments.DataSource = _fullInformation.Comment.OrderBy(Function(x) x.AddedDate).ToList()

                    dgComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    dgComments.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    dgComments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    dgComments.RowsDefaultCellStyle.Padding = New Padding(0, 20, 0, 20)
                    dgComments.DefaultCellStyle.Font = New Font("Roboto", 8, FontStyle.Regular)
                    dgComments.DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
                    dgComments.ReadOnly = True


                    dgComments.Columns("Id").Visible = False
                    dgComments.Columns("ApplicationID").Visible = False

                    dgComments.Columns("Commentor").Visible = True
                    dgComments.Columns("Commentor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
                    dgComments.Columns("Commentor").FillWeight = 150

                    dgComments.Columns("Comment").Visible = True
                    dgComments.Columns("Comment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
                    dgComments.Columns("Comment").FillWeight = 300

                    dgComments.Columns("Status").Visible = True
                    dgComments.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
                    dgComments.Columns("Status").FillWeight = 120

                    dgComments.Columns("AddedDate").Visible = True
                    dgComments.Columns("AddedDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
                    dgComments.Columns("AddedDate").FillWeight = 135
                End With

            End If

            'Hide the approve and reject button if the status is reject or approve
            If .Application.Status = ConstantVariables.HR_Approve Or .Application.Status = ConstantVariables.HR_Reject Then

                'I used remove because there's a conflict between material skin and button. the button still show despite of visible false
                tblbutton.Controls.Remove(btnApprove)
                tblbutton.Controls.Remove(btnReject)

                'hide this table to remove the extra space at the bottom
                tblbutton.Visible = False
                tblPanelComment.Visible = False 'xxx
            End If

            'Display the attachments
            If .Attachment.Count > 0 Then

                For Each file As HRIS2024.Models.Attachment In .Attachment
                    AttachmentEvents.SetImageLabel(file, PanelFiles)
                Next

            ElseIf .Attachment.Count = 0 Then

                'Just to hide the area of attachments including its divider if no attachments
                tblAttachment.Visible = False
                PanelDivider.Visible = False

            End If

            If .Application.Status = ConstantVariables.HR_Pending And dgvName = "dgv_Late" Then
                GroupBox3.BorderColorG = Color.FromArgb(21, 101, 192)
                GroupBox3.BorderColorH = Color.FromArgb(182, 180, 186)
                GroupBox3.BackGColor = Color.White
                chk_HR_Excused.Enabled = True
                chk_HR_Unexcused.Enabled = True
                chk_HR_Excused.BackColor = Color.White
                chk_HR_Unexcused.BackColor = Color.White
            End If

            For Each leaderdecision As HRIS2024.Models.Late In .Information

                If leaderdecision.isExcused_Leader = ConstantVariables.pending _
               And leaderdecision.isExcused_Manager = ConstantVariables.pending _
               And leaderdecision.isExcused_HR = ConstantVariables.pending Then
                    Exit For
                End If

                If leaderdecision.isExcused_Leader = ConstantVariables.excused Then
                    chk_Leader_Excused.Checked = True
                ElseIf leaderdecision.isExcused_Leader = ConstantVariables.unexcused Then
                    chk_Leader_Unexcused.Checked = True
                End If

                If leaderdecision.isExcused_Manager = ConstantVariables.excused Then
                    chk_Manager_Excused.Checked = True
                ElseIf leaderdecision.isExcused_Manager = ConstantVariables.unexcused Then
                    chk_Manager_Unexcused.Checked = True
                End If

                If leaderdecision.isExcused_HR = ConstantVariables.excused Then
                    chk_HR_Excused.Checked = True
                ElseIf leaderdecision.isExcused_HR = ConstantVariables.unexcused Then
                    chk_HR_Unexcused.Checked = True
                End If

            Next


        End With

        If Not dgvName.Contains("dgv_Late") AndAlso Not dgvName.Contains("dgNotif") Then

            tblPanelComment.Visible = False
            tblbutton.Visible = False

        End If

        DatagridProperties()

    End Sub

    'Initialized datagrid properties
    Private Sub DatagridProperties()

        With dgvInformation
            'Set datagrid to full width
            .Dock = DockStyle.Fill

            'Set the column to full width
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Wrap text for short width cells
            dgComments.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            'autoresize rows for long content
            dgComments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            'Set the cell border with only horizontal border
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            'Set datagrid grid color
            .GridColor = SystemColors.InactiveBorder

            'Set font for header and body
            .ColumnHeadersDefaultCellStyle.Font = New Font("Roboto", 9, FontStyle.Regular)
            .DefaultCellStyle.Font = New Font("Roboto", 9, FontStyle.Regular)

            'Set font color  for header and body
            .ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
            .DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark

            'Set alignment for Header and body
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'Set height for body row | In height for header row - I set the height property in columndefaultstyle in control properties
            'dgvLeaveInfo.RowTemplate.Height = 30
            .DefaultCellStyle.Padding = New Padding(0, 5, 0, 5)
            .ColumnHeadersDefaultCellStyle.Padding = New Padding(0, 0, 0, 10)

            'Display in datagrid the result from leave information
            .DataSource = Me._fullInformation.Information
            .ReadOnly = True
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("Id").Visible = False

            .Columns("ApplicationID").Visible = False

            .Columns("RequestID").Visible = False

            .Columns("ShiftDate").Visible = True
            .Columns("ShiftDate").DefaultCellStyle.Format = "MMMM dd, yyyy"
            .Columns("ShiftDate").HeaderText = "Date"

            .Columns("OriginalSchedule").Visible = True
            .Columns("OriginalSchedule").HeaderText = "Original Schedule"
            .Columns("OriginalSchedule").DefaultCellStyle.Format = "hh:mm tt"

            .Columns("ActualTimeIn").Visible = True
            .Columns("ActualTimeIn").HeaderText = "Actual Time In"
            .Columns("ActualTimeIn").DefaultCellStyle.Format = "hh:mm tt"

            .Columns("TotalLateTime").Visible = True
            .Columns("TotalLateTime").HeaderText = "Total Late Time"

            .Columns("Reason").Visible = True
            .Columns("Reason").FillWeight = 400
            .Columns("Reason").HeaderText = "Reason"

            .Columns("isExcused_Leader").Visible = False

            .Columns("isExcused_Manager").Visible = False

            .Columns("isExcused_HR").Visible = False

            For Each column As DataGridViewColumn In .Columns
                column.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        End With

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

    Private Async Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click


        _fullInformation.Application = Await ApplicationRepository.GetDataByIdAsync(ApplicationID)

        With _fullInformation

            'Return if not HR Pending
            If Not String.Equals(.Application.Status, ConstantVariables.HR_Pending, StringComparison.OrdinalIgnoreCase) Then
                EventCode = 14
                Dim DialogBoxOK As New DialogBoxOK(EventCode) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}
                DialogBoxOK.ShowDialog()
                Me.DialogResult = DialogResult.OK
                Me.Close()
                Return
            End If

            'return if decision was not checked
            If chk_HR_Excused.Checked = False And chk_HR_Unexcused.Checked = False Then
                EventCode = 21
                Dim DialogBoxOK As New DialogBoxOK(EventCode) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}
                DialogBoxOK.ShowDialog()
                Return
            End If

            EventCode = If(.Application.isCancelled, 3, 7)
            Dim DialogBoxCancel As New DialogBoxCancel(EventCode, ApplicationID) With {.StartPosition = FormStartPosition.CenterScreen, .FormBorderStyle = FormBorderStyle.FixedDialog}
            DialogBoxCancel.ShowDialog()

            If DialogBoxCancel.DialogResult = DialogResult.No Then
                Return
            End If

            'Assign new value to Application model
            .Application.Status = If(.Application.isCancelled, ConstantVariables.Cancelled, ConstantVariables.HR_Approve)
            .Application.HRApprovedBy = UserPrincipal.Current.ToString()
            .Application.HRApprovedDate = DateTime.Now
            .Application.UpdateTime = DateTime.Now

            'new comment object
            Dim commentObj As New HRIS2024.Models.Comment With {
                .ApplicationID = _fullInformation.Application.ApplicationID,
                .Commentor = UserPrincipal.Current.ToString(),
                .Comment = txtRemark?.Text?.ToString(),
                .Status = _fullInformation.Application.Status,
                .AddedDate = DateTime.Now()
            }

            ' Call the repository method to update the data
            Await ApplicationRepository.UpdateDataAsync(.Application)

            'START-------------update the late information-------------
            Dim isExcused As String = String.Empty

            If chk_HR_Excused.Checked Then
                isExcused = ConstantVariables.excused
            ElseIf chk_HR_Unexcused.Checked Then
                isExcused = ConstantVariables.unexcused
            End If

            Await LateRepository.Update(.Application.ApplicationID, isExcused)
            'FINISH-------------update the late information-------------

            'call the repository method to add comment
            Await CommentRepository.AddData(commentObj)

            ''------------------Email Module---------------------
            Dim notifSubject As String = If(.Application.isCancelled,
                                            "BUS: Late Cancellation Notification - Application ID# " & ApplicationID,
                                            "BUS: Late Notification - Application ID# " & ApplicationID)

            Dim notifBody As String = If(.Application.isCancelled,
                                            "Cancellation of your late has been approved.",
                                            "Your late application has been approved.")

            Dim outlookApp As New Microsoft.Office.Interop.Outlook.Application()

            Await getVariables()
            Await EmailHRFiling(ApplicationID, notifSubject, notifBody, requestor.ToArray(), outlookApp)
            ''------------------Email Module---------------------

            EventCode = If(.Application.isCancelled, 10, 3)
            Dim DialogBoxOK2 As New DialogBoxOK(EventCode, ApplicationID) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}
            DialogBoxOK2.ShowDialog()
            Me.DialogResult = DialogResult.OK
            Me.Close()

        End With

    End Sub

    Private Async Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

        'RefreshLeaveApplication()
        _fullInformation.Application = Await ApplicationRepository.GetDataByIdAsync(ApplicationID)

        With _fullInformation

            'Return if not HR Pending
            If Not String.Equals(.Application.Status, ConstantVariables.HR_Pending, StringComparison.OrdinalIgnoreCase) Then
                EventCode = 14
                Dim DialogBoxOK As New DialogBoxOK(EventCode) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}
                DialogBoxOK.ShowDialog()
                Me.DialogResult = DialogResult.OK
                Me.Close()
                Return
            End If

            'return if decision was not checked
            If chk_HR_Excused.Checked = False And chk_HR_Unexcused.Checked = False Then
                EventCode = 21
                Dim DialogBoxOK As New DialogBoxOK(EventCode) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}
                DialogBoxOK.ShowDialog()
                Return
            End If

            'Set eventcode if cancel or not
            EventCode = If(.Application.isCancelled, 4, 2)
            Dim DialogBoxCancel As New DialogBoxCancel(EventCode, ApplicationID) With {.StartPosition = FormStartPosition.CenterScreen, .FormBorderStyle = FormBorderStyle.FixedDialog}
            DialogBoxCancel.ShowDialog()

            If DialogBoxCancel.DialogResult = DialogResult.No Then
                Return
            End If

            'Assign new value to Application model
            .Application.Status = If(.Application.isCancelled, ConstantVariables.HR_Approve, ConstantVariables.HR_Reject)
            .Application.HRApprovedBy = UserPrincipal.Current.ToString()
            .Application.HRApprovedDate = DateTime.Now
            .Application.UpdateTime = DateTime.Now

            'new comment object
            Dim commentObj As New HRIS2024.Models.Comment With {
                .ApplicationID = _fullInformation.Application.ApplicationID,
                .Commentor = UserPrincipal.Current.ToString(),
                .Comment = txtRemark?.Text?.ToString(),
                .Status = _fullInformation.Application.Status,
                .AddedDate = DateTime.Now()
            }

            ' Call the repository method to update the data
            Await ApplicationRepository.UpdateDataAsync(.Application)

            'START-------------update the late information-------------
            Dim isExcused As String = String.Empty

            If chk_HR_Excused.Checked Then
                isExcused = ConstantVariables.excused
            ElseIf chk_HR_Unexcused.Checked Then
                isExcused = ConstantVariables.unexcused
            End If

            Await LateRepository.Update(.Application.ApplicationID, isExcused)
            'FINISH-------------update the late information-------------

            'call the repository method to add comment
            Await CommentRepository.AddData(commentObj)

            ''------------------Email Module---------------------
            Dim notifSubject As String = If(.Application.isCancelled,
                                            "BUS: Late Cancellation Notification - Application ID# " & ApplicationID,
                                            "BUS: Late Notification - Application ID# " & ApplicationID)

            Dim notifBody As String = If(.Application.isCancelled,
                                            "Cancellation of your late has been rejected.",
                                            "Your late application has been rejected.")

            Dim outlookApp As New Microsoft.Office.Interop.Outlook.Application()

            Await getVariables()
            Await EmailHRFiling(ApplicationID, notifSubject, notifBody, requestor.ToArray(), outlookApp)
            ''------------------Email Module---------------------

            EventCode = If(.Application.isCancelled, 22, 2)
            Dim DialogBoxOK2 As New DialogBoxOK(EventCode, ApplicationID) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}
            DialogBoxOK2.ShowDialog()
            Me.DialogResult = DialogResult.Yes
            Me.Close()

        End With

    End Sub

    Private Sub pbCollapse_Click(sender As Object, e As EventArgs) Handles pbCollapse.Click

        cardComment.Visible = False
        pbExpand.Visible = True
        pbCollapse.Visible = False

    End Sub

    Private Sub pbExpand_Click(sender As Object, e As EventArgs) Handles pbExpand.Click

        cardComment.Visible = True
        pbExpand.Visible = False
        pbCollapse.Visible = True

    End Sub


    'Function to autoresize datagrid height base on its row content, then nakaautosize yung row ng tablepanel kung nasan yung datagrid
    Private Sub AdjustHeightOfGridBasedOnRows(ByVal dataGrid As DataGridView)
        Dim totalRowHeight As Integer = dataGrid.ColumnHeadersHeight

        For Each row As DataGridViewRow In dataGrid.Rows
            totalRowHeight += row.Height
        Next

        dataGrid.Height = totalRowHeight
    End Sub

    'call the AdjustHeightOfGridBasedOnRows after databinding. it works for me, i dont know why. hahaha
    Private Sub dgvLeaveInfo_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvInformation.DataBindingComplete

        AdjustHeightOfGridBasedOnRows(dgvInformation)

    End Sub

    Private Sub dgComments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgComments.CellContentClick

    End Sub

    Private Sub FormViewLeave2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtRemark.Font = New Font("Roboto", 9, FontStyle.Regular)

        'Set all font to roboto
        Dim font As New Font("Roboto", 9, FontStyle.Regular)
        SetFontForLabels(Me, font)

        cardComment.ForeColor = SystemColors.ControlDarkDark

        Me.dgComments.DoubleBuffered(True)
        Me.dgvInformation.DoubleBuffered(True)

        AddHandler txtRemark.Paint, AddressOf txtRemark_Paint

    End Sub

    Private Async Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click

        'early return
        If Not _fullInformation.Attachment.Any() Then

            EventCode = 5
            Dim DialogBoxOK As New DialogBoxOK(EventCode, ApplicationID) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}
            DialogBoxOK.ShowDialog()

        End If

        Dim folderBrowserDialog As New FolderBrowserDialog()

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then

            Dim selectedFolderPath As String = folderBrowserDialog.SelectedPath

            'Function to download attachments
            Await AttachmentEvents.DownloadAttachments(selectedFolderPath, _fullInformation.Attachment)

            EventCode = 4
            Dim DialogBoxOK2 As New DialogBoxOK(EventCode, selectedFolderPath) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.FixedDialog}
            DialogBoxOK2.ShowDialog()

        End If

    End Sub

    Private Sub chk_HR_Excused_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HR_Excused.CheckedChanged
        If chk_HR_Excused.Checked Then
            chk_HR_Unexcused.Checked = False
        End If
    End Sub

    Private Sub chk_HR_Unexcused_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HR_Unexcused.CheckedChanged
        If chk_HR_Unexcused.Checked Then
            chk_HR_Excused.Checked = False
        End If
    End Sub

    Private Sub dgComments_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgComments.CellFormatting

        'Dim names = New List(Of String) From {"Asha Wang", "Alyssa Blessy V. Briones", "Liezel B. Briones", "Maria Rachel G. Jaena", "Lucy Fu", "Sam Tran", "Elizar M. Se", "Tracy Tran"}

        'For Each row As DataGridViewRow In dgComments.Rows
        '    If names.Contains(row.Cells("Commentor").Value.ToString()) Then
        '        row.Cells("Commentor").Value = "HR Department"
        '    End If
        'Next

        For Each row As DataGridViewRow In dgComments.Rows
            If row.Cells("Commentor").Value.ToString() = FormMainWindow.ManagerName Then
                row.Cells("Commentor").Value = "HR Department"
            End If
        Next

    End Sub

    Private Sub txtRemark_Paint(sender As Object, e As PaintEventArgs)
        If String.IsNullOrEmpty(txtRemark.Text) Then
            TextRenderer.DrawText(e.Graphics, "Enter text here...", txtRemark.Font, txtRemark.ClientRectangle, SystemColors.GrayText, txtRemark.BackColor, TextFormatFlags.Top Or TextFormatFlags.Left)
        End If
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams

#Region "----------------------Email Variables"

    Private userDisplay As String = UserPrincipal.Current.DisplayName.ToString
    Private recipients As String()
    Private HRRecipients As String()
    Private requestor As New List(Of String)()

    Private Async Function getVariables() As Task

        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
            Await db.OpenAsync()

            ' Fetch the TicketID after the UPDATE
            Dim selectCmd As New SqlCommand("SELECT Team FROM [HRIS_2024].[dbo].[EmailRecipient] WHERE EmployeeName = @EmployeeName", db)
            selectCmd.Parameters.AddWithValue("@EmployeeName", userDisplay)

            Dim teamResult As String = ""
            Dim teamTL As String = "TL"
            Dim teamManager As String = "Manager"

            ' Execute the query and get the result
            Dim reader As SqlDataReader = selectCmd.ExecuteReader()
            If reader.Read() Then
                ' If there is a result, retrieve the 'Team' value
                teamResult = reader.GetString(reader.GetOrdinal("Team"))
            End If

            ' Close the first DataReader
            reader.Close()

            Dim query As String = ""

            If teamResult.Contains("FM") Then

                query = $"SELECT * FROM [HRIS_2024].[dbo].[EmailRecipient] WHERE (Team = @Team OR Team = 'PAYMENT') AND (Position = @Position OR Position = 'MANAGER')"

            ElseIf teamResult.Contains("CS") Then

                query = $"SELECT * FROM [HRIS_2024].[dbo].[EmailRecipient] WHERE (Team = @Team OR Team = 'CS') AND (Position = @Position OR Position = 'MANAGER')"

            ElseIf teamResult.Contains("BC") Then

                query = $"SELECT * FROM [HRIS_2024].[dbo].[EmailRecipient] WHERE (Team = @Team OR Team = 'Payment') AND (Position = @Position OR Position = 'MANAGER')"

            Else

                query = $"SELECT * FROM [HRIS_2024].[dbo].[EmailRecipient] WHERE Team = @Team AND (Position = @Position OR Position = @Position2)"

            End If

            ' Create a new command to execute the SQL query
            Dim emailCommand As New SqlCommand(query, db)
            emailCommand.Parameters.AddWithValue("@Team", teamResult)
            emailCommand.Parameters.AddWithValue("@Position", teamManager)
            emailCommand.Parameters.AddWithValue("@Position2", teamTL)

            ' Create a list to store the distinct email addresses
            Dim emails As New List(Of String)()

            ' Execute the query and read the results
            Using emailReader As SqlDataReader = emailCommand.ExecuteReader()
                While emailReader.Read()
                    ' Add each distinct email address to the list
                    Dim email As String = emailReader.GetString(emailReader.GetOrdinal("Email"))
                    emails.Add(email)
                End While
            End Using

            recipients = emails.ToArray()


            Dim selectHRNames = "SELECT * FROM [HRIS_2024].[dbo].[EmailRecipient] WHERE Team = 'HR' AND (Position = 'TL' OR Position = 'Manager')" ' (OR Position = @Position2)
            Dim execute = Await db.QueryAsync(Of Emailrecipient)(selectHRNames)
            HRRecipients = execute.Select(Function(x) x.Email).ToArray

            Dim selectRequestor = $"SELECT Email FROM [HRIS_2024].[dbo].[EmailRecipient] WHERE EmployeeName = '{Me._fullInformation.Application.Applicant}'  AND Email IS NOT NULL"
            Dim exe = Await db.QuerySingleAsync(Of String)(selectRequestor)

            requestor.Add(exe)

            db.Close()

        End Using
    End Function
#End Region

    Private Sub txtRemark_GotFocus(sender As Object, e As EventArgs) Handles txtRemark.GotFocus
        txtRemark.WaterMark = ""
    End Sub

    Private Sub txtRemark_LostFocus(sender As Object, e As EventArgs) Handles txtRemark.LostFocus
        txtRemark.WaterMark = "Add a comment..."
    End Sub

End Class