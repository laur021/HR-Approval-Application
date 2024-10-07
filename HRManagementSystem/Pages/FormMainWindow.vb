Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports Dapper
Imports HRIS2024.DataAccess
Imports MaterialSkin
Imports TableDependency.SqlClient
Imports TableDependency.SqlClient.Base.Enums
Imports TableDependency.SqlClient.Base.EventArgs
Imports HRIS2024.Models

Public Class FormMainWindow

    Public Property UserDetail As UserLogin
    Private userControlDashboard As New UserControlDashboard
    Private UCApplication As New UCApplication
    Private UCRecord As New UCRecord
    Private UCReport As New UCTimeKeeping
    Private UCSettings As New UCSettings

    Private Application As Application

    Private sqltabledependency As SqlTableDependency(Of Application)

    Public Shared ManagerName As String

    Dim EventCode As Integer = 0
    Public Sub New(UserDetail)

        Me.DoubleBuffered = True

        InitializeComponent()

        Themes()

        InitializeTabPages()

        LoadHRManager()

        btnName.Text = UserPrincipal.Current.ToString()
        btnName.Visible = False

        Using cg As Graphics = Me.CreateGraphics()
            Dim size As SizeF = cg.MeasureString(UserPrincipal.Current.ToString(), Me.btnName.Font)

            Me.btnName.Padding = New Padding(3)
            Me.btnName.Width = CInt(size.Width + (btnName.Width / 3))

            Me.btnName.Text = UserPrincipal.Current.ToString()
        End Using

        lblVersion.Text = "Version: " & FormLogin.version
        lblConnected.Text = FormLogin.Connected

    End Sub

    Public Sub LoadHRManager()
        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
            ManagerName = db.QueryFirstOrDefault(Of String)("SELECT Name FROM [HRIS_2024].[dbo].[Employee] WHERE Department = 'HR' AND Position = 'HR Manager'")
        End Using
    End Sub

    'Initialize Menutab content
    Private Sub InitializeTabPages()

        'Dashboard
        Me.TabDashboard.Controls.Add(userControlDashboard)
        userControlDashboard.Dock = DockStyle.Fill

        'Leave Application
        Me.TabApplication.Controls.Add(UCApplication)
        UCApplication.Dock = DockStyle.Fill

        'Leave Record
        Me.TabRecord.Controls.Add(UCRecord)
        UCRecord.Dock = DockStyle.Fill

        'Leave Report
        Me.TabTimeKeeping.Controls.Add(UCReport)
        UCReport.Dock = DockStyle.Fill

        'Leave settings
        Me.TabSettings.Controls.Add(UCSettings)
        UCSettings.Dock = DockStyle.Fill

        'hide leave settings from timekeeping account
        If FormLogin.UserDetail.Type = ConstantVariables.Timekeeper Or FormLogin.UserDetail.Type = ConstantVariables.Officer Then
            MenuTab.Controls.Remove(TabSettings)
        End If

    End Sub

    'Set form themes
    Private Sub Themes()

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        'by default MaterialSkin lib enforces the correct backcolor, to stop this behavior, this code is needed
        SkinManager.EnforceBackcolorOnAllComponents = False
        '--------------------------------------------------
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New MaterialSkin.ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue900, Accent.Blue700, TextShade.WHITE)

    End Sub

    ' to update the icon 
    Private Async Sub LoadLogs()
        'Using db = New SqlConnection(FormLogin.ConnectionString_HRSystem)
        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
            Dim sqlSelect = $"SELECT * FROM [Application] WHERE [Status] = '{ConstantVariables.HR_Pending}' "
            Dim entities = Await db.QueryAsync(Of Application)(sqlSelect)

            Dim allRead = entities.All(Function(entity) entity.isRead)

            If allRead Then
                btnNotif.Image = My.Resources.bell_read
            Else
                btnNotif.Image = My.Resources.bell_unread_new
            End If
        End Using
    End Sub

