Imports Dapper
Imports HRIS2024.DataAccess
Imports HRIS2024.Models
Imports HRIS2024.Utility
Imports MaterialSkin
Imports Microsoft
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.DirectoryServices.AccountManagement
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class FormLogin

    Public Shared UserDetail As New HRIS2024.Models.UserLogin
    Dim UserName As String
    Dim Password As String
    Dim EventCode As Integer = 0

    Public Shared version As String = "1.0.0.14"
    Public Shared Connected As String

    Dim AdminUserList As String() = {ConstantVariables.Laurence, ConstantVariables.Bron, ConstantVariables.Alvin, ConstantVariables.Raymart, ConstantVariables.Emron, ConstantVariables.Joep} 'ConstantVariables.Laurence, 

    Public Shared ConnectionString_HRIS2024 As String
    Private cancellationTokenSource As CancellationTokenSource

    Private ReadOnly _UserloginRepo As IUserlogin_Repository
    Public Sub New()

        ConnectionString_HRIS2024 = "Server=192.168.17.100\TITANIUM,51433; Database=HRIS_2024;User Id=sa;Password=Righteousn3ss;TrustServerCertificate=True;"

        'to prevent the controls to be an old school design
        System.Windows.Forms.Application.EnableVisualStyles()

        InitializeComponent()

        _UserloginRepo = New Userlogin_Repository

        Dim font As New Font("Roboto", 9)
        SetFontForLabels(Me, font)
        Size = New Size(650, 550)
        txtUsername.ForeColor = SystemColors.ControlDarkDark
        txtUsername.Font = New Font("Roboto", 9)
        txtPassword.ForeColor = SystemColors.ControlDarkDark
        txtPassword.Font = New Font("Roboto", 9)
        lblUser.ForeColor = SystemColors.ControlDarkDark
        lblUser.Font = New Font("Roboto", 9)
        lblPassword.ForeColor = SystemColors.ControlDarkDark
        lblPassword.Font = New Font("Roboto", 9)
        lblVersion.ForeColor = SystemColors.ControlDarkDark
        lblVersion.Font = New Font("Roboto", 8, FontStyle.Regular)
        lblConnection.Font = New Font("Roboto", 8, FontStyle.Regular)
        lblVersion.Text = $"Version: {version}"

        '------------ check if the user is opsa --------------------------
        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)
            Dim sql_opsa = $"SELECT * FROM Employee WHERE Department = 'OPSA'"
            Dim ent_opsa = db.Query(Of DistinctEmployeeName)(sql_opsa)
            Dim opsalist As List(Of String) = ent_opsa.Select(Function(emp) emp.Name).ToList()

            If opsalist.Contains(UserPrincipal.Current.ToString) Then
                tblPanelServer.Visible = True
            End If

        End Using

    End Sub


