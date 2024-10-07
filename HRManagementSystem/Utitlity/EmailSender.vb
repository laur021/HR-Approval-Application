Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Text
Imports Dapper
Imports HRIS2024.Utility
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Outlook

Module EmailSender
    Dim getApplicationId As String
    Dim getApplicationType As String
    Dim getDepartment As String
    Dim getPosition As String
    Dim getLeaderApproved As String
    Dim getManagerApproved As String
    Dim getLeaveStatus As String
    Dim getRequestorFiling As String

    ' Get Path
    Private Function GetPath(getId As Integer) As String
        Dim path As String = ""

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringBUS)
            Dim sql = $"SELECT TOP 1 email_path FROM [BreakApp].[dbo].[EmailPaths] WHERE Id = '{getId}'"
            Dim command As New SqlCommand(sql, db)
            db.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                ' Read the path value from the database
                path = reader.GetString(0)
            End If
        End Using

        ' Return the path value
        Return path
    End Function

    ' Get Group Email
    Function GetEmailGroup(ByVal getId As Integer) As String()
        Dim groupList As New List(Of String)

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringBUS)
            Dim sql = $"SELECT TOP 1 * FROM [TicketModule].[dbo].[UserGroup] WHERE Id = '{getId}'"
            Dim command As New SqlCommand(sql, db)
            db.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                groupList.Add(reader.GetString(1))
            End If
        End Using


        Return groupList.ToArray()
    End Function

    ' Search in db if email is sent as group
    Function checkEmailGroup(ByVal getGroup As String) As Boolean
        Dim hasResult As Boolean = False

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringBUS)
            Dim sql = $"SELECT TOP 1 * FROM [TicketModule].[dbo].[UserGroup] WHERE Team = '{getGroup}'"
            Dim command As New SqlCommand(sql, db)
            db.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                hasResult = True
            End If
        End Using

        Return hasResult
    End Function

    Function getApplication(ApplicationId As String)

        Using db = New SqlConnection(FormLogin.ConnectionString_HRIS2024)

            getRequestorFiling = ""
            getDepartment = ""
            getApplicationType = ""
            getLeaderApproved = ""
            getManagerApproved = ""
            getLeaveStatus = ""

            Dim sql = $"SELECT TOP 1 * FROM [HRIS_2024].[dbo].[Application] WHERE ApplicationID = '{ApplicationId}'"
            Dim entities = db.Query(Of HRIS2024.Models.Application)(sql)

            For Each entity In entities
                getRequestorFiling = entity.Applicant
                getDepartment = entity.Department
                getApplicationType = entity.ApplicationType
                getLeaveStatus = entity.Status
            Next

        End Using


        Return ApplicationId

    End Function

    ' Notification for Leave
    Async Function EmailHRFiling(ByVal ApplicationId As String, ByVal subject As String, ByVal body As String, ByVal recipients As String(), ByVal outlookApp As Microsoft.Office.Interop.Outlook.Application) As Task

        getApplication(ApplicationId)

        Dim moduleid As Integer = 5
        Dim sysgenid As Integer = 4

        ' Call modulei to retrieve the file path
        Dim filePath As String = GetPath(moduleid)
        Dim sysgen As String = GetPath(sysgenid)

        'Dim imgSrc As String

        Try
            '' Check if Outlook is already running
            If Process.GetProcessesByName("OUTLOOK").Length = 0 Then
                ' Outlook is not running, start it
                outlookApp = New Outlook.Application()
            End If

            ' Create a new email item
            Dim mailItem As Microsoft.Office.Interop.Outlook.MailItem = DirectCast(outlookApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem), Microsoft.Office.Interop.Outlook.MailItem)

            Dim accounts = outlookApp.Session.Accounts

            Dim selectedAccount As Microsoft.Office.Interop.Outlook.Account = Nothing

            Dim selectedEmail As String = "bus.notification@bestresource-inc.com"
            Dim EmailString As String

            For Each acc As Outlook.Account In accounts
                ' If acc.SmtpAddress = EmailString Then
                If acc.SmtpAddress = selectedEmail Then
                    selectedAccount = acc
                    Exit For
                End If
            Next

            mailItem.SendUsingAccount = selectedAccount

            ' Set the email properties
            mailItem.Subject = subject


            Dim htmlbody As New StringBuilder
            htmlbody.Append($"  <!DOCTYPE html>
                                <HTML style=""font-family: 'Montserrat', sans-serif;"">
                                <HEAD>
                                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                                </HEAD>
                                <BODY>
                                    <div style=""position: absolute; top: 0; right: 0; font-family: Montserrat, sans-serif; font-size: 10px; color: #ffffff;"">Application Notification!</div>
                                    <div style=""position: absolute; top: 0; right: 0; font-family: Montserrat, sans-serif; font-size: 10px; color: #ffffff;"">-------------------------------------</div>
                                    <BR><BR><BR><BR>
                                    <TABLE style=""width: 60%; background-color: #151127; font-family: 'Montserrat', sans-serif;"" align=""center"">
                                        <TR><TD style=""text-align: center""><img src=""{GetBanner(1)}""  alt='Image'></TD></TR>
                                        <TR><TD style=""text-align: center""><TABLE style=""width: 60%; background-color: #151127; border-collapse: collapse; margin: 2px auto;""><TR><TD><P> {body} </P></TD></TD></TR></TABLE></TD></TR>
                                        <TR><TD><BR><BR></TD></TR>
                                        <TR><TD  style=""text-align: center"">
                                            <table style=""width: 60%; background-color: #2D3450; border-collapse: collapse; margin: 2px auto; background-color: #2D3450; color: #fff; font-size: 12px;"" align=""center"">
                                            <tr><th style=""border: 1px solid #3D466A; text-align: left; padding: 8px; background-color: #3D466A;"">DETAILS</th><th style=""border: 1px solid #3D466A; text-align: left; padding: 8px; background-color: #3D466A;"">DESCRIPTION</th></tr>
                                            <tr><td style=""border: 1px solid #3D466A; text-align: left; padding: 8px;"">Name</td><td style=""border: 1px solid #3D466A; text-align: left; padding: 8px;""> {getRequestorFiling} </td></tr>
                                            <tr><td style=""border: 1px solid #3D466A; text-align: left; padding: 8px;"">Type</td><td style=""border: 1px solid #3D466A; text-align: left; padding: 8px;""> {getApplicationType} </td></tr>
                                            <tr><td style=""border: 1px solid #3D466A; text-align: left; padding: 8px;"">Department</td><td style=""border: 1px solid #3D466A; text-align: left; padding: 8px;""> {getDepartment} </td></tr>
                                            <tr><td style=""border: 1px solid #3D466A; text-align: left; padding: 8px;"">Status</td><td style=""border: 1px solid #3D466A; text-align: left; padding: 8px;""> {getLeaveStatus} </td></tr>
                                            </table>
                                        </TD></TR>
                                        <TR><TD><BR><BR><BR></TD></TR>
                                        <TR><TD style=""text-align: center""></TD></TR>
                                        <TR><TD style=""text-align: center""><P style=""font-size: 8pt;"">This is a system generated email. Please do not reply to this message
                                                                                <BR>BEST RESOURCE ENTERPRISE NETWORK INC.
                                                                                <BR>In case of any issues, please contact OPSA.DL@bren-inc.com</P><BR><BR><BR><BR></TD></TR>
                                    </TABLE>
                                    <BR>          
                                </BODY>
                             </HTML>
                            ")

            ' Set the HTML body of the email
            mailItem.HTMLBody = htmlbody.ToString

            ' Add recipients to the email
            For Each recipient As String In recipients
                mailItem.Recipients.Add(recipient)
            Next

            ' Send the email asynchronously
            Await Task.Run(Sub() mailItem.Send())

            ' Log or do further processing if needed
            Console.WriteLine($"Email sent to {String.Join(", ", recipients)}")
        Catch ex As System.Exception
            ' Handle any errors that occur during the email sending process
            Console.WriteLine("Error sending email: " & ex.Message)
        End Try

    End Function


    ''' <summary>
    ''' Additional function to the banner from HRIS database
    ''' </summary>
    ''' <param name="imgId"></param>
    ''' <returns></returns>
    Function GetBanner(imgId As Integer)

        Dim imgSrc As String

        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

            Dim imageObject = db.QueryFirstOrDefault(Of Byte())($"SELECT imgfile FROM [HRIS_2024].[dbo].[Banner] WHERE id = {imgId}")

            Dim base64String = Convert.ToBase64String(imageObject)

            imgSrc = "data:image/png;base64," & base64String

            If imgSrc Is Nothing Then

                Return Nothing

            End If

            Return imgSrc

        End Using

    End Function



End Module
