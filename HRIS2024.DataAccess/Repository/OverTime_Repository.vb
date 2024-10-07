Imports System.Data.SqlClient
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility

Public Class OverTime_Repository
    Implements IInformation_Repository(Of OverTime)

    Public Async Function GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of OverTime)) Implements IInformation_Repository(Of OverTime).GetDataByIdAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If ApplicationId Is String.Empty Then
                Throw New ArgumentNullException(NameOf(OverTime))
            End If

            Dim queryString = $"SELECT * FROM Information_OverTime WHERE ApplicationID = @ApplicationID"
            Dim parameter As New DynamicParameters
            parameter.Add("@ApplicationID", ApplicationId)

            Return (Await db.QueryAsync(Of OverTime)(queryString, parameter))

        End Using
    End Function

End Class
