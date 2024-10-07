Imports System.Data.SqlClient
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility

Public Class ApplicationRecord_Repository
    Implements IApplicationRecord_Repository

    Public Async Function GetAllDataAsync() As Task(Of IEnumerable(Of ApplicationRecord)) Implements IApplicationRecord_Repository.GetAllDataAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()
            Return Await Await Task.FromResult(db.QueryAsync(Of ApplicationRecord)($"SELECT * FROM View_ApplicationRecord"))
        End Using
    End Function

    Public Async Function GetSingleDataAsync(ApplicationId As String) As Task(Of ApplicationRecord) Implements IApplicationRecord_Repository.GetSingleDataAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()
            Dim query As String = "SELECT * FROM View_ApplicationRecord WHERE ApplicationID = @ApplicationID"
            Dim parameters As New DynamicParameters
            parameters.Add("@ApplicationID", ApplicationId)
            Return Await Await Task.FromResult(db.QuerySingleAsync(Of ApplicationRecord)(query))
        End Using
    End Function

    Public Async Function GetAllDataCountAsync() As Task(Of Integer) Implements IApplicationRecord_Repository.GetAllDataCountAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()
            Return Await Await Task.FromResult(db.ExecuteScalarAsync(Of Integer)("SELECT COUNT(*) FROM View_ApplicationRecord"))
        End Using
    End Function

End Class

