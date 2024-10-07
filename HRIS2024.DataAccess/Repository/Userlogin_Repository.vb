Imports System.Data.SqlClient
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility

Public Class Userlogin_Repository
    Implements IUserlogin_Repository

    'Public Async Function IsValidCredentials(UserName As String, Password As String) As Task(Of Boolean) Implements IUserlogin_Repository.IsValidCredentials
    '    Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

    '        Await db.OpenAsync()

    '        Dim sqlFind = "SELECT COUNT(*) FROM [HRIS_2024].[dbo].[tblUserLogin] WHERE Username = @Username AND Password = @Password"

    '        Dim parameter As New DynamicParameters
    '        parameter.Add("@Username", UserName)
    '        parameter.Add("@Password", Password)

    '        ' Capture the count result
    '        Dim count As Integer = Await db.ExecuteScalarAsync(Of Integer)(sqlFind, parameter)

    '        ' Return True if the count is greater than 0, otherwise return False
    '        Return count > 0

    '    End Using

    'End Function

    Public Async Function GetUser(UserName As String, Password As String) As Task(Of UserLogin) Implements IUserlogin_Repository.GetUser
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)

            Await db.OpenAsync()

            Dim sqlFind = "SELECT * FROM [HRIS_2024].[dbo].[tblUserLogin] WHERE Username = @Username AND Password = @Password"

            Dim parameter As New DynamicParameters
            parameter.Add("@Username", UserName)
            parameter.Add("@Password", Password)

            Return Await db.QuerySingleOrDefaultAsync(Of UserLogin)(sqlFind, parameter)

        End Using
    End Function
End Class
