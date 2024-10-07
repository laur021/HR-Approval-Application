Imports System.Data.SqlClient
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility
Public Class Leave_Repository
    Implements IInformation_Repository(Of Leave)
    Public Async Function GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of Leave)) Implements IInformation_Repository(Of Leave).GetDataByIdAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If ApplicationId Is String.Empty Then
                Throw New ArgumentNullException(NameOf(Leave))
            End If

            Dim queryString = $"SELECT * FROM Information_Leave WHERE ApplicationID = @ApplicationID"
            Dim parameter As New DynamicParameters
            parameter.Add("@ApplicationID", ApplicationId)

            Return (Await db.QueryAsync(Of Leave)(queryString, parameter))

        End Using
    End Function

End Class