#Region "Notification Code"
    Private Sub tbldependency_Changed(ByVal sender As Object, ByVal e As RecordChangedEventArgs(Of Application))

        'get the table changetype
        If e.ChangeType = ChangeType.Update Or e.ChangeType = ChangeType.Insert Then
            'get the record entity
            Dim changedEntity = e.Entity
            'get the status
            Dim updatedStatus = changedEntity.Status
            Dim isRead = changedEntity.isRead
            'hr will be notify only for hr pending leave request
            If updatedStatus = ConstantVariables.HR_Pending And isRead = False Then
                'need to invoke dahil sa cross-thread error.
                Me.Invoke(Sub()
                              Dim notif As New Notification(changedEntity)
                              notif.StartPosition = FormStartPosition.Manual
                              Dim position As Point = New Point(Me.Location.X + Me.Width - (notif.Width + 48), Me.Location.Y + 48)
                              notif.Location = position
                              notif.ShowDialog()

                              UserControlDashboard.InitializedDataAsync()
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed - para sa UCRecord.InitializedRecordsAsync

                              '------------------- application tab -----------------------
                              'to reload only the specific table everytime new update/insert data

                              Select Case changedEntity.ApplicationType
                                  Case ConstantVariables.LeaveApplication
                                      UCApplication.RunLeaveAsync()
                                      Exit Select
                                  Case ConstantVariables.ChangeShiftApplication
                                      UCApplication.RunChangeShiftAsync()
                                      Exit Select
                                  Case ConstantVariables.OverTimeApplication
                                      UCApplication.RunOverTimeAsync()
                                      Exit Select
                                  Case ConstantVariables.LateApplication
                                      UCApplication.RunLateAsync()
                                      Exit Select
                                  Case ConstantVariables.Infraction
                                      UCApplication.RunInfractionsAsync()
                                      Exit Select
                              End Select

                              '---------------------------- end --------------------------

                              UCRecord.InitializedRecordsAsync()

                              'make the notifbell to have red dot when new pending arrived
                              btnNotif.Image = My.Resources.bell_unread_new

                          End Sub)
            End If
        End If

    End Sub

    Private Sub tbldependency_Onerror(ByVal sender As Object, ByVal e As ErrorEventArgs)

        Dim ex As Exception = e.Error
        Throw ex

    End Sub

