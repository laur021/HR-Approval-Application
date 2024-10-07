Imports ReaLTaiizor.Controls
Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports System.Text
Imports Dapper
Imports System.IO
Imports System.IO.Path
Imports PdfiumViewer
Imports System.ComponentModel
Imports HRIS2024.DataAccess
Imports HRIS2024.Models

Public Class UCSettings

    Dim LeaveID As Integer
    Dim eventcode As Integer
    Dim pdf As PdfViewer

    Dim Attachment As HRIS2024.Models.Attachment

    Private ReadOnly _AttachmentRepo As IAttachment_Repository
    Private ReadOnly _LeaveTypeRepo As ILeaveType_Repository

    Public Sub New()

        InitializeComponent()

        _AttachmentRepo = New Attachment_Repository
        _LeaveTypeRepo = New LeaveType_Repository

        InitializedData()

        pdf = New PdfViewer
        loadpdf()

    End Sub

    Private Sub UCSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim font As New Font("Roboto", 12, FontStyle.Regular)
        SetFontForLabels(Me, font)

        dgvLeaveSettings.DoubleBuffered(True)
        dgvLeaveSettings.ClearSelection()
        InitializedDatagridDesign()

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

    Public Async Sub InitializedData()

        dgvLeaveSettings.DataSource = Await _LeaveTypeRepo.GetListAsync()
        PageDatagridProperties.InitializedTheme(dgvLeaveSettings)
        dgvLeaveSettings.ClearSelection()

    End Sub

    Private Sub InitializedDatagridDesign()

        With dgvLeaveSettings

            'Set column headers
            .Columns(0).HeaderText = "ID"
            .Columns(0).ReadOnly = True
            .Columns(0).Visible = True
            .Columns(0).FillWeight = 50

            .Columns(1).HeaderText = "Type of Leave"
            .Columns(1).ReadOnly = True
            .Columns(1).Visible = True

            .Columns(2).HeaderText = "Description"
            .Columns(2).ReadOnly = True
            .Columns(2).Visible = True
            .Columns(2).FillWeight = 250

            .Columns(3).HeaderText = "Created By"
            .Columns(3).ReadOnly = True
            .Columns(3).Visible = True

            .Columns(4).HeaderText = "Date of Creation"
            .Columns(4).ReadOnly = True
            .Columns(4).Visible = True

            .Columns(5).HeaderText = "isDeleted"
            .Columns(5).Visible = False

            Dim btnActionEditCategory As New DataGridViewButtonColumn
            btnActionEditCategory.Name = "btnActionEdit"
            btnActionEditCategory.HeaderText = ""
            btnActionEditCategory.FlatStyle = FlatStyle.Flat
            btnActionEditCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            btnActionEditCategory.Width = 50
            .Columns.Insert(6, btnActionEditCategory)

            Dim btnActionDeleteCategory As New DataGridViewButtonColumn
            btnActionDeleteCategory.Name = "btnActionDelete"
            btnActionDeleteCategory.HeaderText = ""
            btnActionDeleteCategory.FlatStyle = FlatStyle.Flat
            btnActionDeleteCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            btnActionDeleteCategory.Width = 50
            .Columns.Insert(7, btnActionDeleteCategory)

            .ClearSelection()

        End With

    End Sub

    Private Sub dgvLeaveSettings_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvLeaveSettings.CellPainting
        If e.ColumnIndex = dgvLeaveSettings.Columns("btnActionEdit").Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim w = My.Resources.icons8_edit_property_24.Width
            Dim h = My.Resources.icons8_edit_property_24.Height
            Dim x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2
            Dim y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2
            e.Graphics.DrawImage(My.Resources.icons8_edit_property_24, New Rectangle(x, y, w, h))
            e.Handled = True
        End If

        If e.ColumnIndex = dgvLeaveSettings.Columns("btnActionDelete").Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim w = My.Resources.icons8_delete_view_24.Width
            Dim h = My.Resources.icons8_delete_view_24.Height
            Dim x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2
            Dim y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2
            e.Graphics.DrawImage(My.Resources.icons8_delete_view_24, New Rectangle(x, y, w, h))
            e.Handled = True
        End If
    End Sub

    Private Sub dgvLeaveSettings_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeaveSettings.CellMouseEnter
        If e.RowIndex >= 0 Then
            dgvLeaveSettings.Rows(e.RowIndex).DefaultCellStyle.BackColor = SystemColors.Control
        End If
    End Sub


    Private Sub dgvLeaveSettings_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeaveSettings.CellMouseLeave
        If e.RowIndex >= 0 Then
            dgvLeaveSettings.Rows(e.RowIndex).DefaultCellStyle.BackColor = dgvLeaveSettings.DefaultCellStyle.BackColor
        End If
    End Sub

    'Function to autoresize datagrid height base on its row content, then nakaautosize yung row ng tablepanel kung nasan yung datagrid
    Private Sub AdjustHeightOfGridBasedOnRows(ByVal dataGrid As DataGridView)
        Dim totalRowHeight As Integer = dataGrid.ColumnHeadersHeight

        For Each row As DataGridViewRow In dataGrid.Rows
            totalRowHeight += row.Height
        Next

        dataGrid.Height = totalRowHeight
    End Sub

    Private Sub dgvLeaveSettings_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvLeaveSettings.DataBindingComplete

        AdjustHeightOfGridBasedOnRows(dgvLeaveSettings)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim FormAddLeave As New FormAddLeave(Nothing) With {.StartPosition = FormStartPosition.CenterParent, .FormBorderStyle = FormBorderStyle.None}
        FormAddLeave.ShowDialog()

        If FormAddLeave.DialogResult = DialogResult.OK Then

            InitializedData()

        End If

    End Sub

    Private Async Sub dgvLeaveSettings_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLeaveSettings.CellMouseClick

        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)

            If e.RowIndex < 0 Then
                Return
            End If

            Dim ColumnIndexId = dgvLeaveSettings.Columns("Id").Index
            Dim RowIndexId = dgvLeaveSettings.Rows(e.RowIndex).Index
            LeaveID = Convert.ToInt16(dgvLeaveSettings.Rows(RowIndexId).Cells(ColumnIndexId).Value.ToString())

            If e.ColumnIndex = dgvLeaveSettings.Columns("btnActionDelete").Index Then

                Dim YesNoresult = 5
                Dim DialogBoxCancel As New DialogBoxCancel(YesNoresult) With {.StartPosition = FormStartPosition.CenterScreen,
                                                                              .FormBorderStyle = FormBorderStyle.FixedDialog}
                DialogBoxCancel.ShowDialog()

                If DialogBoxCancel.DialogResult = DialogResult.Yes Then

                    Await _LeaveTypeRepo.RemoveAsync(LeaveID)

                    eventcode = 19
                    Dim DialogBoxOK As New DialogBoxOK(eventcode) With {.StartPosition = FormStartPosition.CenterParent,
                                                                        .FormBorderStyle = FormBorderStyle.FixedDialog}
                    DialogBoxOK.ShowDialog()

                End If

            ElseIf e.ColumnIndex = dgvLeaveSettings.Columns("btnActionEdit").Index Then

                'Get full list of data
                'The correct way is to add GetData in repo, to fecth only single obj, I just use GetList. :P
                Dim objList = Await _LeaveTypeRepo.GetListAsync()
                'Get the actual object from objList
                Dim obj = objList.FirstOrDefault()

                Dim FormAddLeave As New FormAddLeave(obj) With {.StartPosition = FormStartPosition.CenterParent,
                                                                        .FormBorderStyle = FormBorderStyle.None}
                FormAddLeave.ShowDialog()

                If FormAddLeave.DialogResult = DialogResult.OK Then
                    InitializedData()
                End If

            End If

        End Using

    End Sub

    Private Async Sub loadpdf()

        Dim attachList As New List(Of HRIS2024.Models.Attachment)
        attachList = Await _AttachmentRepo.GetDataByIdAsync("Leave Policy")

        'early return
        If Not attachList.Any() Then
            llblFilename.Text = llblFilename.Text
            Return
        End If

        Attachment = attachList.FirstOrDefault()
        llblFilename.Text = Attachment.FileName & Attachment.FileExtension
        Dim memoryStream As New MemoryStream(Attachment.FileBytes)
        Dim document = PdfDocument.Load(memoryStream)
        pdf.ZoomMode = PdfViewerZoomMode.FitBest
        pdf.Document = document
        PanelPDF.Controls.Add(pdf)
        pdf.Dock = DockStyle.Fill

    End Sub


    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        If PanelPDFPreview.Visible = False Then

            PanelPDFPreview.Visible = True
            btnView.Text = "Hide"

        Else

            PanelPDFPreview.Visible = False
            btnView.Text = "View"

        End If

    End Sub

    Private Async Sub llblFilename_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblFilename.LinkClicked
        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)

            Dim openFileDialog As New OpenFileDialog With {.Filter = "PDF Files|*.pdf"}

            If openFileDialog.ShowDialog() = DialogResult.OK Then

                Dim fileinfo As New FileInfo(openFileDialog.FileName)

                Dim fileAttach As New Attachment With {
                    .ApplicationID = "Leave Policy",
                    .FileName = If(fileinfo?.Name.Length <= 50, GetFileNameWithoutExtension(fileinfo.Name), GetFileNameWithoutExtension(fileinfo.Name.Substring(0, 50))),
                    .FileExtension = fileinfo?.Extension.ToLower(),
                    .FileBytes = File.ReadAllBytes(fileinfo?.FullName),
                    .UploadedBy = UserPrincipal.Current.ToString(),
                    .UploadedDate = DateTime.Now()
                    }

                If Attachment Is Nothing Then

                    Await _AttachmentRepo.AddAsync(fileAttach)

                Else

                    eventcode = 6
                    Dim DialogBoxCancel As New DialogBoxCancel(eventcode) With {.StartPosition = FormStartPosition.CenterScreen,
                                                                                .FormBorderStyle = FormBorderStyle.FixedDialog}
                    DialogBoxCancel.ShowDialog()

                    If DialogBoxCancel.DialogResult = DialogResult.Yes Then
                        Await _AttachmentRepo.UpdateAsync(fileAttach)
                    End If

                End If

                loadpdf()

                eventcode = 20
                Dim DialogBoxOK As New DialogBoxOK(eventcode) With {.StartPosition = FormStartPosition.CenterParent,
                                                                    .FormBorderStyle = FormBorderStyle.FixedDialog}
                DialogBoxOK.ShowDialog()

            End If

        End Using
    End Sub

    Protected Overrides Sub finalize() 'automatic by vb.net, not determined when to execute unlike dispose, dispose is not call automatically.

    End Sub

    Private Sub dgvLeaveSettings_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles dgvLeaveSettings.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

End Class
