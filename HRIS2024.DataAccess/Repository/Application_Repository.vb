Imports System.Data.SqlClient
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility
Public Class Application_Repository
    Implements IApplication_Repository

    Public Async Function UpdateDataAsync(Application As Application) As Task Implements IApplication_Repository.UpdateDataAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If Application Is Nothing Then
                Throw New ArgumentNullException(NameOf(Application))
            End If

            With Application
                Dim queryString As String = "UPDATE [Application] SET HRApprovedDate = @HRApprovedDate, HRApprovedBy = @HRApprovedBy, Status = @Status, UpdateTime = @UpdateTime WHERE ApplicationId = @ApplicationId"
                Dim parameter As New DynamicParameters
                parameter.Add("@HRApprovedDate", .HRApprovedDate)
                parameter.Add("@HRApprovedBy", .HRApprovedBy)
                parameter.Add("@Status", .Status)
                parameter.Add("@UpdateTime", .UpdateTime)
                parameter.Add("@ApplicationId", .ApplicationID)
                Dim insert = Await db.ExecuteAsync(queryString, parameter)
            End With

        End Using
    End Function

    Public Async Function GetDataByIdAsync(ApplicationId As String) As Task(Of Application) Implements IApplication_Repository.GetDataByIdAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If ApplicationId Is String.Empty Then
                Throw New ArgumentNullException(NameOf(Application))
            End If

            Dim query As String = "SELECT * FROM Application WHERE ApplicationID = @ApplicationID"
            Dim parameters As New DynamicParameters
            parameters.Add("@ApplicationID", ApplicationId)
            Return Await Await Task.FromResult(db.QuerySingleAsync(Of Application)(query, parameters))
        End Using
    End Function

    Private Async Function GetAllDataAsync() As Task(Of IEnumerable(Of Application)) Implements IApplication_Repository.GetAllDataAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()


            Dim result = Await Task.FromResult(db.QueryAsync(Of Application)($"SELECT * FROM Application"))

            If result Is Nothing Then

                Throw New ArgumentNullException(NameOf(result), "No data")

            End If

            Return Await result

        End Using
    End Function

End Class