#End Region


    Private Async Sub FormMainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        EventCode = 1

        Dim DialogBoxCancel As New DialogBoxCancel(EventCode) With {.StartPosition = FormStartPosition.CenterScreen, .FormBorderStyle = FormBorderStyle.FixedDialog}

        DialogBoxCancel.ShowDialog()

        If DialogBoxCancel.DialogResult = DialogResult.Yes Then

            e.Cancel = True
            Me.Hide()
            FormLogin.Show()
            SqlDependency.Stop(FormLogin.ConnectionString_HRIS2024)
            'Dispose sqltabledependency
            sqltabledependency.Dispose()

            Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
                Dim insertlogs = $"INSERT INTO tblUserLoginLog (UserName, Name, isLoggedin, Activity, Version, LoggedDate) VALUES ('{FormLogin.UserDetail.Username}','{UserPrincipal.Current.ToString}', 'false', 'Log out', '{FormLogin.version}', '{Date.Now}')"
                Dim insert = Await db.ExecuteAsync(insertlogs)
            End Using

        ElseIf DialogBoxCancel.DialogResult = DialogResult.No Then

            e.Cancel = True

        End If

    End Sub

    'need ibuo yung system.eventargs, nagkakaron ng conflict sa eventargs ni sqltabledependency
    Private Async Sub MenuTab_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles MenuTab.SelectedIndexChanged


        If MenuTab.SelectedTab Is TabDashboard Then

            UserControlDashboard.InitializedDataAsync()

        ElseIf MenuTab.SelectedTab Is TabApplication Then

            'i enclosed all async function inside application because they have parameters that are not accessible outside of its class
            UCApplication.RunLeaveAsync()
            UCApplication.RunChangeShiftAsync()
            UCApplication.RunOverTimeAsync()
            UCApplication.RunLateAsync()
            UCApplication.RunInfractionsAsync()

        ElseIf MenuTab.SelectedTab Is TabRecord Then

            Await UCRecord.InitializedRecordsAsync()

        ElseIf MenuTab.SelectedTab Is TabTimeKeeping Then

            Await Task.WhenAll(UCReport.InitializedLeaveCountAsync())
            ',
            'UCReport.InitializedLeaveSummaryAsync(),
            'UCReport.InitializedOverBreakCountsAsync(),
            'UCReport.InitializedOverBreakSummaryAsync()

        ElseIf MenuTab.SelectedTab Is TabSettings Then

            UCSettings.InitializedData()

        End If

    End Sub

    Private Sub FormMainWindow_Load(sender As Object, e As System.EventArgs)
        btnName.Location = New Point(Me.Width - (btnNotif.Width + btnLogout.Width + btnName.Width) - 40, 45)
        btnNotif.Location = New Point(Me.Width - (btnNotif.Width + btnLogout.Width) - 40, 45)
        btnLogout.Location = New Point(Me.Width - btnLogout.Width - 20, 45)


    End Sub

    Private Sub FormMainWindow_Resize(sender As Object, e As System.EventArgs) Handles MyBase.Resize
        btnName.Location = New Point(Me.Width - (btnNotif.Width + btnLogout.Width + btnName.Width) - 40, 45)
        btnNotif.Location = New Point(Me.Width - (btnNotif.Width + btnLogout.Width) - 40, 45)
        btnLogout.Location = New Point(Me.Width - btnLogout.Width - 20, 45)
    End Sub

    Private Sub btnNotif_Click(sender As Object, e As System.EventArgs) Handles btnNotif.Click
        Dim screenPos As Point = btnNotif.PointToScreen(Point.Empty)
        Dim FormNotifList As New FormNotifList With {
            .StartPosition = FormStartPosition.Manual,
            .FormBorderStyle = FormBorderStyle.None
        } ' Set the width of the FormNotifList
        FormNotifList.Location = New Point(screenPos.X - FormNotifList.Width, screenPos.Y + 20)
        FormNotifList.ShowDialog()

        If FormNotifList.DialogResult = DialogResult.OK Then

            UserControlDashboard.InitializedDataAsync()
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
            UCApplication.RunLeaveAsync()
            UCApplication.RunChangeShiftAsync()
            UCApplication.RunOverTimeAsync()
            UCApplication.RunLateAsync()
            UCApplication.RunInfractionsAsync()
            UCRecord.InitializedRecordsAsync()
            LoadLogs()

        End If
    End Sub

    Private Async Sub btnLogout_Click(sender As Object, e As System.EventArgs) Handles btnLogout.Click

        EventCode = 1

        Dim DialogBoxCancel As New DialogBoxCancel(EventCode) With {.StartPosition = FormStartPosition.CenterScreen, .FormBorderStyle = FormBorderStyle.FixedDialog}
        DialogBoxCancel.ShowDialog()
        If DialogBoxCancel.DialogResult = DialogResult.Yes Then

            Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
                Dim insertlogs = $"INSERT INTO tblUserLoginLog (UserName, Name, isLoggedin, Activity, Version, LoggedDate) VALUES ('{FormLogin.UserDetail.Username}','{UserPrincipal.Current.ToString}', 'false', 'Log out', '{FormLogin.version}', '{Date.Now}')"
                Dim insert = Await db.ExecuteAsync(insertlogs)
            End Using

            Me.Hide()
            FormLogin.Show()
            sqltabledependency.Dispose()

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        LoadLogs()

        sqltabledependency = New SqlTableDependency(Of Application)(FormLogin.ConnectionString_HRIS2024)
        AddHandler sqltabledependency.OnChanged, AddressOf tbldependency_Changed
        AddHandler sqltabledependency.OnError, AddressOf tbldependency_Onerror
        sqltabledependency.Start()
    End Sub

    Private Sub FormHome_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    'Dispose other pages when not selected
    Private Sub DisposedUnselectedPage()

        For Each tabpage As Windows.Forms.TabPage In MenuTab.TabPages
            If Not tabpage.Equals(MenuTab.SelectedTab) Then
                tabpage.Controls.Clear()
            End If
        Next

    End Sub

    Public Sub ChangeTabPages(tabindex As Integer)
        MenuTab.SelectedIndex = tabindex
    End Sub

End Class



