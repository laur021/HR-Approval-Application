Imports System.Data.SqlClient
Imports Dapper
Imports HRIS2024.Models
Imports HRIS2024.Utility

Public Class Infraction_Repository
    Implements IInformation_Repository(Of Infraction)
    Private Async Function IRepository_GetDataByIdAsync(ApplicationId As String) As Task(Of List(Of Infraction)) Implements IInformation_Repository(Of Infraction).GetDataByIdAsync
        Using db = New SqlConnection(DbSqlConnection.GetConnectionStringHRIS)
            Await db.OpenAsync()

            If ApplicationId Is String.Empty Then
                Throw New ArgumentNullException(NameOf(Infraction))
            End If

            Dim queryString = $"SELECT * FROM Information_Infraction WHERE ApplicationID = @ApplicationID"
            Dim parameter As New DynamicParameters
            parameter.Add("@ApplicationID", ApplicationId)

            Return (Await db.QueryAsync(Of Infraction)(queryString, parameter))

        End Using
    End Function
End Class