#Region "API to allow the borderless form to be movable"
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TableLayoutPanel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
#End Region

    Private Sub MyBase_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim myGraphics As Graphics = e.Graphics
        Dim pen As Pen = New Pen(SystemColors.ControlDark)

        Dim area As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1) '#004AAA
        Dim lgb As LinearGradientBrush = New LinearGradientBrush(area, ColorTranslator.FromHtml("#30DEE4"), ColorTranslator.FromHtml("#0d47a1"), LinearGradientMode.Horizontal)
        myGraphics.FillRectangle(lgb, area)
        myGraphics.DrawRectangle(pen, area)

    End Sub

    'Function to set all text font style into Arial
    Private Sub SetFontForLabels(parentControl As Control, ByVal font As Font)
        For Each control As Control In parentControl.Controls
            If TypeOf control Is Label Then
                control.Font = font
            End If

            ' If the control has child controls, recursively call the method
            If control.HasChildren Then
                SetFontForLabels(control, font)
            End If
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        Dispose()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Async Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        Using db = New SqlConnection(ConnectionString_HRIS2024)

            'assign textboxes text to variables
            UserName = txtUsername.Text
            Password = txtPassword.Text

            UserDetail = Await _UserloginRepo.GetUser(UserName, Password)

            If UserDetail Is Nothing Then

                Dim insertFailedLogs = $"INSERT INTO tblUserLoginLog (UserName, Name, isLoggedin, Activity, Version, LoggedDate) VALUES ('{UserName}','{UserPrincipal.Current.ToString}', 'false', 'Failed log in', '{version}', '{Date.Now}')"
                Dim insertFailed = Await db.ExecuteAsync(insertFailedLogs)

                ErrorNotif.Visible = True
                Timer1.Start()
                txtUsername.Focus()

                Return

            End If

            Dim insertSuccessLogs = $"INSERT INTO tblUserLoginLog (UserName, Name, isLoggedin, Activity, Version, LoggedDate) VALUES ('{UserName}','{UserPrincipal.Current.ToString}', 'true', 'Successful log in', '{version}', '{Date.Now}')"
            Dim insertSuccess = Await db.ExecuteAsync(insertSuccessLogs)

            Dim FormMainWindow As New FormMainWindow(UserDetail) With {.StartPosition = FormStartPosition.CenterScreen,
                                                                        .WindowState = WindowState.Maximized,
                                                                        .FormBorderStyle = FormBorderStyle.FixedDialog}
            Me.Hide()
            FormMainWindow.Show()
            ErrorNotif.Visible = False

        End Using
    End Sub

    ''check whether the username and password is blank
    'If UserName <> "" Or Password <> "" Or UserName <> "System.Data.DataRowView" Then
    '    Using db = New SqlConnection(ConnectionString_HRIS2024)

    '        Dim sqlSelect = $"SELECT * FROM tblUserLogin WHERE Username = '{UserName}' AND Password = '{Password}'"

    '        'contains initial list of userlogin, it contains await its operation
    '        Dim sqlAwaitResult = Await db.QueryAsync(Of UserLogin)(sqlSelect)

    '        'the await expression will continue if this expression is valid
    '        If sqlAwaitResult.Count <> 0 Then

    '            'Assign the single data into entity model
    '            Dim entity = Await db.QuerySingleAsync(Of UserLogin)(sqlSelect)

    '            'reassign into public shared userdetails
    '            UserDetail = entity
    '            txtUsername.Text = ""
    '            txtPassword.Text = ""

    '            Dim insertlogs = $"INSERT INTO tblUserLoginLog (UserName, Name, isLoggedin, Activity, Version, LoggedDate) VALUES ('{UserName}','{UserPrincipal.Current.ToString}', 'true', 'Successful log in', '{version}', '{Date.Now}')"
    '            Dim insert = Await db.ExecuteAsync(insertlogs)

    '            If UserDetail.Department = ConstantVariables.Department_HR Then

    '                Dim FormMainWindow As New FormMainWindow(UserDetail) With {
    '                                                                            .StartPosition = FormStartPosition.CenterScreen,
    '                                                                            .WindowState = WindowState.Maximized,
    '                                                                            .FormBorderStyle = FormBorderStyle.FixedDialog}
    '                Me.Hide()
    '                FormMainWindow.Show()

    '            Else

    '                Dim FormMainWindow As New FormMainWindow(UserDetail) With {
    '                                                                            .StartPosition = FormStartPosition.CenterScreen,
    '                                                                            .WindowState = WindowState.Maximized,
    '                                                                            .FormBorderStyle = FormBorderStyle.FixedDialog}
    '                Me.Hide()
    '                FormMainWindow.Show()

    '            End If

    '            ErrorNotif.Visible = False

    '        Else

    '            Dim insertlogs = $"INSERT INTO tblUserLoginLog (UserName, Name, isLoggedin, Activity, Version, LoggedDate) VALUES ('{UserName}','{UserPrincipal.Current.ToString}', 'false', 'Failed log in', '{version}', '{Date.Now}')"
    '            Dim insert = Await db.ExecuteAsync(insertlogs)

    '            ErrorNotif.Visible = True
    '            Timer1.Start()
    '            txtUsername.Focus()

    '            Return

    '        End If

    '    End Using

    'Else

    '    ErrorNotif.Visible = True
    '    Timer1.Start()
    '    txtUsername.Focus()

    '    Return

    'End If
    'End Sub


    Private Async Sub rbLiveServer_CheckedChanged(sender As Object, e As EventArgs) Handles rbLiveServer.CheckedChanged, rbTestServer.CheckedChanged
        ' Cancel any ongoing connection attempt
        cancellationTokenSource?.Cancel()

        cancellationTokenSource = New CancellationTokenSource()

        'Change Server
        If rbLiveServer.Checked = True Then
            ConnectionString_HRIS2024 = "Server=192.168.17.100\TITANIUM,51433; Database=HRIS_2024;User Id=sa;Password=Righteousn3ss;TrustServerCertificate=True;"
            Try
                Await Connection("LIVE: Connected", cancellationTokenSource.Token)
                Connected = "LIVE: Connected"
            Catch ex As OperationCanceledException
                ' Connection attempt cancelled
            End Try
        ElseIf rbTestServer.Checked = True Then
            ConnectionString_HRIS2024 = "Server=192.168.17.157\\SILVER,51433; Database=HRIS_2024;User Id=sa;Password=Righteousn3ss;TrustServerCertificate=True;"
            Try
                Await Connection("TEST: Connected", cancellationTokenSource.Token)
                Connected = "TEST: Connected"
            Catch ex As OperationCanceledException
                ' Connection attempt cancelled
            End Try
        End If

        DbSqlConnection.SetConnectionString(ConnectionString_HRIS2024)

    End Sub

    Private Async Function Connection(text As String, cancellationToken As CancellationToken) As Task
        Using db = New SqlConnection(ConnectionString_HRIS2024)
            Try
                lblConnection.Text = "Connecting..."
                pbConnection.Image = My.Resources.icons8_wi_fi_disconnected_32
                Await Task.Delay(1000, cancellationToken)
                Await db.OpenAsync(cancellationToken)
                lblConnection.Text = text
                pbConnection.Image = My.Resources.icons8_wi_fi_connected_32
            Catch ex As TaskCanceledException
                Throw New OperationCanceledException("Connection attempt cancelled.", ex)
            Catch ex As Exception
                lblConnection.Text = "Network Error"
                pbConnection.Image = My.Resources.icons8_wi_fi_disconnected_32
            End Try
        End Using
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ErrorNotif.Visible = True Then
            ErrorNotif.Visible = False
        Else
            Timer1.Stop()
        End If
    End Sub
End Class

